using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using NUnit.Framework;
using Wallee.Model;

namespace Wallee.SerializationRoundTrip.Tests;

[TestFixture]
public class ChargeAttemptSerializationTests
{
    // Synthetic API response; these values do not identify a real transaction.
    private const string ApiResponse = """
        {
          "id": 101,
          "createdOn": "2025-01-15T12:34:56Z",
          "succeededOn": "2025-01-15T12:34:57Z",
          "linkedSpaceId": 601,
          "linkedTransaction": 701,
          "state": "SUCCESSFUL",
          "completionBehavior": "COMPLETE_IMMEDIATELY",
          "environment": "PRODUCTION",
          "customersPresence": "PHYSICAL_PRESENT",
          "charge": { "id": 201 },
          "terminal": { "id": 301 },
          "invocation": { "id": 401 },
          "connectorConfiguration": { "id": 501 }
        }
        """;

    [TestCase("PHYSICAL_PRESENT", true)]
    [TestCase("VIRTUAL_PRESENT", false)]
    public void DefaultSerializationPreservesResponseFields(string presence, bool hasTerminal)
    {
        var attempt = ReadAttempt(presence, hasTerminal);

        // These assertions distinguish information lost while reading from information
        // lost when an already populated model is written to the export file.
        Assert.Multiple(() =>
        {
            Assert.That(Convert.ToInt64(attempt.Id), Is.EqualTo(101));
            Assert.That(Convert.ToDateTime(attempt.CreatedOn).Year, Is.EqualTo(2025));
            Assert.That(Convert.ToInt64(attempt.Charge.Id), Is.EqualTo(201));
            Assert.That(Convert.ToInt64(attempt.Invocation.Id), Is.EqualTo(401));
        });

        var json = JsonConvert.SerializeObject(attempt);
        TestContext.WriteLine($"Serialized response: {json}");
        AssertExportFields(JObject.Parse(json), presence, hasTerminal);
    }

    [Test]
    public void ExportOnlyResolverPreservesResponseFields()
    {
        var attempt = ReadAttempt("PHYSICAL_PRESENT", hasTerminal: true);
        var settings = new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                IgnoreShouldSerializeMembers = true
            }
        };

        var json = JsonConvert.SerializeObject(attempt, settings);
        TestContext.WriteLine($"Serialized response using export-only settings: {json}");
        AssertExportFields(JObject.Parse(json), "PHYSICAL_PRESENT", hasTerminal: true);
    }

    private static ChargeAttempt ReadAttempt(string presence, bool hasTerminal)
    {
        var input = JObject.Parse(ApiResponse);
        input["customersPresence"] = presence;
        if (!hasTerminal)
        {
            input.Remove("terminal");
        }

        return JsonConvert.DeserializeObject<ChargeAttempt>(input.ToString(Formatting.None))
            ?? throw new InvalidOperationException("The API response did not deserialize.");
    }

    private static void AssertExportFields(JObject json, string presence, bool hasTerminal)
    {
        Assert.Multiple(() =>
        {
            Assert.That((long?)json["id"], Is.EqualTo(101), "charge-attempt ID");
            Assert.That((DateTime?)json["createdOn"], Is.EqualTo(new DateTime(2025, 1, 15, 12, 34, 56, DateTimeKind.Utc)), "creation timestamp");
            Assert.That((DateTime?)json["succeededOn"], Is.EqualTo(new DateTime(2025, 1, 15, 12, 34, 57, DateTimeKind.Utc)), "success timestamp");
            Assert.That((long?)json["linkedSpaceId"], Is.EqualTo(601), "linked space ID");
            Assert.That((long?)json["linkedTransaction"], Is.EqualTo(701), "linked transaction ID");
            Assert.That((string?)json["state"], Is.EqualTo("SUCCESSFUL"), "state");
            Assert.That((string?)json["customersPresence"], Is.EqualTo(presence), "customer presence");
            Assert.That((long?)json.SelectToken("charge.id"), Is.EqualTo(201), "charge ID");
            Assert.That((long?)json.SelectToken("invocation.id"), Is.EqualTo(401), "invocation ID");
            Assert.That((long?)json.SelectToken("connectorConfiguration.id"), Is.EqualTo(501), "connector configuration ID");
            if (hasTerminal)
            {
                Assert.That((long?)json.SelectToken("terminal.id"), Is.EqualTo(301), "terminal ID");
            }
            else
            {
                Assert.That(json["terminal"], Is.Null, "virtual charge attempts have no terminal in this sample");
            }
        });
    }
}
