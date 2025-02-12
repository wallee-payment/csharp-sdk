using System;
using System.IO;
using Newtonsoft.Json;
using NUnit.Framework;
using Wallee.Model;
using Wallee.Util;

namespace Wallee.Test;

/// <summary>
/// WebhookEncryptionService tests
/// </summary>
[TestFixture]
public class WebhookEncryptionTests
{
    private const string SignatureAlgorithm = "SHA256withECDSA";

    private const string ContentToVerify =
        """
        {"entityId":11,"eventId":35,"listenerEntityId":1472041829003,"listenerEntityTechnicalName":"Transaction","spaceId":1,"state":"PROCESSING","timestamp":"2023-12-19T13:43:35+0000","webhookListenerId":2}
        """;

    private const string ValidContentSignature =
        "MEYCIQCTzbMrMsOAC6T57T9kQTb1iGZVg2R7n6pY9A4ML4P31gIhAIOoav8cG8x0jpRWQztqSJIC8gXWKq+4DuENEySvmMYf";

    private const string ValidEncodedPublicKey =
        "MFkwEwYHKoZIzj0CAQYIKoZIzj0DAQcDQgAEdWq7ZBGsjUzhBO3e6mzUBLpjpV3TQw1bL1rk3ocjn5C5qne7TY0OBBhiWgaPtWlvUcqASz903vtfeSTQma+SBA==";

    private static WebhookEncryptionPublicKey _validPublicKey;

    [OneTimeSetUp]
    public void GlobalSetup()
    {
        _validPublicKey = GetPublicKeyAsApiObject(ValidEncodedPublicKey);
    }

    /// <summary>
    /// ValidationShouldPassForValidContentSignatureAndKey()
    /// Should validate correct content signature and key.
    /// </summary>
    [Test]
    public void ValidationShouldPassForValidContentSignatureAndKey()
    {
        var isContentValid =
            EncryptionUtil.IsContentValid(ContentToVerify, ValidContentSignature, _validPublicKey, SignatureAlgorithm);
        Assert.IsTrue(isContentValid, "Valid public key, signature and content must fit each other.");
    }

    /// <summary>
    /// ValidationShouldFailForBadContent()
    /// Should fail validation for invalid content.
    /// </summary>
    [Test]
    public void ValidationShouldFailForBadContent()
    {
        var isContentValid = EncryptionUtil.IsContentValid("ModifiedContent", ValidContentSignature, _validPublicKey,
            SignatureAlgorithm);
        Assert.IsFalse(isContentValid, "Invalid content, should fail validation.");
    }

    /// <summary>
    /// ValidationShouldFailForBadSignatureFormat()
    /// Should fail validation for bad signature format.
    /// </summary>
    [Test]
    public void ValidationShouldFailForBadSignatureFormat()
    {
        var isContentValid = EncryptionUtil.IsContentValid(ContentToVerify, "InvalidModifiedSignature",
            _validPublicKey, SignatureAlgorithm);
        Assert.IsFalse(isContentValid, "Invalid signature, should fail validation.");
    }

    /// <summary>
    /// ValidationShouldFailForBadSignatureBase64Format()
    /// Should fail validation for the content signature is not a valid BASE-64 string.
    /// </summary>
    [Test]
    public void ValidationShouldFailForBadSignatureBase64Format()
    {
        try
        {
            EncryptionUtil.IsContentValid(ContentToVerify,
                "MEYCIQCTzbMrMsOAC6T57T9kQTb1iGZVg2R7n6pY9A4ML4P31gIhAIOoav8cG8x0jpRWQztqSJIC8gXWKq",
                _validPublicKey, SignatureAlgorithm);
            Assert.Fail("Expected InvalidDataException, but no exception was thrown.");
        }
        catch (InvalidDataException ex)
        {
            Assert.That(ex.Message, Does.Contain("Content signature is not a valid BASE-64 string"),
                "Invalid public key should fail validation. Content signature is not a valid BASE-64 string."
            );
        }
    }

    /// <summary>
    /// ValidationShouldFailForBadPublicKeyFormat()
    /// Should fail validation for bad public key format.
    /// </summary>
    [Test]
    public void ValidationShouldFailForBadPublicKeyFormat()
    {
        try
        {
            EncryptionUtil.IsContentValid(ContentToVerify, ValidContentSignature,
                GetPublicKeyAsApiObject("InvalidModifiedPublicKey"), SignatureAlgorithm);
            Assert.Fail("Expected IOException, but no exception was thrown.");
        }
        catch (IOException ex)
        {
            Assert.That(ex.Message,
                Does.Contain("unknown tag 2 encountered"), "Invalid public key should fail validation"
            );
        }
    }

    /// <summary>
    /// validationShouldFailForBadPublicKeyBase64Format()
    /// Should fail validation for the public key is not a valid BASE-64 string.
    /// </summary>
    [Test]
    public void ValidationShouldFailForBadPublicKeyBase64Format()
    {
        try
        {
            EncryptionUtil.IsContentValid(ContentToVerify,
                ValidContentSignature,
                GetPublicKeyAsApiObject(
                    "MFkwEwYHKoZIzj0CAQYIKoZIzj0DAQcDQgAEdWq7ZBGsjUzhBO3e6mzUBLpjpV3TQw1bL1rk3ocjn5C5qne7TY0OBBhiWgaPtWlvUcqASz903vtfeSTQm"),
                SignatureAlgorithm);
            Assert.Fail("Expected FormatException, but no exception was thrown.");
        }
        catch (FormatException ex)
        {
            Assert.That(ex.Message,
                Does.Contain("The input is not a valid Base-64 string as it contains a non-base 64 character"),
                "Invalid public key should fail validation"
            );
        }
    }

    // Imitate we got key object via API call.
    private static WebhookEncryptionPublicKey GetPublicKeyAsApiObject(string encodedPublicKey)
    {
        var json = "{\n" +
                   "    \"id\": \"123456890\",\n" +
                   "    \"publicKey\": \"" + encodedPublicKey + "\"\n" +
                   "}";
        try
        {
            return JsonConvert.DeserializeObject<WebhookEncryptionPublicKey>(json);
        }
        catch (JsonException ex)
        {
            throw new Exception("Error deserializing JSON", ex);
        }
    }
}