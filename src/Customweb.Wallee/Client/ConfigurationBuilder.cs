using System;

namespace Customweb.Wallee.Client
{
    public class ConfigurationBuilder
    {
        public ConfigurationBuilder()
        {
        }

        private string _basePath = "https://app-wallee.com:443/api";

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

        public Configuration Build()
        {
            return new Configuration(_basePath,
                                    _applicationUserID,
                                    _authenticationKey,
                                    _tempFolderPath,
                                    _timeout,
                                    _userAgent);
        }
    }
}
