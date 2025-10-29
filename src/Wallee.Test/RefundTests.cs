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

using System.Collections.Generic;
using NUnit.Framework;
using Wallee.Client;
using Wallee.Model;
using Wallee.Service;
using static Wallee.Test.TestUtils;
using static Wallee.Test.Constants;

namespace Wallee.Test;

/// <summary>
/// Refunds service tests
/// </summary>
[TestFixture]
public class RefundTests
{
    // Singleton (single) instance for Configuration.
    private static readonly Configuration configuration = Constants.Config;
    public readonly static List<string> EMPTY_EXPAND = new List<string>();
    private static RefundsService refundsService;
    private static TransactionsService transactionsService;

    [OneTimeSetUp]
    public static void SetUp()
    {
        refundsService = new RefundsService(configuration);
        transactionsService = new TransactionsService(configuration);
    }

    /// <summary>
    /// Refund of fulfilled transaction should be created successfully
    /// </summary>
    [Test]
    public void RefundOfCompletedTransactionShouldWork()
    {
        var transaction = Create(GetTransactionCreatePayload());

        var processedTransaction = transactionsService.PostPaymentTransactionsIdProcessCardDetails(
            transaction.Id, SPACE_ID, MOCK_CARD_DATA, EMPTY_EXPAND);

        var transactionCompletion = transactionsService.PostPaymentTransactionsIdCompleteOffline(
            transaction.Id, SPACE_ID, EMPTY_EXPAND);

        Assert.That(transactionCompletion.State, Is.EqualTo(TransactionCompletionState.SUCCESSFUL),
            "Transaction completion state must be SUCCESSFUL");

        var readTransaction = transactionsService.GetPaymentTransactionsId(
            transaction.Id, SPACE_ID, EMPTY_EXPAND);

        Assert.That(readTransaction.State, Is.EqualTo(TransactionState.FULFILL),
            "Transaction state must be FULFILL");

        var refundCreate = GetRefundCreate(transaction);

        var refund = refundsService.PostPaymentRefunds(SPACE_ID, refundCreate, EMPTY_EXPAND);

        Assert.That(refund.State, Is.EqualTo(RefundState.SUCCESSFUL),
            "Refund state must be SUCCESSFUL");
    }

    /// <summary>
    /// Refund read should return valid data
    /// </summary>
    [Test]
    public void ReadShouldReturnRefundData()
    {
        var transaction = Create(GetTransactionCreatePayload());

        var processedTransaction = transactionsService.PostPaymentTransactionsIdProcessCardDetails(
            transaction.Id, SPACE_ID, MOCK_CARD_DATA, EMPTY_EXPAND);

        var transactionCompletion = transactionsService.PostPaymentTransactionsIdCompleteOffline(
            transaction.Id, SPACE_ID, EMPTY_EXPAND);

        Assert.That(transactionCompletion.State, Is.EqualTo(TransactionCompletionState.SUCCESSFUL),
            "Transaction completion state must be SUCCESSFUL");

        var readTransaction = transactionsService.GetPaymentTransactionsId(
            transaction.Id, SPACE_ID, EMPTY_EXPAND);

        var refundCreate = GetRefundCreate(transaction);

        var refund = refundsService.PostPaymentRefunds(SPACE_ID, refundCreate, EMPTY_EXPAND);

        Assert.That(refund.State, Is.EqualTo(RefundState.SUCCESSFUL),
            "Refund state must be SUCCESSFUL");

        var readRefund = refundsService.GetPaymentRefundsId(refund.Id, SPACE_ID, EMPTY_EXPAND);

        Assert.That(readRefund.Id, Is.EqualTo(refund.Id),
            "Refund ids should match");
    }

    private static RefundCreate GetRefundCreate(Transaction transaction)
    {
        var refundCreate = new RefundCreate(
            transaction: transaction.Id,
            type: RefundType.MERCHANTINITIATEDOFFLINE,
            externalId: System.Guid.NewGuid().ToString(),
            amount: 29.95m
        );
        return refundCreate;
    }

    private Transaction Create(TransactionCreate transactionCreate)
    {
        return transactionsService.PostPaymentTransactions(SPACE_ID, transactionCreate, EMPTY_EXPAND);
    }
}