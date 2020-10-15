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
    public interface IInstallmentPlanCalculationService : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Calculate Plans
        /// </summary>
        /// <remarks>
        /// This operation allows to calculate all plans for the given transaction. The transaction will not be changed in any way.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The transaction for which the plans should be calculated for.</param>
        /// <returns>ApiResponse of List&lt;InstallmentCalculatedPlan&gt;</returns>
        ApiResponse<List<InstallmentCalculatedPlan>> CalculatePlansWithHttpInfo (long? spaceId, long? transactionId);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class InstallmentPlanCalculationService : IInstallmentPlanCalculationService
    {
        private Wallee.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="InstallmentPlanCalculationService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public InstallmentPlanCalculationService(Wallee.Client.Configuration configuration = null)
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
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
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
        /// Calculate Plans This operation allows to calculate all plans for the given transaction. The transaction will not be changed in any way.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="transactionId">The transaction for which the plans should be calculated for.</param>
        /// <returns>ApiResponse of List&lt;InstallmentCalculatedPlan&gt;</returns>
        public ApiResponse< List<InstallmentCalculatedPlan> > CalculatePlansWithHttpInfo (long? spaceId, long? transactionId)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling InstallmentPlanCalculationService->CalculatePlans");
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling InstallmentPlanCalculationService->CalculatePlans");

            var localVarPath = "/installment-plan-calculation/calculatePlans";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (transactionId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "transactionId", transactionId)); // query parameter

			
			this.Configuration.ApiClient.ResetTimeout();
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
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
                (List<InstallmentCalculatedPlan>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<InstallmentCalculatedPlan>)));
        }
    }
}
