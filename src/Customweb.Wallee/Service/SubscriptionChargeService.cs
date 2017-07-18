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
    public interface ISubscriptionChargeService : IApiAccessor
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
        /// The create operation creates a new subscription charge.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="charge"></param>
        /// <returns>SubscriptionCharge</returns>
        SubscriptionCharge Create (long? spaceId, SubscriptionChargeCreate charge);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// The create operation creates a new subscription charge.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="charge"></param>
        /// <returns>ApiResponse of SubscriptionCharge</returns>
        ApiResponse<SubscriptionCharge> CreateWithHttpInfo (long? spaceId, SubscriptionChargeCreate charge);

        /// <summary>
        /// discard
        /// </summary>
        /// <remarks>
        /// This operation allows to discard a scheduled charge.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="chargeId"></param>
        /// <returns>SubscriptionCharge</returns>
        SubscriptionCharge Discard (long? spaceId, long? chargeId);

        /// <summary>
        /// discard
        /// </summary>
        /// <remarks>
        /// This operation allows to discard a scheduled charge.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="chargeId"></param>
        /// <returns>ApiResponse of SubscriptionCharge</returns>
        ApiResponse<SubscriptionCharge> DiscardWithHttpInfo (long? spaceId, long? chargeId);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the subscription charge which should be returned.</param>
        /// <returns>SubscriptionCharge</returns>
        SubscriptionCharge Read (long? spaceId, long? id);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the subscription charge which should be returned.</param>
        /// <returns>ApiResponse of SubscriptionCharge</returns>
        ApiResponse<SubscriptionCharge> ReadWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the subscription charges which are returned by the search.</param>
        /// <returns>List&lt;SubscriptionCharge&gt;</returns>
        List<SubscriptionCharge> Search (long? spaceId, EntityQuery query);

        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the subscription charges which are returned by the search.</param>
        /// <returns>ApiResponse of List&lt;SubscriptionCharge&gt;</returns>
        ApiResponse<List<SubscriptionCharge>> SearchWithHttpInfo (long? spaceId, EntityQuery query);

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
        /// The create operation creates a new subscription charge.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="charge"></param>
        /// <returns>Task of SubscriptionCharge</returns>
        System.Threading.Tasks.Task<SubscriptionCharge> CreateAsync (long? spaceId, SubscriptionChargeCreate charge);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// The create operation creates a new subscription charge.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="charge"></param>
        /// <returns>Task of ApiResponse (SubscriptionCharge)</returns>
        System.Threading.Tasks.Task<ApiResponse<SubscriptionCharge>> CreateAsyncWithHttpInfo (long? spaceId, SubscriptionChargeCreate charge);

        /// <summary>
        /// discard
        /// </summary>
        /// <remarks>
        /// This operation allows to discard a scheduled charge.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="chargeId"></param>
        /// <returns>Task of SubscriptionCharge</returns>
        System.Threading.Tasks.Task<SubscriptionCharge> DiscardAsync (long? spaceId, long? chargeId);

        /// <summary>
        /// discard
        /// </summary>
        /// <remarks>
        /// This operation allows to discard a scheduled charge.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="chargeId"></param>
        /// <returns>Task of ApiResponse (SubscriptionCharge)</returns>
        System.Threading.Tasks.Task<ApiResponse<SubscriptionCharge>> DiscardAsyncWithHttpInfo (long? spaceId, long? chargeId);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the subscription charge which should be returned.</param>
        /// <returns>Task of SubscriptionCharge</returns>
        System.Threading.Tasks.Task<SubscriptionCharge> ReadAsync (long? spaceId, long? id);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the subscription charge which should be returned.</param>
        /// <returns>Task of ApiResponse (SubscriptionCharge)</returns>
        System.Threading.Tasks.Task<ApiResponse<SubscriptionCharge>> ReadAsyncWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the subscription charges which are returned by the search.</param>
        /// <returns>Task of List&lt;SubscriptionCharge&gt;</returns>
        System.Threading.Tasks.Task<List<SubscriptionCharge>> SearchAsync (long? spaceId, EntityQuery query);

        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the subscription charges which are returned by the search.</param>
        /// <returns>Task of ApiResponse (List&lt;SubscriptionCharge&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<SubscriptionCharge>>> SearchAsyncWithHttpInfo (long? spaceId, EntityQuery query);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SubscriptionChargeService : ISubscriptionChargeService
    {
        private readonly Customweb.Wallee.Client.ExceptionFactory _exceptionFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionChargeService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SubscriptionChargeService(Configuration configuration = null)
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
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionChargeService->Count");
            }

            var localVarPath = "/subscription-charge/count";
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
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionChargeService->Count");
            }

            var localVarPath = "/subscription-charge/count";
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
        /// Create The create operation creates a new subscription charge.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="charge"></param>
        /// <returns>SubscriptionCharge</returns>
        public SubscriptionCharge Create (long? spaceId, SubscriptionChargeCreate charge)
        {
             ApiResponse<SubscriptionCharge> localVarResponse = CreateWithHttpInfo(spaceId, charge);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create The create operation creates a new subscription charge.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="charge"></param>
        /// <returns>ApiResponse of SubscriptionCharge</returns>
        public ApiResponse< SubscriptionCharge > CreateWithHttpInfo (long? spaceId, SubscriptionChargeCreate charge)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionChargeService->Create");
            }
            // verify the required parameter 'charge' is set
            if (charge == null)
            {
                throw new ApiException(400, "Missing required parameter 'charge' when calling SubscriptionChargeService->Create");
            }

            var localVarPath = "/subscription-charge/create";
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
            if (charge != null && charge.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(charge); // http body (model) parameter
            }
            else
            {
                localVarPostBody = charge; // byte array
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

            return new ApiResponse<SubscriptionCharge>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubscriptionCharge) ApiClient.Deserialize(localVarResponse, typeof(SubscriptionCharge)));
        }

        /// <summary>
        /// Create The create operation creates a new subscription charge.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="charge"></param>
        /// <returns>Task of SubscriptionCharge</returns>
        public async System.Threading.Tasks.Task<SubscriptionCharge> CreateAsync (long? spaceId, SubscriptionChargeCreate charge)
        {
             ApiResponse<SubscriptionCharge> localVarResponse = await CreateAsyncWithHttpInfo(spaceId, charge);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create The create operation creates a new subscription charge.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="charge"></param>
        /// <returns>Task of ApiResponse (SubscriptionCharge)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SubscriptionCharge>> CreateAsyncWithHttpInfo (long? spaceId, SubscriptionChargeCreate charge)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionChargeService->Create");
            }
            // verify the required parameter 'charge' is set
            if (charge == null)
            {
                throw new ApiException(400, "Missing required parameter 'charge' when calling SubscriptionChargeService->Create");
            }

            var localVarPath = "/subscription-charge/create";
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
            if (charge != null && charge.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(charge); // http body (model) parameter
            }
            else
            {
                localVarPostBody = charge; // byte array
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

            return new ApiResponse<SubscriptionCharge>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubscriptionCharge) ApiClient.Deserialize(localVarResponse, typeof(SubscriptionCharge)));
        }

        /// <summary>
        /// discard This operation allows to discard a scheduled charge.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="chargeId"></param>
        /// <returns>SubscriptionCharge</returns>
        public SubscriptionCharge Discard (long? spaceId, long? chargeId)
        {
             ApiResponse<SubscriptionCharge> localVarResponse = DiscardWithHttpInfo(spaceId, chargeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// discard This operation allows to discard a scheduled charge.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="chargeId"></param>
        /// <returns>ApiResponse of SubscriptionCharge</returns>
        public ApiResponse< SubscriptionCharge > DiscardWithHttpInfo (long? spaceId, long? chargeId)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionChargeService->Discard");
            }
            // verify the required parameter 'chargeId' is set
            if (chargeId == null)
            {
                throw new ApiException(400, "Missing required parameter 'chargeId' when calling SubscriptionChargeService->Discard");
            }

            var localVarPath = "/subscription-charge/discard";
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
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (chargeId != null) localVarQueryParams.Add("chargeId", ApiClient.ParameterToString(chargeId)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Discard", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SubscriptionCharge>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubscriptionCharge) ApiClient.Deserialize(localVarResponse, typeof(SubscriptionCharge)));
        }

        /// <summary>
        /// discard This operation allows to discard a scheduled charge.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="chargeId"></param>
        /// <returns>Task of SubscriptionCharge</returns>
        public async System.Threading.Tasks.Task<SubscriptionCharge> DiscardAsync (long? spaceId, long? chargeId)
        {
             ApiResponse<SubscriptionCharge> localVarResponse = await DiscardAsyncWithHttpInfo(spaceId, chargeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// discard This operation allows to discard a scheduled charge.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="chargeId"></param>
        /// <returns>Task of ApiResponse (SubscriptionCharge)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SubscriptionCharge>> DiscardAsyncWithHttpInfo (long? spaceId, long? chargeId)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionChargeService->Discard");
            }
            // verify the required parameter 'chargeId' is set
            if (chargeId == null)
            {
                throw new ApiException(400, "Missing required parameter 'chargeId' when calling SubscriptionChargeService->Discard");
            }

            var localVarPath = "/subscription-charge/discard";
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
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (chargeId != null) localVarQueryParams.Add("chargeId", ApiClient.ParameterToString(chargeId)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Discard", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SubscriptionCharge>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubscriptionCharge) ApiClient.Deserialize(localVarResponse, typeof(SubscriptionCharge)));
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the subscription charge which should be returned.</param>
        /// <returns>SubscriptionCharge</returns>
        public SubscriptionCharge Read (long? spaceId, long? id)
        {
             ApiResponse<SubscriptionCharge> localVarResponse = ReadWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the subscription charge which should be returned.</param>
        /// <returns>ApiResponse of SubscriptionCharge</returns>
        public ApiResponse< SubscriptionCharge > ReadWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionChargeService->Read");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling SubscriptionChargeService->Read");
            }

            var localVarPath = "/subscription-charge/read";
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

            return new ApiResponse<SubscriptionCharge>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubscriptionCharge) ApiClient.Deserialize(localVarResponse, typeof(SubscriptionCharge)));
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the subscription charge which should be returned.</param>
        /// <returns>Task of SubscriptionCharge</returns>
        public async System.Threading.Tasks.Task<SubscriptionCharge> ReadAsync (long? spaceId, long? id)
        {
             ApiResponse<SubscriptionCharge> localVarResponse = await ReadAsyncWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the subscription charge which should be returned.</param>
        /// <returns>Task of ApiResponse (SubscriptionCharge)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SubscriptionCharge>> ReadAsyncWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionChargeService->Read");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling SubscriptionChargeService->Read");
            }

            var localVarPath = "/subscription-charge/read";
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

            return new ApiResponse<SubscriptionCharge>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubscriptionCharge) ApiClient.Deserialize(localVarResponse, typeof(SubscriptionCharge)));
        }

        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the subscription charges which are returned by the search.</param>
        /// <returns>List&lt;SubscriptionCharge&gt;</returns>
        public List<SubscriptionCharge> Search (long? spaceId, EntityQuery query)
        {
             ApiResponse<List<SubscriptionCharge>> localVarResponse = SearchWithHttpInfo(spaceId, query);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the subscription charges which are returned by the search.</param>
        /// <returns>ApiResponse of List&lt;SubscriptionCharge&gt;</returns>
        public ApiResponse< List<SubscriptionCharge> > SearchWithHttpInfo (long? spaceId, EntityQuery query)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionChargeService->Search");
            }
            // verify the required parameter 'query' is set
            if (query == null)
            {
                throw new ApiException(400, "Missing required parameter 'query' when calling SubscriptionChargeService->Search");
            }

            var localVarPath = "/subscription-charge/search";
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

            return new ApiResponse<List<SubscriptionCharge>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<SubscriptionCharge>) ApiClient.Deserialize(localVarResponse, typeof(List<SubscriptionCharge>)));
        }

        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the subscription charges which are returned by the search.</param>
        /// <returns>Task of List&lt;SubscriptionCharge&gt;</returns>
        public async System.Threading.Tasks.Task<List<SubscriptionCharge>> SearchAsync (long? spaceId, EntityQuery query)
        {
             ApiResponse<List<SubscriptionCharge>> localVarResponse = await SearchAsyncWithHttpInfo(spaceId, query);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the subscription charges which are returned by the search.</param>
        /// <returns>Task of ApiResponse (List&lt;SubscriptionCharge&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<SubscriptionCharge>>> SearchAsyncWithHttpInfo (long? spaceId, EntityQuery query)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionChargeService->Search");
            }
            // verify the required parameter 'query' is set
            if (query == null)
            {
                throw new ApiException(400, "Missing required parameter 'query' when calling SubscriptionChargeService->Search");
            }

            var localVarPath = "/subscription-charge/search";
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

            return new ApiResponse<List<SubscriptionCharge>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<SubscriptionCharge>) ApiClient.Deserialize(localVarResponse, typeof(List<SubscriptionCharge>)));
        }

    }
}
