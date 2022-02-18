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
    ///  Class for testing TransactionVoidService
    /// </summary>
    [TestFixture]
    public class TransactionVoidServiceTests
    {

        private readonly long SpaceId = 405;
        private readonly string ApplicationUserID = "512";
        private readonly string AuthenticationKey = "FKrO76r5VwJtBrqZawBspljbBNOxp5veKQQkOnZxucQ=";

        private Configuration Configuration;
        private TransactionVoidService TransactionVoidService;
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

            if (this.TransactionVoidService == null)
            {
                this.TransactionVoidService = new TransactionVoidService(this.Configuration);
            }

            if (this.TransactionService == null)
            {
                this.TransactionService = new TransactionService(this.Configuration);
            }
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
                    Language = "en-US",
                    AllowedPaymentMethodConfigurations = new List<long?>() { 8656 }, // Invoice Payment Method
                    CompletionBehavior = TransactionCompletionBehavior.COMPLETE_DEFERRED
                };
            }
            return this.TransactionPayload;
        }


        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TransactionVoidService
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<TransactionVoidService>(TransactionVoidService, "instance is a TransactionVoidService");
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
            //var response = TransactionVoidService.Count(spaceId, filter);
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
            //var response = TransactionVoidService.Read(spaceId, id);
            //Assert.IsInstanceOf<TransactionVoid> (response, "response is TransactionVoid");
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
            //var response = TransactionVoidService.Search(spaceId, query);
            //Assert.IsInstanceOf<List<TransactionVoid>> (response, "response is List<TransactionVoid>");
        }

        /// <summary>
        /// Test VoidOffline
        /// </summary>
        [Test]
        public void VoidOfflineTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? spaceId = null;
            //long? id = null;
            //var response = TransactionVoidService.VoidOffline(spaceId, id);
            //Assert.IsInstanceOf<TransactionVoid> (response, "response is TransactionVoid");
        }

        /// <summary>
        /// Test VoidOnline
        /// Transactions in State AUTHORIZED can be voided.
        /// </summary>
        [Test]
        public void VoidOnlineTest()
        {
            Transaction transaction = this.TransactionService.Create(this.SpaceId, this.GetTransactionPayload());
            transaction = this.TransactionService.ProcessWithoutUserInteraction(this.SpaceId, transaction.Id);
			for (var i = 1; i <= 30; i++) {
				Console.WriteLine(transaction.State);

				if (TransactionState.AUTHORIZED == transaction.State) {
					break;
				}
				System.Threading.Thread.Sleep(i * 30);
				transaction = this.TransactionService.Read(this.SpaceId, transaction.Id);
			}
           if (TransactionState.AUTHORIZED == transaction.State) {
                var response = TransactionVoidService.VoidOnline(this.SpaceId, transaction.Id);
                Assert.IsInstanceOf<TransactionVoid> (response, "response is TransactionVoid");
            }

        }

    }

}