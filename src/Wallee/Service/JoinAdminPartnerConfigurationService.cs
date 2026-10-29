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
    public interface IJoinAdminPartnerConfigurationServiceSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete a join admin partner configuration
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void DeleteScopeJoinProgramPartnersConfigurationsId(long id, int operationIndex = 0);

        /// <summary>
        /// Delete a join admin partner configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteScopeJoinProgramPartnersConfigurationsIdWithHttpInfo(long id, int operationIndex = 0);
        /// <summary>
        /// Retrieve a join admin partner configuration
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>WalleejoinAdminPartnerConfigurationResponseDto</returns>
        WalleejoinAdminPartnerConfigurationResponseDto GetScopeJoinProgramPartnersConfigurationsId(long id, List<string>? expand = default, int operationIndex = 0);

        /// <summary>
        /// Retrieve a join admin partner configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of WalleejoinAdminPartnerConfigurationResponseDto</returns>
        ApiResponse<WalleejoinAdminPartnerConfigurationResponseDto> GetScopeJoinProgramPartnersConfigurationsIdWithHttpInfo(long id, List<string>? expand = default, int operationIndex = 0);
        /// <summary>
        /// Update a join admin partner configuration
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partnerAccountId"></param>
        /// <param name="walleejoinAdminPartnerConfigurationRequestDto"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>WalleejoinAdminPartnerConfigurationResponseDto</returns>
        WalleejoinAdminPartnerConfigurationResponseDto PatchScopeJoinProgramPartnersConfigurationsPartnerAccountId(long partnerAccountId, WalleejoinAdminPartnerConfigurationRequestDto walleejoinAdminPartnerConfigurationRequestDto, List<string>? expand = default, int operationIndex = 0);

        /// <summary>
        /// Update a join admin partner configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partnerAccountId"></param>
        /// <param name="walleejoinAdminPartnerConfigurationRequestDto"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of WalleejoinAdminPartnerConfigurationResponseDto</returns>
        ApiResponse<WalleejoinAdminPartnerConfigurationResponseDto> PatchScopeJoinProgramPartnersConfigurationsPartnerAccountIdWithHttpInfo(long partnerAccountId, WalleejoinAdminPartnerConfigurationRequestDto walleejoinAdminPartnerConfigurationRequestDto, List<string>? expand = default, int operationIndex = 0);
        /// <summary>
        /// Create a join admin partner configuration
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walleejoinAdminPartnerConfigurationRequestDto"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>WalleejoinAdminPartnerConfigurationResponseDto</returns>
        WalleejoinAdminPartnerConfigurationResponseDto PostScopeJoinProgramPartnersConfigurations(WalleejoinAdminPartnerConfigurationRequestDto walleejoinAdminPartnerConfigurationRequestDto, List<string>? expand = default, int operationIndex = 0);

        /// <summary>
        /// Create a join admin partner configuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walleejoinAdminPartnerConfigurationRequestDto"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of WalleejoinAdminPartnerConfigurationResponseDto</returns>
        ApiResponse<WalleejoinAdminPartnerConfigurationResponseDto> PostScopeJoinProgramPartnersConfigurationsWithHttpInfo(WalleejoinAdminPartnerConfigurationRequestDto walleejoinAdminPartnerConfigurationRequestDto, List<string>? expand = default, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IJoinAdminPartnerConfigurationService : IJoinAdminPartnerConfigurationServiceSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class JoinAdminPartnerConfigurationService : IJoinAdminPartnerConfigurationService
    {

        private Wallee.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="JoinAdminPartnerConfigurationService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public JoinAdminPartnerConfigurationService(Wallee.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            this.Configuration = configuration;
            this.Client = new Wallee.Client.ApiClient(this.Configuration);
            ExceptionFactory = Wallee.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JoinAdminPartnerConfigurationService"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public JoinAdminPartnerConfigurationService(Wallee.Client.ISynchronousClient client, Wallee.Client.IReadableConfiguration configuration)
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
        /// Delete a join admin partner configuration 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void DeleteScopeJoinProgramPartnersConfigurationsId(long id, int operationIndex = 0)
        {
            DeleteScopeJoinProgramPartnersConfigurationsIdWithHttpInfo(id);
        }

        /// <summary>
        /// Delete a join admin partner configuration 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Wallee.Client.ApiResponse<Object> DeleteScopeJoinProgramPartnersConfigurationsIdWithHttpInfo(long id, int operationIndex = 0)
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

            localVarRequestOptions.Operation = "JoinAdminPartnerConfigurationService.DeleteScopeJoinProgramPartnersConfigurationsId";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/scope/join-program/partners/configurations/{id}",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteScopeJoinProgramPartnersConfigurationsId", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Retrieve a join admin partner configuration 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>WalleejoinAdminPartnerConfigurationResponseDto</returns>
        public WalleejoinAdminPartnerConfigurationResponseDto GetScopeJoinProgramPartnersConfigurationsId(long id, List<string>? expand = default, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<WalleejoinAdminPartnerConfigurationResponseDto> localVarResponse = GetScopeJoinProgramPartnersConfigurationsIdWithHttpInfo(id, expand);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a join admin partner configuration 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of WalleejoinAdminPartnerConfigurationResponseDto</returns>
        public Wallee.Client.ApiResponse<WalleejoinAdminPartnerConfigurationResponseDto> GetScopeJoinProgramPartnersConfigurationsIdWithHttpInfo(long id, List<string>? expand = default, int operationIndex = 0)
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

            localVarRequestOptions.Operation = "JoinAdminPartnerConfigurationService.GetScopeJoinProgramPartnersConfigurationsId";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Get<WalleejoinAdminPartnerConfigurationResponseDto>("/scope/join-program/partners/configurations/{id}",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetScopeJoinProgramPartnersConfigurationsId", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Update a join admin partner configuration 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partnerAccountId"></param>
        /// <param name="walleejoinAdminPartnerConfigurationRequestDto"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>WalleejoinAdminPartnerConfigurationResponseDto</returns>
        public WalleejoinAdminPartnerConfigurationResponseDto PatchScopeJoinProgramPartnersConfigurationsPartnerAccountId(long partnerAccountId, WalleejoinAdminPartnerConfigurationRequestDto walleejoinAdminPartnerConfigurationRequestDto, List<string>? expand = default, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<WalleejoinAdminPartnerConfigurationResponseDto> localVarResponse = PatchScopeJoinProgramPartnersConfigurationsPartnerAccountIdWithHttpInfo(partnerAccountId, walleejoinAdminPartnerConfigurationRequestDto, expand);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a join admin partner configuration 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partnerAccountId"></param>
        /// <param name="walleejoinAdminPartnerConfigurationRequestDto"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of WalleejoinAdminPartnerConfigurationResponseDto</returns>
        public Wallee.Client.ApiResponse<WalleejoinAdminPartnerConfigurationResponseDto> PatchScopeJoinProgramPartnersConfigurationsPartnerAccountIdWithHttpInfo(long partnerAccountId, WalleejoinAdminPartnerConfigurationRequestDto walleejoinAdminPartnerConfigurationRequestDto, List<string>? expand = default, int operationIndex = 0)
        {
            // verify the required parameter 'walleejoinAdminPartnerConfigurationRequestDto' is set
            if (walleejoinAdminPartnerConfigurationRequestDto == null)
            {
                throw new Wallee.Client.ApiException(400, "Missing required parameter 'walleejoinAdminPartnerConfigurationRequestDto' when calling JoinAdminPartnerConfigurationService->PatchScopeJoinProgramPartnersConfigurationsPartnerAccountId");
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

            localVarRequestOptions.PathParameters.Add("partnerAccountId", Wallee.Client.ClientUtils.ParameterToString(partnerAccountId)); // path parameter
            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("multi", "expand", expand));
            }
            localVarRequestOptions.Data = walleejoinAdminPartnerConfigurationRequestDto;

            localVarRequestOptions.Operation = "JoinAdminPartnerConfigurationService.PatchScopeJoinProgramPartnersConfigurationsPartnerAccountId";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Patch<WalleejoinAdminPartnerConfigurationResponseDto>("/scope/join-program/partners/configurations/{partnerAccountId}",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PatchScopeJoinProgramPartnersConfigurationsPartnerAccountId", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Create a join admin partner configuration 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walleejoinAdminPartnerConfigurationRequestDto"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>WalleejoinAdminPartnerConfigurationResponseDto</returns>
        public WalleejoinAdminPartnerConfigurationResponseDto PostScopeJoinProgramPartnersConfigurations(WalleejoinAdminPartnerConfigurationRequestDto walleejoinAdminPartnerConfigurationRequestDto, List<string>? expand = default, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<WalleejoinAdminPartnerConfigurationResponseDto> localVarResponse = PostScopeJoinProgramPartnersConfigurationsWithHttpInfo(walleejoinAdminPartnerConfigurationRequestDto, expand);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a join admin partner configuration 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walleejoinAdminPartnerConfigurationRequestDto"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of WalleejoinAdminPartnerConfigurationResponseDto</returns>
        public Wallee.Client.ApiResponse<WalleejoinAdminPartnerConfigurationResponseDto> PostScopeJoinProgramPartnersConfigurationsWithHttpInfo(WalleejoinAdminPartnerConfigurationRequestDto walleejoinAdminPartnerConfigurationRequestDto, List<string>? expand = default, int operationIndex = 0)
        {
            // verify the required parameter 'walleejoinAdminPartnerConfigurationRequestDto' is set
            if (walleejoinAdminPartnerConfigurationRequestDto == null)
            {
                throw new Wallee.Client.ApiException(400, "Missing required parameter 'walleejoinAdminPartnerConfigurationRequestDto' when calling JoinAdminPartnerConfigurationService->PostScopeJoinProgramPartnersConfigurations");
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

            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("multi", "expand", expand));
            }
            localVarRequestOptions.Data = walleejoinAdminPartnerConfigurationRequestDto;

            localVarRequestOptions.Operation = "JoinAdminPartnerConfigurationService.PostScopeJoinProgramPartnersConfigurations";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Post<WalleejoinAdminPartnerConfigurationResponseDto>("/scope/join-program/partners/configurations",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostScopeJoinProgramPartnersConfigurations", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }


    }
}
