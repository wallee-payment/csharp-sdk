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
    public interface ISubscriptionProductService : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Count
        /// </summary>
        /// <remarks>
        /// Counts the number of items in the database as restricted by the given filter.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>long?</returns>
        long? Count (long? spaceId, EntityQueryFilter filter = null);

        /// <summary>
        /// Count
        /// </summary>
        /// <remarks>
        /// Counts the number of items in the database as restricted by the given filter.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>ApiResponse of long?</returns>
        ApiResponse<long?> CountWithHttpInfo (long? spaceId, EntityQueryFilter filter = null);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// Creates the entity with the given properties.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The product object with the properties which should be created.</param>
        /// <returns>SubscriptionProduct</returns>
        SubscriptionProduct Create (long? spaceId, SubscriptionProductCreate entity);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// Creates the entity with the given properties.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The product object with the properties which should be created.</param>
        /// <returns>ApiResponse of SubscriptionProduct</returns>
        ApiResponse<SubscriptionProduct> CreateWithHttpInfo (long? spaceId, SubscriptionProductCreate entity);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the product which should be returned.</param>
        /// <returns>SubscriptionProduct</returns>
        SubscriptionProduct Read (long? spaceId, long? id);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the product which should be returned.</param>
        /// <returns>ApiResponse of SubscriptionProduct</returns>
        ApiResponse<SubscriptionProduct> ReadWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the products which are returned by the search.</param>
        /// <returns>List&lt;SubscriptionProduct&gt;</returns>
        List<SubscriptionProduct> Search (long? spaceId, EntityQuery query);

        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the products which are returned by the search.</param>
        /// <returns>ApiResponse of List&lt;SubscriptionProduct&gt;</returns>
        ApiResponse<List<SubscriptionProduct>> SearchWithHttpInfo (long? spaceId, EntityQuery query);

        /// <summary>
        /// Update
        /// </summary>
        /// <remarks>
        /// This updates the entity with the given properties. Only those properties which should be updated can be provided. The &#39;id&#39; and &#39;version&#39; are required to identify the entity.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The products object with all the properties which should be updated. The id and the version are required properties.</param>
        /// <returns>SubscriptionProduct</returns>
        SubscriptionProduct Update (long? spaceId, SubscriptionProductActive entity);

        /// <summary>
        /// Update
        /// </summary>
        /// <remarks>
        /// This updates the entity with the given properties. Only those properties which should be updated can be provided. The &#39;id&#39; and &#39;version&#39; are required to identify the entity.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The products object with all the properties which should be updated. The id and the version are required properties.</param>
        /// <returns>ApiResponse of SubscriptionProduct</returns>
        ApiResponse<SubscriptionProduct> UpdateWithHttpInfo (long? spaceId, SubscriptionProductActive entity);

        #endregion Synchronous Operations
        #region Asynchronous Operations

        /// <summary>
        /// Count
        /// </summary>
        /// <remarks>
        /// Counts the number of items in the database as restricted by the given filter.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>Task of long?</returns>
        System.Threading.Tasks.Task<long?> CountAsync (long? spaceId, EntityQueryFilter filter = null);

        /// <summary>
        /// Count
        /// </summary>
        /// <remarks>
        /// Counts the number of items in the database as restricted by the given filter.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>Task of ApiResponse (long?)</returns>
        System.Threading.Tasks.Task<ApiResponse<long?>> CountAsyncWithHttpInfo (long? spaceId, EntityQueryFilter filter = null);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// Creates the entity with the given properties.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The product object with the properties which should be created.</param>
        /// <returns>Task of SubscriptionProduct</returns>
        System.Threading.Tasks.Task<SubscriptionProduct> CreateAsync (long? spaceId, SubscriptionProductCreate entity);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// Creates the entity with the given properties.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The product object with the properties which should be created.</param>
        /// <returns>Task of ApiResponse (SubscriptionProduct)</returns>
        System.Threading.Tasks.Task<ApiResponse<SubscriptionProduct>> CreateAsyncWithHttpInfo (long? spaceId, SubscriptionProductCreate entity);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the product which should be returned.</param>
        /// <returns>Task of SubscriptionProduct</returns>
        System.Threading.Tasks.Task<SubscriptionProduct> ReadAsync (long? spaceId, long? id);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the product which should be returned.</param>
        /// <returns>Task of ApiResponse (SubscriptionProduct)</returns>
        System.Threading.Tasks.Task<ApiResponse<SubscriptionProduct>> ReadAsyncWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the products which are returned by the search.</param>
        /// <returns>Task of List&lt;SubscriptionProduct&gt;</returns>
        System.Threading.Tasks.Task<List<SubscriptionProduct>> SearchAsync (long? spaceId, EntityQuery query);

        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the products which are returned by the search.</param>
        /// <returns>Task of ApiResponse (List&lt;SubscriptionProduct&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<SubscriptionProduct>>> SearchAsyncWithHttpInfo (long? spaceId, EntityQuery query);

        /// <summary>
        /// Update
        /// </summary>
        /// <remarks>
        /// This updates the entity with the given properties. Only those properties which should be updated can be provided. The &#39;id&#39; and &#39;version&#39; are required to identify the entity.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The products object with all the properties which should be updated. The id and the version are required properties.</param>
        /// <returns>Task of SubscriptionProduct</returns>
        System.Threading.Tasks.Task<SubscriptionProduct> UpdateAsync (long? spaceId, SubscriptionProductActive entity);

        /// <summary>
        /// Update
        /// </summary>
        /// <remarks>
        /// This updates the entity with the given properties. Only those properties which should be updated can be provided. The &#39;id&#39; and &#39;version&#39; are required to identify the entity.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The products object with all the properties which should be updated. The id and the version are required properties.</param>
        /// <returns>Task of ApiResponse (SubscriptionProduct)</returns>
        System.Threading.Tasks.Task<ApiResponse<SubscriptionProduct>> UpdateAsyncWithHttpInfo (long? spaceId, SubscriptionProductActive entity);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SubscriptionProductService : ISubscriptionProductService
    {
        private readonly Customweb.Wallee.Client.ExceptionFactory _exceptionFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SubscriptionProductService(Configuration configuration = null)
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
        /// Count Counts the number of items in the database as restricted by the given filter.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>long?</returns>
        public long? Count (long? spaceId, EntityQueryFilter filter = null)
        {
             ApiResponse<long?> localVarResponse = CountWithHttpInfo(spaceId, filter);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Count Counts the number of items in the database as restricted by the given filter.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>ApiResponse of long?</returns>
        public ApiResponse< long? > CountWithHttpInfo (long? spaceId, EntityQueryFilter filter = null)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionProductService->Count");
            }

            var localVarPath = "/subscription-product/count";
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
            if (filter != null && filter.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(filter); // http body (model) parameter
            }
            else
            {
                localVarPostBody = filter; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Count", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<long?>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (long?) ApiClient.Deserialize(localVarResponse, typeof(long?)));
        }

        /// <summary>
        /// Count Counts the number of items in the database as restricted by the given filter.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>Task of long?</returns>
        public async System.Threading.Tasks.Task<long?> CountAsync (long? spaceId, EntityQueryFilter filter = null)
        {
             ApiResponse<long?> localVarResponse = await CountAsyncWithHttpInfo(spaceId, filter);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Count Counts the number of items in the database as restricted by the given filter.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>Task of ApiResponse (long?)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<long?>> CountAsyncWithHttpInfo (long? spaceId, EntityQueryFilter filter = null)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionProductService->Count");
            }

            var localVarPath = "/subscription-product/count";
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
            if (filter != null && filter.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(filter); // http body (model) parameter
            }
            else
            {
                localVarPostBody = filter; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Count", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<long?>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (long?) ApiClient.Deserialize(localVarResponse, typeof(long?)));
        }

        /// <summary>
        /// Create Creates the entity with the given properties.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The product object with the properties which should be created.</param>
        /// <returns>SubscriptionProduct</returns>
        public SubscriptionProduct Create (long? spaceId, SubscriptionProductCreate entity)
        {
             ApiResponse<SubscriptionProduct> localVarResponse = CreateWithHttpInfo(spaceId, entity);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Creates the entity with the given properties.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The product object with the properties which should be created.</param>
        /// <returns>ApiResponse of SubscriptionProduct</returns>
        public ApiResponse< SubscriptionProduct > CreateWithHttpInfo (long? spaceId, SubscriptionProductCreate entity)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionProductService->Create");
            }
            // verify the required parameter 'entity' is set
            if (entity == null)
            {
                throw new ApiException(400, "Missing required parameter 'entity' when calling SubscriptionProductService->Create");
            }

            var localVarPath = "/subscription-product/create";
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
            if (entity != null && entity.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(entity); // http body (model) parameter
            }
            else
            {
                localVarPostBody = entity; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Create", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SubscriptionProduct>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubscriptionProduct) ApiClient.Deserialize(localVarResponse, typeof(SubscriptionProduct)));
        }

        /// <summary>
        /// Create Creates the entity with the given properties.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The product object with the properties which should be created.</param>
        /// <returns>Task of SubscriptionProduct</returns>
        public async System.Threading.Tasks.Task<SubscriptionProduct> CreateAsync (long? spaceId, SubscriptionProductCreate entity)
        {
             ApiResponse<SubscriptionProduct> localVarResponse = await CreateAsyncWithHttpInfo(spaceId, entity);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Creates the entity with the given properties.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The product object with the properties which should be created.</param>
        /// <returns>Task of ApiResponse (SubscriptionProduct)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SubscriptionProduct>> CreateAsyncWithHttpInfo (long? spaceId, SubscriptionProductCreate entity)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionProductService->Create");
            }
            // verify the required parameter 'entity' is set
            if (entity == null)
            {
                throw new ApiException(400, "Missing required parameter 'entity' when calling SubscriptionProductService->Create");
            }

            var localVarPath = "/subscription-product/create";
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
            if (entity != null && entity.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(entity); // http body (model) parameter
            }
            else
            {
                localVarPostBody = entity; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Create", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SubscriptionProduct>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubscriptionProduct) ApiClient.Deserialize(localVarResponse, typeof(SubscriptionProduct)));
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the product which should be returned.</param>
        /// <returns>SubscriptionProduct</returns>
        public SubscriptionProduct Read (long? spaceId, long? id)
        {
             ApiResponse<SubscriptionProduct> localVarResponse = ReadWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the product which should be returned.</param>
        /// <returns>ApiResponse of SubscriptionProduct</returns>
        public ApiResponse< SubscriptionProduct > ReadWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionProductService->Read");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling SubscriptionProductService->Read");
            }

            var localVarPath = "/subscription-product/read";
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
                "*/*"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Read", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SubscriptionProduct>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubscriptionProduct) ApiClient.Deserialize(localVarResponse, typeof(SubscriptionProduct)));
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the product which should be returned.</param>
        /// <returns>Task of SubscriptionProduct</returns>
        public async System.Threading.Tasks.Task<SubscriptionProduct> ReadAsync (long? spaceId, long? id)
        {
             ApiResponse<SubscriptionProduct> localVarResponse = await ReadAsyncWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the product which should be returned.</param>
        /// <returns>Task of ApiResponse (SubscriptionProduct)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SubscriptionProduct>> ReadAsyncWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionProductService->Read");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling SubscriptionProductService->Read");
            }

            var localVarPath = "/subscription-product/read";
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
                "*/*"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Read", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SubscriptionProduct>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubscriptionProduct) ApiClient.Deserialize(localVarResponse, typeof(SubscriptionProduct)));
        }

        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the products which are returned by the search.</param>
        /// <returns>List&lt;SubscriptionProduct&gt;</returns>
        public List<SubscriptionProduct> Search (long? spaceId, EntityQuery query)
        {
             ApiResponse<List<SubscriptionProduct>> localVarResponse = SearchWithHttpInfo(spaceId, query);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the products which are returned by the search.</param>
        /// <returns>ApiResponse of List&lt;SubscriptionProduct&gt;</returns>
        public ApiResponse< List<SubscriptionProduct> > SearchWithHttpInfo (long? spaceId, EntityQuery query)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionProductService->Search");
            }
            // verify the required parameter 'query' is set
            if (query == null)
            {
                throw new ApiException(400, "Missing required parameter 'query' when calling SubscriptionProductService->Search");
            }

            var localVarPath = "/subscription-product/search";
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
            if (query != null && query.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(query); // http body (model) parameter
            }
            else
            {
                localVarPostBody = query; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Search", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<SubscriptionProduct>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<SubscriptionProduct>) ApiClient.Deserialize(localVarResponse, typeof(List<SubscriptionProduct>)));
        }

        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the products which are returned by the search.</param>
        /// <returns>Task of List&lt;SubscriptionProduct&gt;</returns>
        public async System.Threading.Tasks.Task<List<SubscriptionProduct>> SearchAsync (long? spaceId, EntityQuery query)
        {
             ApiResponse<List<SubscriptionProduct>> localVarResponse = await SearchAsyncWithHttpInfo(spaceId, query);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the products which are returned by the search.</param>
        /// <returns>Task of ApiResponse (List&lt;SubscriptionProduct&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<SubscriptionProduct>>> SearchAsyncWithHttpInfo (long? spaceId, EntityQuery query)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionProductService->Search");
            }
            // verify the required parameter 'query' is set
            if (query == null)
            {
                throw new ApiException(400, "Missing required parameter 'query' when calling SubscriptionProductService->Search");
            }

            var localVarPath = "/subscription-product/search";
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
            if (query != null && query.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(query); // http body (model) parameter
            }
            else
            {
                localVarPostBody = query; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Search", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<SubscriptionProduct>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<SubscriptionProduct>) ApiClient.Deserialize(localVarResponse, typeof(List<SubscriptionProduct>)));
        }

        /// <summary>
        /// Update This updates the entity with the given properties. Only those properties which should be updated can be provided. The &#39;id&#39; and &#39;version&#39; are required to identify the entity.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The products object with all the properties which should be updated. The id and the version are required properties.</param>
        /// <returns>SubscriptionProduct</returns>
        public SubscriptionProduct Update (long? spaceId, SubscriptionProductActive entity)
        {
             ApiResponse<SubscriptionProduct> localVarResponse = UpdateWithHttpInfo(spaceId, entity);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update This updates the entity with the given properties. Only those properties which should be updated can be provided. The &#39;id&#39; and &#39;version&#39; are required to identify the entity.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The products object with all the properties which should be updated. The id and the version are required properties.</param>
        /// <returns>ApiResponse of SubscriptionProduct</returns>
        public ApiResponse< SubscriptionProduct > UpdateWithHttpInfo (long? spaceId, SubscriptionProductActive entity)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionProductService->Update");
            }
            // verify the required parameter 'entity' is set
            if (entity == null)
            {
                throw new ApiException(400, "Missing required parameter 'entity' when calling SubscriptionProductService->Update");
            }

            var localVarPath = "/subscription-product/update";
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
            if (entity != null && entity.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(entity); // http body (model) parameter
            }
            else
            {
                localVarPostBody = entity; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Update", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SubscriptionProduct>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubscriptionProduct) ApiClient.Deserialize(localVarResponse, typeof(SubscriptionProduct)));
        }

        /// <summary>
        /// Update This updates the entity with the given properties. Only those properties which should be updated can be provided. The &#39;id&#39; and &#39;version&#39; are required to identify the entity.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The products object with all the properties which should be updated. The id and the version are required properties.</param>
        /// <returns>Task of SubscriptionProduct</returns>
        public async System.Threading.Tasks.Task<SubscriptionProduct> UpdateAsync (long? spaceId, SubscriptionProductActive entity)
        {
             ApiResponse<SubscriptionProduct> localVarResponse = await UpdateAsyncWithHttpInfo(spaceId, entity);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update This updates the entity with the given properties. Only those properties which should be updated can be provided. The &#39;id&#39; and &#39;version&#39; are required to identify the entity.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The products object with all the properties which should be updated. The id and the version are required properties.</param>
        /// <returns>Task of ApiResponse (SubscriptionProduct)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SubscriptionProduct>> UpdateAsyncWithHttpInfo (long? spaceId, SubscriptionProductActive entity)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionProductService->Update");
            }
            // verify the required parameter 'entity' is set
            if (entity == null)
            {
                throw new ApiException(400, "Missing required parameter 'entity' when calling SubscriptionProductService->Update");
            }

            var localVarPath = "/subscription-product/update";
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
            if (entity != null && entity.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(entity); // http body (model) parameter
            }
            else
            {
                localVarPostBody = entity; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Update", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SubscriptionProduct>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubscriptionProduct) ApiClient.Deserialize(localVarResponse, typeof(SubscriptionProduct)));
        }

    }
}
