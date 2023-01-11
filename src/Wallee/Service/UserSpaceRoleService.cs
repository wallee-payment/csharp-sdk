using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Wallee.Client;
using Wallee.Model;

namespace Wallee.Service
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of user space role which should be removed</param>
        /// <returns></returns>
        void RemoveRole (long? id);

        /// <summary>
        /// Remove Role
        /// </summary>
        /// <remarks>
        /// This operation removes the specified user space role.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of user space role which should be removed</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> RemoveRoleWithHttpInfo (long? id);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UserSpaceRoleService : IUserSpaceRoleService
    {
        private Wallee.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserSpaceRoleService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UserSpaceRoleService(Wallee.Client.Configuration configuration = null)
        {
            if(configuration == null){
                throw new ArgumentException("Parameter cannot be null", "configuration");
            }
            this.Configuration = configuration;

            ExceptionFactory = Wallee.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.Options.BaseUrl.ToString();
        }


        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Wallee.Client.Configuration Configuration {get; set;}

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
        /// Add Role This operation grants the given role to the user in the given space.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to whom the role is assigned.</param>
        /// <param name="spaceId">The space to which the role is mapped.</param>
        /// <param name="roleId">The role which is mapped to the user and space.</param>
        /// <returns>ApiResponse of UserSpaceRole</returns>
        public ApiResponse< UserSpaceRole > AddRoleWithHttpInfo (long? userId, long? spaceId, long? roleId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserSpaceRoleService->AddRole");
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling UserSpaceRoleService->AddRole");
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling UserSpaceRoleService->AddRole");

            var localVarPath = "/user-space-role/addRole";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content type
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            if (userId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "userId", userId)); // query parameter
            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (roleId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "roleId", roleId)); // query parameter

			
            int requestTimeout = this.Configuration.Timeout * 1000;

                // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddRole", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UserSpaceRole>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (UserSpaceRole) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserSpaceRole)));
        }
        /// <summary>
        /// List Roles List all the roles that are assigned to the given user in the given space.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to whom the role is assigned.</param>
        /// <param name="spaceId">The space to which the role is mapped.</param>
        /// <returns>ApiResponse of List&lt;UserSpaceRole&gt;</returns>
        public ApiResponse< List<UserSpaceRole> > ListWithHttpInfo (long? userId, long? spaceId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserSpaceRoleService->List");
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling UserSpaceRoleService->List");

            var localVarPath = "/user-space-role/list";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content type
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            if (userId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "userId", userId)); // query parameter
            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter

			
            int requestTimeout = this.Configuration.Timeout * 1000;

                // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("List", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<UserSpaceRole>>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (List<UserSpaceRole>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<UserSpaceRole>)));
        }
        /// <summary>
        /// Remove Role This operation removes the specified user space role.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of user space role which should be removed</param>
        /// <returns></returns>
        public void RemoveRole (long? id)
        {
             RemoveRoleWithHttpInfo(id);
        }

        /// <summary>
        /// Remove Role This operation removes the specified user space role.
        
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of user space role which should be removed</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> RemoveRoleWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling UserSpaceRoleService->RemoveRole");

            var localVarPath = "/user-space-role/removeRole";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content type
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter

			
            int requestTimeout = this.Configuration.Timeout * 1000;

                // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RemoveRole", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers
                    .GroupBy(x => x.Name, x => x.Value.ToString())
                    .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                null);
        }
    }
}
