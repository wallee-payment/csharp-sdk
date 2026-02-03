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

using NUnit.Framework;
using Wallee.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using Wallee.Service;
using static Wallee.Test.Constants;
using static Wallee.Test.TestUtils;
using Wallee.Client;


namespace Wallee.Test;

/// <summary>
/// Api querying features test using transactions service
/// </summary>
[TestFixture]
public class QueryingTests
{
    // Singleton (single) instance for Configuration. See more: <see cref="Constants.Config"/>
    private static readonly Configuration configuration = Constants.Config;
    private static TransactionsService transactionsService;
    private static Transaction transaction1;
    private static Transaction transaction2;

    [OneTimeSetUp]
    public static void SetUp()
    {
        transactionsService = new TransactionsService(configuration);

        var transactionBase = transactionsService.PostPaymentTransactions(
            SPACE_ID, GetTransactionCreatePayload(), new List<string>());

        var authorizedTransaction = transactionsService.PostPaymentTransactionsIdProcessCardDetails(
            transactionBase.Id, SPACE_ID, MOCK_CARD_DATA, new List<string>());

        var transactionsIdCompletion = transactionsService.PostPaymentTransactionsIdCompleteOnline(
            authorizedTransaction.Id, SPACE_ID, new List<string>());

        transaction1 = transactionsService.GetPaymentTransactionsId(
            authorizedTransaction.Id, SPACE_ID, new List<string>());

        var transactionCreate = GetTransactionCreatePayload();
        transactionCreate.Currency = "USD";
        transactionCreate.MerchantReference = "Transaction for querying test";
        transaction2 = transactionsService.PostPaymentTransactions(
            SPACE_ID, transactionCreate, new List<string>());
    }

    /// <summary>
    /// Transaction search with limit parameter set to 2 items.
    /// </summary>
    [Test]
    public void SearchWithLimitShouldReturnCorrectAmountOfItems()
    {
        var transactionSearchResponse = transactionsService.GetPaymentTransactionsSearch(
            SPACE_ID, new List<string>(), 2, 0, "", "");

        Assert.That(2 == transactionSearchResponse.Data.Count,
            "Response should contain 2 items(as limited)");
    }

    /// <summary>
    /// Transaction search with offset parameter. Search is made with query which selects only 2 items
    /// and offset parameter is set to 1. Response should contain only one item which has higher id
    /// number.
    /// </summary>
    [Test]
    public void SearchWithOffsetShouldReturnCorrectResponse()
    {
        Assert.That(transaction1, Is.Not.Null, "First transaction should be present for this test");
        Assert.That(transaction2, Is.Not.Null, "Second transaction should be present for this test");

        var query = $"id:{transaction1.Id} OR id:{transaction2.Id}";
        var higherNumberId = Math.Max(transaction1.Id, transaction2.Id);

        var transactionSearchResponse = transactionsService.GetPaymentTransactionsSearch(
            SPACE_ID, new List<string>(), 2, 1, "id:ASC", query);

        Assert.That(higherNumberId, Is.EqualTo(transactionSearchResponse.Data.First().Id),
            "Response offset should be correct");
    }

    /// <summary>
    /// Transaction search using the 'before' parameter. Ensures that search returns transactions with
    /// IDs less than the given upperBoundTransactionId. The response should contain transaction with
    /// the lower ID (lowerBoundTransactionId), assuming it precedes the upperBoundTransactionId.
    /// </summary>
    [Test]
    public void SearchWithBeforeParameterShouldReturnCorrectResponses()
    {
        Assert.That(transaction1, Is.Not.Null, "First transaction must be initialized for this test");
        Assert.That(transaction2, Is.Not.Null, "Second transaction must be initialized for this test");

        var upperBoundTransactionId = Math.Max(transaction1.Id, transaction2.Id);
        var lowerBoundTransactionId = Math.Min(transaction1.Id, transaction2.Id);

        var response = transactionsService.GetPaymentTransactions(
            SPACE_ID, null, upperBoundTransactionId, new List<string>(), 10, SortingOrder.ASC);

        Assert.That(response.Data, Is.Not.Null, "Response data should not be null");
        Assert.That(
            response.Data.Any(t => t.Id.Equals(lowerBoundTransactionId)), Is.True,
            $"Response should contain the transaction with ID: {lowerBoundTransactionId}");
    }

    /// <summary>
    /// Transaction search made with query. Response should contain 2 items.
    /// </summary>
    [Test]
    public void FetchWithSearchQueryShouldReturnListWithValidItems()
    {
        Assert.That(transaction1, Is.Not.Null, "First transaction should be present for this test");
        Assert.That(transaction2, Is.Not.Null, "Second transaction should be present for this test");

        var query = $"id:{transaction1.Id} OR id:{transaction2.Id}";

        var transactionSearchResponse = transactionsService.GetPaymentTransactionsSearch(
            SPACE_ID, new List<string>(), 4, 0, "id:ASC", query);

        Assert.That(transactionSearchResponse, Is.Not.Null, "Response should be present");
        Assert.That(transactionSearchResponse.Data, Is.Not.Null);
        Assert.That(transactionSearchResponse.Data.Count, Is.EqualTo(2),
            "Response should contain only 2 items");
    }

    /// <summary>
    /// Transaction search made with query which contains quotes. Response should contain 1 item.
    /// </summary>
    [Test]
    public void FetchWithSearchQueryWithQuotesShouldReturnListWithValidItems()
    {
        Assert.That(transaction1, Is.Not.Null, "First transaction should be present for this test");
        Assert.That(transaction2, Is.Not.Null, "Second transaction should be present for this test");

        var query = $"merchantReference:\"Transaction for querying test\" AND id:{transaction2.Id}";

        var transactionSearchResponse = transactionsService.GetPaymentTransactionsSearch(
            SPACE_ID, new List<string>(), 4, 0, "id:ASC", query);

        Assert.That(transactionSearchResponse, Is.Not.Null, "Response should be present");
        Assert.That(transactionSearchResponse.Data, Is.Not.Null);
        Assert.That(transactionSearchResponse.Data.Count, Is.Not.EqualTo(0), "Response should contain more than 0 items");
        Assert.That(transactionSearchResponse.Data.Count, Is.EqualTo(1), "Response should contain 1 item");
    }

    /// <summary>
    /// Transaction search made with query which has isNull constraint. Response should contain 1 item.
    /// </summary>
    [Test]
    public void FetchWithQueryWithIsNullConstrainShouldReturnListWithValidItem()
    {
        Assert.That(transaction1, Is.Not.Null, "First transaction should be present for this test");

        var query = $"id:{transaction2.Id} AND paymentConnectorConfiguration:*";

        var transactionSearchResponse = transactionsService.GetPaymentTransactionsSearch(
            SPACE_ID, new List<string>(), 4, 0, "id:ASC", query);

        Assert.That(transactionSearchResponse, Is.Not.Null, "Response should be present");
        Assert.That(transactionSearchResponse.Data, Is.Not.Null);
        Assert.That(transactionSearchResponse.Data.Count, Is.EqualTo(1), "Response should contain only 1 item");
    }

    /// <summary>
    /// Transaction search made with query which has grouping. Response should contain 1 item.
    /// </summary>
    [Test]
    public void FetchWithQueryWithGroupingShouldReturnListWithValidItems()
    {
        Assert.That(transaction1, Is.Not.Null, "First transaction should be present for this test");
        Assert.That(transaction2, Is.Not.Null, "Second transaction should be present for this test");

        var query = $"id:{transaction1.Id} AND (currency:EUR OR currency:CHF)";

        var transactionSearchResponse = transactionsService.GetPaymentTransactionsSearch(
            SPACE_ID, new List<string>(), 4, 0, "id:ASC", query);

        Assert.That(transactionSearchResponse, Is.Not.Null, "Response should be present");
        Assert.That(transactionSearchResponse.Data, Is.Not.Null);
        Assert.That(transactionSearchResponse.Data.Count, Is.EqualTo(1),
            "Response should contain only 1 items");
    }

    /// <summary>
    /// Transaction search made with query which has range clause. Response should contain transaction
    /// with specific id.
    /// </summary>
    [Test]
    public void FetchWithQueryWithRangeShouldReturnListWithValidItems()
    {
        Assert.That(transaction1, Is.Not.Null, "First transaction should be present for this test");

        var query = $"id:>{transaction1.Id - 2} id:<={transaction1.Id + 2}";

        var transactionSearchResponse = transactionsService.GetPaymentTransactionsSearch(
            SPACE_ID, new List<string>(), 8, 0, "id:ASC", query);

        Assert.That(transactionSearchResponse, Is.Not.Null, "Response should be present");
        Assert.That(transactionSearchResponse.Data, Is.Not.Null);
        Assert.That(
            transactionSearchResponse.Data.Any(t => t.Id.Equals(transaction1.Id)), Is.True,
            "Transaction with expected ID should be found");
    }

    /// <summary>
    /// Transaction search made with query with contains clause. Response should contain more than 0 items.
    /// </summary>
    [Test]
    public void FetchWithQueryWithContainsClauseShouldReturnListWithValidItems()
    {
        Assert.That(transaction2, Is.Not.Null, "Second transaction should be present for this test");

        var query = "merchantReference:~querying";

        var transactionSearchResponse = transactionsService.GetPaymentTransactionsSearch(
            SPACE_ID, new List<string>(), 2, 0, "id:ASC", query);

        Assert.That(transactionSearchResponse, Is.Not.Null, "Response should be present");
        Assert.That(transactionSearchResponse.Data, Is.Not.Null);
        Assert.That(transactionSearchResponse.Data.Count, Is.GreaterThan(0), "Response should contain more than 0 items");
    }

     /// <summary>
     /// Transaction search made with query which includes a negation parameter.
     /// Response should not contain a transaction with a specific ID.
     /// Throws <see cref="ApiException"/> if the API call fails.
     /// </summary>
     [Test]
     public void FetchWithQueryWithNegationShouldReturnListWithValidItems()
     {
         Assert.That(transaction1, Is.Not.Null, "First transaction should be present for this test");

         var query = $"id:>{transaction1.Id - 2} id:<={transaction1.Id + 2} AND -id:{transaction1.Id}";

         var transactionSearchResponse = transactionsService.GetPaymentTransactionsSearch(
             SPACE_ID, new List<string>(), 8, 0, "id:ASC", query);

         Assert.That(transactionSearchResponse, Is.Not.Null, "Response should be present");
         Assert.That(transactionSearchResponse.Data, Is.Not.Null);

         Assert.That(transactionSearchResponse.Data.All(t => t.Id != transaction1.Id),
             "Transaction with excluded ID should not be found in the response");
     }


    /// <summary>
    /// Transaction search made with order clause. Items in response should be in descending order.
    /// </summary>
    [Test]
    public void SearchWithDescSortingShouldReturnSortedResponse()
    {
        Assert.That(transaction1, Is.Not.Null, "First transaction should be present for this test");
        Assert.That(transaction2, Is.Not.Null, "Second transaction should be present for this test");

        var transactionSearchResponse = transactionsService.GetPaymentTransactionsSearch(
            SPACE_ID, new List<string>(), 4, 0, "id:DESC", "");

        Assert.That(transactionSearchResponse.Data, Is.Not.Null);
        Assert.That(transactionSearchResponse.Data.First().Id, Is.Not.Null);
        Assert.That(transactionSearchResponse.Data.Last().Id, Is.Not.Null);

        var differenceBetweenFirstAndLast = transactionSearchResponse.Data.First().Id - transactionSearchResponse.Data.Last().Id;

        Assert.That(differenceBetweenFirstAndLast, Is.GreaterThan(0),
            "Response should be sorted descending. First id in DESC order should be higher than last");
    }

    /// <summary>
    /// Gets transaction with no expand parameters. Checks if response does not contain any data which
    /// should be present only when expand used. Example: group id should be present, but group state
    /// should be null.
    /// </summary>
    [Test]
    public void FetchWithNoExpandingShouldReturnCollapsedResponse()
    {
        Assert.That(transaction1, Is.Not.Null, "Transaction should be present for this test");

        var response = transactionsService.GetPaymentTransactionsId(
            transaction1.Id, SPACE_ID, new List<string>());

        Assert.That(response.Group, Is.Not.Null, "Group always should be present");
        Assert.That(response.Group.Id != 0, "Id always should be present");

        Assert.That(response.Group.State, Is.Null,
            "Group state should be null when response collapsed");
        Assert.That(response.Group.VarVersion, Is.EqualTo(0),
            "Group version should be null when response collapsed");
    }

    /// <summary>
    /// Gets transaction with expand parameters. Checks if response contains data which should be
    /// present when expand parameter is enabled. Example: group id and group state, version
    /// </summary>
    [Test]
    public void FetchWithExpandingShouldReturnExpandedResponse()
    {
        Assert.That(transaction1, Is.Not.Null, "Transaction should be present for this test");
        Assert.That(TransactionState.FULFILL == transaction1.State,
            "Transaction state should be FULFILLED for this test");

        var expandSet = new List<string> { "group", "paymentConnectorConfiguration" };

        var response = transactionsService.GetPaymentTransactionsId(
            transaction1.Id, SPACE_ID, expandSet);

        Assert.That(response.Group, Is.Not.Null, "Group always should be present");
        Assert.That(response.Group.Id, Is.Not.EqualTo(0), "Group id always should be present");

        Assert.That(response.Group.State, Is.Not.Null,
            "Group state should be present when response expanded");
        Assert.That(response.Group.VarVersion, Is.Not.EqualTo(0),
            "Group version should be present when response expanded");

        Assert.That(response.PaymentConnectorConfiguration, Is.Not.Null);
        Assert.That(response.PaymentConnectorConfiguration.ProcessorConfiguration, Is.Not.Null,
            "Both items in expand set should be expanded");
    }

    /// <summary>
    /// Gets transaction with nested expand parameter. Checks if response contains data related to
    /// parent item and to child item. Example: paymentConnectorConfiguration - parent item and
    /// processorConfiguration - child item.
    /// </summary>
    [Test]
    public void FetchWithNestedExpandingShouldReturnExpandedResponse()
    {
        Assert.That(transaction1, Is.Not.Null, "Transaction should be present for this test");
        Assert.That(transaction1.State, Is.EqualTo(TransactionState.FULFILL),
            "Transaction state should be FULFILLED for this test");

        var expandSet = new List<string> { "paymentConnectorConfiguration.processorConfiguration" };

        var response = transactionsService.GetPaymentTransactionsId(
            transaction1.Id, SPACE_ID, expandSet);

        Assert.That(response.PaymentConnectorConfiguration, Is.Not.Null);
        Assert.That(response.PaymentConnectorConfiguration.ProcessorConfiguration, Is.Not.Null);
        Assert.That(
            response.PaymentConnectorConfiguration.ProcessorConfiguration.LinkedSpaceId, Is.Not.EqualTo(0),
            "Items in nested response should be present");
    }

    /// <summary>
    /// Transaction search with single quote sign in query parameter.
    /// </summary>
    [Test]
    public void SearchWithLimitShouldReturnCorrectResponse()
    {
        var transactionSearchResponse = transactionsService.GetPaymentTransactionsSearch(
            SPACE_ID, new List<string>(), 1, 0, "", "completedOn:<'2026-01-15'");

        Assert.That(transactionSearchResponse.Data, Is.Not.Null);
        Assert.That(transactionSearchResponse.Data.Count, Is.Not.Zero);
        Assert.That(transactionSearchResponse.Data, Is.Not.Empty);
    }
}
