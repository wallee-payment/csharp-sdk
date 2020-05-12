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
    ///  Class for testing TransactionCompletionService
    /// </summary>
    [TestFixture]
    public class TransactionCompletionServiceTests
    {
        private readonly long SpaceId = 405;
        private readonly string ApplicationUserID = "512";
        private readonly string AuthenticationKey = "FKrO76r5VwJtBrqZawBspljbBNOxp5veKQQkOnZxucQ=";

        private Configuration Configuration;
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
            if (this.Configuration == null)
            {
                this.Configuration = new Configuration(this.ApplicationUserID, this.AuthenticationKey);
            }
            if (this.TransactionCompletionService == null)
            {
                this.TransactionCompletionService = new TransactionCompletionService(this.Configuration);
            }
            if (this.TransactionService == null)
            {
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

        /// <summary>
        /// Test an instance of TransactionCompletionService
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<TransactionCompletionService>(TransactionCompletionService, "instance is a TransactionCompletionService");
        }

        
        /// <summary>
        /// Test CompleteOffline
        /// </summary>
        [Test]
        public void CompleteOfflineTest()
        {
            Transaction transaction = this.TransactionService.ProcessWithoutUserInteraction(this.SpaceId, this.Transaction.Id);
            TransactionCompletion transactionCompletion = this.TransactionCompletionService.CompleteOffline(this.SpaceId, transaction.Id);
            TransactionCompletionState[] TransactionCompletionStates = {
                TransactionCompletionState.SUCCESSFUL,
                TransactionCompletionState.PENDING
            };
            Assert.AreEqual(true, Array.Exists(TransactionCompletionStates, element => element == transactionCompletion.State));
        }

        /// <summary>
        /// Test CompleteOnline
        /// </summary>
        [Test]
        public void CompleteOnlineTest()
        {
            Transaction transaction = this.TransactionService.Create(this.SpaceId, this.GetTransactionPayload());
            transaction = this.TransactionService.ProcessWithoutUserInteraction(this.SpaceId, transaction.Id);
            TransactionCompletion transactionCompletion = this.TransactionCompletionService.CompleteOnline(this.SpaceId, transaction.Id);
            TransactionCompletionState[] TransactionCompletionStates = {
                TransactionCompletionState.SUCCESSFUL,
                TransactionCompletionState.PENDING
            };
            Assert.AreEqual(true, Array.Exists(TransactionCompletionStates, element => element == transactionCompletion.State));
        }
        
        /// <summary>
        /// Test CompletePartiallyOffline
        /// </summary>
        [Test]
        public void CompletePartiallyOfflineTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? spaceId = null;
            //TransactionCompletionRequest completion = null;
            //var response = TransactionCompletionService.CompletePartiallyOffline(spaceId, completion);
            //Assert.IsInstanceOf<TransactionCompletion> (response, "response is TransactionCompletion");
        }
        
        /// <summary>
        /// Test CompletePartiallyOnline
        /// </summary>
        [Test]
        public void CompletePartiallyOnlineTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? spaceId = null;
            //TransactionCompletionRequest completion = null;
            //var response = TransactionCompletionService.CompletePartiallyOnline(spaceId, completion);
            //Assert.IsInstanceOf<TransactionCompletion> (response, "response is TransactionCompletion");
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
            //var response = TransactionCompletionService.Count(spaceId, filter);
            //Assert.IsInstanceOf<long?> (response, "response is long?");
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
            //var response = TransactionCompletionService.Read(spaceId, id);
            //Assert.IsInstanceOf<TransactionCompletion> (response, "response is TransactionCompletion");
        }
        
        /// <summary>
        /// Test Search
        /// </summary>
        [Test]
        public void SearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? spaceId = null;
            //EntityQuery query = null;
            //var response = TransactionCompletionService.Search(spaceId, query);
            //Assert.IsInstanceOf<List<TransactionCompletion>> (response, "response is List<TransactionCompletion>");
        }
        
    }

}
