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
    public interface ILegalOrganizationFormService : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// All
        /// </summary>
        /// <remarks>
        /// This operation returns all entities which are available.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;LegalOrganizationForm&gt;</returns>
        List<LegalOrganizationForm> All ();

        /// <summary>
        /// All
        /// </summary>
        /// <remarks>
        /// This operation returns all entities which are available.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;LegalOrganizationForm&gt;</returns>
        ApiResponse<List<LegalOrganizationForm>> AllWithHttpInfo ();

        /// <summary>
        /// Find by Country
        /// </summary>
        /// <remarks>
        /// This operation returns all legal organization forms for a given country.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">The country in ISO 3166-1 alpha-2 format, for which all legal organization forms should be returned.</param>
        /// <returns>List&lt;LegalOrganizationForm&gt;</returns>
        List<LegalOrganizationForm> Country (string code);

        /// <summary>
        /// Find by Country
        /// </summary>
        /// <remarks>
        /// This operation returns all legal organization forms for a given country.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">The country in ISO 3166-1 alpha-2 format, for which all legal organization forms should be returned.</param>
        /// <returns>ApiResponse of List&lt;LegalOrganizationForm&gt;</returns>
        ApiResponse<List<LegalOrganizationForm>> CountryWithHttpInfo (string code);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the legal organization form which should be returned.</param>
        /// <returns>LegalOrganizationForm</returns>
        LegalOrganizationForm Read (long? id);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the legal organization form which should be returned.</param>
        /// <returns>ApiResponse of LegalOrganizationForm</returns>
        ApiResponse<LegalOrganizationForm> ReadWithHttpInfo (long? id);

        #endregion Synchronous Operations
        #region Asynchronous Operations

        /// <summary>
        /// All
        /// </summary>
        /// <remarks>
        /// This operation returns all entities which are available.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;LegalOrganizationForm&gt;</returns>
        System.Threading.Tasks.Task<List<LegalOrganizationForm>> AllAsync ();

        /// <summary>
        /// All
        /// </summary>
        /// <remarks>
        /// This operation returns all entities which are available.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;LegalOrganizationForm&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<LegalOrganizationForm>>> AllAsyncWithHttpInfo ();

        /// <summary>
        /// Find by Country
        /// </summary>
        /// <remarks>
        /// This operation returns all legal organization forms for a given country.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">The country in ISO 3166-1 alpha-2 format, for which all legal organization forms should be returned.</param>
        /// <returns>Task of List&lt;LegalOrganizationForm&gt;</returns>
        System.Threading.Tasks.Task<List<LegalOrganizationForm>> CountryAsync (string code);

        /// <summary>
        /// Find by Country
        /// </summary>
        /// <remarks>
        /// This operation returns all legal organization forms for a given country.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">The country in ISO 3166-1 alpha-2 format, for which all legal organization forms should be returned.</param>
        /// <returns>Task of ApiResponse (List&lt;LegalOrganizationForm&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<LegalOrganizationForm>>> CountryAsyncWithHttpInfo (string code);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the legal organization form which should be returned.</param>
        /// <returns>Task of LegalOrganizationForm</returns>
        System.Threading.Tasks.Task<LegalOrganizationForm> ReadAsync (long? id);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the legal organization form which should be returned.</param>
        /// <returns>Task of ApiResponse (LegalOrganizationForm)</returns>
        System.Threading.Tasks.Task<ApiResponse<LegalOrganizationForm>> ReadAsyncWithHttpInfo (long? id);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LegalOrganizationFormService : ILegalOrganizationFormService
    {
        private readonly Customweb.Wallee.Client.ExceptionFactory _exceptionFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="LegalOrganizationFormService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LegalOrganizationFormService(Configuration configuration = null)
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
        /// All This operation returns all entities which are available.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;LegalOrganizationForm&gt;</returns>
        public List<LegalOrganizationForm> All ()
        {
             ApiResponse<List<LegalOrganizationForm>> localVarResponse = AllWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// All This operation returns all entities which are available.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;LegalOrganizationForm&gt;</returns>
        public ApiResponse< List<LegalOrganizationForm> > AllWithHttpInfo ()
        {

            var localVarPath = "/legal-organization-form/all";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("All", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<LegalOrganizationForm>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<LegalOrganizationForm>) ApiClient.Deserialize(localVarResponse, typeof(List<LegalOrganizationForm>)));
        }

        /// <summary>
        /// All This operation returns all entities which are available.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;LegalOrganizationForm&gt;</returns>
        public async System.Threading.Tasks.Task<List<LegalOrganizationForm>> AllAsync ()
        {
             ApiResponse<List<LegalOrganizationForm>> localVarResponse = await AllAsyncWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// All This operation returns all entities which are available.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;LegalOrganizationForm&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<LegalOrganizationForm>>> AllAsyncWithHttpInfo ()
        {

            var localVarPath = "/legal-organization-form/all";
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


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("All", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<LegalOrganizationForm>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<LegalOrganizationForm>) ApiClient.Deserialize(localVarResponse, typeof(List<LegalOrganizationForm>)));
        }

        /// <summary>
        /// Find by Country This operation returns all legal organization forms for a given country.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">The country in ISO 3166-1 alpha-2 format, for which all legal organization forms should be returned.</param>
        /// <returns>List&lt;LegalOrganizationForm&gt;</returns>
        public List<LegalOrganizationForm> Country (string code)
        {
             ApiResponse<List<LegalOrganizationForm>> localVarResponse = CountryWithHttpInfo(code);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Find by Country This operation returns all legal organization forms for a given country.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">The country in ISO 3166-1 alpha-2 format, for which all legal organization forms should be returned.</param>
        /// <returns>ApiResponse of List&lt;LegalOrganizationForm&gt;</returns>
        public ApiResponse< List<LegalOrganizationForm> > CountryWithHttpInfo (string code)
        {
            // verify the required parameter 'code' is set
            if (code == null)
            {
                throw new ApiException(400, "Missing required parameter 'code' when calling LegalOrganizationFormService->Country");
            }

            var localVarPath = "/legal-organization-form/country";
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

            if (code != null) localVarQueryParams.Add("code", ApiClient.ParameterToString(code)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Country", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<LegalOrganizationForm>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<LegalOrganizationForm>) ApiClient.Deserialize(localVarResponse, typeof(List<LegalOrganizationForm>)));
        }

        /// <summary>
        /// Find by Country This operation returns all legal organization forms for a given country.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">The country in ISO 3166-1 alpha-2 format, for which all legal organization forms should be returned.</param>
        /// <returns>Task of List&lt;LegalOrganizationForm&gt;</returns>
        public async System.Threading.Tasks.Task<List<LegalOrganizationForm>> CountryAsync (string code)
        {
             ApiResponse<List<LegalOrganizationForm>> localVarResponse = await CountryAsyncWithHttpInfo(code);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Find by Country This operation returns all legal organization forms for a given country.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">The country in ISO 3166-1 alpha-2 format, for which all legal organization forms should be returned.</param>
        /// <returns>Task of ApiResponse (List&lt;LegalOrganizationForm&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<LegalOrganizationForm>>> CountryAsyncWithHttpInfo (string code)
        {
            // verify the required parameter 'code' is set
            if (code == null)
            {
                throw new ApiException(400, "Missing required parameter 'code' when calling LegalOrganizationFormService->Country");
            }

            var localVarPath = "/legal-organization-form/country";
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

            if (code != null) localVarQueryParams.Add("code", ApiClient.ParameterToString(code)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Country", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<LegalOrganizationForm>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<LegalOrganizationForm>) ApiClient.Deserialize(localVarResponse, typeof(List<LegalOrganizationForm>)));
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the legal organization form which should be returned.</param>
        /// <returns>LegalOrganizationForm</returns>
        public LegalOrganizationForm Read (long? id)
        {
             ApiResponse<LegalOrganizationForm> localVarResponse = ReadWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the legal organization form which should be returned.</param>
        /// <returns>ApiResponse of LegalOrganizationForm</returns>
        public ApiResponse< LegalOrganizationForm > ReadWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling LegalOrganizationFormService->Read");
            }

            var localVarPath = "/legal-organization-form/read";
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

            return new ApiResponse<LegalOrganizationForm>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LegalOrganizationForm) ApiClient.Deserialize(localVarResponse, typeof(LegalOrganizationForm)));
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the legal organization form which should be returned.</param>
        /// <returns>Task of LegalOrganizationForm</returns>
        public async System.Threading.Tasks.Task<LegalOrganizationForm> ReadAsync (long? id)
        {
             ApiResponse<LegalOrganizationForm> localVarResponse = await ReadAsyncWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the legal organization form which should be returned.</param>
        /// <returns>Task of ApiResponse (LegalOrganizationForm)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LegalOrganizationForm>> ReadAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling LegalOrganizationFormService->Read");
            }

            var localVarPath = "/legal-organization-form/read";
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

            return new ApiResponse<LegalOrganizationForm>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LegalOrganizationForm) ApiClient.Deserialize(localVarResponse, typeof(LegalOrganizationForm)));
        }

    }
}
