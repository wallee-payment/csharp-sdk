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
    public interface ITransactionMobileSdkService : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Build Mobile SDK URL
        /// </summary>
        /// <remarks>
        /// This operation builds the URL which is used to load the payment form within a WebView on a mobile device. This operation is typically called through the mobile SDK.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>string</returns>
        string PaymentFormUrl (string credentials);

        /// <summary>
        /// Build Mobile SDK URL
        /// </summary>
        /// <remarks>
        /// This operation builds the URL which is used to load the payment form within a WebView on a mobile device. This operation is typically called through the mobile SDK.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> PaymentFormUrlWithHttpInfo (string credentials);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TransactionMobileSdkService : ITransactionMobileSdkService
    {
        private Wallee.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionMobileSdkService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TransactionMobileSdkService(Wallee.Client.Configuration configuration = null)
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
        /// Build Mobile SDK URL This operation builds the URL which is used to load the payment form within a WebView on a mobile device. This operation is typically called through the mobile SDK.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>string</returns>
        public string PaymentFormUrl (string credentials)
        {
             ApiResponse<string> localVarResponse = PaymentFormUrlWithHttpInfo(credentials);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Build Mobile SDK URL This operation builds the URL which is used to load the payment form within a WebView on a mobile device. This operation is typically called through the mobile SDK.
        
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">The credentials identifies the transaction and contains the security details which grants the access this operation.</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > PaymentFormUrlWithHttpInfo (string credentials)
        {
            // verify the required parameter 'credentials' is set
            if (credentials == null)
                throw new ApiException(400, "Missing required parameter 'credentials' when calling TransactionMobileSdkService->PaymentFormUrl");

            var localVarPath = "/transaction-mobile-sdk/payment-form-url";
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

            if (credentials != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "credentials", credentials)); // query parameter

			
            int requestTimeout = this.Configuration.Timeout * 1000;

                // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PaymentFormUrl", localVarResponse);
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
