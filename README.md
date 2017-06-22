# wallee-csharp-sdk
The C# SDK allows an easy integration of wallee into C# and .net applications.

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
            const long spaceId = 288;

            // Create API service configuration.
            Configuration configuration = Configuration.Builder()
	               .ApplicationUserID("362")
	               .AuthenticationKey("hvAjQf/fCjRgHEDMzH7L+lvWWv+v/RzgK1Vyt5i3+I0=")
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

                Console.WriteLine(token.ToJson());
            }
            catch(ApiException e)
            {
                throw new Exception($"Failed to create token in Space {spaceId}.", e);
            }
        }
    }
}
```

### Example Output

```json
{
  "createdOn": "2017-06-22T08:50:48.415Z",
  "customerEmailAddress": "test@customweb.com",
  "customerId": "281398706",
  "enabledForOneClickPayment": true,
  "externalId": "ae55b231-a05b-426f-a449-a2d812116f80",
  "id": 493,
  "linkedSpaceId": 288,
  "state": "ACTIVE",
  "tokenReference": "test@customweb.com",
  "version": 1
}
```

## License

Please see the [license file](https://github.com/wallee-payment/wallee-csharp-sdk/blob/master/LICENSE.txt) for more information.
