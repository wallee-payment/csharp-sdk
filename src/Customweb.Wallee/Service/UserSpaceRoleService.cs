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
    public interface IUserSpaceRoleService : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Add Role
        /// </summary>
        /// <remarks>
        /// This operation grants the given role to the user in the given space.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to whom the role is assigned.</param>
        /// <param name="spaceId">The space to which the role is mapped.</param>
        /// <param name="roleId">The role which is mapped to the user and space.</param>
        /// <returns>UserSpaceRole</returns>
        UserSpaceRole AddRole (long? userId, long? spaceId, long? roleId);

        /// <summary>
        /// Add Role
        /// </summary>
        /// <remarks>
        /// This operation grants the given role to the user in the given space.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to whom the role is assigned.</param>
        /// <param name="spaceId">The space to which the role is mapped.</param>
        /// <param name="roleId">The role which is mapped to the user and space.</param>
        /// <returns>ApiResponse of UserSpaceRole</returns>
        ApiResponse<UserSpaceRole> AddRoleWithHttpInfo (long? userId, long? spaceId, long? roleId);

        /// <summary>
        /// List Roles
        /// </summary>
        /// <remarks>
        /// List all the roles that are assigned to the given user in the given space.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to whom the role is assigned.</param>
        /// <param name="spaceId">The space to which the role is mapped.</param>
        /// <returns>List&lt;UserSpaceRole&gt;</returns>
        List<UserSpaceRole> List (long? userId, long? spaceId);

        /// <summary>
        /// List Roles
        /// </summary>
        /// <remarks>
        /// List all the roles that are assigned to the given user in the given space.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to whom the role is assigned.</param>
        /// <param name="spaceId">The space to which the role is mapped.</param>
        /// <returns>ApiResponse of List&lt;UserSpaceRole&gt;</returns>
        ApiResponse<List<UserSpaceRole>> ListWithHttpInfo (long? userId, long? spaceId);

        /// <summary>
        /// Remove Role
        /// </summary>
        /// <remarks>
        /// This operation removes the specified user space role.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of user space role which should be removed</param>
        /// <returns></returns>
        void RemoveRole (long? id);

        /// <summary>
        /// Remove Role
        /// </summary>
        /// <remarks>
        /// This operation removes the specified user space role.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of user space role which should be removed</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> RemoveRoleWithHttpInfo (long? id);

        #endregion Synchronous Operations
        #region Asynchronous Operations

        /// <summary>
        /// Add Role
        /// </summary>
        /// <remarks>
        /// This operation grants the given role to the user in the given space.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to whom the role is assigned.</param>
        /// <param name="spaceId">The space to which the role is mapped.</param>
        /// <param name="roleId">The role which is mapped to the user and space.</param>
        /// <returns>Task of UserSpaceRole</returns>
        System.Threading.Tasks.Task<UserSpaceRole> AddRoleAsync (long? userId, long? spaceId, long? roleId);

        /// <summary>
        /// Add Role
        /// </summary>
        /// <remarks>
        /// This operation grants the given role to the user in the given space.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to whom the role is assigned.</param>
        /// <param name="spaceId">The space to which the role is mapped.</param>
        /// <param name="roleId">The role which is mapped to the user and space.</param>
        /// <returns>Task of ApiResponse (UserSpaceRole)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserSpaceRole>> AddRoleAsyncWithHttpInfo (long? userId, long? spaceId, long? roleId);

        /// <summary>
        /// List Roles
        /// </summary>
        /// <remarks>
        /// List all the roles that are assigned to the given user in the given space.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to whom the role is assigned.</param>
        /// <param name="spaceId">The space to which the role is mapped.</param>
        /// <returns>Task of List&lt;UserSpaceRole&gt;</returns>
        System.Threading.Tasks.Task<List<UserSpaceRole>> ListAsync (long? userId, long? spaceId);

        /// <summary>
        /// List Roles
        /// </summary>
        /// <remarks>
        /// List all the roles that are assigned to the given user in the given space.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to whom the role is assigned.</param>
        /// <param name="spaceId">The space to which the role is mapped.</param>
        /// <returns>Task of ApiResponse (List&lt;UserSpaceRole&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<UserSpaceRole>>> ListAsyncWithHttpInfo (long? userId, long? spaceId);

        /// <summary>
        /// Remove Role
        /// </summary>
        /// <remarks>
        /// This operation removes the specified user space role.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of user space role which should be removed</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task RemoveRoleAsync (long? id);

        /// <summary>
        /// Remove Role
        /// </summary>
        /// <remarks>
        /// This operation removes the specified user space role.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of user space role which should be removed</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> RemoveRoleAsyncWithHttpInfo (long? id);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UserSpaceRoleService : IUserSpaceRoleService
    {
        private readonly Customweb.Wallee.Client.ExceptionFactory _exceptionFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserSpaceRoleService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UserSpaceRoleService(Configuration configuration = null)
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
        /// Add Role This operation grants the given role to the user in the given space.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to whom the role is assigned.</param>
        /// <param name="spaceId">The space to which the role is mapped.</param>
        /// <param name="roleId">The role which is mapped to the user and space.</param>
        /// <returns>UserSpaceRole</returns>
        public UserSpaceRole AddRole (long? userId, long? spaceId, long? roleId)
        {
             ApiResponse<UserSpaceRole> localVarResponse = AddRoleWithHttpInfo(userId, spaceId, roleId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add Role This operation grants the given role to the user in the given space.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to whom the role is assigned.</param>
        /// <param name="spaceId">The space to which the role is mapped.</param>
        /// <param name="roleId">The role which is mapped to the user and space.</param>
        /// <returns>ApiResponse of UserSpaceRole</returns>
        public ApiResponse< UserSpaceRole > AddRoleWithHttpInfo (long? userId, long? spaceId, long? roleId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
            {
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserSpaceRoleService->AddRole");
            }
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling UserSpaceRoleService->AddRole");
            }
            // verify the required parameter 'roleId' is set
            if (roleId == null)
            {
                throw new ApiException(400, "Missing required parameter 'roleId' when calling UserSpaceRoleService->AddRole");
            }

            var localVarPath = "/user-space-role/addRole";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (userId != null) localVarQueryParams.Add("userId", ApiClient.ParameterToString(userId)); // query parameter
            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (roleId != null) localVarQueryParams.Add("roleId", ApiClient.ParameterToString(roleId)); // query parameter

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

            return new ApiResponse<UserSpaceRole>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserSpaceRole) ApiClient.Deserialize(localVarResponse, typeof(UserSpaceRole)));
        }

        /// <summary>
        /// Add Role This operation grants the given role to the user in the given space.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to whom the role is assigned.</param>
        /// <param name="spaceId">The space to which the role is mapped.</param>
        /// <param name="roleId">The role which is mapped to the user and space.</param>
        /// <returns>Task of UserSpaceRole</returns>
        public async System.Threading.Tasks.Task<UserSpaceRole> AddRoleAsync (long? userId, long? spaceId, long? roleId)
        {
             ApiResponse<UserSpaceRole> localVarResponse = await AddRoleAsyncWithHttpInfo(userId, spaceId, roleId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add Role This operation grants the given role to the user in the given space.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to whom the role is assigned.</param>
        /// <param name="spaceId">The space to which the role is mapped.</param>
        /// <param name="roleId">The role which is mapped to the user and space.</param>
        /// <returns>Task of ApiResponse (UserSpaceRole)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserSpaceRole>> AddRoleAsyncWithHttpInfo (long? userId, long? spaceId, long? roleId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
            {
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserSpaceRoleService->AddRole");
            }
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling UserSpaceRoleService->AddRole");
            }
            // verify the required parameter 'roleId' is set
            if (roleId == null)
            {
                throw new ApiException(400, "Missing required parameter 'roleId' when calling UserSpaceRoleService->AddRole");
            }

            var localVarPath = "/user-space-role/addRole";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (userId != null) localVarQueryParams.Add("userId", ApiClient.ParameterToString(userId)); // query parameter
            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (roleId != null) localVarQueryParams.Add("roleId", ApiClient.ParameterToString(roleId)); // query parameter

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

            return new ApiResponse<UserSpaceRole>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserSpaceRole) ApiClient.Deserialize(localVarResponse, typeof(UserSpaceRole)));
        }

        /// <summary>
        /// List Roles List all the roles that are assigned to the given user in the given space.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to whom the role is assigned.</param>
        /// <param name="spaceId">The space to which the role is mapped.</param>
        /// <returns>List&lt;UserSpaceRole&gt;</returns>
        public List<UserSpaceRole> List (long? userId, long? spaceId)
        {
             ApiResponse<List<UserSpaceRole>> localVarResponse = ListWithHttpInfo(userId, spaceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List Roles List all the roles that are assigned to the given user in the given space.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to whom the role is assigned.</param>
        /// <param name="spaceId">The space to which the role is mapped.</param>
        /// <returns>ApiResponse of List&lt;UserSpaceRole&gt;</returns>
        public ApiResponse< List<UserSpaceRole> > ListWithHttpInfo (long? userId, long? spaceId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
            {
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserSpaceRoleService->List");
            }
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling UserSpaceRoleService->List");
            }

            var localVarPath = "/user-space-role/list";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (userId != null) localVarQueryParams.Add("userId", ApiClient.ParameterToString(userId)); // query parameter
            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter

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

            return new ApiResponse<List<UserSpaceRole>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<UserSpaceRole>) ApiClient.Deserialize(localVarResponse, typeof(List<UserSpaceRole>)));
        }

        /// <summary>
        /// List Roles List all the roles that are assigned to the given user in the given space.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to whom the role is assigned.</param>
        /// <param name="spaceId">The space to which the role is mapped.</param>
        /// <returns>Task of List&lt;UserSpaceRole&gt;</returns>
        public async System.Threading.Tasks.Task<List<UserSpaceRole>> ListAsync (long? userId, long? spaceId)
        {
             ApiResponse<List<UserSpaceRole>> localVarResponse = await ListAsyncWithHttpInfo(userId, spaceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List Roles List all the roles that are assigned to the given user in the given space.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to whom the role is assigned.</param>
        /// <param name="spaceId">The space to which the role is mapped.</param>
        /// <returns>Task of ApiResponse (List&lt;UserSpaceRole&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<UserSpaceRole>>> ListAsyncWithHttpInfo (long? userId, long? spaceId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
            {
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserSpaceRoleService->List");
            }
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling UserSpaceRoleService->List");
            }

            var localVarPath = "/user-space-role/list";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (userId != null) localVarQueryParams.Add("userId", ApiClient.ParameterToString(userId)); // query parameter
            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter

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

            return new ApiResponse<List<UserSpaceRole>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<UserSpaceRole>) ApiClient.Deserialize(localVarResponse, typeof(List<UserSpaceRole>)));
        }

        /// <summary>
        /// Remove Role This operation removes the specified user space role.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of user space role which should be removed</param>
        /// <returns></returns>
        public void RemoveRole (long? id)
        {
             RemoveRoleWithHttpInfo(id);
        }

        /// <summary>
        /// Remove Role This operation removes the specified user space role.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of user space role which should be removed</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> RemoveRoleWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling UserSpaceRoleService->RemoveRole");
            }

            var localVarPath = "/user-space-role/removeRole";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
        /// Remove Role This operation removes the specified user space role.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of user space role which should be removed</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task RemoveRoleAsync (long? id)
        {
             await RemoveRoleAsyncWithHttpInfo(id);
        }

        /// <summary>
        /// Remove Role This operation removes the specified user space role.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of user space role which should be removed</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> RemoveRoleAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling UserSpaceRoleService->RemoveRole");
            }

            var localVarPath = "/user-space-role/removeRole";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
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
