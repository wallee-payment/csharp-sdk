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
    /// ChargeAttemptService tests
    /// </summary>
    [TestFixture]
    public class ChargeAttemptServiceTests
    {

        private TransactionService transactionService;
        private ChargeAttemptService chargeAttemptService;
        private CardProcessingService cardProcessingService;

        [SetUp]
        public void Init()
        {
            transactionService = new TransactionService(Constants.Config);
            chargeAttemptService = new ChargeAttemptService(Constants.Config);
            cardProcessingService = new CardProcessingService(Constants.Config);
        }

        [TearDown]
        public void Cleanup()
        {
        }
        
        /// <summary>
        /// Search() should find charge attempts by given criteria
        /// </summary>
        [Test]
        public void SearchTest()
        {
            var transactionCreate = Constants.GetTransactionCreate();
            transactionCreate.TokenizationMode = TokenizationMode.FORCE_CREATION;
            transactionCreate.CustomersPresence = CustomersPresence.NOT_PRESENT;
            transactionCreate.CompletionBehavior = TransactionCompletionBehavior.COMPLETE_DEFERRED;
            var transaction = transactionService.Create(Constants.SpaceId, transactionCreate);

            var transactionProcessed = cardProcessingService.Process(Constants.SpaceId, transaction.Id,
                Constants.TestCardPaymentMethodConfigurationId, Constants.FakeCardData);

            Assert.AreEqual(TransactionState.AUTHORIZED, transactionProcessed.State, "State must be AUTHORIZED");

            var queryFilter = new EntityQueryFilter(EntityQueryFilterType.LEAF){
                FieldName = "charge.transaction.id",
                Value = transaction.Id,
                Operator = CriteriaOperator.EQUALS
            };
            var attemptsFound = chargeAttemptService.Search(Constants.SpaceId, new EntityQuery(){
                Filter = queryFilter
            });

            Assert.That(attemptsFound.Count > 0, "Should find a charge attempt");
            attemptsFound.ForEach(attempt => {
                Assert.AreEqual(transaction.Id, attempt.LinkedTransaction, "Transaction ids should match");
            });
        }

        // TODO write more API tests
    }
}