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
    public interface IRefundService : IApiAccessor
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
        /// fail
        /// </summary>
        /// <remarks>
        /// This operation allows to mark a refund as failed which is in state MANUAL_CHECK.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="refundId">The id of the refund which should be marked as failed.</param>
        /// <returns>Refund</returns>
        Refund Fail (long? spaceId, long? refundId);

        /// <summary>
        /// fail
        /// </summary>
        /// <remarks>
        /// This operation allows to mark a refund as failed which is in state MANUAL_CHECK.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="refundId">The id of the refund which should be marked as failed.</param>
        /// <returns>ApiResponse of Refund</returns>
        ApiResponse<Refund> FailWithHttpInfo (long? spaceId, long? refundId);

        /// <summary>
        /// getRefundDocument
        /// </summary>
        /// <remarks>
        /// Returns the PDF document for the refund with given id.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the refund to get the document for.</param>
        /// <returns>RenderedDocument</returns>
        RenderedDocument GetRefundDocument (long? spaceId, long? id);

        /// <summary>
        /// getRefundDocument
        /// </summary>
        /// <remarks>
        /// Returns the PDF document for the refund with given id.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the refund to get the document for.</param>
        /// <returns>ApiResponse of RenderedDocument</returns>
        ApiResponse<RenderedDocument> GetRefundDocumentWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the refund which should be returned.</param>
        /// <returns>Refund</returns>
        Refund Read (long? spaceId, long? id);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the refund which should be returned.</param>
        /// <returns>ApiResponse of Refund</returns>
        ApiResponse<Refund> ReadWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// create
        /// </summary>
        /// <remarks>
        /// This operation creates and executes a refund of a particular transaction.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="refund">The refund object which should be created.</param>
        /// <returns>Refund</returns>
        Refund Refund (long? spaceId, RefundCreate refund);

        /// <summary>
        /// create
        /// </summary>
        /// <remarks>
        /// This operation creates and executes a refund of a particular transaction.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="refund">The refund object which should be created.</param>
        /// <returns>ApiResponse of Refund</returns>
        ApiResponse<Refund> RefundWithHttpInfo (long? spaceId, RefundCreate refund);

        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the refunds which are returned by the search.</param>
        /// <returns>List&lt;Refund&gt;</returns>
        List<Refund> Search (long? spaceId, EntityQuery query);

        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the refunds which are returned by the search.</param>
        /// <returns>ApiResponse of List&lt;Refund&gt;</returns>
        ApiResponse<List<Refund>> SearchWithHttpInfo (long? spaceId, EntityQuery query);

        /// <summary>
        /// succeed
        /// </summary>
        /// <remarks>
        /// This operation allows to mark a refund as successful which is in state MANUAL_CHECK.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="refundId">The id of the refund which should be marked as successful.</param>
        /// <returns>Refund</returns>
        Refund Succeed (long? spaceId, long? refundId);

        /// <summary>
        /// succeed
        /// </summary>
        /// <remarks>
        /// This operation allows to mark a refund as successful which is in state MANUAL_CHECK.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="refundId">The id of the refund which should be marked as successful.</param>
        /// <returns>ApiResponse of Refund</returns>
        ApiResponse<Refund> SucceedWithHttpInfo (long? spaceId, long? refundId);

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
        /// fail
        /// </summary>
        /// <remarks>
        /// This operation allows to mark a refund as failed which is in state MANUAL_CHECK.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="refundId">The id of the refund which should be marked as failed.</param>
        /// <returns>Task of Refund</returns>
        System.Threading.Tasks.Task<Refund> FailAsync (long? spaceId, long? refundId);

        /// <summary>
        /// fail
        /// </summary>
        /// <remarks>
        /// This operation allows to mark a refund as failed which is in state MANUAL_CHECK.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="refundId">The id of the refund which should be marked as failed.</param>
        /// <returns>Task of ApiResponse (Refund)</returns>
        System.Threading.Tasks.Task<ApiResponse<Refund>> FailAsyncWithHttpInfo (long? spaceId, long? refundId);

        /// <summary>
        /// getRefundDocument
        /// </summary>
        /// <remarks>
        /// Returns the PDF document for the refund with given id.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the refund to get the document for.</param>
        /// <returns>Task of RenderedDocument</returns>
        System.Threading.Tasks.Task<RenderedDocument> GetRefundDocumentAsync (long? spaceId, long? id);

        /// <summary>
        /// getRefundDocument
        /// </summary>
        /// <remarks>
        /// Returns the PDF document for the refund with given id.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the refund to get the document for.</param>
        /// <returns>Task of ApiResponse (RenderedDocument)</returns>
        System.Threading.Tasks.Task<ApiResponse<RenderedDocument>> GetRefundDocumentAsyncWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the refund which should be returned.</param>
        /// <returns>Task of Refund</returns>
        System.Threading.Tasks.Task<Refund> ReadAsync (long? spaceId, long? id);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the refund which should be returned.</param>
        /// <returns>Task of ApiResponse (Refund)</returns>
        System.Threading.Tasks.Task<ApiResponse<Refund>> ReadAsyncWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// create
        /// </summary>
        /// <remarks>
        /// This operation creates and executes a refund of a particular transaction.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="refund">The refund object which should be created.</param>
        /// <returns>Task of Refund</returns>
        System.Threading.Tasks.Task<Refund> RefundAsync (long? spaceId, RefundCreate refund);

        /// <summary>
        /// create
        /// </summary>
        /// <remarks>
        /// This operation creates and executes a refund of a particular transaction.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="refund">The refund object which should be created.</param>
        /// <returns>Task of ApiResponse (Refund)</returns>
        System.Threading.Tasks.Task<ApiResponse<Refund>> RefundAsyncWithHttpInfo (long? spaceId, RefundCreate refund);

        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the refunds which are returned by the search.</param>
        /// <returns>Task of List&lt;Refund&gt;</returns>
        System.Threading.Tasks.Task<List<Refund>> SearchAsync (long? spaceId, EntityQuery query);

        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the refunds which are returned by the search.</param>
        /// <returns>Task of ApiResponse (List&lt;Refund&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Refund>>> SearchAsyncWithHttpInfo (long? spaceId, EntityQuery query);

        /// <summary>
        /// succeed
        /// </summary>
        /// <remarks>
        /// This operation allows to mark a refund as successful which is in state MANUAL_CHECK.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="refundId">The id of the refund which should be marked as successful.</param>
        /// <returns>Task of Refund</returns>
        System.Threading.Tasks.Task<Refund> SucceedAsync (long? spaceId, long? refundId);

        /// <summary>
        /// succeed
        /// </summary>
        /// <remarks>
        /// This operation allows to mark a refund as successful which is in state MANUAL_CHECK.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="refundId">The id of the refund which should be marked as successful.</param>
        /// <returns>Task of ApiResponse (Refund)</returns>
        System.Threading.Tasks.Task<ApiResponse<Refund>> SucceedAsyncWithHttpInfo (long? spaceId, long? refundId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class RefundService : IRefundService
    {
        private readonly Customweb.Wallee.Client.ExceptionFactory _exceptionFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="RefundService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RefundService(Configuration configuration = null)
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
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling RefundService->Count");
            }

            var localVarPath = "/refund/count";
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
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling RefundService->Count");
            }

            var localVarPath = "/refund/count";
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
        /// fail This operation allows to mark a refund as failed which is in state MANUAL_CHECK.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="refundId">The id of the refund which should be marked as failed.</param>
        /// <returns>Refund</returns>
        public Refund Fail (long? spaceId, long? refundId)
        {
             ApiResponse<Refund> localVarResponse = FailWithHttpInfo(spaceId, refundId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// fail This operation allows to mark a refund as failed which is in state MANUAL_CHECK.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="refundId">The id of the refund which should be marked as failed.</param>
        /// <returns>ApiResponse of Refund</returns>
        public ApiResponse< Refund > FailWithHttpInfo (long? spaceId, long? refundId)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling RefundService->Fail");
            }
            // verify the required parameter 'refundId' is set
            if (refundId == null)
            {
                throw new ApiException(400, "Missing required parameter 'refundId' when calling RefundService->Fail");
            }

            var localVarPath = "/refund/fail";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
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
            if (refundId != null) localVarQueryParams.Add("refundId", ApiClient.ParameterToString(refundId)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Fail", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Refund>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Refund) ApiClient.Deserialize(localVarResponse, typeof(Refund)));
        }

        /// <summary>
        /// fail This operation allows to mark a refund as failed which is in state MANUAL_CHECK.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="refundId">The id of the refund which should be marked as failed.</param>
        /// <returns>Task of Refund</returns>
        public async System.Threading.Tasks.Task<Refund> FailAsync (long? spaceId, long? refundId)
        {
             ApiResponse<Refund> localVarResponse = await FailAsyncWithHttpInfo(spaceId, refundId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// fail This operation allows to mark a refund as failed which is in state MANUAL_CHECK.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="refundId">The id of the refund which should be marked as failed.</param>
        /// <returns>Task of ApiResponse (Refund)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Refund>> FailAsyncWithHttpInfo (long? spaceId, long? refundId)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling RefundService->Fail");
            }
            // verify the required parameter 'refundId' is set
            if (refundId == null)
            {
                throw new ApiException(400, "Missing required parameter 'refundId' when calling RefundService->Fail");
            }

            var localVarPath = "/refund/fail";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
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
            if (refundId != null) localVarQueryParams.Add("refundId", ApiClient.ParameterToString(refundId)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Fail", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Refund>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Refund) ApiClient.Deserialize(localVarResponse, typeof(Refund)));
        }

        /// <summary>
        /// getRefundDocument Returns the PDF document for the refund with given id.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the refund to get the document for.</param>
        /// <returns>RenderedDocument</returns>
        public RenderedDocument GetRefundDocument (long? spaceId, long? id)
        {
             ApiResponse<RenderedDocument> localVarResponse = GetRefundDocumentWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// getRefundDocument Returns the PDF document for the refund with given id.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the refund to get the document for.</param>
        /// <returns>ApiResponse of RenderedDocument</returns>
        public ApiResponse< RenderedDocument > GetRefundDocumentWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling RefundService->GetRefundDocument");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling RefundService->GetRefundDocument");
            }

            var localVarPath = "/refund/getRefundDocument";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
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
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetRefundDocument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RenderedDocument>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RenderedDocument) ApiClient.Deserialize(localVarResponse, typeof(RenderedDocument)));
        }

        /// <summary>
        /// getRefundDocument Returns the PDF document for the refund with given id.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the refund to get the document for.</param>
        /// <returns>Task of RenderedDocument</returns>
        public async System.Threading.Tasks.Task<RenderedDocument> GetRefundDocumentAsync (long? spaceId, long? id)
        {
             ApiResponse<RenderedDocument> localVarResponse = await GetRefundDocumentAsyncWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// getRefundDocument Returns the PDF document for the refund with given id.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the refund to get the document for.</param>
        /// <returns>Task of ApiResponse (RenderedDocument)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RenderedDocument>> GetRefundDocumentAsyncWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling RefundService->GetRefundDocument");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling RefundService->GetRefundDocument");
            }

            var localVarPath = "/refund/getRefundDocument";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
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
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetRefundDocument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RenderedDocument>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RenderedDocument) ApiClient.Deserialize(localVarResponse, typeof(RenderedDocument)));
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the refund which should be returned.</param>
        /// <returns>Refund</returns>
        public Refund Read (long? spaceId, long? id)
        {
             ApiResponse<Refund> localVarResponse = ReadWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the refund which should be returned.</param>
        /// <returns>ApiResponse of Refund</returns>
        public ApiResponse< Refund > ReadWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling RefundService->Read");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling RefundService->Read");
            }

            var localVarPath = "/refund/read";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
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

            return new ApiResponse<Refund>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Refund) ApiClient.Deserialize(localVarResponse, typeof(Refund)));
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the refund which should be returned.</param>
        /// <returns>Task of Refund</returns>
        public async System.Threading.Tasks.Task<Refund> ReadAsync (long? spaceId, long? id)
        {
             ApiResponse<Refund> localVarResponse = await ReadAsyncWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the refund which should be returned.</param>
        /// <returns>Task of ApiResponse (Refund)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Refund>> ReadAsyncWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling RefundService->Read");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling RefundService->Read");
            }

            var localVarPath = "/refund/read";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
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

            return new ApiResponse<Refund>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Refund) ApiClient.Deserialize(localVarResponse, typeof(Refund)));
        }

        /// <summary>
        /// create This operation creates and executes a refund of a particular transaction.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="refund">The refund object which should be created.</param>
        /// <returns>Refund</returns>
        public Refund Refund (long? spaceId, RefundCreate refund)
        {
             ApiResponse<Refund> localVarResponse = RefundWithHttpInfo(spaceId, refund);
             return localVarResponse.Data;
        }

        /// <summary>
        /// create This operation creates and executes a refund of a particular transaction.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="refund">The refund object which should be created.</param>
        /// <returns>ApiResponse of Refund</returns>
        public ApiResponse< Refund > RefundWithHttpInfo (long? spaceId, RefundCreate refund)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling RefundService->Refund");
            }
            // verify the required parameter 'refund' is set
            if (refund == null)
            {
                throw new ApiException(400, "Missing required parameter 'refund' when calling RefundService->Refund");
            }

            var localVarPath = "/refund/refund";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
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
            if (refund != null && refund.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(refund); // http body (model) parameter
            }
            else
            {
                localVarPostBody = refund; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Refund", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Refund>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Refund) ApiClient.Deserialize(localVarResponse, typeof(Refund)));
        }

        /// <summary>
        /// create This operation creates and executes a refund of a particular transaction.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="refund">The refund object which should be created.</param>
        /// <returns>Task of Refund</returns>
        public async System.Threading.Tasks.Task<Refund> RefundAsync (long? spaceId, RefundCreate refund)
        {
             ApiResponse<Refund> localVarResponse = await RefundAsyncWithHttpInfo(spaceId, refund);
             return localVarResponse.Data;
        }

        /// <summary>
        /// create This operation creates and executes a refund of a particular transaction.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="refund">The refund object which should be created.</param>
        /// <returns>Task of ApiResponse (Refund)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Refund>> RefundAsyncWithHttpInfo (long? spaceId, RefundCreate refund)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling RefundService->Refund");
            }
            // verify the required parameter 'refund' is set
            if (refund == null)
            {
                throw new ApiException(400, "Missing required parameter 'refund' when calling RefundService->Refund");
            }

            var localVarPath = "/refund/refund";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
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
            if (refund != null && refund.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(refund); // http body (model) parameter
            }
            else
            {
                localVarPostBody = refund; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Refund", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Refund>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Refund) ApiClient.Deserialize(localVarResponse, typeof(Refund)));
        }

        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the refunds which are returned by the search.</param>
        /// <returns>List&lt;Refund&gt;</returns>
        public List<Refund> Search (long? spaceId, EntityQuery query)
        {
             ApiResponse<List<Refund>> localVarResponse = SearchWithHttpInfo(spaceId, query);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the refunds which are returned by the search.</param>
        /// <returns>ApiResponse of List&lt;Refund&gt;</returns>
        public ApiResponse< List<Refund> > SearchWithHttpInfo (long? spaceId, EntityQuery query)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling RefundService->Search");
            }
            // verify the required parameter 'query' is set
            if (query == null)
            {
                throw new ApiException(400, "Missing required parameter 'query' when calling RefundService->Search");
            }

            var localVarPath = "/refund/search";
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

            return new ApiResponse<List<Refund>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Refund>) ApiClient.Deserialize(localVarResponse, typeof(List<Refund>)));
        }

        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the refunds which are returned by the search.</param>
        /// <returns>Task of List&lt;Refund&gt;</returns>
        public async System.Threading.Tasks.Task<List<Refund>> SearchAsync (long? spaceId, EntityQuery query)
        {
             ApiResponse<List<Refund>> localVarResponse = await SearchAsyncWithHttpInfo(spaceId, query);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the refunds which are returned by the search.</param>
        /// <returns>Task of ApiResponse (List&lt;Refund&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Refund>>> SearchAsyncWithHttpInfo (long? spaceId, EntityQuery query)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling RefundService->Search");
            }
            // verify the required parameter 'query' is set
            if (query == null)
            {
                throw new ApiException(400, "Missing required parameter 'query' when calling RefundService->Search");
            }

            var localVarPath = "/refund/search";
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

            return new ApiResponse<List<Refund>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Refund>) ApiClient.Deserialize(localVarResponse, typeof(List<Refund>)));
        }

        /// <summary>
        /// succeed This operation allows to mark a refund as successful which is in state MANUAL_CHECK.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="refundId">The id of the refund which should be marked as successful.</param>
        /// <returns>Refund</returns>
        public Refund Succeed (long? spaceId, long? refundId)
        {
             ApiResponse<Refund> localVarResponse = SucceedWithHttpInfo(spaceId, refundId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// succeed This operation allows to mark a refund as successful which is in state MANUAL_CHECK.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="refundId">The id of the refund which should be marked as successful.</param>
        /// <returns>ApiResponse of Refund</returns>
        public ApiResponse< Refund > SucceedWithHttpInfo (long? spaceId, long? refundId)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling RefundService->Succeed");
            }
            // verify the required parameter 'refundId' is set
            if (refundId == null)
            {
                throw new ApiException(400, "Missing required parameter 'refundId' when calling RefundService->Succeed");
            }

            var localVarPath = "/refund/succeed";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
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
            if (refundId != null) localVarQueryParams.Add("refundId", ApiClient.ParameterToString(refundId)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Succeed", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Refund>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Refund) ApiClient.Deserialize(localVarResponse, typeof(Refund)));
        }

        /// <summary>
        /// succeed This operation allows to mark a refund as successful which is in state MANUAL_CHECK.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="refundId">The id of the refund which should be marked as successful.</param>
        /// <returns>Task of Refund</returns>
        public async System.Threading.Tasks.Task<Refund> SucceedAsync (long? spaceId, long? refundId)
        {
             ApiResponse<Refund> localVarResponse = await SucceedAsyncWithHttpInfo(spaceId, refundId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// succeed This operation allows to mark a refund as successful which is in state MANUAL_CHECK.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="refundId">The id of the refund which should be marked as successful.</param>
        /// <returns>Task of ApiResponse (Refund)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Refund>> SucceedAsyncWithHttpInfo (long? spaceId, long? refundId)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling RefundService->Succeed");
            }
            // verify the required parameter 'refundId' is set
            if (refundId == null)
            {
                throw new ApiException(400, "Missing required parameter 'refundId' when calling RefundService->Succeed");
            }

            var localVarPath = "/refund/succeed";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
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
            if (refundId != null) localVarQueryParams.Add("refundId", ApiClient.ParameterToString(refundId)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Succeed", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Refund>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Refund) ApiClient.Deserialize(localVarResponse, typeof(Refund)));
        }

    }
}
