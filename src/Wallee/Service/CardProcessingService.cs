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
    public interface ICardProcessingService : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Process
        /// </summary>
        /// <remarks>
        /// The process method will process the transaction with the given card details without using 3-D secure.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The ID of the transaction which should be processed.</param>
        /// <param name="paymentMethodConfigurationId">The payment method configuration ID which is applied to the transaction.</param>
        /// <param name="cardData">The card details as JSON in plain which should be used to authorize the payment.</param>
        /// <returns>Transaction</returns>
        Transaction Process (long? spaceId, long? transactionId, long? paymentMethodConfigurationId, AuthenticatedCardDataCreate cardData);

        /// <summary>
        /// Process
        /// </summary>
        /// <remarks>
        /// The process method will process the transaction with the given card details without using 3-D secure.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The ID of the transaction which should be processed.</param>
        /// <param name="paymentMethodConfigurationId">The payment method configuration ID which is applied to the transaction.</param>
        /// <param name="cardData">The card details as JSON in plain which should be used to authorize the payment.</param>
        /// <returns>ApiResponse of Transaction</returns>
        ApiResponse<Transaction> ProcessWithHttpInfo (long? spaceId, long? transactionId, long? paymentMethodConfigurationId, AuthenticatedCardDataCreate cardData);



        /// <summary>
        /// Process With 3-D Secure
        /// </summary>
        /// <remarks>
        /// The process method will process the transaction with the given card details by eventually using 3-D secure. The buyer has to be redirect to the URL returned by this method.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The ID of the transaction which should be processed.</param>
        /// <param name="paymentMethodConfigurationId">The payment method configuration ID which is applied to the transaction.</param>
        /// <param name="cardData">The card details as JSON in plain which should be used to authorize the payment.</param>
        /// <returns>string</returns>
        string ProcessWith3DSecure (long? spaceId, long? transactionId, long? paymentMethodConfigurationId, TokenizedCardDataCreate cardData);

        /// <summary>
        /// Process With 3-D Secure
        /// </summary>
        /// <remarks>
        /// The process method will process the transaction with the given card details by eventually using 3-D secure. The buyer has to be redirect to the URL returned by this method.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The ID of the transaction which should be processed.</param>
        /// <param name="paymentMethodConfigurationId">The payment method configuration ID which is applied to the transaction.</param>
        /// <param name="cardData">The card details as JSON in plain which should be used to authorize the payment.</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ProcessWith3DSecureWithHttpInfo (long? spaceId, long? transactionId, long? paymentMethodConfigurationId, TokenizedCardDataCreate cardData);



        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CardProcessingService : ICardProcessingService
    {
        private Wallee.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CardProcessingService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CardProcessingService(Wallee.Client.Configuration configuration = null)
        {
            if (configuration == null) {
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
        /// Process The process method will process the transaction with the given card details without using 3-D secure.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The ID of the transaction which should be processed.</param>
        /// <param name="paymentMethodConfigurationId">The payment method configuration ID which is applied to the transaction.</param>
        /// <param name="cardData">The card details as JSON in plain which should be used to authorize the payment.</param>
        /// <returns>Transaction</returns>
        public Transaction Process (long? spaceId, long? transactionId, long? paymentMethodConfigurationId, AuthenticatedCardDataCreate cardData)
        {
             ApiResponse<Transaction> localVarResponse = ProcessWithHttpInfo(spaceId, transactionId, paymentMethodConfigurationId, cardData);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Process The process method will process the transaction with the given card details without using 3-D secure.
        
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The ID of the transaction which should be processed.</param>
        /// <param name="paymentMethodConfigurationId">The payment method configuration ID which is applied to the transaction.</param>
        /// <param name="cardData">The card details as JSON in plain which should be used to authorize the payment.</param>
        /// <returns>ApiResponse of Transaction</returns>
        public ApiResponse< Transaction > ProcessWithHttpInfo (long? spaceId, long? transactionId, long? paymentMethodConfigurationId, AuthenticatedCardDataCreate cardData)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling CardProcessingService->Process");
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling CardProcessingService->Process");
            // verify the required parameter 'paymentMethodConfigurationId' is set
            if (paymentMethodConfigurationId == null)
                throw new ApiException(400, "Missing required parameter 'paymentMethodConfigurationId' when calling CardProcessingService->Process");
            // verify the required parameter 'cardData' is set
            if (cardData == null)
                throw new ApiException(400, "Missing required parameter 'cardData' when calling CardProcessingService->Process");

            var localVarPath = "/card-processing/process";
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
            if (transactionId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "transactionId", transactionId)); // query parameter
            if (paymentMethodConfigurationId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "paymentMethodConfigurationId", paymentMethodConfigurationId)); // query parameter
            if (cardData != null && cardData.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(cardData); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cardData; // byte array
            }

			int requestTimeout = this.Configuration.Timeout * 1000;

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
                localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Process", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Transaction>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (Transaction) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Transaction)));
        }
        /// <summary>
        /// Process With 3-D Secure The process method will process the transaction with the given card details by eventually using 3-D secure. The buyer has to be redirect to the URL returned by this method.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The ID of the transaction which should be processed.</param>
        /// <param name="paymentMethodConfigurationId">The payment method configuration ID which is applied to the transaction.</param>
        /// <param name="cardData">The card details as JSON in plain which should be used to authorize the payment.</param>
        /// <returns>string</returns>
        public string ProcessWith3DSecure (long? spaceId, long? transactionId, long? paymentMethodConfigurationId, TokenizedCardDataCreate cardData)
        {
             ApiResponse<string> localVarResponse = ProcessWith3DSecureWithHttpInfo(spaceId, transactionId, paymentMethodConfigurationId, cardData);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Process With 3-D Secure The process method will process the transaction with the given card details by eventually using 3-D secure. The buyer has to be redirect to the URL returned by this method.
        
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The ID of the transaction which should be processed.</param>
        /// <param name="paymentMethodConfigurationId">The payment method configuration ID which is applied to the transaction.</param>
        /// <param name="cardData">The card details as JSON in plain which should be used to authorize the payment.</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ProcessWith3DSecureWithHttpInfo (long? spaceId, long? transactionId, long? paymentMethodConfigurationId, TokenizedCardDataCreate cardData)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling CardProcessingService->ProcessWith3DSecure");
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling CardProcessingService->ProcessWith3DSecure");
            // verify the required parameter 'paymentMethodConfigurationId' is set
            if (paymentMethodConfigurationId == null)
                throw new ApiException(400, "Missing required parameter 'paymentMethodConfigurationId' when calling CardProcessingService->ProcessWith3DSecure");
            // verify the required parameter 'cardData' is set
            if (cardData == null)
                throw new ApiException(400, "Missing required parameter 'cardData' when calling CardProcessingService->ProcessWith3DSecure");

            var localVarPath = "/card-processing/processWith3DSecure";
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
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (transactionId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "transactionId", transactionId)); // query parameter
            if (paymentMethodConfigurationId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "paymentMethodConfigurationId", paymentMethodConfigurationId)); // query parameter
            if (cardData != null && cardData.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(cardData); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cardData; // byte array
            }

			int requestTimeout = this.Configuration.Timeout * 1000;

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
                localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ProcessWith3DSecure", localVarResponse);
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
