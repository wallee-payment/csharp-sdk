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
using Wallee.Model;
using Wallee.Service;
using static Wallee.Test.TestUtils;
using static Wallee.Test.Constants;
using Wallee.Client;

namespace Wallee.Test;

/// <summary>
/// Transaction completions service tests
/// </summary>
[TestFixture]
public class TransactionCompletionsServiceTests
{
    // Singleton (single) instance for Configuration.
    private static readonly Configuration configuration = Constants.Config;
    public static readonly List<string> EMPTY_EXPAND = new List<string>();
    private static TransactionsService transactionsService;
    private static TransactionCompletionsService transactionCompletionsService;

    [OneTimeSetUp]
    public static void SetUp()
    {
        transactionsService = new TransactionsService(configuration);
        transactionCompletionsService = new TransactionCompletionsService(configuration);
    }

    /// <summary>
    /// Transaction completion read should return valid data.
    /// Ids of transaction linked to Transaction completion and initial transaction should match.
    /// </summary>
    [Test]
    public void ReadShouldReturnCompletedTransactionData()
    {
        var transaction = Create(GetTransactionCreatePayload());

        var processedTransaction = transactionsService.PostPaymentTransactionsIdProcessCardDetails(
            transaction.Id, SPACE_ID, MOCK_CARD_DATA, EMPTY_EXPAND);

        Assert.That(processedTransaction.State, Is.EqualTo(TransactionState.FULFILL),
            "State must be FULFILL");

        var transactionCompletion = transactionsService.PostPaymentTransactionsIdCompleteOffline(
            transaction.Id, SPACE_ID, EMPTY_EXPAND);

        var readTransaction = transactionsService.GetPaymentTransactionsId(
            transaction.Id, SPACE_ID, EMPTY_EXPAND);

        Assert.That(transactionCompletion.LinkedTransaction, Is.EqualTo(readTransaction.Id),
            "Transaction ids must match");
    }

    private Transaction Create(TransactionCreate transactionCreate)
    {
        return transactionsService.PostPaymentTransactions(SPACE_ID, transactionCreate, EMPTY_EXPAND);
    }
}
