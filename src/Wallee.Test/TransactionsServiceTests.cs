/**
 * Wallee AG C# SDK
 *
 * This library allows to interact with the Wallee AG payment service.
 *
 * Copyright owner: Wallee AG
 * Website: https://en.wallee.com
 * Developer email: ecosystem-team@wallee.com
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
using NUnit.Framework;
using System.Collections.Generic;
using Wallee.Client;
using Wallee.Model;
using Wallee.Service;
using static Wallee.Test.TestUtils;
using static Wallee.Test.Constants;
using System.Linq;
using System.IO;

namespace Wallee.Test;

[TestFixture]
public class TransactionsServiceTests
{
    // Singleton (single) instance for Configuration.
    private static readonly Configuration configuration = Constants.Config;
    private static TransactionsService transactionsService;
    private static TokensService tokensService;
    private static readonly List<string> EMPTY_EXPAND = new();
    private const string INTEGRATION_MODE = "payment_page";

    [OneTimeSetUp]
    public void SetUp()
    {
        transactionsService = new TransactionsService(configuration);
        tokensService = new TokensService(configuration);
    }

    /// <summary>
    /// Creates a new transaction.
    ///
    /// -Verifies that:
    ///     -Transaction state is PENDING
    /// </summary>
    [Test]
    public void CreateAndFindPendingTransaction()
    {
        Transaction transaction = Create(GetTransactionCreatePayload());

        Transaction found = transactionsService.GetPaymentTransactionsId(
            transaction.Id, SPACE_ID, EMPTY_EXPAND);

        Assert.That(transaction.State, Is.EqualTo(TransactionState.PENDING), "Transaction state must be PENDING");
        Assert.That(found.MerchantReference, Is.EqualTo(transaction.MerchantReference), "Merchant reference should match.");
    }

    /// <summary>
    /// Confirms a pending transaction.
    ///
    /// -Verifies that:
    ///     -Transaction state is CONFIRMED
    ///     -Transaction entity version is correctly incremented
    ///     -Merchant reference is correctly updated
    /// </summary>
    [Test]
    public void ConfirmShouldMakeTransactionConfirmed()
    {
        var transactionCreate = GetTransactionCreatePayload();
        transactionCreate.MerchantReference = "Test Initial Confirm";
        var created = Create(transactionCreate);

        var transactionPending = new TransactionPending
        {
            VarVersion = 2,
            MerchantReference = "Test Confirm"
        };

        var confirmed = transactionsService.PostPaymentTransactionsIdConfirm(
            created.Id, SPACE_ID, transactionPending, EMPTY_EXPAND);

        Assert.That(confirmed.State, Is.EqualTo(TransactionState.CONFIRMED), "Transaction state must be CONFIRMED");
        Assert.That(confirmed.VarVersion, Is.EqualTo(3), "Version should match.");
        Assert.That(confirmed.MerchantReference, Is.EqualTo(transactionPending.MerchantReference), "Merchant reference should match.");
    }

    /// <summary>
    /// Processes a deferred transaction.
    ///
    /// -Verifies that:
    ///     -Transaction state is AUTHORIZED
    /// </summary>
    [Test]
    public void ProcessDeferredTransactionShouldMakeTransactionAuthorized()
    {
        var transactionCreate = GetTransactionCreatePayload();
        transactionCreate.TokenizationMode = TokenizationMode.FORCECREATION;
        transactionCreate.CustomersPresence = CustomersPresence.NOTPRESENT;
        transactionCreate.CompletionBehavior = TransactionCompletionBehavior.COMPLETEDEFERRED;

        var transaction = Create(transactionCreate);

        var processed = transactionsService.PostPaymentTransactionsIdProcessCardDetails(
            transaction.Id, SPACE_ID, MOCK_CARD_DATA, EMPTY_EXPAND);

        Assert.That(processed.State, Is.EqualTo(TransactionState.AUTHORIZED), "Transaction state must be AUTHORIZED");
    }

    /// <summary>
    /// Processes a transaction via charge flow.
    ///
    /// -Verifies that:
    ///     -Transaction state is PROCESSING
    /// </summary>
    [Test]
    public void ProcessViaChargeFlowShouldMakeTransactionProcessing()
    {
        var transaction = Create(GetTransactionCreatePayload());

        var processingTransaction = transactionsService.PostPaymentTransactionsIdChargeFlowApply(
            transaction.Id, SPACE_ID, EMPTY_EXPAND);

        Assert.That(processingTransaction.State, Is.EqualTo(TransactionState.PROCESSING), "Transaction state must be PROCESSING");
    }

    /// <summary>
    /// Processes and cancels a transaction via charge flow.
    ///
    /// -Verifies that:
    ///     -Initially, transaction state is PROCESSING
    ///     -After cancellation, transaction state is FAILED
    /// </summary>
    [Test]
    public void CancelChargeFlowShouldMakeTransactionFailed()
    {
        var transaction = Create(GetTransactionCreatePayload());

        var processingTransaction = transactionsService.PostPaymentTransactionsIdChargeFlowApply(
            transaction.Id, SPACE_ID, EMPTY_EXPAND);

        Assert.That(processingTransaction.State, Is.EqualTo(TransactionState.PROCESSING), "Transaction state must be PROCESSING");

        var failedTransaction = transactionsService.PostPaymentTransactionsIdChargeFlowCancel(
            transaction.Id, SPACE_ID, EMPTY_EXPAND);

        Assert.That(failedTransaction.State, Is.EqualTo(TransactionState.FAILED), "Transaction state must be FAILED");
    }

    /// <summary>
    /// Processes a transaction and retrieves payment page URL.
    ///
    /// -Verifies that:
    ///     -Retrieved URL contains space ID
    ///     -Retrieved URL contains transaction ID
    /// </summary>
    [Test]
    public void FetchPaymentPageUrlShouldReturnValidUrl()
    {
        var transaction = Create(GetTransactionCreatePayload());

        var processingTransaction = transactionsService.PostPaymentTransactionsIdChargeFlowApply(
            transaction.Id, SPACE_ID, EMPTY_EXPAND);

        string url = transactionsService.GetPaymentTransactionsIdPaymentPageUrl(transaction.Id, SPACE_ID);

        Assert.That(url, Does.Contain($"/s/{SPACE_ID}"), "Space id should be present in url");
        Assert.That(url, Does.Contain("securityToken="), "Security token should be present in url");
        Assert.That(url, Does.Contain(processingTransaction.Id.ToString()), "Transaction id should be present in url");
    }

    /// <summary>
    /// Processes a transaction via charge flow and retrieves payment page URL.
    ///
    /// -Verifies that:
    ///     -Transaction state is PROCESSING
    ///     -Retrieved URL contains space ID
    ///     -Retrieved URL contains transaction ID
    /// </summary>
    [Test]
    public void FetchChargeFlowUrlShouldReturnValidUrl()
    {
        var transaction = Create(GetTransactionCreatePayload());

        var processingTransaction = transactionsService.PostPaymentTransactionsIdChargeFlowApply(
            transaction.Id, SPACE_ID, EMPTY_EXPAND);

        Assert.That(processingTransaction.State, Is.EqualTo(TransactionState.PROCESSING), "Transaction state must be PROCESSING");

        string url = transactionsService.GetPaymentTransactionsIdChargeFlowPaymentPageUrl(
            processingTransaction.Id, SPACE_ID);

        Assert.That(url, Does.Contain(SPACE_ID.ToString()), "Url must contain space id");
        Assert.That(url, Does.Contain(processingTransaction.Id.ToString()), "Url must contain transaction id");
        Assert.That(url, Does.Contain("securityToken="), "Url must contain security token");
    }

    /// <summary>
    /// Authorizes and completes a transaction online using card details.
    ///
    /// -Verifies that:
    ///     -Transaction completion state is SUCCESSFUL
    ///     -Transaction state is FULFILL
    /// </summary>
    [Test]
    public void CompleteOnlineShouldMakeTransactionCompletionStateSuccessful()
    {
        var transactionCreate = GetTransactionCreatePayload();
        transactionCreate.TokenizationMode = TokenizationMode.FORCECREATION;
        transactionCreate.CustomersPresence = CustomersPresence.NOTPRESENT;
        transactionCreate.CompletionBehavior = TransactionCompletionBehavior.COMPLETEIMMEDIATELY;

        var transaction = Create(transactionCreate);

        var authorizedTransaction = transactionsService.PostPaymentTransactionsIdProcessCardDetails(
            transaction.Id, SPACE_ID, MOCK_CARD_DATA, EMPTY_EXPAND);

        var processedTransaction = transactionsService.PostPaymentTransactionsIdCompleteOnline(
            authorizedTransaction.Id, SPACE_ID, EMPTY_EXPAND);

        Assert.That(processedTransaction.State, Is.EqualTo(TransactionCompletionState.SUCCESSFUL), "Transaction completion state must be SUCCESSFUL");

        var completedTransaction = transactionsService.GetPaymentTransactionsId(transaction.Id, SPACE_ID, EMPTY_EXPAND);

        Assert.That(completedTransaction.State, Is.EqualTo(TransactionState.FULFILL), "Transaction state must be FULFILLED");
    }

    /// <summary>
    /// Authorizes and completes a transaction online partially using card details.
    ///
    /// -Verifies that:
    ///     -Transaction completion state is SUCCESSFUL
    ///     -Transaction state is FULFILL
    /// </summary>
    [Test]
    public void CompleteOnlinePartiallyShouldMakeTransactionCompletionStateSuccessful()
    {
        var transaction = Create(GetTransactionCreatePayload());

        var authorizedTransaction = transactionsService.PostPaymentTransactionsIdProcessCardDetails(
            transaction.Id, SPACE_ID, MOCK_CARD_DATA, EMPTY_EXPAND);

        var tcd = new TransactionCompletionDetails
        {
            ExternalId = Guid.NewGuid().ToString()
        };

        var processedTransaction = transactionsService.PostPaymentTransactionsIdCompletePartiallyOnline(
            authorizedTransaction.Id, SPACE_ID, tcd, EMPTY_EXPAND);

        Assert.That(processedTransaction.State, Is.EqualTo(TransactionCompletionState.SUCCESSFUL), "Transaction completion state must be SUCCESSFUL");

        var completedTransaction = transactionsService.GetPaymentTransactionsId(transaction.Id, SPACE_ID, EMPTY_EXPAND);

        Assert.That(completedTransaction.State, Is.EqualTo(TransactionState.FULFILL), "Transaction state must be FULFILLED");
    }



    /// <summary>
    /// Authorizes and voids a transaction online.
    ///
    /// -Verifies that:
    ///     -Transaction void state is SUCCESSFUL
    ///     -Transaction state is VOIDED
    /// </summary>
    [Test]
    public void VoidTransactionOnlineShouldReturnVoidedTransaction()
    {
        var transactionCreate = GetTransactionCreatePayload();
        transactionCreate.TokenizationMode = TokenizationMode.FORCECREATION;
        transactionCreate.CustomersPresence = CustomersPresence.NOTPRESENT;
        transactionCreate.CompletionBehavior = TransactionCompletionBehavior.COMPLETEDEFERRED;

        var transaction = Create(transactionCreate);

        var authorizedTransaction = transactionsService.PostPaymentTransactionsIdProcessCardDetails(
            transaction.Id, SPACE_ID, MOCK_CARD_DATA, EMPTY_EXPAND);

        Assert.That(authorizedTransaction.State, Is.EqualTo(TransactionState.AUTHORIZED),
            "Transaction state should be AUTHORIZED");

        var expand = new List<string> { "transaction" };

        var transactionVoid = transactionsService.PostPaymentTransactionsIdVoidOnline(
            authorizedTransaction.Id, SPACE_ID, expand);

        Assert.That(transactionVoid.State, Is.EqualTo(TransactionVoidState.SUCCESSFUL),
            "Transaction void state should be SUCCESSFUL");

        Assert.That(transactionVoid.Transaction, Is.Not.Null, "Voided transaction should not be null");

        Assert.That(transactionVoid.Transaction.State, Is.EqualTo(TransactionState.VOIDED),
            "Transaction state should be VOIDED");
    }


    /// <summary>
    /// Creates, authorizes and completes a transaction.
    ///
    /// -Verifies that:
    ///     -It's possible to create a transaction token for the fulfilled transaction
    /// </summary>
    [Test]
    public void CheckIfPossibleToCreateTokenForFulfilledTransaction()
    {
        var transaction = Create(GetTransactionCreatePayload());

        var authorizedTransaction = transactionsService.PostPaymentTransactionsIdProcessCardDetails(
            transaction.Id, SPACE_ID, MOCK_CARD_DATA, EMPTY_EXPAND);

        var fulfilledTransactionCompletion = transactionsService.PostPaymentTransactionsIdCompleteOnline(
            authorizedTransaction.Id, SPACE_ID, EMPTY_EXPAND);

        var fulfilledTransaction = transactionsService.GetPaymentTransactionsId(
            transaction.Id, SPACE_ID, EMPTY_EXPAND);

        Assert.That(fulfilledTransaction.State, Is.EqualTo(TransactionState.FULFILL),
            "Transaction state must be FULFILL");

        Assert.That(fulfilledTransactionCompletion.State, Is.EqualTo(TransactionCompletionState.SUCCESSFUL),
            "Transaction completion state must be SUCCESSFUL");

        Assert.That(transactionsService.GetPaymentTransactionsIdCheckTokenCreationPossible(
            fulfilledTransaction.Id, SPACE_ID), Is.True,
            "Should be possible to create token for successful transaction");
    }

    /// <summary>
    /// Creates, authorizes and voids a transaction.
    ///
    /// -Verifies that:
    ///     -It's possible to create a transaction token for the voided transaction
    /// </summary>
    [Test]
    public void CheckIfPossibleToCreateTokenForVoidedTransaction()
    {
        var transactionCreate = GetTransactionCreatePayload();
        transactionCreate.TokenizationMode = TokenizationMode.FORCECREATION;
        transactionCreate.CustomersPresence = CustomersPresence.NOTPRESENT;
        transactionCreate.CompletionBehavior = TransactionCompletionBehavior.COMPLETEDEFERRED;

        var transaction = Create(transactionCreate);

        var authorizedTransaction = transactionsService.PostPaymentTransactionsIdProcessCardDetails(
            transaction.Id, SPACE_ID, MOCK_CARD_DATA, EMPTY_EXPAND);

        Assert.That(authorizedTransaction.State, Is.EqualTo(TransactionState.AUTHORIZED),
            "Transaction state should be AUTHORIZED");

        var transactionVoid = transactionsService.PostPaymentTransactionsIdVoidOnline(
            authorizedTransaction.Id, SPACE_ID, EMPTY_EXPAND);

        var voidedTransaction = transactionsService.GetPaymentTransactionsId(
            transaction.Id, SPACE_ID, EMPTY_EXPAND);

        Assert.That(transactionVoid.State, Is.EqualTo(TransactionVoidState.SUCCESSFUL),
            "Transaction void state should be SUCCESSFUL");

        Assert.That(voidedTransaction.State, Is.EqualTo(TransactionState.VOIDED),
            "Transaction state should be VOIDED");

        Assert.That(transactionsService.GetPaymentTransactionsIdCheckTokenCreationPossible(
            voidedTransaction.Id, SPACE_ID), Is.True,
            "Should be possible to create token for voided transaction");
    }

    /// <summary>
    /// Creates transaction token for a transaction.
    ///
    /// -Verifies that:
    ///     -Token contains space ID
    ///     -Token contains transaction ID
    /// </summary>
    [Test]
    public void CreateTransactionCredentialsShouldCreateTransactionToken()
    {
        var transaction = Create(GetTransactionCreatePayload());

        var credentials = GetCredentials(transaction.Id);

        Assert.That(credentials.StartsWith(SPACE_ID.ToString()),
            "Transaction credentials token should have valid format");

        Assert.That(transaction.Id, Is.Not.Null,
            "Transaction ID should not be null");

        Assert.That(credentials.Contains(transaction.Id.ToString()),
            "Transaction credentials token should contain transaction id");
    }

    /// <summary>
    /// Gets IFrame payment URL for transaction.
    ///
    /// -Verifies that:
    ///     -URL contains space ID
    ///     -URL contains transaction ID
    /// </summary>
    [Test]
    public void FetchIFrameUrlShouldReturnValidUrl()
    {
        var transaction = Create(GetTransactionCreatePayload());

        var iFrameUrl = transactionsService.GetPaymentTransactionsIdIframeJavascriptUrl(
            transaction.Id, SPACE_ID);

        Assert.That(iFrameUrl.Contains(SPACE_ID.ToString()),
            "IFrame JavaScript URL should contain space id");

        Assert.That(iFrameUrl.Contains(transaction.Id.ToString()),
            "IFrame JavaScript URL should contain transaction id");
    }

    /// <summary>
    /// Gets Lightbox payment URL for transaction.
    ///
    /// -Verifies that:
    ///     -URL contains space ID
    ///     -URL contains transaction ID
    /// </summary>
    [Test]
    public void FetchLightboxUrlShouldReturnValidUrl()
    {
        var transaction = Create(GetTransactionCreatePayload());

        var lightboxUrl = transactionsService.GetPaymentTransactionsIdLightboxJavascriptUrl(
            transaction.Id, SPACE_ID);

        Assert.That(lightboxUrl.Contains(SPACE_ID.ToString()),
            "Lightbox URL should contain space id");

        Assert.That(lightboxUrl.Contains(transaction.Id.ToString()),
            "Lightbox URL should contain transaction id");
    }

    /// <summary>
    /// Creates, authorizes, completes transaction and gets invoice file.
    ///
    /// -Creates, authorizes and completes transaction
    /// -Gets transaction invoice file
    ///
    /// -Verifies that:
    ///     -File title contains "invoice"
    ///     -File mime type is PDF
    /// </summary>
    [Test]
    public void FetchInvoiceShouldReturnPdfFile()
    {
        var transaction = Create(GetTransactionCreatePayload());

        var authorizedTransaction = transactionsService.PostPaymentTransactionsIdProcessCardDetails(
            transaction.Id, SPACE_ID, MOCK_CARD_DATA, EMPTY_EXPAND);

        var fulfilledTransactionCompletion = transactionsService.PostPaymentTransactionsIdCompleteOnline(
            authorizedTransaction.Id, SPACE_ID, EMPTY_EXPAND);

        var fulfilledTransaction = transactionsService.GetPaymentTransactionsId(
            transaction.Id, SPACE_ID, EMPTY_EXPAND);

        var invoice = transactionsService.GetPaymentTransactionsIdInvoiceDocument(
            fulfilledTransaction.Id, SPACE_ID);

        Assert.That(invoice.Title, Is.Not.Null,
            "Invoice title should not be null");

        Assert.That(invoice.Title.ToLower().Contains("invoice"),
            "Invoice title should contain the word 'invoice'");

        Assert.That(invoice.MimeType, Is.Not.Null,
            "Invoice MIME type should not be null");

        Assert.That(invoice.MimeType.ToLower().Contains("pdf"),
            "Invoice MIME type should be PDF");
    }

    /// <summary>
    /// Creates, authorizes, completes transaction and gets packing slip.
    ///
    /// -Creates, authorizes and completes transaction
    /// -Gets transaction packing slip
    ///
    /// -Verifies that:
    ///     -File title contains "packing slip"
    ///     -File mime type is PDF
    /// </summary>
    [Test]
    public void FetchPackageSlipShouldReturnPdfFile()
    {
        var transaction = Create(GetTransactionCreatePayload());

        var authorizedTransaction = transactionsService.PostPaymentTransactionsIdProcessCardDetails(
            transaction.Id, SPACE_ID, MOCK_CARD_DATA, EMPTY_EXPAND);

        var fulfilledTransactionCompletion = transactionsService.PostPaymentTransactionsIdCompleteOnline(
            authorizedTransaction.Id, SPACE_ID, EMPTY_EXPAND);

        var fulfilledTransaction = transactionsService.GetPaymentTransactionsId(
            transaction.Id, SPACE_ID, EMPTY_EXPAND);

        var packingSlip = transactionsService.GetPaymentTransactionsIdPackingSlipDocument(
            fulfilledTransaction.Id, SPACE_ID);

        Assert.That(packingSlip.Title, Is.Not.Null,
            "Packing slip title should not be null");

        Assert.That(packingSlip.Title.ToLower().Contains("packing slip"),
            "Packing slip title should contain 'packing slip'");

        Assert.That(packingSlip.MimeType, Is.Not.Null,
            "Packing slip MIME type should not be null");

        Assert.That(packingSlip.MimeType.ToLower().Contains("pdf"),
            "Packing slip MIME type should be PDF");
    }

    /// <summary>
    /// Creates transaction and gets payment methods configuration.
    ///
    /// -Creates transaction
    /// -Gets payment methods configuration
    ///
    /// -Verifies that:
    ///     -Payment methods are present
    /// </summary>
    [Test]
    public void FetchPaymentMethodsByIDShouldReturnAvailablePaymentMethods()
    {
        var transaction = Create(GetTransactionCreatePayload());

        var methodConfigListResponse = transactionsService.GetPaymentTransactionsIdPaymentMethodConfigurations(
            transaction.Id, INTEGRATION_MODE, SPACE_ID, EMPTY_EXPAND);

        Assert.That(methodConfigListResponse.Data, Is.Not.Null,
            "The payment method list should be present");

        Assert.That(methodConfigListResponse.Data.Any(),
            "Payment methods should be configured for the transaction in test space");
    }

    /// <summary>
    /// Creates transaction and finds it by credentials.
    ///
    /// -Creates transaction and gets its credentials
    /// -Finds transaction by credentials
    ///
    /// -Verifies that:
    ///     -Transaction is present
    /// </summary>
    [Test]
    public void FetchTransactionWithCredentialsShouldReturnTransaction()
    {
        var transaction = Create(GetTransactionCreatePayload());

        var credentials = transactionsService.GetPaymentTransactionsIdCredentials(transaction.Id, SPACE_ID);

        var retrievedTransaction = transactionsService.GetPaymentTransactionsByCredentialsCredentials(
            credentials, SPACE_ID, EMPTY_EXPAND);

        Assert.That(retrievedTransaction, Is.Not.Null,
            "Transaction must be present when fetched using credentials");
    }

    /// <summary>
    /// Creates transaction and gets payment methods configuration by credentials.
    ///
    /// -Creates transaction and gets its credentials
    /// -Gets payment methods configuration by credentials
    ///
    /// -Verifies that:
    ///     -Payment methods are present
    /// </summary>
    [Test]
    public void FetchPaymentMethodsWithCredentialsShouldReturnAvailablePaymentMethods()
    {
        var transaction = Create(GetTransactionCreatePayload());

        var credentials = GetCredentials(transaction.Id);

        var methodConfigListResponse = transactionsService
            .GetPaymentTransactionsByCredentialsCredentialsPaymentMethodConfigurations(
                credentials, INTEGRATION_MODE, SPACE_ID, EMPTY_EXPAND);

        Assert.That(methodConfigListResponse.Data, Is.Not.Null,
            "The payment method list should be present.");

        Assert.That(methodConfigListResponse.Data.Any(),
            "Payment methods should be configured for a given transaction in test space");
    }

    /// <summary>
    /// Creates and exports a transaction.
    ///
    /// -Verifies that:
    ///     -Export file exists
    /// </summary>
    [Test]
    public void ExportTransactionsShouldReturnFile()
    {
        var transaction = Create(GetTransactionCreatePayload());

        var fields = new List<string> { "id" };

        Assert.That(transaction.Id, Is.Not.Null);

        using var exportStream = transactionsService.GetPaymentTransactionsExport(
            SPACE_ID, fields, 1, 0, "id:ASC", $"id:{transaction.Id}");

        Assert.That(exportStream, Is.Not.Null, "Export stream should not be null");

        using var memoryStream = new MemoryStream();
        exportStream.CopyTo(memoryStream);

        Assert.That(memoryStream.Length, Is.GreaterThan(0), "Export stream should contain data");
    }

    /// <summary>
    /// Gets transaction by invalid credentials.
    ///
    /// -Attempts to retrieve a transaction using invalid credentials
    ///
    /// -Verifies that:
    ///     -Operation fails as expected
    /// </summary>
    [Test]
    public void FetchWithCredentialsWithGivenBadCredentialsShouldFail()
    {
        var ex = Assert.Throws<ApiException>(() =>
        {
            transactionsService.GetPaymentTransactionsByCredentialsCredentials(
                "bad_credentials", SPACE_ID, EMPTY_EXPAND);
        });

        Assert.That(ex, Is.Not.Null, "Bad token should trigger an error response");
    }

    /// <summary>
    /// Creates and updates a transaction.
    ///
    /// -Verifies that:
    ///     -Update was successful
    ///     -Version was incremented correctly
    /// </summary>
    [Test]
    public void UpdateShouldChangeTransactionData()
    {
        var transaction = Create(GetTransactionCreatePayload());

        var update = new TransactionPending
        {
            Language = "en-GB",
            VarVersion = 2
        };

        var updatedTransaction = transactionsService.PatchPaymentTransactionsId(
            transaction.Id, SPACE_ID, update, EMPTY_EXPAND);

        Assert.That(updatedTransaction.Language, Is.EqualTo("en-GB"),
            "Transaction language should be updated");

        Assert.That(updatedTransaction.MerchantReference, Is.EqualTo(transaction.MerchantReference),
            "Merchant reference should remain unchanged");

        Assert.That(updatedTransaction.VarVersion, Is.EqualTo(2),
            "Version should be updated to 2");
    }

    /// <summary>
    /// Tests one-click token flow: creation, update, usage, deletion.
    ///
    /// -Creates token
    /// -Updates token settings (enabling one click payment)
    /// -Creates transaction with linked token
    /// -Processes and completes transaction
    /// -Creates new transaction and completes it using token
    /// -Deletes the token and ensures it's state is deleted
    /// </summary>
    [Test]
    public void ProcessOneClickTokenAndRedirectWithCredentialsShouldReturnPaymentUrl()
    {
        var tokenCreate = new TokenCreate
        (
            state: CreationEntityState.ACTIVE,
            tokenReference: "testtoken",
            customerId: TEST_CUSTOMER_ID.ToString(),
            externalId: Guid.NewGuid().ToString(),
            customerEmailAddress: "test@domain.com"
        );

        var token = tokensService.PostPaymentTokens(SPACE_ID, tokenCreate, EMPTY_EXPAND);
        Assert.That(token.VarVersion, Is.Not.Null);

        var tokenUpdate = new TokenUpdate
        {
            VarVersion = token.VarVersion,
            EnabledForOneClickPayment = true
        };

        var updatedToken = tokensService.PatchPaymentTokensId(token.Id, SPACE_ID, tokenUpdate, EMPTY_EXPAND);

        var transaction1 = tokensService.PostPaymentTokensIdCreateTransactionForTokenUpdate(token.Id, SPACE_ID, EMPTY_EXPAND);

        var lineItem = new LineItemCreate(
            name: "Red T-Shirt",
            uniqueId: "5412",
            type: LineItemType.PRODUCT,
            quantity: 1m,
            amountIncludingTax: 29.95m,
            sku: "red-t-shirt-789"
        );

        var transaction1Pending = new TransactionPending
        (
            lineItems: [lineItem],
            varVersion: 2,
            currency: "CHF"
        );

        transactionsService.PatchPaymentTransactionsId(transaction1.Id, SPACE_ID, transaction1Pending, EMPTY_EXPAND);

        var processedTransaction1 = transactionsService.PostPaymentTransactionsIdProcessCardDetails(
            transaction1.Id, SPACE_ID, MOCK_CARD_DATA, EMPTY_EXPAND);

        var completion1 = transactionsService.PostPaymentTransactionsIdCompleteOnline(transaction1.Id, SPACE_ID, EMPTY_EXPAND);

        var transactionCreate2 = GetTransactionCreatePayload();
        transactionCreate2.TokenizationMode = TokenizationMode.FORCECREATIONWITHONECLICKPAYMENT;
        transactionCreate2.CustomersPresence = CustomersPresence.NOTPRESENT;
        transactionCreate2.CompletionBehavior = TransactionCompletionBehavior.COMPLETEDEFERRED;
        transactionCreate2.CustomerId = TEST_CUSTOMER_ID.ToString();

        var transaction2 = Create(transactionCreate2);

        var credentials1 = GetCredentials(transaction1.Id);
        var credentials2 = GetCredentials(transaction2.Id);

        var paymentUrl2 = transactionsService.PostPaymentTransactionsByCredentialsCredentialsOneClickTokensIdProcess(
            credentials2, updatedToken.Id, SPACE_ID);

        Assert.That(paymentUrl2, Is.Not.Empty, "Url should not be empty");
        Assert.That(paymentUrl2, Is.Not.Null, "Url should not be null");

        var readTransaction2 = transactionsService.GetPaymentTransactionsId(transaction2.Id, SPACE_ID, EMPTY_EXPAND);
        Assert.That(readTransaction2.State, Is.EqualTo(TransactionState.AUTHORIZED), "State must be AUTHORIZED");

        Assert.That(readTransaction2.State, Is.Not.EqualTo(TransactionCompletionState.FAILED), "Transaction state should not be FAILED");
        Assert.That(readTransaction2.State, Is.Not.EqualTo(TransactionCompletionState.PENDING), "Transaction state should not be PENDING");

        var completedTransaction1 = transactionsService.PostPaymentTransactionsIdCompleteOnline(
            transaction1.Id, SPACE_ID, EMPTY_EXPAND);

        Assert.That(completedTransaction1.State, Is.EqualTo(TransactionCompletionState.SUCCESSFUL));
    }

    /// <summary>
    /// Processes transaction via token
    ///
    /// -Creates token
    /// -Creates transaction with linked token
    /// -Processes and completes transaction
    /// -Creates new transaction and completes it using token
    /// </summary>
    [Test]
    public void ProcessTransactionViaTokenShouldProcessTransaction()
    {
        var lineItem = new LineItemCreate(
            name: "Red T-Shirt",
            uniqueId: "5412",
            type: LineItemType.PRODUCT,
            quantity: 1m,
            amountIncludingTax: 29.95m,
            sku: "red-t-shirt-789"
        );

        var tokenCreate = new TokenCreate
        (
            state: CreationEntityState.ACTIVE,
            tokenReference: "testtoken",
            customerId: TEST_CUSTOMER_ID.ToString(),
            externalId: Guid.NewGuid().ToString(),
            customerEmailAddress: "test@domain.com"
        );

        var token = tokensService.PostPaymentTokens(SPACE_ID, tokenCreate, EMPTY_EXPAND);

        var transaction = tokensService.PostPaymentTokensIdCreateTransactionForTokenUpdate(
            token.Id, SPACE_ID, EMPTY_EXPAND);

        var transaction1Pending = new TransactionPending
        (
            lineItems: [lineItem],
            varVersion: 2,
            currency: "CHF"
        );

        transactionsService.PatchPaymentTransactionsId(transaction.Id, SPACE_ID, transaction1Pending, EMPTY_EXPAND);

        var processedTransaction = transactionsService.PostPaymentTransactionsIdProcessCardDetails(
            transaction.Id, SPACE_ID, MOCK_CARD_DATA, EMPTY_EXPAND);

        var completion = transactionsService.PostPaymentTransactionsIdCompleteOnline(transaction.Id, SPACE_ID, EMPTY_EXPAND);

        var transaction2 = Create(GetTransactionCreatePayload());
        var transactionPending = new TransactionPending
        (
            token: token.Id,
            varVersion: transaction2.VarVersion,
            currency: "CHF",
            lineItems: [lineItem]
        );

        var updatedTransaction2 = transactionsService.PatchPaymentTransactionsId(
            transaction2.Id, SPACE_ID, transactionPending, EMPTY_EXPAND);

        var charge = transactionsService.PostPaymentTransactionsIdProcessWithToken(
            updatedTransaction2.Id, SPACE_ID, EMPTY_EXPAND);

        Assert.That(charge.State, Is.EqualTo(ChargeState.SUCCESSFUL), "Charge state must be SUCCESSFUL");

        var readTransaction2 = transactionsService.GetPaymentTransactionsId(transaction2.Id, SPACE_ID, EMPTY_EXPAND);

        Assert.That(readTransaction2.Token.Id, Is.EqualTo(token.Id), "Token ID should match");
        Assert.That(readTransaction2.State, Is.EqualTo(TransactionState.FULFILL), "Transaction must be fulfilled");
    }

    /// <summary>
    /// Verifies non-interactive transaction processing.
    ///
    /// -Processes a transaction without user interaction
    ///
    /// -Verifies that:
    ///     -Transaction reaches the AUTHORIZED state
    /// </summary>
    [Test]
    public void ProcessWithoutUserInteractionShouldProcessTransactionProperly()
    {
        var transaction = Create(GetTransactionCreatePayload());

        var processedTransaction = transactionsService.PostPaymentTransactionsIdProcessWithoutInteraction(
            transaction.Id, SPACE_ID, EMPTY_EXPAND);

        Assert.That(processedTransaction.Id, Is.EqualTo(transaction.Id), "Transaction IDs must match");
        Assert.That(processedTransaction.State, Is.EqualTo(TransactionState.PROCESSING), "State should be PROCESSING");
    }

    /// <summary>
    /// Retrieves tokens by transaction credentials.
    ///
    /// -Creates a new transaction
    /// -Attempts to retrieve one-click tokens
    ///
    /// -Verifies that:
    ///     -Response data is present
    /// </summary>
    [Test]
    public void FetchOneClickTokenShouldReturnResponseWithoutException()
    {
        Assert.DoesNotThrow(() =>
        {
            var transaction = Create(GetTransactionCreatePayload());
            var credentials = GetCredentials(transaction.Id);

            var tokens = transactionsService.GetPaymentTransactionsByCredentialsCredentialsOneClickTokens(
                credentials, SPACE_ID, EMPTY_EXPAND);

            Assert.That(tokens, Is.Not.Null);
            Assert.That(tokens.Data, Is.Not.Null, "Token data should not be null");
        });
    }

    /// <summary>
    /// Processes transaction with 3-D security
    ///
    /// -Creates a new transaction
    /// -Processes transaction with 3-D security
    ///
    /// -Verifies that:
    ///     -Returned url contains space id
    ///     -Returned url contains securityToken
    ///     -Transaction state is fulfilled
    /// </summary>
    [Test]
    public void ProcessTransactionWithThreeDSecureShouldFulfillTransaction()
    {
        var transaction = Create(GetTransactionCreatePayload());

        var tokenizedCardDataCreate = new TokenizedCardDataCreate
        (
            expiryDate: MOCK_CARD_DATA.CardData.ExpiryDate,
            primaryAccountNumber: MOCK_CARD_DATA.CardData.PrimaryAccountNumber
        );

        var request = new TokenizedCardRequest
        {
            CardData = tokenizedCardDataCreate,
            PaymentMethodConfiguration = TEST_CARD_PAYMENT_METHOD_CONFIGURATION_ID
        };

        var url = transactionsService.PostPaymentTransactionsIdProcessCardDetailsThreed(
            transaction.Id, SPACE_ID, request);

        var processed = transactionsService.GetPaymentTransactionsId(transaction.Id, SPACE_ID, EMPTY_EXPAND);

        Assert.That(url, Is.Not.Null, "Url should not be null");
        Assert.That(url, Is.Not.Empty, "Url should not be empty");
        Assert.That(processed.State, Is.Not.EqualTo(TransactionState.FAILED), "Transaction state should not be FAILED");
        Assert.That(processed.State, Is.Not.EqualTo(TransactionState.PENDING), "Transaction state should not be PENDING");
    }

    /// <summary>
    /// Gets mobile sdk url by credentials
    ///
    /// -Creates a new transaction
    /// -Gets mobile sdk url
    ///
    /// -Verifies that:
    ///     -Returned url contains space id
    ///     -Returned url contains securityToken
    /// </summary>
    [Test]
    public void FetchMobileSdkUrlByCredentialsShouldReturnValidUrl()
    {
        var transaction = Create(GetTransactionCreatePayload());
        var credentials = GetCredentials(transaction.Id);

        var url = transactionsService.GetPaymentTransactionsByCredentialsCredentialsMobileSdkUrl(
            credentials, SPACE_ID);

        Assert.That(url, Does.Contain($"/s/{SPACE_ID}"), "URL should contain space ID");
        Assert.That(url, Does.Contain("securityToken="), "URL should contain security token");
    }

    /// <summary>
    /// Gets all terminal receipts for transaction.
    ///
    /// -Verifies that:
    ///     -Terminal receipts list is empty as they were now created
    /// </summary>
    [Test]
    public void FetchTerminalReceiptsShouldReturnValidTerminalReceiptsList()
    {
        var transaction = Create(GetTransactionCreatePayload());

        var authorizedTransaction = transactionsService.PostPaymentTransactionsIdProcessCardDetails(
            transaction.Id, SPACE_ID, MOCK_CARD_DATA, EMPTY_EXPAND);

        var completed = transactionsService.PostPaymentTransactionsIdCompleteOnline(
            authorizedTransaction.Id, SPACE_ID, EMPTY_EXPAND);

        var receiptList = transactionsService.GetPaymentTransactionsIdTerminalReceipts(
            transaction.Id, TerminalReceiptFormat.TXT, 200, SPACE_ID);

        Assert.That(receiptList, Is.Not.Null, "Response should be present");
        Assert.That(receiptList.Data.Count, Is.EqualTo(0), "No terminal receipts should exist for this transaction");
    }

    /// <summary>
    /// Updates charge flow recipient for processing transaction
    ///
    /// -Verifies that:
    ///     -Operations was made without exceptions
    /// </summary>
    [Test]
    public void UpdateChargeFlowRecipientShouldNotThrowException()
    {
        var transaction = Create(GetTransactionCreatePayload());

        var processingTransaction = transactionsService.PostPaymentTransactionsIdChargeFlowApply(
            transaction.Id, SPACE_ID, EMPTY_EXPAND);

        Assert.That(processingTransaction.State, Is.EqualTo(TransactionState.PROCESSING), "State should be PROCESSING");

        Assert.DoesNotThrow(() =>
        {
            transactionsService.PostPaymentTransactionsIdChargeFlowUpdateRecipient(
                transaction.Id, 1453447675844L, "test2@domain.com", SPACE_ID);
        }, "ApiException should not be thrown when updating recipient");
    }

    /// <summary>
    /// Gets last version of line items list
    ///
    /// -Creates a new transaction
    /// -Gets line items
    ///
    /// -Verifies that:
    ///     -Amount is correct
    ///     -Version is correct
    ///     -Transaction id is same in transaction and charge
    /// </summary>
    [Test]
    public void FetchLineItemsVersionShouldReturnLatestLineItemsVersion()
    {
        var transaction = Create(GetTransactionCreatePayload());

        var authorizedTransaction = transactionsService.PostPaymentTransactionsIdProcessCardDetails(
            transaction.Id, SPACE_ID, MOCK_CARD_DATA, EMPTY_EXPAND);

        var completedTransaction = transactionsService.PostPaymentTransactionsIdCompleteOnline(
            authorizedTransaction.Id, SPACE_ID, EMPTY_EXPAND);

        var lineItems = transactionsService.GetPaymentTransactionsIdLatestLineItemVersion(
            transaction.Id, SPACE_ID, EMPTY_EXPAND);

        Assert.That(lineItems.VarVersion, Is.EqualTo(1), "Line items version should be 1");
        Assert.That(lineItems.Amount, Is.EqualTo(29.95m), "Amount should be 29.95");
        Assert.That(lineItems.LinkedTransaction, Is.EqualTo(transaction.Id), "Transaction IDs should match");
    }

    private static Transaction Create(TransactionCreate transactionCreate)
    {
        return transactionsService.PostPaymentTransactions(SPACE_ID, transactionCreate, EMPTY_EXPAND);
    }

    private static string GetCredentials(long transactionId)
    {
        return transactionsService.GetPaymentTransactionsIdCredentials(transactionId, SPACE_ID);
    }
}
