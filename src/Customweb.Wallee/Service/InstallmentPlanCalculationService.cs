
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Customweb.Wallee.Client;
using Customweb.Wallee.Model;

namespace Customweb.Wallee.Service
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInstallmentPlanCalculationService : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Calculate Plans
        /// </summary>
        /// <remarks>
        /// This operation allows to calculate all plans for the given transaction. The transaction will not be changed in any way.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The transaction for which the plans should be calculated for.</param>
        /// <returns>List&lt;InstallmentCalculatedPlan&gt;</returns>
        List<InstallmentCalculatedPlan> CalculatePlans (long? spaceId, long? transactionId);

        /// <summary>
        /// Calculate Plans
        /// </summary>
        /// <remarks>
        /// This operation allows to calculate all plans for the given transaction. The transaction will not be changed in any way.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The transaction for which the plans should be calculated for.</param>
        /// <returns>ApiResponse of List&lt;InstallmentCalculatedPlan&gt;</returns>
        ApiResponse<List<InstallmentCalculatedPlan>> CalculatePlansWithHttpInfo (long? spaceId, long? transactionId);

        #endregion Synchronous Operations
        #region Asynchronous Operations

        /// <summary>
        /// Calculate Plans
        /// </summary>
        /// <remarks>
        /// This operation allows to calculate all plans for the given transaction. The transaction will not be changed in any way.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The transaction for which the plans should be calculated for.</param>
        /// <returns>Task of List&lt;InstallmentCalculatedPlan&gt;</returns>
        System.Threading.Tasks.Task<List<InstallmentCalculatedPlan>> CalculatePlansAsync (long? spaceId, long? transactionId);

        /// <summary>
        /// Calculate Plans
        /// </summary>
        /// <remarks>
        /// This operation allows to calculate all plans for the given transaction. The transaction will not be changed in any way.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The transaction for which the plans should be calculated for.</param>
        /// <returns>Task of ApiResponse (List&lt;InstallmentCalculatedPlan&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<InstallmentCalculatedPlan>>> CalculatePlansAsyncWithHttpInfo (long? spaceId, long? transactionId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class InstallmentPlanCalculationService : IInstallmentPlanCalculationService
    {
        private readonly Customweb.Wallee.Client.ExceptionFactory _exceptionFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="InstallmentPlanCalculationService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public InstallmentPlanCalculationService(Configuration configuration = null)
        {
            this._configuration = CheckArgument.NotNull("configuration", configuration);
            this._apiClient = new ApiClient(configuration);
            this._exceptionFactory = Configuration.DefaultExceptionFactory;
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
        /// Calculate Plans This operation allows to calculate all plans for the given transaction. The transaction will not be changed in any way.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The transaction for which the plans should be calculated for.</param>
        /// <returns>List&lt;InstallmentCalculatedPlan&gt;</returns>
        public List<InstallmentCalculatedPlan> CalculatePlans (long? spaceId, long? transactionId)
        {
             ApiResponse<List<InstallmentCalculatedPlan>> localVarResponse = CalculatePlansWithHttpInfo(spaceId, transactionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Calculate Plans This operation allows to calculate all plans for the given transaction. The transaction will not be changed in any way.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The transaction for which the plans should be calculated for.</param>
        /// <returns>ApiResponse of List&lt;InstallmentCalculatedPlan&gt;</returns>
        public ApiResponse< List<InstallmentCalculatedPlan> > CalculatePlansWithHttpInfo (long? spaceId, long? transactionId)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling InstallmentPlanCalculationService->CalculatePlans");
            }
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
            {
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling InstallmentPlanCalculationService->CalculatePlans");
            }

            var localVarPath = "/installment-plan-calculation/calculatePlans";
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

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (transactionId != null) localVarQueryParams.Add("transactionId", ApiClient.ParameterToString(transactionId)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CalculatePlans", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<InstallmentCalculatedPlan>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InstallmentCalculatedPlan>) ApiClient.Deserialize(localVarResponse, typeof(List<InstallmentCalculatedPlan>)));
        }

        /// <summary>
        /// Calculate Plans This operation allows to calculate all plans for the given transaction. The transaction will not be changed in any way.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The transaction for which the plans should be calculated for.</param>
        /// <returns>Task of List&lt;InstallmentCalculatedPlan&gt;</returns>
        public async System.Threading.Tasks.Task<List<InstallmentCalculatedPlan>> CalculatePlansAsync (long? spaceId, long? transactionId)
        {
             ApiResponse<List<InstallmentCalculatedPlan>> localVarResponse = await CalculatePlansAsyncWithHttpInfo(spaceId, transactionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Calculate Plans This operation allows to calculate all plans for the given transaction. The transaction will not be changed in any way.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The transaction for which the plans should be calculated for.</param>
        /// <returns>Task of ApiResponse (List&lt;InstallmentCalculatedPlan&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<InstallmentCalculatedPlan>>> CalculatePlansAsyncWithHttpInfo (long? spaceId, long? transactionId)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling InstallmentPlanCalculationService->CalculatePlans");
            }
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
            {
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling InstallmentPlanCalculationService->CalculatePlans");
            }

            var localVarPath = "/installment-plan-calculation/calculatePlans";
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

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (transactionId != null) localVarQueryParams.Add("transactionId", ApiClient.ParameterToString(transactionId)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CalculatePlans", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<InstallmentCalculatedPlan>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InstallmentCalculatedPlan>) ApiClient.Deserialize(localVarResponse, typeof(List<InstallmentCalculatedPlan>)));
        }

    }
}
