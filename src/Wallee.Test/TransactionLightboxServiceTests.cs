using NUnit.Framework;
using Wallee.Service;

namespace Wallee.Test
{
    /// <summary>
    /// TransactionLightboxService tests
    /// </summary>
    [TestFixture]
    public class TransactionLightboxServiceTests
    {
        private TransactionService transactionService;
        private TransactionLightboxService transactionLightboxService;

        [SetUp]
        public void Init()
        {
            transactionService = new TransactionService(Constants.Config);
            transactionLightboxService = new TransactionLightboxService(Constants.Config);
        }

        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        /// JavascriptUrl() should create URL for use in Lightbox checkout flow javascript
        /// </summary>
        [Test]
        public void JavascriptUrlTest()
        {
            var transaction = transactionService.Create(Constants.SpaceId, Constants.GetTransactionCreate());
            var url = transactionLightboxService.JavascriptUrl(Constants.SpaceId, transaction.Id);

            StringAssert.Contains("securityToken", url, "URL must be of a proper format");
        }
    }
}