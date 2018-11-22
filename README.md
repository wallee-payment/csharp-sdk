[![Build Status](https://travis-ci.org/wallee-payment/wallee-csharp-sdk.svg?branch=master)](https://travis-ci.org/wallee-payment/wallee-csharp-sdk) [![NuGet Status](https://buildstats.info/nuget/Customweb.Wallee)](https://www.nuget.org/packages/Customweb.Wallee/1.0.5)

# wallee-csharp-sdk
The C# SDK allows an easy integration of wallee into C# and .NET applications.

To Install from the Nuget Package Manager Console:

	PM> Install-Package Customweb.Wallee

## Documentation
https://app-wallee.com/doc/api/web-service

## Usage

### Example

```csharp
using System;

using Customweb.Wallee.Model;
using Customweb.Wallee.Client;
using Customweb.Wallee.Service;
using System.Collections.Generic;

namespace WalleeExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Configuration. 
            const long spaceId = 405;
            const string userId = "512";  
            const string secret = "FKrO76r5VwJtBrqZawBspljbBNOxp5veKQQkOnZxucQ=";
           
            Configuration configuration = Configuration.Builder()
                .ApplicationUserID(userId)
                .AuthenticationKey(secret)
                .Build();

            // Create API service instances.
            var tokenService = new TokenService(configuration);
            var transactionService = new TransactionService(configuration);

            // Optionally create token for recurring payments.
            var tokenCreate = new TokenCreate(ExternalId: Guid.NewGuid().ToString())
            {
                CustomerEmailAddress = "spam@customweb.com",
                TokenReference = "spam@customweb.com",
                CustomerId = new Random().Next().ToString(),
                EnabledForOneClickPayment = true
            };

            var token = tokenService.Create(spaceId, tokenCreate);

            // Create transaction.
            var lineItem = new LineItemCreate
                (
                 Name: "Red T-Shirt",
                 Sku: "red-t-shirt-1",
                 UniqueId: "2130",
                 Quantity: 1,
                 Type: LineItemType.PRODUCT,
                 AmountIncludingTax: 22.91m
                );

            var transactionCreate = new TransactionCreate
            {
                Currency = "EUR",
                LineItems = new List<LineItemCreate>() { lineItem },
                AutoConfirmationEnabled = true,
                Token = token.Id
            };

            // Send create transaction request.
            var transaction = transactionService.Create(spaceId, transactionCreate);

            // Create payment page URL.
            var redirectionUrl = transactionService.BuildPaymentPageUrl(spaceId, transaction.Id);
            System.Console.WriteLine("Payment URL: " + redirectionUrl);

        }
    }
}
```

## License

Please see the [license file](https://github.com/wallee-payment/wallee-csharp-sdk/blob/master/LICENSE.txt) for more information.
