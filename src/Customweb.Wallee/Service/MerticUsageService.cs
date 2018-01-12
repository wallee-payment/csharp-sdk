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
    public interface IMerticUsageService : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Calculate
        /// </summary>
        /// <remarks>
        /// Calculates the consumed resources for the given space and time range.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="start">The start date from which on the consumed units should be returned from.</param>
        /// <param name="end">The end date to which the consumed units should be returned to. The end date is not included in the result.</param>
        /// <returns>List&lt;MetricUsage&gt;</returns>
        List<MetricUsage> Calculate (long? spaceId, DateTime? start, DateTime? end);

        /// <summary>
        /// Calculate
        /// </summary>
        /// <remarks>
        /// Calculates the consumed resources for the given space and time range.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="start">The start date from which on the consumed units should be returned from.</param>
        /// <param name="end">The end date to which the consumed units should be returned to. The end date is not included in the result.</param>
        /// <returns>ApiResponse of List&lt;MetricUsage&gt;</returns>
        ApiResponse<List<MetricUsage>> CalculateWithHttpInfo (long? spaceId, DateTime? start, DateTime? end);

        #endregion Synchronous Operations
        #region Asynchronous Operations

        /// <summary>
        /// Calculate
        /// </summary>
        /// <remarks>
        /// Calculates the consumed resources for the given space and time range.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="start">The start date from which on the consumed units should be returned from.</param>
        /// <param name="end">The end date to which the consumed units should be returned to. The end date is not included in the result.</param>
        /// <returns>Task of List&lt;MetricUsage&gt;</returns>
        System.Threading.Tasks.Task<List<MetricUsage>> CalculateAsync (long? spaceId, DateTime? start, DateTime? end);

        /// <summary>
        /// Calculate
        /// </summary>
        /// <remarks>
        /// Calculates the consumed resources for the given space and time range.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="start">The start date from which on the consumed units should be returned from.</param>
        /// <param name="end">The end date to which the consumed units should be returned to. The end date is not included in the result.</param>
        /// <returns>Task of ApiResponse (List&lt;MetricUsage&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<MetricUsage>>> CalculateAsyncWithHttpInfo (long? spaceId, DateTime? start, DateTime? end);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MerticUsageService : IMerticUsageService
    {
        private readonly Customweb.Wallee.Client.ExceptionFactory _exceptionFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="MerticUsageService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MerticUsageService(Configuration configuration = null)
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
        /// Calculate Calculates the consumed resources for the given space and time range.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="start">The start date from which on the consumed units should be returned from.</param>
        /// <param name="end">The end date to which the consumed units should be returned to. The end date is not included in the result.</param>
        /// <returns>List&lt;MetricUsage&gt;</returns>
        public List<MetricUsage> Calculate (long? spaceId, DateTime? start, DateTime? end)
        {
             ApiResponse<List<MetricUsage>> localVarResponse = CalculateWithHttpInfo(spaceId, start, end);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Calculate Calculates the consumed resources for the given space and time range.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="start">The start date from which on the consumed units should be returned from.</param>
        /// <param name="end">The end date to which the consumed units should be returned to. The end date is not included in the result.</param>
        /// <returns>ApiResponse of List&lt;MetricUsage&gt;</returns>
        public ApiResponse< List<MetricUsage> > CalculateWithHttpInfo (long? spaceId, DateTime? start, DateTime? end)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling MerticUsageService->Calculate");
            }
            // verify the required parameter 'start' is set
            if (start == null)
            {
                throw new ApiException(400, "Missing required parameter 'start' when calling MerticUsageService->Calculate");
            }
            // verify the required parameter 'end' is set
            if (end == null)
            {
                throw new ApiException(400, "Missing required parameter 'end' when calling MerticUsageService->Calculate");
            }

            var localVarPath = "/mertic-usage/calculate";
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
            if (start != null) localVarQueryParams.Add("start", ApiClient.ParameterToString(start)); // query parameter
            if (end != null) localVarQueryParams.Add("end", ApiClient.ParameterToString(end)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Calculate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<MetricUsage>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<MetricUsage>) ApiClient.Deserialize(localVarResponse, typeof(List<MetricUsage>)));
        }

        /// <summary>
        /// Calculate Calculates the consumed resources for the given space and time range.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="start">The start date from which on the consumed units should be returned from.</param>
        /// <param name="end">The end date to which the consumed units should be returned to. The end date is not included in the result.</param>
        /// <returns>Task of List&lt;MetricUsage&gt;</returns>
        public async System.Threading.Tasks.Task<List<MetricUsage>> CalculateAsync (long? spaceId, DateTime? start, DateTime? end)
        {
             ApiResponse<List<MetricUsage>> localVarResponse = await CalculateAsyncWithHttpInfo(spaceId, start, end);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Calculate Calculates the consumed resources for the given space and time range.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="start">The start date from which on the consumed units should be returned from.</param>
        /// <param name="end">The end date to which the consumed units should be returned to. The end date is not included in the result.</param>
        /// <returns>Task of ApiResponse (List&lt;MetricUsage&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<MetricUsage>>> CalculateAsyncWithHttpInfo (long? spaceId, DateTime? start, DateTime? end)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling MerticUsageService->Calculate");
            }
            // verify the required parameter 'start' is set
            if (start == null)
            {
                throw new ApiException(400, "Missing required parameter 'start' when calling MerticUsageService->Calculate");
            }
            // verify the required parameter 'end' is set
            if (end == null)
            {
                throw new ApiException(400, "Missing required parameter 'end' when calling MerticUsageService->Calculate");
            }

            var localVarPath = "/mertic-usage/calculate";
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
            if (start != null) localVarQueryParams.Add("start", ApiClient.ParameterToString(start)); // query parameter
            if (end != null) localVarQueryParams.Add("end", ApiClient.ParameterToString(end)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Calculate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<MetricUsage>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<MetricUsage>) ApiClient.Deserialize(localVarResponse, typeof(List<MetricUsage>)));
        }

    }
}
