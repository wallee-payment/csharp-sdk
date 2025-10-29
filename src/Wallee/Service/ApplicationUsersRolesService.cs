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
using Wallee.Client;
using Wallee.Model;

namespace Wallee.Service
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IApplicationUsersRolesServiceSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Unassign a role from an application user for an account
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="roleId"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void DeleteApplicationUsersUserIdAccountRoles(long userId, long roleId, long account, int operationIndex = 0);

        /// <summary>
        /// Unassign a role from an application user for an account
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="roleId"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteApplicationUsersUserIdAccountRolesWithHttpInfo(long userId, long roleId, long account, int operationIndex = 0);

        /// <summary>
        /// Unassign a role from an application user for a space
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="roleId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void DeleteApplicationUsersUserIdSpaceRoles(long userId, long roleId, long space, int operationIndex = 0);

        /// <summary>
        /// Unassign a role from an application user for a space
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="roleId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteApplicationUsersUserIdSpaceRolesWithHttpInfo(long userId, long roleId, long space, int operationIndex = 0);

        /// <summary>
        /// List all roles of an application user for an account
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>UserAccountRoleListResponse</returns>
        UserAccountRoleListResponse GetApplicationUsersUserIdAccountRoles(long userId, long account, int operationIndex = 0);

        /// <summary>
        /// List all roles of an application user for an account
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of UserAccountRoleListResponse</returns>
        ApiResponse<UserAccountRoleListResponse> GetApplicationUsersUserIdAccountRolesWithHttpInfo(long userId, long account, int operationIndex = 0);

        /// <summary>
        /// List all roles of an application user for a space
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>UserSpaceRoleListResponse</returns>
        UserSpaceRoleListResponse GetApplicationUsersUserIdSpaceRoles(long userId, long space, int operationIndex = 0);

        /// <summary>
        /// List all roles of an application user for a space
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of UserSpaceRoleListResponse</returns>
        ApiResponse<UserSpaceRoleListResponse> GetApplicationUsersUserIdSpaceRolesWithHttpInfo(long userId, long space, int operationIndex = 0);

        /// <summary>
        /// Assign a role to an application user for an account
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="roleId"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="appliesOnSubAccount">Whether the role should be assigned to the user in subaccounts only. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>UserAccountRole</returns>
        UserAccountRole PostApplicationUsersUserIdAccountRoles(long userId, long roleId, long account, bool? appliesOnSubAccount = default(bool?), int operationIndex = 0);

        /// <summary>
        /// Assign a role to an application user for an account
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="roleId"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="appliesOnSubAccount">Whether the role should be assigned to the user in subaccounts only. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of UserAccountRole</returns>
        ApiResponse<UserAccountRole> PostApplicationUsersUserIdAccountRolesWithHttpInfo(long userId, long roleId, long account, bool? appliesOnSubAccount = default(bool?), int operationIndex = 0);

        /// <summary>
        /// Assign a role to an application user for a space
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="roleId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>UserSpaceRole</returns>
        UserSpaceRole PostApplicationUsersUserIdSpaceRoles(long userId, long roleId, long space, int operationIndex = 0);

        /// <summary>
        /// Assign a role to an application user for a space
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="roleId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of UserSpaceRole</returns>
        ApiResponse<UserSpaceRole> PostApplicationUsersUserIdSpaceRolesWithHttpInfo(long userId, long roleId, long space, int operationIndex = 0);

        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IApplicationUsersRolesService : IApplicationUsersRolesServiceSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ApplicationUsersRolesService : IApplicationUsersRolesService
    {

        private Wallee.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationUsersRolesService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ApplicationUsersRolesService(Wallee.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            this.Configuration = configuration;
            this.Client = new Wallee.Client.ApiClient(this.Configuration);
            ExceptionFactory = Wallee.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationUsersRolesService"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ApplicationUsersRolesService(Wallee.Client.ISynchronousClient client, Wallee.Client.IReadableConfiguration configuration)
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
        /// Unassign a role from an application user for an account 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="roleId"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void DeleteApplicationUsersUserIdAccountRoles(long userId, long roleId, long account, int operationIndex = 0)
        {
            DeleteApplicationUsersUserIdAccountRolesWithHttpInfo(userId, roleId, account);
        }

        /// <summary>
        /// Unassign a role from an application user for an account 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="roleId"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Wallee.Client.ApiResponse<Object> DeleteApplicationUsersUserIdAccountRolesWithHttpInfo(long userId, long roleId, long account, int operationIndex = 0)
        {
            Wallee.Client.RequestOptions localVarRequestOptions = new Wallee.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Wallee.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Wallee.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("userId", Wallee.Client.ClientUtils.ParameterToString(userId)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("", "roleId", roleId));
            localVarRequestOptions.HeaderParameters.Add("Account", Wallee.Client.ClientUtils.ParameterToString(account)); // header parameter

            localVarRequestOptions.Operation = "ApplicationUsersRolesService.DeleteApplicationUsersUserIdAccountRoles";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = Client.Delete<Object>("/application-users/{userId}/account-roles",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteApplicationUsersUserIdAccountRoles", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Unassign a role from an application user for a space 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="roleId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void DeleteApplicationUsersUserIdSpaceRoles(long userId, long roleId, long space, int operationIndex = 0)
        {
            DeleteApplicationUsersUserIdSpaceRolesWithHttpInfo(userId, roleId, space);
        }

        /// <summary>
        /// Unassign a role from an application user for a space 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="roleId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Wallee.Client.ApiResponse<Object> DeleteApplicationUsersUserIdSpaceRolesWithHttpInfo(long userId, long roleId, long space, int operationIndex = 0)
        {
            Wallee.Client.RequestOptions localVarRequestOptions = new Wallee.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Wallee.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Wallee.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("userId", Wallee.Client.ClientUtils.ParameterToString(userId)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("", "roleId", roleId));
            localVarRequestOptions.HeaderParameters.Add("Space", Wallee.Client.ClientUtils.ParameterToString(space)); // header parameter

            localVarRequestOptions.Operation = "ApplicationUsersRolesService.DeleteApplicationUsersUserIdSpaceRoles";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = Client.Delete<Object>("/application-users/{userId}/space-roles",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteApplicationUsersUserIdSpaceRoles", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// List all roles of an application user for an account 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>UserAccountRoleListResponse</returns>
        public UserAccountRoleListResponse GetApplicationUsersUserIdAccountRoles(long userId, long account, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<UserAccountRoleListResponse> localVarResponse = GetApplicationUsersUserIdAccountRolesWithHttpInfo(userId, account);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List all roles of an application user for an account 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of UserAccountRoleListResponse</returns>
        public Wallee.Client.ApiResponse<UserAccountRoleListResponse> GetApplicationUsersUserIdAccountRolesWithHttpInfo(long userId, long account, int operationIndex = 0)
        {
            Wallee.Client.RequestOptions localVarRequestOptions = new Wallee.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Wallee.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Wallee.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("userId", Wallee.Client.ClientUtils.ParameterToString(userId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("Account", Wallee.Client.ClientUtils.ParameterToString(account)); // header parameter

            localVarRequestOptions.Operation = "ApplicationUsersRolesService.GetApplicationUsersUserIdAccountRoles";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = Client.Get<UserAccountRoleListResponse>("/application-users/{userId}/account-roles",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetApplicationUsersUserIdAccountRoles", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// List all roles of an application user for a space 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>UserSpaceRoleListResponse</returns>
        public UserSpaceRoleListResponse GetApplicationUsersUserIdSpaceRoles(long userId, long space, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<UserSpaceRoleListResponse> localVarResponse = GetApplicationUsersUserIdSpaceRolesWithHttpInfo(userId, space);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List all roles of an application user for a space 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of UserSpaceRoleListResponse</returns>
        public Wallee.Client.ApiResponse<UserSpaceRoleListResponse> GetApplicationUsersUserIdSpaceRolesWithHttpInfo(long userId, long space, int operationIndex = 0)
        {
            Wallee.Client.RequestOptions localVarRequestOptions = new Wallee.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Wallee.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Wallee.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("userId", Wallee.Client.ClientUtils.ParameterToString(userId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("Space", Wallee.Client.ClientUtils.ParameterToString(space)); // header parameter

            localVarRequestOptions.Operation = "ApplicationUsersRolesService.GetApplicationUsersUserIdSpaceRoles";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = Client.Get<UserSpaceRoleListResponse>("/application-users/{userId}/space-roles",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetApplicationUsersUserIdSpaceRoles", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Assign a role to an application user for an account 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="roleId"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="appliesOnSubAccount">Whether the role should be assigned to the user in subaccounts only. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>UserAccountRole</returns>
        public UserAccountRole PostApplicationUsersUserIdAccountRoles(long userId, long roleId, long account, bool? appliesOnSubAccount = default(bool?), int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<UserAccountRole> localVarResponse = PostApplicationUsersUserIdAccountRolesWithHttpInfo(userId, roleId, account, appliesOnSubAccount);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Assign a role to an application user for an account 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="roleId"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="appliesOnSubAccount">Whether the role should be assigned to the user in subaccounts only. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of UserAccountRole</returns>
        public Wallee.Client.ApiResponse<UserAccountRole> PostApplicationUsersUserIdAccountRolesWithHttpInfo(long userId, long roleId, long account, bool? appliesOnSubAccount = default(bool?), int operationIndex = 0)
        {
            Wallee.Client.RequestOptions localVarRequestOptions = new Wallee.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Wallee.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Wallee.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("userId", Wallee.Client.ClientUtils.ParameterToString(userId)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("", "roleId", roleId));
            if (appliesOnSubAccount != null)
            {
                localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("", "appliesOnSubAccount", appliesOnSubAccount));
            }
            localVarRequestOptions.HeaderParameters.Add("Account", Wallee.Client.ClientUtils.ParameterToString(account)); // header parameter

            localVarRequestOptions.Operation = "ApplicationUsersRolesService.PostApplicationUsersUserIdAccountRoles";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = Client.Post<UserAccountRole>("/application-users/{userId}/account-roles",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostApplicationUsersUserIdAccountRoles", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Assign a role to an application user for a space 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="roleId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>UserSpaceRole</returns>
        public UserSpaceRole PostApplicationUsersUserIdSpaceRoles(long userId, long roleId, long space, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<UserSpaceRole> localVarResponse = PostApplicationUsersUserIdSpaceRolesWithHttpInfo(userId, roleId, space);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Assign a role to an application user for a space 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="roleId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of UserSpaceRole</returns>
        public Wallee.Client.ApiResponse<UserSpaceRole> PostApplicationUsersUserIdSpaceRolesWithHttpInfo(long userId, long roleId, long space, int operationIndex = 0)
        {
            Wallee.Client.RequestOptions localVarRequestOptions = new Wallee.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Wallee.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Wallee.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("userId", Wallee.Client.ClientUtils.ParameterToString(userId)); // path parameter
            localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("", "roleId", roleId));
            localVarRequestOptions.HeaderParameters.Add("Space", Wallee.Client.ClientUtils.ParameterToString(space)); // header parameter

            localVarRequestOptions.Operation = "ApplicationUsersRolesService.PostApplicationUsersUserIdSpaceRoles";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = Client.Post<UserSpaceRole>("/application-users/{userId}/space-roles",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostApplicationUsersUserIdSpaceRoles", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }


    }
}
