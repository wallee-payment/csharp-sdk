using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Wallee.Client;
using Wallee.Model;

namespace Wallee.Service
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITransactionService : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Confirm
        /// </summary>
        /// <remarks>
        /// The confirm operation marks the transaction as confirmed. Once the transaction is confirmed no more changes can be applied.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>List&lt;TokenVersion&gt;</returns>
        List<TokenVersion> FetchOneClickTokensWithCredentials (string credentials);

        /// <summary>
        /// Fetch One Click Tokens with Credentials
        /// </summary>
        /// <remarks>
        /// This operation returns the token version objects which references the tokens usable as one-click payment tokens for the provided transaction.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>ApiResponse of List&lt;TokenVersion&gt;</returns>
        ApiResponse<List<TokenVersion>> FetchOneClickTokensWithCredentialsWithHttpInfo (string credentials);
        /// <summary>
        /// Fetch Possible Payment Methods
        /// </summary>
        /// <remarks>
        /// This operation allows to get the payment method configurations which can be used with the provided transaction.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <param name="integrationMode">The integration mode defines the type of integration that is applied on the transaction.</param>
        /// <returns>List&lt;PaymentMethodConfiguration&gt;</returns>
        List<PaymentMethodConfiguration> FetchPaymentMethods (long? spaceId, long? id, string integrationMode);

        /// <summary>
        /// Fetch Possible Payment Methods
        /// </summary>
        /// <remarks>
        /// This operation allows to get the payment method configurations which can be used with the provided transaction.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <param name="integrationMode">The integration mode defines the type of integration that is applied on the transaction.</param>
        /// <returns>ApiResponse of List&lt;PaymentMethodConfiguration&gt;</returns>
        ApiResponse<List<PaymentMethodConfiguration>> FetchPaymentMethodsWithHttpInfo (long? spaceId, long? id, string integrationMode);
        /// <summary>
        /// Fetch Possible Payment Methods with Credentials
        /// </summary>
        /// <remarks>
        /// This operation allows to get the payment method configurations which can be used with the provided transaction.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <param name="integrationMode">The integration mode defines the type of integration that is applied on the transaction.</param>
        /// <returns>List&lt;PaymentMethodConfiguration&gt;</returns>
        List<PaymentMethodConfiguration> FetchPaymentMethodsWithCredentials (string credentials, string integrationMode);

        /// <summary>
        /// Fetch Possible Payment Methods with Credentials
        /// </summary>
        /// <remarks>
        /// This operation allows to get the payment method configurations which can be used with the provided transaction.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <param name="integrationMode">The integration mode defines the type of integration that is applied on the transaction.</param>
        /// <returns>ApiResponse of List&lt;PaymentMethodConfiguration&gt;</returns>
        ApiResponse<List<PaymentMethodConfiguration>> FetchPaymentMethodsWithCredentialsWithHttpInfo (string credentials, string integrationMode);
        /// <summary>
        /// getInvoiceDocument
        /// </summary>
        /// <remarks>
        /// Returns the PDF document for the transaction invoice with given id.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction to get the invoice document for.</param>
        /// <returns>ApiResponse of RenderedDocument</returns>
        ApiResponse<RenderedDocument> GetInvoiceDocumentWithHttpInfo (long? spaceId, long? id);
        /// <summary>
        /// getLatestSuccessfulTransactionLineItemVersion
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction to get the latest line item version for.</param>
        /// <returns>TransactionLineItemVersion</returns>
        TransactionLineItemVersion GetLatestTransactionLineItemVersion (long? spaceId, long? id);

        /// <summary>
        /// getLatestSuccessfulTransactionLineItemVersion
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction to get the packing slip for.</param>
        /// <returns>ApiResponse of RenderedDocument</returns>
        ApiResponse<RenderedDocument> GetPackingSlipWithHttpInfo (long? spaceId, long? id);
        /// <summary>
        /// Process One-Click Token with Credentials
        /// </summary>
        /// <remarks>
        /// This operation assigns the given token to the transaction and process it. This method will return an URL where the customer has to be redirect to complete the transaction.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <param name="tokenId">The token ID is used to load the corresponding token and to process the transaction with it.</param>
        /// <returns>string</returns>
        string ProcessOneClickTokenAndRedirectWithCredentials (string credentials, long? tokenId);

        /// <summary>
        /// Process One-Click Token with Credentials
        /// </summary>
        /// <remarks>
        /// This operation assigns the given token to the transaction and process it. This method will return an URL where the customer has to be redirect to complete the transaction.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <param name="tokenId">The token ID is used to load the corresponding token and to process the transaction with it.</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ProcessOneClickTokenAndRedirectWithCredentialsWithHttpInfo (string credentials, long? tokenId);
        /// <summary>
        /// Process Without User Interaction
        /// </summary>
        /// <remarks>
        /// This operation processes the transaction without requiring that the customer is present. Means this operation applies strategies to process the transaction without a direct interaction with the buyer. This operation is suitable for recurring transactions.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>Transaction</returns>
        Transaction ReadWithCredentials (string credentials);

        /// <summary>
        /// Read With Credentials
        /// </summary>
        /// <remarks>
        /// Reads the transaction with the given &#39;id&#39; and returns it. This method uses the credentials to authenticate and identify the transaction.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>ApiResponse of Transaction</returns>
        ApiResponse<Transaction> ReadWithCredentialsWithHttpInfo (string credentials);
        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The transaction object with the properties which should be updated.</param>
        /// <returns>ApiResponse of Transaction</returns>
        ApiResponse<Transaction> UpdateWithHttpInfo (long? spaceId, TransactionPending entity);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TransactionService : ITransactionService
    {
        private Wallee.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TransactionService(Wallee.Client.Configuration configuration = null)
        {
            if(configuration == null){
                throw new ArgumentException("Parameter cannot be null", "configuration");
            }
            this.Configuration = configuration;

            ExceptionFactory = Wallee.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }


        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Wallee.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Wallee.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Confirm The confirm operation marks the transaction as confirmed. Once the transaction is confirmed no more changes can be applied.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionModel">The transaction JSON object to update and confirm.</param>
        /// <returns>ApiResponse of Transaction</returns>
        public ApiResponse< Transaction > ConfirmWithHttpInfo (long? spaceId, TransactionPending transactionModel)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->Confirm");
            // verify the required parameter 'transactionModel' is set
            if (transactionModel == null)
                throw new ApiException(400, "Missing required parameter 'transactionModel' when calling TransactionService->Confirm");

            var localVarPath = "/transaction/confirm";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (transactionModel != null && transactionModel.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(transactionModel); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transactionModel; // byte array
            }

			
			this.Configuration.ApiClient.ResetTimeout();
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
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
                (Transaction) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Transaction)));
        }
        /// <summary>
        /// Count Counts the number of items in the database as restricted by the given filter.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>ApiResponse of long?</returns>
        public ApiResponse< long? > CountWithHttpInfo (long? spaceId, EntityQueryFilter filter = null)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->Count");

            var localVarPath = "/transaction/count";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (filter != null && filter.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(filter); // http body (model) parameter
            }
            else
            {
                localVarPostBody = filter; // byte array
            }

			
			this.Configuration.ApiClient.ResetTimeout();
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
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
                (long?) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(long?)));
        }
        /// <summary>
        /// Create Creates the entity with the given properties.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transaction">The transaction object which should be created.</param>
        /// <returns>ApiResponse of Transaction</returns>
        public ApiResponse< Transaction > CreateWithHttpInfo (long? spaceId, TransactionCreate transaction)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->Create");
            // verify the required parameter 'transaction' is set
            if (transaction == null)
                throw new ApiException(400, "Missing required parameter 'transaction' when calling TransactionService->Create");

            var localVarPath = "/transaction/create";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (transaction != null && transaction.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(transaction); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transaction; // byte array
            }

			
			this.Configuration.ApiClient.ResetTimeout();
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
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
                (Transaction) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Transaction)));
        }
        /// <summary>
        /// Create Transaction Credentials This operation allows to create transaction credentials to delegate temporarily the access to the web service API for this particular transaction.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > CreateTransactionCredentialsWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->CreateTransactionCredentials");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionService->CreateTransactionCredentials");

            var localVarPath = "/transaction/createTransactionCredentials";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter

			
			this.Configuration.ApiClient.ResetTimeout();
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
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
                (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }
        /// <summary>
        /// Delete One-Click Token with Credentials This operation removes the given token.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <param name="tokenId">The token ID will be used to find the token which should be removed.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteOneClickTokenWithCredentialsWithHttpInfo (string credentials, long? tokenId)
        {
            // verify the required parameter 'credentials' is set
            if (credentials == null)
                throw new ApiException(400, "Missing required parameter 'credentials' when calling TransactionService->DeleteOneClickTokenWithCredentials");
            // verify the required parameter 'tokenId' is set
            if (tokenId == null)
                throw new ApiException(400, "Missing required parameter 'tokenId' when calling TransactionService->DeleteOneClickTokenWithCredentials");

            var localVarPath = "/transaction/deleteOneClickTokenWithCredentials";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (credentials != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "credentials", credentials)); // query parameter
            if (tokenId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "tokenId", tokenId)); // query parameter

			
			this.Configuration.ApiClient.ResetTimeout();
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="request">The request controls the entries which are exported.</param>
        /// <returns>ApiResponse of byte[]</returns>
        public ApiResponse< byte[] > ExportWithHttpInfo (long? spaceId, EntityExportRequest request)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->Export");
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling TransactionService->Export");

            var localVarPath = "/transaction/export";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8",
                "text/csv"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

			
			this.Configuration.ApiClient.ResetTimeout();
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
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
                (byte[]) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(byte[])));
        }
        /// <summary>
        /// Fetch One Click Tokens with Credentials This operation returns the token version objects which references the tokens usable as one-click payment tokens for the provided transaction.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>ApiResponse of List&lt;TokenVersion&gt;</returns>
        public ApiResponse< List<TokenVersion> > FetchOneClickTokensWithCredentialsWithHttpInfo (string credentials)
        {
            // verify the required parameter 'credentials' is set
            if (credentials == null)
                throw new ApiException(400, "Missing required parameter 'credentials' when calling TransactionService->FetchOneClickTokensWithCredentials");

            var localVarPath = "/transaction/fetchOneClickTokensWithCredentials";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (credentials != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "credentials", credentials)); // query parameter

			
			this.Configuration.ApiClient.ResetTimeout();
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
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
                (List<TokenVersion>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<TokenVersion>)));
        }
        /// <summary>
        /// Fetch Possible Payment Methods This operation allows to get the payment method configurations which can be used with the provided transaction.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <param name="integrationMode">The integration mode defines the type of integration that is applied on the transaction.</param>
        /// <returns>List&lt;PaymentMethodConfiguration&gt;</returns>
        public List<PaymentMethodConfiguration> FetchPaymentMethods (long? spaceId, long? id, string integrationMode)
        {
             ApiResponse<List<PaymentMethodConfiguration>> localVarResponse = FetchPaymentMethodsWithHttpInfo(spaceId, id, integrationMode);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch Possible Payment Methods This operation allows to get the payment method configurations which can be used with the provided transaction.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <param name="integrationMode">The integration mode defines the type of integration that is applied on the transaction.</param>
        /// <returns>ApiResponse of List&lt;PaymentMethodConfiguration&gt;</returns>
        public ApiResponse< List<PaymentMethodConfiguration> > FetchPaymentMethodsWithHttpInfo (long? spaceId, long? id, string integrationMode)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->FetchPaymentMethods");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionService->FetchPaymentMethods");
            // verify the required parameter 'integrationMode' is set
            if (integrationMode == null)
                throw new ApiException(400, "Missing required parameter 'integrationMode' when calling TransactionService->FetchPaymentMethods");

            var localVarPath = "/transaction/fetch-payment-methods";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter
            if (integrationMode != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "integrationMode", integrationMode)); // query parameter

			
			this.Configuration.ApiClient.ResetTimeout();
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FetchPaymentMethods", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<PaymentMethodConfiguration>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<PaymentMethodConfiguration>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<PaymentMethodConfiguration>)));
        }
        /// <summary>
        /// Fetch Possible Payment Methods with Credentials This operation allows to get the payment method configurations which can be used with the provided transaction.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <param name="integrationMode">The integration mode defines the type of integration that is applied on the transaction.</param>
        /// <returns>List&lt;PaymentMethodConfiguration&gt;</returns>
        public List<PaymentMethodConfiguration> FetchPaymentMethodsWithCredentials (string credentials, string integrationMode)
        {
             ApiResponse<List<PaymentMethodConfiguration>> localVarResponse = FetchPaymentMethodsWithCredentialsWithHttpInfo(credentials, integrationMode);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch Possible Payment Methods with Credentials This operation allows to get the payment method configurations which can be used with the provided transaction.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <param name="integrationMode">The integration mode defines the type of integration that is applied on the transaction.</param>
        /// <returns>ApiResponse of List&lt;PaymentMethodConfiguration&gt;</returns>
        public ApiResponse< List<PaymentMethodConfiguration> > FetchPaymentMethodsWithCredentialsWithHttpInfo (string credentials, string integrationMode)
        {
            // verify the required parameter 'credentials' is set
            if (credentials == null)
                throw new ApiException(400, "Missing required parameter 'credentials' when calling TransactionService->FetchPaymentMethodsWithCredentials");
            // verify the required parameter 'integrationMode' is set
            if (integrationMode == null)
                throw new ApiException(400, "Missing required parameter 'integrationMode' when calling TransactionService->FetchPaymentMethodsWithCredentials");

            var localVarPath = "/transaction/fetch-payment-methods-with-credentials";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (credentials != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "credentials", credentials)); // query parameter
            if (integrationMode != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "integrationMode", integrationMode)); // query parameter

			
			this.Configuration.ApiClient.ResetTimeout();
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FetchPaymentMethodsWithCredentials", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<PaymentMethodConfiguration>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<PaymentMethodConfiguration>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<PaymentMethodConfiguration>)));
        }
        /// <summary>
        /// getInvoiceDocument Returns the PDF document for the transaction invoice with given id.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction to get the invoice document for.</param>
        /// <returns>ApiResponse of RenderedDocument</returns>
        public ApiResponse< RenderedDocument > GetInvoiceDocumentWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->GetInvoiceDocument");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionService->GetInvoiceDocument");

            var localVarPath = "/transaction/getInvoiceDocument";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter

			
			this.Configuration.ApiClient.ResetTimeout();
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
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
                (RenderedDocument) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RenderedDocument)));
        }
        /// <summary>
        /// getLatestSuccessfulTransactionLineItemVersion 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction to get the latest line item version for.</param>
        /// <returns>TransactionLineItemVersion</returns>
        public TransactionLineItemVersion GetLatestTransactionLineItemVersion (long? spaceId, long? id)
        {
             ApiResponse<TransactionLineItemVersion> localVarResponse = GetLatestTransactionLineItemVersionWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// getLatestSuccessfulTransactionLineItemVersion 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction to get the latest line item version for.</param>
        /// <returns>ApiResponse of TransactionLineItemVersion</returns>
        public ApiResponse< TransactionLineItemVersion > GetLatestTransactionLineItemVersionWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->GetLatestTransactionLineItemVersion");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionService->GetLatestTransactionLineItemVersion");

            var localVarPath = "/transaction/getLatestTransactionLineItemVersion";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter

			
			this.Configuration.ApiClient.ResetTimeout();
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
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
                (TransactionLineItemVersion) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransactionLineItemVersion)));
        }
        /// <summary>
        /// getPackingSlip Returns the packing slip for the transaction with given id.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction to get the packing slip for.</param>
        /// <returns>ApiResponse of RenderedDocument</returns>
        public ApiResponse< RenderedDocument > GetPackingSlipWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->GetPackingSlip");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionService->GetPackingSlip");

            var localVarPath = "/transaction/getPackingSlip";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter

			
			this.Configuration.ApiClient.ResetTimeout();
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
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
                (RenderedDocument) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RenderedDocument)));
        }
        /// <summary>
        /// Process One-Click Token with Credentials This operation assigns the given token to the transaction and process it. This method will return an URL where the customer has to be redirect to complete the transaction.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <param name="tokenId">The token ID is used to load the corresponding token and to process the transaction with it.</param>
        /// <returns>string</returns>
        public string ProcessOneClickTokenAndRedirectWithCredentials (string credentials, long? tokenId)
        {
             ApiResponse<string> localVarResponse = ProcessOneClickTokenAndRedirectWithCredentialsWithHttpInfo(credentials, tokenId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Process One-Click Token with Credentials This operation assigns the given token to the transaction and process it. This method will return an URL where the customer has to be redirect to complete the transaction.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <param name="tokenId">The token ID is used to load the corresponding token and to process the transaction with it.</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ProcessOneClickTokenAndRedirectWithCredentialsWithHttpInfo (string credentials, long? tokenId)
        {
            // verify the required parameter 'credentials' is set
            if (credentials == null)
                throw new ApiException(400, "Missing required parameter 'credentials' when calling TransactionService->ProcessOneClickTokenAndRedirectWithCredentials");
            // verify the required parameter 'tokenId' is set
            if (tokenId == null)
                throw new ApiException(400, "Missing required parameter 'tokenId' when calling TransactionService->ProcessOneClickTokenAndRedirectWithCredentials");

            var localVarPath = "/transaction/processOneClickTokenAndRedirectWithCredentials";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (credentials != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "credentials", credentials)); // query parameter
            if (tokenId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "tokenId", tokenId)); // query parameter

			
			this.Configuration.ApiClient.ResetTimeout();
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ProcessOneClickTokenAndRedirectWithCredentials", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }
        /// <summary>
        /// Process Without User Interaction This operation processes the transaction without requiring that the customer is present. Means this operation applies strategies to process the transaction without a direct interaction with the buyer. This operation is suitable for recurring transactions.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be processed.</param>
        /// <returns>ApiResponse of Transaction</returns>
        public ApiResponse< Transaction > ProcessWithoutUserInteractionWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->ProcessWithoutUserInteraction");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionService->ProcessWithoutUserInteraction");

            var localVarPath = "/transaction/processWithoutUserInteraction";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter

			
			this.Configuration.ApiClient.ResetTimeout();
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
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
                (Transaction) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Transaction)));
        }
        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction which should be returned.</param>
        /// <returns>ApiResponse of Transaction</returns>
        public ApiResponse< Transaction > ReadWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->Read");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionService->Read");

            var localVarPath = "/transaction/read";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter

			
			this.Configuration.ApiClient.ResetTimeout();
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
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
                (Transaction) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Transaction)));
        }
        /// <summary>
        /// Read With Credentials Reads the transaction with the given &#39;id&#39; and returns it. This method uses the credentials to authenticate and identify the transaction.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>ApiResponse of Transaction</returns>
        public ApiResponse< Transaction > ReadWithCredentialsWithHttpInfo (string credentials)
        {
            // verify the required parameter 'credentials' is set
            if (credentials == null)
                throw new ApiException(400, "Missing required parameter 'credentials' when calling TransactionService->ReadWithCredentials");

            var localVarPath = "/transaction/readWithCredentials";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (credentials != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "credentials", credentials)); // query parameter

			
			this.Configuration.ApiClient.ResetTimeout();
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
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
                (Transaction) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Transaction)));
        }
        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the transactions which are returned by the search.</param>
        /// <returns>ApiResponse of List&lt;Transaction&gt;</returns>
        public ApiResponse< List<Transaction> > SearchWithHttpInfo (long? spaceId, EntityQuery query)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->Search");
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling TransactionService->Search");

            var localVarPath = "/transaction/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (query != null && query.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(query); // http body (model) parameter
            }
            else
            {
                localVarPostBody = query; // byte array
            }

			
			this.Configuration.ApiClient.ResetTimeout();
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
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
                (List<Transaction>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Transaction>)));
        }
        /// <summary>
        /// Update This updates the entity with the given properties. Only those properties which should be updated can be provided. The &#39;id&#39; and &#39;version&#39; are required to identify the entity.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The transaction object with the properties which should be updated.</param>
        /// <returns>ApiResponse of Transaction</returns>
        public ApiResponse< Transaction > UpdateWithHttpInfo (long? spaceId, TransactionPending entity)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionService->Update");
            // verify the required parameter 'entity' is set
            if (entity == null)
                throw new ApiException(400, "Missing required parameter 'entity' when calling TransactionService->Update");

            var localVarPath = "/transaction/update";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (entity != null && entity.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(entity); // http body (model) parameter
            }
            else
            {
                localVarPostBody = entity; // byte array
            }

			
			this.Configuration.ApiClient.ResetTimeout();
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
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
                (Transaction) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Transaction)));
        }
    }
}
