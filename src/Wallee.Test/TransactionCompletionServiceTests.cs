using NUnit.Framework;
using Wallee.Model;
using Wallee.Service;

namespace Wallee.Test
{
    /// <summary>
    /// TransactionCompletionService tests
    /// </summary>
    [TestFixture]
    public class TransactionCompletionServiceTests
    {
        private TransactionService transactionService;
        private CardProcessingService cardProcessingService;
        private TransactionCompletionService transactionCompletionService;

        [SetUp]
        public void Init()
        {
            transactionService = new TransactionService(Constants.Config);
            cardProcessingService = new CardProcessingService(Constants.Config);
            transactionCompletionService = new TransactionCompletionService(Constants.Config);
        }

        [TearDown]
        public void Cleanup()
        {
        }

        private TransactionCreate GetDeferredTransactionCreate()
        {
            var transactionCreate = Constants.GetTransactionCreate();
            transactionCreate.TokenizationMode = TokenizationMode.FORCE_CREATION;
            transactionCreate.CustomersPresence = CustomersPresence.NOT_PRESENT;
            transactionCreate.CompletionBehavior = TransactionCompletionBehavior.COMPLETE_DEFERRED;
            return transactionCreate;
        }

        /// <summary>
        /// CompleteOffline() should complete transaction offline (completion is NOT forwarded to processor)
        /// </summary>
        [Test]
        public void CompleteOfflineTest()
        {
            var transaction = transactionService.Create(Constants.SpaceId, GetDeferredTransactionCreate());
            var transactionProcessed = cardProcessingService.Process(Constants.SpaceId, transaction.Id,
                Constants.TestCardPaymentMethodConfigurationId, Constants.FakeCardData);

            Assert.AreEqual(TransactionState.AUTHORIZED, transactionProcessed.State, "State must be AUTHORIZED");

            var transactionCompletion =
                transactionCompletionService.CompleteOffline(Constants.SpaceId, transactionProcessed.Id);

            Assert.AreEqual(TransactionCompletionState.SUCCESSFUL, transactionCompletion.State,
                "State must be SUCCESSFUL");
        }

        /// <summary>
        /// CompleteOnline() should complete transaction online (completion is forwarded to processor)
        /// </summary>
        [Test]
        public void CompleteOnlineTest()
        {
            var transaction = transactionService.Create(Constants.SpaceId, GetDeferredTransactionCreate());
            var transactionProcessed = cardProcessingService.Process(Constants.SpaceId, transaction.Id,
                Constants.TestCardPaymentMethodConfigurationId, Constants.FakeCardData);

            Assert.AreEqual(TransactionState.AUTHORIZED, transactionProcessed.State, "State must be AUTHORIZED");

            var transactionCompletion =
                transactionCompletionService.CompleteOnline(Constants.SpaceId, transactionProcessed.Id);

            Assert.AreEqual(TransactionCompletionState.SUCCESSFUL, transactionCompletion.State,
                "State must be SUCCESSFUL");
        }

        /// <summary>
        /// Read() should read details of transaction completion by id
        /// </summary>
        [Test]
        public void ReadTest()
        {
            var transaction = transactionService.Create(Constants.SpaceId, GetDeferredTransactionCreate());
            var transactionProcessed = cardProcessingService.Process(Constants.SpaceId, transaction.Id,
                Constants.TestCardPaymentMethodConfigurationId, Constants.FakeCardData);

            Assert.AreEqual(TransactionState.AUTHORIZED, transactionProcessed.State, "State must be AUTHORIZED");

            var transactionCompletion =
                transactionCompletionService.CompleteOnline(Constants.SpaceId, transactionProcessed.Id);
            var transactionRead = transactionCompletionService.Read(Constants.SpaceId, transactionCompletion.Id);

            Assert.AreEqual(transactionCompletion.Id, transactionRead.Id, "Transaction ids must match");
        }

        /// <summary>
        /// Count() should count transaction completions based on provided criteria
        /// </summary>
        [Test]
        public void CountTest()
        {
            var transaction = transactionService.Create(Constants.SpaceId, GetDeferredTransactionCreate());
            var transactionProcessed = cardProcessingService.Process(Constants.SpaceId, transaction.Id,
                Constants.TestCardPaymentMethodConfigurationId, Constants.FakeCardData);
            var transactionCompletion =
                transactionCompletionService.CompleteOnline(Constants.SpaceId, transactionProcessed.Id);

            var queryFilter = new EntityQueryFilter(EntityQueryFilterType.LEAF)
            {
                FieldName = "id",
                Value = transactionCompletion.Id,
                Operator = CriteriaOperator.EQUALS
            };
            var count = transactionCompletionService.Count(Constants.SpaceId, queryFilter);

            Assert.AreEqual(1, count, "Count of completions should be 1");
        }

        /// <summary>
        /// Search() should find transaction completions based on provided criteria
        /// </summary>
        [Test]
        public void SearchTest()
        {
            var transaction = transactionService.Create(Constants.SpaceId, GetDeferredTransactionCreate());
            var transactionProcessed = cardProcessingService.Process(Constants.SpaceId, transaction.Id,
                Constants.TestCardPaymentMethodConfigurationId, Constants.FakeCardData);
            var transactionCompletion =
                transactionCompletionService.CompleteOnline(Constants.SpaceId, transactionProcessed.Id);


            var queryFilter = new EntityQueryFilter(EntityQueryFilterType.LEAF)
            {
                FieldName = "id",
                Value = transactionCompletion.Id,
                Operator = CriteriaOperator.EQUALS
            };
            var completionsFound = transactionCompletionService.Search(Constants.SpaceId, new EntityQuery()
            {
                Filter = queryFilter
            });

            Assert.That(completionsFound.Count == 1, "Should find one completion");
            completionsFound.ForEach(compl =>
            {
                Assert.AreEqual(transactionCompletion.Id, compl.Id, "Completion ids should match");
            });
        }
    }
}