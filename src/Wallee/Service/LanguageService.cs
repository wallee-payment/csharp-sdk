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
    public interface ILanguageService : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// All
        /// </summary>
        /// <remarks>
        /// This operation returns all languages.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;RestLanguage&gt;</returns>
        List<RestLanguage> All ();

        /// <summary>
        /// All
        /// </summary>
        /// <remarks>
        /// This operation returns all languages.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;RestLanguage&gt;</returns>
        ApiResponse<List<RestLanguage>> AllWithHttpInfo ();



        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LanguageService : ILanguageService
    {
        private Wallee.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LanguageService(Wallee.Client.Configuration configuration = null)
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
        /// All This operation returns all languages.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;RestLanguage&gt;</returns>
        public List<RestLanguage> All ()
        {
             ApiResponse<List<RestLanguage>> localVarResponse = AllWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// All This operation returns all languages.
        
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;RestLanguage&gt;</returns>
        public ApiResponse< List<RestLanguage> > AllWithHttpInfo ()
        {

            var localVarPath = "/language/all";
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

            return new ApiResponse<List<RestLanguage>>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (List<RestLanguage>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<RestLanguage>)));
        }
    }
}
