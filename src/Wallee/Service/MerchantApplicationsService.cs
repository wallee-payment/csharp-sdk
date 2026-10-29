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
    public interface IMerchantApplicationsServiceSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieve a merchant application status
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>MerchantApplicationStatusDto</returns>
        MerchantApplicationStatusDto GetOnboardingMerchantApplicationsIdStatus(long id, long account, List<string>? expand = default, int operationIndex = 0);

        /// <summary>
        /// Retrieve a merchant application status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of MerchantApplicationStatusDto</returns>
        ApiResponse<MerchantApplicationStatusDto> GetOnboardingMerchantApplicationsIdStatusWithHttpInfo(long id, long account, List<string>? expand = default, int operationIndex = 0);
        /// <summary>
        /// Return merchant application submission URL
        /// </summary>
        /// <remarks>
        /// Returns the URL where the merchant can review the application and complete the submission.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>string</returns>
        string GetOnboardingMerchantApplicationsIdSubmissionUrl(long id, long account, int operationIndex = 0);

        /// <summary>
        /// Return merchant application submission URL
        /// </summary>
        /// <remarks>
        /// Returns the URL where the merchant can review the application and complete the submission.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> GetOnboardingMerchantApplicationsIdSubmissionUrlWithHttpInfo(long id, long account, int operationIndex = 0);
        /// <summary>
        /// Update a merchant application
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="merchantApplicationDataDto"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>MerchantApplicationDataDto</returns>
        MerchantApplicationDataDto PatchOnboardingMerchantApplicationsId(long id, long account, MerchantApplicationDataDto merchantApplicationDataDto, List<string>? expand = default, int operationIndex = 0);

        /// <summary>
        /// Update a merchant application
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="merchantApplicationDataDto"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of MerchantApplicationDataDto</returns>
        ApiResponse<MerchantApplicationDataDto> PatchOnboardingMerchantApplicationsIdWithHttpInfo(long id, long account, MerchantApplicationDataDto merchantApplicationDataDto, List<string>? expand = default, int operationIndex = 0);
        /// <summary>
        /// Create a merchant application
        /// </summary>
        /// <remarks>
        /// Creates a merchant application. The request body is optional. Send an empty body to create a draft application, or send the full application payload to create it with initial data
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="merchantApplicationDataDto"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>MerchantApplicationDataDto</returns>
        MerchantApplicationDataDto PostOnboardingMerchantApplications(long account, List<string>? expand = default, MerchantApplicationDataDto? merchantApplicationDataDto = default, int operationIndex = 0);

        /// <summary>
        /// Create a merchant application
        /// </summary>
        /// <remarks>
        /// Creates a merchant application. The request body is optional. Send an empty body to create a draft application, or send the full application payload to create it with initial data
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="merchantApplicationDataDto"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of MerchantApplicationDataDto</returns>
        ApiResponse<MerchantApplicationDataDto> PostOnboardingMerchantApplicationsWithHttpInfo(long account, List<string>? expand = default, MerchantApplicationDataDto? merchantApplicationDataDto = default, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMerchantApplicationsService : IMerchantApplicationsServiceSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MerchantApplicationsService : IMerchantApplicationsService
    {

        private Wallee.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantApplicationsService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MerchantApplicationsService(Wallee.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            this.Configuration = configuration;
            this.Client = new Wallee.Client.ApiClient(this.Configuration);
            ExceptionFactory = Wallee.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantApplicationsService"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public MerchantApplicationsService(Wallee.Client.ISynchronousClient client, Wallee.Client.IReadableConfiguration configuration)
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
        /// Retrieve a merchant application status 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>MerchantApplicationStatusDto</returns>
        public MerchantApplicationStatusDto GetOnboardingMerchantApplicationsIdStatus(long id, long account, List<string>? expand = default, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<MerchantApplicationStatusDto> localVarResponse = GetOnboardingMerchantApplicationsIdStatusWithHttpInfo(id, account, expand);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a merchant application status 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of MerchantApplicationStatusDto</returns>
        public Wallee.Client.ApiResponse<MerchantApplicationStatusDto> GetOnboardingMerchantApplicationsIdStatusWithHttpInfo(long id, long account, List<string>? expand = default, int operationIndex = 0)
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

            localVarRequestOptions.PathParameters.Add("id", Wallee.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("multi", "expand", expand));
            }
            localVarRequestOptions.HeaderParameters.Add("account", Wallee.Client.ClientUtils.ParameterToString(account)); // header parameter

            localVarRequestOptions.Operation = "MerchantApplicationsService.GetOnboardingMerchantApplicationsIdStatus";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Get<MerchantApplicationStatusDto>("/onboarding/merchant-applications/{id}/status",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetOnboardingMerchantApplicationsIdStatus", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Return merchant application submission URL Returns the URL where the merchant can review the application and complete the submission.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>string</returns>
        public string GetOnboardingMerchantApplicationsIdSubmissionUrl(long id, long account, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<string> localVarResponse = GetOnboardingMerchantApplicationsIdSubmissionUrlWithHttpInfo(id, account);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Return merchant application submission URL Returns the URL where the merchant can review the application and complete the submission.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of string</returns>
        public Wallee.Client.ApiResponse<string> GetOnboardingMerchantApplicationsIdSubmissionUrlWithHttpInfo(long id, long account, int operationIndex = 0)
        {
            Wallee.Client.RequestOptions localVarRequestOptions = new Wallee.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
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

            localVarRequestOptions.PathParameters.Add("id", Wallee.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("account", Wallee.Client.ClientUtils.ParameterToString(account)); // header parameter

            localVarRequestOptions.Operation = "MerchantApplicationsService.GetOnboardingMerchantApplicationsIdSubmissionUrl";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Get<string>("/onboarding/merchant-applications/{id}/submission-url",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetOnboardingMerchantApplicationsIdSubmissionUrl", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Update a merchant application 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="merchantApplicationDataDto"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>MerchantApplicationDataDto</returns>
        public MerchantApplicationDataDto PatchOnboardingMerchantApplicationsId(long id, long account, MerchantApplicationDataDto merchantApplicationDataDto, List<string>? expand = default, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<MerchantApplicationDataDto> localVarResponse = PatchOnboardingMerchantApplicationsIdWithHttpInfo(id, account, merchantApplicationDataDto, expand);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a merchant application 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="merchantApplicationDataDto"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of MerchantApplicationDataDto</returns>
        public Wallee.Client.ApiResponse<MerchantApplicationDataDto> PatchOnboardingMerchantApplicationsIdWithHttpInfo(long id, long account, MerchantApplicationDataDto merchantApplicationDataDto, List<string>? expand = default, int operationIndex = 0)
        {
            // verify the required parameter 'merchantApplicationDataDto' is set
            if (merchantApplicationDataDto == null)
            {
                throw new Wallee.Client.ApiException(400, "Missing required parameter 'merchantApplicationDataDto' when calling MerchantApplicationsService->PatchOnboardingMerchantApplicationsId");
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

            localVarRequestOptions.PathParameters.Add("id", Wallee.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("multi", "expand", expand));
            }
            localVarRequestOptions.HeaderParameters.Add("account", Wallee.Client.ClientUtils.ParameterToString(account)); // header parameter
            localVarRequestOptions.Data = merchantApplicationDataDto;

            localVarRequestOptions.Operation = "MerchantApplicationsService.PatchOnboardingMerchantApplicationsId";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Patch<MerchantApplicationDataDto>("/onboarding/merchant-applications/{id}",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PatchOnboardingMerchantApplicationsId", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Create a merchant application Creates a merchant application. The request body is optional. Send an empty body to create a draft application, or send the full application payload to create it with initial data
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="merchantApplicationDataDto"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>MerchantApplicationDataDto</returns>
        public MerchantApplicationDataDto PostOnboardingMerchantApplications(long account, List<string>? expand = default, MerchantApplicationDataDto? merchantApplicationDataDto = default, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<MerchantApplicationDataDto> localVarResponse = PostOnboardingMerchantApplicationsWithHttpInfo(account, expand, merchantApplicationDataDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a merchant application Creates a merchant application. The request body is optional. Send an empty body to create a draft application, or send the full application payload to create it with initial data
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="merchantApplicationDataDto"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of MerchantApplicationDataDto</returns>
        public Wallee.Client.ApiResponse<MerchantApplicationDataDto> PostOnboardingMerchantApplicationsWithHttpInfo(long account, List<string>? expand = default, MerchantApplicationDataDto? merchantApplicationDataDto = default, int operationIndex = 0)
        {
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

            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("multi", "expand", expand));
            }
            localVarRequestOptions.HeaderParameters.Add("account", Wallee.Client.ClientUtils.ParameterToString(account)); // header parameter
            localVarRequestOptions.Data = merchantApplicationDataDto;

            localVarRequestOptions.Operation = "MerchantApplicationsService.PostOnboardingMerchantApplications";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Post<MerchantApplicationDataDto>("/onboarding/merchant-applications",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostOnboardingMerchantApplications", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }


    }
}
