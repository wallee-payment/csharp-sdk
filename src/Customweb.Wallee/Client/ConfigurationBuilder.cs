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

namespace Customweb.Wallee.Client
{
    public class ConfigurationBuilder
    {
        public ConfigurationBuilder()
        {
        }

        private string _basePath = "https://staging-wallee.com:443/api";

        /// <summary>
        /// Sets the base API path.
        /// </summary>
        /// <returns>The configuration builder object.</returns>
        /// <param name="basePath">Base path.</param>
        public ConfigurationBuilder BasePath(string basePath)
        {
            _basePath = basePath;
            return this;
        }

        private string _applicationUserID;

        /// <summary>
        /// Sets the application user's ID.
        /// </summary>
        /// <returns>The configuration builder object.</returns>
        /// <param name="applicationUserID">Application user ID.</param>
        public ConfigurationBuilder ApplicationUserID(string applicationUserID)
        {
            _applicationUserID = applicationUserID;
            return this;
        }

        private string _authenticationKey;

        /// <summary>
        /// Sets the secret authentication key.
        /// </summary>
        /// <returns>The configuration builder object.</returns>
        /// <param name="applicationKey">Authentication key.</param>
        public ConfigurationBuilder AuthenticationKey(string authenticationKey)
        {
            _authenticationKey = authenticationKey;
            return this;
        }

        private int _timeout = 100000;

        /// <summary>
        /// Sets the HTTP timeout.
        /// </summary>
        /// <returns>The configuration builder object.</returns>
        /// <param name="timeout">Timeout.</param>
		    public ConfigurationBuilder Timeout(int timeout)
        {
            _timeout = timeout;
            return this;
        }

        private string _tempFolderPath;

        /// <summary>
        /// Sets the temporary folder path to store the files downloaded from the server.
        /// </summary>
        /// <returns>The configuration builder object.</returns>
        /// <param name="tempFolderPath">Temp folder path.</param>
        public ConfigurationBuilder TempFolderPath(string tempFolderPath)
        {
            _tempFolderPath = tempFolderPath;
            return this;
        }

        private string _userAgent;

        /// <summary>
        /// Sets the HTTP user agent
        /// </summary>
        /// <returns>The configuration builder object.</returns>
        /// <param name="userAgent">HTTP user agent.</param>
        public ConfigurationBuilder UserAgent(string userAgent)
        {
            _userAgent = userAgent;
            return this;
        }

        private ExceptionFactory _exceptionFactory;

        /// <summary>
        /// Sets the factory of exceptions.
        /// </summary>
        /// <returns>The configuration builder object.</returns>
        /// <param name="exceptionFactory">Exception factory.</param>
        public ConfigurationBuilder ExceptionFactory(ExceptionFactory exceptionFactory)
        {
            _exceptionFactory = exceptionFactory;
            return this;
        }

        public Configuration Build()
        {
            return new Configuration(_basePath,
                                    _applicationUserID,
                                    _authenticationKey,
                                    _tempFolderPath,
                                    _timeout,
                                    _userAgent,
                                    _exceptionFactory);
        }
    }
}
