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
    public interface ISubscriptionProductMeteredFeeService : IApiAccessor
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
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>long?</returns>
        long? Count (long? spaceId, EntityQueryFilter filter = null);

        /// <summary>
        /// Count
        /// </summary>
        /// <remarks>
        /// Counts the number of items in the database as restricted by the given filter.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The metered fee object with the properties which should be created.</param>
        /// <returns>ProductMeteredFee</returns>
        ProductMeteredFee Create (long? spaceId, ProductMeteredFeeUpdate entity);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// Creates the entity with the given properties.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The metered fee object with the properties which should be created.</param>
        /// <returns>ApiResponse of ProductMeteredFee</returns>
        ApiResponse<ProductMeteredFee> CreateWithHttpInfo (long? spaceId, ProductMeteredFeeUpdate entity);
        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// Deletes the entity with the given id.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        void Delete (long? spaceId, long? id);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// Deletes the entity with the given id.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteWithHttpInfo (long? spaceId, long? id);
        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the metered fee which should be returned.</param>
        /// <returns>ProductMeteredFee</returns>
        ProductMeteredFee Read (long? spaceId, long? id);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the metered fee which should be returned.</param>
        /// <returns>ApiResponse of ProductMeteredFee</returns>
        ApiResponse<ProductMeteredFee> ReadWithHttpInfo (long? spaceId, long? id);
        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the metered fees which are returned by the search.</param>
        /// <returns>List&lt;ProductMeteredFee&gt;</returns>
        List<ProductMeteredFee> Search (long? spaceId, EntityQuery query);

        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the metered fees which are returned by the search.</param>
        /// <returns>ApiResponse of List&lt;ProductMeteredFee&gt;</returns>
        ApiResponse<List<ProductMeteredFee>> SearchWithHttpInfo (long? spaceId, EntityQuery query);
        /// <summary>
        /// Update
        /// </summary>
        /// <remarks>
        /// This updates the entity with the given properties. Only those properties which should be updated can be provided. The &#39;id&#39; and &#39;version&#39; are required to identify the entity.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The metered fee object with all the properties which should be updated. The id and the version are required properties.</param>
        /// <returns>ProductMeteredFee</returns>
        ProductMeteredFee Update (long? spaceId, ProductMeteredFeeUpdate entity);

        /// <summary>
        /// Update
        /// </summary>
        /// <remarks>
        /// This updates the entity with the given properties. Only those properties which should be updated can be provided. The &#39;id&#39; and &#39;version&#39; are required to identify the entity.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The metered fee object with all the properties which should be updated. The id and the version are required properties.</param>
        /// <returns>ApiResponse of ProductMeteredFee</returns>
        ApiResponse<ProductMeteredFee> UpdateWithHttpInfo (long? spaceId, ProductMeteredFeeUpdate entity);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SubscriptionProductMeteredFeeService : ISubscriptionProductMeteredFeeService
    {
        private Wallee.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductMeteredFeeService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SubscriptionProductMeteredFeeService(Wallee.Client.Configuration configuration = null)
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>ApiResponse of long?</returns>
        public ApiResponse< long? > CountWithHttpInfo (long? spaceId, EntityQueryFilter filter = null)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionProductMeteredFeeService->Count");

            var localVarPath = "/subscription-product-metered-fee/count";
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
        /// Create Creates the entity with the given properties.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The metered fee object with the properties which should be created.</param>
        /// <returns>ProductMeteredFee</returns>
        public ProductMeteredFee Create (long? spaceId, ProductMeteredFeeUpdate entity)
        {
             ApiResponse<ProductMeteredFee> localVarResponse = CreateWithHttpInfo(spaceId, entity);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Creates the entity with the given properties.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The metered fee object with the properties which should be created.</param>
        /// <returns>ApiResponse of ProductMeteredFee</returns>
        public ApiResponse< ProductMeteredFee > CreateWithHttpInfo (long? spaceId, ProductMeteredFeeUpdate entity)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionProductMeteredFeeService->Create");
            // verify the required parameter 'entity' is set
            if (entity == null)
                throw new ApiException(400, "Missing required parameter 'entity' when calling SubscriptionProductMeteredFeeService->Create");

            var localVarPath = "/subscription-product-metered-fee/create";
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
            if (entity != null && entity.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(entity); // http body (model) parameter
            }
            else
            {
                localVarPostBody = entity; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Create", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ProductMeteredFee>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProductMeteredFee) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProductMeteredFee)));
        }
        /// <summary>
        /// Delete Deletes the entity with the given id.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public void Delete (long? spaceId, long? id)
        {
             DeleteWithHttpInfo(spaceId, id);
        }

        /// <summary>
        /// Delete Deletes the entity with the given id.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionProductMeteredFeeService->Delete");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SubscriptionProductMeteredFeeService->Delete");

            var localVarPath = "/subscription-product-metered-fee/delete";
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
            if (id != null && id.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(id); // http body (model) parameter
            }
            else
            {
                localVarPostBody = id; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Delete", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the metered fee which should be returned.</param>
        /// <returns>ProductMeteredFee</returns>
        public ProductMeteredFee Read (long? spaceId, long? id)
        {
             ApiResponse<ProductMeteredFee> localVarResponse = ReadWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the metered fee which should be returned.</param>
        /// <returns>ApiResponse of ProductMeteredFee</returns>
        public ApiResponse< ProductMeteredFee > ReadWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionProductMeteredFeeService->Read");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SubscriptionProductMeteredFeeService->Read");

            var localVarPath = "/subscription-product-metered-fee/read";
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

            return new ApiResponse<ProductMeteredFee>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProductMeteredFee) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProductMeteredFee)));
        }
        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the metered fees which are returned by the search.</param>
        /// <returns>List&lt;ProductMeteredFee&gt;</returns>
        public List<ProductMeteredFee> Search (long? spaceId, EntityQuery query)
        {
             ApiResponse<List<ProductMeteredFee>> localVarResponse = SearchWithHttpInfo(spaceId, query);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the metered fees which are returned by the search.</param>
        /// <returns>ApiResponse of List&lt;ProductMeteredFee&gt;</returns>
        public ApiResponse< List<ProductMeteredFee> > SearchWithHttpInfo (long? spaceId, EntityQuery query)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionProductMeteredFeeService->Search");
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling SubscriptionProductMeteredFeeService->Search");

            var localVarPath = "/subscription-product-metered-fee/search";
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

            return new ApiResponse<List<ProductMeteredFee>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ProductMeteredFee>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ProductMeteredFee>)));
        }
        /// <summary>
        /// Update This updates the entity with the given properties. Only those properties which should be updated can be provided. The &#39;id&#39; and &#39;version&#39; are required to identify the entity.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The metered fee object with all the properties which should be updated. The id and the version are required properties.</param>
        /// <returns>ProductMeteredFee</returns>
        public ProductMeteredFee Update (long? spaceId, ProductMeteredFeeUpdate entity)
        {
             ApiResponse<ProductMeteredFee> localVarResponse = UpdateWithHttpInfo(spaceId, entity);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update This updates the entity with the given properties. Only those properties which should be updated can be provided. The &#39;id&#39; and &#39;version&#39; are required to identify the entity.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The metered fee object with all the properties which should be updated. The id and the version are required properties.</param>
        /// <returns>ApiResponse of ProductMeteredFee</returns>
        public ApiResponse< ProductMeteredFee > UpdateWithHttpInfo (long? spaceId, ProductMeteredFeeUpdate entity)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionProductMeteredFeeService->Update");
            // verify the required parameter 'entity' is set
            if (entity == null)
                throw new ApiException(400, "Missing required parameter 'entity' when calling SubscriptionProductMeteredFeeService->Update");

            var localVarPath = "/subscription-product-metered-fee/update";
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
            if (entity != null && entity.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(entity); // http body (model) parameter
            }
            else
            {
                localVarPostBody = entity; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Update", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ProductMeteredFee>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProductMeteredFee) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProductMeteredFee)));
        }
    }
}
