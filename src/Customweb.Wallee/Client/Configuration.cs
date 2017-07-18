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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using RestSharp;

using Customweb.Wallee.Util;

namespace Customweb.Wallee.Client
{
    /// <summary>
    /// Represents a set of configuration settings
    /// </summary>
    public class Configuration
    {
        /// <summary>
        /// Initializes a new instance of the Configuration class with different settings.
        /// </summary>
        /// <param name="basePath">The base API path.</param>
        /// <param name="applicationUserID">The ID of application user.</param>
        /// <param name="authenticationKey">The secret authentication key.</param>
        /// <param name="tempFolderPath">Temp folder path</param>
        /// <param name="timeout">HTTP connection timeout (in milliseconds)</param>
        /// <param name="userAgent">HTTP user agent</param>
        /// <param name="exceptionFactory">The factory of exceptions which are caused by service methods.</param>
        public Configuration(string basePath,
                             string applicationUserID,
                             string authenticationKey,
                             string tempFolderPath,
                             int timeout,
                             string userAgent,
                             ExceptionFactory exceptionFactory
                            )
        {
            _basePath = CheckArgument.NotEmpty("basePath", basePath);
            _authenticationKey = CheckArgument.NotNull("authenticationKey", authenticationKey);
            _applicationUserID = CheckArgument.NotNull("applicationUserID", applicationUserID);
            _timeout = timeout;
            _userAgent = userAgent;

            if (!String.IsNullOrEmpty(tempFolderPath))
            {
                // check if the path contains directory separator at the end
                if (tempFolderPath[tempFolderPath.Length - 1] == Path.DirectorySeparatorChar)
                {
                    _tempFolderPath = tempFolderPath;
                }
                else
                {
                    _tempFolderPath = tempFolderPath + Path.DirectorySeparatorChar;
                }
            }
            else
            {
                _tempFolderPath = Path.GetTempPath();
            }

            // create the directory if it does not exist
            if (!Directory.Exists(_tempFolderPath))
            {
                Directory.CreateDirectory(_tempFolderPath);
            }

            if (exceptionFactory != null)
            {
                _exceptionFactory = exceptionFactory;
            }
            else
            {
                _exceptionFactory = DefaultExceptionFactory;
            }
        }


        /// <summary>
        /// Default creation of exceptions for a given method name and response object
        /// </summary>
        public static readonly ExceptionFactory DefaultExceptionFactory = (methodName, response) =>
        {
            int status = (int)response.StatusCode;
            if (status >= 400) return new ApiException(status, String.Format("Error calling {0}: {1}", methodName, response.Content), response.Content);
            if (status == 0) return new ApiException(status, String.Format("Error calling {0}: {1}", methodName, response.ErrorMessage), response.ErrorMessage);
            return null;
        };

        private readonly ExceptionFactory _exceptionFactory;

        /// <summary>
        /// Factory of exceptions for the given method name and response object.
        /// </summary>
        /// <value>Exception factory.</value>
        public ExceptionFactory ExceptionFactory
        {
            get { return _exceptionFactory; }
        }

        /// <summary>
        /// Version of the API.
        /// </summary>
        /// <value>Version of the API.</value>
        public const string Version = "1";

        private readonly string _basePath;

        /// <summary>
        /// Gets the base API path.
        /// </summary>
        /// <value>The base path.</value>
        public string BasePath
        {
            get { return _basePath; }
        }

        private readonly string _applicationUserID;

        /// <summary>
        /// Gets the application user's ID.
        /// </summary>
        /// <value>The application user ID.</value>
        public string ApplicationUserID
        {
            get { return _applicationUserID; }
        }

        private readonly string _authenticationKey;

        /// <summary>
        /// Gets the authentication key.
        /// </summary>
        /// <value>The authentication key.</value>
        public string AuthenticationKey
        {
            get { return _authenticationKey; }
        }

        private readonly int _timeout;

        /// <summary>
        /// Gets the HTTP timeout (milliseconds) of ApiClient.
        /// </summary>
        /// <value>Timeout.</value>
        public int Timeout
        {
            get { return _timeout; }
        }

        private readonly string _tempFolderPath;

        /// <summary>
        /// Gets the temporary folder path to store the files downloaded from the server.
        /// </summary>
        /// <value>Temporary folder path.</value>
        public String TempFolderPath
        {
            get { return _tempFolderPath; }
        }

        private const string ISO8601_DATETIME_FORMAT = "o";

        private string _dateTimeFormat = ISO8601_DATETIME_FORMAT;

        /// <summary>
        /// Gets or sets the the date time format used when serializing in the ApiClient
        /// By default, it's set to ISO 8601 - "o", for others see:
        /// https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx
        /// and https://msdn.microsoft.com/en-us/library/8kb3ddd4(v=vs.110).aspx
        /// No validation is done to ensure that the string you're providing is valid
        /// </summary>
        /// <value>The DateTimeFormat string</value>
        public String DateTimeFormat
        {
            get
            {
                return _dateTimeFormat;
            }
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

        private readonly string _userAgent;

        /// <summary>
        /// Gets the HTTP user agent.
        /// </summary>
        /// <value>Http user agent.</value>
        public string UserAgent
        {
            get { return _userAgent; }
        }

        /// <summary>
        /// Returns a new instance of ConfigurationBuilder.
        /// </summary>
        /// <value>New instance of configuration builder</value>
        public static ConfigurationBuilder Builder()
        {
            return new ConfigurationBuilder();
        }
    }
}
