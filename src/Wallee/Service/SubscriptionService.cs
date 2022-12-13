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
    public interface ISubscriptionService : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// apply changes
        /// </summary>
        /// <remarks>
        /// This operation allows to apply changes on a subscription.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="request"></param>
        /// <returns>SubscriptionVersion</returns>
        SubscriptionVersion ApplyChanges (long? spaceId, SubscriptionChangeRequest request);

        /// <summary>
        /// apply changes
        /// </summary>
        /// <remarks>
        /// This operation allows to apply changes on a subscription.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="request"></param>
        /// <returns>ApiResponse of SubscriptionVersion</returns>
        ApiResponse<SubscriptionVersion> ApplyChangesWithHttpInfo (long? spaceId, SubscriptionChangeRequest request);
        /// <summary>
        /// Count
        /// </summary>
        /// <remarks>
        /// Counts the number of items in the database as restricted by the given filter.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>long?</returns>
        long? Count (long? spaceId, EntityQueryFilter filter = null);

        /// <summary>
        /// Count
        /// </summary>
        /// <remarks>
        /// Counts the number of items in the database as restricted by the given filter.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>ApiResponse of long?</returns>
        ApiResponse<long?> CountWithHttpInfo (long? spaceId, EntityQueryFilter filter = null);
        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// The create operation creates a new subscription and a corresponding subscription version.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="createRequest"></param>
        /// <returns>SubscriptionVersion</returns>
        SubscriptionVersion Create (long? spaceId, SubscriptionCreateRequest createRequest);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// The create operation creates a new subscription and a corresponding subscription version.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="createRequest"></param>
        /// <returns>ApiResponse of SubscriptionVersion</returns>
        ApiResponse<SubscriptionVersion> CreateWithHttpInfo (long? spaceId, SubscriptionCreateRequest createRequest);
        /// <summary>
        /// initialize
        /// </summary>
        /// <remarks>
        /// The initialize operation initializes a subscription. This method uses charge flows to carry out the transaction.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId">The provided subscription id will be used to lookup the subscription which should be initialized.</param>
        /// <returns>SubscriptionCharge</returns>
        SubscriptionCharge Initialize (long? spaceId, long? subscriptionId);

        /// <summary>
        /// initialize
        /// </summary>
        /// <remarks>
        /// The initialize operation initializes a subscription. This method uses charge flows to carry out the transaction.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId">The provided subscription id will be used to lookup the subscription which should be initialized.</param>
        /// <returns>ApiResponse of SubscriptionCharge</returns>
        ApiResponse<SubscriptionCharge> InitializeWithHttpInfo (long? spaceId, long? subscriptionId);
        /// <summary>
        /// initializeSubscriberPresent
        /// </summary>
        /// <remarks>
        /// The initialize operation initializes a subscription when the subscriber is present. The method will initialize a transaction which has to be completed by using the transaction service.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="successUrl">The subscriber will be redirected to the success URL when the transaction is successful. (optional)</param>
        /// <param name="failedUrl">The subscriber will be redirected to the fail URL when the transaction fails. (optional)</param>
        /// <returns>SubscriptionCharge</returns>
        SubscriptionCharge InitializeSubscriberPresent (long? spaceId, long? subscriptionId, string successUrl = null, string failedUrl = null);

        /// <summary>
        /// initializeSubscriberPresent
        /// </summary>
        /// <remarks>
        /// The initialize operation initializes a subscription when the subscriber is present. The method will initialize a transaction which has to be completed by using the transaction service.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="successUrl">The subscriber will be redirected to the success URL when the transaction is successful. (optional)</param>
        /// <param name="failedUrl">The subscriber will be redirected to the fail URL when the transaction fails. (optional)</param>
        /// <returns>ApiResponse of SubscriptionCharge</returns>
        ApiResponse<SubscriptionCharge> InitializeSubscriberPresentWithHttpInfo (long? spaceId, long? subscriptionId, string successUrl = null, string failedUrl = null);
        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the subscription which should be returned.</param>
        /// <returns>Subscription</returns>
        Subscription Read (long? spaceId, long? id);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the subscription which should be returned.</param>
        /// <returns>ApiResponse of Subscription</returns>
        ApiResponse<Subscription> ReadWithHttpInfo (long? spaceId, long? id);
        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the subscriptions which are returned by the search.</param>
        /// <returns>List&lt;Subscription&gt;</returns>
        List<Subscription> Search (long? spaceId, EntityQuery query);

        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the subscriptions which are returned by the search.</param>
        /// <returns>ApiResponse of List&lt;Subscription&gt;</returns>
        ApiResponse<List<Subscription>> SearchWithHttpInfo (long? spaceId, EntityQuery query);
        /// <summary>
        /// Search Subscription Invoices
        /// </summary>
        /// <remarks>
        /// This operation allows to search for subscription invoices.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId">The id of the subscription for which the invoices should be searched for.</param>
        /// <param name="query">The query restricts the invoices which are returned by the search.</param>
        /// <returns>List&lt;TransactionInvoice&gt;</returns>
        List<TransactionInvoice> SearchSubscriptionInvoices (long? spaceId, long? subscriptionId, EntityQuery query);

        /// <summary>
        /// Search Subscription Invoices
        /// </summary>
        /// <remarks>
        /// This operation allows to search for subscription invoices.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId">The id of the subscription for which the invoices should be searched for.</param>
        /// <param name="query">The query restricts the invoices which are returned by the search.</param>
        /// <returns>ApiResponse of List&lt;TransactionInvoice&gt;</returns>
        ApiResponse<List<TransactionInvoice>> SearchSubscriptionInvoicesWithHttpInfo (long? spaceId, long? subscriptionId, EntityQuery query);
        /// <summary>
        /// terminate
        /// </summary>
        /// <remarks>
        /// This operation allows to terminate a subscription.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId">The subscription id identifies the subscription which should be terminated.</param>
        /// <param name="respectTerminationPeriod">The respect termination period controls whether the termination period configured on the product version should be respected or if the operation should take effect immediately.</param>
        /// <returns></returns>
        void Terminate (long? spaceId, long? subscriptionId, bool? respectTerminationPeriod);

        /// <summary>
        /// terminate
        /// </summary>
        /// <remarks>
        /// This operation allows to terminate a subscription.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId">The subscription id identifies the subscription which should be terminated.</param>
        /// <param name="respectTerminationPeriod">The respect termination period controls whether the termination period configured on the product version should be respected or if the operation should take effect immediately.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> TerminateWithHttpInfo (long? spaceId, long? subscriptionId, bool? respectTerminationPeriod);
        /// <summary>
        /// update
        /// </summary>
        /// <remarks>
        /// This operation allows to update the subscription.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="request"></param>
        /// <returns>Subscription</returns>
        Subscription Update (long? spaceId, long? subscriptionId, SubscriptionUpdateRequest request);

        /// <summary>
        /// update
        /// </summary>
        /// <remarks>
        /// This operation allows to update the subscription.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="request"></param>
        /// <returns>ApiResponse of Subscription</returns>
        ApiResponse<Subscription> UpdateWithHttpInfo (long? spaceId, long? subscriptionId, SubscriptionUpdateRequest request);
        /// <summary>
        /// update product version
        /// </summary>
        /// <remarks>
        /// The update product version operation updates the product version of the subscription to the latest active product version.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId">The subscription id identifies the subscription which should be updated to the latest version.</param>
        /// <param name="respectTerminationPeriod">The subscription version may be retired. The respect termination period controls whether the termination period configured on the product version should be respected or if the operation should take effect immediately.</param>
        /// <returns>SubscriptionVersion</returns>
        SubscriptionVersion UpdateProductVersion (long? spaceId, long? subscriptionId, bool? respectTerminationPeriod);

        /// <summary>
        /// update product version
        /// </summary>
        /// <remarks>
        /// The update product version operation updates the product version of the subscription to the latest active product version.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId">The subscription id identifies the subscription which should be updated to the latest version.</param>
        /// <param name="respectTerminationPeriod">The subscription version may be retired. The respect termination period controls whether the termination period configured on the product version should be respected or if the operation should take effect immediately.</param>
        /// <returns>ApiResponse of SubscriptionVersion</returns>
        ApiResponse<SubscriptionVersion> UpdateProductVersionWithHttpInfo (long? spaceId, long? subscriptionId, bool? respectTerminationPeriod);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SubscriptionService : ISubscriptionService
    {
        private Wallee.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SubscriptionService(Wallee.Client.Configuration configuration = null)
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
        /// apply changes This operation allows to apply changes on a subscription.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="request"></param>
        /// <returns>SubscriptionVersion</returns>
        public SubscriptionVersion ApplyChanges (long? spaceId, SubscriptionChangeRequest request)
        {
             ApiResponse<SubscriptionVersion> localVarResponse = ApplyChangesWithHttpInfo(spaceId, request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// apply changes This operation allows to apply changes on a subscription.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="request"></param>
        /// <returns>ApiResponse of SubscriptionVersion</returns>
        public ApiResponse< SubscriptionVersion > ApplyChangesWithHttpInfo (long? spaceId, SubscriptionChangeRequest request)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionService->ApplyChanges");
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling SubscriptionService->ApplyChanges");

            var localVarPath = "/subscription/applyChanges";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content type
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
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

			
			this.Configuration.ApiClient.ResetTimeout();
            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ApplyChanges", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SubscriptionVersion>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (SubscriptionVersion) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SubscriptionVersion)));
        }
        /// <summary>
        /// Count Counts the number of items in the database as restricted by the given filter.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>long?</returns>
        public long? Count (long? spaceId, EntityQueryFilter filter = null)
        {
             ApiResponse<long?> localVarResponse = CountWithHttpInfo(spaceId, filter);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Count Counts the number of items in the database as restricted by the given filter.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>ApiResponse of long?</returns>
        public ApiResponse< long? > CountWithHttpInfo (long? spaceId, EntityQueryFilter filter = null)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionService->Count");

            var localVarPath = "/subscription/count";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content type
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (filter != null && filter.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(filter); // http body (model) parameter
            }
            else
            {
                localVarPostBody = filter; // byte array
            }

			
			this.Configuration.ApiClient.ResetTimeout();
            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Count", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<long?>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (long?) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(long?)));
        }
        /// <summary>
        /// Create The create operation creates a new subscription and a corresponding subscription version.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="createRequest"></param>
        /// <returns>SubscriptionVersion</returns>
        public SubscriptionVersion Create (long? spaceId, SubscriptionCreateRequest createRequest)
        {
             ApiResponse<SubscriptionVersion> localVarResponse = CreateWithHttpInfo(spaceId, createRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create The create operation creates a new subscription and a corresponding subscription version.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="createRequest"></param>
        /// <returns>ApiResponse of SubscriptionVersion</returns>
        public ApiResponse< SubscriptionVersion > CreateWithHttpInfo (long? spaceId, SubscriptionCreateRequest createRequest)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionService->Create");
            // verify the required parameter 'createRequest' is set
            if (createRequest == null)
                throw new ApiException(400, "Missing required parameter 'createRequest' when calling SubscriptionService->Create");

            var localVarPath = "/subscription/create";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content type
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (createRequest != null && createRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(createRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = createRequest; // byte array
            }

			
			this.Configuration.ApiClient.ResetTimeout();
            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Create", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SubscriptionVersion>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (SubscriptionVersion) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SubscriptionVersion)));
        }
        /// <summary>
        /// initialize The initialize operation initializes a subscription. This method uses charge flows to carry out the transaction.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId">The provided subscription id will be used to lookup the subscription which should be initialized.</param>
        /// <returns>SubscriptionCharge</returns>
        public SubscriptionCharge Initialize (long? spaceId, long? subscriptionId)
        {
             ApiResponse<SubscriptionCharge> localVarResponse = InitializeWithHttpInfo(spaceId, subscriptionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// initialize The initialize operation initializes a subscription. This method uses charge flows to carry out the transaction.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId">The provided subscription id will be used to lookup the subscription which should be initialized.</param>
        /// <returns>ApiResponse of SubscriptionCharge</returns>
        public ApiResponse< SubscriptionCharge > InitializeWithHttpInfo (long? spaceId, long? subscriptionId)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionService->Initialize");
            // verify the required parameter 'subscriptionId' is set
            if (subscriptionId == null)
                throw new ApiException(400, "Missing required parameter 'subscriptionId' when calling SubscriptionService->Initialize");

            var localVarPath = "/subscription/initialize";
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
            if (subscriptionId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "subscriptionId", subscriptionId)); // query parameter

			
			this.Configuration.ApiClient.ResetTimeout();
            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Initialize", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SubscriptionCharge>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (SubscriptionCharge) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SubscriptionCharge)));
        }
        /// <summary>
        /// initializeSubscriberPresent The initialize operation initializes a subscription when the subscriber is present. The method will initialize a transaction which has to be completed by using the transaction service.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="successUrl">The subscriber will be redirected to the success URL when the transaction is successful. (optional)</param>
        /// <param name="failedUrl">The subscriber will be redirected to the fail URL when the transaction fails. (optional)</param>
        /// <returns>SubscriptionCharge</returns>
        public SubscriptionCharge InitializeSubscriberPresent (long? spaceId, long? subscriptionId, string successUrl = null, string failedUrl = null)
        {
             ApiResponse<SubscriptionCharge> localVarResponse = InitializeSubscriberPresentWithHttpInfo(spaceId, subscriptionId, successUrl, failedUrl);
             return localVarResponse.Data;
        }

        /// <summary>
        /// initializeSubscriberPresent The initialize operation initializes a subscription when the subscriber is present. The method will initialize a transaction which has to be completed by using the transaction service.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="successUrl">The subscriber will be redirected to the success URL when the transaction is successful. (optional)</param>
        /// <param name="failedUrl">The subscriber will be redirected to the fail URL when the transaction fails. (optional)</param>
        /// <returns>ApiResponse of SubscriptionCharge</returns>
        public ApiResponse< SubscriptionCharge > InitializeSubscriberPresentWithHttpInfo (long? spaceId, long? subscriptionId, string successUrl = null, string failedUrl = null)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionService->InitializeSubscriberPresent");
            // verify the required parameter 'subscriptionId' is set
            if (subscriptionId == null)
                throw new ApiException(400, "Missing required parameter 'subscriptionId' when calling SubscriptionService->InitializeSubscriberPresent");

            var localVarPath = "/subscription/initializeSubscriberPresent";
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
            if (subscriptionId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "subscriptionId", subscriptionId)); // query parameter
            if (successUrl != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "successUrl", successUrl)); // query parameter
            if (failedUrl != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "failedUrl", failedUrl)); // query parameter

			
			this.Configuration.ApiClient.ResetTimeout();
            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("InitializeSubscriberPresent", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SubscriptionCharge>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (SubscriptionCharge) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SubscriptionCharge)));
        }
        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the subscription which should be returned.</param>
        /// <returns>Subscription</returns>
        public Subscription Read (long? spaceId, long? id)
        {
             ApiResponse<Subscription> localVarResponse = ReadWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the subscription which should be returned.</param>
        /// <returns>ApiResponse of Subscription</returns>
        public ApiResponse< Subscription > ReadWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionService->Read");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SubscriptionService->Read");

            var localVarPath = "/subscription/read";
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
            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter

			
			this.Configuration.ApiClient.ResetTimeout();
            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Read", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Subscription>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (Subscription) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Subscription)));
        }
        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the subscriptions which are returned by the search.</param>
        /// <returns>List&lt;Subscription&gt;</returns>
        public List<Subscription> Search (long? spaceId, EntityQuery query)
        {
             ApiResponse<List<Subscription>> localVarResponse = SearchWithHttpInfo(spaceId, query);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the subscriptions which are returned by the search.</param>
        /// <returns>ApiResponse of List&lt;Subscription&gt;</returns>
        public ApiResponse< List<Subscription> > SearchWithHttpInfo (long? spaceId, EntityQuery query)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionService->Search");
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling SubscriptionService->Search");

            var localVarPath = "/subscription/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content type
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (query != null && query.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(query); // http body (model) parameter
            }
            else
            {
                localVarPostBody = query; // byte array
            }

			
			this.Configuration.ApiClient.ResetTimeout();
            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Search", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Subscription>>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (List<Subscription>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Subscription>)));
        }
        /// <summary>
        /// Search Subscription Invoices This operation allows to search for subscription invoices.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId">The id of the subscription for which the invoices should be searched for.</param>
        /// <param name="query">The query restricts the invoices which are returned by the search.</param>
        /// <returns>List&lt;TransactionInvoice&gt;</returns>
        public List<TransactionInvoice> SearchSubscriptionInvoices (long? spaceId, long? subscriptionId, EntityQuery query)
        {
             ApiResponse<List<TransactionInvoice>> localVarResponse = SearchSubscriptionInvoicesWithHttpInfo(spaceId, subscriptionId, query);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Subscription Invoices This operation allows to search for subscription invoices.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId">The id of the subscription for which the invoices should be searched for.</param>
        /// <param name="query">The query restricts the invoices which are returned by the search.</param>
        /// <returns>ApiResponse of List&lt;TransactionInvoice&gt;</returns>
        public ApiResponse< List<TransactionInvoice> > SearchSubscriptionInvoicesWithHttpInfo (long? spaceId, long? subscriptionId, EntityQuery query)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionService->SearchSubscriptionInvoices");
            // verify the required parameter 'subscriptionId' is set
            if (subscriptionId == null)
                throw new ApiException(400, "Missing required parameter 'subscriptionId' when calling SubscriptionService->SearchSubscriptionInvoices");
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling SubscriptionService->SearchSubscriptionInvoices");

            var localVarPath = "/subscription/searchSubscriptionInvoices";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content type
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (subscriptionId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "subscriptionId", subscriptionId)); // query parameter
            if (query != null && query.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(query); // http body (model) parameter
            }
            else
            {
                localVarPostBody = query; // byte array
            }

			
			this.Configuration.ApiClient.ResetTimeout();
            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchSubscriptionInvoices", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<TransactionInvoice>>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (List<TransactionInvoice>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<TransactionInvoice>)));
        }
        /// <summary>
        /// terminate This operation allows to terminate a subscription.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId">The subscription id identifies the subscription which should be terminated.</param>
        /// <param name="respectTerminationPeriod">The respect termination period controls whether the termination period configured on the product version should be respected or if the operation should take effect immediately.</param>
        /// <returns></returns>
        public void Terminate (long? spaceId, long? subscriptionId, bool? respectTerminationPeriod)
        {
             TerminateWithHttpInfo(spaceId, subscriptionId, respectTerminationPeriod);
        }

        /// <summary>
        /// terminate This operation allows to terminate a subscription.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId">The subscription id identifies the subscription which should be terminated.</param>
        /// <param name="respectTerminationPeriod">The respect termination period controls whether the termination period configured on the product version should be respected or if the operation should take effect immediately.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> TerminateWithHttpInfo (long? spaceId, long? subscriptionId, bool? respectTerminationPeriod)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionService->Terminate");
            // verify the required parameter 'subscriptionId' is set
            if (subscriptionId == null)
                throw new ApiException(400, "Missing required parameter 'subscriptionId' when calling SubscriptionService->Terminate");
            // verify the required parameter 'respectTerminationPeriod' is set
            if (respectTerminationPeriod == null)
                throw new ApiException(400, "Missing required parameter 'respectTerminationPeriod' when calling SubscriptionService->Terminate");

            var localVarPath = "/subscription/terminate";
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
            if (subscriptionId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "subscriptionId", subscriptionId)); // query parameter
            if (respectTerminationPeriod != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "respectTerminationPeriod", respectTerminationPeriod)); // query parameter

			
			this.Configuration.ApiClient.ResetTimeout();
            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Terminate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers
                    .GroupBy(x => x.Name, x => x.Value.ToString())
                    .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                null);
        }
        /// <summary>
        /// update This operation allows to update the subscription.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="request"></param>
        /// <returns>Subscription</returns>
        public Subscription Update (long? spaceId, long? subscriptionId, SubscriptionUpdateRequest request)
        {
             ApiResponse<Subscription> localVarResponse = UpdateWithHttpInfo(spaceId, subscriptionId, request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// update This operation allows to update the subscription.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="request"></param>
        /// <returns>ApiResponse of Subscription</returns>
        public ApiResponse< Subscription > UpdateWithHttpInfo (long? spaceId, long? subscriptionId, SubscriptionUpdateRequest request)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionService->Update");
            // verify the required parameter 'subscriptionId' is set
            if (subscriptionId == null)
                throw new ApiException(400, "Missing required parameter 'subscriptionId' when calling SubscriptionService->Update");
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling SubscriptionService->Update");

            var localVarPath = "/subscription/update";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content type
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (subscriptionId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "subscriptionId", subscriptionId)); // query parameter
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

			
			this.Configuration.ApiClient.ResetTimeout();
            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Update", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Subscription>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (Subscription) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Subscription)));
        }
        /// <summary>
        /// update product version The update product version operation updates the product version of the subscription to the latest active product version.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId">The subscription id identifies the subscription which should be updated to the latest version.</param>
        /// <param name="respectTerminationPeriod">The subscription version may be retired. The respect termination period controls whether the termination period configured on the product version should be respected or if the operation should take effect immediately.</param>
        /// <returns>SubscriptionVersion</returns>
        public SubscriptionVersion UpdateProductVersion (long? spaceId, long? subscriptionId, bool? respectTerminationPeriod)
        {
             ApiResponse<SubscriptionVersion> localVarResponse = UpdateProductVersionWithHttpInfo(spaceId, subscriptionId, respectTerminationPeriod);
             return localVarResponse.Data;
        }

        /// <summary>
        /// update product version The update product version operation updates the product version of the subscription to the latest active product version.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId">The subscription id identifies the subscription which should be updated to the latest version.</param>
        /// <param name="respectTerminationPeriod">The subscription version may be retired. The respect termination period controls whether the termination period configured on the product version should be respected or if the operation should take effect immediately.</param>
        /// <returns>ApiResponse of SubscriptionVersion</returns>
        public ApiResponse< SubscriptionVersion > UpdateProductVersionWithHttpInfo (long? spaceId, long? subscriptionId, bool? respectTerminationPeriod)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionService->UpdateProductVersion");
            // verify the required parameter 'subscriptionId' is set
            if (subscriptionId == null)
                throw new ApiException(400, "Missing required parameter 'subscriptionId' when calling SubscriptionService->UpdateProductVersion");
            // verify the required parameter 'respectTerminationPeriod' is set
            if (respectTerminationPeriod == null)
                throw new ApiException(400, "Missing required parameter 'respectTerminationPeriod' when calling SubscriptionService->UpdateProductVersion");

            var localVarPath = "/subscription/updateProductVersion";
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
            if (subscriptionId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "subscriptionId", subscriptionId)); // query parameter
            if (respectTerminationPeriod != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "respectTerminationPeriod", respectTerminationPeriod)); // query parameter

			
			this.Configuration.ApiClient.ResetTimeout();
            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateProductVersion", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SubscriptionVersion>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (SubscriptionVersion) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SubscriptionVersion)));
        }
    }
}
