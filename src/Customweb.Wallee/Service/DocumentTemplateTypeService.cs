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
    public interface IDocumentTemplateTypeService : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// All
        /// </summary>
        /// <remarks>
        /// This operation returns all entities which are available.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;DocumentTemplateType&gt;</returns>
        List<DocumentTemplateType> All ();

        /// <summary>
        /// All
        /// </summary>
        /// <remarks>
        /// This operation returns all entities which are available.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;DocumentTemplateType&gt;</returns>
        ApiResponse<List<DocumentTemplateType>> AllWithHttpInfo ();

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the document template type which should be returned.</param>
        /// <returns>DocumentTemplateType</returns>
        DocumentTemplateType Read (long? id);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the document template type which should be returned.</param>
        /// <returns>ApiResponse of DocumentTemplateType</returns>
        ApiResponse<DocumentTemplateType> ReadWithHttpInfo (long? id);

        #endregion Synchronous Operations
        #region Asynchronous Operations

        /// <summary>
        /// All
        /// </summary>
        /// <remarks>
        /// This operation returns all entities which are available.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;DocumentTemplateType&gt;</returns>
        System.Threading.Tasks.Task<List<DocumentTemplateType>> AllAsync ();

        /// <summary>
        /// All
        /// </summary>
        /// <remarks>
        /// This operation returns all entities which are available.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;DocumentTemplateType&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<DocumentTemplateType>>> AllAsyncWithHttpInfo ();

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the document template type which should be returned.</param>
        /// <returns>Task of DocumentTemplateType</returns>
        System.Threading.Tasks.Task<DocumentTemplateType> ReadAsync (long? id);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the document template type which should be returned.</param>
        /// <returns>Task of ApiResponse (DocumentTemplateType)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentTemplateType>> ReadAsyncWithHttpInfo (long? id);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DocumentTemplateTypeService : IDocumentTemplateTypeService
    {
        private readonly Customweb.Wallee.Client.ExceptionFactory _exceptionFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentTemplateTypeService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DocumentTemplateTypeService(Configuration configuration = null)
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
        /// <returns>List&lt;DocumentTemplateType&gt;</returns>
        public List<DocumentTemplateType> All ()
        {
             ApiResponse<List<DocumentTemplateType>> localVarResponse = AllWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// All This operation returns all entities which are available.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;DocumentTemplateType&gt;</returns>
        public ApiResponse< List<DocumentTemplateType> > AllWithHttpInfo ()
        {

            var localVarPath = "/document-template-type/all";
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
                "*/*"
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

            return new ApiResponse<List<DocumentTemplateType>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<DocumentTemplateType>) ApiClient.Deserialize(localVarResponse, typeof(List<DocumentTemplateType>)));
        }

        /// <summary>
        /// All This operation returns all entities which are available.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;DocumentTemplateType&gt;</returns>
        public async System.Threading.Tasks.Task<List<DocumentTemplateType>> AllAsync ()
        {
             ApiResponse<List<DocumentTemplateType>> localVarResponse = await AllAsyncWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// All This operation returns all entities which are available.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;DocumentTemplateType&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<DocumentTemplateType>>> AllAsyncWithHttpInfo ()
        {

            var localVarPath = "/document-template-type/all";
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
                "*/*"
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

            return new ApiResponse<List<DocumentTemplateType>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<DocumentTemplateType>) ApiClient.Deserialize(localVarResponse, typeof(List<DocumentTemplateType>)));
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the document template type which should be returned.</param>
        /// <returns>DocumentTemplateType</returns>
        public DocumentTemplateType Read (long? id)
        {
             ApiResponse<DocumentTemplateType> localVarResponse = ReadWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the document template type which should be returned.</param>
        /// <returns>ApiResponse of DocumentTemplateType</returns>
        public ApiResponse< DocumentTemplateType > ReadWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling DocumentTemplateTypeService->Read");
            }

            var localVarPath = "/document-template-type/read";
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
                "*/*"
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

            return new ApiResponse<DocumentTemplateType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentTemplateType) ApiClient.Deserialize(localVarResponse, typeof(DocumentTemplateType)));
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the document template type which should be returned.</param>
        /// <returns>Task of DocumentTemplateType</returns>
        public async System.Threading.Tasks.Task<DocumentTemplateType> ReadAsync (long? id)
        {
             ApiResponse<DocumentTemplateType> localVarResponse = await ReadAsyncWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the document template type which should be returned.</param>
        /// <returns>Task of ApiResponse (DocumentTemplateType)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentTemplateType>> ReadAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling DocumentTemplateTypeService->Read");
            }

            var localVarPath = "/document-template-type/read";
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
                "*/*"
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

            return new ApiResponse<DocumentTemplateType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentTemplateType) ApiClient.Deserialize(localVarResponse, typeof(DocumentTemplateType)));
        }

    }
}
