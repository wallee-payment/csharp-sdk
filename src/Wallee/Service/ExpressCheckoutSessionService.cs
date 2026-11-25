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

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Wallee.Client;
using Wallee.Model;

namespace Wallee.Service
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IExpressCheckoutSessionServiceSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get Express Checkout Session details
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ExpressCheckoutSession</returns>
        ExpressCheckoutSession GetExpressCheckoutSession(long sessionId, long space, int operationIndex = 0);

        /// <summary>
        /// Get Express Checkout Session details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ExpressCheckoutSession</returns>
        ApiResponse<ExpressCheckoutSession> GetExpressCheckoutSessionWithHttpInfo(long sessionId, long space, int operationIndex = 0);
        /// <summary>
        /// Create a new Express Checkout Session
        /// </summary>
        /// <remarks>
        /// Creates a new Express Checkout session and returns both sessionId and sessionToken. Use the sessionToken to render the wallet widget, and persist the sessionId for the later process call.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expressCheckoutSessionCreate"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ExpressCheckoutSessionCreateResponse</returns>
        ExpressCheckoutSessionCreateResponse PostExpressCheckoutSessionCreate(long space, ExpressCheckoutSessionCreate expressCheckoutSessionCreate, int operationIndex = 0);

        /// <summary>
        /// Create a new Express Checkout Session
        /// </summary>
        /// <remarks>
        /// Creates a new Express Checkout session and returns both sessionId and sessionToken. Use the sessionToken to render the wallet widget, and persist the sessionId for the later process call.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expressCheckoutSessionCreate"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ExpressCheckoutSessionCreateResponse</returns>
        ApiResponse<ExpressCheckoutSessionCreateResponse> PostExpressCheckoutSessionCreateWithHttpInfo(long space, ExpressCheckoutSessionCreate expressCheckoutSessionCreate, int operationIndex = 0);
        /// <summary>
        /// Process Express Checkout Session
        /// </summary>
        /// <remarks>
        /// Processes the approved session and returns the redirect URL to continue checkout. Customer language and time zone are automatically derived from the HTTP request when available.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expressCheckoutSessionProcessRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ExpressCheckoutSessionProcessResponse</returns>
        ExpressCheckoutSessionProcessResponse PostExpressCheckoutSessionProcess(long space, ExpressCheckoutSessionProcessRequest expressCheckoutSessionProcessRequest, int operationIndex = 0);

        /// <summary>
        /// Process Express Checkout Session
        /// </summary>
        /// <remarks>
        /// Processes the approved session and returns the redirect URL to continue checkout. Customer language and time zone are automatically derived from the HTTP request when available.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expressCheckoutSessionProcessRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ExpressCheckoutSessionProcessResponse</returns>
        ApiResponse<ExpressCheckoutSessionProcessResponse> PostExpressCheckoutSessionProcessWithHttpInfo(long space, ExpressCheckoutSessionProcessRequest expressCheckoutSessionProcessRequest, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IExpressCheckoutSessionService : IExpressCheckoutSessionServiceSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ExpressCheckoutSessionService : IExpressCheckoutSessionService
    {

        private Wallee.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressCheckoutSessionService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ExpressCheckoutSessionService(Wallee.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            this.Configuration = configuration;
            this.Client = new Wallee.Client.ApiClient(this.Configuration);
            ExceptionFactory = Wallee.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressCheckoutSessionService"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ExpressCheckoutSessionService(Wallee.Client.ISynchronousClient client, Wallee.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.Configuration = configuration;
            this.ExceptionFactory = Wallee.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Wallee.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Wallee.Client.IReadableConfiguration Configuration { get; set; }

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
        /// Get Express Checkout Session details 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ExpressCheckoutSession</returns>
        public ExpressCheckoutSession GetExpressCheckoutSession(long sessionId, long space, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<ExpressCheckoutSession> localVarResponse = GetExpressCheckoutSessionWithHttpInfo(sessionId, space);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Express Checkout Session details 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ExpressCheckoutSession</returns>
        public Wallee.Client.ApiResponse<ExpressCheckoutSession> GetExpressCheckoutSessionWithHttpInfo(long sessionId, long space, int operationIndex = 0)
        {
            Wallee.Client.RequestOptions localVarRequestOptions = new Wallee.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Wallee.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            var localVarMultipartFormData = localVarContentType == "multipart/form-data";
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Wallee.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("", "sessionId", sessionId));
            localVarRequestOptions.HeaderParameters.Add("space", Wallee.Client.ClientUtils.ParameterToString(space)); // header parameter

            localVarRequestOptions.Operation = "ExpressCheckoutSessionService.GetExpressCheckoutSession";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Get<ExpressCheckoutSession>("/express-checkout/session",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetExpressCheckoutSession", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Create a new Express Checkout Session Creates a new Express Checkout session and returns both sessionId and sessionToken. Use the sessionToken to render the wallet widget, and persist the sessionId for the later process call.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expressCheckoutSessionCreate"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ExpressCheckoutSessionCreateResponse</returns>
        public ExpressCheckoutSessionCreateResponse PostExpressCheckoutSessionCreate(long space, ExpressCheckoutSessionCreate expressCheckoutSessionCreate, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<ExpressCheckoutSessionCreateResponse> localVarResponse = PostExpressCheckoutSessionCreateWithHttpInfo(space, expressCheckoutSessionCreate);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new Express Checkout Session Creates a new Express Checkout session and returns both sessionId and sessionToken. Use the sessionToken to render the wallet widget, and persist the sessionId for the later process call.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expressCheckoutSessionCreate"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ExpressCheckoutSessionCreateResponse</returns>
        public Wallee.Client.ApiResponse<ExpressCheckoutSessionCreateResponse> PostExpressCheckoutSessionCreateWithHttpInfo(long space, ExpressCheckoutSessionCreate expressCheckoutSessionCreate, int operationIndex = 0)
        {
            // verify the required parameter 'expressCheckoutSessionCreate' is set
            if (expressCheckoutSessionCreate == null)
            {
                throw new Wallee.Client.ApiException(400, "Missing required parameter 'expressCheckoutSessionCreate' when calling ExpressCheckoutSessionService->PostExpressCheckoutSessionCreate");
            }

            Wallee.Client.RequestOptions localVarRequestOptions = new Wallee.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Wallee.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            var localVarMultipartFormData = localVarContentType == "multipart/form-data";
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Wallee.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.HeaderParameters.Add("space", Wallee.Client.ClientUtils.ParameterToString(space)); // header parameter
            localVarRequestOptions.Data = expressCheckoutSessionCreate;

            localVarRequestOptions.Operation = "ExpressCheckoutSessionService.PostExpressCheckoutSessionCreate";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Post<ExpressCheckoutSessionCreateResponse>("/express-checkout/session/create",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostExpressCheckoutSessionCreate", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Process Express Checkout Session Processes the approved session and returns the redirect URL to continue checkout. Customer language and time zone are automatically derived from the HTTP request when available.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expressCheckoutSessionProcessRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ExpressCheckoutSessionProcessResponse</returns>
        public ExpressCheckoutSessionProcessResponse PostExpressCheckoutSessionProcess(long space, ExpressCheckoutSessionProcessRequest expressCheckoutSessionProcessRequest, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<ExpressCheckoutSessionProcessResponse> localVarResponse = PostExpressCheckoutSessionProcessWithHttpInfo(space, expressCheckoutSessionProcessRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Process Express Checkout Session Processes the approved session and returns the redirect URL to continue checkout. Customer language and time zone are automatically derived from the HTTP request when available.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expressCheckoutSessionProcessRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ExpressCheckoutSessionProcessResponse</returns>
        public Wallee.Client.ApiResponse<ExpressCheckoutSessionProcessResponse> PostExpressCheckoutSessionProcessWithHttpInfo(long space, ExpressCheckoutSessionProcessRequest expressCheckoutSessionProcessRequest, int operationIndex = 0)
        {
            // verify the required parameter 'expressCheckoutSessionProcessRequest' is set
            if (expressCheckoutSessionProcessRequest == null)
            {
                throw new Wallee.Client.ApiException(400, "Missing required parameter 'expressCheckoutSessionProcessRequest' when calling ExpressCheckoutSessionService->PostExpressCheckoutSessionProcess");
            }

            Wallee.Client.RequestOptions localVarRequestOptions = new Wallee.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Wallee.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            var localVarMultipartFormData = localVarContentType == "multipart/form-data";
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Wallee.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.HeaderParameters.Add("space", Wallee.Client.ClientUtils.ParameterToString(space)); // header parameter
            localVarRequestOptions.Data = expressCheckoutSessionProcessRequest;

            localVarRequestOptions.Operation = "ExpressCheckoutSessionService.PostExpressCheckoutSessionProcess";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Post<ExpressCheckoutSessionProcessResponse>("/express-checkout/session/process",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostExpressCheckoutSessionProcess", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }


    }
}
