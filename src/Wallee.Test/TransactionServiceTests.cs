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
    ///  Class for testing TransactionService
    /// </summary>
    /// <remarks>
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TransactionServiceTests
    {
        private TransactionService transactionService;
        private TransactionCreate transactionCreate;
        private Transaction transaction;
        private Configuration configuration;
        private long spaceId = 405;
        private string applicationUserID = "512";
        private string authenticationKey = "FKrO76r5VwJtBrqZawBspljbBNOxp5veKQQkOnZxucQ=";

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            this.configuration = new Configuration(this.applicationUserID, this.authenticationKey);
            this.transactionService = new TransactionService(this.configuration);
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
        /// Test an transactionService of TransactionService
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TransactionService
            Assert.IsInstanceOf<TransactionService>(transactionService, "transactionService is a TransactionService");
        }

        
        /// <summary>
        /// Test Confirm
        /// </summary>
        [Test]
        public void ConfirmTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? spaceId = null;
            //TransactionPending transactionModel = null;
            //var response = transactionService.Confirm(spaceId, transactionModel);
            //Assert.IsInstanceOf<Transaction> (response, "response is Transaction");
        }
        
        /// <summary>
        /// Test Count
        /// </summary>
        [Test]
        public void CountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? spaceId = null;
            //EntityQueryFilter filter = null;
            //var response = transactionService.Count(spaceId, filter);
            //Assert.IsInstanceOf<long?> (response, "response is long?");
        }
        
        /// <summary>
        /// Test Create
        /// </summary>
        [Test]
        public void CreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? spaceId = null;
            //TransactionCreate transaction = null;
            //var response = transactionService.Create(spaceId, transaction);
            Assert.IsInstanceOf<Transaction> (this.transaction, "response is Transaction");
        }
        
        /// <summary>
        /// Test CreateTransactionCredentials
        /// </summary>
        [Test]
        public void CreateTransactionCredentialsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? spaceId = null;
            //long? id = null;
            //var response = transactionService.CreateTransactionCredentials(spaceId, id);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test DeleteOneClickTokenWithCredentials
        /// </summary>
        [Test]
        public void DeleteOneClickTokenWithCredentialsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string credentials = null;
            //long? tokenId = null;
            //transactionService.DeleteOneClickTokenWithCredentials(credentials, tokenId);
            
        }
        
        /// <summary>
        /// Test Export
        /// </summary>
        [Test]
        public void ExportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? spaceId = null;
            //EntityExportRequest request = null;
            //var response = transactionService.Export(spaceId, request);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test FetchOneClickTokensWithCredentials
        /// </summary>
        [Test]
        public void FetchOneClickTokensWithCredentialsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string credentials = null;
            //var response = transactionService.FetchOneClickTokensWithCredentials(credentials);
            //Assert.IsInstanceOf<List<TokenVersion>> (response, "response is List<TokenVersion>");
        }
        
        /// <summary>
        /// Test FetchPossiblePaymentMethods
        /// </summary>
        [Test]
        public void FetchPossiblePaymentMethodsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? spaceId = null;
            //long? id = null;
            //var response = transactionService.FetchPossiblePaymentMethods(spaceId, id);
            //Assert.IsInstanceOf<List<PaymentMethodConfiguration>> (response, "response is List<PaymentMethodConfiguration>");
        }
        
        /// <summary>
        /// Test FetchPossiblePaymentMethodsWithCredentials
        /// </summary>
        [Test]
        public void FetchPossiblePaymentMethodsWithCredentialsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string credentials = null;
            //var response = transactionService.FetchPossiblePaymentMethodsWithCredentials(credentials);
            //Assert.IsInstanceOf<List<PaymentMethodConfiguration>> (response, "response is List<PaymentMethodConfiguration>");
        }
        
        /// <summary>
        /// Test GetInvoiceDocument
        /// </summary>
        [Test]
        public void GetInvoiceDocumentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? spaceId = null;
            //long? id = null;
            //var response = transactionService.GetInvoiceDocument(spaceId, id);
            //Assert.IsInstanceOf<RenderedDocument> (response, "response is RenderedDocument");
        }
        
        /// <summary>
        /// Test GetLatestTransactionLineItemVersion
        /// </summary>
        [Test]
        public void GetLatestTransactionLineItemVersionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? spaceId = null;
            //long? id = null;
            //var response = transactionService.GetLatestTransactionLineItemVersion(spaceId, id);
            //Assert.IsInstanceOf<TransactionLineItemVersion> (response, "response is TransactionLineItemVersion");
        }
        
        /// <summary>
        /// Test GetPackingSlip
        /// </summary>
        [Test]
        public void GetPackingSlipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? spaceId = null;
            //long? id = null;
            //var response = transactionService.GetPackingSlip(spaceId, id);
            //Assert.IsInstanceOf<RenderedDocument> (response, "response is RenderedDocument");
        }
        
        /// <summary>
        /// Test ProcessOneClickTokenAndRedirectWithCredentials
        /// </summary>
        [Test]
        public void ProcessOneClickTokenAndRedirectWithCredentialsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string credentials = null;
            //long? tokenId = null;
            //var response = transactionService.ProcessOneClickTokenAndRedirectWithCredentials(credentials, tokenId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test ProcessWithoutUserInteraction
        /// </summary>
        [Test]
        public void ProcessWithoutUserInteractionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? spaceId = null;
            //long? id = null;
            //var response = transactionService.ProcessWithoutUserInteraction(spaceId, id);
            //Assert.IsInstanceOf<Transaction> (response, "response is Transaction");
        }
        
        /// <summary>
        /// Test Read
        /// </summary>
        [Test]
        public void ReadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? spaceId = null;
            //long? id = null;
            //var response = transactionService.Read(spaceId, id);
            //Assert.IsInstanceOf<Transaction> (response, "response is Transaction");
        }
        
        /// <summary>
        /// Test ReadWithCredentials
        /// </summary>
        [Test]
        public void ReadWithCredentialsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string credentials = null;
            //var response = transactionService.ReadWithCredentials(credentials);
            //Assert.IsInstanceOf<Transaction> (response, "response is Transaction");
        }
        
        /// <summary>
        /// Test Search
        /// </summary>
        [Test]
        public void SearchTest()
        {
            EntityQueryFilter entityQueryFilter = new EntityQueryFilter(EntityQueryFilterType.LEAF);
            entityQueryFilter.FieldName = "id";
            entityQueryFilter.Value = this.transaction.Id;
            entityQueryFilter.Operator = CriteriaOperator.EQUALS;

            EntityQuery entityQuery = new EntityQuery();
            entityQuery.Filter = entityQueryFilter;

            var response = transactionService.Search(this.spaceId, entityQuery);

            Assert.IsInstanceOf<List<Transaction>> (response, "response is List<Transaction>");
        }
        
        /// <summary>
        /// Test Update
        /// </summary>
        [Test]
        public void UpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? spaceId = null;
            //TransactionPending entity = null;
            //var response = transactionService.Update(spaceId, entity);
            //Assert.IsInstanceOf<Transaction> (response, "response is Transaction");
        }
        
        /// <summary>
        /// Test UpdateTransactionLineItems
        /// </summary>
        [Test]
        public void UpdateTransactionLineItemsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? spaceId = null;
            //TransactionLineItemUpdateRequest updateRequest = null;
            //var response = transactionService.UpdateTransactionLineItems(spaceId, updateRequest);
            //Assert.IsInstanceOf<TransactionLineItemVersion> (response, "response is TransactionLineItemVersion");
        }
        
    }

}
