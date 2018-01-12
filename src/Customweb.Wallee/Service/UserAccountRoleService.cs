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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Customweb.Wallee.Client;
using Customweb.Wallee.Util;
using Customweb.Wallee.Model;

namespace Customweb.Wallee.Service
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserAccountRoleService : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Add Role
        /// </summary>
        /// <remarks>
        /// This operation grants the role to the given user with in the given account.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to whom the role is assigned.</param>
        /// <param name="accountId">The account to which the role is mapped.</param>
        /// <param name="roleId">The role which is mapped to the user and account.</param>
        /// <param name="appliesOnSubaccount">Whether the role applies only on subaccount. (optional)</param>
        /// <returns>UserAccountRole</returns>
        UserAccountRole AddRole (long? userId, long? accountId, long? roleId, bool? appliesOnSubaccount = null);

        /// <summary>
        /// Add Role
        /// </summary>
        /// <remarks>
        /// This operation grants the role to the given user with in the given account.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to whom the role is assigned.</param>
        /// <param name="accountId">The account to which the role is mapped.</param>
        /// <param name="roleId">The role which is mapped to the user and account.</param>
        /// <param name="appliesOnSubaccount">Whether the role applies only on subaccount. (optional)</param>
        /// <returns>ApiResponse of UserAccountRole</returns>
        ApiResponse<UserAccountRole> AddRoleWithHttpInfo (long? userId, long? accountId, long? roleId, bool? appliesOnSubaccount = null);

        /// <summary>
        /// List Roles
        /// </summary>
        /// <remarks>
        /// List all the roles that are assigned to the given user in the given account.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to whom the role is assigned.</param>
        /// <param name="accountId">The account to which the role is mapped.</param>
        /// <returns>List&lt;UserAccountRole&gt;</returns>
        List<UserAccountRole> List (long? userId, long? accountId);

        /// <summary>
        /// List Roles
        /// </summary>
        /// <remarks>
        /// List all the roles that are assigned to the given user in the given account.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to whom the role is assigned.</param>
        /// <param name="accountId">The account to which the role is mapped.</param>
        /// <returns>ApiResponse of List&lt;UserAccountRole&gt;</returns>
        ApiResponse<List<UserAccountRole>> ListWithHttpInfo (long? userId, long? accountId);

        /// <summary>
        /// Remove Role
        /// </summary>
        /// <remarks>
        /// This operation removes the specified user account role.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of user account role which should be removed</param>
        /// <returns></returns>
        void RemoveRole (long? id);

        /// <summary>
        /// Remove Role
        /// </summary>
        /// <remarks>
        /// This operation removes the specified user account role.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of user account role which should be removed</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> RemoveRoleWithHttpInfo (long? id);

        #endregion Synchronous Operations
        #region Asynchronous Operations

        /// <summary>
        /// Add Role
        /// </summary>
        /// <remarks>
        /// This operation grants the role to the given user with in the given account.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to whom the role is assigned.</param>
        /// <param name="accountId">The account to which the role is mapped.</param>
        /// <param name="roleId">The role which is mapped to the user and account.</param>
        /// <param name="appliesOnSubaccount">Whether the role applies only on subaccount. (optional)</param>
        /// <returns>Task of UserAccountRole</returns>
        System.Threading.Tasks.Task<UserAccountRole> AddRoleAsync (long? userId, long? accountId, long? roleId, bool? appliesOnSubaccount = null);

        /// <summary>
        /// Add Role
        /// </summary>
        /// <remarks>
        /// This operation grants the role to the given user with in the given account.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to whom the role is assigned.</param>
        /// <param name="accountId">The account to which the role is mapped.</param>
        /// <param name="roleId">The role which is mapped to the user and account.</param>
        /// <param name="appliesOnSubaccount">Whether the role applies only on subaccount. (optional)</param>
        /// <returns>Task of ApiResponse (UserAccountRole)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserAccountRole>> AddRoleAsyncWithHttpInfo (long? userId, long? accountId, long? roleId, bool? appliesOnSubaccount = null);

        /// <summary>
        /// List Roles
        /// </summary>
        /// <remarks>
        /// List all the roles that are assigned to the given user in the given account.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to whom the role is assigned.</param>
        /// <param name="accountId">The account to which the role is mapped.</param>
        /// <returns>Task of List&lt;UserAccountRole&gt;</returns>
        System.Threading.Tasks.Task<List<UserAccountRole>> ListAsync (long? userId, long? accountId);

        /// <summary>
        /// List Roles
        /// </summary>
        /// <remarks>
        /// List all the roles that are assigned to the given user in the given account.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to whom the role is assigned.</param>
        /// <param name="accountId">The account to which the role is mapped.</param>
        /// <returns>Task of ApiResponse (List&lt;UserAccountRole&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<UserAccountRole>>> ListAsyncWithHttpInfo (long? userId, long? accountId);

        /// <summary>
        /// Remove Role
        /// </summary>
        /// <remarks>
        /// This operation removes the specified user account role.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of user account role which should be removed</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task RemoveRoleAsync (long? id);

        /// <summary>
        /// Remove Role
        /// </summary>
        /// <remarks>
        /// This operation removes the specified user account role.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of user account role which should be removed</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> RemoveRoleAsyncWithHttpInfo (long? id);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UserAccountRoleService : IUserAccountRoleService
    {
        private readonly Customweb.Wallee.Client.ExceptionFactory _exceptionFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserAccountRoleService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UserAccountRoleService(Configuration configuration = null)
        {
            this._configuration = CheckArgument.NotNull("configuration", configuration);
            this._apiClient = new ApiClient(configuration);
            this._exceptionFactory = Configuration.ExceptionFactory;
        }

        private readonly ApiClient _apiClient;

        public ApiClient ApiClient
        {
            get { return _apiClient; }
        }

        private readonly Configuration _configuration;

        public Configuration Configuration
        {
            get { return _configuration; }
        }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Customweb.Wallee.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
        }

        /// <summary>
        /// Add Role This operation grants the role to the given user with in the given account.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to whom the role is assigned.</param>
        /// <param name="accountId">The account to which the role is mapped.</param>
        /// <param name="roleId">The role which is mapped to the user and account.</param>
        /// <param name="appliesOnSubaccount">Whether the role applies only on subaccount. (optional)</param>
        /// <returns>UserAccountRole</returns>
        public UserAccountRole AddRole (long? userId, long? accountId, long? roleId, bool? appliesOnSubaccount = null)
        {
             ApiResponse<UserAccountRole> localVarResponse = AddRoleWithHttpInfo(userId, accountId, roleId, appliesOnSubaccount);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add Role This operation grants the role to the given user with in the given account.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to whom the role is assigned.</param>
        /// <param name="accountId">The account to which the role is mapped.</param>
        /// <param name="roleId">The role which is mapped to the user and account.</param>
        /// <param name="appliesOnSubaccount">Whether the role applies only on subaccount. (optional)</param>
        /// <returns>ApiResponse of UserAccountRole</returns>
        public ApiResponse< UserAccountRole > AddRoleWithHttpInfo (long? userId, long? accountId, long? roleId, bool? appliesOnSubaccount = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
            {
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserAccountRoleService->AddRole");
            }
            // verify the required parameter 'accountId' is set
            if (accountId == null)
            {
                throw new ApiException(400, "Missing required parameter 'accountId' when calling UserAccountRoleService->AddRole");
            }
            // verify the required parameter 'roleId' is set
            if (roleId == null)
            {
                throw new ApiException(400, "Missing required parameter 'roleId' when calling UserAccountRoleService->AddRole");
            }

            var localVarPath = "/user-account-role/addRole";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (userId != null) localVarQueryParams.Add("userId", ApiClient.ParameterToString(userId)); // query parameter
            if (accountId != null) localVarQueryParams.Add("accountId", ApiClient.ParameterToString(accountId)); // query parameter
            if (roleId != null) localVarQueryParams.Add("roleId", ApiClient.ParameterToString(roleId)); // query parameter
            if (appliesOnSubaccount != null) localVarQueryParams.Add("appliesOnSubaccount", ApiClient.ParameterToString(appliesOnSubaccount)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddRole", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UserAccountRole>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserAccountRole) ApiClient.Deserialize(localVarResponse, typeof(UserAccountRole)));
        }

        /// <summary>
        /// Add Role This operation grants the role to the given user with in the given account.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to whom the role is assigned.</param>
        /// <param name="accountId">The account to which the role is mapped.</param>
        /// <param name="roleId">The role which is mapped to the user and account.</param>
        /// <param name="appliesOnSubaccount">Whether the role applies only on subaccount. (optional)</param>
        /// <returns>Task of UserAccountRole</returns>
        public async System.Threading.Tasks.Task<UserAccountRole> AddRoleAsync (long? userId, long? accountId, long? roleId, bool? appliesOnSubaccount = null)
        {
             ApiResponse<UserAccountRole> localVarResponse = await AddRoleAsyncWithHttpInfo(userId, accountId, roleId, appliesOnSubaccount);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add Role This operation grants the role to the given user with in the given account.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to whom the role is assigned.</param>
        /// <param name="accountId">The account to which the role is mapped.</param>
        /// <param name="roleId">The role which is mapped to the user and account.</param>
        /// <param name="appliesOnSubaccount">Whether the role applies only on subaccount. (optional)</param>
        /// <returns>Task of ApiResponse (UserAccountRole)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserAccountRole>> AddRoleAsyncWithHttpInfo (long? userId, long? accountId, long? roleId, bool? appliesOnSubaccount = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
            {
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserAccountRoleService->AddRole");
            }
            // verify the required parameter 'accountId' is set
            if (accountId == null)
            {
                throw new ApiException(400, "Missing required parameter 'accountId' when calling UserAccountRoleService->AddRole");
            }
            // verify the required parameter 'roleId' is set
            if (roleId == null)
            {
                throw new ApiException(400, "Missing required parameter 'roleId' when calling UserAccountRoleService->AddRole");
            }

            var localVarPath = "/user-account-role/addRole";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (userId != null) localVarQueryParams.Add("userId", ApiClient.ParameterToString(userId)); // query parameter
            if (accountId != null) localVarQueryParams.Add("accountId", ApiClient.ParameterToString(accountId)); // query parameter
            if (roleId != null) localVarQueryParams.Add("roleId", ApiClient.ParameterToString(roleId)); // query parameter
            if (appliesOnSubaccount != null) localVarQueryParams.Add("appliesOnSubaccount", ApiClient.ParameterToString(appliesOnSubaccount)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddRole", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UserAccountRole>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserAccountRole) ApiClient.Deserialize(localVarResponse, typeof(UserAccountRole)));
        }

        /// <summary>
        /// List Roles List all the roles that are assigned to the given user in the given account.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to whom the role is assigned.</param>
        /// <param name="accountId">The account to which the role is mapped.</param>
        /// <returns>List&lt;UserAccountRole&gt;</returns>
        public List<UserAccountRole> List (long? userId, long? accountId)
        {
             ApiResponse<List<UserAccountRole>> localVarResponse = ListWithHttpInfo(userId, accountId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List Roles List all the roles that are assigned to the given user in the given account.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to whom the role is assigned.</param>
        /// <param name="accountId">The account to which the role is mapped.</param>
        /// <returns>ApiResponse of List&lt;UserAccountRole&gt;</returns>
        public ApiResponse< List<UserAccountRole> > ListWithHttpInfo (long? userId, long? accountId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
            {
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserAccountRoleService->List");
            }
            // verify the required parameter 'accountId' is set
            if (accountId == null)
            {
                throw new ApiException(400, "Missing required parameter 'accountId' when calling UserAccountRoleService->List");
            }

            var localVarPath = "/user-account-role/list";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (userId != null) localVarQueryParams.Add("userId", ApiClient.ParameterToString(userId)); // query parameter
            if (accountId != null) localVarQueryParams.Add("accountId", ApiClient.ParameterToString(accountId)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("List", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<UserAccountRole>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<UserAccountRole>) ApiClient.Deserialize(localVarResponse, typeof(List<UserAccountRole>)));
        }

        /// <summary>
        /// List Roles List all the roles that are assigned to the given user in the given account.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to whom the role is assigned.</param>
        /// <param name="accountId">The account to which the role is mapped.</param>
        /// <returns>Task of List&lt;UserAccountRole&gt;</returns>
        public async System.Threading.Tasks.Task<List<UserAccountRole>> ListAsync (long? userId, long? accountId)
        {
             ApiResponse<List<UserAccountRole>> localVarResponse = await ListAsyncWithHttpInfo(userId, accountId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List Roles List all the roles that are assigned to the given user in the given account.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to whom the role is assigned.</param>
        /// <param name="accountId">The account to which the role is mapped.</param>
        /// <returns>Task of ApiResponse (List&lt;UserAccountRole&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<UserAccountRole>>> ListAsyncWithHttpInfo (long? userId, long? accountId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
            {
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserAccountRoleService->List");
            }
            // verify the required parameter 'accountId' is set
            if (accountId == null)
            {
                throw new ApiException(400, "Missing required parameter 'accountId' when calling UserAccountRoleService->List");
            }

            var localVarPath = "/user-account-role/list";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (userId != null) localVarQueryParams.Add("userId", ApiClient.ParameterToString(userId)); // query parameter
            if (accountId != null) localVarQueryParams.Add("accountId", ApiClient.ParameterToString(accountId)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("List", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<UserAccountRole>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<UserAccountRole>) ApiClient.Deserialize(localVarResponse, typeof(List<UserAccountRole>)));
        }

        /// <summary>
        /// Remove Role This operation removes the specified user account role.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of user account role which should be removed</param>
        /// <returns></returns>
        public void RemoveRole (long? id)
        {
             RemoveRoleWithHttpInfo(id);
        }

        /// <summary>
        /// Remove Role This operation removes the specified user account role.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of user account role which should be removed</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> RemoveRoleWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling UserAccountRoleService->RemoveRole");
            }

            var localVarPath = "/user-account-role/removeRole";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RemoveRole", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Remove Role This operation removes the specified user account role.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of user account role which should be removed</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task RemoveRoleAsync (long? id)
        {
             await RemoveRoleAsyncWithHttpInfo(id);
        }

        /// <summary>
        /// Remove Role This operation removes the specified user account role.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of user account role which should be removed</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> RemoveRoleAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling UserAccountRoleService->RemoveRole");
            }

            var localVarPath = "/user-account-role/removeRole";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RemoveRole", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}
