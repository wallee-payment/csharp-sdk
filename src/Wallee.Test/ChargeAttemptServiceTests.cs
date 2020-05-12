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
    ///  Class for testing ChargeAttemptService
    /// </summary>
    [TestFixture]
    public class ChargeAttemptServiceTests
    {

        private readonly long SpaceId = 405;
        private readonly string ApplicationUserID = "512";
        private readonly string AuthenticationKey = "FKrO76r5VwJtBrqZawBspljbBNOxp5veKQQkOnZxucQ=";

        private Configuration Configuration;
        private ChargeAttemptService ChargeAttemptService;
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

            if (this.ChargeAttemptService == null){
                this.ChargeAttemptService = new ChargeAttemptService(this.Configuration);
            }

            if (this.TransactionService == null)
            {
                this.TransactionService = new TransactionService(this.Configuration);
            }
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
        /// Test an instance of ChargeAttemptService
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<ChargeAttemptService>(ChargeAttemptService, "instance is a ChargeAttemptService");
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
            //var response = ChargeAttemptService.Count(spaceId, filter);
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
            //var response = ChargeAttemptService.Read(spaceId, id);
            //Assert.IsInstanceOf<ChargeAttempt> (response, "response is ChargeAttempt");
        }
        
        /// <summary>
        /// Test Search
        /// </summary>
        [Test]
        public void SearchTest()
        {
            Transaction transaction = this.TransactionService.Create(this.SpaceId, this.GetTransactionPayload());

            EntityQueryFilter entityQueryFilter = new EntityQueryFilter(EntityQueryFilterType.LEAF);
            entityQueryFilter.FieldName = "charge.transaction.id";
            entityQueryFilter.Value = transaction.Id;
            entityQueryFilter.Operator = CriteriaOperator.EQUALS;

            EntityQuery entityQuery = new EntityQuery();
            entityQuery.Filter = entityQueryFilter;

            var response = this.ChargeAttemptService.Search(this.SpaceId, entityQuery);
            Assert.IsInstanceOf<List<ChargeAttempt>> (response, "response is List<ChargeAttempt>");
        }
        
    }

}
