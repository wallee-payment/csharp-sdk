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
    public interface IAnalyticsQueryService : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Cancel Execution
        /// </summary>
        /// <remarks>
        /// Cancels the specified query execution.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the query execution to cancel.</param>
        /// <returns></returns>
        void CancelExecution (long? id);

        /// <summary>
        /// Cancel Execution
        /// </summary>
        /// <remarks>
        /// Cancels the specified query execution.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the query execution to cancel.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CancelExecutionWithHttpInfo (long? id);
        /// <summary>
        /// Fetch Result
        /// </summary>
        /// <remarks>
        /// Fetches one batch of the result of a query execution.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the query execution for which to fetch the result.</param>
        /// <param name="timeout">The maximal time in seconds to wait for the result if it is not yet available. Use 0 (the default) to return immediately without waiting. (optional)</param>
        /// <param name="maxRows">The maximum number of rows to return per batch. (Between 1 and 999. The default is 999.) (optional)</param>
        /// <param name="nextToken">The next-token of the preceding batch to get the next result batch or null to get the first result batch. (optional)</param>
        /// <returns>AnalyticsQueryResultBatch</returns>
        AnalyticsQueryResultBatch FetchResult (long? id, int? timeout = null, int? maxRows = null, string nextToken = null);

        /// <summary>
        /// Fetch Result
        /// </summary>
        /// <remarks>
        /// Fetches one batch of the result of a query execution.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the query execution for which to fetch the result.</param>
        /// <param name="timeout">The maximal time in seconds to wait for the result if it is not yet available. Use 0 (the default) to return immediately without waiting. (optional)</param>
        /// <param name="maxRows">The maximum number of rows to return per batch. (Between 1 and 999. The default is 999.) (optional)</param>
        /// <param name="nextToken">The next-token of the preceding batch to get the next result batch or null to get the first result batch. (optional)</param>
        /// <returns>ApiResponse of AnalyticsQueryResultBatch</returns>
        ApiResponse<AnalyticsQueryResultBatch> FetchResultWithHttpInfo (long? id, int? timeout = null, int? maxRows = null, string nextToken = null);
        /// <summary>
        /// Generate Download URL
        /// </summary>
        /// <remarks>
        /// Generate a URL from which the results of a query execution can be downloaded in CSV format.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the query execution for which to generate the download URL.</param>
        /// <param name="timeout">The maximal time in seconds to wait for the result if it is not yet available. Use 0 (the default) to return immediately without waiting. (optional)</param>
        /// <returns>string</returns>
        string GenerateDownloadUrl (long? id, int? timeout = null);

        /// <summary>
        /// Generate Download URL
        /// </summary>
        /// <remarks>
        /// Generate a URL from which the results of a query execution can be downloaded in CSV format.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the query execution for which to generate the download URL.</param>
        /// <param name="timeout">The maximal time in seconds to wait for the result if it is not yet available. Use 0 (the default) to return immediately without waiting. (optional)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> GenerateDownloadUrlWithHttpInfo (long? id, int? timeout = null);
        /// <summary>
        /// Get Schemas
        /// </summary>
        /// <remarks>
        /// Get the schemas describing the available tables and their columns.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;AnalyticsSchemaTable&gt;</returns>
        List<AnalyticsSchemaTable> Schema ();

        /// <summary>
        /// Get Schemas
        /// </summary>
        /// <remarks>
        /// Get the schemas describing the available tables and their columns.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;AnalyticsSchemaTable&gt;</returns>
        ApiResponse<List<AnalyticsSchemaTable>> SchemaWithHttpInfo ();
        /// <summary>
        /// Execution Status
        /// </summary>
        /// <remarks>
        /// Returns the current status of a query execution.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the query execution for which to get the status.</param>
        /// <returns>AnalyticsQueryExecution</returns>
        AnalyticsQueryExecution Status (long? id);

        /// <summary>
        /// Execution Status
        /// </summary>
        /// <remarks>
        /// Returns the current status of a query execution.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the query execution for which to get the status.</param>
        /// <returns>ApiResponse of AnalyticsQueryExecution</returns>
        ApiResponse<AnalyticsQueryExecution> StatusWithHttpInfo (long? id);
        /// <summary>
        /// Submit Query
        /// </summary>
        /// <remarks>
        /// Submits a query for execution.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The query to submit.</param>
        /// <returns>AnalyticsQueryExecution</returns>
        AnalyticsQueryExecution SubmitQuery (AnalyticsQuery query);

        /// <summary>
        /// Submit Query
        /// </summary>
        /// <remarks>
        /// Submits a query for execution.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The query to submit.</param>
        /// <returns>ApiResponse of AnalyticsQueryExecution</returns>
        ApiResponse<AnalyticsQueryExecution> SubmitQueryWithHttpInfo (AnalyticsQuery query);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AnalyticsQueryService : IAnalyticsQueryService
    {
        private Wallee.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueryService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AnalyticsQueryService(Wallee.Client.Configuration configuration = null)
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
        /// Cancel Execution Cancels the specified query execution.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the query execution to cancel.</param>
        /// <returns></returns>
        public void CancelExecution (long? id)
        {
             CancelExecutionWithHttpInfo(id);
        }

        /// <summary>
        /// Cancel Execution Cancels the specified query execution.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the query execution to cancel.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> CancelExecutionWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AnalyticsQueryService->CancelExecution");

            var localVarPath = "/analytics-query/cancel-execution";
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

            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter

			
			this.Configuration.ApiClient.ResetTimeout();
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CancelExecution", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        /// <summary>
        /// Fetch Result Fetches one batch of the result of a query execution.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the query execution for which to fetch the result.</param>
        /// <param name="timeout">The maximal time in seconds to wait for the result if it is not yet available. Use 0 (the default) to return immediately without waiting. (optional)</param>
        /// <param name="maxRows">The maximum number of rows to return per batch. (Between 1 and 999. The default is 999.) (optional)</param>
        /// <param name="nextToken">The next-token of the preceding batch to get the next result batch or null to get the first result batch. (optional)</param>
        /// <returns>AnalyticsQueryResultBatch</returns>
        public AnalyticsQueryResultBatch FetchResult (long? id, int? timeout = null, int? maxRows = null, string nextToken = null)
        {
             ApiResponse<AnalyticsQueryResultBatch> localVarResponse = FetchResultWithHttpInfo(id, timeout, maxRows, nextToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch Result Fetches one batch of the result of a query execution.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the query execution for which to fetch the result.</param>
        /// <param name="timeout">The maximal time in seconds to wait for the result if it is not yet available. Use 0 (the default) to return immediately without waiting. (optional)</param>
        /// <param name="maxRows">The maximum number of rows to return per batch. (Between 1 and 999. The default is 999.) (optional)</param>
        /// <param name="nextToken">The next-token of the preceding batch to get the next result batch or null to get the first result batch. (optional)</param>
        /// <returns>ApiResponse of AnalyticsQueryResultBatch</returns>
        public ApiResponse< AnalyticsQueryResultBatch > FetchResultWithHttpInfo (long? id, int? timeout = null, int? maxRows = null, string nextToken = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AnalyticsQueryService->FetchResult");

            var localVarPath = "/analytics-query/fetch-result";
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

            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter
            if (timeout != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "timeout", timeout)); // query parameter
            if (maxRows != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "maxRows", maxRows)); // query parameter
            if (nextToken != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "nextToken", nextToken)); // query parameter

			
			this.Configuration.ApiClient.ResetTimeout();
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FetchResult", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AnalyticsQueryResultBatch>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AnalyticsQueryResultBatch) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AnalyticsQueryResultBatch)));
        }
        /// <summary>
        /// Generate Download URL Generate a URL from which the results of a query execution can be downloaded in CSV format.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the query execution for which to generate the download URL.</param>
        /// <param name="timeout">The maximal time in seconds to wait for the result if it is not yet available. Use 0 (the default) to return immediately without waiting. (optional)</param>
        /// <returns>string</returns>
        public string GenerateDownloadUrl (long? id, int? timeout = null)
        {
             ApiResponse<string> localVarResponse = GenerateDownloadUrlWithHttpInfo(id, timeout);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Generate Download URL Generate a URL from which the results of a query execution can be downloaded in CSV format.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the query execution for which to generate the download URL.</param>
        /// <param name="timeout">The maximal time in seconds to wait for the result if it is not yet available. Use 0 (the default) to return immediately without waiting. (optional)</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > GenerateDownloadUrlWithHttpInfo (long? id, int? timeout = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AnalyticsQueryService->GenerateDownloadUrl");

            var localVarPath = "/analytics-query/generate-download-url";
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
                "text/plain"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter
            if (timeout != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "timeout", timeout)); // query parameter

			
			this.Configuration.ApiClient.ResetTimeout();
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GenerateDownloadUrl", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }
        /// <summary>
        /// Get Schemas Get the schemas describing the available tables and their columns.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;AnalyticsSchemaTable&gt;</returns>
        public List<AnalyticsSchemaTable> Schema ()
        {
             ApiResponse<List<AnalyticsSchemaTable>> localVarResponse = SchemaWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Schemas Get the schemas describing the available tables and their columns.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;AnalyticsSchemaTable&gt;</returns>
        public ApiResponse< List<AnalyticsSchemaTable> > SchemaWithHttpInfo ()
        {

            var localVarPath = "/analytics-query/schema";
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


			
			this.Configuration.ApiClient.ResetTimeout();
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Schema", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<AnalyticsSchemaTable>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<AnalyticsSchemaTable>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<AnalyticsSchemaTable>)));
        }
        /// <summary>
        /// Execution Status Returns the current status of a query execution.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the query execution for which to get the status.</param>
        /// <returns>AnalyticsQueryExecution</returns>
        public AnalyticsQueryExecution Status (long? id)
        {
             ApiResponse<AnalyticsQueryExecution> localVarResponse = StatusWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Execution Status Returns the current status of a query execution.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the query execution for which to get the status.</param>
        /// <returns>ApiResponse of AnalyticsQueryExecution</returns>
        public ApiResponse< AnalyticsQueryExecution > StatusWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AnalyticsQueryService->Status");

            var localVarPath = "/analytics-query/status";
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

            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter

			
			this.Configuration.ApiClient.ResetTimeout();
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Status", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AnalyticsQueryExecution>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AnalyticsQueryExecution) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AnalyticsQueryExecution)));
        }
        /// <summary>
        /// Submit Query Submits a query for execution.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The query to submit.</param>
        /// <returns>AnalyticsQueryExecution</returns>
        public AnalyticsQueryExecution SubmitQuery (AnalyticsQuery query)
        {
             ApiResponse<AnalyticsQueryExecution> localVarResponse = SubmitQueryWithHttpInfo(query);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Submit Query Submits a query for execution.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The query to submit.</param>
        /// <returns>ApiResponse of AnalyticsQueryExecution</returns>
        public ApiResponse< AnalyticsQueryExecution > SubmitQueryWithHttpInfo (AnalyticsQuery query)
        {
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling AnalyticsQueryService->SubmitQuery");

            var localVarPath = "/analytics-query/submit-query";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (query != null && query.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(query); // http body (model) parameter
            }
            else
            {
                localVarPostBody = query; // byte array
            }

			
			this.Configuration.ApiClient.ResetTimeout();
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SubmitQuery", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AnalyticsQueryExecution>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AnalyticsQueryExecution) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AnalyticsQueryExecution)));
        }
    }
}
