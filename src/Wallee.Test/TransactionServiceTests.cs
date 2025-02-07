using System.Linq;
using NUnit.Framework;
using Wallee.Client;
using Wallee.Model;
using Wallee.Service;

namespace Wallee.Test
{
    /// <summary>
    /// TransactionService tests
    /// </summary>
    [TestFixture]
    public class TransactionServiceTests
    {
        private TransactionService transactionService;
        private CardProcessingService cardProcessingService;
        private TokenService tokenService;
        private TransactionCompletionService transactionCompletionService;

        [SetUp]
        public void Init()
        {
            transactionService = new TransactionService(Constants.Config);
            cardProcessingService = new CardProcessingService(Constants.Config);
            tokenService = new TokenService(Constants.Config);
            transactionCompletionService = new TransactionCompletionService(Constants.Config);
        }

        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        /// Create() should create transaction
        /// </summary>
        [Test]
        public void CreateTest()
        {
            var transaction = transactionService.Create(Constants.SpaceId, Constants.GetTransactionCreate());

            Assert.AreEqual(TransactionState.PENDING, transaction.State, "State must be PENDING");
        }

        /// <summary>
        /// Confirm() should mark transaction as confirmed
        /// </summary>
        [Test]
        public void ConfirmTest()
        {
            var transaction = transactionService.Create(Constants.SpaceId, Constants.GetTransactionCreate());
            var transactionPending = new TransactionPending(transaction.Version, transaction.Id);
            var transactionConfirmed = transactionService.Confirm(Constants.SpaceId, transactionPending);

            Assert.AreEqual(TransactionState.CONFIRMED, transactionConfirmed.State, "State must be CONFIRMED");
        }

        /// <summary>
        /// Create() with COMPLETE_DEFERRED transaction behaviour should make transaction Authorized when we pay with card details
        /// </summary>
        [Test]
        public void CreateCompleteDeferredTest()
        {
            var transactionCreate = Constants.GetTransactionCreate();
            transactionCreate.TokenizationMode = TokenizationMode.FORCE_CREATION;
            transactionCreate.CustomersPresence = CustomersPresence.NOT_PRESENT;
            transactionCreate.CompletionBehavior = TransactionCompletionBehavior.COMPLETE_DEFERRED;
            var transaction = transactionService.Create(Constants.SpaceId, transactionCreate);

            var transactionProcessed = cardProcessingService.Process(Constants.SpaceId, transaction.Id,
                Constants.TestCardPaymentMethodConfigurationId, Constants.FakeCardData);

            Assert.AreEqual(TransactionState.AUTHORIZED, transactionProcessed.State, "State must be AUTHORIZED");
        }

        /// <summary>
        /// Create() with COMPLETE_IMMEDIATELY transaction behaviour should make transaction Fulfilled when we pay with card details
        /// </summary>
        [Test]
        public void CreateCompleteImmediatelyTest()
        {
            var transactionCreate = Constants.GetTransactionCreate();
            transactionCreate.TokenizationMode = TokenizationMode.FORCE_CREATION;
            transactionCreate.CustomersPresence = CustomersPresence.NOT_PRESENT;
            transactionCreate.CompletionBehavior = TransactionCompletionBehavior.COMPLETE_IMMEDIATELY;
            var transaction = transactionService.Create(Constants.SpaceId, transactionCreate);

            var transactionProcessed = cardProcessingService.Process(Constants.SpaceId, transaction.Id,
                Constants.TestCardPaymentMethodConfigurationId, Constants.FakeCardData);

            Assert.AreEqual(TransactionState.FULFILL, transactionProcessed.State, "State must be FULFILL");
        }

        /// <summary>
        /// Count() should count transactions matching given criteria
        /// </summary>
        [Test]
        public void CountTest()
        {
            var transaction = transactionService.Create(Constants.SpaceId, Constants.GetTransactionCreate());
            var queryFilter = new EntityQueryFilter(EntityQueryFilterType.LEAF)
            {
                FieldName = "id",
                Value = transaction.Id,
                Operator = CriteriaOperator.EQUALS
            };
            var transactionCount = transactionService.Count(Constants.SpaceId, queryFilter);

            Assert.AreEqual(1, transactionCount, "Transaction count should be 1");
        }

        /// <summary>
        /// CreateTransactionCredentials() should create valid transaction credentials token
        /// </summary>
        [Test]
        public void CreateTransactionCredentialsTest()
        {
            var transaction = transactionService.Create(Constants.SpaceId, Constants.GetTransactionCreate());
            var creds = transactionService.CreateTransactionCredentials(Constants.SpaceId, transaction.Id);

            StringAssert.StartsWith(Constants.SpaceId.ToString(), creds,
                "Transaction credentials token should have valid format");
        }

        /// <summary>
        /// FetchPaymentMethods() should fetch payment methods available for the transaction
        /// </summary>
        [Test]
        public void FetchPaymentMethodsTest()
        {
            var transaction = transactionService.Create(Constants.SpaceId, Constants.GetTransactionCreate());
            var methods =
                transactionService.FetchPaymentMethods(Constants.SpaceId, transaction.Id, "payment_page");

            Assert.That(methods.Any(), "Payment methods should be configured for a given transaction in test space");
        }

        /// <summary>
        /// Read() should read transaction details
        /// </summary>
        [Test]
        public void ReadTest()
        {
            var transaction = transactionService.Create(Constants.SpaceId, Constants.GetTransactionCreate());
            var transactionRead = transactionService.Read(Constants.SpaceId, transaction.Id);

            Assert.AreEqual(transaction.Id, transactionRead.Id, "Transaction ids should match");
            Assert.AreEqual(TransactionState.PENDING, transactionRead.State, "State must be PENDING");
        }

        /// <summary>
        /// ReadWithCredentials() should fail when credentials are bad
        /// </summary>
        [Test]
        public void ReadWithCredentialsForBadCredentialsTest()
        {
            Assert.That(() => { transactionService.ReadWithCredentials("invalid_token"); },
                Throws.TypeOf<ApiException>()
                    .With.Message.StartsWith("Error calling ReadWithCredentials"));
        }

        /// <summary>
        /// ReadWithCredentials() should read transaction when valid credentials token is provided
        /// </summary>
        [Test]
        public void ReadWithCredentialsTest()
        {
            var transaction = transactionService.Create(Constants.SpaceId, Constants.GetTransactionCreate());
            var creds = transactionService.CreateTransactionCredentials(Constants.SpaceId, transaction.Id);
            var transactionRead = transactionService.ReadWithCredentials(creds);

            Assert.AreEqual(transaction.Id, transactionRead.Id, "Transaction ids should match");
        }

        /// <summary>
        /// Search() should find transaction by id
        /// </summary>
        [Test]
        public void SearchTest()
        {
            var transaction = transactionService.Create(Constants.SpaceId, Constants.GetTransactionCreate());

            var queryFilter = new EntityQueryFilter(EntityQueryFilterType.LEAF)
            {
                FieldName = "id",
                Value = transaction.Id,
                Operator = CriteriaOperator.EQUALS
            };
            var transactionsFound = transactionService.Search(Constants.SpaceId, new EntityQuery()
            {
                Filter = queryFilter
            });

            Assert.That(transactionsFound.Count == 1, "Should find one transaction");
            transactionsFound.ForEach(tx =>
            {
                Assert.AreEqual(transaction.Id, tx.Id, "Transaction ids should match");
            });
        }

        /// <summary>
        /// Update() should successfully update existing transaction
        /// </summary>
        [Test]
        public void UpdateTest()
        {
            var transaction = transactionService.Create(Constants.SpaceId, Constants.GetTransactionCreate());
            var transactionPending = new TransactionPending(transaction.Version, transaction.Id)
            {
                Language = "en-US"
            };

            var transactionUpdate = transactionService.Update(Constants.SpaceId, transactionPending);

            Assert.AreEqual("en-US", transactionUpdate.Language, "Language value should match");
        }

        /// <summary>
        /// ProcessWithoutUserInteraction() should correctly process created transaction without need for user interaction
        /// </summary>
        [Test]
        public void ProcessWithoutUserInteractionTest()
        {
            var transaction = transactionService.Create(Constants.SpaceId, Constants.GetTransactionCreate());
            var transactionProcessed =
                transactionService.ProcessWithoutUserInteraction(Constants.SpaceId, transaction.Id);

            Assert.AreEqual(transaction.Id, transactionProcessed.Id, "Transaction ids must match");
        }

        /// <summary>
        /// FetchOneClickTokensWithCredentials() should return one-click payment tokens (if any) for provided transaction
        /// </summary>
        [Test]
        public void FetchOneClickTokensWithCredentialsNoTokensTest()
        {
            var transaction = transactionService.Create(Constants.SpaceId, Constants.GetTransactionCreate());
            var creds = transactionService.CreateTransactionCredentials(Constants.SpaceId, transaction.Id);
            var tokens = transactionService.FetchOneClickTokensWithCredentials(creds);

            Assert.That(tokens.Count == 0, "Should be no tokens yet");
        }

        /// <summary>
        /// FetchPaymentMethodsWithCredentials() should return payment methods (if any) for credentials
        /// </summary>
        [Test]
        public void FetchPaymentMethodsWithCredentialsTest()
        {
            var transaction = transactionService.Create(Constants.SpaceId, Constants.GetTransactionCreate());
            var creds = transactionService.CreateTransactionCredentials(Constants.SpaceId, transaction.Id);
            var methods =
                transactionService.FetchPaymentMethodsWithCredentials(creds, "payment_page");

            Assert.That(methods.Any(), "Should have some payment methods set up");
        }

        /// <summary>
        /// ProcessOneClickTokenAndRedirectWithCredentials()
        /// should create URL that can be used to authorize 2nd transaction after we have created token for 1st authorized transaction
        /// </summary>
        [Test]
        public void ProcessOneClickTokenAndRedirectWithCredentialsTest()
        {
            var transaction1Create = Constants.GetTransactionCreate();
            transaction1Create.TokenizationMode = TokenizationMode.FORCE_CREATION_WITH_ONE_CLICK_PAYMENT;
            transaction1Create.CustomersPresence = CustomersPresence.NOT_PRESENT;
            transaction1Create.CompletionBehavior = TransactionCompletionBehavior.COMPLETE_DEFERRED;
            transaction1Create.CustomerId = Constants.TestCustomerId;
            var transaction1 = transactionService.Create(Constants.SpaceId, transaction1Create);

            var transaction1Processed = cardProcessingService.Process(Constants.SpaceId, transaction1.Id,
                Constants.TestCardPaymentMethodConfigurationId, Constants.FakeCardData);

            var token = tokenService.CreateToken(Constants.SpaceId, transaction1Processed.Id);
            var tokenForUpdate = new TokenUpdate(token.Version, token.Id)
            {
                EnabledForOneClickPayment = true
            };
            var updatedToken = tokenService.Update(Constants.SpaceId, tokenForUpdate);

            var transaction2Create = Constants.GetTransactionCreate();
            transaction2Create.TokenizationMode = TokenizationMode.FORCE_CREATION_WITH_ONE_CLICK_PAYMENT;
            transaction2Create.CustomersPresence = CustomersPresence.NOT_PRESENT;
            transaction2Create.CompletionBehavior = TransactionCompletionBehavior.COMPLETE_DEFERRED;
            transaction2Create.CustomerId = Constants.TestCustomerId;

            var transaction2 = transactionService.Create(Constants.SpaceId, transaction2Create);
            var creds2 = transactionService.CreateTransactionCredentials(Constants.SpaceId, transaction2.Id);
            var paymentUrl2 =
                transactionService.ProcessOneClickTokenAndRedirectWithCredentials(creds2, updatedToken.Id);

            StringAssert.Contains("securityToken", paymentUrl2, "URL must be of a proper format");

            var transaction2Read = transactionService.Read(Constants.SpaceId, transaction2.Id);

            Assert.AreEqual(TransactionState.AUTHORIZED, transaction2Read.State, "State must be AUTHORIZED");

            // cleanup - 2nd transaction
            var transaction2Completed =
                transactionCompletionService.CompleteOnline(Constants.SpaceId, transaction2.Id);
            Assert.AreEqual(TransactionCompletionState.SUCCESSFUL, transaction2Completed.State,
                "State must be SUCCESSFUL");

            // cleanup - 1st transaction
            var transaction1Completed =
                transactionCompletionService.CompleteOnline(Constants.SpaceId, transaction1.Id);
            Assert.AreEqual(TransactionCompletionState.SUCCESSFUL, transaction1Completed.State,
                "State must be SUCCESSFUL");

            tokenService.Delete(Constants.SpaceId, token.Id);
        }
    }
}