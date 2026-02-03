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
    public interface IBogusExpressCheckoutServiceSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Approve express checkout wallet payment
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="bogusExpressCheckoutApprovalRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ExpressCheckoutApprovalResponse</returns>
        ExpressCheckoutApprovalResponse PostBogusExpressCheckoutOnApprove(string sessionToken, long space, BogusExpressCheckoutApprovalRequest bogusExpressCheckoutApprovalRequest, int operationIndex = 0);

        /// <summary>
        /// Approve express checkout wallet payment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="bogusExpressCheckoutApprovalRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ExpressCheckoutApprovalResponse</returns>
        ApiResponse<ExpressCheckoutApprovalResponse> PostBogusExpressCheckoutOnApproveWithHttpInfo(string sessionToken, long space, BogusExpressCheckoutApprovalRequest bogusExpressCheckoutApprovalRequest, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBogusExpressCheckoutService : IBogusExpressCheckoutServiceSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class BogusExpressCheckoutService : IBogusExpressCheckoutService
    {

        private Wallee.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BogusExpressCheckoutService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BogusExpressCheckoutService(Wallee.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            this.Configuration = configuration;
            this.Client = new Wallee.Client.ApiClient(this.Configuration);
            ExceptionFactory = Wallee.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BogusExpressCheckoutService"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public BogusExpressCheckoutService(Wallee.Client.ISynchronousClient client, Wallee.Client.IReadableConfiguration configuration)
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
        /// Approve express checkout wallet payment 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="bogusExpressCheckoutApprovalRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ExpressCheckoutApprovalResponse</returns>
        public ExpressCheckoutApprovalResponse PostBogusExpressCheckoutOnApprove(string sessionToken, long space, BogusExpressCheckoutApprovalRequest bogusExpressCheckoutApprovalRequest, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<ExpressCheckoutApprovalResponse> localVarResponse = PostBogusExpressCheckoutOnApproveWithHttpInfo(sessionToken, space, bogusExpressCheckoutApprovalRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Approve express checkout wallet payment 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionToken"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="bogusExpressCheckoutApprovalRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ExpressCheckoutApprovalResponse</returns>
        public Wallee.Client.ApiResponse<ExpressCheckoutApprovalResponse> PostBogusExpressCheckoutOnApproveWithHttpInfo(string sessionToken, long space, BogusExpressCheckoutApprovalRequest bogusExpressCheckoutApprovalRequest, int operationIndex = 0)
        {
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
            {
                throw new Wallee.Client.ApiException(400, "Missing required parameter 'sessionToken' when calling BogusExpressCheckoutService->PostBogusExpressCheckoutOnApprove");
            }

            // verify the required parameter 'bogusExpressCheckoutApprovalRequest' is set
            if (bogusExpressCheckoutApprovalRequest == null)
            {
                throw new Wallee.Client.ApiException(400, "Missing required parameter 'bogusExpressCheckoutApprovalRequest' when calling BogusExpressCheckoutService->PostBogusExpressCheckoutOnApprove");
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

            localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("", "sessionToken", sessionToken));
            localVarRequestOptions.HeaderParameters.Add("Space", Wallee.Client.ClientUtils.ParameterToString(space)); // header parameter
            localVarRequestOptions.Data = bogusExpressCheckoutApprovalRequest;

            localVarRequestOptions.Operation = "BogusExpressCheckoutService.PostBogusExpressCheckoutOnApprove";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Post<ExpressCheckoutApprovalResponse>("/bogus-express-checkout/on-approve",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostBogusExpressCheckoutOnApprove", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }


    }
}
