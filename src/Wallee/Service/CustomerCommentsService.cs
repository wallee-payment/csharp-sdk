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
    public interface ICustomerCommentsServiceSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete a customer comment
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void DeleteCustomersCustomerIdCommentsId(long customerId, long id, long space, int operationIndex = 0);

        /// <summary>
        /// Delete a customer comment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteCustomersCustomerIdCommentsIdWithHttpInfo(long customerId, long id, long space, int operationIndex = 0);
        /// <summary>
        /// List all customer comments
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="after">Set to an object&#39;s ID to retrieve the page of objects coming immediately after the named object. (optional)</param>
        /// <param name="before">Set to an object&#39;s ID to retrieve the page of objects coming immediately before the named object. (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="order">Specify to retrieve objects in chronological (ASC) or reverse chronological (DESC) order. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CustomerCommentListResponse</returns>
        CustomerCommentListResponse GetCustomersCustomerIdComments(long customerId, long space, long? after = default, long? before = default, List<string>? expand = default, int? limit = default, SortingOrder? order = default, int operationIndex = 0);

        /// <summary>
        /// List all customer comments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="after">Set to an object&#39;s ID to retrieve the page of objects coming immediately after the named object. (optional)</param>
        /// <param name="before">Set to an object&#39;s ID to retrieve the page of objects coming immediately before the named object. (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="order">Specify to retrieve objects in chronological (ASC) or reverse chronological (DESC) order. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CustomerCommentListResponse</returns>
        ApiResponse<CustomerCommentListResponse> GetCustomersCustomerIdCommentsWithHttpInfo(long customerId, long space, long? after = default, long? before = default, List<string>? expand = default, int? limit = default, SortingOrder? order = default, int operationIndex = 0);
        /// <summary>
        /// Retrieve a customer comment
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CustomerComment</returns>
        CustomerComment GetCustomersCustomerIdCommentsId(long customerId, long id, long space, List<string>? expand = default, int operationIndex = 0);

        /// <summary>
        /// Retrieve a customer comment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CustomerComment</returns>
        ApiResponse<CustomerComment> GetCustomersCustomerIdCommentsIdWithHttpInfo(long customerId, long id, long space, List<string>? expand = default, int operationIndex = 0);
        /// <summary>
        /// Search customer comments
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="offset">A cursor for pagination, specifies the number of objects to skip. (optional)</param>
        /// <param name="order">The fields and order to sort the objects by. (optional)</param>
        /// <param name="query">The search query to filter the objects by. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CustomerCommentSearchResponse</returns>
        CustomerCommentSearchResponse GetCustomersCustomerIdCommentsSearch(long customerId, long space, List<string>? expand = default, int? limit = default, int? offset = default, string? order = default, string? query = default, int operationIndex = 0);

        /// <summary>
        /// Search customer comments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="offset">A cursor for pagination, specifies the number of objects to skip. (optional)</param>
        /// <param name="order">The fields and order to sort the objects by. (optional)</param>
        /// <param name="query">The search query to filter the objects by. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CustomerCommentSearchResponse</returns>
        ApiResponse<CustomerCommentSearchResponse> GetCustomersCustomerIdCommentsSearchWithHttpInfo(long customerId, long space, List<string>? expand = default, int? limit = default, int? offset = default, string? order = default, string? query = default, int operationIndex = 0);
        /// <summary>
        /// Update a customer comment
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="customerCommentActive"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CustomerComment</returns>
        CustomerComment PatchCustomersCustomerIdCommentsId(long customerId, long id, long space, CustomerCommentActive customerCommentActive, List<string>? expand = default, int operationIndex = 0);

        /// <summary>
        /// Update a customer comment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="customerCommentActive"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CustomerComment</returns>
        ApiResponse<CustomerComment> PatchCustomersCustomerIdCommentsIdWithHttpInfo(long customerId, long id, long space, CustomerCommentActive customerCommentActive, List<string>? expand = default, int operationIndex = 0);
        /// <summary>
        /// Create a customer comment
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="customerCommentCreate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CustomerComment</returns>
        CustomerComment PostCustomersCustomerIdComments(long customerId, long space, CustomerCommentCreate customerCommentCreate, List<string>? expand = default, int operationIndex = 0);

        /// <summary>
        /// Create a customer comment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="customerCommentCreate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CustomerComment</returns>
        ApiResponse<CustomerComment> PostCustomersCustomerIdCommentsWithHttpInfo(long customerId, long space, CustomerCommentCreate customerCommentCreate, List<string>? expand = default, int operationIndex = 0);
        /// <summary>
        /// Pin a comment to the top
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void PostCustomersCustomerIdCommentsIdPin(long customerId, long id, long space, int operationIndex = 0);

        /// <summary>
        /// Pin a comment to the top
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostCustomersCustomerIdCommentsIdPinWithHttpInfo(long customerId, long id, long space, int operationIndex = 0);
        /// <summary>
        /// Remove a pinned comment from the top
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void PostCustomersCustomerIdCommentsIdUnpin(long customerId, long id, long space, int operationIndex = 0);

        /// <summary>
        /// Remove a pinned comment from the top
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostCustomersCustomerIdCommentsIdUnpinWithHttpInfo(long customerId, long id, long space, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICustomerCommentsService : ICustomerCommentsServiceSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CustomerCommentsService : ICustomerCommentsService
    {

        private Wallee.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerCommentsService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CustomerCommentsService(Wallee.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            this.Configuration = configuration;
            this.Client = new Wallee.Client.ApiClient(this.Configuration);
            ExceptionFactory = Wallee.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerCommentsService"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public CustomerCommentsService(Wallee.Client.ISynchronousClient client, Wallee.Client.IReadableConfiguration configuration)
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
        /// Delete a customer comment 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void DeleteCustomersCustomerIdCommentsId(long customerId, long id, long space, int operationIndex = 0)
        {
            DeleteCustomersCustomerIdCommentsIdWithHttpInfo(customerId, id, space);
        }

        /// <summary>
        /// Delete a customer comment 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Wallee.Client.ApiResponse<Object> DeleteCustomersCustomerIdCommentsIdWithHttpInfo(long customerId, long id, long space, int operationIndex = 0)
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

            localVarRequestOptions.PathParameters.Add("customerId", Wallee.Client.ClientUtils.ParameterToString(customerId)); // path parameter
            localVarRequestOptions.PathParameters.Add("id", Wallee.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("Space", Wallee.Client.ClientUtils.ParameterToString(space)); // header parameter

            localVarRequestOptions.Operation = "CustomerCommentsService.DeleteCustomersCustomerIdCommentsId";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/customers/{customerId}/comments/{id}",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteCustomersCustomerIdCommentsId", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// List all customer comments 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="after">Set to an object&#39;s ID to retrieve the page of objects coming immediately after the named object. (optional)</param>
        /// <param name="before">Set to an object&#39;s ID to retrieve the page of objects coming immediately before the named object. (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="order">Specify to retrieve objects in chronological (ASC) or reverse chronological (DESC) order. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CustomerCommentListResponse</returns>
        public CustomerCommentListResponse GetCustomersCustomerIdComments(long customerId, long space, long? after = default, long? before = default, List<string>? expand = default, int? limit = default, SortingOrder? order = default, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<CustomerCommentListResponse> localVarResponse = GetCustomersCustomerIdCommentsWithHttpInfo(customerId, space, after, before, expand, limit, order);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List all customer comments 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="after">Set to an object&#39;s ID to retrieve the page of objects coming immediately after the named object. (optional)</param>
        /// <param name="before">Set to an object&#39;s ID to retrieve the page of objects coming immediately before the named object. (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="order">Specify to retrieve objects in chronological (ASC) or reverse chronological (DESC) order. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CustomerCommentListResponse</returns>
        public Wallee.Client.ApiResponse<CustomerCommentListResponse> GetCustomersCustomerIdCommentsWithHttpInfo(long customerId, long space, long? after = default, long? before = default, List<string>? expand = default, int? limit = default, SortingOrder? order = default, int operationIndex = 0)
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

            localVarRequestOptions.PathParameters.Add("customerId", Wallee.Client.ClientUtils.ParameterToString(customerId)); // path parameter
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
            localVarRequestOptions.HeaderParameters.Add("Space", Wallee.Client.ClientUtils.ParameterToString(space)); // header parameter

            localVarRequestOptions.Operation = "CustomerCommentsService.GetCustomersCustomerIdComments";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Get<CustomerCommentListResponse>("/customers/{customerId}/comments",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCustomersCustomerIdComments", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Retrieve a customer comment 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CustomerComment</returns>
        public CustomerComment GetCustomersCustomerIdCommentsId(long customerId, long id, long space, List<string>? expand = default, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<CustomerComment> localVarResponse = GetCustomersCustomerIdCommentsIdWithHttpInfo(customerId, id, space, expand);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a customer comment 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CustomerComment</returns>
        public Wallee.Client.ApiResponse<CustomerComment> GetCustomersCustomerIdCommentsIdWithHttpInfo(long customerId, long id, long space, List<string>? expand = default, int operationIndex = 0)
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

            localVarRequestOptions.PathParameters.Add("customerId", Wallee.Client.ClientUtils.ParameterToString(customerId)); // path parameter
            localVarRequestOptions.PathParameters.Add("id", Wallee.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("multi", "expand", expand));
            }
            localVarRequestOptions.HeaderParameters.Add("Space", Wallee.Client.ClientUtils.ParameterToString(space)); // header parameter

            localVarRequestOptions.Operation = "CustomerCommentsService.GetCustomersCustomerIdCommentsId";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Get<CustomerComment>("/customers/{customerId}/comments/{id}",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCustomersCustomerIdCommentsId", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Search customer comments 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="offset">A cursor for pagination, specifies the number of objects to skip. (optional)</param>
        /// <param name="order">The fields and order to sort the objects by. (optional)</param>
        /// <param name="query">The search query to filter the objects by. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CustomerCommentSearchResponse</returns>
        public CustomerCommentSearchResponse GetCustomersCustomerIdCommentsSearch(long customerId, long space, List<string>? expand = default, int? limit = default, int? offset = default, string? order = default, string? query = default, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<CustomerCommentSearchResponse> localVarResponse = GetCustomersCustomerIdCommentsSearchWithHttpInfo(customerId, space, expand, limit, offset, order, query);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Search customer comments 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="offset">A cursor for pagination, specifies the number of objects to skip. (optional)</param>
        /// <param name="order">The fields and order to sort the objects by. (optional)</param>
        /// <param name="query">The search query to filter the objects by. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CustomerCommentSearchResponse</returns>
        public Wallee.Client.ApiResponse<CustomerCommentSearchResponse> GetCustomersCustomerIdCommentsSearchWithHttpInfo(long customerId, long space, List<string>? expand = default, int? limit = default, int? offset = default, string? order = default, string? query = default, int operationIndex = 0)
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

            localVarRequestOptions.PathParameters.Add("customerId", Wallee.Client.ClientUtils.ParameterToString(customerId)); // path parameter
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
            localVarRequestOptions.HeaderParameters.Add("Space", Wallee.Client.ClientUtils.ParameterToString(space)); // header parameter

            localVarRequestOptions.Operation = "CustomerCommentsService.GetCustomersCustomerIdCommentsSearch";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Get<CustomerCommentSearchResponse>("/customers/{customerId}/comments/search",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCustomersCustomerIdCommentsSearch", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Update a customer comment 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="customerCommentActive"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CustomerComment</returns>
        public CustomerComment PatchCustomersCustomerIdCommentsId(long customerId, long id, long space, CustomerCommentActive customerCommentActive, List<string>? expand = default, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<CustomerComment> localVarResponse = PatchCustomersCustomerIdCommentsIdWithHttpInfo(customerId, id, space, customerCommentActive, expand);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a customer comment 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="customerCommentActive"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CustomerComment</returns>
        public Wallee.Client.ApiResponse<CustomerComment> PatchCustomersCustomerIdCommentsIdWithHttpInfo(long customerId, long id, long space, CustomerCommentActive customerCommentActive, List<string>? expand = default, int operationIndex = 0)
        {
            // verify the required parameter 'customerCommentActive' is set
            if (customerCommentActive == null)
            {
                throw new Wallee.Client.ApiException(400, "Missing required parameter 'customerCommentActive' when calling CustomerCommentsService->PatchCustomersCustomerIdCommentsId");
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

            localVarRequestOptions.PathParameters.Add("customerId", Wallee.Client.ClientUtils.ParameterToString(customerId)); // path parameter
            localVarRequestOptions.PathParameters.Add("id", Wallee.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("multi", "expand", expand));
            }
            localVarRequestOptions.HeaderParameters.Add("Space", Wallee.Client.ClientUtils.ParameterToString(space)); // header parameter
            localVarRequestOptions.Data = customerCommentActive;

            localVarRequestOptions.Operation = "CustomerCommentsService.PatchCustomersCustomerIdCommentsId";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Patch<CustomerComment>("/customers/{customerId}/comments/{id}",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PatchCustomersCustomerIdCommentsId", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Create a customer comment 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="customerCommentCreate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CustomerComment</returns>
        public CustomerComment PostCustomersCustomerIdComments(long customerId, long space, CustomerCommentCreate customerCommentCreate, List<string>? expand = default, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<CustomerComment> localVarResponse = PostCustomersCustomerIdCommentsWithHttpInfo(customerId, space, customerCommentCreate, expand);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a customer comment 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="customerCommentCreate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CustomerComment</returns>
        public Wallee.Client.ApiResponse<CustomerComment> PostCustomersCustomerIdCommentsWithHttpInfo(long customerId, long space, CustomerCommentCreate customerCommentCreate, List<string>? expand = default, int operationIndex = 0)
        {
            // verify the required parameter 'customerCommentCreate' is set
            if (customerCommentCreate == null)
            {
                throw new Wallee.Client.ApiException(400, "Missing required parameter 'customerCommentCreate' when calling CustomerCommentsService->PostCustomersCustomerIdComments");
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

            localVarRequestOptions.PathParameters.Add("customerId", Wallee.Client.ClientUtils.ParameterToString(customerId)); // path parameter
            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("multi", "expand", expand));
            }
            localVarRequestOptions.HeaderParameters.Add("Space", Wallee.Client.ClientUtils.ParameterToString(space)); // header parameter
            localVarRequestOptions.Data = customerCommentCreate;

            localVarRequestOptions.Operation = "CustomerCommentsService.PostCustomersCustomerIdComments";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Post<CustomerComment>("/customers/{customerId}/comments",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostCustomersCustomerIdComments", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Pin a comment to the top 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void PostCustomersCustomerIdCommentsIdPin(long customerId, long id, long space, int operationIndex = 0)
        {
            PostCustomersCustomerIdCommentsIdPinWithHttpInfo(customerId, id, space);
        }

        /// <summary>
        /// Pin a comment to the top 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Wallee.Client.ApiResponse<Object> PostCustomersCustomerIdCommentsIdPinWithHttpInfo(long customerId, long id, long space, int operationIndex = 0)
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

            localVarRequestOptions.PathParameters.Add("customerId", Wallee.Client.ClientUtils.ParameterToString(customerId)); // path parameter
            localVarRequestOptions.PathParameters.Add("id", Wallee.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("Space", Wallee.Client.ClientUtils.ParameterToString(space)); // header parameter

            localVarRequestOptions.Operation = "CustomerCommentsService.PostCustomersCustomerIdCommentsIdPin";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/customers/{customerId}/comments/{id}/pin",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostCustomersCustomerIdCommentsIdPin", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Remove a pinned comment from the top 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void PostCustomersCustomerIdCommentsIdUnpin(long customerId, long id, long space, int operationIndex = 0)
        {
            PostCustomersCustomerIdCommentsIdUnpinWithHttpInfo(customerId, id, space);
        }

        /// <summary>
        /// Remove a pinned comment from the top 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customerId"></param>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Wallee.Client.ApiResponse<Object> PostCustomersCustomerIdCommentsIdUnpinWithHttpInfo(long customerId, long id, long space, int operationIndex = 0)
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

            localVarRequestOptions.PathParameters.Add("customerId", Wallee.Client.ClientUtils.ParameterToString(customerId)); // path parameter
            localVarRequestOptions.PathParameters.Add("id", Wallee.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("Space", Wallee.Client.ClientUtils.ParameterToString(space)); // header parameter

            localVarRequestOptions.Operation = "CustomerCommentsService.PostCustomersCustomerIdCommentsIdUnpin";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/customers/{customerId}/comments/{id}/unpin",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostCustomersCustomerIdCommentsIdUnpin", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }


    }
}
