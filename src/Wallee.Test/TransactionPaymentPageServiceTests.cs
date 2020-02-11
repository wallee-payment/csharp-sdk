using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Wallee.Model;
using Wallee.Service;
using Wallee.Client;

namespace Wallee.Test
{
    /// <summary>
    ///  Class for testing TransactionPaymentPageService
    /// </summary>
    /// <remarks>
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TransactionPaymentPageServiceTests
    {
        private TransactionService transactionService;
        private TransactionPaymentPageService transactionPaymentPageService;
        private TransactionCreate transactionCreate;
        private Configuration configuration;
        private long spaceId;
        private string applicationUserID;
        private string authenticationKey;
        private Transaction transaction;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            this.spaceId = 405;
            this.authenticationKey = "FKrO76r5VwJtBrqZawBspljbBNOxp5veKQQkOnZxucQ=";
            this.applicationUserID = "512";
            this.configuration = new Configuration(this.applicationUserID, this.authenticationKey);
            this.transactionPaymentPageService = new TransactionPaymentPageService(configuration);
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
                this.transaction = this.transactionService.Create(
                    this.spaceId,
                    this.transactionCreate
                );
            } catch (ApiException e){
                Assert.Fail("Failed to create transaction. Reason: " + e.Message + " Details: " + e.ErrorContent);
            }

        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an transactionPaymentPageService of TransactionPaymentPageService
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<TransactionPaymentPageService>(this.transactionPaymentPageService, "transactionPaymentPageService is a TransactionPaymentPageService");
        }

        
        /// <summary>
        /// Test PaymentPageUrl
        /// </summary>
        [Test]
        public void PaymentPageUrlTest()
        {
            var response = this.transactionPaymentPageService.PaymentPageUrl(this.spaceId, this.transaction.Id);
            Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}
