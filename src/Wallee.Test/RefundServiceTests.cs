/**
* wallee SDK
*
* This library allows to interact with the wallee payment service.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

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
    ///  Class for testing RefundService
    /// </summary>
    [TestFixture]
    public class RefundServiceTests
    {
        private readonly long SpaceId = 405;
        private readonly string ApplicationUserID = "512";
        private readonly string AuthenticationKey = "FKrO76r5VwJtBrqZawBspljbBNOxp5veKQQkOnZxucQ=";

        private Configuration Configuration;
        private RefundService RefundService;
        private Transaction Transaction;
        private TransactionCompletionService TransactionCompletionService;
        private TransactionCreate TransactionPayload;
        private TransactionService TransactionService;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            if (this.Configuration == null) {
                this.Configuration = new Configuration(this.ApplicationUserID, this.AuthenticationKey);
            }
            if (this.RefundService == null) {
                this.RefundService = new RefundService(this.Configuration);
            }
            if (this.TransactionCompletionService == null){
                this.TransactionCompletionService = new TransactionCompletionService(this.Configuration);
            }
            if (this.TransactionService == null){
                this.TransactionService = new TransactionService(this.Configuration);
            }
            this.Transaction = this.GetTransaction();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        // <summary>
        // Get transaction payload
        // <summary>
        private TransactionCreate GetTransactionPayload()
        {
            if (this.TransactionPayload == null)
            {
                // Line item
                LineItemCreate lineItem1 = new LineItemCreate(
                    name: "Red T-Shirt",
                    uniqueId: "5412",
                    type: LineItemType.PRODUCT,
                    quantity: 1,
                    amountIncludingTax: (decimal)29.95
                )
                {
                    Sku = "red-t-shirt-123"
                };

                // Customer Billing Address
                AddressCreate billingAddress = new AddressCreate
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

                this.TransactionPayload = new TransactionCreate(new List<LineItemCreate>() { lineItem1 })
                {
                    Currency = "CHF",
                    AutoConfirmationEnabled = true,
                    BillingAddress = billingAddress,
                    ShippingAddress = billingAddress,
                    Language = "en-US"
                };
            }
            return this.TransactionPayload;
        }

        /// <summary>
        /// Create Transaction
        /// </summary>
        private Transaction GetTransaction()
        {
            if (this.Transaction == null)
            {
                try
                {
                    this.Transaction = this.TransactionService.Create(this.SpaceId, this.GetTransactionPayload());
                }
                catch (ApiException e)
                {
                    Assert.Fail("Failed to create transaction. Reason: " + e.Message + " Details: " + e.ErrorContent);
                }
            }
            return this.Transaction;
        }


        // <summary>
        // Get refund payload
        // <summary>
        private RefundCreate GetRefundPayload(Transaction transaction)
        {
            RefundCreate refundPayload = new RefundCreate(transaction.Id.ToString(), RefundType.MERCHANT_INITIATED_ONLINE)
            {
                Amount = transaction.AuthorizationAmount,
                Transaction = transaction.Id,
                MerchantReference = transaction.MerchantReference
            };
            return refundPayload;
        }

        /// <summary>
        /// Test an instance of RefundService
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<RefundService>(this.RefundService, "instance is a RefundService");
        }

        
        /// <summary>
        /// Test Count
        /// </summary>
        public void CountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? spaceId = null;
            //EntityQueryFilter filter = null;
            //var response = RefundService.Count(spaceId, filter);
            //Assert.IsInstanceOf<long?> (response, "response is long?");
        }
        
        /// <summary>
        /// Test Fail
        /// </summary>
        public void FailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? spaceId = null;
            //long? refundId = null;
            //var response = RefundService.Fail(spaceId, refundId);
            //Assert.IsInstanceOf<Refund> (response, "response is Refund");
        }
        
        /// <summary>
        /// Test GetRefundDocument
        /// </summary>
        public void GetRefundDocumentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? spaceId = null;
            //long? id = null;
            //var response = RefundService.GetRefundDocument(spaceId, id);
            //Assert.IsInstanceOf<RenderedDocument> (response, "response is RenderedDocument");
        }
        
        /// <summary>
        /// Test GetRefundDocumentWithTargetMediaType
        /// </summary>
        public void GetRefundDocumentWithTargetMediaTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? spaceId = null;
            //long? id = null;
            //long? targetMediaTypeId = null;
            //var response = RefundService.GetRefundDocumentWithTargetMediaType(spaceId, id, targetMediaTypeId);
            //Assert.IsInstanceOf<RenderedDocument> (response, "response is RenderedDocument");
        }
        
        /// <summary>
        /// Test Read
        /// </summary>
        public void ReadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? spaceId = null;
            //long? id = null;
            //var response = RefundService.Read(spaceId, id);
            //Assert.IsInstanceOf<Refund> (response, "response is Refund");
        }
        
        /// <summary>
        /// Test Refund
        /// </summary>
        [Test]
        public void RefundTest()
        {
            Transaction transaction = this.TransactionService.ProcessWithoutUserInteraction(this.SpaceId, this.Transaction.Id);
            Console.WriteLine(transaction.Id);
            TransactionState[] TransactionStates = {
                TransactionState.FAILED,
                TransactionState.FULFILL
            };
            for (var i = 1; i <= 5; i++) {
                Console.WriteLine(transaction.State);
           
                if (Array.Exists(TransactionStates, element => element == transaction.State)) {
                    break;
                }
                System.Threading.Thread.Sleep(i * 30);
                transaction = this.TransactionService.Read(this.SpaceId, transaction.Id);
            }

            if (transaction.State == TransactionState.FULFILL){
                TransactionCompletion transactionCompletion = this.TransactionCompletionService.CompleteOffline(this.SpaceId, transaction.Id);
                Assert.AreEqual(transactionCompletion.State, TransactionCompletionState.SUCCESSFUL);
                transaction = this.TransactionService.Read(this.SpaceId, transactionCompletion.LinkedTransaction);  // fetch the latest transaction data
                RefundCreate refundPayload = this.GetRefundPayload(transaction);
                Refund refund = this.RefundService.Refund(this.SpaceId, refundPayload);
                Assert.AreEqual(refund.State, RefundState.SUCCESSFUL);
            }
        }
        
        /// <summary>
        /// Test Search
        /// </summary>
        public void SearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? spaceId = null;
            //EntityQuery query = null;
            //var response = RefundService.Search(spaceId, query);
            //Assert.IsInstanceOf<List<Refund>> (response, "response is List<Refund>");
        }
        
        /// <summary>
        /// Test Succeed
        /// </summary>
        public void SucceedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? spaceId = null;
            //long? refundId = null;
            //var response = RefundService.Succeed(spaceId, refundId);
            //Assert.IsInstanceOf<Refund> (response, "response is Refund");
        }
        
    }

}
