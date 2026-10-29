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
    public interface IJoinPartnershipServiceSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete a join partnership
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void DeleteJoinProgramPartnershipsId(long id, long account, int operationIndex = 0);

        /// <summary>
        /// Delete a join partnership
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteJoinProgramPartnershipsIdWithHttpInfo(long id, long account, int operationIndex = 0);
        /// <summary>
        /// List all join partnerships
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="after">Set to an object&#39;s ID to retrieve the page of objects coming immediately after the named object. (optional)</param>
        /// <param name="before">Set to an object&#39;s ID to retrieve the page of objects coming immediately before the named object. (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="order">Specify to retrieve objects in chronological (ASC) or reverse chronological (DESC) order. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>WalleejoinPartnershipResponseDtoListResponse</returns>
        WalleejoinPartnershipResponseDtoListResponse GetJoinProgramPartnerships(long account, long? after = default, long? before = default, List<string>? expand = default, int? limit = default, SortingOrder? order = default, int operationIndex = 0);

        /// <summary>
        /// List all join partnerships
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="after">Set to an object&#39;s ID to retrieve the page of objects coming immediately after the named object. (optional)</param>
        /// <param name="before">Set to an object&#39;s ID to retrieve the page of objects coming immediately before the named object. (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="order">Specify to retrieve objects in chronological (ASC) or reverse chronological (DESC) order. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of WalleejoinPartnershipResponseDtoListResponse</returns>
        ApiResponse<WalleejoinPartnershipResponseDtoListResponse> GetJoinProgramPartnershipsWithHttpInfo(long account, long? after = default, long? before = default, List<string>? expand = default, int? limit = default, SortingOrder? order = default, int operationIndex = 0);
        /// <summary>
        /// Retrieve a join partnership
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>WalleejoinPartnershipResponseDto</returns>
        WalleejoinPartnershipResponseDto GetJoinProgramPartnershipsId(long id, long account, List<string>? expand = default, int operationIndex = 0);

        /// <summary>
        /// Retrieve a join partnership
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of WalleejoinPartnershipResponseDto</returns>
        ApiResponse<WalleejoinPartnershipResponseDto> GetJoinProgramPartnershipsIdWithHttpInfo(long id, long account, List<string>? expand = default, int operationIndex = 0);
        /// <summary>
        /// Search join partnerships
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="offset">A cursor for pagination, specifies the number of objects to skip. (optional)</param>
        /// <param name="order">The fields and order to sort the objects by. (optional)</param>
        /// <param name="query">The search query to filter the objects by. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>WalleejoinPartnershipResponseDtoSearchResponse</returns>
        WalleejoinPartnershipResponseDtoSearchResponse GetJoinProgramPartnershipsSearch(long account, List<string>? expand = default, int? limit = default, int? offset = default, string? order = default, string? query = default, int operationIndex = 0);

        /// <summary>
        /// Search join partnerships
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="offset">A cursor for pagination, specifies the number of objects to skip. (optional)</param>
        /// <param name="order">The fields and order to sort the objects by. (optional)</param>
        /// <param name="query">The search query to filter the objects by. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of WalleejoinPartnershipResponseDtoSearchResponse</returns>
        ApiResponse<WalleejoinPartnershipResponseDtoSearchResponse> GetJoinProgramPartnershipsSearchWithHttpInfo(long account, List<string>? expand = default, int? limit = default, int? offset = default, string? order = default, string? query = default, int operationIndex = 0);
        /// <summary>
        /// Create a join account partnership
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="walleejoinCreatePartnershipApiRequestDto"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Object</returns>
        Object PostJoinProgramPartnershipsCreateAffiliate(long account, WalleejoinCreatePartnershipApiRequestDto walleejoinCreatePartnershipApiRequestDto, int operationIndex = 0);

        /// <summary>
        /// Create a join account partnership
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="walleejoinCreatePartnershipApiRequestDto"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> PostJoinProgramPartnershipsCreateAffiliateWithHttpInfo(long account, WalleejoinCreatePartnershipApiRequestDto walleejoinCreatePartnershipApiRequestDto, int operationIndex = 0);
        /// <summary>
        /// Create a join platform partnership
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="walleejoinCreatePartnershipApiRequestDto"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>WalleejoinPartnershipResponseDto</returns>
        WalleejoinPartnershipResponseDto PostJoinProgramPartnershipsCreateIsv(long account, WalleejoinCreatePartnershipApiRequestDto walleejoinCreatePartnershipApiRequestDto, List<string>? expand = default, int operationIndex = 0);

        /// <summary>
        /// Create a join platform partnership
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="walleejoinCreatePartnershipApiRequestDto"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of WalleejoinPartnershipResponseDto</returns>
        ApiResponse<WalleejoinPartnershipResponseDto> PostJoinProgramPartnershipsCreateIsvWithHttpInfo(long account, WalleejoinCreatePartnershipApiRequestDto walleejoinCreatePartnershipApiRequestDto, List<string>? expand = default, int operationIndex = 0);
        /// <summary>
        /// Create a join partnership for an existing merchant
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="walleejoinPartnershipCreate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>WalleejoinPartnershipResponseDto</returns>
        WalleejoinPartnershipResponseDto PostJoinProgramPartnershipsCreateSimple(long account, WalleejoinPartnershipCreate walleejoinPartnershipCreate, List<string>? expand = default, int operationIndex = 0);

        /// <summary>
        /// Create a join partnership for an existing merchant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="walleejoinPartnershipCreate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of WalleejoinPartnershipResponseDto</returns>
        ApiResponse<WalleejoinPartnershipResponseDto> PostJoinProgramPartnershipsCreateSimpleWithHttpInfo(long account, WalleejoinPartnershipCreate walleejoinPartnershipCreate, List<string>? expand = default, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IJoinPartnershipService : IJoinPartnershipServiceSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class JoinPartnershipService : IJoinPartnershipService
    {

        private Wallee.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="JoinPartnershipService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public JoinPartnershipService(Wallee.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            this.Configuration = configuration;
            this.Client = new Wallee.Client.ApiClient(this.Configuration);
            ExceptionFactory = Wallee.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JoinPartnershipService"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public JoinPartnershipService(Wallee.Client.ISynchronousClient client, Wallee.Client.IReadableConfiguration configuration)
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
        /// Delete a join partnership 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void DeleteJoinProgramPartnershipsId(long id, long account, int operationIndex = 0)
        {
            DeleteJoinProgramPartnershipsIdWithHttpInfo(id, account);
        }

        /// <summary>
        /// Delete a join partnership 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Wallee.Client.ApiResponse<Object> DeleteJoinProgramPartnershipsIdWithHttpInfo(long id, long account, int operationIndex = 0)
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
            localVarRequestOptions.HeaderParameters.Add("account", Wallee.Client.ClientUtils.ParameterToString(account)); // header parameter

            localVarRequestOptions.Operation = "JoinPartnershipService.DeleteJoinProgramPartnershipsId";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/join-program/partnerships/{id}",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteJoinProgramPartnershipsId", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// List all join partnerships 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="after">Set to an object&#39;s ID to retrieve the page of objects coming immediately after the named object. (optional)</param>
        /// <param name="before">Set to an object&#39;s ID to retrieve the page of objects coming immediately before the named object. (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="order">Specify to retrieve objects in chronological (ASC) or reverse chronological (DESC) order. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>WalleejoinPartnershipResponseDtoListResponse</returns>
        public WalleejoinPartnershipResponseDtoListResponse GetJoinProgramPartnerships(long account, long? after = default, long? before = default, List<string>? expand = default, int? limit = default, SortingOrder? order = default, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<WalleejoinPartnershipResponseDtoListResponse> localVarResponse = GetJoinProgramPartnershipsWithHttpInfo(account, after, before, expand, limit, order);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List all join partnerships 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="after">Set to an object&#39;s ID to retrieve the page of objects coming immediately after the named object. (optional)</param>
        /// <param name="before">Set to an object&#39;s ID to retrieve the page of objects coming immediately before the named object. (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="order">Specify to retrieve objects in chronological (ASC) or reverse chronological (DESC) order. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of WalleejoinPartnershipResponseDtoListResponse</returns>
        public Wallee.Client.ApiResponse<WalleejoinPartnershipResponseDtoListResponse> GetJoinProgramPartnershipsWithHttpInfo(long account, long? after = default, long? before = default, List<string>? expand = default, int? limit = default, SortingOrder? order = default, int operationIndex = 0)
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

            if (after != null)
            {
                localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("", "after", after));
            }
            if (before != null)
            {
                localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("", "before", before));
            }
            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("multi", "expand", expand));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (order != null)
            {
                localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("", "order", order));
            }
            localVarRequestOptions.HeaderParameters.Add("account", Wallee.Client.ClientUtils.ParameterToString(account)); // header parameter

            localVarRequestOptions.Operation = "JoinPartnershipService.GetJoinProgramPartnerships";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Get<WalleejoinPartnershipResponseDtoListResponse>("/join-program/partnerships",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetJoinProgramPartnerships", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Retrieve a join partnership 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>WalleejoinPartnershipResponseDto</returns>
        public WalleejoinPartnershipResponseDto GetJoinProgramPartnershipsId(long id, long account, List<string>? expand = default, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<WalleejoinPartnershipResponseDto> localVarResponse = GetJoinProgramPartnershipsIdWithHttpInfo(id, account, expand);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a join partnership 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of WalleejoinPartnershipResponseDto</returns>
        public Wallee.Client.ApiResponse<WalleejoinPartnershipResponseDto> GetJoinProgramPartnershipsIdWithHttpInfo(long id, long account, List<string>? expand = default, int operationIndex = 0)
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

            localVarRequestOptions.Operation = "JoinPartnershipService.GetJoinProgramPartnershipsId";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Get<WalleejoinPartnershipResponseDto>("/join-program/partnerships/{id}",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetJoinProgramPartnershipsId", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Search join partnerships 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="offset">A cursor for pagination, specifies the number of objects to skip. (optional)</param>
        /// <param name="order">The fields and order to sort the objects by. (optional)</param>
        /// <param name="query">The search query to filter the objects by. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>WalleejoinPartnershipResponseDtoSearchResponse</returns>
        public WalleejoinPartnershipResponseDtoSearchResponse GetJoinProgramPartnershipsSearch(long account, List<string>? expand = default, int? limit = default, int? offset = default, string? order = default, string? query = default, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<WalleejoinPartnershipResponseDtoSearchResponse> localVarResponse = GetJoinProgramPartnershipsSearchWithHttpInfo(account, expand, limit, offset, order, query);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Search join partnerships 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="offset">A cursor for pagination, specifies the number of objects to skip. (optional)</param>
        /// <param name="order">The fields and order to sort the objects by. (optional)</param>
        /// <param name="query">The search query to filter the objects by. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of WalleejoinPartnershipResponseDtoSearchResponse</returns>
        public Wallee.Client.ApiResponse<WalleejoinPartnershipResponseDtoSearchResponse> GetJoinProgramPartnershipsSearchWithHttpInfo(long account, List<string>? expand = default, int? limit = default, int? offset = default, string? order = default, string? query = default, int operationIndex = 0)
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

            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("multi", "expand", expand));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (offset != null)
            {
                localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("", "offset", offset));
            }
            if (order != null)
            {
                localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("", "order", order));
            }
            if (query != null)
            {
                localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("", "query", query));
            }
            localVarRequestOptions.HeaderParameters.Add("account", Wallee.Client.ClientUtils.ParameterToString(account)); // header parameter

            localVarRequestOptions.Operation = "JoinPartnershipService.GetJoinProgramPartnershipsSearch";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Get<WalleejoinPartnershipResponseDtoSearchResponse>("/join-program/partnerships/search",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetJoinProgramPartnershipsSearch", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Create a join account partnership 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="walleejoinCreatePartnershipApiRequestDto"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Object</returns>
        public Object PostJoinProgramPartnershipsCreateAffiliate(long account, WalleejoinCreatePartnershipApiRequestDto walleejoinCreatePartnershipApiRequestDto, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<Object> localVarResponse = PostJoinProgramPartnershipsCreateAffiliateWithHttpInfo(account, walleejoinCreatePartnershipApiRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a join account partnership 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="walleejoinCreatePartnershipApiRequestDto"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object</returns>
        public Wallee.Client.ApiResponse<Object> PostJoinProgramPartnershipsCreateAffiliateWithHttpInfo(long account, WalleejoinCreatePartnershipApiRequestDto walleejoinCreatePartnershipApiRequestDto, int operationIndex = 0)
        {
            // verify the required parameter 'walleejoinCreatePartnershipApiRequestDto' is set
            if (walleejoinCreatePartnershipApiRequestDto == null)
            {
                throw new Wallee.Client.ApiException(400, "Missing required parameter 'walleejoinCreatePartnershipApiRequestDto' when calling JoinPartnershipService->PostJoinProgramPartnershipsCreateAffiliate");
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

            localVarRequestOptions.HeaderParameters.Add("account", Wallee.Client.ClientUtils.ParameterToString(account)); // header parameter
            localVarRequestOptions.Data = walleejoinCreatePartnershipApiRequestDto;

            localVarRequestOptions.Operation = "JoinPartnershipService.PostJoinProgramPartnershipsCreateAffiliate";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/join-program/partnerships/create-affiliate",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostJoinProgramPartnershipsCreateAffiliate", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Create a join platform partnership 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="walleejoinCreatePartnershipApiRequestDto"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>WalleejoinPartnershipResponseDto</returns>
        public WalleejoinPartnershipResponseDto PostJoinProgramPartnershipsCreateIsv(long account, WalleejoinCreatePartnershipApiRequestDto walleejoinCreatePartnershipApiRequestDto, List<string>? expand = default, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<WalleejoinPartnershipResponseDto> localVarResponse = PostJoinProgramPartnershipsCreateIsvWithHttpInfo(account, walleejoinCreatePartnershipApiRequestDto, expand);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a join platform partnership 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="walleejoinCreatePartnershipApiRequestDto"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of WalleejoinPartnershipResponseDto</returns>
        public Wallee.Client.ApiResponse<WalleejoinPartnershipResponseDto> PostJoinProgramPartnershipsCreateIsvWithHttpInfo(long account, WalleejoinCreatePartnershipApiRequestDto walleejoinCreatePartnershipApiRequestDto, List<string>? expand = default, int operationIndex = 0)
        {
            // verify the required parameter 'walleejoinCreatePartnershipApiRequestDto' is set
            if (walleejoinCreatePartnershipApiRequestDto == null)
            {
                throw new Wallee.Client.ApiException(400, "Missing required parameter 'walleejoinCreatePartnershipApiRequestDto' when calling JoinPartnershipService->PostJoinProgramPartnershipsCreateIsv");
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
            localVarRequestOptions.HeaderParameters.Add("account", Wallee.Client.ClientUtils.ParameterToString(account)); // header parameter
            localVarRequestOptions.Data = walleejoinCreatePartnershipApiRequestDto;

            localVarRequestOptions.Operation = "JoinPartnershipService.PostJoinProgramPartnershipsCreateIsv";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Post<WalleejoinPartnershipResponseDto>("/join-program/partnerships/create-isv",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostJoinProgramPartnershipsCreateIsv", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Create a join partnership for an existing merchant 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="walleejoinPartnershipCreate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>WalleejoinPartnershipResponseDto</returns>
        public WalleejoinPartnershipResponseDto PostJoinProgramPartnershipsCreateSimple(long account, WalleejoinPartnershipCreate walleejoinPartnershipCreate, List<string>? expand = default, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<WalleejoinPartnershipResponseDto> localVarResponse = PostJoinProgramPartnershipsCreateSimpleWithHttpInfo(account, walleejoinPartnershipCreate, expand);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a join partnership for an existing merchant 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="walleejoinPartnershipCreate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of WalleejoinPartnershipResponseDto</returns>
        public Wallee.Client.ApiResponse<WalleejoinPartnershipResponseDto> PostJoinProgramPartnershipsCreateSimpleWithHttpInfo(long account, WalleejoinPartnershipCreate walleejoinPartnershipCreate, List<string>? expand = default, int operationIndex = 0)
        {
            // verify the required parameter 'walleejoinPartnershipCreate' is set
            if (walleejoinPartnershipCreate == null)
            {
                throw new Wallee.Client.ApiException(400, "Missing required parameter 'walleejoinPartnershipCreate' when calling JoinPartnershipService->PostJoinProgramPartnershipsCreateSimple");
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
            localVarRequestOptions.HeaderParameters.Add("account", Wallee.Client.ClientUtils.ParameterToString(account)); // header parameter
            localVarRequestOptions.Data = walleejoinPartnershipCreate;

            localVarRequestOptions.Operation = "JoinPartnershipService.PostJoinProgramPartnershipsCreateSimple";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Post<WalleejoinPartnershipResponseDto>("/join-program/partnerships/create-simple",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostJoinProgramPartnershipsCreateSimple", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }


    }
}
