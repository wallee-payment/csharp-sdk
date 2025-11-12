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
using Wallee.Client;
using Wallee.Model;

namespace Wallee.Service
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAnalyticsQueriesServiceSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Cancel a query execution, identifying it by its external id.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryExternalId">Identifies the query execution.</param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void DeleteAnalyticsQueriesQueryExternalIdQueryExternalId(string queryExternalId, long account, int operationIndex = 0);

        /// <summary>
        /// Cancel a query execution, identifying it by its external id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryExternalId">Identifies the query execution.</param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteAnalyticsQueriesQueryExternalIdQueryExternalIdWithHttpInfo(string queryExternalId, long account, int operationIndex = 0);

        /// <summary>
        /// Cancel a query execution, identifying it by its query token.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryToken">Identifies the query execution.</param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void DeleteAnalyticsQueriesQueryTokenQueryToken(string queryToken, long account, int operationIndex = 0);

        /// <summary>
        /// Cancel a query execution, identifying it by its query token.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryToken">Identifies the query execution.</param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteAnalyticsQueriesQueryTokenQueryTokenWithHttpInfo(string queryToken, long account, int operationIndex = 0);

        /// <summary>
        /// Get portion of query executions for account
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">A cursor for pagination, specifies the number of query executions to skip.</param>
        /// <param name="limit">A limit on the number of query executions to be returned, between 1 and 100. Default is 100.</param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ResultPortionModel</returns>
        ResultPortionModel GetAnalyticsQueries(int offset, int limit, long account, int operationIndex = 0);

        /// <summary>
        /// Get portion of query executions for account
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">A cursor for pagination, specifies the number of query executions to skip.</param>
        /// <param name="limit">A limit on the number of query executions to be returned, between 1 and 100. Default is 100.</param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ResultPortionModel</returns>
        ApiResponse<ResultPortionModel> GetAnalyticsQueriesWithHttpInfo(int offset, int limit, long account, int operationIndex = 0);

        /// <summary>
        /// Retrieve a query execution information by its external id
        /// </summary>
        /// <remarks>
        /// Queries are processed asynchronously and may take several minutes to complete. Avoid frequent requests, as they will not speed up processing.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryExternalId">Identifies the query execution.</param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SubmittedAnalyticsQueryExecution</returns>
        SubmittedAnalyticsQueryExecution GetAnalyticsQueriesQueryExternalIdQueryExternalId(string queryExternalId, long account, int operationIndex = 0);

        /// <summary>
        /// Retrieve a query execution information by its external id
        /// </summary>
        /// <remarks>
        /// Queries are processed asynchronously and may take several minutes to complete. Avoid frequent requests, as they will not speed up processing.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryExternalId">Identifies the query execution.</param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SubmittedAnalyticsQueryExecution</returns>
        ApiResponse<SubmittedAnalyticsQueryExecution> GetAnalyticsQueriesQueryExternalIdQueryExternalIdWithHttpInfo(string queryExternalId, long account, int operationIndex = 0);

        /// <summary>
        /// Generate a temporary URL to download the query result. It retrieves the query by its external id
        /// </summary>
        /// <remarks>
        /// Generate a short-lived (5-minute) URL for downloading the Analytics query result file. Note that each URL generation is counted as a potential download and will be billed accordingly. Do not use this endpoint for periodic checks of file availability. Instead, use the &#39;Retrieve a query execution&#39; endpoint for status checks.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryExternalId">Identifies the query execution.</param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>string</returns>
        string GetAnalyticsQueriesQueryExternalIdQueryExternalIdResult(string queryExternalId, long account, int operationIndex = 0);

        /// <summary>
        /// Generate a temporary URL to download the query result. It retrieves the query by its external id
        /// </summary>
        /// <remarks>
        /// Generate a short-lived (5-minute) URL for downloading the Analytics query result file. Note that each URL generation is counted as a potential download and will be billed accordingly. Do not use this endpoint for periodic checks of file availability. Instead, use the &#39;Retrieve a query execution&#39; endpoint for status checks.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryExternalId">Identifies the query execution.</param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> GetAnalyticsQueriesQueryExternalIdQueryExternalIdResultWithHttpInfo(string queryExternalId, long account, int operationIndex = 0);

        /// <summary>
        /// Retrieve a query execution information by its query token
        /// </summary>
        /// <remarks>
        /// Queries are processed asynchronously and may take several minutes to complete. Avoid frequent requests, as they will not speed up processing.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryToken">Identifies the query execution.</param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SubmittedAnalyticsQueryExecution</returns>
        SubmittedAnalyticsQueryExecution GetAnalyticsQueriesQueryTokenQueryToken(string queryToken, long account, int operationIndex = 0);

        /// <summary>
        /// Retrieve a query execution information by its query token
        /// </summary>
        /// <remarks>
        /// Queries are processed asynchronously and may take several minutes to complete. Avoid frequent requests, as they will not speed up processing.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryToken">Identifies the query execution.</param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SubmittedAnalyticsQueryExecution</returns>
        ApiResponse<SubmittedAnalyticsQueryExecution> GetAnalyticsQueriesQueryTokenQueryTokenWithHttpInfo(string queryToken, long account, int operationIndex = 0);

        /// <summary>
        /// Generate a temporary URL to download the query result. It retrieves the query by its query token
        /// </summary>
        /// <remarks>
        /// Generate a short-lived (5-minute) URL for downloading the Analytics query result file. Note that each URL generation is counted as a potential download and will be billed accordingly. Do not use this endpoint for periodic checks of file availability. Instead, use the &#39;Retrieve a query execution&#39; endpoint for status checks.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryToken">Identifies the query execution.</param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>string</returns>
        string GetAnalyticsQueriesQueryTokenQueryTokenResult(string queryToken, long account, int operationIndex = 0);

        /// <summary>
        /// Generate a temporary URL to download the query result. It retrieves the query by its query token
        /// </summary>
        /// <remarks>
        /// Generate a short-lived (5-minute) URL for downloading the Analytics query result file. Note that each URL generation is counted as a potential download and will be billed accordingly. Do not use this endpoint for periodic checks of file availability. Instead, use the &#39;Retrieve a query execution&#39; endpoint for status checks.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryToken">Identifies the query execution.</param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> GetAnalyticsQueriesQueryTokenQueryTokenResultWithHttpInfo(string queryToken, long account, int operationIndex = 0);

        /// <summary>
        /// Submit a query execution
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryExternalId">A unique id to be provided for each query. The same id for different queries will be only executed the first time</param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="analyticsQueryExecutionRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AnalyticsQueryExecutionResponse</returns>
        AnalyticsQueryExecutionResponse PostAnalyticsQueriesSubmit(string queryExternalId, long account, AnalyticsQueryExecutionRequest analyticsQueryExecutionRequest, int operationIndex = 0);

        /// <summary>
        /// Submit a query execution
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryExternalId">A unique id to be provided for each query. The same id for different queries will be only executed the first time</param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="analyticsQueryExecutionRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AnalyticsQueryExecutionResponse</returns>
        ApiResponse<AnalyticsQueryExecutionResponse> PostAnalyticsQueriesSubmitWithHttpInfo(string queryExternalId, long account, AnalyticsQueryExecutionRequest analyticsQueryExecutionRequest, int operationIndex = 0);

        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAnalyticsQueriesService : IAnalyticsQueriesServiceSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AnalyticsQueriesService : IAnalyticsQueriesService
    {

        private Wallee.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueriesService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AnalyticsQueriesService(Wallee.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            this.Configuration = configuration;
            this.Client = new Wallee.Client.ApiClient(this.Configuration);
            ExceptionFactory = Wallee.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueriesService"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AnalyticsQueriesService(Wallee.Client.ISynchronousClient client, Wallee.Client.IReadableConfiguration configuration)
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
        /// Cancel a query execution, identifying it by its external id. 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryExternalId">Identifies the query execution.</param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void DeleteAnalyticsQueriesQueryExternalIdQueryExternalId(string queryExternalId, long account, int operationIndex = 0)
        {
            DeleteAnalyticsQueriesQueryExternalIdQueryExternalIdWithHttpInfo(queryExternalId, account);
        }

        /// <summary>
        /// Cancel a query execution, identifying it by its external id. 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryExternalId">Identifies the query execution.</param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Wallee.Client.ApiResponse<Object> DeleteAnalyticsQueriesQueryExternalIdQueryExternalIdWithHttpInfo(string queryExternalId, long account, int operationIndex = 0)
        {
            // verify the required parameter 'queryExternalId' is set
            if (queryExternalId == null)
            {
                throw new Wallee.Client.ApiException(400, "Missing required parameter 'queryExternalId' when calling AnalyticsQueriesService->DeleteAnalyticsQueriesQueryExternalIdQueryExternalId");
            }

            Wallee.Client.RequestOptions localVarRequestOptions = new Wallee.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Wallee.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Wallee.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("queryExternalId", Wallee.Client.ClientUtils.ParameterToString(queryExternalId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("Account", Wallee.Client.ClientUtils.ParameterToString(account)); // header parameter

            localVarRequestOptions.Operation = "AnalyticsQueriesService.DeleteAnalyticsQueriesQueryExternalIdQueryExternalId";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = Client.Delete<Object>("/analytics/queries/queryExternalId/{queryExternalId}",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteAnalyticsQueriesQueryExternalIdQueryExternalId", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Cancel a query execution, identifying it by its query token. 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryToken">Identifies the query execution.</param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void DeleteAnalyticsQueriesQueryTokenQueryToken(string queryToken, long account, int operationIndex = 0)
        {
            DeleteAnalyticsQueriesQueryTokenQueryTokenWithHttpInfo(queryToken, account);
        }

        /// <summary>
        /// Cancel a query execution, identifying it by its query token. 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryToken">Identifies the query execution.</param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Wallee.Client.ApiResponse<Object> DeleteAnalyticsQueriesQueryTokenQueryTokenWithHttpInfo(string queryToken, long account, int operationIndex = 0)
        {
            // verify the required parameter 'queryToken' is set
            if (queryToken == null)
            {
                throw new Wallee.Client.ApiException(400, "Missing required parameter 'queryToken' when calling AnalyticsQueriesService->DeleteAnalyticsQueriesQueryTokenQueryToken");
            }

            Wallee.Client.RequestOptions localVarRequestOptions = new Wallee.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Wallee.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Wallee.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("queryToken", Wallee.Client.ClientUtils.ParameterToString(queryToken)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("Account", Wallee.Client.ClientUtils.ParameterToString(account)); // header parameter

            localVarRequestOptions.Operation = "AnalyticsQueriesService.DeleteAnalyticsQueriesQueryTokenQueryToken";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = Client.Delete<Object>("/analytics/queries/queryToken/{queryToken}",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteAnalyticsQueriesQueryTokenQueryToken", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Get portion of query executions for account 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">A cursor for pagination, specifies the number of query executions to skip.</param>
        /// <param name="limit">A limit on the number of query executions to be returned, between 1 and 100. Default is 100.</param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ResultPortionModel</returns>
        public ResultPortionModel GetAnalyticsQueries(int offset, int limit, long account, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<ResultPortionModel> localVarResponse = GetAnalyticsQueriesWithHttpInfo(offset, limit, account);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get portion of query executions for account 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">A cursor for pagination, specifies the number of query executions to skip.</param>
        /// <param name="limit">A limit on the number of query executions to be returned, between 1 and 100. Default is 100.</param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ResultPortionModel</returns>
        public Wallee.Client.ApiResponse<ResultPortionModel> GetAnalyticsQueriesWithHttpInfo(int offset, int limit, long account, int operationIndex = 0)
        {
            Wallee.Client.RequestOptions localVarRequestOptions = new Wallee.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Wallee.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Wallee.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("", "offset", offset));
            localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            localVarRequestOptions.HeaderParameters.Add("Account", Wallee.Client.ClientUtils.ParameterToString(account)); // header parameter

            localVarRequestOptions.Operation = "AnalyticsQueriesService.GetAnalyticsQueries";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = Client.Get<ResultPortionModel>("/analytics/queries",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAnalyticsQueries", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Retrieve a query execution information by its external id Queries are processed asynchronously and may take several minutes to complete. Avoid frequent requests, as they will not speed up processing.
        /// Timeout for this request is: 97 seconds.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryExternalId">Identifies the query execution.</param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SubmittedAnalyticsQueryExecution</returns>
        public SubmittedAnalyticsQueryExecution GetAnalyticsQueriesQueryExternalIdQueryExternalId(string queryExternalId, long account, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<SubmittedAnalyticsQueryExecution> localVarResponse = GetAnalyticsQueriesQueryExternalIdQueryExternalIdWithHttpInfo(queryExternalId, account);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a query execution information by its external id Queries are processed asynchronously and may take several minutes to complete. Avoid frequent requests, as they will not speed up processing.
        /// Timeout for this request is: 97 seconds.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryExternalId">Identifies the query execution.</param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SubmittedAnalyticsQueryExecution</returns>
        public Wallee.Client.ApiResponse<SubmittedAnalyticsQueryExecution> GetAnalyticsQueriesQueryExternalIdQueryExternalIdWithHttpInfo(string queryExternalId, long account, int operationIndex = 0)
        {
            // verify the required parameter 'queryExternalId' is set
            if (queryExternalId == null)
            {
                throw new Wallee.Client.ApiException(400, "Missing required parameter 'queryExternalId' when calling AnalyticsQueriesService->GetAnalyticsQueriesQueryExternalIdQueryExternalId");
            }

            Wallee.Client.RequestOptions localVarRequestOptions = new Wallee.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Wallee.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Wallee.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("queryExternalId", Wallee.Client.ClientUtils.ParameterToString(queryExternalId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("Account", Wallee.Client.ClientUtils.ParameterToString(account)); // header parameter

            localVarRequestOptions.Operation = "AnalyticsQueriesService.GetAnalyticsQueriesQueryExternalIdQueryExternalId";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = 97;
            

            // make the HTTP request
            var localVarResponse = Client.Get<SubmittedAnalyticsQueryExecution>("/analytics/queries/queryExternalId/{queryExternalId}",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAnalyticsQueriesQueryExternalIdQueryExternalId", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Generate a temporary URL to download the query result. It retrieves the query by its external id Generate a short-lived (5-minute) URL for downloading the Analytics query result file. Note that each URL generation is counted as a potential download and will be billed accordingly. Do not use this endpoint for periodic checks of file availability. Instead, use the &#39;Retrieve a query execution&#39; endpoint for status checks.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryExternalId">Identifies the query execution.</param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>string</returns>
        public string GetAnalyticsQueriesQueryExternalIdQueryExternalIdResult(string queryExternalId, long account, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<string> localVarResponse = GetAnalyticsQueriesQueryExternalIdQueryExternalIdResultWithHttpInfo(queryExternalId, account);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Generate a temporary URL to download the query result. It retrieves the query by its external id Generate a short-lived (5-minute) URL for downloading the Analytics query result file. Note that each URL generation is counted as a potential download and will be billed accordingly. Do not use this endpoint for periodic checks of file availability. Instead, use the &#39;Retrieve a query execution&#39; endpoint for status checks.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryExternalId">Identifies the query execution.</param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of string</returns>
        public Wallee.Client.ApiResponse<string> GetAnalyticsQueriesQueryExternalIdQueryExternalIdResultWithHttpInfo(string queryExternalId, long account, int operationIndex = 0)
        {
            // verify the required parameter 'queryExternalId' is set
            if (queryExternalId == null)
            {
                throw new Wallee.Client.ApiException(400, "Missing required parameter 'queryExternalId' when calling AnalyticsQueriesService->GetAnalyticsQueriesQueryExternalIdQueryExternalIdResult");
            }

            Wallee.Client.RequestOptions localVarRequestOptions = new Wallee.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json"
            };

            var localVarContentType = Wallee.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Wallee.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("queryExternalId", Wallee.Client.ClientUtils.ParameterToString(queryExternalId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("Account", Wallee.Client.ClientUtils.ParameterToString(account)); // header parameter

            localVarRequestOptions.Operation = "AnalyticsQueriesService.GetAnalyticsQueriesQueryExternalIdQueryExternalIdResult";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = Client.Get<string>("/analytics/queries/queryExternalId/{queryExternalId}/result",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAnalyticsQueriesQueryExternalIdQueryExternalIdResult", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Retrieve a query execution information by its query token Queries are processed asynchronously and may take several minutes to complete. Avoid frequent requests, as they will not speed up processing.
        /// Timeout for this request is: 97 seconds.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryToken">Identifies the query execution.</param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SubmittedAnalyticsQueryExecution</returns>
        public SubmittedAnalyticsQueryExecution GetAnalyticsQueriesQueryTokenQueryToken(string queryToken, long account, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<SubmittedAnalyticsQueryExecution> localVarResponse = GetAnalyticsQueriesQueryTokenQueryTokenWithHttpInfo(queryToken, account);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a query execution information by its query token Queries are processed asynchronously and may take several minutes to complete. Avoid frequent requests, as they will not speed up processing.
        /// Timeout for this request is: 97 seconds.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryToken">Identifies the query execution.</param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SubmittedAnalyticsQueryExecution</returns>
        public Wallee.Client.ApiResponse<SubmittedAnalyticsQueryExecution> GetAnalyticsQueriesQueryTokenQueryTokenWithHttpInfo(string queryToken, long account, int operationIndex = 0)
        {
            // verify the required parameter 'queryToken' is set
            if (queryToken == null)
            {
                throw new Wallee.Client.ApiException(400, "Missing required parameter 'queryToken' when calling AnalyticsQueriesService->GetAnalyticsQueriesQueryTokenQueryToken");
            }

            Wallee.Client.RequestOptions localVarRequestOptions = new Wallee.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Wallee.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Wallee.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("queryToken", Wallee.Client.ClientUtils.ParameterToString(queryToken)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("Account", Wallee.Client.ClientUtils.ParameterToString(account)); // header parameter

            localVarRequestOptions.Operation = "AnalyticsQueriesService.GetAnalyticsQueriesQueryTokenQueryToken";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = 97;
            

            // make the HTTP request
            var localVarResponse = Client.Get<SubmittedAnalyticsQueryExecution>("/analytics/queries/queryToken/{queryToken}",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAnalyticsQueriesQueryTokenQueryToken", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Generate a temporary URL to download the query result. It retrieves the query by its query token Generate a short-lived (5-minute) URL for downloading the Analytics query result file. Note that each URL generation is counted as a potential download and will be billed accordingly. Do not use this endpoint for periodic checks of file availability. Instead, use the &#39;Retrieve a query execution&#39; endpoint for status checks.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryToken">Identifies the query execution.</param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>string</returns>
        public string GetAnalyticsQueriesQueryTokenQueryTokenResult(string queryToken, long account, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<string> localVarResponse = GetAnalyticsQueriesQueryTokenQueryTokenResultWithHttpInfo(queryToken, account);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Generate a temporary URL to download the query result. It retrieves the query by its query token Generate a short-lived (5-minute) URL for downloading the Analytics query result file. Note that each URL generation is counted as a potential download and will be billed accordingly. Do not use this endpoint for periodic checks of file availability. Instead, use the &#39;Retrieve a query execution&#39; endpoint for status checks.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryToken">Identifies the query execution.</param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of string</returns>
        public Wallee.Client.ApiResponse<string> GetAnalyticsQueriesQueryTokenQueryTokenResultWithHttpInfo(string queryToken, long account, int operationIndex = 0)
        {
            // verify the required parameter 'queryToken' is set
            if (queryToken == null)
            {
                throw new Wallee.Client.ApiException(400, "Missing required parameter 'queryToken' when calling AnalyticsQueriesService->GetAnalyticsQueriesQueryTokenQueryTokenResult");
            }

            Wallee.Client.RequestOptions localVarRequestOptions = new Wallee.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json"
            };

            var localVarContentType = Wallee.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Wallee.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("queryToken", Wallee.Client.ClientUtils.ParameterToString(queryToken)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("Account", Wallee.Client.ClientUtils.ParameterToString(account)); // header parameter

            localVarRequestOptions.Operation = "AnalyticsQueriesService.GetAnalyticsQueriesQueryTokenQueryTokenResult";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = Client.Get<string>("/analytics/queries/queryToken/{queryToken}/result",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAnalyticsQueriesQueryTokenQueryTokenResult", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Submit a query execution 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryExternalId">A unique id to be provided for each query. The same id for different queries will be only executed the first time</param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="analyticsQueryExecutionRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AnalyticsQueryExecutionResponse</returns>
        public AnalyticsQueryExecutionResponse PostAnalyticsQueriesSubmit(string queryExternalId, long account, AnalyticsQueryExecutionRequest analyticsQueryExecutionRequest, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<AnalyticsQueryExecutionResponse> localVarResponse = PostAnalyticsQueriesSubmitWithHttpInfo(queryExternalId, account, analyticsQueryExecutionRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Submit a query execution 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="queryExternalId">A unique id to be provided for each query. The same id for different queries will be only executed the first time</param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="analyticsQueryExecutionRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AnalyticsQueryExecutionResponse</returns>
        public Wallee.Client.ApiResponse<AnalyticsQueryExecutionResponse> PostAnalyticsQueriesSubmitWithHttpInfo(string queryExternalId, long account, AnalyticsQueryExecutionRequest analyticsQueryExecutionRequest, int operationIndex = 0)
        {
            // verify the required parameter 'queryExternalId' is set
            if (queryExternalId == null)
            {
                throw new Wallee.Client.ApiException(400, "Missing required parameter 'queryExternalId' when calling AnalyticsQueriesService->PostAnalyticsQueriesSubmit");
            }

            // verify the required parameter 'analyticsQueryExecutionRequest' is set
            if (analyticsQueryExecutionRequest == null)
            {
                throw new Wallee.Client.ApiException(400, "Missing required parameter 'analyticsQueryExecutionRequest' when calling AnalyticsQueriesService->PostAnalyticsQueriesSubmit");
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
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Wallee.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("", "queryExternalId", queryExternalId));
            localVarRequestOptions.HeaderParameters.Add("Account", Wallee.Client.ClientUtils.ParameterToString(account)); // header parameter
            localVarRequestOptions.Data = analyticsQueryExecutionRequest;

            localVarRequestOptions.Operation = "AnalyticsQueriesService.PostAnalyticsQueriesSubmit";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = Client.Post<AnalyticsQueryExecutionResponse>("/analytics/queries/submit",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostAnalyticsQueriesSubmit", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }


    }
}
