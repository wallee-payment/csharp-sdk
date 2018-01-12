[![Build Status](https://travis-ci.org/wallee-payment/wallee-csharp-sdk.svg?branch=master)](https://travis-ci.org/wallee-payment/wallee-csharp-sdk) [![NuGet Status](https://buildstats.info/nuget/Customweb.Wallee)](https://www.nuget.org/packages/Customweb.Wallee/1.0.4)

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

namespace WalleeExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Space ID.
            const long spaceId = 1;

            // Create API service configuration.
            Configuration configuration = Configuration.Builder()
	               .ApplicationUserID("application-user-id")
	               .AuthenticationKey("application-user-authentication-key")
	               .Build();

            // Create token service instance.
            var tokenService = new TokenService(configuration);

            // Create token.
            TokenCreate tokenCreate = new TokenCreate()
            {
                CustomerEmailAddress = "test@customweb.com",
                TokenReference = "test@customweb.com",
                CustomerId = new Random().Next().ToString(),
                ExternalId = Guid.NewGuid().ToString(),
                EnabledForOneClickPayment = true
            };

            try
            {
                // Send create request.
                var token = tokenService.Create(spaceId, tokenCreate);
            }
            catch(ApiException e)
            {
                throw new Exception($"Failed to create token in Space {spaceId}.", e);
            }
        }
    }
}
```

## License

Please see the [license file](https://github.com/wallee-payment/wallee-csharp-sdk/blob/master/LICENSE.txt) for more information.
