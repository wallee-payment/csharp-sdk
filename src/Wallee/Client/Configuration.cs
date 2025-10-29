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
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

namespace Wallee.Client
{
    /// <summary>
    /// Represents a set of configuration settings
    /// </summary>
    public class Configuration : IReadableConfiguration
    {
        #region Constants

        /// <summary>
        /// Version of the package.
        /// </summary>
        /// <value>Version of the package.</value>
        public const string Version = "1.0.0";

        /// <summary>
        /// Identifier for ISO 8601 DateTime Format
        /// </summary>
        /// <remarks>See https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8 for more information.</remarks>
        // ReSharper disable once InconsistentNaming
        public const string ISO8601_DATETIME_FORMAT = "o";

        #endregion Constants

        #region Static Members

        /// <summary>
        /// Default creation of exceptions for a given method name and response object
        /// </summary>
        public static readonly ExceptionFactory DefaultExceptionFactory = (methodName, response) =>
        {
            var status = (int)response.StatusCode;
            if (status >= 400)
            {
                return new ApiException(status,
                    string.Format("Error calling {0}: {1}", methodName, response.RawContent),
                    response.RawContent, response.Headers);
            }
            if (status == 0)
            {
                return new ApiException(status,
                    string.Format("Error calling {0}: {1}", methodName, response.ErrorText), response.ErrorText);
            }
            return null;
        };

        #endregion Static Members

        #region Private Members

        /// <summary>
        /// Defines the base path of the target API server.
        /// Example: http://localhost:3000/v1/
        /// </summary>
        private string _basePath;

        private bool _useDefaultCredentials = false;

        /// <summary>
        /// Stores the unique identifier for the application user making the API request.
        /// This ID is used to associate actions with a specific application user.
        /// </summary>
        private long _applicationUserId;

        /// <summary>
        /// The key used to authenticate the application user with the API server.
        /// This should be kept secure and used in headers.
        /// </summary>
        private string _authenticationKey;

        private string _dateTimeFormat = ISO8601_DATETIME_FORMAT;
        private string _tempFolderPath = Path.GetTempPath();

        /// <summary>
        /// Gets or sets the servers defined in the OpenAPI spec.
        /// </summary>
        /// <value>The servers</value>
        private IList<IReadOnlyDictionary<string, object>> _servers;

        /// <summary>
        /// Gets or sets the operation servers defined in the OpenAPI spec.
        /// </summary>
        /// <value>The operation servers</value>
        private IReadOnlyDictionary<string, List<IReadOnlyDictionary<string, object>>> _operationServers;

        #endregion Private Members

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Configuration" /> class
        /// </summary>
        /// <param name="applicationUserId">The ID of application user.</param>
        /// <param name="authenticationKey">The secret authentication key.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "VirtualMemberCallInConstructor")]
        public Configuration(long applicationUserId, string authenticationKey)
        {
            if(string.IsNullOrWhiteSpace(authenticationKey))
                throw new ArgumentException("The provided authenticationKey is invalid.", "authenticationKey");
            Proxy = null;
            UserAgent = WebUtility.UrlEncode("Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/109.0.0.0 Safari/537.36");
            BasePath = "https://app-wallee.com/api/v2.0";
            DefaultHeaders = new ConcurrentDictionary<string, string>();
            ApplicationUserId = applicationUserId;
            AuthenticationKey = authenticationKey;
            Servers = new List<IReadOnlyDictionary<string, object>>()
            {
                {
                    new Dictionary<string, object> {
                        {"url", "https://app-wallee.com/api/v2.0"},
                        {"description", "No description provided"},
                    }
                }
            };
            OperationServers = new Dictionary<string, List<IReadOnlyDictionary<string, object>>>()
            {
            };
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Configuration" /> class
        /// </summary>
        /// <param name="applicationUserId">The ID of application user.</param>
        /// <param name="authenticationKey">The secret authentication key.</param>
        /// <param name="defaultHeaders">The default headers as key-value pairs.</param>
        /// <param name="basePath">The base URL path for API requests.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "VirtualMemberCallInConstructor")]
        public Configuration(
            long applicationUserId,
            string authenticationKey,
            IDictionary<string, string> defaultHeaders,
            string basePath = "https://app-wallee.com/api/v2.0") : this(applicationUserId, authenticationKey)
        {
            if (string.IsNullOrWhiteSpace(basePath))
                throw new ArgumentException("The provided basePath is invalid.", "basePath");
            if (defaultHeaders == null)
                throw new ArgumentNullException("defaultHeaders");

            BasePath = basePath;

            foreach (var keyValuePair in defaultHeaders)
            {
                DefaultHeaders.Add(keyValuePair);
            }
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the base path for API access.
        /// </summary>
        public virtual string BasePath 
        {
            get { return _basePath; }
            set { _basePath = value; }
        }

        /// <summary>
        /// Gets or sets the application user ID for API access.
        /// </summary>
        public virtual long ApplicationUserId
        {
            get { return _applicationUserId; }
            set { _applicationUserId = value; }
        }

        /// <summary>
        /// Gets or sets the authentication key for API access.
        /// </summary>
        public virtual string AuthenticationKey
        {
            get { return _authenticationKey; }
            set { _authenticationKey = value; }
        }

        /// <summary>
        /// Determine whether the "default credentials" (e.g. the user account under which the current process is running) will be sent along to the server. The default is false.
        /// </summary>
        public virtual bool UseDefaultCredentials
        {
            get { return _useDefaultCredentials; }
            set { _useDefaultCredentials = value; }
        }

        /// <summary>
        /// Gets or sets the default header.
        /// </summary>
        [Obsolete("Use DefaultHeaders instead.")]
        public virtual IDictionary<string, string> DefaultHeader
        {
            get
            {
                return DefaultHeaders;
            }
            set
            {
                DefaultHeaders = value;
            }
        }

        /// <summary>
        /// Gets or sets the default headers.
        /// </summary>
        public virtual IDictionary<string, string> DefaultHeaders { get; set; }

        /// <summary>
        /// Gets or sets the HTTP timeout (seconds) of ApiClient. Default: 25 seconds.
        /// </summary>
        public virtual int Timeout { get; set; } = 25;

        /// <summary>
        /// Gets or sets the proxy
        /// </summary>
        /// <value>Proxy.</value>
        public virtual WebProxy Proxy { get; set; }

        /// <summary>
        /// Gets or sets the HTTP user agent.
        /// </summary>
        /// <value>Http user agent.</value>
        public virtual string UserAgent { get; set; }

        /// <summary>
        /// Gets or sets certificate collection to be sent with requests.
        /// </summary>
        /// <value>X509 Certificate collection.</value>
        public X509CertificateCollection ClientCertificates { get; set; }

        /// <summary>
        /// Gets or sets the temporary folder path to store the files downloaded from the server.
        /// </summary>
        /// <value>Folder path.</value>
        public virtual string TempFolderPath
        {
            get { return _tempFolderPath; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _tempFolderPath = Path.GetTempPath();
                    return;
                }

                // create the directory if it does not exist
                if (!Directory.Exists(value))
                {
                    Directory.CreateDirectory(value);
                }

                // check if the path contains directory separator at the end
                if (value[value.Length - 1] == Path.DirectorySeparatorChar)
                {
                    _tempFolderPath = value;
                }
                else
                {
                    _tempFolderPath = value + Path.DirectorySeparatorChar;
                }
            }
        }

        /// <summary>
        /// Gets or sets the date time format used when serializing in the ApiClient
        /// By default, it's set to ISO 8601 - "o", for others see:
        /// https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx
        /// and https://msdn.microsoft.com/en-us/library/8kb3ddd4(v=vs.110).aspx
        /// No validation is done to ensure that the string you're providing is valid
        /// </summary>
        /// <value>The DateTimeFormat string</value>
        public virtual string DateTimeFormat
        {
            get { return _dateTimeFormat; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    // Never allow a blank or null string, go back to the default
                    _dateTimeFormat = ISO8601_DATETIME_FORMAT;
                    return;
                }

                // Caution, no validation when you choose date time format other than ISO 8601
                // Take a look at the above links
                _dateTimeFormat = value;
            }
        }


        /// <summary>
        /// Gets or sets the servers.
        /// </summary>
        /// <value>The servers.</value>
        public virtual IList<IReadOnlyDictionary<string, object>> Servers
        {
            get { return _servers; }
            set
            {
                if (value == null)
                {
                    throw new InvalidOperationException("Servers may not be null.");
                }
                _servers = value;
            }
        }

        /// <summary>
        /// Gets or sets the operation servers.
        /// </summary>
        /// <value>The operation servers.</value>
        public virtual IReadOnlyDictionary<string, List<IReadOnlyDictionary<string, object>>> OperationServers
        {
            get { return _operationServers; }
            set
            {
                if (value == null)
                {
                    throw new InvalidOperationException("Operation servers may not be null.");
                }
                _operationServers = value;
            }
        }

        /// <summary>
        /// Returns URL based on server settings without providing values
        /// for the variables
        /// </summary>
        /// <param name="index">Array index of the server settings.</param>
        /// <return>The server URL.</return>
        public string GetServerUrl(int index)
        {
            return GetServerUrl(Servers, index, null);
        }

        /// <summary>
        /// Returns URL based on server settings.
        /// </summary>
        /// <param name="index">Array index of the server settings.</param>
        /// <param name="inputVariables">Dictionary of the variables and the corresponding values.</param>
        /// <return>The server URL.</return>
        public string GetServerUrl(int index, Dictionary<string, string> inputVariables)
        {
            return GetServerUrl(Servers, index, inputVariables);
        }

        /// <summary>
        /// Returns URL based on operation server settings.
        /// </summary>
        /// <param name="operation">Operation associated with the request path.</param>
        /// <param name="index">Array index of the server settings.</param>
        /// <return>The operation server URL.</return>
        public string GetOperationServerUrl(string operation, int index)
        {
            return GetOperationServerUrl(operation, index, null);
        }

        /// <summary>
        /// Returns URL based on operation server settings.
        /// </summary>
        /// <param name="operation">Operation associated with the request path.</param>
        /// <param name="index">Array index of the server settings.</param>
        /// <param name="inputVariables">Dictionary of the variables and the corresponding values.</param>
        /// <return>The operation server URL.</return>
        public string GetOperationServerUrl(string operation, int index, Dictionary<string, string> inputVariables)
        {
            if (operation != null && OperationServers.TryGetValue(operation, out var operationServer))
            {
                return GetServerUrl(operationServer, index, inputVariables);
            }

            return null;
        }

        /// <summary>
        /// Returns URL based on server settings.
        /// </summary>
        /// <param name="servers">Dictionary of server settings.</param>
        /// <param name="index">Array index of the server settings.</param>
        /// <param name="inputVariables">Dictionary of the variables and the corresponding values.</param>
        /// <return>The server URL.</return>
        private string GetServerUrl(IList<IReadOnlyDictionary<string, object>> servers, int index, Dictionary<string, string> inputVariables)
        {
            if (index < 0 || index >= servers.Count)
            {
                throw new InvalidOperationException($"Invalid index {index} when selecting the server. Must be less than {servers.Count}.");
            }

            if (inputVariables == null)
            {
                inputVariables = new Dictionary<string, string>();
            }

            IReadOnlyDictionary<string, object> server = servers[index];
            string url = (string)server["url"];

            if (server.ContainsKey("variables"))
            {
                // go through each variable and assign a value
                foreach (KeyValuePair<string, object> variable in (IReadOnlyDictionary<string, object>)server["variables"])
                {

                    IReadOnlyDictionary<string, object> serverVariables = (IReadOnlyDictionary<string, object>)(variable.Value);

                    if (inputVariables.ContainsKey(variable.Key))
                    {
                        if (((List<string>)serverVariables["enum_values"]).Contains(inputVariables[variable.Key]))
                        {
                            url = url.Replace("{" + variable.Key + "}", inputVariables[variable.Key]);
                        }
                        else
                        {
                            throw new InvalidOperationException($"The variable `{variable.Key}` in the server URL has invalid value #{inputVariables[variable.Key]}. Must be {(List<string>)serverVariables["enum_values"]}");
                        }
                    }
                    else
                    {
                        // use default value
                        url = url.Replace("{" + variable.Key + "}", (string)serverVariables["default_value"]);
                    }
                }
            }

            return url;
        }
        
        /// <summary>
        /// Gets and Sets the RemoteCertificateValidationCallback
        /// </summary>
        public RemoteCertificateValidationCallback RemoteCertificateValidationCallback { get; set; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Returns a string with essential information for debugging.
        /// </summary>
        public static string ToDebugReport()
        {
            string report = "C# SDK (Wallee) Debug Report:\n";
            report += "    OS: " + System.Environment.OSVersion + "\n";
            report += "    .NET Framework Version: " + System.Environment.Version + "\n";
            report += "    Version of the API: 2.0\n";
            report += "    SDK Package Version: 1.0.0\n";

            return report;
        }

        /// <summary>
        /// Resets the timeout in the Configuration to the default value - 25 seconds.
        /// </summary>
        public void ResetTimeout(){
            this.Timeout = 25;
        }
        #endregion Methods
    }
}
