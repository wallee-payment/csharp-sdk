using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Wallee.Client;
using Wallee.Model;

namespace Wallee.Service
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="start">The start date from which on the consumed units should be returned from.</param>
        /// <param name="end">The end date to which the consumed units should be returned to. The end date is not included in the result.</param>
        /// <returns>ApiResponse of List&lt;MetricUsage&gt;</returns>
        ApiResponse<List<MetricUsage>> CalculateWithHttpInfo (long? spaceId, DateTime? start, DateTime? end);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MerticUsageService : IMerticUsageService
    {
        private Wallee.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MerticUsageService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MerticUsageService(Wallee.Client.Configuration configuration = null)
        {
            if(configuration == null){
                throw new ArgumentException("Parameter cannot be null", "configuration");
            }
            this.Configuration = configuration;

            ExceptionFactory = Wallee.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }


        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Wallee.Client.Configuration Configuration {get; set;}

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
        /// Calculate Calculates the consumed resources for the given space and time range.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="start">The start date from which on the consumed units should be returned from.</param>
        /// <param name="end">The end date to which the consumed units should be returned to. The end date is not included in the result.</param>
        /// <returns>ApiResponse of List&lt;MetricUsage&gt;</returns>
        public ApiResponse< List<MetricUsage> > CalculateWithHttpInfo (long? spaceId, DateTime? start, DateTime? end)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling MerticUsageService->Calculate");
            // verify the required parameter 'start' is set
            if (start == null)
                throw new ApiException(400, "Missing required parameter 'start' when calling MerticUsageService->Calculate");
            // verify the required parameter 'end' is set
            if (end == null)
                throw new ApiException(400, "Missing required parameter 'end' when calling MerticUsageService->Calculate");

            var localVarPath = "/mertic-usage/calculate";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (start != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start", start)); // query parameter
            if (end != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "end", end)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
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
                (List<MetricUsage>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<MetricUsage>)));
        }
    }
}
