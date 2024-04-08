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
    /// RefundService tests
    /// </summary>
    [TestFixture]
    public class RefundServiceTests
    {
        private TransactionService transactionService;
        private CardProcessingService cardProcessingService;
        private TransactionCompletionService transactionCompletionService;
        private RefundService refundService;

        [SetUp]
        public void Init()
        {
            transactionService = new TransactionService(Constants.Config);
            cardProcessingService = new CardProcessingService(Constants.Config);
            transactionCompletionService = new TransactionCompletionService(Constants.Config);
            refundService = new RefundService(Constants.Config);
        }

        [TearDown]
        public void Cleanup()
        {
        }

        private RefundCreate GetRefundCreate(Transaction transaction) {
            return new RefundCreate(transaction.Id.ToString(), RefundType.MERCHANT_INITIATED_ONLINE){
                Amount=transaction.AuthorizationAmount,
                Transaction=transaction.Id,
                MerchantReference=transaction.MerchantReference
            };
        }
        
        /// <summary>
        /// Refund() should create a refund for transaction
        /// </summary>
        [Test]
        public void RefundTest()
        {
            var transaction = transactionService.Create(Constants.SpaceId, Constants.GetTransactionCreate());
            var transactionProcessed = cardProcessingService.Process(Constants.SpaceId, transaction.Id,
                Constants.TestCardPaymentMethodConfigurationId, Constants.FakeCardData);

            var transactionCompletion = transactionCompletionService.CompleteOffline(Constants.SpaceId, transactionProcessed.Id);

            Assert.AreEqual(TransactionCompletionState.SUCCESSFUL, transactionCompletion.State, "State must be SUCCESSFUL");

            var transactionRead = transactionService.Read(Constants.SpaceId, transactionProcessed.Id);

            var refund = refundService.Refund(Constants.SpaceId, GetRefundCreate(transactionRead));

            Assert.AreEqual(RefundState.SUCCESSFUL, refund.State, "State must be SUCCESSFUL");
        }

        /// <summary>
        /// Read() should fetch refund details
        /// </summary>
        [Test]
        public void ReadTest()
        {
            var transaction = transactionService.Create(Constants.SpaceId, Constants.GetTransactionCreate());
            var transactionProcessed = cardProcessingService.Process(Constants.SpaceId, transaction.Id,
                Constants.TestCardPaymentMethodConfigurationId, Constants.FakeCardData);

            var transactionCompletion = transactionCompletionService.CompleteOffline(Constants.SpaceId, transactionProcessed.Id);

            Assert.AreEqual(TransactionCompletionState.SUCCESSFUL, transactionCompletion.State, "State must be SUCCESSFUL");

            var transactionRead = transactionService.Read(Constants.SpaceId, transactionProcessed.Id);

            var refund = refundService.Refund(Constants.SpaceId, GetRefundCreate(transactionRead));

            Assert.AreEqual(RefundState.SUCCESSFUL, refund.State, "State must be SUCCESSFUL");

            var readRefund = refundService.Read(Constants.SpaceId, refund.Id);

            Assert.AreEqual(refund.Id, readRefund.Id, "Refund ids must match");
        }

        /// <summary>
        /// Search() should find a refund for a given criteria
        /// </summary>
        [Test]
        public void SearchTest()
        {
            var transaction = transactionService.Create(Constants.SpaceId, Constants.GetTransactionCreate());
            var transactionProcessed = cardProcessingService.Process(Constants.SpaceId, transaction.Id,
                Constants.TestCardPaymentMethodConfigurationId, Constants.FakeCardData);

            var transactionCompletion = transactionCompletionService.CompleteOffline(Constants.SpaceId, transactionProcessed.Id);

            Assert.AreEqual(TransactionCompletionState.SUCCESSFUL, transactionCompletion.State, "State must be SUCCESSFUL");

            var transactionRead = transactionService.Read(Constants.SpaceId, transactionProcessed.Id);

            var refund = refundService.Refund(Constants.SpaceId, GetRefundCreate(transactionRead));

            Assert.AreEqual(RefundState.SUCCESSFUL, refund.State, "State must be SUCCESSFUL");

            var queryFilter = new EntityQueryFilter(EntityQueryFilterType.LEAF){
                FieldName = "id",
                Value = refund.Id,
                Operator = CriteriaOperator.EQUALS
            };
            var refundsFound = refundService.Search(Constants.SpaceId, new EntityQuery(){
                Filter = queryFilter
            });

            Assert.That(refundsFound.Count == 1, "Should find one refund");
            refundsFound.ForEach(refnd => {
                Assert.AreEqual(refund.Id, refnd.Id, "Refund ids should match");
            });
        }

        /// <summary>
        /// Count() should count refunds for a given criteria
        /// </summary>
        [Test]
        public void CountTest()
        {
            var transaction = transactionService.Create(Constants.SpaceId, Constants.GetTransactionCreate());
            var transactionProcessed = cardProcessingService.Process(Constants.SpaceId, transaction.Id,
                Constants.TestCardPaymentMethodConfigurationId, Constants.FakeCardData);

            var transactionCompletion = transactionCompletionService.CompleteOffline(Constants.SpaceId, transactionProcessed.Id);

            Assert.AreEqual(TransactionCompletionState.SUCCESSFUL, transactionCompletion.State, "State must be SUCCESSFUL");

            var transactionRead = transactionService.Read(Constants.SpaceId, transactionProcessed.Id);

            var refund = refundService.Refund(Constants.SpaceId, GetRefundCreate(transactionRead));

            Assert.AreEqual(RefundState.SUCCESSFUL, refund.State, "State must be SUCCESSFUL");

            var queryFilter = new EntityQueryFilter(EntityQueryFilterType.LEAF){
                FieldName = "id",
                Value = refund.Id,
                Operator = CriteriaOperator.EQUALS
            };
            var refundsFound = refundService.Count(Constants.SpaceId, queryFilter);

            Assert.That(refundsFound == 1, "Should find 1 refund");
        }
    }
}