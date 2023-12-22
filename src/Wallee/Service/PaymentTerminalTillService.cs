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
    public interface IPaymentTerminalTillService : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Perform Payment Terminal Transaction
        /// </summary>
        /// <remarks>
        /// Starts a payment terminal transaction and waits for its completion. If the call returns with a long polling timeout status, you may try again. The processing of the transaction will be picked up where it was left off.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The ID of the transaction which is used to process with the terminal.</param>
        /// <param name="terminalId">The ID of the terminal which should be used to process the transaction.</param>
        /// <param name="language">The language in which the messages should be rendered in. (optional)</param>
        /// <returns>Transaction</returns>
        Transaction PerformTransaction (long? spaceId, long? transactionId, long? terminalId, string language = null);

        /// <summary>
        /// Perform Payment Terminal Transaction
        /// </summary>
        /// <remarks>
        /// Starts a payment terminal transaction and waits for its completion. If the call returns with a long polling timeout status, you may try again. The processing of the transaction will be picked up where it was left off.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The ID of the transaction which is used to process with the terminal.</param>
        /// <param name="terminalId">The ID of the terminal which should be used to process the transaction.</param>
        /// <param name="language">The language in which the messages should be rendered in. (optional)</param>
        /// <returns>ApiResponse of Transaction</returns>
        ApiResponse<Transaction> PerformTransactionWithHttpInfo (long? spaceId, long? transactionId, long? terminalId, string language = null);



        /// <summary>
        /// Perform Payment Terminal Transaction (using TID)
        /// </summary>
        /// <remarks>
        /// Starts a payment terminal transaction and waits for its completion. If the call returns with a long polling timeout status, you may try again. The processing of the transaction will be picked up where it was left off.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The ID of the transaction which is used to process with the terminal.</param>
        /// <param name="terminalIdentifier">The identifier (aka TID) of the terminal which should be used to process the transaction.</param>
        /// <param name="language">The language in which the messages should be rendered in. (optional)</param>
        /// <returns>Transaction</returns>
        Transaction PerformTransactionByIdentifier (long? spaceId, long? transactionId, string terminalIdentifier, string language = null);

        /// <summary>
        /// Perform Payment Terminal Transaction (using TID)
        /// </summary>
        /// <remarks>
        /// Starts a payment terminal transaction and waits for its completion. If the call returns with a long polling timeout status, you may try again. The processing of the transaction will be picked up where it was left off.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The ID of the transaction which is used to process with the terminal.</param>
        /// <param name="terminalIdentifier">The identifier (aka TID) of the terminal which should be used to process the transaction.</param>
        /// <param name="language">The language in which the messages should be rendered in. (optional)</param>
        /// <returns>ApiResponse of Transaction</returns>
        ApiResponse<Transaction> PerformTransactionByIdentifierWithHttpInfo (long? spaceId, long? transactionId, string terminalIdentifier, string language = null);



        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PaymentTerminalTillService : IPaymentTerminalTillService
    {
        private Wallee.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTerminalTillService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PaymentTerminalTillService(Wallee.Client.Configuration configuration = null)
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
        /// Perform Payment Terminal Transaction Starts a payment terminal transaction and waits for its completion. If the call returns with a long polling timeout status, you may try again. The processing of the transaction will be picked up where it was left off.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The ID of the transaction which is used to process with the terminal.</param>
        /// <param name="terminalId">The ID of the terminal which should be used to process the transaction.</param>
        /// <param name="language">The language in which the messages should be rendered in. (optional)</param>
        /// <returns>Transaction</returns>
        public Transaction PerformTransaction (long? spaceId, long? transactionId, long? terminalId, string language = null)
        {
             ApiResponse<Transaction> localVarResponse = PerformTransactionWithHttpInfo(spaceId, transactionId, terminalId, language);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Perform Payment Terminal Transaction Starts a payment terminal transaction and waits for its completion. If the call returns with a long polling timeout status, you may try again. The processing of the transaction will be picked up where it was left off.
        /// Timeout for this request is: 90 seconds.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The ID of the transaction which is used to process with the terminal.</param>
        /// <param name="terminalId">The ID of the terminal which should be used to process the transaction.</param>
        /// <param name="language">The language in which the messages should be rendered in. (optional)</param>
        /// <returns>ApiResponse of Transaction</returns>
        public ApiResponse< Transaction > PerformTransactionWithHttpInfo (long? spaceId, long? transactionId, long? terminalId, string language = null)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling PaymentTerminalTillService->PerformTransaction");
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling PaymentTerminalTillService->PerformTransaction");
            // verify the required parameter 'terminalId' is set
            if (terminalId == null)
                throw new ApiException(400, "Missing required parameter 'terminalId' when calling PaymentTerminalTillService->PerformTransaction");

            var localVarPath = "/payment-terminal-till/perform-transaction";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content type
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (transactionId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "transactionId", transactionId)); // query parameter
            if (terminalId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "terminalId", terminalId)); // query parameter
            if (language != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "language", language)); // query parameter

			int requestTimeout = 90 * 1000;
            

                // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PerformTransaction", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Transaction>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (Transaction) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Transaction)));
        }
        /// <summary>
        /// Perform Payment Terminal Transaction (using TID) Starts a payment terminal transaction and waits for its completion. If the call returns with a long polling timeout status, you may try again. The processing of the transaction will be picked up where it was left off.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The ID of the transaction which is used to process with the terminal.</param>
        /// <param name="terminalIdentifier">The identifier (aka TID) of the terminal which should be used to process the transaction.</param>
        /// <param name="language">The language in which the messages should be rendered in. (optional)</param>
        /// <returns>Transaction</returns>
        public Transaction PerformTransactionByIdentifier (long? spaceId, long? transactionId, string terminalIdentifier, string language = null)
        {
             ApiResponse<Transaction> localVarResponse = PerformTransactionByIdentifierWithHttpInfo(spaceId, transactionId, terminalIdentifier, language);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Perform Payment Terminal Transaction (using TID) Starts a payment terminal transaction and waits for its completion. If the call returns with a long polling timeout status, you may try again. The processing of the transaction will be picked up where it was left off.
        /// Timeout for this request is: 90 seconds.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The ID of the transaction which is used to process with the terminal.</param>
        /// <param name="terminalIdentifier">The identifier (aka TID) of the terminal which should be used to process the transaction.</param>
        /// <param name="language">The language in which the messages should be rendered in. (optional)</param>
        /// <returns>ApiResponse of Transaction</returns>
        public ApiResponse< Transaction > PerformTransactionByIdentifierWithHttpInfo (long? spaceId, long? transactionId, string terminalIdentifier, string language = null)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling PaymentTerminalTillService->PerformTransactionByIdentifier");
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling PaymentTerminalTillService->PerformTransactionByIdentifier");
            // verify the required parameter 'terminalIdentifier' is set
            if (terminalIdentifier == null)
                throw new ApiException(400, "Missing required parameter 'terminalIdentifier' when calling PaymentTerminalTillService->PerformTransactionByIdentifier");

            var localVarPath = "/payment-terminal-till/perform-transaction-by-identifier";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content type
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (transactionId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "transactionId", transactionId)); // query parameter
            if (terminalIdentifier != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "terminalIdentifier", terminalIdentifier)); // query parameter
            if (language != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "language", language)); // query parameter

			int requestTimeout = 90 * 1000;
            

                // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PerformTransactionByIdentifier", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Transaction>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (Transaction) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Transaction)));
        }
    }
}
