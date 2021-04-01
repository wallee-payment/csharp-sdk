[![Build Status](https://travis-ci.org/wallee-payment/csharp-sdk.svg?branch=master)](https://travis-ci.org/wallee-payment/csharp-sdk)

# wallee C# Library

The wallee C# library wraps around the wallee API. This library facilitates your interaction with various services such as transactions, accounts, and subscriptions.


## Documentation

[wallee Web Service API](https://app-wallee.com/doc/api/web-service)


<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.5 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.2.1
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.2
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.6.0

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 106.2.1 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
```
# Package Manager
Install-Package Wallee -Version 2.2.2
# .NET CLI
dotnet add package Wallee --version 2.2.2
# Paket CLI
paket add Wallee --version 2.2.2
# PackageReference
<PackageReference Include="Wallee" Version="2.2.2" />
```

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Wallee.Service;
using Wallee.Client;
using Wallee.Model;
```

<a name="getting-started"></a>
## Getting Started

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

## License

Please see the [license file](https://github.com/wallee-payment/csharp-sdk/blob/master/LICENSE) for more information.
