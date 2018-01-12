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
    public interface ICardProcessingService : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Process
        /// </summary>
        /// <remarks>
        /// The process method will process the transaction with the given card details without using 3-D secure.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The ID of the transaction which should be processed.</param>
        /// <param name="paymentMethodConfigurationId">The payment method configuration ID which is applied to the transaction.</param>
        /// <param name="cardData">The card details as JSON in plain which should be used to authorize the payment.</param>
        /// <returns>Transaction</returns>
        Transaction Process (long? spaceId, long? transactionId, long? paymentMethodConfigurationId, UnencryptedCardDataCreate cardData);

        /// <summary>
        /// Process
        /// </summary>
        /// <remarks>
        /// The process method will process the transaction with the given card details without using 3-D secure.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The ID of the transaction which should be processed.</param>
        /// <param name="paymentMethodConfigurationId">The payment method configuration ID which is applied to the transaction.</param>
        /// <param name="cardData">The card details as JSON in plain which should be used to authorize the payment.</param>
        /// <returns>ApiResponse of Transaction</returns>
        ApiResponse<Transaction> ProcessWithHttpInfo (long? spaceId, long? transactionId, long? paymentMethodConfigurationId, UnencryptedCardDataCreate cardData);

        /// <summary>
        /// Process With 3-D Secure
        /// </summary>
        /// <remarks>
        /// The process method will process the transaction with the given card details by evenutually using 3-D secure. The buyer has to be redirect to the URL returned by this method.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The ID of the transaction which should be processed.</param>
        /// <param name="paymentMethodConfigurationId">The payment method configuration ID which is applied to the transaction.</param>
        /// <param name="cardData">The card details as JSON in plain which should be used to authorize the payment.</param>
        /// <returns>string</returns>
        string ProcessWith3DSecure (long? spaceId, long? transactionId, long? paymentMethodConfigurationId, UnencryptedCardDataCreate cardData);

        /// <summary>
        /// Process With 3-D Secure
        /// </summary>
        /// <remarks>
        /// The process method will process the transaction with the given card details by evenutually using 3-D secure. The buyer has to be redirect to the URL returned by this method.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The ID of the transaction which should be processed.</param>
        /// <param name="paymentMethodConfigurationId">The payment method configuration ID which is applied to the transaction.</param>
        /// <param name="cardData">The card details as JSON in plain which should be used to authorize the payment.</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ProcessWith3DSecureWithHttpInfo (long? spaceId, long? transactionId, long? paymentMethodConfigurationId, UnencryptedCardDataCreate cardData);

        #endregion Synchronous Operations
        #region Asynchronous Operations

        /// <summary>
        /// Process
        /// </summary>
        /// <remarks>
        /// The process method will process the transaction with the given card details without using 3-D secure.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The ID of the transaction which should be processed.</param>
        /// <param name="paymentMethodConfigurationId">The payment method configuration ID which is applied to the transaction.</param>
        /// <param name="cardData">The card details as JSON in plain which should be used to authorize the payment.</param>
        /// <returns>Task of Transaction</returns>
        System.Threading.Tasks.Task<Transaction> ProcessAsync (long? spaceId, long? transactionId, long? paymentMethodConfigurationId, UnencryptedCardDataCreate cardData);

        /// <summary>
        /// Process
        /// </summary>
        /// <remarks>
        /// The process method will process the transaction with the given card details without using 3-D secure.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The ID of the transaction which should be processed.</param>
        /// <param name="paymentMethodConfigurationId">The payment method configuration ID which is applied to the transaction.</param>
        /// <param name="cardData">The card details as JSON in plain which should be used to authorize the payment.</param>
        /// <returns>Task of ApiResponse (Transaction)</returns>
        System.Threading.Tasks.Task<ApiResponse<Transaction>> ProcessAsyncWithHttpInfo (long? spaceId, long? transactionId, long? paymentMethodConfigurationId, UnencryptedCardDataCreate cardData);

        /// <summary>
        /// Process With 3-D Secure
        /// </summary>
        /// <remarks>
        /// The process method will process the transaction with the given card details by evenutually using 3-D secure. The buyer has to be redirect to the URL returned by this method.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The ID of the transaction which should be processed.</param>
        /// <param name="paymentMethodConfigurationId">The payment method configuration ID which is applied to the transaction.</param>
        /// <param name="cardData">The card details as JSON in plain which should be used to authorize the payment.</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ProcessWith3DSecureAsync (long? spaceId, long? transactionId, long? paymentMethodConfigurationId, UnencryptedCardDataCreate cardData);

        /// <summary>
        /// Process With 3-D Secure
        /// </summary>
        /// <remarks>
        /// The process method will process the transaction with the given card details by evenutually using 3-D secure. The buyer has to be redirect to the URL returned by this method.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The ID of the transaction which should be processed.</param>
        /// <param name="paymentMethodConfigurationId">The payment method configuration ID which is applied to the transaction.</param>
        /// <param name="cardData">The card details as JSON in plain which should be used to authorize the payment.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ProcessWith3DSecureAsyncWithHttpInfo (long? spaceId, long? transactionId, long? paymentMethodConfigurationId, UnencryptedCardDataCreate cardData);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CardProcessingService : ICardProcessingService
    {
        private readonly Customweb.Wallee.Client.ExceptionFactory _exceptionFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="CardProcessingService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CardProcessingService(Configuration configuration = null)
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
        /// Process The process method will process the transaction with the given card details without using 3-D secure.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The ID of the transaction which should be processed.</param>
        /// <param name="paymentMethodConfigurationId">The payment method configuration ID which is applied to the transaction.</param>
        /// <param name="cardData">The card details as JSON in plain which should be used to authorize the payment.</param>
        /// <returns>Transaction</returns>
        public Transaction Process (long? spaceId, long? transactionId, long? paymentMethodConfigurationId, UnencryptedCardDataCreate cardData)
        {
             ApiResponse<Transaction> localVarResponse = ProcessWithHttpInfo(spaceId, transactionId, paymentMethodConfigurationId, cardData);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Process The process method will process the transaction with the given card details without using 3-D secure.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The ID of the transaction which should be processed.</param>
        /// <param name="paymentMethodConfigurationId">The payment method configuration ID which is applied to the transaction.</param>
        /// <param name="cardData">The card details as JSON in plain which should be used to authorize the payment.</param>
        /// <returns>ApiResponse of Transaction</returns>
        public ApiResponse< Transaction > ProcessWithHttpInfo (long? spaceId, long? transactionId, long? paymentMethodConfigurationId, UnencryptedCardDataCreate cardData)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling CardProcessingService->Process");
            }
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
            {
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling CardProcessingService->Process");
            }
            // verify the required parameter 'paymentMethodConfigurationId' is set
            if (paymentMethodConfigurationId == null)
            {
                throw new ApiException(400, "Missing required parameter 'paymentMethodConfigurationId' when calling CardProcessingService->Process");
            }
            // verify the required parameter 'cardData' is set
            if (cardData == null)
            {
                throw new ApiException(400, "Missing required parameter 'cardData' when calling CardProcessingService->Process");
            }

            var localVarPath = "/card-processing/process";
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
            if (transactionId != null) localVarQueryParams.Add("transactionId", ApiClient.ParameterToString(transactionId)); // query parameter
            if (paymentMethodConfigurationId != null) localVarQueryParams.Add("paymentMethodConfigurationId", ApiClient.ParameterToString(paymentMethodConfigurationId)); // query parameter
            if (cardData != null && cardData.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(cardData); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cardData; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Process", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Transaction>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Transaction) ApiClient.Deserialize(localVarResponse, typeof(Transaction)));
        }

        /// <summary>
        /// Process The process method will process the transaction with the given card details without using 3-D secure.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The ID of the transaction which should be processed.</param>
        /// <param name="paymentMethodConfigurationId">The payment method configuration ID which is applied to the transaction.</param>
        /// <param name="cardData">The card details as JSON in plain which should be used to authorize the payment.</param>
        /// <returns>Task of Transaction</returns>
        public async System.Threading.Tasks.Task<Transaction> ProcessAsync (long? spaceId, long? transactionId, long? paymentMethodConfigurationId, UnencryptedCardDataCreate cardData)
        {
             ApiResponse<Transaction> localVarResponse = await ProcessAsyncWithHttpInfo(spaceId, transactionId, paymentMethodConfigurationId, cardData);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Process The process method will process the transaction with the given card details without using 3-D secure.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The ID of the transaction which should be processed.</param>
        /// <param name="paymentMethodConfigurationId">The payment method configuration ID which is applied to the transaction.</param>
        /// <param name="cardData">The card details as JSON in plain which should be used to authorize the payment.</param>
        /// <returns>Task of ApiResponse (Transaction)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Transaction>> ProcessAsyncWithHttpInfo (long? spaceId, long? transactionId, long? paymentMethodConfigurationId, UnencryptedCardDataCreate cardData)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling CardProcessingService->Process");
            }
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
            {
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling CardProcessingService->Process");
            }
            // verify the required parameter 'paymentMethodConfigurationId' is set
            if (paymentMethodConfigurationId == null)
            {
                throw new ApiException(400, "Missing required parameter 'paymentMethodConfigurationId' when calling CardProcessingService->Process");
            }
            // verify the required parameter 'cardData' is set
            if (cardData == null)
            {
                throw new ApiException(400, "Missing required parameter 'cardData' when calling CardProcessingService->Process");
            }

            var localVarPath = "/card-processing/process";
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
            if (transactionId != null) localVarQueryParams.Add("transactionId", ApiClient.ParameterToString(transactionId)); // query parameter
            if (paymentMethodConfigurationId != null) localVarQueryParams.Add("paymentMethodConfigurationId", ApiClient.ParameterToString(paymentMethodConfigurationId)); // query parameter
            if (cardData != null && cardData.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(cardData); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cardData; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Process", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Transaction>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Transaction) ApiClient.Deserialize(localVarResponse, typeof(Transaction)));
        }

        /// <summary>
        /// Process With 3-D Secure The process method will process the transaction with the given card details by evenutually using 3-D secure. The buyer has to be redirect to the URL returned by this method.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The ID of the transaction which should be processed.</param>
        /// <param name="paymentMethodConfigurationId">The payment method configuration ID which is applied to the transaction.</param>
        /// <param name="cardData">The card details as JSON in plain which should be used to authorize the payment.</param>
        /// <returns>string</returns>
        public string ProcessWith3DSecure (long? spaceId, long? transactionId, long? paymentMethodConfigurationId, UnencryptedCardDataCreate cardData)
        {
             ApiResponse<string> localVarResponse = ProcessWith3DSecureWithHttpInfo(spaceId, transactionId, paymentMethodConfigurationId, cardData);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Process With 3-D Secure The process method will process the transaction with the given card details by evenutually using 3-D secure. The buyer has to be redirect to the URL returned by this method.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The ID of the transaction which should be processed.</param>
        /// <param name="paymentMethodConfigurationId">The payment method configuration ID which is applied to the transaction.</param>
        /// <param name="cardData">The card details as JSON in plain which should be used to authorize the payment.</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ProcessWith3DSecureWithHttpInfo (long? spaceId, long? transactionId, long? paymentMethodConfigurationId, UnencryptedCardDataCreate cardData)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling CardProcessingService->ProcessWith3DSecure");
            }
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
            {
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling CardProcessingService->ProcessWith3DSecure");
            }
            // verify the required parameter 'paymentMethodConfigurationId' is set
            if (paymentMethodConfigurationId == null)
            {
                throw new ApiException(400, "Missing required parameter 'paymentMethodConfigurationId' when calling CardProcessingService->ProcessWith3DSecure");
            }
            // verify the required parameter 'cardData' is set
            if (cardData == null)
            {
                throw new ApiException(400, "Missing required parameter 'cardData' when calling CardProcessingService->ProcessWith3DSecure");
            }

            var localVarPath = "/card-processing/processWith3DSecure";
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
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (transactionId != null) localVarQueryParams.Add("transactionId", ApiClient.ParameterToString(transactionId)); // query parameter
            if (paymentMethodConfigurationId != null) localVarQueryParams.Add("paymentMethodConfigurationId", ApiClient.ParameterToString(paymentMethodConfigurationId)); // query parameter
            if (cardData != null && cardData.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(cardData); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cardData; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ProcessWith3DSecure", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Process With 3-D Secure The process method will process the transaction with the given card details by evenutually using 3-D secure. The buyer has to be redirect to the URL returned by this method.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The ID of the transaction which should be processed.</param>
        /// <param name="paymentMethodConfigurationId">The payment method configuration ID which is applied to the transaction.</param>
        /// <param name="cardData">The card details as JSON in plain which should be used to authorize the payment.</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ProcessWith3DSecureAsync (long? spaceId, long? transactionId, long? paymentMethodConfigurationId, UnencryptedCardDataCreate cardData)
        {
             ApiResponse<string> localVarResponse = await ProcessWith3DSecureAsyncWithHttpInfo(spaceId, transactionId, paymentMethodConfigurationId, cardData);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Process With 3-D Secure The process method will process the transaction with the given card details by evenutually using 3-D secure. The buyer has to be redirect to the URL returned by this method.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The ID of the transaction which should be processed.</param>
        /// <param name="paymentMethodConfigurationId">The payment method configuration ID which is applied to the transaction.</param>
        /// <param name="cardData">The card details as JSON in plain which should be used to authorize the payment.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ProcessWith3DSecureAsyncWithHttpInfo (long? spaceId, long? transactionId, long? paymentMethodConfigurationId, UnencryptedCardDataCreate cardData)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling CardProcessingService->ProcessWith3DSecure");
            }
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
            {
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling CardProcessingService->ProcessWith3DSecure");
            }
            // verify the required parameter 'paymentMethodConfigurationId' is set
            if (paymentMethodConfigurationId == null)
            {
                throw new ApiException(400, "Missing required parameter 'paymentMethodConfigurationId' when calling CardProcessingService->ProcessWith3DSecure");
            }
            // verify the required parameter 'cardData' is set
            if (cardData == null)
            {
                throw new ApiException(400, "Missing required parameter 'cardData' when calling CardProcessingService->ProcessWith3DSecure");
            }

            var localVarPath = "/card-processing/processWith3DSecure";
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
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (transactionId != null) localVarQueryParams.Add("transactionId", ApiClient.ParameterToString(transactionId)); // query parameter
            if (paymentMethodConfigurationId != null) localVarQueryParams.Add("paymentMethodConfigurationId", ApiClient.ParameterToString(paymentMethodConfigurationId)); // query parameter
            if (cardData != null && cardData.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(cardData); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cardData; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ProcessWith3DSecure", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

    }
}
