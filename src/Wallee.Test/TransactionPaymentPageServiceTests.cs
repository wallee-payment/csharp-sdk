using NUnit.Framework;
using Wallee.Service;

namespace Wallee.Test
{
    /// <summary>
    /// TransactionPaymentPageService tests
    /// </summary>
    [TestFixture]
    public class TransactionPaymentPageServiceTests
    {
        private TransactionService transactionService;
        private TransactionPaymentPageService transactionPaymentPageService;

        [SetUp]
        public void Init()
        {
            transactionService = new TransactionService(Constants.Config);
            transactionPaymentPageService = new TransactionPaymentPageService(Constants.Config);
        }

        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        /// PaymentPageUrl() should create payment page URL
        /// </summary>
        [Test]
        public void PaymentPageUrlTest()
        {
            var transaction = transactionService.Create(Constants.SpaceId, Constants.GetTransactionCreate());
            var url = transactionPaymentPageService.PaymentPageUrl(Constants.SpaceId, transaction.Id);

            StringAssert.Contains("securityToken", url, "URL must be of a proper format");
        }
    }
}