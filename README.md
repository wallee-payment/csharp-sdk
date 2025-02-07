# wallee C# Library

The wallee C# library wraps around the wallee API. This library facilitates your interaction with various services such as transactions, accounts, and subscriptions.


## Documentation

[wallee Web Service API](https://app-wallee.com/doc/api/web-service)


<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 8.0 or later

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 112.1.0
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.3
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 2.0.1
- [BouncyCastle.Cryptography](https://www.nuget.org/packages/BouncyCastle.Cryptography/) - 2.0.0

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package BouncyCastle.Cryptography
```


<a name="installation"></a>
## Installation
```
# Package Manager
Install-Package Wallee -Version 8.1.0
# .NET CLI
dotnet add package Wallee --version 8.1.0
# Paket CLI
paket add Wallee --version 8.1.0
# PackageReference
<PackageReference Include="Wallee" Version="8.1.0" />
```

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Wallee.Service;
using Wallee.Client;
using Wallee.Model;
```

<a name="getting-started"></a>
## Getting Started
Instantiate a configuration like so:
```csharp
new Configuration(this.applicationUserID, this.authenticationKey)
```
Or if you want to customize the RestSharp client that's being used underneath (e.g. set the proxy), use the overloaded constructor:
```csharp
new Configuration(this.applicationUserID, this.authenticationKey, new RestClientOptions()
{
    Proxy = new WebProxy("http://example.com")
});
```

Request Timeout (in seconds) is customizable separately via the ```Configuration.TimeOut``` property.

```csharp
using System;
using System.Configuration;
using System.Collections.Generic;

using NUnit.Framework;

using Wallee.Model;
using Wallee.Service;
using Wallee.Client;

namespace Wallee.Test
{
    /// <summary>
    ///  Class for testing TransactionService.
    /// </summary>
    [TestFixture]
    public class TransactionPaymentPageServiceTest
    {
        private TransactionService transactionService;
        private TransactionCreate transactionCreate;
        private Configuration configuration;
        private long spaceId;
        private string applicationUserID;
        private string authenticationKey;
        private ApiResponse<Transaction> transaction;

        /// <summary>
        /// Setup before each unit test.
        /// </summary>
        [SetUp]
        public void SetUpTest()
        {
            this.spaceId = 405;
            this.authenticationKey = "FKrO76r5VwJtBrqZawBspljbBNOxp5veKQQkOnZxucQ=";
            this.applicationUserID = "512";
            this.configuration = new Configuration(this.applicationUserID, this.authenticationKey);
            this.transactionService = new TransactionService(configuration);
            this.CreateTransaction();
        }

        private void CreateTransaction() {

            AddressCreate billingAddress = new AddressCreate();
            billingAddress.Salutation = "Ms";
            billingAddress.GivenName = "Good";
            billingAddress.FamilyName = "Customer";
            billingAddress.Gender = Gender.FEMALE;
            billingAddress.Country = "CH";
            billingAddress.City = "Winterthur";
            billingAddress.PostCode = "8400";
            billingAddress.DateOfBirth = new DateTime(1988, 4, 19);
            billingAddress.OrganizationName = "Test GmbH";
            billingAddress.MobilePhoneNumber = "+41791234567";
            billingAddress.EmailAddress = "test@example.com";

            LineItemCreate lineItem1 = new LineItemCreate(
                name: "Item 1",
                uniqueId: "unique-id-item-1",
                type: LineItemType.PRODUCT,
                quantity: 1,
                amountIncludingTax: (decimal) 67.47
            );
            lineItem1.Sku = "item-1";
            lineItem1.ShippingRequired = true;

            this.transactionCreate = new TransactionCreate(new List<LineItemCreate>() { lineItem1 });
            this.transactionCreate.BillingAddress = billingAddress;
            this.transactionCreate.ShippingAddress = billingAddress;
            this.transactionCreate.CustomerEmailAddress = billingAddress.EmailAddress;
            this.transactionCreate.CustomerId = "cutomer-x";
            this.transactionCreate.MerchantReference = Guid.NewGuid().ToString();
            this.transactionCreate.InvoiceMerchantReference = "order-1";
            this.transactionCreate.SuccessUrl = "http://localhost/success?orderId=1";
            this.transactionCreate.FailedUrl = "http://localhost/failed?orderId=1";
            this.transactionCreate.ShippingMethod = "Test Shipping";
            this.transactionCreate.ChargeRetryEnabled = false;
            this.transactionCreate.AllowedPaymentMethodConfigurations = new List<long?>() { 8656L };
            this.transactionCreate.Language = "en-US";
            this.transactionCreate.Currency = "CHF";

            try
            {
                this.transaction = this.transactionService.CreateWithHttpInfo(
                    this.spaceId,
                    this.transactionCreate
                );
            } catch (ApiException e){
                Assert.Fail("Failed to create transaction. Reason: " + e.Message + " Details: " + e.ErrorContent);
            }

        }

        /// <summary>
        /// Test transaction creation.
        /// </summary>
        [Test]
        public void TestPaymentPageUrl() {
        // If needed configure configure a custom timeout. (Default is 25 seconds)
        this.configuration.Timeout = 30;
        TransactionPaymentPageService transactionPaymentPageService = new TransactionPaymentPageService(this.configuration);
            String paymentPageUrl     = null;
            try {
                paymentPageUrl = transactionPaymentPageService.PaymentPageUrl(this.spaceId, this.transaction.Data.Id);
            } catch (ApiException e) {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine(paymentPageUrl);
            Assert.IsTrue(paymentPageUrl.Contains("http"));
        }
    }
}
```
### Integrating Webhook Payload Signing Mechanism into webhook callback handler

The HTTP request which is sent for a state change of an entity now includes an additional field `state`, which provides information about the update of the monitored entity's state. This enhancement is a result of the implementation of our webhook encryption mechanism.

Payload field `state` provides direct information about the state update of the entity, making additional API calls to retrieve the entity state redundant.

#### ⚠️ Warning: Generic Pseudocode

> **The provided pseudocode is intentionally generic and serves to illustrate the process of enhancing your API to leverage webhook payload signing. It is not a complete implementation.**
>
> Please ensure that you adapt and extend this code to meet the specific needs of your application, including appropriate security measures and error handling.
For a detailed webhook payload signing mechanism understanding we highly recommend referring to our comprehensive
[Webhook Payload Signing Documentation](https://app-wallee.com/doc/webhooks#_webhook_payload_signing_mechanism).

```csharp
...
    [HttpPost("callback")]
    public IActionResult HandleWebhook([FromBody] string requestPayload)
    {
        var signature = Request.Headers["x-signature"];

        if (string.IsNullOrEmpty(signature))
        {
            // Make additional API call to retrieve the entity state
            // ...
        }
        else
        {
            if (webhookEncryptionService().isContentValid(signature, requestPayload))
            {
                // Parse requestPayload to extract 'state' value
                // Process entity's state change
                // ...
            }
        }

        // Process the received webhook data
        // ...
    }
...
```


## License

Please see the [license file](https://github.com/wallee-payment/csharp-sdk/blob/master/LICENSE) for more information.
