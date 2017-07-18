using System;
using System.Collections;
using System.Collections.Generic;

using NUnit.Framework;

using Customweb.Wallee.Model;
using Customweb.Wallee.Client;
using Customweb.Wallee.Service;

namespace Customweb.Wallee.Test
{
    /// <summary>
    ///  Class for testing TransactionService.
    /// </summary>
    [TestFixture]
    public class TransactionServiceTest
    {
        private TransactionService transactionService;

        private long spaceId;

        /// <summary>
        /// Setup before each unit test.
        /// </summary>
        [SetUp]
        public void SetUpTest()
        {
            spaceId = long.Parse(Environment.GetEnvironmentVariable("APPLICATION_SPACE_ID"));

            var authenticationKey = Environment.GetEnvironmentVariable("APPLICATION_AUTHENTICATION_KEY");
            var applicationUserID = Environment.GetEnvironmentVariable("APPLICATION_USER_ID");
            var basePath = Environment.GetEnvironmentVariable("API_URL_BASE_PATH");

            Configuration configuration = Configuration.Builder()
                                      .AuthenticationKey(authenticationKey)
                                      .ApplicationUserID(applicationUserID)
                                      .BasePath(basePath)
                                      .Build();

            transactionService = new TransactionService(configuration);
        }

        /// <summary>
        /// Test transaction creation.
        /// </summary>
        [Test]
        public void TransactionCreateTest()
        {
            var transaction = new TransactionCreate(CustomersPresence: CustomersPresence.VIRTUAL_PRESENT)
            {
                CustomerEmailAddress = "test@wallee.com",
                CustomerId = "customer-1",
                MerchantReference = Guid.NewGuid().ToString(),
                InvoiceMerchantReference = "order-1",
                SuccessUrl = "http://localhost/success?orderId=1",
                FailedUrl = "http://localhost/failed?orderId=1",
                ShippingMethod = "Test Shipping",
                ChargeRetryEnabled = true,
                Language = "en-US",
                Currency = "EUR",
                BillingAddress = new AddressCreate(Salutation: "Mr",
                                                   GivenName: "John",
                                                   FamilyName: "Doe",
                                                   Gender: Gender.MALE,
                                                   Country: "CH",
                                                   City: "Winterthur",
                                                   PostCode: "8400",
                                                   DateOfBirth: new DateTime(1988, 4, 19),
                                                   OrganizationName: "Test GmbH",
                                                   MobilePhoneNumber: "+41791234567",
                                                   PhoneNumber: "+41011234567",
                                                   EmailAddress: "test@wallee.com"),

                LineItems = new List<LineItemCreate>() {
                    new LineItemCreate(Sku: "sku-1",
                                       Name: "Item 1",
                                       UniqueId: "unique-id-item-1",
                                       Type: LineItemType.PRODUCT,
                                       Quantity: 1,
                                       ShippingRequired: true,
                                       AmountIncludingTax: 34.90m,
                                       Taxes: new List<TaxCreate>(){
                                            new TaxCreate(Title: "VAT", Rate: 8)
                                        }),
                    new LineItemCreate(Sku: "test-shipping",
                                       Name: "Test Shipping",
                                       UniqueId: "unique-id-test-shipping",
                                       Type: LineItemType.SHIPPING,
                                       Quantity: 1,
                                       ShippingRequired: true,
                                       AmountIncludingTax: 4.51m,
                                       Taxes: new List<TaxCreate>(){
                                            new TaxCreate(Title: "VAT", Rate: 8)
                                        })
                }
            };


            var response = transactionService.CreateWithHttpInfo(spaceId, transaction);

            Assert.AreEqual(200, response.StatusCode);
            Assert.AreEqual(spaceId, response.Data.LinkedSpaceId);
            Assert.AreEqual(39.41m, response.Data.AuthorizationAmount);
        }
    }
}
