using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.RegularExpressions;
using RestSharp;
using Wallee.Client;
using Wallee.Model;
using Wallee.Util;

namespace Wallee.Service
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of user account role which should be removed</param>
        /// <returns></returns>
        void RemoveRole (long? id);

        /// <summary>
        /// Remove Role
        /// </summary>
        /// <remarks>
        /// This operation removes the specified user account role.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of user account role which should be removed</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> RemoveRoleWithHttpInfo (long? id);



        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UserAccountRoleService : IUserAccountRoleService
    {
        private Wallee.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserAccountRoleService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UserAccountRoleService(Wallee.Client.Configuration configuration = null)
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
        /// Add Role This operation grants the role to the given user with in the given account.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to whom the role is assigned.</param>
        /// <param name="accountId">The account to which the role is mapped.</param>
        /// <param name="roleId">The role which is mapped to the user and account.</param>
        /// <param name="appliesOnSubaccount">Whether the role applies only on subaccount. (optional)</param>
        /// <returns>ApiResponse of UserAccountRole</returns>
        public ApiResponse< UserAccountRole > AddRoleWithHttpInfo (long? userId, long? accountId, long? roleId, bool? appliesOnSubaccount = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserAccountRoleService->AddRole");
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling UserAccountRoleService->AddRole");
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling UserAccountRoleService->AddRole");

            var localVarPath = "/user-account-role/addRole";
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
            if (accountId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "accountId", accountId)); // query parameter
            if (roleId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "roleId", roleId)); // query parameter
            if (appliesOnSubaccount != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "appliesOnSubaccount", appliesOnSubaccount)); // query parameter

			
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

            return new ApiResponse<UserAccountRole>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (UserAccountRole) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserAccountRole)));
        }
        /// <summary>
        /// List Roles List all the roles that are assigned to the given user in the given account.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The id of the user to whom the role is assigned.</param>
        /// <param name="accountId">The account to which the role is mapped.</param>
        /// <returns>ApiResponse of List&lt;UserAccountRole&gt;</returns>
        public ApiResponse< List<UserAccountRole> > ListWithHttpInfo (long? userId, long? accountId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserAccountRoleService->List");
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling UserAccountRoleService->List");

            var localVarPath = "/user-account-role/list";
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
            if (accountId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "accountId", accountId)); // query parameter

			
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

            return new ApiResponse<List<UserAccountRole>>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (List<UserAccountRole>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<UserAccountRole>)));
        }
        /// <summary>
        /// Remove Role This operation removes the specified user account role.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of user account role which should be removed</param>
        /// <returns></returns>
        public void RemoveRole (long? id)
        {
             RemoveRoleWithHttpInfo(id);
        }

        /// <summary>
        /// Remove Role This operation removes the specified user account role.
        
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of user account role which should be removed</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> RemoveRoleWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling UserAccountRoleService->RemoveRole");

            var localVarPath = "/user-account-role/removeRole";
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
