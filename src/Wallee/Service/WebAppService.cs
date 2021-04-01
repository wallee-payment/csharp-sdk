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
    public interface IWebAppService : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Check Installation
        /// </summary>
        /// <remarks>
        /// This operation returns true when the app is installed in given space. The web app is implied by the client ID resp. user ID that is been used to invoke this operation.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">This parameter identifies the space which should be checked if the web app is installed.</param>
        /// <returns>bool?</returns>
        bool? CheckInstallation (long? spaceId);

        /// <summary>
        /// Check Installation
        /// </summary>
        /// <remarks>
        /// This operation returns true when the app is installed in given space. The web app is implied by the client ID resp. user ID that is been used to invoke this operation.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">This parameter identifies the space which should be checked if the web app is installed.</param>
        /// <returns>ApiResponse of bool?</returns>
        ApiResponse<bool?> CheckInstallationWithHttpInfo (long? spaceId);
        /// <summary>
        /// Confirm
        /// </summary>
        /// <remarks>
        /// This operation confirms the app installation. This method has to be invoked after the user returns to the web app. The request of the user will contain the code as a request parameter. The web app is implied by the client ID resp. user ID that is been used to invoke this operation.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <returns>WebAppConfirmationResponse</returns>
        WebAppConfirmationResponse Confirm (WebAppConfirmationRequest request);

        /// <summary>
        /// Confirm
        /// </summary>
        /// <remarks>
        /// This operation confirms the app installation. This method has to be invoked after the user returns to the web app. The request of the user will contain the code as a request parameter. The web app is implied by the client ID resp. user ID that is been used to invoke this operation.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <returns>ApiResponse of WebAppConfirmationResponse</returns>
        ApiResponse<WebAppConfirmationResponse> ConfirmWithHttpInfo (WebAppConfirmationRequest request);
        /// <summary>
        /// Uninstall
        /// </summary>
        /// <remarks>
        /// This operation uninstalls the web app from the provided space. The web app is implied by the client ID resp. user ID that is been used to invoke this operation.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">This parameter identifies the space within which the web app should be uninstalled.</param>
        /// <returns></returns>
        void Uninstall (long? spaceId);

        /// <summary>
        /// Uninstall
        /// </summary>
        /// <remarks>
        /// This operation uninstalls the web app from the provided space. The web app is implied by the client ID resp. user ID that is been used to invoke this operation.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">This parameter identifies the space within which the web app should be uninstalled.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UninstallWithHttpInfo (long? spaceId);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class WebAppService : IWebAppService
    {
        private Wallee.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="WebAppService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public WebAppService(Wallee.Client.Configuration configuration = null)
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
        /// Check Installation This operation returns true when the app is installed in given space. The web app is implied by the client ID resp. user ID that is been used to invoke this operation.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">This parameter identifies the space which should be checked if the web app is installed.</param>
        /// <returns>bool?</returns>
        public bool? CheckInstallation (long? spaceId)
        {
             ApiResponse<bool?> localVarResponse = CheckInstallationWithHttpInfo(spaceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Check Installation This operation returns true when the app is installed in given space. The web app is implied by the client ID resp. user ID that is been used to invoke this operation.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">This parameter identifies the space which should be checked if the web app is installed.</param>
        /// <returns>ApiResponse of bool?</returns>
        public ApiResponse< bool? > CheckInstallationWithHttpInfo (long? spaceId)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling WebAppService->CheckInstallation");

            var localVarPath = "/web-app/check-installation";
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

			
			this.Configuration.ApiClient.ResetTimeout();
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CheckInstallation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<bool?>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (bool?) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(bool?)));
        }
        /// <summary>
        /// Confirm This operation confirms the app installation. This method has to be invoked after the user returns to the web app. The request of the user will contain the code as a request parameter. The web app is implied by the client ID resp. user ID that is been used to invoke this operation.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <returns>WebAppConfirmationResponse</returns>
        public WebAppConfirmationResponse Confirm (WebAppConfirmationRequest request)
        {
             ApiResponse<WebAppConfirmationResponse> localVarResponse = ConfirmWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Confirm This operation confirms the app installation. This method has to be invoked after the user returns to the web app. The request of the user will contain the code as a request parameter. The web app is implied by the client ID resp. user ID that is been used to invoke this operation.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <returns>ApiResponse of WebAppConfirmationResponse</returns>
        public ApiResponse< WebAppConfirmationResponse > ConfirmWithHttpInfo (WebAppConfirmationRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling WebAppService->Confirm");

            var localVarPath = "/web-app/confirm";
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
                Exception exception = ExceptionFactory("Confirm", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<WebAppConfirmationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WebAppConfirmationResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebAppConfirmationResponse)));
        }
        /// <summary>
        /// Uninstall This operation uninstalls the web app from the provided space. The web app is implied by the client ID resp. user ID that is been used to invoke this operation.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">This parameter identifies the space within which the web app should be uninstalled.</param>
        /// <returns></returns>
        public void Uninstall (long? spaceId)
        {
             UninstallWithHttpInfo(spaceId);
        }

        /// <summary>
        /// Uninstall This operation uninstalls the web app from the provided space. The web app is implied by the client ID resp. user ID that is been used to invoke this operation.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">This parameter identifies the space within which the web app should be uninstalled.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UninstallWithHttpInfo (long? spaceId)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling WebAppService->Uninstall");

            var localVarPath = "/web-app/uninstall";
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

			
			this.Configuration.ApiClient.ResetTimeout();
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Uninstall", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    }
}
