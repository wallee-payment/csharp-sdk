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
            billingAddress.EmailAddress = "test@wallee.com";

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
            Assert.IsTrue(paymentPageUrl.Contains("http"));
        }
    }
}
