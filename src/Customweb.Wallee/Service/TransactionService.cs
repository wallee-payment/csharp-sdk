/**
 * Wallee SDK Client
 *
 * This client allows to interact with the Wallee API.
 *
 * Wallee API: 1.0.0
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Customweb.Wallee.Client;
using Customweb.Wallee.Util;
using Customweb.Wallee.Model;

namespace Customweb.Wallee.Service
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITransactionService : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Build JavaScript URL
        /// </summary>
        /// <remarks>
        /// This operation creates the URL which can be used to embed the JavaScript for handling the iFrame checkout flow.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>string</returns>
        string BuildJavaScriptUrl (long? spaceId, long? id);

        /// <summary>
        /// Build JavaScript URL
        /// </summary>
        /// <remarks>
        /// This operation creates the URL which can be used to embed the JavaScript for handling the iFrame checkout flow.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> BuildJavaScriptUrlWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// Build Mobile SDK URL with Credentials
        /// </summary>
        /// <remarks>
        /// This operation builds the URL which is used to load the payment form within a WebView on a mobile device. This operation is typically called through the mobile SDK.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>string</returns>
        string BuildMobileSdkUrlWithCredentials (string credentials);

        /// <summary>
        /// Build Mobile SDK URL with Credentials
        /// </summary>
        /// <remarks>
        /// This operation builds the URL which is used to load the payment form within a WebView on a mobile device. This operation is typically called through the mobile SDK.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> BuildMobileSdkUrlWithCredentialsWithHttpInfo (string credentials);

        /// <summary>
        /// Build Payment Page URL
        /// </summary>
        /// <remarks>
        /// This operation creates the URL to which the user should be redirected to when the payment page should be used.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>string</returns>
        string BuildPaymentPageUrl (long? spaceId, long? id);

        /// <summary>
        /// Build Payment Page URL
        /// </summary>
        /// <remarks>
        /// This operation creates the URL to which the user should be redirected to when the payment page should be used.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> BuildPaymentPageUrlWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// Confirm
        /// </summary>
        /// <remarks>
        /// The confirm operation marks the transaction as confirmed. Once the transaction is confirmed no more changes can be applied.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionModel">The transaction JSON object to update and confirm.</param>
        /// <returns>Transaction</returns>
        Transaction Confirm (long? spaceId, TransactionPending transactionModel);

        /// <summary>
        /// Confirm
        /// </summary>
        /// <remarks>
        /// The confirm operation marks the transaction as confirmed. Once the transaction is confirmed no more changes can be applied.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionModel">The transaction JSON object to update and confirm.</param>
        /// <returns>ApiResponse of Transaction</returns>
        ApiResponse<Transaction> ConfirmWithHttpInfo (long? spaceId, TransactionPending transactionModel);

        /// <summary>
        /// Count
        /// </summary>
        /// <remarks>
        /// Counts the number of items in the database as restricted by the given filter.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>long?</returns>
        long? Count (long? spaceId, EntityQueryFilter filter = null);

        /// <summary>
        /// Count
        /// </summary>
        /// <remarks>
        /// Counts the number of items in the database as restricted by the given filter.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>ApiResponse of long?</returns>
        ApiResponse<long?> CountWithHttpInfo (long? spaceId, EntityQueryFilter filter = null);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// Creates the entity with the given properties.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transaction">The transaction object which should be created.</param>
        /// <returns>Transaction</returns>
        Transaction Create (long? spaceId, TransactionCreate transaction);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// Creates the entity with the given properties.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transaction">The transaction object which should be created.</param>
        /// <returns>ApiResponse of Transaction</returns>
        ApiResponse<Transaction> CreateWithHttpInfo (long? spaceId, TransactionCreate transaction);

        /// <summary>
        /// Create Transaction Credentials
        /// </summary>
        /// <remarks>
        /// This operation allows to create transaction credentials to delegate temporarily the access to the web service API for this particular transaction.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>string</returns>
        string CreateTransactionCredentials (long? spaceId, long? id);

        /// <summary>
        /// Create Transaction Credentials
        /// </summary>
        /// <remarks>
        /// This operation allows to create transaction credentials to delegate temporarily the access to the web service API for this particular transaction.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> CreateTransactionCredentialsWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// Delete One-Click Token with Credentials
        /// </summary>
        /// <remarks>
        /// This operation removes the given token.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <param name="tokenId">The token ID will be used to find the token which should be removed.</param>
        /// <returns></returns>
        void DeleteOneClickTokenWithCredentials (string credentials, long? tokenId);

        /// <summary>
        /// Delete One-Click Token with Credentials
        /// </summary>
        /// <remarks>
        /// This operation removes the given token.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <param name="tokenId">The token ID will be used to find the token which should be removed.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteOneClickTokenWithCredentialsWithHttpInfo (string credentials, long? tokenId);

        /// <summary>
        /// Export
        /// </summary>
        /// <remarks>
        /// Exports the transactions into a CSV file. The file will contain the properties defined in the request.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="request">The request controls the entries which are exported.</param>
        /// <returns>byte[]</returns>
        byte[] Export (long? spaceId, EntityExportRequest request);

        /// <summary>
        /// Export
        /// </summary>
        /// <remarks>
        /// Exports the transactions into a CSV file. The file will contain the properties defined in the request.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="request">The request controls the entries which are exported.</param>
        /// <returns>ApiResponse of byte[]</returns>
        ApiResponse<byte[]> ExportWithHttpInfo (long? spaceId, EntityExportRequest request);

        /// <summary>
        /// Fetch One Click Tokens with Credentials
        /// </summary>
        /// <remarks>
        /// This operation returns the token version objects which references the tokens usable as one-click payment tokens for the provided transaction.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>List&lt;TokenVersion&gt;</returns>
        List<TokenVersion> FetchOneClickTokensWithCredentials (string credentials);

        /// <summary>
        /// Fetch One Click Tokens with Credentials
        /// </summary>
        /// <remarks>
        /// This operation returns the token version objects which references the tokens usable as one-click payment tokens for the provided transaction.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>ApiResponse of List&lt;TokenVersion&gt;</returns>
        ApiResponse<List<TokenVersion>> FetchOneClickTokensWithCredentialsWithHttpInfo (string credentials);

        /// <summary>
        /// Fetch Possible Payment Methods
        /// </summary>
        /// <remarks>
        /// This operation allows to get the payment method configurations which can be used with the provided transaction.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>List&lt;PaymentMethodConfiguration&gt;</returns>
        List<PaymentMethodConfiguration> FetchPossiblePaymentMethods (long? spaceId, long? id);

        /// <summary>
        /// Fetch Possible Payment Methods
        /// </summary>
        /// <remarks>
        /// This operation allows to get the payment method configurations which can be used with the provided transaction.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>ApiResponse of List&lt;PaymentMethodConfiguration&gt;</returns>
        ApiResponse<List<PaymentMethodConfiguration>> FetchPossiblePaymentMethodsWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// Fetch Possible Payment Methods with Credentials
        /// </summary>
        /// <remarks>
        /// This operation allows to get the payment method configurations which can be used with the provided transaction.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>List&lt;PaymentMethodConfiguration&gt;</returns>
        List<PaymentMethodConfiguration> FetchPossiblePaymentMethodsWithCredentials (string credentials);

        /// <summary>
        /// Fetch Possible Payment Methods with Credentials
        /// </summary>
        /// <remarks>
        /// This operation allows to get the payment method configurations which can be used with the provided transaction.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>ApiResponse of List&lt;PaymentMethodConfiguration&gt;</returns>
        ApiResponse<List<PaymentMethodConfiguration>> FetchPossiblePaymentMethodsWithCredentialsWithHttpInfo (string credentials);

        /// <summary>
        /// getInvoiceDocument
        /// </summary>
        /// <remarks>
        /// Returns the PDF document for the transaction invoice with given id.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction to get the invoice document for.</param>
        /// <returns>RenderedDocument</returns>
        RenderedDocument GetInvoiceDocument (long? spaceId, long? id);

        /// <summary>
        /// getInvoiceDocument
        /// </summary>
        /// <remarks>
        /// Returns the PDF document for the transaction invoice with given id.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction to get the invoice document for.</param>
        /// <returns>ApiResponse of RenderedDocument</returns>
        ApiResponse<RenderedDocument> GetInvoiceDocumentWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// getLatestTransactionLineItemVersion
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction to get the latest line item version for.</param>
        /// <returns>TransactionLineItemVersion</returns>
        TransactionLineItemVersion GetLatestTransactionLineItemVersion (long? spaceId, long? id);

        /// <summary>
        /// getLatestTransactionLineItemVersion
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction to get the latest line item version for.</param>
        /// <returns>ApiResponse of TransactionLineItemVersion</returns>
        ApiResponse<TransactionLineItemVersion> GetLatestTransactionLineItemVersionWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// getPackingSlip
        /// </summary>
        /// <remarks>
        /// Returns the packing slip for the transaction with given id.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction to get the packing slip for.</param>
        /// <returns>RenderedDocument</returns>
        RenderedDocument GetPackingSlip (long? spaceId, long? id);

        /// <summary>
        /// getPackingSlip
        /// </summary>
        /// <remarks>
        /// Returns the packing slip for the transaction with given id.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction to get the packing slip for.</param>
        /// <returns>ApiResponse of RenderedDocument</returns>
        ApiResponse<RenderedDocument> GetPackingSlipWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// Process One-Click Token with Credentials
        /// </summary>
        /// <remarks>
        /// This operation assigns the given token to the transaction and process it.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <param name="tokenId">The token ID is used to load the corresponding token and to process the transaction with it.</param>
        /// <returns>Transaction</returns>
        Transaction ProcessOneClickTokenWithCredentials (string credentials, long? tokenId);

        /// <summary>
        /// Process One-Click Token with Credentials
        /// </summary>
        /// <remarks>
        /// This operation assigns the given token to the transaction and process it.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <param name="tokenId">The token ID is used to load the corresponding token and to process the transaction with it.</param>
        /// <returns>ApiResponse of Transaction</returns>
        ApiResponse<Transaction> ProcessOneClickTokenWithCredentialsWithHttpInfo (string credentials, long? tokenId);

        /// <summary>
        /// Process Without User Interaction
        /// </summary>
        /// <remarks>
        /// This operation processes the transaction without requiring that the customer is present. Means this operation applies strategies to process the transaction without a direct interaction with the buyer. This operation is suitable for recurring transactions.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be processed.</param>
        /// <returns>Transaction</returns>
        Transaction ProcessWithoutUserInteraction (long? spaceId, long? id);

        /// <summary>
        /// Process Without User Interaction
        /// </summary>
        /// <remarks>
        /// This operation processes the transaction without requiring that the customer is present. Means this operation applies strategies to process the transaction without a direct interaction with the buyer. This operation is suitable for recurring transactions.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be processed.</param>
        /// <returns>ApiResponse of Transaction</returns>
        ApiResponse<Transaction> ProcessWithoutUserInteractionWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>Transaction</returns>
        Transaction Read (long? spaceId, long? id);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>ApiResponse of Transaction</returns>
        ApiResponse<Transaction> ReadWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// Read With Credentials
        /// </summary>
        /// <remarks>
        /// Reads the transaction with the given &#39;id&#39; and returns it. This method uses the credentials to authenticate and identify the transaction.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>Transaction</returns>
        Transaction ReadWithCredentials (string credentials);

        /// <summary>
        /// Read With Credentials
        /// </summary>
        /// <remarks>
        /// Reads the transaction with the given &#39;id&#39; and returns it. This method uses the credentials to authenticate and identify the transaction.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>ApiResponse of Transaction</returns>
        ApiResponse<Transaction> ReadWithCredentialsWithHttpInfo (string credentials);

        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the transactions which are returned by the search.</param>
        /// <returns>List&lt;Transaction&gt;</returns>
        List<Transaction> Search (long? spaceId, EntityQuery query);

        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the transactions which are returned by the search.</param>
        /// <returns>ApiResponse of List&lt;Transaction&gt;</returns>
        ApiResponse<List<Transaction>> SearchWithHttpInfo (long? spaceId, EntityQuery query);

        /// <summary>
        /// Update
        /// </summary>
        /// <remarks>
        /// This updates the entity with the given properties. Only those properties which should be updated can be provided. The &#39;id&#39; and &#39;version&#39; are required to identify the entity.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The transaction object with the properties which should be updated.</param>
        /// <returns>Transaction</returns>
        Transaction Update (long? spaceId, TransactionPending entity);

        /// <summary>
        /// Update
        /// </summary>
        /// <remarks>
        /// This updates the entity with the given properties. Only those properties which should be updated can be provided. The &#39;id&#39; and &#39;version&#39; are required to identify the entity.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The transaction object with the properties which should be updated.</param>
        /// <returns>ApiResponse of Transaction</returns>
        ApiResponse<Transaction> UpdateWithHttpInfo (long? spaceId, TransactionPending entity);

        /// <summary>
        /// updateTransactionLineItems
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="updateRequest"></param>
        /// <returns>TransactionLineItemVersion</returns>
        TransactionLineItemVersion UpdateTransactionLineItems (long? spaceId, TransactionLineItemUpdateRequest updateRequest);

        /// <summary>
        /// updateTransactionLineItems
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="updateRequest"></param>
        /// <returns>ApiResponse of TransactionLineItemVersion</returns>
        ApiResponse<TransactionLineItemVersion> UpdateTransactionLineItemsWithHttpInfo (long? spaceId, TransactionLineItemUpdateRequest updateRequest);

        #endregion Synchronous Operations
        #region Asynchronous Operations

        /// <summary>
        /// Build JavaScript URL
        /// </summary>
        /// <remarks>
        /// This operation creates the URL which can be used to embed the JavaScript for handling the iFrame checkout flow.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> BuildJavaScriptUrlAsync (long? spaceId, long? id);

        /// <summary>
        /// Build JavaScript URL
        /// </summary>
        /// <remarks>
        /// This operation creates the URL which can be used to embed the JavaScript for handling the iFrame checkout flow.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> BuildJavaScriptUrlAsyncWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// Build Mobile SDK URL with Credentials
        /// </summary>
        /// <remarks>
        /// This operation builds the URL which is used to load the payment form within a WebView on a mobile device. This operation is typically called through the mobile SDK.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> BuildMobileSdkUrlWithCredentialsAsync (string credentials);

        /// <summary>
        /// Build Mobile SDK URL with Credentials
        /// </summary>
        /// <remarks>
        /// This operation builds the URL which is used to load the payment form within a WebView on a mobile device. This operation is typically called through the mobile SDK.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> BuildMobileSdkUrlWithCredentialsAsyncWithHttpInfo (string credentials);

        /// <summary>
        /// Build Payment Page URL
        /// </summary>
        /// <remarks>
        /// This operation creates the URL to which the user should be redirected to when the payment page should be used.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> BuildPaymentPageUrlAsync (long? spaceId, long? id);

        /// <summary>
        /// Build Payment Page URL
        /// </summary>
        /// <remarks>
        /// This operation creates the URL to which the user should be redirected to when the payment page should be used.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> BuildPaymentPageUrlAsyncWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// Confirm
        /// </summary>
        /// <remarks>
        /// The confirm operation marks the transaction as confirmed. Once the transaction is confirmed no more changes can be applied.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionModel">The transaction JSON object to update and confirm.</param>
        /// <returns>Task of Transaction</returns>
        System.Threading.Tasks.Task<Transaction> ConfirmAsync (long? spaceId, TransactionPending transactionModel);

        /// <summary>
        /// Confirm
        /// </summary>
        /// <remarks>
        /// The confirm operation marks the transaction as confirmed. Once the transaction is confirmed no more changes can be applied.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionModel">The transaction JSON object to update and confirm.</param>
        /// <returns>Task of ApiResponse (Transaction)</returns>
        System.Threading.Tasks.Task<ApiResponse<Transaction>> ConfirmAsyncWithHttpInfo (long? spaceId, TransactionPending transactionModel);

        /// <summary>
        /// Count
        /// </summary>
        /// <remarks>
        /// Counts the number of items in the database as restricted by the given filter.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>Task of long?</returns>
        System.Threading.Tasks.Task<long?> CountAsync (long? spaceId, EntityQueryFilter filter = null);

        /// <summary>
        /// Count
        /// </summary>
        /// <remarks>
        /// Counts the number of items in the database as restricted by the given filter.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>Task of ApiResponse (long?)</returns>
        System.Threading.Tasks.Task<ApiResponse<long?>> CountAsyncWithHttpInfo (long? spaceId, EntityQueryFilter filter = null);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// Creates the entity with the given properties.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transaction">The transaction object which should be created.</param>
        /// <returns>Task of Transaction</returns>
        System.Threading.Tasks.Task<Transaction> CreateAsync (long? spaceId, TransactionCreate transaction);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// Creates the entity with the given properties.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transaction">The transaction object which should be created.</param>
        /// <returns>Task of ApiResponse (Transaction)</returns>
        System.Threading.Tasks.Task<ApiResponse<Transaction>> CreateAsyncWithHttpInfo (long? spaceId, TransactionCreate transaction);

        /// <summary>
        /// Create Transaction Credentials
        /// </summary>
        /// <remarks>
        /// This operation allows to create transaction credentials to delegate temporarily the access to the web service API for this particular transaction.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> CreateTransactionCredentialsAsync (long? spaceId, long? id);

        /// <summary>
        /// Create Transaction Credentials
        /// </summary>
        /// <remarks>
        /// This operation allows to create transaction credentials to delegate temporarily the access to the web service API for this particular transaction.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> CreateTransactionCredentialsAsyncWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// Delete One-Click Token with Credentials
        /// </summary>
        /// <remarks>
        /// This operation removes the given token.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <param name="tokenId">The token ID will be used to find the token which should be removed.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteOneClickTokenWithCredentialsAsync (string credentials, long? tokenId);

        /// <summary>
        /// Delete One-Click Token with Credentials
        /// </summary>
        /// <remarks>
        /// This operation removes the given token.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <param name="tokenId">The token ID will be used to find the token which should be removed.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOneClickTokenWithCredentialsAsyncWithHttpInfo (string credentials, long? tokenId);

        /// <summary>
        /// Export
        /// </summary>
        /// <remarks>
        /// Exports the transactions into a CSV file. The file will contain the properties defined in the request.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="request">The request controls the entries which are exported.</param>
        /// <returns>Task of byte[]</returns>
        System.Threading.Tasks.Task<byte[]> ExportAsync (long? spaceId, EntityExportRequest request);

        /// <summary>
        /// Export
        /// </summary>
        /// <remarks>
        /// Exports the transactions into a CSV file. The file will contain the properties defined in the request.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="request">The request controls the entries which are exported.</param>
        /// <returns>Task of ApiResponse (byte[])</returns>
        System.Threading.Tasks.Task<ApiResponse<byte[]>> ExportAsyncWithHttpInfo (long? spaceId, EntityExportRequest request);

        /// <summary>
        /// Fetch One Click Tokens with Credentials
        /// </summary>
        /// <remarks>
        /// This operation returns the token version objects which references the tokens usable as one-click payment tokens for the provided transaction.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>Task of List&lt;TokenVersion&gt;</returns>
        System.Threading.Tasks.Task<List<TokenVersion>> FetchOneClickTokensWithCredentialsAsync (string credentials);

        /// <summary>
        /// Fetch One Click Tokens with Credentials
        /// </summary>
        /// <remarks>
        /// This operation returns the token version objects which references the tokens usable as one-click payment tokens for the provided transaction.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>Task of ApiResponse (List&lt;TokenVersion&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<TokenVersion>>> FetchOneClickTokensWithCredentialsAsyncWithHttpInfo (string credentials);

        /// <summary>
        /// Fetch Possible Payment Methods
        /// </summary>
        /// <remarks>
        /// This operation allows to get the payment method configurations which can be used with the provided transaction.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>Task of List&lt;PaymentMethodConfiguration&gt;</returns>
        System.Threading.Tasks.Task<List<PaymentMethodConfiguration>> FetchPossiblePaymentMethodsAsync (long? spaceId, long? id);

        /// <summary>
        /// Fetch Possible Payment Methods
        /// </summary>
        /// <remarks>
        /// This operation allows to get the payment method configurations which can be used with the provided transaction.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>Task of ApiResponse (List&lt;PaymentMethodConfiguration&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<PaymentMethodConfiguration>>> FetchPossiblePaymentMethodsAsyncWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// Fetch Possible Payment Methods with Credentials
        /// </summary>
        /// <remarks>
        /// This operation allows to get the payment method configurations which can be used with the provided transaction.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>Task of List&lt;PaymentMethodConfiguration&gt;</returns>
        System.Threading.Tasks.Task<List<PaymentMethodConfiguration>> FetchPossiblePaymentMethodsWithCredentialsAsync (string credentials);

        /// <summary>
        /// Fetch Possible Payment Methods with Credentials
        /// </summary>
        /// <remarks>
        /// This operation allows to get the payment method configurations which can be used with the provided transaction.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>Task of ApiResponse (List&lt;PaymentMethodConfiguration&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<PaymentMethodConfiguration>>> FetchPossiblePaymentMethodsWithCredentialsAsyncWithHttpInfo (string credentials);

        /// <summary>
        /// getInvoiceDocument
        /// </summary>
        /// <remarks>
        /// Returns the PDF document for the transaction invoice with given id.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction to get the invoice document for.</param>
        /// <returns>Task of RenderedDocument</returns>
        System.Threading.Tasks.Task<RenderedDocument> GetInvoiceDocumentAsync (long? spaceId, long? id);

        /// <summary>
        /// getInvoiceDocument
        /// </summary>
        /// <remarks>
        /// Returns the PDF document for the transaction invoice with given id.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction to get the invoice document for.</param>
        /// <returns>Task of ApiResponse (RenderedDocument)</returns>
        System.Threading.Tasks.Task<ApiResponse<RenderedDocument>> GetInvoiceDocumentAsyncWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// getLatestTransactionLineItemVersion
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction to get the latest line item version for.</param>
        /// <returns>Task of TransactionLineItemVersion</returns>
        System.Threading.Tasks.Task<TransactionLineItemVersion> GetLatestTransactionLineItemVersionAsync (long? spaceId, long? id);

        /// <summary>
        /// getLatestTransactionLineItemVersion
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction to get the latest line item version for.</param>
        /// <returns>Task of ApiResponse (TransactionLineItemVersion)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransactionLineItemVersion>> GetLatestTransactionLineItemVersionAsyncWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// getPackingSlip
        /// </summary>
        /// <remarks>
        /// Returns the packing slip for the transaction with given id.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction to get the packing slip for.</param>
        /// <returns>Task of RenderedDocument</returns>
        System.Threading.Tasks.Task<RenderedDocument> GetPackingSlipAsync (long? spaceId, long? id);

        /// <summary>
        /// getPackingSlip
        /// </summary>
        /// <remarks>
        /// Returns the packing slip for the transaction with given id.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction to get the packing slip for.</param>
        /// <returns>Task of ApiResponse (RenderedDocument)</returns>
        System.Threading.Tasks.Task<ApiResponse<RenderedDocument>> GetPackingSlipAsyncWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// Process One-Click Token with Credentials
        /// </summary>
        /// <remarks>
        /// This operation assigns the given token to the transaction and process it.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <param name="tokenId">The token ID is used to load the corresponding token and to process the transaction with it.</param>
        /// <returns>Task of Transaction</returns>
        System.Threading.Tasks.Task<Transaction> ProcessOneClickTokenWithCredentialsAsync (string credentials, long? tokenId);

        /// <summary>
        /// Process One-Click Token with Credentials
        /// </summary>
        /// <remarks>
        /// This operation assigns the given token to the transaction and process it.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <param name="tokenId">The token ID is used to load the corresponding token and to process the transaction with it.</param>
        /// <returns>Task of ApiResponse (Transaction)</returns>
        System.Threading.Tasks.Task<ApiResponse<Transaction>> ProcessOneClickTokenWithCredentialsAsyncWithHttpInfo (string credentials, long? tokenId);

        /// <summary>
        /// Process Without User Interaction
        /// </summary>
        /// <remarks>
        /// This operation processes the transaction without requiring that the customer is present. Means this operation applies strategies to process the transaction without a direct interaction with the buyer. This operation is suitable for recurring transactions.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be processed.</param>
        /// <returns>Task of Transaction</returns>
        System.Threading.Tasks.Task<Transaction> ProcessWithoutUserInteractionAsync (long? spaceId, long? id);

        /// <summary>
        /// Process Without User Interaction
        /// </summary>
        /// <remarks>
        /// This operation processes the transaction without requiring that the customer is present. Means this operation applies strategies to process the transaction without a direct interaction with the buyer. This operation is suitable for recurring transactions.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be processed.</param>
        /// <returns>Task of ApiResponse (Transaction)</returns>
        System.Threading.Tasks.Task<ApiResponse<Transaction>> ProcessWithoutUserInteractionAsyncWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>Task of Transaction</returns>
        System.Threading.Tasks.Task<Transaction> ReadAsync (long? spaceId, long? id);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>Task of ApiResponse (Transaction)</returns>
        System.Threading.Tasks.Task<ApiResponse<Transaction>> ReadAsyncWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// Read With Credentials
        /// </summary>
        /// <remarks>
        /// Reads the transaction with the given &#39;id&#39; and returns it. This method uses the credentials to authenticate and identify the transaction.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>Task of Transaction</returns>
        System.Threading.Tasks.Task<Transaction> ReadWithCredentialsAsync (string credentials);

        /// <summary>
        /// Read With Credentials
        /// </summary>
        /// <remarks>
        /// Reads the transaction with the given &#39;id&#39; and returns it. This method uses the credentials to authenticate and identify the transaction.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>Task of ApiResponse (Transaction)</returns>
        System.Threading.Tasks.Task<ApiResponse<Transaction>> ReadWithCredentialsAsyncWithHttpInfo (string credentials);

        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the transactions which are returned by the search.</param>
        /// <returns>Task of List&lt;Transaction&gt;</returns>
        System.Threading.Tasks.Task<List<Transaction>> SearchAsync (long? spaceId, EntityQuery query);

        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the transactions which are returned by the search.</param>
        /// <returns>Task of ApiResponse (List&lt;Transaction&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Transaction>>> SearchAsyncWithHttpInfo (long? spaceId, EntityQuery query);

        /// <summary>
        /// Update
        /// </summary>
        /// <remarks>
        /// This updates the entity with the given properties. Only those properties which should be updated can be provided. The &#39;id&#39; and &#39;version&#39; are required to identify the entity.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The transaction object with the properties which should be updated.</param>
        /// <returns>Task of Transaction</returns>
        System.Threading.Tasks.Task<Transaction> UpdateAsync (long? spaceId, TransactionPending entity);

        /// <summary>
        /// Update
        /// </summary>
        /// <remarks>
        /// This updates the entity with the given properties. Only those properties which should be updated can be provided. The &#39;id&#39; and &#39;version&#39; are required to identify the entity.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The transaction object with the properties which should be updated.</param>
        /// <returns>Task of ApiResponse (Transaction)</returns>
        System.Threading.Tasks.Task<ApiResponse<Transaction>> UpdateAsyncWithHttpInfo (long? spaceId, TransactionPending entity);

        /// <summary>
        /// updateTransactionLineItems
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="updateRequest"></param>
        /// <returns>Task of TransactionLineItemVersion</returns>
        System.Threading.Tasks.Task<TransactionLineItemVersion> UpdateTransactionLineItemsAsync (long? spaceId, TransactionLineItemUpdateRequest updateRequest);

        /// <summary>
        /// updateTransactionLineItems
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="updateRequest"></param>
        /// <returns>Task of ApiResponse (TransactionLineItemVersion)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransactionLineItemVersion>> UpdateTransactionLineItemsAsyncWithHttpInfo (long? spaceId, TransactionLineItemUpdateRequest updateRequest);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TransactionService : ITransactionService
    {
        private readonly Customweb.Wallee.Client.ExceptionFactory _exceptionFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TransactionService(Configuration configuration = null)
        {
            this._configuration = CheckArgument.NotNull("configuration", configuration);
            this._apiClient = new ApiClient(configuration);
            this._exceptionFactory = Configuration.ExceptionFactory;
        }

        private readonly ApiClient _apiClient;

        public ApiClient ApiClient
        {
            get { return _apiClient; }
        }

        private readonly Configuration _configuration;

        public Configuration Configuration
        {
            get { return _configuration; }
        }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Customweb.Wallee.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
        }

        /// <summary>
        /// Build JavaScript URL This operation creates the URL which can be used to embed the JavaScript for handling the iFrame checkout flow.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>string</returns>
        public string BuildJavaScriptUrl (long? spaceId, long? id)
        {
             ApiResponse<string> localVarResponse = BuildJavaScriptUrlWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Build JavaScript URL This operation creates the URL which can be used to embed the JavaScript for handling the iFrame checkout flow.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > BuildJavaScriptUrlWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->BuildJavaScriptUrl");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionService->BuildJavaScriptUrl");
            }

            var localVarPath = "/transaction/buildJavaScriptUrl";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("BuildJavaScriptUrl", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Build JavaScript URL This operation creates the URL which can be used to embed the JavaScript for handling the iFrame checkout flow.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> BuildJavaScriptUrlAsync (long? spaceId, long? id)
        {
             ApiResponse<string> localVarResponse = await BuildJavaScriptUrlAsyncWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Build JavaScript URL This operation creates the URL which can be used to embed the JavaScript for handling the iFrame checkout flow.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> BuildJavaScriptUrlAsyncWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->BuildJavaScriptUrl");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionService->BuildJavaScriptUrl");
            }

            var localVarPath = "/transaction/buildJavaScriptUrl";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("BuildJavaScriptUrl", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Build Mobile SDK URL with Credentials This operation builds the URL which is used to load the payment form within a WebView on a mobile device. This operation is typically called through the mobile SDK.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>string</returns>
        public string BuildMobileSdkUrlWithCredentials (string credentials)
        {
             ApiResponse<string> localVarResponse = BuildMobileSdkUrlWithCredentialsWithHttpInfo(credentials);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Build Mobile SDK URL with Credentials This operation builds the URL which is used to load the payment form within a WebView on a mobile device. This operation is typically called through the mobile SDK.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > BuildMobileSdkUrlWithCredentialsWithHttpInfo (string credentials)
        {
            // verify the required parameter 'credentials' is set
            if (credentials == null)
            {
                throw new ApiException(400, "Missing required parameter 'credentials' when calling TransactionService->BuildMobileSdkUrlWithCredentials");
            }

            var localVarPath = "/transaction/buildMobileSdkUrlWithCredentials";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (credentials != null) localVarQueryParams.Add("credentials", ApiClient.ParameterToString(credentials)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("BuildMobileSdkUrlWithCredentials", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Build Mobile SDK URL with Credentials This operation builds the URL which is used to load the payment form within a WebView on a mobile device. This operation is typically called through the mobile SDK.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> BuildMobileSdkUrlWithCredentialsAsync (string credentials)
        {
             ApiResponse<string> localVarResponse = await BuildMobileSdkUrlWithCredentialsAsyncWithHttpInfo(credentials);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Build Mobile SDK URL with Credentials This operation builds the URL which is used to load the payment form within a WebView on a mobile device. This operation is typically called through the mobile SDK.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> BuildMobileSdkUrlWithCredentialsAsyncWithHttpInfo (string credentials)
        {
            // verify the required parameter 'credentials' is set
            if (credentials == null)
            {
                throw new ApiException(400, "Missing required parameter 'credentials' when calling TransactionService->BuildMobileSdkUrlWithCredentials");
            }

            var localVarPath = "/transaction/buildMobileSdkUrlWithCredentials";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (credentials != null) localVarQueryParams.Add("credentials", ApiClient.ParameterToString(credentials)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("BuildMobileSdkUrlWithCredentials", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Build Payment Page URL This operation creates the URL to which the user should be redirected to when the payment page should be used.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>string</returns>
        public string BuildPaymentPageUrl (long? spaceId, long? id)
        {
             ApiResponse<string> localVarResponse = BuildPaymentPageUrlWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Build Payment Page URL This operation creates the URL to which the user should be redirected to when the payment page should be used.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > BuildPaymentPageUrlWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->BuildPaymentPageUrl");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionService->BuildPaymentPageUrl");
            }

            var localVarPath = "/transaction/buildPaymentPageUrl";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("BuildPaymentPageUrl", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Build Payment Page URL This operation creates the URL to which the user should be redirected to when the payment page should be used.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> BuildPaymentPageUrlAsync (long? spaceId, long? id)
        {
             ApiResponse<string> localVarResponse = await BuildPaymentPageUrlAsyncWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Build Payment Page URL This operation creates the URL to which the user should be redirected to when the payment page should be used.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> BuildPaymentPageUrlAsyncWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->BuildPaymentPageUrl");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionService->BuildPaymentPageUrl");
            }

            var localVarPath = "/transaction/buildPaymentPageUrl";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("BuildPaymentPageUrl", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Confirm The confirm operation marks the transaction as confirmed. Once the transaction is confirmed no more changes can be applied.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionModel">The transaction JSON object to update and confirm.</param>
        /// <returns>Transaction</returns>
        public Transaction Confirm (long? spaceId, TransactionPending transactionModel)
        {
             ApiResponse<Transaction> localVarResponse = ConfirmWithHttpInfo(spaceId, transactionModel);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Confirm The confirm operation marks the transaction as confirmed. Once the transaction is confirmed no more changes can be applied.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionModel">The transaction JSON object to update and confirm.</param>
        /// <returns>ApiResponse of Transaction</returns>
        public ApiResponse< Transaction > ConfirmWithHttpInfo (long? spaceId, TransactionPending transactionModel)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->Confirm");
            }
            // verify the required parameter 'transactionModel' is set
            if (transactionModel == null)
            {
                throw new ApiException(400, "Missing required parameter 'transactionModel' when calling TransactionService->Confirm");
            }

            var localVarPath = "/transaction/confirm";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (transactionModel != null && transactionModel.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(transactionModel); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transactionModel; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Confirm", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Transaction>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Transaction) ApiClient.Deserialize(localVarResponse, typeof(Transaction)));
        }

        /// <summary>
        /// Confirm The confirm operation marks the transaction as confirmed. Once the transaction is confirmed no more changes can be applied.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionModel">The transaction JSON object to update and confirm.</param>
        /// <returns>Task of Transaction</returns>
        public async System.Threading.Tasks.Task<Transaction> ConfirmAsync (long? spaceId, TransactionPending transactionModel)
        {
             ApiResponse<Transaction> localVarResponse = await ConfirmAsyncWithHttpInfo(spaceId, transactionModel);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Confirm The confirm operation marks the transaction as confirmed. Once the transaction is confirmed no more changes can be applied.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionModel">The transaction JSON object to update and confirm.</param>
        /// <returns>Task of ApiResponse (Transaction)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Transaction>> ConfirmAsyncWithHttpInfo (long? spaceId, TransactionPending transactionModel)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->Confirm");
            }
            // verify the required parameter 'transactionModel' is set
            if (transactionModel == null)
            {
                throw new ApiException(400, "Missing required parameter 'transactionModel' when calling TransactionService->Confirm");
            }

            var localVarPath = "/transaction/confirm";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (transactionModel != null && transactionModel.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(transactionModel); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transactionModel; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Confirm", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Transaction>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Transaction) ApiClient.Deserialize(localVarResponse, typeof(Transaction)));
        }

        /// <summary>
        /// Count Counts the number of items in the database as restricted by the given filter.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>long?</returns>
        public long? Count (long? spaceId, EntityQueryFilter filter = null)
        {
             ApiResponse<long?> localVarResponse = CountWithHttpInfo(spaceId, filter);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Count Counts the number of items in the database as restricted by the given filter.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>ApiResponse of long?</returns>
        public ApiResponse< long? > CountWithHttpInfo (long? spaceId, EntityQueryFilter filter = null)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->Count");
            }

            var localVarPath = "/transaction/count";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (filter != null && filter.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(filter); // http body (model) parameter
            }
            else
            {
                localVarPostBody = filter; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Count", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<long?>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (long?) ApiClient.Deserialize(localVarResponse, typeof(long?)));
        }

        /// <summary>
        /// Count Counts the number of items in the database as restricted by the given filter.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>Task of long?</returns>
        public async System.Threading.Tasks.Task<long?> CountAsync (long? spaceId, EntityQueryFilter filter = null)
        {
             ApiResponse<long?> localVarResponse = await CountAsyncWithHttpInfo(spaceId, filter);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Count Counts the number of items in the database as restricted by the given filter.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>Task of ApiResponse (long?)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<long?>> CountAsyncWithHttpInfo (long? spaceId, EntityQueryFilter filter = null)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->Count");
            }

            var localVarPath = "/transaction/count";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (filter != null && filter.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(filter); // http body (model) parameter
            }
            else
            {
                localVarPostBody = filter; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Count", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<long?>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (long?) ApiClient.Deserialize(localVarResponse, typeof(long?)));
        }

        /// <summary>
        /// Create Creates the entity with the given properties.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transaction">The transaction object which should be created.</param>
        /// <returns>Transaction</returns>
        public Transaction Create (long? spaceId, TransactionCreate transaction)
        {
             ApiResponse<Transaction> localVarResponse = CreateWithHttpInfo(spaceId, transaction);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Creates the entity with the given properties.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transaction">The transaction object which should be created.</param>
        /// <returns>ApiResponse of Transaction</returns>
        public ApiResponse< Transaction > CreateWithHttpInfo (long? spaceId, TransactionCreate transaction)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->Create");
            }
            // verify the required parameter 'transaction' is set
            if (transaction == null)
            {
                throw new ApiException(400, "Missing required parameter 'transaction' when calling TransactionService->Create");
            }

            var localVarPath = "/transaction/create";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (transaction != null && transaction.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(transaction); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transaction; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Create", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Transaction>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Transaction) ApiClient.Deserialize(localVarResponse, typeof(Transaction)));
        }

        /// <summary>
        /// Create Creates the entity with the given properties.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transaction">The transaction object which should be created.</param>
        /// <returns>Task of Transaction</returns>
        public async System.Threading.Tasks.Task<Transaction> CreateAsync (long? spaceId, TransactionCreate transaction)
        {
             ApiResponse<Transaction> localVarResponse = await CreateAsyncWithHttpInfo(spaceId, transaction);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Creates the entity with the given properties.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transaction">The transaction object which should be created.</param>
        /// <returns>Task of ApiResponse (Transaction)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Transaction>> CreateAsyncWithHttpInfo (long? spaceId, TransactionCreate transaction)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->Create");
            }
            // verify the required parameter 'transaction' is set
            if (transaction == null)
            {
                throw new ApiException(400, "Missing required parameter 'transaction' when calling TransactionService->Create");
            }

            var localVarPath = "/transaction/create";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (transaction != null && transaction.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(transaction); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transaction; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Create", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Transaction>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Transaction) ApiClient.Deserialize(localVarResponse, typeof(Transaction)));
        }

        /// <summary>
        /// Create Transaction Credentials This operation allows to create transaction credentials to delegate temporarily the access to the web service API for this particular transaction.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>string</returns>
        public string CreateTransactionCredentials (long? spaceId, long? id)
        {
             ApiResponse<string> localVarResponse = CreateTransactionCredentialsWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Transaction Credentials This operation allows to create transaction credentials to delegate temporarily the access to the web service API for this particular transaction.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > CreateTransactionCredentialsWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->CreateTransactionCredentials");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionService->CreateTransactionCredentials");
            }

            var localVarPath = "/transaction/createTransactionCredentials";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateTransactionCredentials", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Create Transaction Credentials This operation allows to create transaction credentials to delegate temporarily the access to the web service API for this particular transaction.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> CreateTransactionCredentialsAsync (long? spaceId, long? id)
        {
             ApiResponse<string> localVarResponse = await CreateTransactionCredentialsAsyncWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Transaction Credentials This operation allows to create transaction credentials to delegate temporarily the access to the web service API for this particular transaction.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> CreateTransactionCredentialsAsyncWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->CreateTransactionCredentials");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionService->CreateTransactionCredentials");
            }

            var localVarPath = "/transaction/createTransactionCredentials";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateTransactionCredentials", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Delete One-Click Token with Credentials This operation removes the given token.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <param name="tokenId">The token ID will be used to find the token which should be removed.</param>
        /// <returns></returns>
        public void DeleteOneClickTokenWithCredentials (string credentials, long? tokenId)
        {
             DeleteOneClickTokenWithCredentialsWithHttpInfo(credentials, tokenId);
        }

        /// <summary>
        /// Delete One-Click Token with Credentials This operation removes the given token.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <param name="tokenId">The token ID will be used to find the token which should be removed.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteOneClickTokenWithCredentialsWithHttpInfo (string credentials, long? tokenId)
        {
            // verify the required parameter 'credentials' is set
            if (credentials == null)
            {
                throw new ApiException(400, "Missing required parameter 'credentials' when calling TransactionService->DeleteOneClickTokenWithCredentials");
            }
            // verify the required parameter 'tokenId' is set
            if (tokenId == null)
            {
                throw new ApiException(400, "Missing required parameter 'tokenId' when calling TransactionService->DeleteOneClickTokenWithCredentials");
            }

            var localVarPath = "/transaction/deleteOneClickTokenWithCredentials";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (credentials != null) localVarQueryParams.Add("credentials", ApiClient.ParameterToString(credentials)); // query parameter
            if (tokenId != null) localVarQueryParams.Add("tokenId", ApiClient.ParameterToString(tokenId)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteOneClickTokenWithCredentials", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete One-Click Token with Credentials This operation removes the given token.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <param name="tokenId">The token ID will be used to find the token which should be removed.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteOneClickTokenWithCredentialsAsync (string credentials, long? tokenId)
        {
             await DeleteOneClickTokenWithCredentialsAsyncWithHttpInfo(credentials, tokenId);
        }

        /// <summary>
        /// Delete One-Click Token with Credentials This operation removes the given token.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <param name="tokenId">The token ID will be used to find the token which should be removed.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOneClickTokenWithCredentialsAsyncWithHttpInfo (string credentials, long? tokenId)
        {
            // verify the required parameter 'credentials' is set
            if (credentials == null)
            {
                throw new ApiException(400, "Missing required parameter 'credentials' when calling TransactionService->DeleteOneClickTokenWithCredentials");
            }
            // verify the required parameter 'tokenId' is set
            if (tokenId == null)
            {
                throw new ApiException(400, "Missing required parameter 'tokenId' when calling TransactionService->DeleteOneClickTokenWithCredentials");
            }

            var localVarPath = "/transaction/deleteOneClickTokenWithCredentials";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (credentials != null) localVarQueryParams.Add("credentials", ApiClient.ParameterToString(credentials)); // query parameter
            if (tokenId != null) localVarQueryParams.Add("tokenId", ApiClient.ParameterToString(tokenId)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteOneClickTokenWithCredentials", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Export Exports the transactions into a CSV file. The file will contain the properties defined in the request.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="request">The request controls the entries which are exported.</param>
        /// <returns>byte[]</returns>
        public byte[] Export (long? spaceId, EntityExportRequest request)
        {
             ApiResponse<byte[]> localVarResponse = ExportWithHttpInfo(spaceId, request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Export Exports the transactions into a CSV file. The file will contain the properties defined in the request.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="request">The request controls the entries which are exported.</param>
        /// <returns>ApiResponse of byte[]</returns>
        public ApiResponse< byte[] > ExportWithHttpInfo (long? spaceId, EntityExportRequest request)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->Export");
            }
            // verify the required parameter 'request' is set
            if (request == null)
            {
                throw new ApiException(400, "Missing required parameter 'request' when calling TransactionService->Export");
            }

            var localVarPath = "/transaction/export";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8", 
                "text/csv"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Export", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<byte[]>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (byte[]) ApiClient.Deserialize(localVarResponse, typeof(byte[])));
        }

        /// <summary>
        /// Export Exports the transactions into a CSV file. The file will contain the properties defined in the request.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="request">The request controls the entries which are exported.</param>
        /// <returns>Task of byte[]</returns>
        public async System.Threading.Tasks.Task<byte[]> ExportAsync (long? spaceId, EntityExportRequest request)
        {
             ApiResponse<byte[]> localVarResponse = await ExportAsyncWithHttpInfo(spaceId, request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Export Exports the transactions into a CSV file. The file will contain the properties defined in the request.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="request">The request controls the entries which are exported.</param>
        /// <returns>Task of ApiResponse (byte[])</returns>
        public async System.Threading.Tasks.Task<ApiResponse<byte[]>> ExportAsyncWithHttpInfo (long? spaceId, EntityExportRequest request)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->Export");
            }
            // verify the required parameter 'request' is set
            if (request == null)
            {
                throw new ApiException(400, "Missing required parameter 'request' when calling TransactionService->Export");
            }

            var localVarPath = "/transaction/export";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8", 
                "text/csv"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Export", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<byte[]>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (byte[]) ApiClient.Deserialize(localVarResponse, typeof(byte[])));
        }

        /// <summary>
        /// Fetch One Click Tokens with Credentials This operation returns the token version objects which references the tokens usable as one-click payment tokens for the provided transaction.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>List&lt;TokenVersion&gt;</returns>
        public List<TokenVersion> FetchOneClickTokensWithCredentials (string credentials)
        {
             ApiResponse<List<TokenVersion>> localVarResponse = FetchOneClickTokensWithCredentialsWithHttpInfo(credentials);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch One Click Tokens with Credentials This operation returns the token version objects which references the tokens usable as one-click payment tokens for the provided transaction.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>ApiResponse of List&lt;TokenVersion&gt;</returns>
        public ApiResponse< List<TokenVersion> > FetchOneClickTokensWithCredentialsWithHttpInfo (string credentials)
        {
            // verify the required parameter 'credentials' is set
            if (credentials == null)
            {
                throw new ApiException(400, "Missing required parameter 'credentials' when calling TransactionService->FetchOneClickTokensWithCredentials");
            }

            var localVarPath = "/transaction/fetchOneClickTokensWithCredentials";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (credentials != null) localVarQueryParams.Add("credentials", ApiClient.ParameterToString(credentials)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FetchOneClickTokensWithCredentials", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<TokenVersion>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<TokenVersion>) ApiClient.Deserialize(localVarResponse, typeof(List<TokenVersion>)));
        }

        /// <summary>
        /// Fetch One Click Tokens with Credentials This operation returns the token version objects which references the tokens usable as one-click payment tokens for the provided transaction.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>Task of List&lt;TokenVersion&gt;</returns>
        public async System.Threading.Tasks.Task<List<TokenVersion>> FetchOneClickTokensWithCredentialsAsync (string credentials)
        {
             ApiResponse<List<TokenVersion>> localVarResponse = await FetchOneClickTokensWithCredentialsAsyncWithHttpInfo(credentials);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch One Click Tokens with Credentials This operation returns the token version objects which references the tokens usable as one-click payment tokens for the provided transaction.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>Task of ApiResponse (List&lt;TokenVersion&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<TokenVersion>>> FetchOneClickTokensWithCredentialsAsyncWithHttpInfo (string credentials)
        {
            // verify the required parameter 'credentials' is set
            if (credentials == null)
            {
                throw new ApiException(400, "Missing required parameter 'credentials' when calling TransactionService->FetchOneClickTokensWithCredentials");
            }

            var localVarPath = "/transaction/fetchOneClickTokensWithCredentials";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (credentials != null) localVarQueryParams.Add("credentials", ApiClient.ParameterToString(credentials)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FetchOneClickTokensWithCredentials", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<TokenVersion>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<TokenVersion>) ApiClient.Deserialize(localVarResponse, typeof(List<TokenVersion>)));
        }

        /// <summary>
        /// Fetch Possible Payment Methods This operation allows to get the payment method configurations which can be used with the provided transaction.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>List&lt;PaymentMethodConfiguration&gt;</returns>
        public List<PaymentMethodConfiguration> FetchPossiblePaymentMethods (long? spaceId, long? id)
        {
             ApiResponse<List<PaymentMethodConfiguration>> localVarResponse = FetchPossiblePaymentMethodsWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch Possible Payment Methods This operation allows to get the payment method configurations which can be used with the provided transaction.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>ApiResponse of List&lt;PaymentMethodConfiguration&gt;</returns>
        public ApiResponse< List<PaymentMethodConfiguration> > FetchPossiblePaymentMethodsWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->FetchPossiblePaymentMethods");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionService->FetchPossiblePaymentMethods");
            }

            var localVarPath = "/transaction/fetchPossiblePaymentMethods";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FetchPossiblePaymentMethods", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<PaymentMethodConfiguration>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<PaymentMethodConfiguration>) ApiClient.Deserialize(localVarResponse, typeof(List<PaymentMethodConfiguration>)));
        }

        /// <summary>
        /// Fetch Possible Payment Methods This operation allows to get the payment method configurations which can be used with the provided transaction.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>Task of List&lt;PaymentMethodConfiguration&gt;</returns>
        public async System.Threading.Tasks.Task<List<PaymentMethodConfiguration>> FetchPossiblePaymentMethodsAsync (long? spaceId, long? id)
        {
             ApiResponse<List<PaymentMethodConfiguration>> localVarResponse = await FetchPossiblePaymentMethodsAsyncWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch Possible Payment Methods This operation allows to get the payment method configurations which can be used with the provided transaction.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>Task of ApiResponse (List&lt;PaymentMethodConfiguration&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<PaymentMethodConfiguration>>> FetchPossiblePaymentMethodsAsyncWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->FetchPossiblePaymentMethods");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionService->FetchPossiblePaymentMethods");
            }

            var localVarPath = "/transaction/fetchPossiblePaymentMethods";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FetchPossiblePaymentMethods", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<PaymentMethodConfiguration>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<PaymentMethodConfiguration>) ApiClient.Deserialize(localVarResponse, typeof(List<PaymentMethodConfiguration>)));
        }

        /// <summary>
        /// Fetch Possible Payment Methods with Credentials This operation allows to get the payment method configurations which can be used with the provided transaction.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>List&lt;PaymentMethodConfiguration&gt;</returns>
        public List<PaymentMethodConfiguration> FetchPossiblePaymentMethodsWithCredentials (string credentials)
        {
             ApiResponse<List<PaymentMethodConfiguration>> localVarResponse = FetchPossiblePaymentMethodsWithCredentialsWithHttpInfo(credentials);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch Possible Payment Methods with Credentials This operation allows to get the payment method configurations which can be used with the provided transaction.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>ApiResponse of List&lt;PaymentMethodConfiguration&gt;</returns>
        public ApiResponse< List<PaymentMethodConfiguration> > FetchPossiblePaymentMethodsWithCredentialsWithHttpInfo (string credentials)
        {
            // verify the required parameter 'credentials' is set
            if (credentials == null)
            {
                throw new ApiException(400, "Missing required parameter 'credentials' when calling TransactionService->FetchPossiblePaymentMethodsWithCredentials");
            }

            var localVarPath = "/transaction/fetchPossiblePaymentMethodsWithCredentials";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (credentials != null) localVarQueryParams.Add("credentials", ApiClient.ParameterToString(credentials)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FetchPossiblePaymentMethodsWithCredentials", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<PaymentMethodConfiguration>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<PaymentMethodConfiguration>) ApiClient.Deserialize(localVarResponse, typeof(List<PaymentMethodConfiguration>)));
        }

        /// <summary>
        /// Fetch Possible Payment Methods with Credentials This operation allows to get the payment method configurations which can be used with the provided transaction.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>Task of List&lt;PaymentMethodConfiguration&gt;</returns>
        public async System.Threading.Tasks.Task<List<PaymentMethodConfiguration>> FetchPossiblePaymentMethodsWithCredentialsAsync (string credentials)
        {
             ApiResponse<List<PaymentMethodConfiguration>> localVarResponse = await FetchPossiblePaymentMethodsWithCredentialsAsyncWithHttpInfo(credentials);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch Possible Payment Methods with Credentials This operation allows to get the payment method configurations which can be used with the provided transaction.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>Task of ApiResponse (List&lt;PaymentMethodConfiguration&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<PaymentMethodConfiguration>>> FetchPossiblePaymentMethodsWithCredentialsAsyncWithHttpInfo (string credentials)
        {
            // verify the required parameter 'credentials' is set
            if (credentials == null)
            {
                throw new ApiException(400, "Missing required parameter 'credentials' when calling TransactionService->FetchPossiblePaymentMethodsWithCredentials");
            }

            var localVarPath = "/transaction/fetchPossiblePaymentMethodsWithCredentials";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (credentials != null) localVarQueryParams.Add("credentials", ApiClient.ParameterToString(credentials)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FetchPossiblePaymentMethodsWithCredentials", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<PaymentMethodConfiguration>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<PaymentMethodConfiguration>) ApiClient.Deserialize(localVarResponse, typeof(List<PaymentMethodConfiguration>)));
        }

        /// <summary>
        /// getInvoiceDocument Returns the PDF document for the transaction invoice with given id.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction to get the invoice document for.</param>
        /// <returns>RenderedDocument</returns>
        public RenderedDocument GetInvoiceDocument (long? spaceId, long? id)
        {
             ApiResponse<RenderedDocument> localVarResponse = GetInvoiceDocumentWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// getInvoiceDocument Returns the PDF document for the transaction invoice with given id.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction to get the invoice document for.</param>
        /// <returns>ApiResponse of RenderedDocument</returns>
        public ApiResponse< RenderedDocument > GetInvoiceDocumentWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->GetInvoiceDocument");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionService->GetInvoiceDocument");
            }

            var localVarPath = "/transaction/getInvoiceDocument";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetInvoiceDocument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RenderedDocument>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RenderedDocument) ApiClient.Deserialize(localVarResponse, typeof(RenderedDocument)));
        }

        /// <summary>
        /// getInvoiceDocument Returns the PDF document for the transaction invoice with given id.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction to get the invoice document for.</param>
        /// <returns>Task of RenderedDocument</returns>
        public async System.Threading.Tasks.Task<RenderedDocument> GetInvoiceDocumentAsync (long? spaceId, long? id)
        {
             ApiResponse<RenderedDocument> localVarResponse = await GetInvoiceDocumentAsyncWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// getInvoiceDocument Returns the PDF document for the transaction invoice with given id.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction to get the invoice document for.</param>
        /// <returns>Task of ApiResponse (RenderedDocument)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RenderedDocument>> GetInvoiceDocumentAsyncWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->GetInvoiceDocument");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionService->GetInvoiceDocument");
            }

            var localVarPath = "/transaction/getInvoiceDocument";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetInvoiceDocument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RenderedDocument>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RenderedDocument) ApiClient.Deserialize(localVarResponse, typeof(RenderedDocument)));
        }

        /// <summary>
        /// getLatestTransactionLineItemVersion 
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction to get the latest line item version for.</param>
        /// <returns>TransactionLineItemVersion</returns>
        public TransactionLineItemVersion GetLatestTransactionLineItemVersion (long? spaceId, long? id)
        {
             ApiResponse<TransactionLineItemVersion> localVarResponse = GetLatestTransactionLineItemVersionWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// getLatestTransactionLineItemVersion 
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction to get the latest line item version for.</param>
        /// <returns>ApiResponse of TransactionLineItemVersion</returns>
        public ApiResponse< TransactionLineItemVersion > GetLatestTransactionLineItemVersionWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->GetLatestTransactionLineItemVersion");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionService->GetLatestTransactionLineItemVersion");
            }

            var localVarPath = "/transaction/getLatestTransactionLineItemVersion";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetLatestTransactionLineItemVersion", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransactionLineItemVersion>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransactionLineItemVersion) ApiClient.Deserialize(localVarResponse, typeof(TransactionLineItemVersion)));
        }

        /// <summary>
        /// getLatestTransactionLineItemVersion 
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction to get the latest line item version for.</param>
        /// <returns>Task of TransactionLineItemVersion</returns>
        public async System.Threading.Tasks.Task<TransactionLineItemVersion> GetLatestTransactionLineItemVersionAsync (long? spaceId, long? id)
        {
             ApiResponse<TransactionLineItemVersion> localVarResponse = await GetLatestTransactionLineItemVersionAsyncWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// getLatestTransactionLineItemVersion 
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction to get the latest line item version for.</param>
        /// <returns>Task of ApiResponse (TransactionLineItemVersion)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransactionLineItemVersion>> GetLatestTransactionLineItemVersionAsyncWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->GetLatestTransactionLineItemVersion");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionService->GetLatestTransactionLineItemVersion");
            }

            var localVarPath = "/transaction/getLatestTransactionLineItemVersion";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetLatestTransactionLineItemVersion", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransactionLineItemVersion>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransactionLineItemVersion) ApiClient.Deserialize(localVarResponse, typeof(TransactionLineItemVersion)));
        }

        /// <summary>
        /// getPackingSlip Returns the packing slip for the transaction with given id.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction to get the packing slip for.</param>
        /// <returns>RenderedDocument</returns>
        public RenderedDocument GetPackingSlip (long? spaceId, long? id)
        {
             ApiResponse<RenderedDocument> localVarResponse = GetPackingSlipWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// getPackingSlip Returns the packing slip for the transaction with given id.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction to get the packing slip for.</param>
        /// <returns>ApiResponse of RenderedDocument</returns>
        public ApiResponse< RenderedDocument > GetPackingSlipWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->GetPackingSlip");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionService->GetPackingSlip");
            }

            var localVarPath = "/transaction/getPackingSlip";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPackingSlip", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RenderedDocument>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RenderedDocument) ApiClient.Deserialize(localVarResponse, typeof(RenderedDocument)));
        }

        /// <summary>
        /// getPackingSlip Returns the packing slip for the transaction with given id.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction to get the packing slip for.</param>
        /// <returns>Task of RenderedDocument</returns>
        public async System.Threading.Tasks.Task<RenderedDocument> GetPackingSlipAsync (long? spaceId, long? id)
        {
             ApiResponse<RenderedDocument> localVarResponse = await GetPackingSlipAsyncWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// getPackingSlip Returns the packing slip for the transaction with given id.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction to get the packing slip for.</param>
        /// <returns>Task of ApiResponse (RenderedDocument)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RenderedDocument>> GetPackingSlipAsyncWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->GetPackingSlip");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionService->GetPackingSlip");
            }

            var localVarPath = "/transaction/getPackingSlip";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPackingSlip", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RenderedDocument>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RenderedDocument) ApiClient.Deserialize(localVarResponse, typeof(RenderedDocument)));
        }

        /// <summary>
        /// Process One-Click Token with Credentials This operation assigns the given token to the transaction and process it.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <param name="tokenId">The token ID is used to load the corresponding token and to process the transaction with it.</param>
        /// <returns>Transaction</returns>
        public Transaction ProcessOneClickTokenWithCredentials (string credentials, long? tokenId)
        {
             ApiResponse<Transaction> localVarResponse = ProcessOneClickTokenWithCredentialsWithHttpInfo(credentials, tokenId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Process One-Click Token with Credentials This operation assigns the given token to the transaction and process it.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <param name="tokenId">The token ID is used to load the corresponding token and to process the transaction with it.</param>
        /// <returns>ApiResponse of Transaction</returns>
        public ApiResponse< Transaction > ProcessOneClickTokenWithCredentialsWithHttpInfo (string credentials, long? tokenId)
        {
            // verify the required parameter 'credentials' is set
            if (credentials == null)
            {
                throw new ApiException(400, "Missing required parameter 'credentials' when calling TransactionService->ProcessOneClickTokenWithCredentials");
            }
            // verify the required parameter 'tokenId' is set
            if (tokenId == null)
            {
                throw new ApiException(400, "Missing required parameter 'tokenId' when calling TransactionService->ProcessOneClickTokenWithCredentials");
            }

            var localVarPath = "/transaction/processOneClickTokenWithCredentials";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (credentials != null) localVarQueryParams.Add("credentials", ApiClient.ParameterToString(credentials)); // query parameter
            if (tokenId != null) localVarQueryParams.Add("tokenId", ApiClient.ParameterToString(tokenId)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ProcessOneClickTokenWithCredentials", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Transaction>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Transaction) ApiClient.Deserialize(localVarResponse, typeof(Transaction)));
        }

        /// <summary>
        /// Process One-Click Token with Credentials This operation assigns the given token to the transaction and process it.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <param name="tokenId">The token ID is used to load the corresponding token and to process the transaction with it.</param>
        /// <returns>Task of Transaction</returns>
        public async System.Threading.Tasks.Task<Transaction> ProcessOneClickTokenWithCredentialsAsync (string credentials, long? tokenId)
        {
             ApiResponse<Transaction> localVarResponse = await ProcessOneClickTokenWithCredentialsAsyncWithHttpInfo(credentials, tokenId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Process One-Click Token with Credentials This operation assigns the given token to the transaction and process it.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <param name="tokenId">The token ID is used to load the corresponding token and to process the transaction with it.</param>
        /// <returns>Task of ApiResponse (Transaction)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Transaction>> ProcessOneClickTokenWithCredentialsAsyncWithHttpInfo (string credentials, long? tokenId)
        {
            // verify the required parameter 'credentials' is set
            if (credentials == null)
            {
                throw new ApiException(400, "Missing required parameter 'credentials' when calling TransactionService->ProcessOneClickTokenWithCredentials");
            }
            // verify the required parameter 'tokenId' is set
            if (tokenId == null)
            {
                throw new ApiException(400, "Missing required parameter 'tokenId' when calling TransactionService->ProcessOneClickTokenWithCredentials");
            }

            var localVarPath = "/transaction/processOneClickTokenWithCredentials";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (credentials != null) localVarQueryParams.Add("credentials", ApiClient.ParameterToString(credentials)); // query parameter
            if (tokenId != null) localVarQueryParams.Add("tokenId", ApiClient.ParameterToString(tokenId)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ProcessOneClickTokenWithCredentials", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Transaction>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Transaction) ApiClient.Deserialize(localVarResponse, typeof(Transaction)));
        }

        /// <summary>
        /// Process Without User Interaction This operation processes the transaction without requiring that the customer is present. Means this operation applies strategies to process the transaction without a direct interaction with the buyer. This operation is suitable for recurring transactions.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be processed.</param>
        /// <returns>Transaction</returns>
        public Transaction ProcessWithoutUserInteraction (long? spaceId, long? id)
        {
             ApiResponse<Transaction> localVarResponse = ProcessWithoutUserInteractionWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Process Without User Interaction This operation processes the transaction without requiring that the customer is present. Means this operation applies strategies to process the transaction without a direct interaction with the buyer. This operation is suitable for recurring transactions.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be processed.</param>
        /// <returns>ApiResponse of Transaction</returns>
        public ApiResponse< Transaction > ProcessWithoutUserInteractionWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->ProcessWithoutUserInteraction");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionService->ProcessWithoutUserInteraction");
            }

            var localVarPath = "/transaction/processWithoutUserInteraction";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ProcessWithoutUserInteraction", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Transaction>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Transaction) ApiClient.Deserialize(localVarResponse, typeof(Transaction)));
        }

        /// <summary>
        /// Process Without User Interaction This operation processes the transaction without requiring that the customer is present. Means this operation applies strategies to process the transaction without a direct interaction with the buyer. This operation is suitable for recurring transactions.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be processed.</param>
        /// <returns>Task of Transaction</returns>
        public async System.Threading.Tasks.Task<Transaction> ProcessWithoutUserInteractionAsync (long? spaceId, long? id)
        {
             ApiResponse<Transaction> localVarResponse = await ProcessWithoutUserInteractionAsyncWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Process Without User Interaction This operation processes the transaction without requiring that the customer is present. Means this operation applies strategies to process the transaction without a direct interaction with the buyer. This operation is suitable for recurring transactions.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be processed.</param>
        /// <returns>Task of ApiResponse (Transaction)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Transaction>> ProcessWithoutUserInteractionAsyncWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->ProcessWithoutUserInteraction");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionService->ProcessWithoutUserInteraction");
            }

            var localVarPath = "/transaction/processWithoutUserInteraction";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ProcessWithoutUserInteraction", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Transaction>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Transaction) ApiClient.Deserialize(localVarResponse, typeof(Transaction)));
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>Transaction</returns>
        public Transaction Read (long? spaceId, long? id)
        {
             ApiResponse<Transaction> localVarResponse = ReadWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>ApiResponse of Transaction</returns>
        public ApiResponse< Transaction > ReadWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->Read");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionService->Read");
            }

            var localVarPath = "/transaction/read";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Read", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Transaction>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Transaction) ApiClient.Deserialize(localVarResponse, typeof(Transaction)));
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>Task of Transaction</returns>
        public async System.Threading.Tasks.Task<Transaction> ReadAsync (long? spaceId, long? id)
        {
             ApiResponse<Transaction> localVarResponse = await ReadAsyncWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>Task of ApiResponse (Transaction)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Transaction>> ReadAsyncWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->Read");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionService->Read");
            }

            var localVarPath = "/transaction/read";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Read", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Transaction>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Transaction) ApiClient.Deserialize(localVarResponse, typeof(Transaction)));
        }

        /// <summary>
        /// Read With Credentials Reads the transaction with the given &#39;id&#39; and returns it. This method uses the credentials to authenticate and identify the transaction.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>Transaction</returns>
        public Transaction ReadWithCredentials (string credentials)
        {
             ApiResponse<Transaction> localVarResponse = ReadWithCredentialsWithHttpInfo(credentials);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read With Credentials Reads the transaction with the given &#39;id&#39; and returns it. This method uses the credentials to authenticate and identify the transaction.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>ApiResponse of Transaction</returns>
        public ApiResponse< Transaction > ReadWithCredentialsWithHttpInfo (string credentials)
        {
            // verify the required parameter 'credentials' is set
            if (credentials == null)
            {
                throw new ApiException(400, "Missing required parameter 'credentials' when calling TransactionService->ReadWithCredentials");
            }

            var localVarPath = "/transaction/readWithCredentials";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (credentials != null) localVarQueryParams.Add("credentials", ApiClient.ParameterToString(credentials)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ReadWithCredentials", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Transaction>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Transaction) ApiClient.Deserialize(localVarResponse, typeof(Transaction)));
        }

        /// <summary>
        /// Read With Credentials Reads the transaction with the given &#39;id&#39; and returns it. This method uses the credentials to authenticate and identify the transaction.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>Task of Transaction</returns>
        public async System.Threading.Tasks.Task<Transaction> ReadWithCredentialsAsync (string credentials)
        {
             ApiResponse<Transaction> localVarResponse = await ReadWithCredentialsAsyncWithHttpInfo(credentials);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read With Credentials Reads the transaction with the given &#39;id&#39; and returns it. This method uses the credentials to authenticate and identify the transaction.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>Task of ApiResponse (Transaction)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Transaction>> ReadWithCredentialsAsyncWithHttpInfo (string credentials)
        {
            // verify the required parameter 'credentials' is set
            if (credentials == null)
            {
                throw new ApiException(400, "Missing required parameter 'credentials' when calling TransactionService->ReadWithCredentials");
            }

            var localVarPath = "/transaction/readWithCredentials";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (credentials != null) localVarQueryParams.Add("credentials", ApiClient.ParameterToString(credentials)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ReadWithCredentials", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Transaction>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Transaction) ApiClient.Deserialize(localVarResponse, typeof(Transaction)));
        }

        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the transactions which are returned by the search.</param>
        /// <returns>List&lt;Transaction&gt;</returns>
        public List<Transaction> Search (long? spaceId, EntityQuery query)
        {
             ApiResponse<List<Transaction>> localVarResponse = SearchWithHttpInfo(spaceId, query);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the transactions which are returned by the search.</param>
        /// <returns>ApiResponse of List&lt;Transaction&gt;</returns>
        public ApiResponse< List<Transaction> > SearchWithHttpInfo (long? spaceId, EntityQuery query)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->Search");
            }
            // verify the required parameter 'query' is set
            if (query == null)
            {
                throw new ApiException(400, "Missing required parameter 'query' when calling TransactionService->Search");
            }

            var localVarPath = "/transaction/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (query != null && query.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(query); // http body (model) parameter
            }
            else
            {
                localVarPostBody = query; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Search", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Transaction>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Transaction>) ApiClient.Deserialize(localVarResponse, typeof(List<Transaction>)));
        }

        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the transactions which are returned by the search.</param>
        /// <returns>Task of List&lt;Transaction&gt;</returns>
        public async System.Threading.Tasks.Task<List<Transaction>> SearchAsync (long? spaceId, EntityQuery query)
        {
             ApiResponse<List<Transaction>> localVarResponse = await SearchAsyncWithHttpInfo(spaceId, query);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the transactions which are returned by the search.</param>
        /// <returns>Task of ApiResponse (List&lt;Transaction&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Transaction>>> SearchAsyncWithHttpInfo (long? spaceId, EntityQuery query)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->Search");
            }
            // verify the required parameter 'query' is set
            if (query == null)
            {
                throw new ApiException(400, "Missing required parameter 'query' when calling TransactionService->Search");
            }

            var localVarPath = "/transaction/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (query != null && query.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(query); // http body (model) parameter
            }
            else
            {
                localVarPostBody = query; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Search", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Transaction>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Transaction>) ApiClient.Deserialize(localVarResponse, typeof(List<Transaction>)));
        }

        /// <summary>
        /// Update This updates the entity with the given properties. Only those properties which should be updated can be provided. The &#39;id&#39; and &#39;version&#39; are required to identify the entity.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The transaction object with the properties which should be updated.</param>
        /// <returns>Transaction</returns>
        public Transaction Update (long? spaceId, TransactionPending entity)
        {
             ApiResponse<Transaction> localVarResponse = UpdateWithHttpInfo(spaceId, entity);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update This updates the entity with the given properties. Only those properties which should be updated can be provided. The &#39;id&#39; and &#39;version&#39; are required to identify the entity.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The transaction object with the properties which should be updated.</param>
        /// <returns>ApiResponse of Transaction</returns>
        public ApiResponse< Transaction > UpdateWithHttpInfo (long? spaceId, TransactionPending entity)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->Update");
            }
            // verify the required parameter 'entity' is set
            if (entity == null)
            {
                throw new ApiException(400, "Missing required parameter 'entity' when calling TransactionService->Update");
            }

            var localVarPath = "/transaction/update";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (entity != null && entity.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(entity); // http body (model) parameter
            }
            else
            {
                localVarPostBody = entity; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Update", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Transaction>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Transaction) ApiClient.Deserialize(localVarResponse, typeof(Transaction)));
        }

        /// <summary>
        /// Update This updates the entity with the given properties. Only those properties which should be updated can be provided. The &#39;id&#39; and &#39;version&#39; are required to identify the entity.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The transaction object with the properties which should be updated.</param>
        /// <returns>Task of Transaction</returns>
        public async System.Threading.Tasks.Task<Transaction> UpdateAsync (long? spaceId, TransactionPending entity)
        {
             ApiResponse<Transaction> localVarResponse = await UpdateAsyncWithHttpInfo(spaceId, entity);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update This updates the entity with the given properties. Only those properties which should be updated can be provided. The &#39;id&#39; and &#39;version&#39; are required to identify the entity.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The transaction object with the properties which should be updated.</param>
        /// <returns>Task of ApiResponse (Transaction)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Transaction>> UpdateAsyncWithHttpInfo (long? spaceId, TransactionPending entity)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->Update");
            }
            // verify the required parameter 'entity' is set
            if (entity == null)
            {
                throw new ApiException(400, "Missing required parameter 'entity' when calling TransactionService->Update");
            }

            var localVarPath = "/transaction/update";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (entity != null && entity.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(entity); // http body (model) parameter
            }
            else
            {
                localVarPostBody = entity; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Update", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Transaction>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Transaction) ApiClient.Deserialize(localVarResponse, typeof(Transaction)));
        }

        /// <summary>
        /// updateTransactionLineItems 
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="updateRequest"></param>
        /// <returns>TransactionLineItemVersion</returns>
        public TransactionLineItemVersion UpdateTransactionLineItems (long? spaceId, TransactionLineItemUpdateRequest updateRequest)
        {
             ApiResponse<TransactionLineItemVersion> localVarResponse = UpdateTransactionLineItemsWithHttpInfo(spaceId, updateRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// updateTransactionLineItems 
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="updateRequest"></param>
        /// <returns>ApiResponse of TransactionLineItemVersion</returns>
        public ApiResponse< TransactionLineItemVersion > UpdateTransactionLineItemsWithHttpInfo (long? spaceId, TransactionLineItemUpdateRequest updateRequest)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->UpdateTransactionLineItems");
            }
            // verify the required parameter 'updateRequest' is set
            if (updateRequest == null)
            {
                throw new ApiException(400, "Missing required parameter 'updateRequest' when calling TransactionService->UpdateTransactionLineItems");
            }

            var localVarPath = "/transaction/updateTransactionLineItems";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (updateRequest != null && updateRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(updateRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = updateRequest; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateTransactionLineItems", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransactionLineItemVersion>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransactionLineItemVersion) ApiClient.Deserialize(localVarResponse, typeof(TransactionLineItemVersion)));
        }

        /// <summary>
        /// updateTransactionLineItems 
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="updateRequest"></param>
        /// <returns>Task of TransactionLineItemVersion</returns>
        public async System.Threading.Tasks.Task<TransactionLineItemVersion> UpdateTransactionLineItemsAsync (long? spaceId, TransactionLineItemUpdateRequest updateRequest)
        {
             ApiResponse<TransactionLineItemVersion> localVarResponse = await UpdateTransactionLineItemsAsyncWithHttpInfo(spaceId, updateRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// updateTransactionLineItems 
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="updateRequest"></param>
        /// <returns>Task of ApiResponse (TransactionLineItemVersion)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransactionLineItemVersion>> UpdateTransactionLineItemsAsyncWithHttpInfo (long? spaceId, TransactionLineItemUpdateRequest updateRequest)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->UpdateTransactionLineItems");
            }
            // verify the required parameter 'updateRequest' is set
            if (updateRequest == null)
            {
                throw new ApiException(400, "Missing required parameter 'updateRequest' when calling TransactionService->UpdateTransactionLineItems");
            }

            var localVarPath = "/transaction/updateTransactionLineItems";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (updateRequest != null && updateRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(updateRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = updateRequest; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateTransactionLineItems", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransactionLineItemVersion>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransactionLineItemVersion) ApiClient.Deserialize(localVarResponse, typeof(TransactionLineItemVersion)));
        }

    }
}
