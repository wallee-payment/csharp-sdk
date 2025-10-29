/**
 * Wallee AG C# SDK
 *
 * This library allows to interact with the Wallee AG payment service.
 *
 * Copyright owner: Wallee AG
 * Website: https://en.wallee.com
 * Developer email: ecosystem-team@wallee.com
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using NUnit.Framework;
using Wallee.Service;
using Wallee.Client;
using Wallee.Model;
using static Wallee.Test.Constants;

namespace Wallee.Test;

/// <summary>
/// Class for testing WebhookListenersService
/// </summary>
[TestFixture]
public class WebhookListenersApiTests
{
    private const string WebhookListenerName = "CSharp Mock UnitTest Webhook Listener";
    private const long WebhookListenerEntityStaticId = 1472041829003;

    // Singleton (single) instance for Configuration. See more: <see cref="Constants.Config"/>
    private readonly Configuration _configuration = Constants.Config;
    private WebhookListenersService _webhookListenersService;
    private WebhookURLsService _webhookUrlsService;

    [OneTimeSetUp]
    public void Setup()
    {
        _webhookListenersService = new WebhookListenersService(_configuration);
        _webhookUrlsService = new WebhookURLsService(_configuration);
    }

    /// <summary>
    /// Search() should create and delete a webhook listener for a given criteria
    /// </summary>
    [Test]
    public void CreateAndDeleteTest()
    {
        // search webhook url
        var webhookUrlsSearchResponse = _webhookUrlsService.GetWebhooksUrlsSearch(
            space: SPACE_ID,
            limit: 1,
            offset: 0,
            order: "id:ASC",
            query: "name:\"Webhook Test URL Listener\"");
        Assert.That(webhookUrlsSearchResponse.Data.Count == 1, message: "Should find one webhook listener");

        // post
        var webhookUrlId = webhookUrlsSearchResponse.Data[0].Id;
        var webhookListenerCreate = _webhookListenersService.PostWebhooksListeners(space: SPACE_ID,
            GetWebhookListenerCreate(webhookUrlId));
        Assert.That(webhookListenerCreate.Name, Is.EqualTo(expected: WebhookListenerName),
            message: "Name should match");
        Assert.That(webhookListenerCreate.State, Is.EqualTo(expected: CreationEntityState.ACTIVE),
            message: "State should match");
        Assert.That(webhookListenerCreate.Entity, Is.EqualTo(expected: WebhookListenerEntityStaticId),
            message: "Entity ID should match");
        Assert.That(webhookListenerCreate.Url.Id, Is.EqualTo(webhookUrlId),
            message: "Webhook URL ID should match");

        // delete and verify
        _webhookListenersService.DeleteWebhooksListenersId(webhookListenerCreate.Id, space: SPACE_ID);
        var webhookListenerGetDeleted =
            _webhookListenersService.GetWebhooksListenersId(webhookListenerCreate.Id, space: SPACE_ID,
                expand: ["url", "group"]);
        Assert.That(webhookListenerGetDeleted.LinkedSpaceId, Is.EqualTo(expected: SPACE_ID),
            message: "Space ID should match");
        Assert.That(webhookListenerGetDeleted.Name, Is.EqualTo(expected: WebhookListenerName),
            message: "Name should match");
        Assert.That(webhookListenerGetDeleted.State, Is.EqualTo(expected: CreationEntityState.DELETED),
            message: "State should match");
    }

    private static WebhookListenerCreate GetWebhookListenerCreate(long webhookUrlId)
    {
        return new WebhookListenerCreate
        {
            Name = WebhookListenerName,
            State = CreationEntityState.ACTIVE,
            Entity = WebhookListenerEntityStaticId,
            Url = webhookUrlId
        };
    }

    /// <summary>
    /// SearchWebhookListenersWithoutCustomTimeoutTest() should find a webhook listeners without custom timeout.
    /// Default timeout of 25 seconds is set instead.
    /// </summary>
    [Test]
    public void SearchWebhookListenersWithoutCustomTimeoutTest()
    {
        var webhookListenerFound = _webhookListenersService.GetWebhooksListenersSearch(
            space: SPACE_ID,
            expand: ["url", "group"],
            limit: 1,
            offset: 0,
            order: "id:DESC",
            query: "name:Test AND state:INACTIVE");

        Assert.That(webhookListenerFound.Data.Count == 1, message: "Should find one webhook listener");
        Assert.That(_configuration.Timeout == 25,
            message: "Configuration timeout should match the default timeout of 25 seconds");

        foreach (var webhookListener in webhookListenerFound.Data)
        {
            Assert.Multiple(() =>
            {
                Assert.That(webhookListener.LinkedSpaceId, Is.EqualTo(expected: SPACE_ID),
                    message: "Space ID should match");
                Assert.That(webhookListener.Name, Is.EqualTo(expected: "Test"), message: "Name should match");
                Assert.That(webhookListener.State, Is.EqualTo(expected: CreationEntityState.INACTIVE),
                    message: "State should match");
            });
        }
    }

    /// <summary>
    /// SearchWebhookListenersWithCustomTimeoutTest() should find a webhook listener with custom timeout: 36 seconds.
    /// </summary>
    [Test]
    public void SearchWebhookListenersWithCustomTimeoutTest()
    {
        /*
         * Configuration.new() creates independent instances and is not considered static.
         * With the new instance of Configuration the timeout can be set not via modifying
         * the global shared state but only for that specific instance of {@link Configuration}.
         */
        var configurationWithCustomTimeout = new Configuration(APPLICATION_USER_ID, AUTHENTICATION_KEY)
        {
            Timeout = 36
        };
        var webhookListenersServiceWithCustomTimeout = new WebhookListenersService(configurationWithCustomTimeout);
        // or set the custom timeout via setter:
        // configurationWithCustomTimeout.Timeout = 36;

        var webhookListenerFound = webhookListenersServiceWithCustomTimeout.GetWebhooksListenersSearch(
            SPACE_ID,
            expand: ["url", "group"],
            limit: 1,
            offset: 0,
            order: "id:DESC",
            query: "name:Test AND state:INACTIVE");

        Assert.That(webhookListenerFound.Data.Count == 1, "Should find one webhook listener");

        foreach (var webhookListener in webhookListenerFound.Data)
        {
            Assert.Multiple(() =>
            {
                Assert.That(webhookListener.LinkedSpaceId, Is.EqualTo(SPACE_ID),
                    "Space ID should match");
                Assert.That(webhookListener.Name, Is.EqualTo("Test"), "Name should match");
                Assert.That(webhookListener.State, Is.EqualTo(CreationEntityState.INACTIVE),
                    "State should match");
            });
        }
    }
}