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
    public interface ICountryStateService : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// All
        /// </summary>
        /// <remarks>
        /// This operation returns all states of all countries.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;RestCountryState&gt;</returns>
        List<RestCountryState> All ();

        /// <summary>
        /// All
        /// </summary>
        /// <remarks>
        /// This operation returns all states of all countries.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;RestCountryState&gt;</returns>
        ApiResponse<List<RestCountryState>> AllWithHttpInfo ();

        /// <summary>
        /// Find by Country
        /// </summary>
        /// <remarks>
        /// This operation returns all states for a given country.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">The country code in ISO code two letter format for which all states should be returned.</param>
        /// <returns>List&lt;RestCountryState&gt;</returns>
        List<RestCountryState> Country (string code);

        /// <summary>
        /// Find by Country
        /// </summary>
        /// <remarks>
        /// This operation returns all states for a given country.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">The country code in ISO code two letter format for which all states should be returned.</param>
        /// <returns>ApiResponse of List&lt;RestCountryState&gt;</returns>
        ApiResponse<List<RestCountryState>> CountryWithHttpInfo (string code);

        #endregion Synchronous Operations
        #region Asynchronous Operations

        /// <summary>
        /// All
        /// </summary>
        /// <remarks>
        /// This operation returns all states of all countries.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;RestCountryState&gt;</returns>
        System.Threading.Tasks.Task<List<RestCountryState>> AllAsync ();

        /// <summary>
        /// All
        /// </summary>
        /// <remarks>
        /// This operation returns all states of all countries.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;RestCountryState&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<RestCountryState>>> AllAsyncWithHttpInfo ();

        /// <summary>
        /// Find by Country
        /// </summary>
        /// <remarks>
        /// This operation returns all states for a given country.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">The country code in ISO code two letter format for which all states should be returned.</param>
        /// <returns>Task of List&lt;RestCountryState&gt;</returns>
        System.Threading.Tasks.Task<List<RestCountryState>> CountryAsync (string code);

        /// <summary>
        /// Find by Country
        /// </summary>
        /// <remarks>
        /// This operation returns all states for a given country.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">The country code in ISO code two letter format for which all states should be returned.</param>
        /// <returns>Task of ApiResponse (List&lt;RestCountryState&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<RestCountryState>>> CountryAsyncWithHttpInfo (string code);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CountryStateService : ICountryStateService
    {
        private readonly Customweb.Wallee.Client.ExceptionFactory _exceptionFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="CountryStateService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CountryStateService(Configuration configuration = null)
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
        /// All This operation returns all states of all countries.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;RestCountryState&gt;</returns>
        public List<RestCountryState> All ()
        {
             ApiResponse<List<RestCountryState>> localVarResponse = AllWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// All This operation returns all states of all countries.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;RestCountryState&gt;</returns>
        public ApiResponse< List<RestCountryState> > AllWithHttpInfo ()
        {

            var localVarPath = "/country-state/all";
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

            return new ApiResponse<List<RestCountryState>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<RestCountryState>) ApiClient.Deserialize(localVarResponse, typeof(List<RestCountryState>)));
        }

        /// <summary>
        /// All This operation returns all states of all countries.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;RestCountryState&gt;</returns>
        public async System.Threading.Tasks.Task<List<RestCountryState>> AllAsync ()
        {
             ApiResponse<List<RestCountryState>> localVarResponse = await AllAsyncWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// All This operation returns all states of all countries.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;RestCountryState&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<RestCountryState>>> AllAsyncWithHttpInfo ()
        {

            var localVarPath = "/country-state/all";
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

            return new ApiResponse<List<RestCountryState>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<RestCountryState>) ApiClient.Deserialize(localVarResponse, typeof(List<RestCountryState>)));
        }

        /// <summary>
        /// Find by Country This operation returns all states for a given country.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">The country code in ISO code two letter format for which all states should be returned.</param>
        /// <returns>List&lt;RestCountryState&gt;</returns>
        public List<RestCountryState> Country (string code)
        {
             ApiResponse<List<RestCountryState>> localVarResponse = CountryWithHttpInfo(code);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Find by Country This operation returns all states for a given country.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">The country code in ISO code two letter format for which all states should be returned.</param>
        /// <returns>ApiResponse of List&lt;RestCountryState&gt;</returns>
        public ApiResponse< List<RestCountryState> > CountryWithHttpInfo (string code)
        {
            // verify the required parameter 'code' is set
            if (code == null)
            {
                throw new ApiException(400, "Missing required parameter 'code' when calling CountryStateService->Country");
            }

            var localVarPath = "/country-state/country";
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

            return new ApiResponse<List<RestCountryState>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<RestCountryState>) ApiClient.Deserialize(localVarResponse, typeof(List<RestCountryState>)));
        }

        /// <summary>
        /// Find by Country This operation returns all states for a given country.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">The country code in ISO code two letter format for which all states should be returned.</param>
        /// <returns>Task of List&lt;RestCountryState&gt;</returns>
        public async System.Threading.Tasks.Task<List<RestCountryState>> CountryAsync (string code)
        {
             ApiResponse<List<RestCountryState>> localVarResponse = await CountryAsyncWithHttpInfo(code);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Find by Country This operation returns all states for a given country.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">The country code in ISO code two letter format for which all states should be returned.</param>
        /// <returns>Task of ApiResponse (List&lt;RestCountryState&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<RestCountryState>>> CountryAsyncWithHttpInfo (string code)
        {
            // verify the required parameter 'code' is set
            if (code == null)
            {
                throw new ApiException(400, "Missing required parameter 'code' when calling CountryStateService->Country");
            }

            var localVarPath = "/country-state/country";
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

            return new ApiResponse<List<RestCountryState>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<RestCountryState>) ApiClient.Deserialize(localVarResponse, typeof(List<RestCountryState>)));
        }

    }
}
