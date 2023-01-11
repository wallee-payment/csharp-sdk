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
    public interface IPaymentWebAppService : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Activate Processor for Production
        /// </summary>
        /// <remarks>
        /// This operation marks the processor to be usable within the production environment.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">The space ID identifies the space in which the processor is installed in.</param>
        /// <param name="externalId">The external ID identifies the processor. The external ID corresponds to the ID provided during inserting of the processor.</param>
        /// <returns>PaymentAppProcessor</returns>
        PaymentAppProcessor ActivateProcessorForProduction (long? spaceId, string externalId);

        /// <summary>
        /// Activate Processor for Production
        /// </summary>
        /// <remarks>
        /// This operation marks the processor to be usable within the production environment.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">The space ID identifies the space in which the processor is installed in.</param>
        /// <param name="externalId">The external ID identifies the processor. The external ID corresponds to the ID provided during inserting of the processor.</param>
        /// <returns>ApiResponse of PaymentAppProcessor</returns>
        ApiResponse<PaymentAppProcessor> ActivateProcessorForProductionWithHttpInfo (long? spaceId, string externalId);
        /// <summary>
        /// Delete Connector
        /// </summary>
        /// <remarks>
        /// This operation removes the web app payment connector from the given space.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">The space ID identifies the space in which the connector is installed in.</param>
        /// <param name="externalId">The external ID identifies the connector. The external ID corresponds to the ID provided during inserting of the connector.</param>
        /// <returns></returns>
        void DeleteConnector (long? spaceId, string externalId);

        /// <summary>
        /// Delete Connector
        /// </summary>
        /// <remarks>
        /// This operation removes the web app payment connector from the given space.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">The space ID identifies the space in which the connector is installed in.</param>
        /// <param name="externalId">The external ID identifies the connector. The external ID corresponds to the ID provided during inserting of the connector.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteConnectorWithHttpInfo (long? spaceId, string externalId);
        /// <summary>
        /// Delete Processor
        /// </summary>
        /// <remarks>
        /// This operation removes the web app payment processor and its connectors from the given space.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">The space ID identifies the space in which the processor is installed in.</param>
        /// <param name="externalId">The external ID identifies the processor. The external ID corresponds to the ID provided during inserting of the processor.</param>
        /// <returns></returns>
        void DeleteProcessor (long? spaceId, string externalId);

        /// <summary>
        /// Delete Processor
        /// </summary>
        /// <remarks>
        /// This operation removes the web app payment processor and its connectors from the given space.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">The space ID identifies the space in which the processor is installed in.</param>
        /// <param name="externalId">The external ID identifies the processor. The external ID corresponds to the ID provided during inserting of the processor.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteProcessorWithHttpInfo (long? spaceId, string externalId);
        /// <summary>
        /// Insert or Update Connector
        /// </summary>
        /// <remarks>
        /// This operation inserts or updates a web app payment connector.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">The space ID identifies the space into which the connector should be inserted into.</param>
        /// <param name="request">The connector object contains all the details required to create or update a web app connector.</param>
        /// <returns>PaymentAppConnector</returns>
        PaymentAppConnector InsertOrUpdateConnector (long? spaceId, PaymentAppConnectorCreationRequest request);

        /// <summary>
        /// Insert or Update Connector
        /// </summary>
        /// <remarks>
        /// This operation inserts or updates a web app payment connector.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">The space ID identifies the space into which the connector should be inserted into.</param>
        /// <param name="request">The connector object contains all the details required to create or update a web app connector.</param>
        /// <returns>ApiResponse of PaymentAppConnector</returns>
        ApiResponse<PaymentAppConnector> InsertOrUpdateConnectorWithHttpInfo (long? spaceId, PaymentAppConnectorCreationRequest request);
        /// <summary>
        /// Insert or Update Processor
        /// </summary>
        /// <remarks>
        /// This operation inserts or updates a web app payment processor.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">The space ID identifies the space into which the processor should be inserted into.</param>
        /// <param name="request">The processor object contains all the details required to create or update a web app processor.</param>
        /// <returns>PaymentAppProcessor</returns>
        PaymentAppProcessor InsertOrUpdateProcessor (long? spaceId, PaymentAppProcessorCreationRequest request);

        /// <summary>
        /// Insert or Update Processor
        /// </summary>
        /// <remarks>
        /// This operation inserts or updates a web app payment processor.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">The space ID identifies the space into which the processor should be inserted into.</param>
        /// <param name="request">The processor object contains all the details required to create or update a web app processor.</param>
        /// <returns>ApiResponse of PaymentAppProcessor</returns>
        ApiResponse<PaymentAppProcessor> InsertOrUpdateProcessorWithHttpInfo (long? spaceId, PaymentAppProcessorCreationRequest request);
        /// <summary>
        /// Update Charge Attempt
        /// </summary>
        /// <remarks>
        /// This operation updates the state of the charge attempt. This method can be invoked for transactions originally created with a processor associated with the web app that invokes this operation. The returned charge attempt corresponds to the charge attempt indicated in the request.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">This is the ID of the space in which the charge attempt is located in.</param>
        /// <param name="request">The charge attempt update request allows to update the state of a charge attempt.</param>
        /// <returns>ChargeAttempt</returns>
        ChargeAttempt UpdateChargeAttempt (long? spaceId, PaymentAppChargeAttemptUpdateRequest request);

        /// <summary>
        /// Update Charge Attempt
        /// </summary>
        /// <remarks>
        /// This operation updates the state of the charge attempt. This method can be invoked for transactions originally created with a processor associated with the web app that invokes this operation. The returned charge attempt corresponds to the charge attempt indicated in the request.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">This is the ID of the space in which the charge attempt is located in.</param>
        /// <param name="request">The charge attempt update request allows to update the state of a charge attempt.</param>
        /// <returns>ApiResponse of ChargeAttempt</returns>
        ApiResponse<ChargeAttempt> UpdateChargeAttemptWithHttpInfo (long? spaceId, PaymentAppChargeAttemptUpdateRequest request);
        /// <summary>
        /// Update Completion
        /// </summary>
        /// <remarks>
        /// This operation updates the state of the transaction completion. This method can be invoked for transactions originally created with a processor associated with the web app that invokes this operation. The returned completion corresponds to the completion indicated in the request.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">This is the ID of the space in which the completion is located in.</param>
        /// <param name="request">The completion update request allows to update the state of a completion.</param>
        /// <returns>TransactionCompletion</returns>
        TransactionCompletion UpdateCompletion (long? spaceId, PaymentAppCompletionUpdateRequest request);

        /// <summary>
        /// Update Completion
        /// </summary>
        /// <remarks>
        /// This operation updates the state of the transaction completion. This method can be invoked for transactions originally created with a processor associated with the web app that invokes this operation. The returned completion corresponds to the completion indicated in the request.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">This is the ID of the space in which the completion is located in.</param>
        /// <param name="request">The completion update request allows to update the state of a completion.</param>
        /// <returns>ApiResponse of TransactionCompletion</returns>
        ApiResponse<TransactionCompletion> UpdateCompletionWithHttpInfo (long? spaceId, PaymentAppCompletionUpdateRequest request);
        /// <summary>
        /// Update Refund
        /// </summary>
        /// <remarks>
        /// This operation updates the state of the refund. This method can be invoked for transactions originally created with a processor associated with the web app that invokes this operation. The returned refund corresponds to the refund indicated in the request.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">This is the ID of the space in which the refund is located in.</param>
        /// <param name="request">The refund update request allows to update the state of a refund.</param>
        /// <returns>Refund</returns>
        Refund UpdateRefund (long? spaceId, PaymentAppRefundUpdateRequest request);

        /// <summary>
        /// Update Refund
        /// </summary>
        /// <remarks>
        /// This operation updates the state of the refund. This method can be invoked for transactions originally created with a processor associated with the web app that invokes this operation. The returned refund corresponds to the refund indicated in the request.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">This is the ID of the space in which the refund is located in.</param>
        /// <param name="request">The refund update request allows to update the state of a refund.</param>
        /// <returns>ApiResponse of Refund</returns>
        ApiResponse<Refund> UpdateRefundWithHttpInfo (long? spaceId, PaymentAppRefundUpdateRequest request);
        /// <summary>
        /// Update Void
        /// </summary>
        /// <remarks>
        /// This operation updates the state of the transaction void. This method can be invoked for transactions originally created with a processor associated with the web app that invokes this operation. The returned void corresponds to the void indicated in the request.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">This is the ID of the space in which the void is located in.</param>
        /// <param name="request">The void update request allows to update the state of a void.</param>
        /// <returns>TransactionVoid</returns>
        TransactionVoid UpdateVoid (long? spaceId, PaymentAppVoidUpdateRequest request);

        /// <summary>
        /// Update Void
        /// </summary>
        /// <remarks>
        /// This operation updates the state of the transaction void. This method can be invoked for transactions originally created with a processor associated with the web app that invokes this operation. The returned void corresponds to the void indicated in the request.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">This is the ID of the space in which the void is located in.</param>
        /// <param name="request">The void update request allows to update the state of a void.</param>
        /// <returns>ApiResponse of TransactionVoid</returns>
        ApiResponse<TransactionVoid> UpdateVoidWithHttpInfo (long? spaceId, PaymentAppVoidUpdateRequest request);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PaymentWebAppService : IPaymentWebAppService
    {
        private Wallee.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentWebAppService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PaymentWebAppService(Wallee.Client.Configuration configuration = null)
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
        /// Activate Processor for Production This operation marks the processor to be usable within the production environment.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">The space ID identifies the space in which the processor is installed in.</param>
        /// <param name="externalId">The external ID identifies the processor. The external ID corresponds to the ID provided during inserting of the processor.</param>
        /// <returns>PaymentAppProcessor</returns>
        public PaymentAppProcessor ActivateProcessorForProduction (long? spaceId, string externalId)
        {
             ApiResponse<PaymentAppProcessor> localVarResponse = ActivateProcessorForProductionWithHttpInfo(spaceId, externalId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Activate Processor for Production This operation marks the processor to be usable within the production environment.
        
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">The space ID identifies the space in which the processor is installed in.</param>
        /// <param name="externalId">The external ID identifies the processor. The external ID corresponds to the ID provided during inserting of the processor.</param>
        /// <returns>ApiResponse of PaymentAppProcessor</returns>
        public ApiResponse< PaymentAppProcessor > ActivateProcessorForProductionWithHttpInfo (long? spaceId, string externalId)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling PaymentWebAppService->ActivateProcessorForProduction");
            // verify the required parameter 'externalId' is set
            if (externalId == null)
                throw new ApiException(400, "Missing required parameter 'externalId' when calling PaymentWebAppService->ActivateProcessorForProduction");

            var localVarPath = "/payment-web-app/activate-processor-for-production";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content type
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (externalId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "externalId", externalId)); // query parameter

			
            int requestTimeout = this.Configuration.Timeout * 1000;

                // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ActivateProcessorForProduction", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PaymentAppProcessor>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (PaymentAppProcessor) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaymentAppProcessor)));
        }
        /// <summary>
        /// Delete Connector This operation removes the web app payment connector from the given space.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">The space ID identifies the space in which the connector is installed in.</param>
        /// <param name="externalId">The external ID identifies the connector. The external ID corresponds to the ID provided during inserting of the connector.</param>
        /// <returns></returns>
        public void DeleteConnector (long? spaceId, string externalId)
        {
             DeleteConnectorWithHttpInfo(spaceId, externalId);
        }

        /// <summary>
        /// Delete Connector This operation removes the web app payment connector from the given space.
        
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">The space ID identifies the space in which the connector is installed in.</param>
        /// <param name="externalId">The external ID identifies the connector. The external ID corresponds to the ID provided during inserting of the connector.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteConnectorWithHttpInfo (long? spaceId, string externalId)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling PaymentWebAppService->DeleteConnector");
            // verify the required parameter 'externalId' is set
            if (externalId == null)
                throw new ApiException(400, "Missing required parameter 'externalId' when calling PaymentWebAppService->DeleteConnector");

            var localVarPath = "/payment-web-app/delete-connector";
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

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (externalId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "externalId", externalId)); // query parameter

			
            int requestTimeout = this.Configuration.Timeout * 1000;

                // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteConnector", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers
                    .GroupBy(x => x.Name, x => x.Value.ToString())
                    .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                null);
        }
        /// <summary>
        /// Delete Processor This operation removes the web app payment processor and its connectors from the given space.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">The space ID identifies the space in which the processor is installed in.</param>
        /// <param name="externalId">The external ID identifies the processor. The external ID corresponds to the ID provided during inserting of the processor.</param>
        /// <returns></returns>
        public void DeleteProcessor (long? spaceId, string externalId)
        {
             DeleteProcessorWithHttpInfo(spaceId, externalId);
        }

        /// <summary>
        /// Delete Processor This operation removes the web app payment processor and its connectors from the given space.
        
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">The space ID identifies the space in which the processor is installed in.</param>
        /// <param name="externalId">The external ID identifies the processor. The external ID corresponds to the ID provided during inserting of the processor.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteProcessorWithHttpInfo (long? spaceId, string externalId)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling PaymentWebAppService->DeleteProcessor");
            // verify the required parameter 'externalId' is set
            if (externalId == null)
                throw new ApiException(400, "Missing required parameter 'externalId' when calling PaymentWebAppService->DeleteProcessor");

            var localVarPath = "/payment-web-app/delete-processor";
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

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (externalId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "externalId", externalId)); // query parameter

			
            int requestTimeout = this.Configuration.Timeout * 1000;

                // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteProcessor", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers
                    .GroupBy(x => x.Name, x => x.Value.ToString())
                    .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                null);
        }
        /// <summary>
        /// Insert or Update Connector This operation inserts or updates a web app payment connector.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">The space ID identifies the space into which the connector should be inserted into.</param>
        /// <param name="request">The connector object contains all the details required to create or update a web app connector.</param>
        /// <returns>PaymentAppConnector</returns>
        public PaymentAppConnector InsertOrUpdateConnector (long? spaceId, PaymentAppConnectorCreationRequest request)
        {
             ApiResponse<PaymentAppConnector> localVarResponse = InsertOrUpdateConnectorWithHttpInfo(spaceId, request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Insert or Update Connector This operation inserts or updates a web app payment connector.
        
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">The space ID identifies the space into which the connector should be inserted into.</param>
        /// <param name="request">The connector object contains all the details required to create or update a web app connector.</param>
        /// <returns>ApiResponse of PaymentAppConnector</returns>
        public ApiResponse< PaymentAppConnector > InsertOrUpdateConnectorWithHttpInfo (long? spaceId, PaymentAppConnectorCreationRequest request)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling PaymentWebAppService->InsertOrUpdateConnector");
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling PaymentWebAppService->InsertOrUpdateConnector");

            var localVarPath = "/payment-web-app/insert-or-update-connector";
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

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

			
            int requestTimeout = this.Configuration.Timeout * 1000;

                // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("InsertOrUpdateConnector", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PaymentAppConnector>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (PaymentAppConnector) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaymentAppConnector)));
        }
        /// <summary>
        /// Insert or Update Processor This operation inserts or updates a web app payment processor.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">The space ID identifies the space into which the processor should be inserted into.</param>
        /// <param name="request">The processor object contains all the details required to create or update a web app processor.</param>
        /// <returns>PaymentAppProcessor</returns>
        public PaymentAppProcessor InsertOrUpdateProcessor (long? spaceId, PaymentAppProcessorCreationRequest request)
        {
             ApiResponse<PaymentAppProcessor> localVarResponse = InsertOrUpdateProcessorWithHttpInfo(spaceId, request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Insert or Update Processor This operation inserts or updates a web app payment processor.
        
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">The space ID identifies the space into which the processor should be inserted into.</param>
        /// <param name="request">The processor object contains all the details required to create or update a web app processor.</param>
        /// <returns>ApiResponse of PaymentAppProcessor</returns>
        public ApiResponse< PaymentAppProcessor > InsertOrUpdateProcessorWithHttpInfo (long? spaceId, PaymentAppProcessorCreationRequest request)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling PaymentWebAppService->InsertOrUpdateProcessor");
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling PaymentWebAppService->InsertOrUpdateProcessor");

            var localVarPath = "/payment-web-app/insert-or-update-processor";
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

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

			
            int requestTimeout = this.Configuration.Timeout * 1000;

                // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("InsertOrUpdateProcessor", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PaymentAppProcessor>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (PaymentAppProcessor) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaymentAppProcessor)));
        }
        /// <summary>
        /// Update Charge Attempt This operation updates the state of the charge attempt. This method can be invoked for transactions originally created with a processor associated with the web app that invokes this operation. The returned charge attempt corresponds to the charge attempt indicated in the request.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">This is the ID of the space in which the charge attempt is located in.</param>
        /// <param name="request">The charge attempt update request allows to update the state of a charge attempt.</param>
        /// <returns>ChargeAttempt</returns>
        public ChargeAttempt UpdateChargeAttempt (long? spaceId, PaymentAppChargeAttemptUpdateRequest request)
        {
             ApiResponse<ChargeAttempt> localVarResponse = UpdateChargeAttemptWithHttpInfo(spaceId, request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update Charge Attempt This operation updates the state of the charge attempt. This method can be invoked for transactions originally created with a processor associated with the web app that invokes this operation. The returned charge attempt corresponds to the charge attempt indicated in the request.
        
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">This is the ID of the space in which the charge attempt is located in.</param>
        /// <param name="request">The charge attempt update request allows to update the state of a charge attempt.</param>
        /// <returns>ApiResponse of ChargeAttempt</returns>
        public ApiResponse< ChargeAttempt > UpdateChargeAttemptWithHttpInfo (long? spaceId, PaymentAppChargeAttemptUpdateRequest request)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling PaymentWebAppService->UpdateChargeAttempt");
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling PaymentWebAppService->UpdateChargeAttempt");

            var localVarPath = "/payment-web-app/update-charge-attempt";
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

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

			
            int requestTimeout = this.Configuration.Timeout * 1000;

                // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateChargeAttempt", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ChargeAttempt>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (ChargeAttempt) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ChargeAttempt)));
        }
        /// <summary>
        /// Update Completion This operation updates the state of the transaction completion. This method can be invoked for transactions originally created with a processor associated with the web app that invokes this operation. The returned completion corresponds to the completion indicated in the request.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">This is the ID of the space in which the completion is located in.</param>
        /// <param name="request">The completion update request allows to update the state of a completion.</param>
        /// <returns>TransactionCompletion</returns>
        public TransactionCompletion UpdateCompletion (long? spaceId, PaymentAppCompletionUpdateRequest request)
        {
             ApiResponse<TransactionCompletion> localVarResponse = UpdateCompletionWithHttpInfo(spaceId, request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update Completion This operation updates the state of the transaction completion. This method can be invoked for transactions originally created with a processor associated with the web app that invokes this operation. The returned completion corresponds to the completion indicated in the request.
        
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">This is the ID of the space in which the completion is located in.</param>
        /// <param name="request">The completion update request allows to update the state of a completion.</param>
        /// <returns>ApiResponse of TransactionCompletion</returns>
        public ApiResponse< TransactionCompletion > UpdateCompletionWithHttpInfo (long? spaceId, PaymentAppCompletionUpdateRequest request)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling PaymentWebAppService->UpdateCompletion");
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling PaymentWebAppService->UpdateCompletion");

            var localVarPath = "/payment-web-app/update-completion";
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

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

			
            int requestTimeout = this.Configuration.Timeout * 1000;

                // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateCompletion", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransactionCompletion>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (TransactionCompletion) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransactionCompletion)));
        }
        /// <summary>
        /// Update Refund This operation updates the state of the refund. This method can be invoked for transactions originally created with a processor associated with the web app that invokes this operation. The returned refund corresponds to the refund indicated in the request.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">This is the ID of the space in which the refund is located in.</param>
        /// <param name="request">The refund update request allows to update the state of a refund.</param>
        /// <returns>Refund</returns>
        public Refund UpdateRefund (long? spaceId, PaymentAppRefundUpdateRequest request)
        {
             ApiResponse<Refund> localVarResponse = UpdateRefundWithHttpInfo(spaceId, request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update Refund This operation updates the state of the refund. This method can be invoked for transactions originally created with a processor associated with the web app that invokes this operation. The returned refund corresponds to the refund indicated in the request.
        
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">This is the ID of the space in which the refund is located in.</param>
        /// <param name="request">The refund update request allows to update the state of a refund.</param>
        /// <returns>ApiResponse of Refund</returns>
        public ApiResponse< Refund > UpdateRefundWithHttpInfo (long? spaceId, PaymentAppRefundUpdateRequest request)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling PaymentWebAppService->UpdateRefund");
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling PaymentWebAppService->UpdateRefund");

            var localVarPath = "/payment-web-app/update-refund";
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

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

			
            int requestTimeout = this.Configuration.Timeout * 1000;

                // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateRefund", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Refund>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (Refund) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Refund)));
        }
        /// <summary>
        /// Update Void This operation updates the state of the transaction void. This method can be invoked for transactions originally created with a processor associated with the web app that invokes this operation. The returned void corresponds to the void indicated in the request.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">This is the ID of the space in which the void is located in.</param>
        /// <param name="request">The void update request allows to update the state of a void.</param>
        /// <returns>TransactionVoid</returns>
        public TransactionVoid UpdateVoid (long? spaceId, PaymentAppVoidUpdateRequest request)
        {
             ApiResponse<TransactionVoid> localVarResponse = UpdateVoidWithHttpInfo(spaceId, request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update Void This operation updates the state of the transaction void. This method can be invoked for transactions originally created with a processor associated with the web app that invokes this operation. The returned void corresponds to the void indicated in the request.
        
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId">This is the ID of the space in which the void is located in.</param>
        /// <param name="request">The void update request allows to update the state of a void.</param>
        /// <returns>ApiResponse of TransactionVoid</returns>
        public ApiResponse< TransactionVoid > UpdateVoidWithHttpInfo (long? spaceId, PaymentAppVoidUpdateRequest request)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling PaymentWebAppService->UpdateVoid");
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling PaymentWebAppService->UpdateVoid");

            var localVarPath = "/payment-web-app/update-void";
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

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

			
            int requestTimeout = this.Configuration.Timeout * 1000;

                // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateVoid", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransactionVoid>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (TransactionVoid) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransactionVoid)));
        }
    }
}
