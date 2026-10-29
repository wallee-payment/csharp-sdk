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
    public interface IOAuthClientsServiceSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Deactivate a client secret
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="id"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void DeleteOauth2ClientsClientIdSecretsId(long clientId, long id, int operationIndex = 0);

        /// <summary>
        /// Deactivate a client secret
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="id"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteOauth2ClientsClientIdSecretsIdWithHttpInfo(long clientId, long id, int operationIndex = 0);
        /// <summary>
        /// Delete a OAuth Client
        /// </summary>
        /// <remarks>
        /// Permanently deletes a OAuth Client. It cannot be undone.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void DeleteOauth2ClientsId(long id, int operationIndex = 0);

        /// <summary>
        /// Delete a OAuth Client
        /// </summary>
        /// <remarks>
        /// Permanently deletes a OAuth Client. It cannot be undone.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteOauth2ClientsIdWithHttpInfo(long id, int operationIndex = 0);
        /// <summary>
        /// List all OAuth Clients
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="after">Set to an object&#39;s ID to retrieve the page of objects coming immediately after the named object. (optional)</param>
        /// <param name="before">Set to an object&#39;s ID to retrieve the page of objects coming immediately before the named object. (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="order">Specify to retrieve objects in chronological (ASC) or reverse chronological (DESC) order. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>OAuthClientListResponse</returns>
        OAuthClientListResponse GetOauth2Clients(long? after = default, long? before = default, List<string>? expand = default, int? limit = default, SortingOrder? order = default, int operationIndex = 0);

        /// <summary>
        /// List all OAuth Clients
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="after">Set to an object&#39;s ID to retrieve the page of objects coming immediately after the named object. (optional)</param>
        /// <param name="before">Set to an object&#39;s ID to retrieve the page of objects coming immediately before the named object. (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="order">Specify to retrieve objects in chronological (ASC) or reverse chronological (DESC) order. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of OAuthClientListResponse</returns>
        ApiResponse<OAuthClientListResponse> GetOauth2ClientsWithHttpInfo(long? after = default, long? before = default, List<string>? expand = default, int? limit = default, SortingOrder? order = default, int operationIndex = 0);
        /// <summary>
        /// Retrieve an OAuth Client
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ExtendedRestOAuthClient</returns>
        ExtendedRestOAuthClient GetOauth2ClientsId(long id, List<string>? expand = default, int operationIndex = 0);

        /// <summary>
        /// Retrieve an OAuth Client
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ExtendedRestOAuthClient</returns>
        ApiResponse<ExtendedRestOAuthClient> GetOauth2ClientsIdWithHttpInfo(long id, List<string>? expand = default, int operationIndex = 0);
        /// <summary>
        /// Search OAuth Clients
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="offset">A cursor for pagination, specifies the number of objects to skip. (optional)</param>
        /// <param name="order">The fields and order to sort the objects by. (optional)</param>
        /// <param name="query">The search query to filter the objects by. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>OAuthClientSearchResponse</returns>
        OAuthClientSearchResponse GetOauth2ClientsSearch(List<string>? expand = default, int? limit = default, int? offset = default, string? order = default, string? query = default, int operationIndex = 0);

        /// <summary>
        /// Search OAuth Clients
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="offset">A cursor for pagination, specifies the number of objects to skip. (optional)</param>
        /// <param name="order">The fields and order to sort the objects by. (optional)</param>
        /// <param name="query">The search query to filter the objects by. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of OAuthClientSearchResponse</returns>
        ApiResponse<OAuthClientSearchResponse> GetOauth2ClientsSearchWithHttpInfo(List<string>? expand = default, int? limit = default, int? offset = default, string? order = default, string? query = default, int operationIndex = 0);
        /// <summary>
        /// Update a OAuth Client
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="oAuthClientUpdate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>OAuthClient</returns>
        OAuthClient PatchOauth2ClientsId(long id, OAuthClientUpdate oAuthClientUpdate, List<string>? expand = default, int operationIndex = 0);

        /// <summary>
        /// Update a OAuth Client
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="oAuthClientUpdate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of OAuthClient</returns>
        ApiResponse<OAuthClient> PatchOauth2ClientsIdWithHttpInfo(long id, OAuthClientUpdate oAuthClientUpdate, List<string>? expand = default, int operationIndex = 0);
        /// <summary>
        /// Create a OAuth Client
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oAuthClientCreate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>OAuthClient</returns>
        OAuthClient PostOauth2Clients(OAuthClientCreate oAuthClientCreate, List<string>? expand = default, int operationIndex = 0);

        /// <summary>
        /// Create a OAuth Client
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oAuthClientCreate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of OAuthClient</returns>
        ApiResponse<OAuthClient> PostOauth2ClientsWithHttpInfo(OAuthClientCreate oAuthClientCreate, List<string>? expand = default, int operationIndex = 0);
        /// <summary>
        /// Generate a new client secret
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>RestOAuthClientSecret</returns>
        RestOAuthClientSecret PostOauth2ClientsClientIdSecrets(long clientId, List<string>? expand = default, int operationIndex = 0);

        /// <summary>
        /// Generate a new client secret
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of RestOAuthClientSecret</returns>
        ApiResponse<RestOAuthClientSecret> PostOauth2ClientsClientIdSecretsWithHttpInfo(long clientId, List<string>? expand = default, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOAuthClientsService : IOAuthClientsServiceSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class OAuthClientsService : IOAuthClientsService
    {

        private Wallee.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthClientsService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OAuthClientsService(Wallee.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            this.Configuration = configuration;
            this.Client = new Wallee.Client.ApiClient(this.Configuration);
            ExceptionFactory = Wallee.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthClientsService"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public OAuthClientsService(Wallee.Client.ISynchronousClient client, Wallee.Client.IReadableConfiguration configuration)
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
        /// Deactivate a client secret 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="id"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void DeleteOauth2ClientsClientIdSecretsId(long clientId, long id, int operationIndex = 0)
        {
            DeleteOauth2ClientsClientIdSecretsIdWithHttpInfo(clientId, id);
        }

        /// <summary>
        /// Deactivate a client secret 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="id"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Wallee.Client.ApiResponse<Object> DeleteOauth2ClientsClientIdSecretsIdWithHttpInfo(long clientId, long id, int operationIndex = 0)
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

            localVarRequestOptions.PathParameters.Add("clientId", Wallee.Client.ClientUtils.ParameterToString(clientId)); // path parameter
            localVarRequestOptions.PathParameters.Add("id", Wallee.Client.ClientUtils.ParameterToString(id)); // path parameter

            localVarRequestOptions.Operation = "OAuthClientsService.DeleteOauth2ClientsClientIdSecretsId";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/oauth2/clients/{clientId}/secrets/{id}",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteOauth2ClientsClientIdSecretsId", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Delete a OAuth Client Permanently deletes a OAuth Client. It cannot be undone.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void DeleteOauth2ClientsId(long id, int operationIndex = 0)
        {
            DeleteOauth2ClientsIdWithHttpInfo(id);
        }

        /// <summary>
        /// Delete a OAuth Client Permanently deletes a OAuth Client. It cannot be undone.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Wallee.Client.ApiResponse<Object> DeleteOauth2ClientsIdWithHttpInfo(long id, int operationIndex = 0)
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

            localVarRequestOptions.Operation = "OAuthClientsService.DeleteOauth2ClientsId";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/oauth2/clients/{id}",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteOauth2ClientsId", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// List all OAuth Clients 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="after">Set to an object&#39;s ID to retrieve the page of objects coming immediately after the named object. (optional)</param>
        /// <param name="before">Set to an object&#39;s ID to retrieve the page of objects coming immediately before the named object. (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="order">Specify to retrieve objects in chronological (ASC) or reverse chronological (DESC) order. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>OAuthClientListResponse</returns>
        public OAuthClientListResponse GetOauth2Clients(long? after = default, long? before = default, List<string>? expand = default, int? limit = default, SortingOrder? order = default, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<OAuthClientListResponse> localVarResponse = GetOauth2ClientsWithHttpInfo(after, before, expand, limit, order);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List all OAuth Clients 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="after">Set to an object&#39;s ID to retrieve the page of objects coming immediately after the named object. (optional)</param>
        /// <param name="before">Set to an object&#39;s ID to retrieve the page of objects coming immediately before the named object. (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="order">Specify to retrieve objects in chronological (ASC) or reverse chronological (DESC) order. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of OAuthClientListResponse</returns>
        public Wallee.Client.ApiResponse<OAuthClientListResponse> GetOauth2ClientsWithHttpInfo(long? after = default, long? before = default, List<string>? expand = default, int? limit = default, SortingOrder? order = default, int operationIndex = 0)
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

            localVarRequestOptions.Operation = "OAuthClientsService.GetOauth2Clients";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Get<OAuthClientListResponse>("/oauth2/clients",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetOauth2Clients", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Retrieve an OAuth Client 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ExtendedRestOAuthClient</returns>
        public ExtendedRestOAuthClient GetOauth2ClientsId(long id, List<string>? expand = default, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<ExtendedRestOAuthClient> localVarResponse = GetOauth2ClientsIdWithHttpInfo(id, expand);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve an OAuth Client 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ExtendedRestOAuthClient</returns>
        public Wallee.Client.ApiResponse<ExtendedRestOAuthClient> GetOauth2ClientsIdWithHttpInfo(long id, List<string>? expand = default, int operationIndex = 0)
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

            localVarRequestOptions.Operation = "OAuthClientsService.GetOauth2ClientsId";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Get<ExtendedRestOAuthClient>("/oauth2/clients/{id}",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetOauth2ClientsId", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Search OAuth Clients 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="offset">A cursor for pagination, specifies the number of objects to skip. (optional)</param>
        /// <param name="order">The fields and order to sort the objects by. (optional)</param>
        /// <param name="query">The search query to filter the objects by. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>OAuthClientSearchResponse</returns>
        public OAuthClientSearchResponse GetOauth2ClientsSearch(List<string>? expand = default, int? limit = default, int? offset = default, string? order = default, string? query = default, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<OAuthClientSearchResponse> localVarResponse = GetOauth2ClientsSearchWithHttpInfo(expand, limit, offset, order, query);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Search OAuth Clients 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="offset">A cursor for pagination, specifies the number of objects to skip. (optional)</param>
        /// <param name="order">The fields and order to sort the objects by. (optional)</param>
        /// <param name="query">The search query to filter the objects by. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of OAuthClientSearchResponse</returns>
        public Wallee.Client.ApiResponse<OAuthClientSearchResponse> GetOauth2ClientsSearchWithHttpInfo(List<string>? expand = default, int? limit = default, int? offset = default, string? order = default, string? query = default, int operationIndex = 0)
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

            localVarRequestOptions.Operation = "OAuthClientsService.GetOauth2ClientsSearch";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Get<OAuthClientSearchResponse>("/oauth2/clients/search",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetOauth2ClientsSearch", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Update a OAuth Client 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="oAuthClientUpdate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>OAuthClient</returns>
        public OAuthClient PatchOauth2ClientsId(long id, OAuthClientUpdate oAuthClientUpdate, List<string>? expand = default, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<OAuthClient> localVarResponse = PatchOauth2ClientsIdWithHttpInfo(id, oAuthClientUpdate, expand);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a OAuth Client 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="oAuthClientUpdate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of OAuthClient</returns>
        public Wallee.Client.ApiResponse<OAuthClient> PatchOauth2ClientsIdWithHttpInfo(long id, OAuthClientUpdate oAuthClientUpdate, List<string>? expand = default, int operationIndex = 0)
        {
            // verify the required parameter 'oAuthClientUpdate' is set
            if (oAuthClientUpdate == null)
            {
                throw new Wallee.Client.ApiException(400, "Missing required parameter 'oAuthClientUpdate' when calling OAuthClientsService->PatchOauth2ClientsId");
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
            localVarRequestOptions.Data = oAuthClientUpdate;

            localVarRequestOptions.Operation = "OAuthClientsService.PatchOauth2ClientsId";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Patch<OAuthClient>("/oauth2/clients/{id}",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PatchOauth2ClientsId", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Create a OAuth Client 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oAuthClientCreate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>OAuthClient</returns>
        public OAuthClient PostOauth2Clients(OAuthClientCreate oAuthClientCreate, List<string>? expand = default, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<OAuthClient> localVarResponse = PostOauth2ClientsWithHttpInfo(oAuthClientCreate, expand);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a OAuth Client 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oAuthClientCreate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of OAuthClient</returns>
        public Wallee.Client.ApiResponse<OAuthClient> PostOauth2ClientsWithHttpInfo(OAuthClientCreate oAuthClientCreate, List<string>? expand = default, int operationIndex = 0)
        {
            // verify the required parameter 'oAuthClientCreate' is set
            if (oAuthClientCreate == null)
            {
                throw new Wallee.Client.ApiException(400, "Missing required parameter 'oAuthClientCreate' when calling OAuthClientsService->PostOauth2Clients");
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
            localVarRequestOptions.Data = oAuthClientCreate;

            localVarRequestOptions.Operation = "OAuthClientsService.PostOauth2Clients";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Post<OAuthClient>("/oauth2/clients",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostOauth2Clients", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Generate a new client secret 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>RestOAuthClientSecret</returns>
        public RestOAuthClientSecret PostOauth2ClientsClientIdSecrets(long clientId, List<string>? expand = default, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<RestOAuthClientSecret> localVarResponse = PostOauth2ClientsClientIdSecretsWithHttpInfo(clientId, expand);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Generate a new client secret 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of RestOAuthClientSecret</returns>
        public Wallee.Client.ApiResponse<RestOAuthClientSecret> PostOauth2ClientsClientIdSecretsWithHttpInfo(long clientId, List<string>? expand = default, int operationIndex = 0)
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

            localVarRequestOptions.PathParameters.Add("clientId", Wallee.Client.ClientUtils.ParameterToString(clientId)); // path parameter
            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("multi", "expand", expand));
            }

            localVarRequestOptions.Operation = "OAuthClientsService.PostOauth2ClientsClientIdSecrets";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Post<RestOAuthClientSecret>("/oauth2/clients/{clientId}/secrets",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostOauth2ClientsClientIdSecrets", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }


    }
}
