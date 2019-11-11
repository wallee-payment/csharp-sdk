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
    public interface IInstallmentPaymentService : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Count
        /// </summary>
        /// <remarks>
        /// Counts the number of items in the database as restricted by the given filter.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the installment payment which are used to calculate the count.</param>
        /// <returns>long?</returns>
        long? Count (long? spaceId, EntityQueryFilter filter);

        /// <summary>
        /// Count
        /// </summary>
        /// <remarks>
        /// Counts the number of items in the database as restricted by the given filter.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the installment payment which are used to calculate the count.</param>
        /// <returns>ApiResponse of long?</returns>
        ApiResponse<long?> CountWithHttpInfo (long? spaceId, EntityQueryFilter filter);
        /// <summary>
        /// Create Installment Payment
        /// </summary>
        /// <remarks>
        /// This operation creates based up on the given transaction an installment payment.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The transaction which should be converted into an installment payment.</param>
        /// <param name="installmentPlanConfiguration">The installment plan configuration ID which should be applied on the transaction.</param>
        /// <returns>InstallmentPayment</returns>
        InstallmentPayment CreateInstallmentPayment (long? spaceId, long? transactionId, long? installmentPlanConfiguration);

        /// <summary>
        /// Create Installment Payment
        /// </summary>
        /// <remarks>
        /// This operation creates based up on the given transaction an installment payment.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The transaction which should be converted into an installment payment.</param>
        /// <param name="installmentPlanConfiguration">The installment plan configuration ID which should be applied on the transaction.</param>
        /// <returns>ApiResponse of InstallmentPayment</returns>
        ApiResponse<InstallmentPayment> CreateInstallmentPaymentWithHttpInfo (long? spaceId, long? transactionId, long? installmentPlanConfiguration);
        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the installment payment which should be returned.</param>
        /// <returns>InstallmentPayment</returns>
        InstallmentPayment Read (long? spaceId, long? id);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the installment payment which should be returned.</param>
        /// <returns>ApiResponse of InstallmentPayment</returns>
        ApiResponse<InstallmentPayment> ReadWithHttpInfo (long? spaceId, long? id);
        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the installment payments which are returned by the search.</param>
        /// <returns>List&lt;InstallmentPayment&gt;</returns>
        List<InstallmentPayment> Search (long? spaceId, EntityQuery query);

        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the installment payments which are returned by the search.</param>
        /// <returns>ApiResponse of List&lt;InstallmentPayment&gt;</returns>
        ApiResponse<List<InstallmentPayment>> SearchWithHttpInfo (long? spaceId, EntityQuery query);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class InstallmentPaymentService : IInstallmentPaymentService
    {
        private Wallee.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="InstallmentPaymentService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public InstallmentPaymentService(Wallee.Client.Configuration configuration = null)
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
        /// Count Counts the number of items in the database as restricted by the given filter.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the installment payment which are used to calculate the count.</param>
        /// <returns>long?</returns>
        public long? Count (long? spaceId, EntityQueryFilter filter)
        {
             ApiResponse<long?> localVarResponse = CountWithHttpInfo(spaceId, filter);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Count Counts the number of items in the database as restricted by the given filter.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the installment payment which are used to calculate the count.</param>
        /// <returns>ApiResponse of long?</returns>
        public ApiResponse< long? > CountWithHttpInfo (long? spaceId, EntityQueryFilter filter)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling InstallmentPaymentService->Count");
            // verify the required parameter 'filter' is set
            if (filter == null)
                throw new ApiException(400, "Missing required parameter 'filter' when calling InstallmentPaymentService->Count");

            var localVarPath = "/installment-payment/count";
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

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (filter != null && filter.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(filter); // http body (model) parameter
            }
            else
            {
                localVarPostBody = filter; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
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
                (long?) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(long?)));
        }
        /// <summary>
        /// Create Installment Payment This operation creates based up on the given transaction an installment payment.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The transaction which should be converted into an installment payment.</param>
        /// <param name="installmentPlanConfiguration">The installment plan configuration ID which should be applied on the transaction.</param>
        /// <returns>InstallmentPayment</returns>
        public InstallmentPayment CreateInstallmentPayment (long? spaceId, long? transactionId, long? installmentPlanConfiguration)
        {
             ApiResponse<InstallmentPayment> localVarResponse = CreateInstallmentPaymentWithHttpInfo(spaceId, transactionId, installmentPlanConfiguration);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Installment Payment This operation creates based up on the given transaction an installment payment.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The transaction which should be converted into an installment payment.</param>
        /// <param name="installmentPlanConfiguration">The installment plan configuration ID which should be applied on the transaction.</param>
        /// <returns>ApiResponse of InstallmentPayment</returns>
        public ApiResponse< InstallmentPayment > CreateInstallmentPaymentWithHttpInfo (long? spaceId, long? transactionId, long? installmentPlanConfiguration)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling InstallmentPaymentService->CreateInstallmentPayment");
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling InstallmentPaymentService->CreateInstallmentPayment");
            // verify the required parameter 'installmentPlanConfiguration' is set
            if (installmentPlanConfiguration == null)
                throw new ApiException(400, "Missing required parameter 'installmentPlanConfiguration' when calling InstallmentPaymentService->CreateInstallmentPayment");

            var localVarPath = "/installment-payment/createInstallmentPayment";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
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
            if (transactionId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "transactionId", transactionId)); // query parameter
            if (installmentPlanConfiguration != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "installmentPlanConfiguration", installmentPlanConfiguration)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateInstallmentPayment", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InstallmentPayment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InstallmentPayment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InstallmentPayment)));
        }
        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the installment payment which should be returned.</param>
        /// <returns>InstallmentPayment</returns>
        public InstallmentPayment Read (long? spaceId, long? id)
        {
             ApiResponse<InstallmentPayment> localVarResponse = ReadWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the installment payment which should be returned.</param>
        /// <returns>ApiResponse of InstallmentPayment</returns>
        public ApiResponse< InstallmentPayment > ReadWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling InstallmentPaymentService->Read");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling InstallmentPaymentService->Read");

            var localVarPath = "/installment-payment/read";
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
            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Read", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InstallmentPayment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InstallmentPayment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InstallmentPayment)));
        }
        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the installment payments which are returned by the search.</param>
        /// <returns>List&lt;InstallmentPayment&gt;</returns>
        public List<InstallmentPayment> Search (long? spaceId, EntityQuery query)
        {
             ApiResponse<List<InstallmentPayment>> localVarResponse = SearchWithHttpInfo(spaceId, query);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the installment payments which are returned by the search.</param>
        /// <returns>ApiResponse of List&lt;InstallmentPayment&gt;</returns>
        public ApiResponse< List<InstallmentPayment> > SearchWithHttpInfo (long? spaceId, EntityQuery query)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling InstallmentPaymentService->Search");
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling InstallmentPaymentService->Search");

            var localVarPath = "/installment-payment/search";
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

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (query != null && query.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(query); // http body (model) parameter
            }
            else
            {
                localVarPostBody = query; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Search", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<InstallmentPayment>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InstallmentPayment>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<InstallmentPayment>)));
        }
    }
}
