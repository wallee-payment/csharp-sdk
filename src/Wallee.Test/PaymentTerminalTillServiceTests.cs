/**
* WhiteLabelName SDK
*
* This library allows to interact with the WhiteLabelName payment service.
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
    ///  Class for testing PaymentTerminalTillService
    /// </summary>
    [TestFixture]
    public class PaymentTerminalTillServiceTests
    {

        private readonly long SpaceId = 405;
        private readonly string ApplicationUserID = "512";
        private readonly string AuthenticationKey = "FKrO76r5VwJtBrqZawBspljbBNOxp5veKQQkOnZxucQ=";
        
        private TransactionService TransactionService;
        private TransactionCreate TransactionPayload;
        private Transaction Transaction;

        private Configuration Configuration;
        private PaymentTerminalTillService paymentTerminalTillService;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            if (this.Configuration == null) {
                this.Configuration = new Configuration(this.ApplicationUserID, this.AuthenticationKey);
            }
            if (this.TransactionService == null){
                this.TransactionService = new TransactionService(this.Configuration);
            }
            if (this.paymentTerminalTillService == null){
                this.paymentTerminalTillService = new PaymentTerminalTillService(this.Configuration);
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
        // Get transaction payload
        // <summary>
        private TransactionCreate GetTransactionPayload()
        {
            if (this.TransactionPayload == null) {
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
        /// Test an instance of PaymentTerminalTillService
        /// </summary>
        ///[Test]
        ///public void InstanceTest()
        ///{
        ///    Assert.IsInstanceOf<PaymentTerminalTillService>(PaymentTerminalTillService, "instance is a PaymentTerminalTillService");
        ///}

        
        /// <summary>
        /// Test PerformTransaction
        /// </summary>
        [Test]
        public void PerformTransactionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            long? terminalId = 1;
            string language = "en";

            var response = paymentTerminalTillService.PerformTransaction(this.SpaceId, this.Transaction.Id, terminalId, language);
            Assert.IsInstanceOf<Transaction> (response, "response is Transaction");
        }
        
        /// <summary>
        /// Test PerformTransactionByIdentifier
        /// </summary>
        [Test]
        public void PerformTransactionByIdentifierTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? spaceId = null;
            //long? transactionId = null;
            //string terminalIdentifier = null;
            //string language = null;
            //var response = PaymentTerminalTillService.PerformTransactionByIdentifier(spaceId, transactionId, terminalIdentifier, language);
            //Assert.IsInstanceOf<Transaction> (response, "response is Transaction");
        }
        
    }

}
