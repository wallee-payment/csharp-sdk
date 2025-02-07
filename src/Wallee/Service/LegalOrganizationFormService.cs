using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.RegularExpressions;
using RestSharp;
using Wallee.Client;
using Wallee.Model;
using Wallee.Util;

namespace Wallee.Service
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;LegalOrganizationForm&gt;</returns>
        List<LegalOrganizationForm> All ();

        /// <summary>
        /// All
        /// </summary>
        /// <remarks>
        /// This operation returns all entities which are available.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;LegalOrganizationForm&gt;</returns>
        ApiResponse<List<LegalOrganizationForm>> AllWithHttpInfo ();



        /// <summary>
        /// Find by Country
        /// </summary>
        /// <remarks>
        /// This operation returns all legal organization forms for a given country.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">The country in ISO 3166-1 alpha-2 format, for which all legal organization forms should be returned.</param>
        /// <returns>List&lt;LegalOrganizationForm&gt;</returns>
        List<LegalOrganizationForm> Country (string code);

        /// <summary>
        /// Find by Country
        /// </summary>
        /// <remarks>
        /// This operation returns all legal organization forms for a given country.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">The country in ISO 3166-1 alpha-2 format, for which all legal organization forms should be returned.</param>
        /// <returns>ApiResponse of List&lt;LegalOrganizationForm&gt;</returns>
        ApiResponse<List<LegalOrganizationForm>> CountryWithHttpInfo (string code);



        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the legal organization form which should be returned.</param>
        /// <returns>LegalOrganizationForm</returns>
        LegalOrganizationForm Read (long? id);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the legal organization form which should be returned.</param>
        /// <returns>ApiResponse of LegalOrganizationForm</returns>
        ApiResponse<LegalOrganizationForm> ReadWithHttpInfo (long? id);



        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LegalOrganizationFormService : ILegalOrganizationFormService
    {
        private Wallee.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LegalOrganizationFormService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LegalOrganizationFormService(Wallee.Client.Configuration configuration = null)
        {
            if (configuration == null) {
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
            return this.Configuration.ApiClient.RestClient.Options.BaseUrl.ToString();
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
        /// All This operation returns all entities which are available.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;LegalOrganizationForm&gt;</returns>
        public List<LegalOrganizationForm> All ()
        {
             ApiResponse<List<LegalOrganizationForm>> localVarResponse = AllWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// All This operation returns all entities which are available.
        
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;LegalOrganizationForm&gt;</returns>
        public ApiResponse< List<LegalOrganizationForm> > AllWithHttpInfo ()
        {

            var localVarPath = "/legal-organization-form/all";
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


			int requestTimeout = this.Configuration.Timeout * 1000;

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
                localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("All", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<LegalOrganizationForm>>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (List<LegalOrganizationForm>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LegalOrganizationForm>)));
        }
        /// <summary>
        /// Find by Country This operation returns all legal organization forms for a given country.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="code">The country in ISO 3166-1 alpha-2 format, for which all legal organization forms should be returned.</param>
        /// <returns>ApiResponse of List&lt;LegalOrganizationForm&gt;</returns>
        public ApiResponse< List<LegalOrganizationForm> > CountryWithHttpInfo (string code)
        {
            // verify the required parameter 'code' is set
            if (code == null)
                throw new ApiException(400, "Missing required parameter 'code' when calling LegalOrganizationFormService->Country");

            var localVarPath = "/legal-organization-form/country";
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

            if (code != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "code", code)); // query parameter

			int requestTimeout = this.Configuration.Timeout * 1000;

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
                localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Country", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<LegalOrganizationForm>>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (List<LegalOrganizationForm>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LegalOrganizationForm>)));
        }
        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the legal organization form which should be returned.</param>
        /// <returns>ApiResponse of LegalOrganizationForm</returns>
        public ApiResponse< LegalOrganizationForm > ReadWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling LegalOrganizationFormService->Read");

            var localVarPath = "/legal-organization-form/read";
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

			int requestTimeout = this.Configuration.Timeout * 1000;

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
                localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Read", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<LegalOrganizationForm>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (LegalOrganizationForm) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LegalOrganizationForm)));
        }
    }
}
