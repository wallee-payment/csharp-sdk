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
    public interface IAccountService : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Count
        /// </summary>
        /// <remarks>
        /// Counts the number of items in the database as restricted by the given filter.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>long?</returns>
        long? Count (EntityQueryFilter filter = null);

        /// <summary>
        /// Count
        /// </summary>
        /// <remarks>
        /// Counts the number of items in the database as restricted by the given filter.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>ApiResponse of long?</returns>
        ApiResponse<long?> CountWithHttpInfo (EntityQueryFilter filter = null);
        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// Creates the entity with the given properties.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entity">The account object with the properties which should be created.</param>
        /// <returns>Account</returns>
        Account Create (AccountCreate entity);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// Creates the entity with the given properties.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entity">The account object with the properties which should be created.</param>
        /// <returns>ApiResponse of Account</returns>
        ApiResponse<Account> CreateWithHttpInfo (AccountCreate entity);
        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// Deletes the entity with the given id.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns></returns>
        void Delete (long? id);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// Deletes the entity with the given id.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteWithHttpInfo (long? id);
        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the account which should be returned.</param>
        /// <returns>Account</returns>
        Account Read (long? id);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the account which should be returned.</param>
        /// <returns>ApiResponse of Account</returns>
        ApiResponse<Account> ReadWithHttpInfo (long? id);
        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The query restricts the accounts which are returned by the search.</param>
        /// <returns>List&lt;Account&gt;</returns>
        List<Account> Search (EntityQuery query);

        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The query restricts the accounts which are returned by the search.</param>
        /// <returns>ApiResponse of List&lt;Account&gt;</returns>
        ApiResponse<List<Account>> SearchWithHttpInfo (EntityQuery query);
        /// <summary>
        /// Update
        /// </summary>
        /// <remarks>
        /// This updates the entity with the given properties. Only those properties which should be updated can be provided. The &#39;id&#39; and &#39;version&#39; are required to identify the entity.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entity">The account object with all the properties which should be updated. The id and the version are required properties.</param>
        /// <returns>Account</returns>
        Account Update (AccountUpdate entity);

        /// <summary>
        /// Update
        /// </summary>
        /// <remarks>
        /// This updates the entity with the given properties. Only those properties which should be updated can be provided. The &#39;id&#39; and &#39;version&#39; are required to identify the entity.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entity">The account object with all the properties which should be updated. The id and the version are required properties.</param>
        /// <returns>ApiResponse of Account</returns>
        ApiResponse<Account> UpdateWithHttpInfo (AccountUpdate entity);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AccountService : IAccountService
    {
        private Wallee.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AccountService(Wallee.Client.Configuration configuration = null)
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
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>long?</returns>
        public long? Count (EntityQueryFilter filter = null)
        {
             ApiResponse<long?> localVarResponse = CountWithHttpInfo(filter);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Count Counts the number of items in the database as restricted by the given filter.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>ApiResponse of long?</returns>
        public ApiResponse< long? > CountWithHttpInfo (EntityQueryFilter filter = null)
        {

            var localVarPath = "/account/count";
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
        /// <param name="entity">The account object with the properties which should be created.</param>
        /// <returns>Account</returns>
        public Account Create (AccountCreate entity)
        {
             ApiResponse<Account> localVarResponse = CreateWithHttpInfo(entity);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Creates the entity with the given properties.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entity">The account object with the properties which should be created.</param>
        /// <returns>ApiResponse of Account</returns>
        public ApiResponse< Account > CreateWithHttpInfo (AccountCreate entity)
        {
            // verify the required parameter 'entity' is set
            if (entity == null)
                throw new ApiException(400, "Missing required parameter 'entity' when calling AccountService->Create");

            var localVarPath = "/account/create";
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

            return new ApiResponse<Account>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Account) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Account)));
        }
        /// <summary>
        /// Delete Deletes the entity with the given id.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns></returns>
        public void Delete (long? id)
        {
             DeleteWithHttpInfo(id);
        }

        /// <summary>
        /// Delete Deletes the entity with the given id.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountService->Delete");

            var localVarPath = "/account/delete";
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
        /// <param name="id">The id of the account which should be returned.</param>
        /// <returns>Account</returns>
        public Account Read (long? id)
        {
             ApiResponse<Account> localVarResponse = ReadWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the account which should be returned.</param>
        /// <returns>ApiResponse of Account</returns>
        public ApiResponse< Account > ReadWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AccountService->Read");

            var localVarPath = "/account/read";
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

            return new ApiResponse<Account>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Account) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Account)));
        }
        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The query restricts the accounts which are returned by the search.</param>
        /// <returns>List&lt;Account&gt;</returns>
        public List<Account> Search (EntityQuery query)
        {
             ApiResponse<List<Account>> localVarResponse = SearchWithHttpInfo(query);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The query restricts the accounts which are returned by the search.</param>
        /// <returns>ApiResponse of List&lt;Account&gt;</returns>
        public ApiResponse< List<Account> > SearchWithHttpInfo (EntityQuery query)
        {
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling AccountService->Search");

            var localVarPath = "/account/search";
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

            return new ApiResponse<List<Account>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Account>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Account>)));
        }
        /// <summary>
        /// Update This updates the entity with the given properties. Only those properties which should be updated can be provided. The &#39;id&#39; and &#39;version&#39; are required to identify the entity.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entity">The account object with all the properties which should be updated. The id and the version are required properties.</param>
        /// <returns>Account</returns>
        public Account Update (AccountUpdate entity)
        {
             ApiResponse<Account> localVarResponse = UpdateWithHttpInfo(entity);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update This updates the entity with the given properties. Only those properties which should be updated can be provided. The &#39;id&#39; and &#39;version&#39; are required to identify the entity.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entity">The account object with all the properties which should be updated. The id and the version are required properties.</param>
        /// <returns>ApiResponse of Account</returns>
        public ApiResponse< Account > UpdateWithHttpInfo (AccountUpdate entity)
        {
            // verify the required parameter 'entity' is set
            if (entity == null)
                throw new ApiException(400, "Missing required parameter 'entity' when calling AccountService->Update");

            var localVarPath = "/account/update";
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

            return new ApiResponse<Account>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Account) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Account)));
        }
    }
}
