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
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestSharp;
using RestSharp.Serializers;
using RestSharpMethod = RestSharp.Method;
using FileIO = System.IO.File;
using Wallee.Client.Auth;
using Wallee.Model;

namespace Wallee.Client
{
    /// <summary>
    /// Allows RestSharp to Serialize/Deserialize JSON using our custom logic, but only when ContentType is JSON.
    /// </summary>
    internal class CustomJsonCodec : IRestSerializer, ISerializer, IDeserializer
    {
        private readonly IReadableConfiguration _configuration;
        private readonly JsonSerializerSettings _serializerSettings = new JsonSerializerSettings
        {
            // OpenAPI generated types generally hide default constructors.
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy
                {
                    OverrideSpecifiedNames = false
                }
            }
        };

        public CustomJsonCodec(IReadableConfiguration configuration)
        {
            _configuration = configuration;
        }

        public CustomJsonCodec(JsonSerializerSettings serializerSettings, IReadableConfiguration configuration)
        {
            _serializerSettings = serializerSettings;
            _configuration = configuration;
        }

        /// <summary>
        /// Serialize the object into a JSON string.
        /// </summary>
        /// <param name="obj">Object to be serialized.</param>
        /// <returns>A JSON string.</returns>
        public string Serialize(object obj)
        {
            if (obj != null && obj is AbstractOpenAPISchema)
            {
                // the object to be serialized is an oneOf/anyOf schema
                return ((AbstractOpenAPISchema)obj).ToJson();
            }
            else
            {
                return JsonConvert.SerializeObject(obj, _serializerSettings);
            }
        }

        public string Serialize(Parameter bodyParameter) => Serialize(bodyParameter.Value);

        public T Deserialize<T>(RestResponse response)
        {
            var result = (T)Deserialize(response, typeof(T));
            return result;
        }

        /// <summary>
        /// Deserialize the JSON string into a proper object.
        /// </summary>
        /// <param name="response">The HTTP response.</param>
        /// <param name="type">Object type.</param>
        /// <returns>Object representation of the JSON string.</returns>
        internal object Deserialize(RestResponse response, Type type)
        {
            if (type == typeof(byte[])) // return byte array
            {
                return response.RawBytes;
            }

            // TODO: ? if (type.IsAssignableFrom(typeof(Stream)))
            if (type == typeof(Stream))
            {
                var bytes = response.RawBytes;
                if (response.Headers != null)
                {
                    var filePath = string.IsNullOrEmpty(_configuration.TempFolderPath)
                        ? Path.GetTempPath()
                        : _configuration.TempFolderPath;
                    var regex = new Regex(@"Content-Disposition=.*filename=['""]?([^'""\s]+)['""]?$");
                    foreach (var header in response.Headers)
                    {
                        var match = regex.Match(header.ToString());
                        if (match.Success)
                        {
                            string fileName = filePath + ClientUtils.SanitizeFilename(match.Groups[1].Value.Replace("\"", "").Replace("'", ""));
                            FileIO.WriteAllBytes(fileName, bytes);
                            return new FileStream(fileName, FileMode.Open);
                        }
                    }
                }
                var stream = new MemoryStream(bytes);
                return stream;
            }

            if (type.Name.StartsWith("System.Nullable`1[[System.DateTime")) // return a datetime object
            {
                return DateTime.Parse(response.Content, null, DateTimeStyles.RoundtripKind);
            }

            if (type == typeof(string) || type.Name.StartsWith("System.Nullable")) // return primitive type
            {
                return Convert.ChangeType(response.Content, type);
            }

            // at this point, it must be a model (json)
            try
            {
                return JsonConvert.DeserializeObject(response.Content, type, _serializerSettings);
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }

        public ISerializer Serializer => this;
        public IDeserializer Deserializer => this;

        public string[] AcceptedContentTypes => ContentType.JsonAccept;

        public SupportsContentType SupportsContentType => contentType =>
            contentType.Value.EndsWith("json", StringComparison.InvariantCultureIgnoreCase) ||
            contentType.Value.EndsWith("javascript", StringComparison.InvariantCultureIgnoreCase);

        public ContentType ContentType { get; set; } = ContentType.Json;

        public DataFormat DataFormat => DataFormat.Json;
    }
    /// <summary>
    /// Provides a default implementation of an Api client (ONLY synchronous implementations, asynchronous - not supported),
    /// encapsulating general REST accessor use cases.
    /// </summary>
    public partial class ApiClient : ISynchronousClient
    {
        private readonly string _baseUrl;

        private readonly IDictionary<string, IAuthentication> _authentications;

        /// <summary>
        /// Specifies the settings on a <see cref="JsonSerializer" /> object.
        /// These settings can be adjusted to accommodate custom serialization rules.
        /// </summary>
        public JsonSerializerSettings SerializerSettings { get; set; } = new JsonSerializerSettings
        {
            // OpenAPI generated types generally hide default constructors.
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy
                {
                    OverrideSpecifiedNames = false
                }
            }
        };

        /// <summary>
        /// Allows for extending request processing for <see cref="ApiClient"/> generated code.
        /// </summary>
        /// <param name="request">The RestSharp request object</param>
        partial void InterceptRequest(RestRequest request);

        /// <summary>
        /// Allows for extending response processing for <see cref="ApiClient"/> generated code.
        /// </summary>
        /// <param name="request">The RestSharp request object</param>
        /// <param name="response">The RestSharp response object</param>
        partial void InterceptResponse(RestRequest request, RestResponse response);

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" />
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <exception cref="ArgumentException"></exception>
        public ApiClient(IReadableConfiguration configuration)
        {
            if (string.IsNullOrEmpty(configuration.BasePath))
                throw new ArgumentException("basePath cannot be empty");

            _baseUrl = configuration.BasePath;
            _authentications = new Dictionary<string, IAuthentication>();

            // Setup authentications (key: authentication name, value: authentication).
            if (!string.IsNullOrEmpty(configuration.AuthenticationKey))
            {
                _authentications["jwtAuth"] =
                    new HttpBearerAuth(configuration.ApplicationUserId, configuration.AuthenticationKey);
            }
        }

        /// <summary>
        /// Constructs the RestSharp version of the http method
        /// </summary>
        /// <param name="method">Swagger Client Custom HttpMethod</param>
        /// <returns>RestSharp's HttpMethod instance.</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private RestSharpMethod Method(HttpMethod method)
        {
            RestSharpMethod other;
            switch (method)
            {
                case HttpMethod.GET:
                    other = RestSharpMethod.Get;
                    break;
                case HttpMethod.POST:
                    other = RestSharpMethod.Post;
                    break;
                case HttpMethod.PUT:
                    other = RestSharpMethod.Put;
                    break;
                case HttpMethod.DELETE:
                    other = RestSharpMethod.Delete;
                    break;
                case HttpMethod.HEAD:
                    other = RestSharpMethod.Head;
                    break;
                case HttpMethod.OPTIONS:
                    other = RestSharpMethod.Options;
                    break;
                case HttpMethod.PATCH:
                    other = RestSharpMethod.Patch;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("method", method, null);
            }

            return other;
        }

        /// <summary>
        /// Provides all logic for constructing a new RestSharp <see cref="RestRequest"/>.
        /// At this point, all information for querying the service is known. 
        /// Here, it is simply mapped into the RestSharp request.
        /// </summary>
        /// <param name="method">The http verb.</param>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="configuration">A per-request configuration object.</param>
        /// <returns>[private] A new RestRequest instance.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        private RestRequest NewRequest(
            HttpMethod method,
            string path,
            RequestOptions options,
            IReadableConfiguration configuration)
        {
            if (path == null) throw new ArgumentNullException("path");
            if (options == null) throw new ArgumentNullException("options");
            if (configuration == null) throw new ArgumentNullException("configuration");

            RestRequest request = new RestRequest(path, Method(method));

            if (options.PathParameters != null)
            {
                foreach (var pathParam in options.PathParameters)
                {
                    request.AddParameter(pathParam.Key, pathParam.Value, ParameterType.UrlSegment);
                }
            }

            if (options.QueryParameters != null)
            {
                foreach (var queryParam in options.QueryParameters)
                {
                    foreach (var value in queryParam.Value)
                    {
                        string encodedValue = Uri.EscapeDataString(value);
                        request.AddQueryParameter(queryParam.Key, encodedValue, false);
                    }
                }
            }

            if (configuration.DefaultHeaders != null)
            {
                foreach (var headerParam in configuration.DefaultHeaders)
                {
                    request.AddHeader(headerParam.Key, headerParam.Value);
                }
            }

            // Add additional meta headers
            AddMetaHeaders(request);

            if (options.HeaderParameters != null)
            {
                foreach (var headerParam in options.HeaderParameters)
                {
                    foreach (var value in headerParam.Value)
                    {
                        request.AddHeader(headerParam.Key, value);
                    }
                }
            }

            UpdateParamsForAuth(path, method, options.PathParameters, options.QueryParameters, request);

            if (options.FormParameters != null)
            {
                foreach (var formParam in options.FormParameters)
                {
                    request.AddParameter(formParam.Key, formParam.Value);
                }
            }

            if (options.Data != null)
            {
                if (options.Data is Stream stream)
                {
                    var contentType = "application/octet-stream";
                    if (options.HeaderParameters != null)
                    {
                        var contentTypes = options.HeaderParameters["Content-Type"];
                        contentType = contentTypes[0];
                    }

                    var bytes = ClientUtils.ReadAsBytes(stream);
                    request.AddParameter(contentType, bytes, ParameterType.RequestBody);
                }
                else
                {
                    if (options.HeaderParameters != null)
                    {
                        var contentTypes = options.HeaderParameters["Content-Type"];
                        if (contentTypes == null || contentTypes.Any(header => header.Contains("application/json")))
                        {
                            request.RequestFormat = DataFormat.Json;
                        }
                        else
                        {
                            // TODO: Generated client user should add additional handlers. RestSharp only supports XML and JSON, with XML as default.
                        }
                    }
                    else
                    {
                        // Here, we'll assume JSON APIs are more common. XML can be forced by adding produces/consumes to openapi spec explicitly.
                        request.RequestFormat = DataFormat.Json;
                    }

                    request.AddJsonBody(options.Data);
                }
            }

            if (options.FileParameters != null)
            {
                foreach (var fileParam in options.FileParameters)
                {
                    foreach (var file in fileParam.Value)
                    {
                        var bytes = ClientUtils.ReadAsBytes(file);
                        var fileStream = file as FileStream;
                        if (fileStream != null)
                            request.AddFile(fileParam.Key, bytes, Path.GetFileName(fileStream.Name));
                        else
                            request.AddFile(fileParam.Key, bytes, "no_file_name_provided");
                    }
                }
            }

            return request;
        }

        /// <summary>
        /// Transforms a RestResponse instance into a new ApiResponse instance.
        /// At this point, we have a concrete http response from the service.
        /// Here, it is simply mapped into the [public] ApiResponse object.
        /// </summary>
        /// <param name="response">The RestSharp response object</param>
        /// <returns>A new ApiResponse instance.</returns>
        private ApiResponse<T> ToApiResponse<T>(RestResponse<T> response)
        {
            T result = response.Data;
            string rawContent = response.Content;

            var transformed = new ApiResponse<T>(response.StatusCode, new Multimap<string, string>(), result, rawContent)
            {
                ErrorText = response.ErrorMessage,
                Cookies = new List<Cookie>()
            };

            if (response.Headers != null)
            {
                foreach (var responseHeader in response.Headers)
                {
                    transformed.Headers.Add(responseHeader.Name, ClientUtils.ParameterToString(responseHeader.Value));
                }
            }

            if (response.ContentHeaders != null)
            {
                foreach (var responseHeader in response.ContentHeaders)
                {
                    transformed.Headers.Add(responseHeader.Name, ClientUtils.ParameterToString(responseHeader.Value));
                }
            }

            if (response.Cookies != null)
            {
                foreach (var responseCookies in response.Cookies.Cast<Cookie>())
                {
                    transformed.Cookies.Add(
                        new Cookie(
                            responseCookies.Name,
                            responseCookies.Value,
                            responseCookies.Path,
                            responseCookies.Domain)
                        );
                }
            }

            return transformed;
        }

        /// <summary>
        /// Executes the HTTP request for the current service.
        /// Based on functions received it can be async or sync.
        /// </summary>
        /// <param name="getResponse">Local function that executes http request and returns http response.</param>
        /// <param name="setOptions">Local function to specify options for the service.</param>        
        /// <param name="request">The RestSharp request object</param>
        /// <param name="options">The RestSharp options object</param>
        /// <param name="requestTimeout">A per-request (connection) timeout in seconds.</param>
        /// <param name="configuration">A per-request configuration object.</param>
        /// <returns>A new ApiResponse instance.</returns>
        private async Task<ApiResponse<T>> ExecClientAsync<T>(Func<RestClient, Task<RestResponse<T>>> getResponse,
            Action<RestClientOptions> setOptions, RestRequest request, RequestOptions options, int requestTimeout,
            IReadableConfiguration configuration)
        {
            var baseUrl = configuration.GetOperationServerUrl(options.Operation, options.OperationIndex) ?? _baseUrl;

            // Prioritizes the request timeout provided, falling back to the configuration as a secondary option.
            var resolveRequestTimeout = requestTimeout > 0 ? requestTimeout : configuration.Timeout;

            var clientOptions = new RestClientOptions(baseUrl)
            {
                ClientCertificates = configuration.ClientCertificates,
                Timeout = TimeSpan.FromSeconds(resolveRequestTimeout),
                Proxy = configuration.Proxy,
                UserAgent = configuration.UserAgent,
                UseDefaultCredentials = configuration.UseDefaultCredentials,
                RemoteCertificateValidationCallback = configuration.RemoteCertificateValidationCallback
            };
            setOptions(clientOptions);

            using (RestClient client = new RestClient(clientOptions,
                configureSerialization: serializerConfig => serializerConfig.UseSerializer(() => new CustomJsonCodec(SerializerSettings, configuration))))
            {
                InterceptRequest(request);

                RestResponse<T> response = await getResponse(client);

                // if the response type is oneOf/anyOf, call FromJSON to deserialize the data
                if (typeof(AbstractOpenAPISchema).IsAssignableFrom(typeof(T)))
                {
                    try
                    {
                        response.Data = (T)typeof(T).GetMethod("FromJson").Invoke(null, new object[] { response.Content });
                    }
                    catch (Exception ex)
                    {
                        throw ex.InnerException != null ? ex.InnerException : ex;
                    }
                }
                else if (typeof(T).Name == "Stream") // for binary response
                {
                    response.Data = (T)(object)new MemoryStream(response.RawBytes);
                }
                else if (typeof(T).Name == "Byte[]") // for byte response
                {
                    response.Data = (T)(object)response.RawBytes;
                }
                else if (typeof(T).Name == "String") // for string response
                {
                    response.Data = (T)(object)response.Content;
                }

                InterceptResponse(request, response);

                var result = ToApiResponse(response);
                if (response.ErrorMessage != null)
                {
                    result.ErrorText = response.ErrorMessage;
                }

                if (response.Cookies != null && response.Cookies.Count > 0)
                {
                    if (result.Cookies == null) result.Cookies = new List<Cookie>();
                    foreach (var restResponseCookie in response.Cookies.Cast<Cookie>())
                    {
                        var cookie = new Cookie(
                            restResponseCookie.Name,
                            restResponseCookie.Value,
                            restResponseCookie.Path,
                            restResponseCookie.Domain
                        )
                        {
                            Comment = restResponseCookie.Comment,
                            CommentUri = restResponseCookie.CommentUri,
                            Discard = restResponseCookie.Discard,
                            Expired = restResponseCookie.Expired,
                            Expires = restResponseCookie.Expires,
                            HttpOnly = restResponseCookie.HttpOnly,
                            Port = restResponseCookie.Port,
                            Secure = restResponseCookie.Secure,
                            Version = restResponseCookie.Version
                        };

                        result.Cookies.Add(cookie);
                    }
                }
                return result;
            }
        }

        private ApiResponse<T> Exec<T>(RestRequest request, RequestOptions options, int requestTimeout,
            IReadableConfiguration configuration)
        {
            Action<RestClientOptions> setOptions = (clientOptions) =>
            {
                var cookies = new CookieContainer();

                if (options.Cookies != null && options.Cookies.Count > 0)
                {
                    foreach (var cookie in options.Cookies)
                    {
                        cookies.Add(new Cookie(cookie.Name, cookie.Value));
                    }
                }
                clientOptions.CookieContainer = cookies;
            };

            Func<RestClient, Task<RestResponse<T>>> getResponse = (client) =>
            {
                // Directly execute the request without retry logic
                return Task.FromResult(client.Execute<T>(request));
            };

            return ExecClientAsync(getResponse, setOptions, request, options, requestTimeout, configuration)
                .GetAwaiter()
                .GetResult();
        }

        #region ISynchronousClient
        /// <summary>
        /// Make the HTTP GET request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="requestTimeout">The per-request (read) timeout in seconds.</param>
        /// <param name="config">A per-request configuration object.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Get<T>(string path, RequestOptions options, int requestTimeout,
            IReadableConfiguration config)
        {
            return Exec<T>(NewRequest(HttpMethod.GET, path, options, config), options, requestTimeout, config);
        }

        /// <summary>
        /// Make the HTTP POST request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="requestTimeout">The per-request (read) timeout in seconds.</param>
        /// <param name="config">A per-request configuration object.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Post<T>(string path, RequestOptions options, int requestTimeout,
            IReadableConfiguration config)
        {
            return Exec<T>(NewRequest(HttpMethod.POST, path, options, config), options, requestTimeout, config);
        }

        /// <summary>
        /// Make the HTTP PUT request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="requestTimeout">The per-request (read) timeout in seconds.</param>
        /// <param name="config">A per-request configuration object.</param
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Put<T>(string path, RequestOptions options, int requestTimeout,
            IReadableConfiguration config)
        {
            return Exec<T>(NewRequest(HttpMethod.PUT, path, options, config), options, requestTimeout, config);
        }

        /// <summary>
        /// Make the HTTP DELETE request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="requestTimeout">The per-request (read) timeout in seconds.</param>
        /// <param name="config">A per-request configuration object.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Delete<T>(string path, RequestOptions options, int requestTimeout,
            IReadableConfiguration config)
        {
            return Exec<T>(NewRequest(HttpMethod.DELETE, path, options, config), options, requestTimeout, config);
        }

        /// <summary>
        /// Make the HTTP HEAD request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="requestTimeout">The per-request (read) timeout in seconds.</param>
        /// <param name="config">A per-request configuration object.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Head<T>(string path, RequestOptions options, int requestTimeout,
            IReadableConfiguration config)
        {
            return Exec<T>(NewRequest(HttpMethod.HEAD, path, options, config), options, requestTimeout, config);
        }

        /// <summary>
        /// Make the HTTP OPTION request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="requestTimeout">The per-request (read) timeout in seconds.</param>
        /// <param name="config">A per-request configuration object.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Options<T>(string path, RequestOptions options, int requestTimeout,
            IReadableConfiguration config)
        {
            return Exec<T>(NewRequest(HttpMethod.OPTIONS, path, options, config), options, requestTimeout, config);
        }

        /// <summary>
        /// Make the HTTP PATCH request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="requestTimeout">The per-request (read) timeout in seconds.</param>
        /// <param name="config">A per-request configuration object.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Patch<T>(string path, RequestOptions options, int requestTimeout,
            IReadableConfiguration config)
        {
            return Exec<T>(NewRequest(HttpMethod.PATCH, path, options, config), options, requestTimeout, config);
        }
        #endregion ISynchronousClient

        #region Methods
        private void UpdateParamsForAuth(string path, HttpMethod method, Dictionary<string, string> pathParameters,
            Multimap<string, string> queryParameters, RestRequest request)
        {
            foreach (var auth in _authentications.Values)
            {
                var authHeaderParam = auth.GetAuthParam(path, method, pathParameters, queryParameters);
                request.AddHeader(authHeaderParam.Name, authHeaderParam.Value);
            }
        }

        private static void AddMetaHeaders(RestRequest request)
        {
            request.AddHeader("x-meta-sdk-version", "10.0.0");
            request.AddHeader("x-meta-sdk-language", "csharp");
            request.AddHeader("x-meta-sdk-provider", "wallee");
            request.AddHeader("x-meta-sdk-language-version", Environment.Version.ToString());
        }
        #endregion Methods
    }
}
