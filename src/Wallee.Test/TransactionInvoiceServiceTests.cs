using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Wallee.Model;
using Wallee.Service;

namespace Wallee.Test
{
    /// <summary>
    /// TransactionInvoiceService tests
    /// </summary>
    [TestFixture]
    public class TransactionInvoiceServiceTests
    {
        private TransactionService transactionService;
        private TransactionInvoiceService transactionInvoiceService;
        private TransactionCompletionService transactionCompletionService;
        private CardProcessingService cardProcessingService;

        [SetUp]
        public void Init()
        {
            transactionService = new TransactionService(Constants.Config);
            transactionInvoiceService = new TransactionInvoiceService(Constants.Config);
            transactionCompletionService = new TransactionCompletionService(Constants.Config);
            cardProcessingService = new CardProcessingService(Constants.Config);
        }

        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        /// Search() should find transaction invoice by a given criteria
        /// </summary>
        [Test]
        public void SearchTest()
        {
            var transactionCreate = Constants.GetTransactionCreate();
            transactionCreate.TokenizationMode = TokenizationMode.FORCE_CREATION;
            transactionCreate.CustomersPresence = CustomersPresence.NOT_PRESENT;
            transactionCreate.CompletionBehavior = TransactionCompletionBehavior.COMPLETE_IMMEDIATELY;
            var transaction = transactionService.Create(Constants.SpaceId, transactionCreate);

            var transactionProcessed = cardProcessingService.Process(Constants.SpaceId, transaction.Id,
                Constants.TestCardPaymentMethodConfigurationId, Constants.FakeCardData);

            Assert.AreEqual(TransactionState.FULFILL, transactionProcessed.State, "Transaction state must be FULFILL");

            var queryFilter = new EntityQueryFilter(EntityQueryFilterType.LEAF)
            {
                // linkedTransaction does not work here as criteria
                FieldName = "completion.lineItemVersion.transaction.id",
                Value = transactionProcessed.Id,
                Operator = CriteriaOperator.EQUALS
            };

            var invoicesFound = transactionInvoiceService.Search(Constants.SpaceId, new EntityQuery()
            {
                Filter = queryFilter
            });

            Assert.That(invoicesFound.Any(), "Should find invoice");
            invoicesFound.ForEach(invoice =>
            {
                Assert.AreEqual(TransactionInvoiceState.NOT_APPLICABLE, invoice.State,
                    "Invoice paid by card is expected to be of NOT_APPLICABLE state");
            });
        }

        /// <summary>
        /// MarkAsDerecognized() should derecognize open invoice
        /// </summary>
        [Test]
        public void DerecognizeTransactionInvoiceTest()
        {
            var transactionCreate = Constants.GetTransactionCreate();
            transactionCreate.TokenizationMode = TokenizationMode.FORCE_CREATION;
            transactionCreate.CustomersPresence = CustomersPresence.NOT_PRESENT;
            transactionCreate.CompletionBehavior = TransactionCompletionBehavior.COMPLETE_DEFERRED;

            // we want invoice in OPEN state (OPEN invoices can be derecognized), so we force payment by invoice
            transactionCreate.AllowedPaymentMethodConfigurations = new List<long?>
                { Constants.TestIsrInvoicePaymentMethodConfigurationId };
            var transaction = transactionService.Create(Constants.SpaceId, transactionCreate);

            var transactionProcessed =
                transactionService.ProcessWithoutUserInteraction(Constants.SpaceId, transaction.Id);
            var transactionCompletion =
                transactionCompletionService.CompleteOnline(Constants.SpaceId, transactionProcessed.Id);

            var queryFilter = new EntityQueryFilter(EntityQueryFilterType.LEAF)
            {
                FieldName = "completion.lineItemVersion.transaction.id",
                Value = transactionProcessed.Id,
                Operator = CriteriaOperator.EQUALS
            };

            var invoicesFound = transactionInvoiceService.Search(Constants.SpaceId, new EntityQuery()
            {
                Filter = queryFilter
            });

            Assert.That(invoicesFound.Any(), "Should find invoice");

            var foundInvoice = invoicesFound[0];

            Assert.AreEqual(TransactionInvoiceState.OPEN, foundInvoice.State,
                "Transaction paid by invoice should create invoice in OPEN state");

            // this is a POST call without a body
            var derecognizedInvoice = transactionInvoiceService.MarkAsDerecognized(Constants.SpaceId, foundInvoice.Id);

            Assert.AreEqual(TransactionInvoiceState.DERECOGNIZED, derecognizedInvoice.State,
                "Expected DERECOGNIZED invoice state");
        }
    }
}