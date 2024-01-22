using System;
using System.Collections.Concurrent;
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
    public interface IWebhookEncryptionService : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the key version.</param>
        /// <returns>WebhookEncryptionPublicKey</returns>
        WebhookEncryptionPublicKey Read (string id);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the key version.</param>
        /// <returns>ApiResponse of WebhookEncryptionPublicKey</returns>
        ApiResponse<WebhookEncryptionPublicKey> ReadWithHttpInfo (string id);

        /// <summary>
        /// Verify content of a webhook.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when when private key can not be found</exception>
        /// <param name="signatureHeader">The content of the X-Signature header.</param>
        /// <param name="content">The content body.</param>
        /// <returns>true if the content body conforms with the signature header</returns>
        bool IsContentValid(string signatureHeader, string content);


        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class WebhookEncryptionService : IWebhookEncryptionService
    {
        private static readonly ConcurrentDictionary<string, WebhookEncryptionPublicKey> cache =
                new ConcurrentDictionary<string, WebhookEncryptionPublicKey>();

        private Wallee.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEncryptionService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public WebhookEncryptionService(Wallee.Client.Configuration configuration = null)
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
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the key version.</param>
        /// <returns>WebhookEncryptionPublicKey</returns>
        public WebhookEncryptionPublicKey Read (string id)
        {
             ApiResponse<WebhookEncryptionPublicKey> localVarResponse = ReadWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the key version.</param>
        /// <returns>ApiResponse of WebhookEncryptionPublicKey</returns>
        public ApiResponse< WebhookEncryptionPublicKey > ReadWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling WebhookEncryptionService->Read");

            var localVarPath = "/webhook-encryption/read";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content type
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter

			
            int requestTimeout = this.Configuration.Timeout * 1000;

                // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Read", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<WebhookEncryptionPublicKey>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (WebhookEncryptionPublicKey) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebhookEncryptionPublicKey)));
        }
        /// <summary>
        /// Verify content of a webhook.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when when private key can not be found</exception>
        /// <param name="signatureHeader">The content of the X-Signature header.</param>
        /// <param name="content">The content body.</param>
        /// <returns>true if the content body conforms with the signature header</returns>
        public bool IsContentValid(string signatureHeader, string content)
        {
            string regex = "^algorithm=([a-zA-Z0-9]+),\\skeyId=([a-z0-9\\-]+),\\s{1}signature=([a-zA-Z0-9+\\/=]+)$";
            Regex pattern = new Regex(regex);
            Match matcher = pattern.Match(signatureHeader);
            if (matcher.Success)
            {
                string signatureAlgorithm = matcher.Groups[1].Value;
                string publicKeyId = matcher.Groups[2].Value;
                string contentSignature = matcher.Groups[3].Value;

                if (!cache.TryGetValue(publicKeyId, out WebhookEncryptionPublicKey publicKey))
                {
                    publicKey = Read(publicKeyId);
                    if (publicKey == null)
                    {
                        throw new ApiException(404, "WebhookEncryptionKey not found");
                    }
                    cache.TryAdd(publicKey.Id, publicKey);
                }

                return EncryptionUtil.IsContentValid(content, contentSignature, publicKey, signatureAlgorithm);
            }
            throw new ArgumentException("Invalid signature header. Expected format: 'algorithm=<algorithm>, keyId=<keyId>, signature=<signature>'", "signatureHeader");
        }
    }
}
