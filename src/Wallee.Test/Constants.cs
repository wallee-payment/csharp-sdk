using System.Collections.Generic;
using Wallee.Client;
using Wallee.Model;

namespace Wallee.Test
{
    public static class Constants
    {
        private static readonly string ApplicationUserId = "512";
        private static readonly string AuthenticationKey = "FKrO76r5VwJtBrqZawBspljbBNOxp5veKQQkOnZxucQ=";
        public static readonly Configuration Config = new Configuration(ApplicationUserId, AuthenticationKey);

        public static readonly long SpaceId = 405;
        public static readonly long TestCardPaymentMethodConfigurationId = 1352;
        public static readonly long TestIsrInvoicePaymentMethodConfigurationId = 8656;
        public static readonly string TestCustomerId = "7311742";

        public static readonly AuthenticatedCardDataCreate FakeCardData =
            new AuthenticatedCardDataCreate("4111111111111111")
            {
                ExpiryDate = "2026-12"
            };

        // <summary>
        // Get transaction payload
        // <summary>
        public static TransactionCreate GetTransactionCreate()
        {
            var lineItem1 = new LineItemCreate(
                name: "Red T-Shirt",
                uniqueId: "5412",
                type: LineItemType.PRODUCT,
                quantity: 1,
                amountIncludingTax: 88.95m
            )
            {
                Sku = "red-t-shirt-123"
            };

            var address = new AddressCreate
            {
                City = "Winterthur",
                Country = "CH",
                EmailAddress = "test@example.com",
                FamilyName = "Customer",
                GivenName = "Good",
                Postcode = "8400",
                PostalState = "ZH",
                OrganizationName = "Test GmbH",
                MobilePhoneNumber = "+41791234567",
                Salutation = "Ms"
            };

            return new TransactionCreate(new List<LineItemCreate>() { lineItem1 })
            {
                Currency = "CHF",
                AutoConfirmationEnabled = true,
                BillingAddress = address,
                ShippingAddress = address,
                Language = "en-GB"
            };
        }
    }
}