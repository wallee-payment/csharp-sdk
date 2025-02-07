using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.IO;
using System.Web;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using RestSharp;

namespace Wallee.Client
{
    /// <summary>
    /// API client is mainly responsible for making the HTTP call to the API backend.
    /// </summary>
    public partial class ApiClient
    {
        private JsonSerializerSettings serializerSettings = new JsonSerializerSettings
        {
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
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
        /// Initializes a new instance of the <see cref="ApiClient" /> class
        /// with default configuration.
        /// </summary>
        public ApiClient()
        {
            RestClient = new RestClient("https://app-wallee.com:443/api");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" /> class
        /// with default base path (https://app-wallee.com:443/api).
        /// </summary>
        /// <param name="config">An instance of Configuration.</param>
        public ApiClient(Configuration config)
        {
            Configuration = config;

            if (String.IsNullOrEmpty(Configuration.BasePath))
                throw new ArgumentException("basePath cannot be empty");

            var options = Configuration.RestClientOptions;
            options.BaseUrl = new Uri(Configuration.BasePath);
            RestClient = new RestClient(options);
        }

        /// <summary>
        /// Gets or sets an instance of the IReadableConfiguration.
        /// </summary>
        /// <value>An instance of the IReadableConfiguration.</value>
        /// <remarks>
        /// <see cref="IReadableConfiguration"/> helps us to avoid modifying possibly global
        /// configuration values from within a given client. It does not guarantee thread-safety
        /// of the <see cref="Configuration"/> instance in any way.
        /// </remarks>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Gets or sets the RestClient.
        /// </summary>
        /// <value>An instance of the RestClient</value>
        public RestClient RestClient { get; set; }

        // Creates and sets up a RestRequest prior to a call.
        private RestRequest PrepareRequest(
            String path, RestSharp.Method method, List<KeyValuePair<String, String>> queryParams, Object postBody,
            Dictionary<String, String> headerParams, Dictionary<String, String> defaultHeaderParams, Dictionary<String, String> formParams,
            Dictionary<String, FileParameter> fileParams, Dictionary<String, String> pathParams,
            String contentType)
        {
            var request = new RestRequest(path, method);

            // add path parameter, if any
            foreach(var param in pathParams)
                request.AddParameter(param.Key, param.Value, ParameterType.UrlSegment);

            // add header parameter, if any
            foreach(var param in headerParams)
                request.AddHeader(param.Key, param.Value);

            // add default header parameters
            foreach(var param in defaultHeaderParams)
                request.AddHeader(param.Key, param.Value);

            // add authentication headers
            foreach (var param in AuthenticationHeaders(method, path, queryParams))
                request.AddHeader(param.Key, param.Value);

            // add query parameter, if any
            foreach(var param in queryParams)
                request.AddQueryParameter(param.Key, param.Value);

            // add form parameter, if any
            foreach(var param in formParams)
                request.AddParameter(param.Key, param.Value);

            // add file parameter, if any
            foreach(var param in fileParams)
            {
                request.AddFile(param.Value.Name, param.Value.FileName, param.Value.ContentType);
            }

            if (postBody != null) // http body (model or byte[]) parameter
            {
                request.AddBody(postBody, contentType);
            }

            var isPostMethod = (method == RestSharp.Method.Post);
            // NB: Our server wants even empty POST to have a Content-Type header. Don't provide Content-Type for GET requests.
            if (contentType != null 
                && (postBody != null || isPostMethod)
            ) {
                request.AddHeader("Content-Type", contentType);
            }

            return request;
        }

        /// <summary>
        /// Makes the HTTP request (Sync).
        /// </summary>
        /// <param name="path">URL path.</param>
        /// <param name="method">HTTP method.</param>
        /// <param name="queryParams">Query parameters.</param>
        /// <param name="postBody">HTTP body (POST request).</param>
        /// <param name="headerParams">Header parameters.</param>
        /// <param name="formParams">Form parameters.</param>
        /// <param name="fileParams">File parameters.</param>
        /// <param name="pathParams">Path parameters.</param>
        /// <param name="contentType">Content Type of the request</param>
        /// <param name="timeout">Per-request timeout in milliseconds.
        /// <returns>Object</returns>
        public Object CallApi(
            String path, RestSharp.Method method, List<KeyValuePair<String, String>> queryParams, Object postBody,
            Dictionary<String, String> headerParams, Dictionary<String, String> formParams,
            Dictionary<String, FileParameter> fileParams, Dictionary<String, String> pathParams,
            String contentType, int timeout)
        {

            Dictionary<String, String> defaultHeaderParams = new Dictionary<String, String>() {
                {"x-meta-sdk-version", "8.0.0"},
                {"x-meta-sdk-language", "csharp"},
                {"x-meta-sdk-provider", "wallee"},
                {"x-meta-sdk-language-version", Environment.Version.ToString()}
            };

            var request = PrepareRequest(
                path, method, queryParams, postBody, headerParams, defaultHeaderParams, formParams, fileParams,
                pathParams, contentType);

            // set timeout for the request
            request.Timeout = TimeSpan.FromMilliseconds(timeout);

            InterceptRequest(request);
            var response = RestClient.Execute(request);
            InterceptResponse(request, response);

            return (Object) response;
        }

        /// <summary>
        /// Escape string (url-encoded).
        /// </summary>
        /// <param name="str">String to be escaped.</param>
        /// <returns>Escaped string.</returns>
        public string EscapeString(string str)
        {
            return UrlEncode(str);
        }

        /// <summary>
        /// Create FileParameter based on Stream.
        /// </summary>
        /// <param name="name">Parameter name.</param>
        /// <param name="stream">Input stream.</param>
        /// <returns>FileParameter.</returns>
        public FileParameter ParameterToFile(string name, Stream stream)
        {
            if (stream is FileStream)
                return FileParameter.Create(name, ReadAsBytes(stream), Path.GetFileName(((FileStream)stream).Name));
            else
                return FileParameter.Create(name, ReadAsBytes(stream), "no_file_name_provided");
        }

        /// <summary>
        /// If parameter is DateTime, output in a formatted string (default ISO 8601), customizable with Configuration.DateTime.
        /// If parameter is a list, join the list with ",".
        /// Otherwise just return the string.
        /// </summary>
        /// <param name="obj">The parameter (header, path, query, form).</param>
        /// <returns>Formatted string.</returns>
        public string ParameterToString(object obj)
        {
            if (obj is DateTime)
                // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
                // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
                // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
                // For example: 2009-06-15T13:45:30.0000000
                return ((DateTime)obj).ToString (Configuration.DateTimeFormat);
            else if (obj is DateTimeOffset)
                // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
                // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
                // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
                // For example: 2009-06-15T13:45:30.0000000
                return ((DateTimeOffset)obj).ToString (Configuration.DateTimeFormat);
            else if (obj is IList)
            {
                var flattenedString = new StringBuilder();
                foreach (var param in (IList)obj)
                {
                    if (flattenedString.Length > 0)
                        flattenedString.Append(",");
                    flattenedString.Append(param);
                }
                return flattenedString.ToString();
            }
            else
                return Convert.ToString (obj);
        }

        /// <summary>
        /// Deserialize the JSON string into a proper object.
        /// </summary>
        /// <param name="response">The HTTP response.</param>
        /// <param name="type">Object type.</param>
        /// <returns>Object representation of the JSON string.</returns>
        public object Deserialize(RestResponse response, Type type)
        {
            IReadOnlyCollection<HeaderParameter> headers = response.Headers;
            if (type == typeof(byte[])) // return byte array
            {
                return response.RawBytes;
            }

            // TODO: ? if (type.IsAssignableFrom(typeof(Stream)))
            if (type == typeof(Stream))
            {
                if (headers != null)
                {
                    var filePath = String.IsNullOrEmpty(Configuration.TempFolderPath)
                        ? Path.GetTempPath()
                        : Configuration.TempFolderPath;
                    var regex = new Regex(@"Content-Disposition=.*filename=['""]?([^'""\s]+)['""]?$");
                    foreach (var header in headers)
                    {
                        var match = regex.Match(header.ToString());
                        if (match.Success)
                        {
                            string fileName = filePath + SanitizeFilename(match.Groups[1].Value.Replace("\"", "").Replace("'", ""));
                            File.WriteAllBytes(fileName, response.RawBytes);
                            return new FileStream(fileName, FileMode.Open);
                        }
                    }
                }
                var stream = new MemoryStream(response.RawBytes);
                return stream;
            }

            if (type.Name.StartsWith("System.Nullable`1[[System.DateTime")) // return a datetime object
            {
                return DateTime.Parse(response.Content,  null, System.Globalization.DateTimeStyles.RoundtripKind);
            }

            if (type == typeof(String) || type.Name.StartsWith("System.Nullable")) // return primitive type
            {
                return ConvertType(response.Content, type);
            }

            // at this point, it must be a model (json)
            try
            {
                return JsonConvert.DeserializeObject(response.Content, type, serializerSettings);
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }

        /// <summary>
        /// Serialize an input (model) into JSON string
        /// </summary>
        /// <param name="obj">Object.</param>
        /// <returns>JSON string.</returns>
        public String Serialize(object obj)
        {
            try
            {
				return obj != null ? JsonConvert.SerializeObject(obj, Formatting.None, new JsonSerializerSettings{ NullValueHandling = NullValueHandling.Ignore}) : null;
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }

        /// <summary>
        ///Check if the given MIME is a JSON MIME.
        ///JSON MIME examples:
        ///    application/json
        ///    application/json; charset=UTF8
        ///    APPLICATION/JSON
        ///    application/vnd.company+json
        /// </summary>
        /// <param name="mime">MIME</param>
        /// <returns>Returns True if MIME type is json.</returns>
        public bool IsJsonMime(String mime)
        {
            var jsonRegex = new Regex("(?i)^(application/json|[^;/ \t]+/[^;/ \t]+[+]json)[ \t]*(;.*)?$");
            return mime != null && (jsonRegex.IsMatch(mime) || mime.Equals("application/json-patch+json"));
        }

        /// <summary>
        /// Select the Content-Type header's value from the given content-type array:
        /// if JSON type exists in the given array, use it;
        /// otherwise use the first one defined in 'consumes'
        /// </summary>
        /// <param name="contentTypes">The Content-Type array to select from.</param>
        /// <returns>The Content-Type header to use.</returns>
        public String SelectHeaderContentType(String[] contentTypes)
        {
            if (contentTypes.Length == 0)
                return "application/json";

            foreach (var contentType in contentTypes)
            {
                if (IsJsonMime(contentType.ToLower()))
                {
                    String jsonContentType = contentType;
                    int index = jsonContentType.IndexOf(";");
                    if (index >= 0)
                    {
                        jsonContentType = jsonContentType.Substring(0, index);
                    }
                    return jsonContentType;
                }
            }
            return contentTypes[0]; // use the first content type specified in 'consumes'
        }

        /// <summary>
        /// Select the Accept header's value from the given accepts array:
        /// if JSON exists in the given array, use it;
        /// otherwise use all of them (joining into a string)
        /// </summary>
        /// <param name="accepts">The accepts array to select from.</param>
        /// <returns>The Accept header to use.</returns>
        public String SelectHeaderAccept(String[] accepts)
        {
            if (accepts.Length == 0)
                return null;

            if (accepts.Contains("application/json", StringComparer.OrdinalIgnoreCase))
                return "application/json";

            return String.Join(",", accepts);
        }

        /// <summary>
        /// Encode string in base64 format.
        /// </summary>
        /// <param name="text">String to be encoded.</param>
        /// <returns>Encoded string.</returns>
        public static string Base64Encode(string text)
        {
            return System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(text));
        }

        /// <summary>
        /// Dynamically cast the object into target type.
        /// </summary>
        /// <param name="fromObject">Object to be casted</param>
        /// <param name="toObject">Target type</param>
        /// <returns>Casted object</returns>
        public static object ConvertType<T>(T fromObject, Type toObject) where T : class
        {
            return Convert.ChangeType(fromObject, toObject);
        }

        /// <summary>
        /// Convert stream to byte array
        /// </summary>
        /// <param name="inputStream">Input stream to be converted</param>
        /// <returns>Byte array</returns>
        public static byte[] ReadAsBytes(Stream inputStream)
        {
            byte[] buf = new byte[16*1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int count;
                while ((count = inputStream.Read(buf, 0, buf.Length)) > 0)
                {
                    ms.Write(buf, 0, count);
                }
                return ms.ToArray();
            }
        }

        /// <summary>
        /// URL encode a string
        /// Credit/Ref: https://github.com/restsharp/RestSharp/blob/master/RestSharp/Extensions/StringExtensions.cs#L50
        /// </summary>
        /// <param name="input">String to be URL encoded</param>
        /// <returns>Byte array</returns>
        public static string UrlEncode(string input)
        {
            const int maxLength = 32766;

            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            if (input.Length <= maxLength)
            {
                return Uri.EscapeDataString(input);
            }

            StringBuilder sb = new StringBuilder(input.Length * 2);
            int index = 0;

            while (index < input.Length)
            {
                int length = Math.Min(input.Length - index, maxLength);
                string subString = input.Substring(index, length);

                sb.Append(Uri.EscapeDataString(subString));
                index += subString.Length;
            }

            return sb.ToString();
        }

        /// <summary>
        /// Sanitize filename by removing the path
        /// </summary>
        /// <param name="filename">Filename</param>
        /// <returns>Filename</returns>
        public static string SanitizeFilename(string filename)
        {
            Match match = Regex.Match(filename, @".*[/\\](.*)$");

            if (match.Success)
            {
                return match.Groups[1].Value;
            }
            else
            {
                return filename;
            }
        }

        /// <summary>
        /// Convert params to key/value pairs.
        /// Use collectionFormat to properly format lists and collections.
        /// </summary>
        /// <param name="name">Key name.</param>
        /// <param name="value">Value object.</param>
        /// <returns>A list of KeyValuePairs</returns>
        public IEnumerable<KeyValuePair<string, string>> ParameterToKeyValuePairs(string collectionFormat, string name, object value)
        {
            var parameters = new List<KeyValuePair<string, string>>();

            if (IsCollection(value) && collectionFormat == "multi")
            {
                var valueCollection = value as IEnumerable;
                parameters.AddRange(from object item in valueCollection select new KeyValuePair<string, string>(name, ParameterToString(item)));
            }
            else
            {
                parameters.Add(new KeyValuePair<string, string>(name, ParameterToString(value)));
            }

            return parameters;
        }

        /// <summary>
        /// Check if generic object is a collection.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>True if object is a collection type</returns>
        private static bool IsCollection(object value)
        {
            return value is IList || value is ICollection;
        }

        /// <summary>
        /// Generates the authentication headers for this configuration.
        /// </summary>
        /// <returns>The authentication headers.</returns>
        /// <param name="method">HTTP method.</param>
        /// <param name="path">The request path.</param>
        public IEnumerable<KeyValuePair<string, string>> AuthenticationHeaders(Method method, string path, List<KeyValuePair<string, string>> queryParams)
        {
            var headers = new List<KeyValuePair<string, string>>();
            var pathWithQueryString = RestClient.Options.BaseUrl.AbsolutePath + path + ToQueryString(queryParams);
            var version = "1";
            var userID = Configuration.ApplicationUserID;
            var timestamp = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;
            var signature = version + "|" + userID + "|" + timestamp + "|" + method.ToString().ToUpper() + "|" + pathWithQueryString;
            headers.Add(new KeyValuePair<string, string>("x-mac-version", version));
            headers.Add(new KeyValuePair<string, string>("x-mac-userid", userID));
            headers.Add(new KeyValuePair<string, string>("x-mac-timestamp", timestamp.ToString()));
            headers.Add(new KeyValuePair<string, string>("x-mac-value", CalculateHmac(signature)));
            return headers;
        }

        private string CalculateHmac(string signature)
        {
            string encodedKey = Configuration.AuthenticationKey;
            while (encodedKey.Length % 4 != 0)
            {
                encodedKey += "=";
            }
            byte[] keyBytes = System.Convert.FromBase64String(encodedKey);
            using (var hmac = new System.Security.Cryptography.HMACSHA512(keyBytes))
            {
                byte[] signatureBytes = System.Text.Encoding.UTF8.GetBytes(signature);
                byte[] hashBytes = hmac.ComputeHash(signatureBytes);
                return System.Convert.ToBase64String(hashBytes);
            }
        }

        private String ToQueryString(List<KeyValuePair<string, string>> queryParams)
        {
            if (queryParams.Count == 0)
            {
                return string.Empty;
            }
            List<String> query = new List<String>();
            foreach (var param in queryParams)
            {
                query.Add(param.Key + "=" + HttpUtility.UrlEncode(param.Value));
            }
            return "?" + string.Join("&", query.ToArray());
        }

		/// <summary>
		/// Reset timeout to default: 25 seconds
		/// https://docs.microsoft.com/en-us/dotnet/api/system.net.httpwebrequest.timeout?view=netcore-3.1
		/// </summary>
		public void ResetTimeout(){
			Configuration.Timeout = 25;
		}

    }
}
