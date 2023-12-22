using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.RegularExpressions;
using RestSharp;
using Wallee.Client;
using Wallee.Model;
using Wallee.Util;

namespace Wallee.Service
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITransactionTerminalService : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Fetch Receipts
        /// </summary>
        /// <remarks>
        /// Returns all receipts for the requested terminal transaction.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="request"></param>
        /// <returns>List&lt;RenderedTerminalReceipt&gt;</returns>
        List<RenderedTerminalReceipt> FetchReceipts (long? spaceId, TerminalReceiptFetchRequest request);

        /// <summary>
        /// Fetch Receipts
        /// </summary>
        /// <remarks>
        /// Returns all receipts for the requested terminal transaction.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="request"></param>
        /// <returns>ApiResponse of List&lt;RenderedTerminalReceipt&gt;</returns>
        ApiResponse<List<RenderedTerminalReceipt>> FetchReceiptsWithHttpInfo (long? spaceId, TerminalReceiptFetchRequest request);



        /// <summary>
        /// Create Till Connection Credentials
        /// </summary>
        /// <remarks>
        /// This operation creates a set of credentials to use within the WebSocket.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The ID of the transaction which is used to process with the terminal.</param>
        /// <param name="terminalId">The ID of the terminal which should be used to process the transaction.</param>
        /// <param name="language">The language in which the messages should be rendered in. (optional)</param>
        /// <returns>string</returns>
        string TillConnectionCredentials (long? spaceId, long? transactionId, long? terminalId, string language = null);

        /// <summary>
        /// Create Till Connection Credentials
        /// </summary>
        /// <remarks>
        /// This operation creates a set of credentials to use within the WebSocket.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The ID of the transaction which is used to process with the terminal.</param>
        /// <param name="terminalId">The ID of the terminal which should be used to process the transaction.</param>
        /// <param name="language">The language in which the messages should be rendered in. (optional)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> TillConnectionCredentialsWithHttpInfo (long? spaceId, long? transactionId, long? terminalId, string language = null);



        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TransactionTerminalService : ITransactionTerminalService
    {
        private Wallee.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionTerminalService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TransactionTerminalService(Wallee.Client.Configuration configuration = null)
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
            return this.Configuration.ApiClient.RestClient.Options.BaseUrl.ToString();
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
        /// Fetch Receipts Returns all receipts for the requested terminal transaction.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="request"></param>
        /// <returns>List&lt;RenderedTerminalReceipt&gt;</returns>
        public List<RenderedTerminalReceipt> FetchReceipts (long? spaceId, TerminalReceiptFetchRequest request)
        {
             ApiResponse<List<RenderedTerminalReceipt>> localVarResponse = FetchReceiptsWithHttpInfo(spaceId, request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch Receipts Returns all receipts for the requested terminal transaction.
        
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="request"></param>
        /// <returns>ApiResponse of List&lt;RenderedTerminalReceipt&gt;</returns>
        public ApiResponse< List<RenderedTerminalReceipt> > FetchReceiptsWithHttpInfo (long? spaceId, TerminalReceiptFetchRequest request)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionTerminalService->FetchReceipts");
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling TransactionTerminalService->FetchReceipts");

            var localVarPath = "/transaction-terminal/fetch-receipts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content type
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

			
            int requestTimeout = this.Configuration.Timeout * 1000;

                // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FetchReceipts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<RenderedTerminalReceipt>>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (List<RenderedTerminalReceipt>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<RenderedTerminalReceipt>)));
        }
        /// <summary>
        /// Create Till Connection Credentials This operation creates a set of credentials to use within the WebSocket.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The ID of the transaction which is used to process with the terminal.</param>
        /// <param name="terminalId">The ID of the terminal which should be used to process the transaction.</param>
        /// <param name="language">The language in which the messages should be rendered in. (optional)</param>
        /// <returns>string</returns>
        public string TillConnectionCredentials (long? spaceId, long? transactionId, long? terminalId, string language = null)
        {
             ApiResponse<string> localVarResponse = TillConnectionCredentialsWithHttpInfo(spaceId, transactionId, terminalId, language);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Till Connection Credentials This operation creates a set of credentials to use within the WebSocket.
        
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The ID of the transaction which is used to process with the terminal.</param>
        /// <param name="terminalId">The ID of the terminal which should be used to process the transaction.</param>
        /// <param name="language">The language in which the messages should be rendered in. (optional)</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > TillConnectionCredentialsWithHttpInfo (long? spaceId, long? transactionId, long? terminalId, string language = null)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionTerminalService->TillConnectionCredentials");
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling TransactionTerminalService->TillConnectionCredentials");
            // verify the required parameter 'terminalId' is set
            if (terminalId == null)
                throw new ApiException(400, "Missing required parameter 'terminalId' when calling TransactionTerminalService->TillConnectionCredentials");

            var localVarPath = "/transaction-terminal/till-connection-credentials";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content type
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (transactionId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "transactionId", transactionId)); // query parameter
            if (terminalId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "terminalId", terminalId)); // query parameter
            if (language != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "language", language)); // query parameter

			
            int requestTimeout = this.Configuration.Timeout * 1000;

                // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TillConnectionCredentials", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }
    }
}
