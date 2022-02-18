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
    ///  Class for testing PaymentTerminalService
    /// </summary>
    [TestFixture]
    public class PaymentTerminalServiceTests
    {

        private readonly long SpaceId = 405;
        private readonly string ApplicationUserID = "512";
        private readonly string AuthenticationKey = "FKrO76r5VwJtBrqZawBspljbBNOxp5veKQQkOnZxucQ=";

        private Configuration Configuration;
        private PaymentTerminalService PaymentTerminalService;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            if (this.Configuration == null) {
                this.Configuration = new Configuration(this.ApplicationUserID, this.AuthenticationKey);
            }
            this.PaymentTerminalService = new PaymentTerminalService(this.Configuration);
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PaymentTerminalService
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<PaymentTerminalService>(PaymentTerminalService, "instance is a PaymentTerminalService");
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
            //var response = PaymentTerminalService.Count(spaceId, filter);
            //Assert.IsInstanceOf<long?> (response, "response is long?");
        }

        /// <summary>
        /// Test Link
        /// </summary>
        [Test]
        public void LinkTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? spaceId = null;
            //long? terminalId = null;
            //string serialNumber = null;
            //PaymentTerminalService.Link(spaceId, terminalId, serialNumber);

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
            //var response = PaymentTerminalService.Read(spaceId, id);
            //Assert.IsInstanceOf<PaymentTerminal> (response, "response is PaymentTerminal");
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
            //var response = PaymentTerminalService.Search(spaceId, query);
            //Assert.IsInstanceOf<List<PaymentTerminal>> (response, "response is List<PaymentTerminal>");
        }

        /// <summary>
        /// Test TriggerFinalBalance
        /// </summary>
        [Test]
        public void TriggerFinalBalanceTest()
        {
            // Use your Terminal Id and Space ID
            //long? terminalId = 15053;
            //PaymentTerminalService.TriggerFinalBalance(this.SpaceId, terminalId);
        }

        /// <summary>
        /// Test Unlink
        /// </summary>
        [Test]
        public void UnlinkTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? spaceId = null;
            //long? terminalId = null;
            //PaymentTerminalService.Unlink(spaceId, terminalId);

        }

    }

}
