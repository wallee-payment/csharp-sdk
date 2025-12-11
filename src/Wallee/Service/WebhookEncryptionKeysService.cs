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
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Wallee.Client;
using System.Collections.Concurrent;
using System.Text.RegularExpressions;
using Wallee.Util;
using Wallee.Model;

namespace Wallee.Service
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWebhookEncryptionKeysServiceSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieve a webhook encryption key
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>string</returns>
        string GetWebhooksEncryptionKeysId(string id, int operationIndex = 0);

        /// <summary>
        /// Retrieve a webhook encryption key
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> GetWebhooksEncryptionKeysIdWithHttpInfo(string id, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWebhookEncryptionKeysService : IWebhookEncryptionKeysServiceSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class WebhookEncryptionKeysService : IWebhookEncryptionKeysService
    {
        private static readonly ConcurrentDictionary<string, string> _cache =
            new ConcurrentDictionary<string, string>();

        private Wallee.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEncryptionKeysService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public WebhookEncryptionKeysService(Wallee.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            this.Configuration = configuration;
            this.Client = new Wallee.Client.ApiClient(this.Configuration);
            ExceptionFactory = Wallee.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEncryptionKeysService"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public WebhookEncryptionKeysService(Wallee.Client.ISynchronousClient client, Wallee.Client.IReadableConfiguration configuration)
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
        /// Retrieve a webhook encryption key 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>string</returns>
        public string GetWebhooksEncryptionKeysId(string id, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<string> localVarResponse = GetWebhooksEncryptionKeysIdWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a webhook encryption key 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of string</returns>
        public Wallee.Client.ApiResponse<string> GetWebhooksEncryptionKeysIdWithHttpInfo(string id, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Wallee.Client.ApiException(400, "Missing required parameter 'id' when calling WebhookEncryptionKeysService->GetWebhooksEncryptionKeysId");
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
            var localVarMultipartFormData = localVarContentType == "multipart/form-data";
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Wallee.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("id", Wallee.Client.ClientUtils.ParameterToString(id)); // path parameter

            localVarRequestOptions.Operation = "WebhookEncryptionKeysService.GetWebhooksEncryptionKeysId";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Get<string>("/webhooks/encryption-keys/{id}",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetWebhooksEncryptionKeysId", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

            /// <summary>
            /// Verify content of a webhook.
            /// </summary>
            /// <exception cref="Wallee.Client.WalleeSdkException">Thrown when validation fails or public key is not found.</exception>
            /// <param name="signatureHeader">The content of the X-Signature header.</param>
            /// <param name="content">The content body.</param>
            /// <returns>true if the content body conforms with the signature header</returns>
            public bool IsContentValid(string signatureHeader, string content)
            {
                // Regular expression to extract algorithm, keyId, and signature from the signatureHeader
                string regex = @"^algorithm=([a-zA-Z0-9]+),\skeyId=([a-z0-9\-]+),\s{1}signature=([a-zA-Z0-9+/=]+)$";
                Regex pattern = new Regex(regex);
                Match matcher = pattern.Match(signatureHeader);

                if (matcher.Success)
                {
                    string signatureAlgorithm = matcher.Groups[1].Value;
                    string publicKeyId = matcher.Groups[2].Value;
                    string contentSignature = matcher.Groups[3].Value;

                    if (!_cache.TryGetValue(publicKeyId, out string publicKey))
                    {
                        try
                        {
                            publicKey = GetWebhooksEncryptionKeysId(publicKeyId);
                        }
                        catch (ApiException ex)
                        {
                            throw new ApiException(
                                ex.ErrorCode,
                                $"Could not retrieve public key with ID: {publicKeyId}. Because: {ex.Message}");
                        }

                        if (string.IsNullOrEmpty(publicKey))
                        {
                            throw new WalleeSdkException(
                                SdkExceptionErrorCodes.UNKNOWN_WEBHOOK_ENCRYPTION_PUBLIC_KEY,
                                $"Public key not found for ID: {publicKeyId}");
                        }

                        _cache.TryAdd(publicKeyId, publicKey);
                    }

                    return EncryptionUtil.IsContentValid(content, contentSignature, publicKey, signatureAlgorithm);
                }

                throw new WalleeSdkException(
                    SdkExceptionErrorCodes.INVALID_WEBHOOK_ENCRYPTION_HEADER_FORMAT,
                    "Invalid webhook signature header. Expected format: 'algorithm=<algorithm>, keyId=<keyId>, signature=<signature>'");
            }

    }
}
