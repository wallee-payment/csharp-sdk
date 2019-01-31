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
    public interface ISubscriptionService : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// apply changes
        /// </summary>
        /// <remarks>
        /// This operation allows to apply changes on a subscription.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId">The subscription id identifies the subscription which should be terminated.</param>
        /// <param name="respectTerminationPeriod">The respect termination period controls whether the termination period configured on the product version should be respected or if the operation should take effect immediately.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> TerminateWithHttpInfo (long? spaceId, long? subscriptionId, bool? respectTerminationPeriod);

        /// <summary>
        /// update product version
        /// </summary>
        /// <remarks>
        /// The update product version operation updates the product version of the subscription to the latest active product version.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId">The subscription id identifies the subscription which should be updated to the latest version.</param>
        /// <param name="respectTerminationPeriod">The subscription version may be retired. The respect termination period controls whether the termination period configured on the product version should be respected or if the operation should take effect immediately.</param>
        /// <returns>ApiResponse of SubscriptionVersion</returns>
        ApiResponse<SubscriptionVersion> UpdateProductVersionWithHttpInfo (long? spaceId, long? subscriptionId, bool? respectTerminationPeriod);

        #endregion Synchronous Operations
        #region Asynchronous Operations

        /// <summary>
        /// apply changes
        /// </summary>
        /// <remarks>
        /// This operation allows to apply changes on a subscription.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="request"></param>
        /// <returns>Task of SubscriptionVersion</returns>
        System.Threading.Tasks.Task<SubscriptionVersion> ApplyChangesAsync (long? spaceId, SubscriptionChangeRequest request);

        /// <summary>
        /// apply changes
        /// </summary>
        /// <remarks>
        /// This operation allows to apply changes on a subscription.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="request"></param>
        /// <returns>Task of ApiResponse (SubscriptionVersion)</returns>
        System.Threading.Tasks.Task<ApiResponse<SubscriptionVersion>> ApplyChangesAsyncWithHttpInfo (long? spaceId, SubscriptionChangeRequest request);

        /// <summary>
        /// Count
        /// </summary>
        /// <remarks>
        /// Counts the number of items in the database as restricted by the given filter.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>Task of long?</returns>
        System.Threading.Tasks.Task<long?> CountAsync (long? spaceId, EntityQueryFilter filter = null);

        /// <summary>
        /// Count
        /// </summary>
        /// <remarks>
        /// Counts the number of items in the database as restricted by the given filter.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>Task of ApiResponse (long?)</returns>
        System.Threading.Tasks.Task<ApiResponse<long?>> CountAsyncWithHttpInfo (long? spaceId, EntityQueryFilter filter = null);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// The create operation creates a new subscription and a corresponding subscription version.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="createRequest"></param>
        /// <returns>Task of SubscriptionVersion</returns>
        System.Threading.Tasks.Task<SubscriptionVersion> CreateAsync (long? spaceId, SubscriptionCreateRequest createRequest);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// The create operation creates a new subscription and a corresponding subscription version.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="createRequest"></param>
        /// <returns>Task of ApiResponse (SubscriptionVersion)</returns>
        System.Threading.Tasks.Task<ApiResponse<SubscriptionVersion>> CreateAsyncWithHttpInfo (long? spaceId, SubscriptionCreateRequest createRequest);

        /// <summary>
        /// initialize
        /// </summary>
        /// <remarks>
        /// The initialize operation initializes a subscription. This method uses charge flows to carry out the transaction.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId">The provided subscription id will be used to lookup the subscription which should be initialized.</param>
        /// <returns>Task of SubscriptionCharge</returns>
        System.Threading.Tasks.Task<SubscriptionCharge> InitializeAsync (long? spaceId, long? subscriptionId);

        /// <summary>
        /// initialize
        /// </summary>
        /// <remarks>
        /// The initialize operation initializes a subscription. This method uses charge flows to carry out the transaction.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId">The provided subscription id will be used to lookup the subscription which should be initialized.</param>
        /// <returns>Task of ApiResponse (SubscriptionCharge)</returns>
        System.Threading.Tasks.Task<ApiResponse<SubscriptionCharge>> InitializeAsyncWithHttpInfo (long? spaceId, long? subscriptionId);

        /// <summary>
        /// initializeSubscriberPresent
        /// </summary>
        /// <remarks>
        /// The initialize operation initializes a subscription when the subscriber is present. The method will initialize a transaction which has to be completed by using the transaction service.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="successUrl">The subscriber will be redirected to the success URL when the transaction is successful. (optional)</param>
        /// <param name="failedUrl">The subscriber will be redirected to the fail URL when the transaction fails. (optional)</param>
        /// <returns>Task of SubscriptionCharge</returns>
        System.Threading.Tasks.Task<SubscriptionCharge> InitializeSubscriberPresentAsync (long? spaceId, long? subscriptionId, string successUrl = null, string failedUrl = null);

        /// <summary>
        /// initializeSubscriberPresent
        /// </summary>
        /// <remarks>
        /// The initialize operation initializes a subscription when the subscriber is present. The method will initialize a transaction which has to be completed by using the transaction service.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="successUrl">The subscriber will be redirected to the success URL when the transaction is successful. (optional)</param>
        /// <param name="failedUrl">The subscriber will be redirected to the fail URL when the transaction fails. (optional)</param>
        /// <returns>Task of ApiResponse (SubscriptionCharge)</returns>
        System.Threading.Tasks.Task<ApiResponse<SubscriptionCharge>> InitializeSubscriberPresentAsyncWithHttpInfo (long? spaceId, long? subscriptionId, string successUrl = null, string failedUrl = null);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the subscription which should be returned.</param>
        /// <returns>Task of Subscription</returns>
        System.Threading.Tasks.Task<Subscription> ReadAsync (long? spaceId, long? id);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the subscription which should be returned.</param>
        /// <returns>Task of ApiResponse (Subscription)</returns>
        System.Threading.Tasks.Task<ApiResponse<Subscription>> ReadAsyncWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the subscriptions which are returned by the search.</param>
        /// <returns>Task of List&lt;Subscription&gt;</returns>
        System.Threading.Tasks.Task<List<Subscription>> SearchAsync (long? spaceId, EntityQuery query);

        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the subscriptions which are returned by the search.</param>
        /// <returns>Task of ApiResponse (List&lt;Subscription&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Subscription>>> SearchAsyncWithHttpInfo (long? spaceId, EntityQuery query);

        /// <summary>
        /// Search Subscription Invoices
        /// </summary>
        /// <remarks>
        /// This operation allows to search for subscription invoices.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId">The id of the subscription for which the invoices should be searched for.</param>
        /// <param name="query">The query restricts the invoices which are returned by the search.</param>
        /// <returns>Task of List&lt;TransactionInvoice&gt;</returns>
        System.Threading.Tasks.Task<List<TransactionInvoice>> SearchSubscriptionInvoicesAsync (long? spaceId, long? subscriptionId, EntityQuery query);

        /// <summary>
        /// Search Subscription Invoices
        /// </summary>
        /// <remarks>
        /// This operation allows to search for subscription invoices.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId">The id of the subscription for which the invoices should be searched for.</param>
        /// <param name="query">The query restricts the invoices which are returned by the search.</param>
        /// <returns>Task of ApiResponse (List&lt;TransactionInvoice&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<TransactionInvoice>>> SearchSubscriptionInvoicesAsyncWithHttpInfo (long? spaceId, long? subscriptionId, EntityQuery query);

        /// <summary>
        /// terminate
        /// </summary>
        /// <remarks>
        /// This operation allows to terminate a subscription.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId">The subscription id identifies the subscription which should be terminated.</param>
        /// <param name="respectTerminationPeriod">The respect termination period controls whether the termination period configured on the product version should be respected or if the operation should take effect immediately.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task TerminateAsync (long? spaceId, long? subscriptionId, bool? respectTerminationPeriod);

        /// <summary>
        /// terminate
        /// </summary>
        /// <remarks>
        /// This operation allows to terminate a subscription.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId">The subscription id identifies the subscription which should be terminated.</param>
        /// <param name="respectTerminationPeriod">The respect termination period controls whether the termination period configured on the product version should be respected or if the operation should take effect immediately.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> TerminateAsyncWithHttpInfo (long? spaceId, long? subscriptionId, bool? respectTerminationPeriod);

        /// <summary>
        /// update product version
        /// </summary>
        /// <remarks>
        /// The update product version operation updates the product version of the subscription to the latest active product version.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId">The subscription id identifies the subscription which should be updated to the latest version.</param>
        /// <param name="respectTerminationPeriod">The subscription version may be retired. The respect termination period controls whether the termination period configured on the product version should be respected or if the operation should take effect immediately.</param>
        /// <returns>Task of SubscriptionVersion</returns>
        System.Threading.Tasks.Task<SubscriptionVersion> UpdateProductVersionAsync (long? spaceId, long? subscriptionId, bool? respectTerminationPeriod);

        /// <summary>
        /// update product version
        /// </summary>
        /// <remarks>
        /// The update product version operation updates the product version of the subscription to the latest active product version.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId">The subscription id identifies the subscription which should be updated to the latest version.</param>
        /// <param name="respectTerminationPeriod">The subscription version may be retired. The respect termination period controls whether the termination period configured on the product version should be respected or if the operation should take effect immediately.</param>
        /// <returns>Task of ApiResponse (SubscriptionVersion)</returns>
        System.Threading.Tasks.Task<ApiResponse<SubscriptionVersion>> UpdateProductVersionAsyncWithHttpInfo (long? spaceId, long? subscriptionId, bool? respectTerminationPeriod);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SubscriptionService : ISubscriptionService
    {
        private readonly Customweb.Wallee.Client.ExceptionFactory _exceptionFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SubscriptionService(Configuration configuration = null)
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
        /// apply changes This operation allows to apply changes on a subscription.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="request"></param>
        /// <returns>ApiResponse of SubscriptionVersion</returns>
        public ApiResponse< SubscriptionVersion > ApplyChangesWithHttpInfo (long? spaceId, SubscriptionChangeRequest request)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionService->ApplyChanges");
            }
            // verify the required parameter 'request' is set
            if (request == null)
            {
                throw new ApiException(400, "Missing required parameter 'request' when calling SubscriptionService->ApplyChanges");
            }

            var localVarPath = "/subscription/applyChanges";
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

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ApplyChanges", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SubscriptionVersion>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubscriptionVersion) ApiClient.Deserialize(localVarResponse, typeof(SubscriptionVersion)));
        }

        /// <summary>
        /// apply changes This operation allows to apply changes on a subscription.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="request"></param>
        /// <returns>Task of SubscriptionVersion</returns>
        public async System.Threading.Tasks.Task<SubscriptionVersion> ApplyChangesAsync (long? spaceId, SubscriptionChangeRequest request)
        {
             ApiResponse<SubscriptionVersion> localVarResponse = await ApplyChangesAsyncWithHttpInfo(spaceId, request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// apply changes This operation allows to apply changes on a subscription.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="request"></param>
        /// <returns>Task of ApiResponse (SubscriptionVersion)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SubscriptionVersion>> ApplyChangesAsyncWithHttpInfo (long? spaceId, SubscriptionChangeRequest request)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionService->ApplyChanges");
            }
            // verify the required parameter 'request' is set
            if (request == null)
            {
                throw new ApiException(400, "Missing required parameter 'request' when calling SubscriptionService->ApplyChanges");
            }

            var localVarPath = "/subscription/applyChanges";
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

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ApplyChanges", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SubscriptionVersion>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubscriptionVersion) ApiClient.Deserialize(localVarResponse, typeof(SubscriptionVersion)));
        }

        /// <summary>
        /// Count Counts the number of items in the database as restricted by the given filter.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>ApiResponse of long?</returns>
        public ApiResponse< long? > CountWithHttpInfo (long? spaceId, EntityQueryFilter filter = null)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionService->Count");
            }

            var localVarPath = "/subscription/count";
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
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (filter != null && filter.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(filter); // http body (model) parameter
            }
            else
            {
                localVarPostBody = filter; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Count", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<long?>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (long?) ApiClient.Deserialize(localVarResponse, typeof(long?)));
        }

        /// <summary>
        /// Count Counts the number of items in the database as restricted by the given filter.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>Task of long?</returns>
        public async System.Threading.Tasks.Task<long?> CountAsync (long? spaceId, EntityQueryFilter filter = null)
        {
             ApiResponse<long?> localVarResponse = await CountAsyncWithHttpInfo(spaceId, filter);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Count Counts the number of items in the database as restricted by the given filter.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>Task of ApiResponse (long?)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<long?>> CountAsyncWithHttpInfo (long? spaceId, EntityQueryFilter filter = null)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionService->Count");
            }

            var localVarPath = "/subscription/count";
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
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (filter != null && filter.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(filter); // http body (model) parameter
            }
            else
            {
                localVarPostBody = filter; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Count", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<long?>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (long?) ApiClient.Deserialize(localVarResponse, typeof(long?)));
        }

        /// <summary>
        /// Create The create operation creates a new subscription and a corresponding subscription version.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="createRequest"></param>
        /// <returns>ApiResponse of SubscriptionVersion</returns>
        public ApiResponse< SubscriptionVersion > CreateWithHttpInfo (long? spaceId, SubscriptionCreateRequest createRequest)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionService->Create");
            }
            // verify the required parameter 'createRequest' is set
            if (createRequest == null)
            {
                throw new ApiException(400, "Missing required parameter 'createRequest' when calling SubscriptionService->Create");
            }

            var localVarPath = "/subscription/create";
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
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (createRequest != null && createRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(createRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = createRequest; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Create", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SubscriptionVersion>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubscriptionVersion) ApiClient.Deserialize(localVarResponse, typeof(SubscriptionVersion)));
        }

        /// <summary>
        /// Create The create operation creates a new subscription and a corresponding subscription version.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="createRequest"></param>
        /// <returns>Task of SubscriptionVersion</returns>
        public async System.Threading.Tasks.Task<SubscriptionVersion> CreateAsync (long? spaceId, SubscriptionCreateRequest createRequest)
        {
             ApiResponse<SubscriptionVersion> localVarResponse = await CreateAsyncWithHttpInfo(spaceId, createRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create The create operation creates a new subscription and a corresponding subscription version.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="createRequest"></param>
        /// <returns>Task of ApiResponse (SubscriptionVersion)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SubscriptionVersion>> CreateAsyncWithHttpInfo (long? spaceId, SubscriptionCreateRequest createRequest)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionService->Create");
            }
            // verify the required parameter 'createRequest' is set
            if (createRequest == null)
            {
                throw new ApiException(400, "Missing required parameter 'createRequest' when calling SubscriptionService->Create");
            }

            var localVarPath = "/subscription/create";
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
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (createRequest != null && createRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(createRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = createRequest; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Create", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SubscriptionVersion>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubscriptionVersion) ApiClient.Deserialize(localVarResponse, typeof(SubscriptionVersion)));
        }

        /// <summary>
        /// initialize The initialize operation initializes a subscription. This method uses charge flows to carry out the transaction.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId">The provided subscription id will be used to lookup the subscription which should be initialized.</param>
        /// <returns>ApiResponse of SubscriptionCharge</returns>
        public ApiResponse< SubscriptionCharge > InitializeWithHttpInfo (long? spaceId, long? subscriptionId)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionService->Initialize");
            }
            // verify the required parameter 'subscriptionId' is set
            if (subscriptionId == null)
            {
                throw new ApiException(400, "Missing required parameter 'subscriptionId' when calling SubscriptionService->Initialize");
            }

            var localVarPath = "/subscription/initialize";
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

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (subscriptionId != null) localVarQueryParams.Add("subscriptionId", ApiClient.ParameterToString(subscriptionId)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Initialize", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SubscriptionCharge>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubscriptionCharge) ApiClient.Deserialize(localVarResponse, typeof(SubscriptionCharge)));
        }

        /// <summary>
        /// initialize The initialize operation initializes a subscription. This method uses charge flows to carry out the transaction.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId">The provided subscription id will be used to lookup the subscription which should be initialized.</param>
        /// <returns>Task of SubscriptionCharge</returns>
        public async System.Threading.Tasks.Task<SubscriptionCharge> InitializeAsync (long? spaceId, long? subscriptionId)
        {
             ApiResponse<SubscriptionCharge> localVarResponse = await InitializeAsyncWithHttpInfo(spaceId, subscriptionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// initialize The initialize operation initializes a subscription. This method uses charge flows to carry out the transaction.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId">The provided subscription id will be used to lookup the subscription which should be initialized.</param>
        /// <returns>Task of ApiResponse (SubscriptionCharge)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SubscriptionCharge>> InitializeAsyncWithHttpInfo (long? spaceId, long? subscriptionId)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionService->Initialize");
            }
            // verify the required parameter 'subscriptionId' is set
            if (subscriptionId == null)
            {
                throw new ApiException(400, "Missing required parameter 'subscriptionId' when calling SubscriptionService->Initialize");
            }

            var localVarPath = "/subscription/initialize";
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

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (subscriptionId != null) localVarQueryParams.Add("subscriptionId", ApiClient.ParameterToString(subscriptionId)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Initialize", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SubscriptionCharge>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubscriptionCharge) ApiClient.Deserialize(localVarResponse, typeof(SubscriptionCharge)));
        }

        /// <summary>
        /// initializeSubscriberPresent The initialize operation initializes a subscription when the subscriber is present. The method will initialize a transaction which has to be completed by using the transaction service.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="successUrl">The subscriber will be redirected to the success URL when the transaction is successful. (optional)</param>
        /// <param name="failedUrl">The subscriber will be redirected to the fail URL when the transaction fails. (optional)</param>
        /// <returns>ApiResponse of SubscriptionCharge</returns>
        public ApiResponse< SubscriptionCharge > InitializeSubscriberPresentWithHttpInfo (long? spaceId, long? subscriptionId, string successUrl = null, string failedUrl = null)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionService->InitializeSubscriberPresent");
            }
            // verify the required parameter 'subscriptionId' is set
            if (subscriptionId == null)
            {
                throw new ApiException(400, "Missing required parameter 'subscriptionId' when calling SubscriptionService->InitializeSubscriberPresent");
            }

            var localVarPath = "/subscription/initializeSubscriberPresent";
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

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (subscriptionId != null) localVarQueryParams.Add("subscriptionId", ApiClient.ParameterToString(subscriptionId)); // query parameter
            if (successUrl != null) localVarQueryParams.Add("successUrl", ApiClient.ParameterToString(successUrl)); // query parameter
            if (failedUrl != null) localVarQueryParams.Add("failedUrl", ApiClient.ParameterToString(failedUrl)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("InitializeSubscriberPresent", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SubscriptionCharge>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubscriptionCharge) ApiClient.Deserialize(localVarResponse, typeof(SubscriptionCharge)));
        }

        /// <summary>
        /// initializeSubscriberPresent The initialize operation initializes a subscription when the subscriber is present. The method will initialize a transaction which has to be completed by using the transaction service.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="successUrl">The subscriber will be redirected to the success URL when the transaction is successful. (optional)</param>
        /// <param name="failedUrl">The subscriber will be redirected to the fail URL when the transaction fails. (optional)</param>
        /// <returns>Task of SubscriptionCharge</returns>
        public async System.Threading.Tasks.Task<SubscriptionCharge> InitializeSubscriberPresentAsync (long? spaceId, long? subscriptionId, string successUrl = null, string failedUrl = null)
        {
             ApiResponse<SubscriptionCharge> localVarResponse = await InitializeSubscriberPresentAsyncWithHttpInfo(spaceId, subscriptionId, successUrl, failedUrl);
             return localVarResponse.Data;
        }

        /// <summary>
        /// initializeSubscriberPresent The initialize operation initializes a subscription when the subscriber is present. The method will initialize a transaction which has to be completed by using the transaction service.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="successUrl">The subscriber will be redirected to the success URL when the transaction is successful. (optional)</param>
        /// <param name="failedUrl">The subscriber will be redirected to the fail URL when the transaction fails. (optional)</param>
        /// <returns>Task of ApiResponse (SubscriptionCharge)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SubscriptionCharge>> InitializeSubscriberPresentAsyncWithHttpInfo (long? spaceId, long? subscriptionId, string successUrl = null, string failedUrl = null)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionService->InitializeSubscriberPresent");
            }
            // verify the required parameter 'subscriptionId' is set
            if (subscriptionId == null)
            {
                throw new ApiException(400, "Missing required parameter 'subscriptionId' when calling SubscriptionService->InitializeSubscriberPresent");
            }

            var localVarPath = "/subscription/initializeSubscriberPresent";
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

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (subscriptionId != null) localVarQueryParams.Add("subscriptionId", ApiClient.ParameterToString(subscriptionId)); // query parameter
            if (successUrl != null) localVarQueryParams.Add("successUrl", ApiClient.ParameterToString(successUrl)); // query parameter
            if (failedUrl != null) localVarQueryParams.Add("failedUrl", ApiClient.ParameterToString(failedUrl)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("InitializeSubscriberPresent", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SubscriptionCharge>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubscriptionCharge) ApiClient.Deserialize(localVarResponse, typeof(SubscriptionCharge)));
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the subscription which should be returned.</param>
        /// <returns>ApiResponse of Subscription</returns>
        public ApiResponse< Subscription > ReadWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionService->Read");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling SubscriptionService->Read");
            }

            var localVarPath = "/subscription/read";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Read", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Subscription>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Subscription) ApiClient.Deserialize(localVarResponse, typeof(Subscription)));
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the subscription which should be returned.</param>
        /// <returns>Task of Subscription</returns>
        public async System.Threading.Tasks.Task<Subscription> ReadAsync (long? spaceId, long? id)
        {
             ApiResponse<Subscription> localVarResponse = await ReadAsyncWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the subscription which should be returned.</param>
        /// <returns>Task of ApiResponse (Subscription)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Subscription>> ReadAsyncWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionService->Read");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling SubscriptionService->Read");
            }

            var localVarPath = "/subscription/read";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
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

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Read", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Subscription>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Subscription) ApiClient.Deserialize(localVarResponse, typeof(Subscription)));
        }

        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the subscriptions which are returned by the search.</param>
        /// <returns>ApiResponse of List&lt;Subscription&gt;</returns>
        public ApiResponse< List<Subscription> > SearchWithHttpInfo (long? spaceId, EntityQuery query)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionService->Search");
            }
            // verify the required parameter 'query' is set
            if (query == null)
            {
                throw new ApiException(400, "Missing required parameter 'query' when calling SubscriptionService->Search");
            }

            var localVarPath = "/subscription/search";
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
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (query != null && query.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(query); // http body (model) parameter
            }
            else
            {
                localVarPostBody = query; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Search", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Subscription>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Subscription>) ApiClient.Deserialize(localVarResponse, typeof(List<Subscription>)));
        }

        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the subscriptions which are returned by the search.</param>
        /// <returns>Task of List&lt;Subscription&gt;</returns>
        public async System.Threading.Tasks.Task<List<Subscription>> SearchAsync (long? spaceId, EntityQuery query)
        {
             ApiResponse<List<Subscription>> localVarResponse = await SearchAsyncWithHttpInfo(spaceId, query);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the subscriptions which are returned by the search.</param>
        /// <returns>Task of ApiResponse (List&lt;Subscription&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Subscription>>> SearchAsyncWithHttpInfo (long? spaceId, EntityQuery query)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionService->Search");
            }
            // verify the required parameter 'query' is set
            if (query == null)
            {
                throw new ApiException(400, "Missing required parameter 'query' when calling SubscriptionService->Search");
            }

            var localVarPath = "/subscription/search";
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
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (query != null && query.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(query); // http body (model) parameter
            }
            else
            {
                localVarPostBody = query; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Search", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Subscription>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Subscription>) ApiClient.Deserialize(localVarResponse, typeof(List<Subscription>)));
        }

        /// <summary>
        /// Search Subscription Invoices This operation allows to search for subscription invoices.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId">The id of the subscription for which the invoices should be searched for.</param>
        /// <param name="query">The query restricts the invoices which are returned by the search.</param>
        /// <returns>ApiResponse of List&lt;TransactionInvoice&gt;</returns>
        public ApiResponse< List<TransactionInvoice> > SearchSubscriptionInvoicesWithHttpInfo (long? spaceId, long? subscriptionId, EntityQuery query)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionService->SearchSubscriptionInvoices");
            }
            // verify the required parameter 'subscriptionId' is set
            if (subscriptionId == null)
            {
                throw new ApiException(400, "Missing required parameter 'subscriptionId' when calling SubscriptionService->SearchSubscriptionInvoices");
            }
            // verify the required parameter 'query' is set
            if (query == null)
            {
                throw new ApiException(400, "Missing required parameter 'query' when calling SubscriptionService->SearchSubscriptionInvoices");
            }

            var localVarPath = "/subscription/searchSubscriptionInvoices";
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
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (subscriptionId != null) localVarQueryParams.Add("subscriptionId", ApiClient.ParameterToString(subscriptionId)); // query parameter
            if (query != null && query.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(query); // http body (model) parameter
            }
            else
            {
                localVarPostBody = query; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchSubscriptionInvoices", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<TransactionInvoice>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<TransactionInvoice>) ApiClient.Deserialize(localVarResponse, typeof(List<TransactionInvoice>)));
        }

        /// <summary>
        /// Search Subscription Invoices This operation allows to search for subscription invoices.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId">The id of the subscription for which the invoices should be searched for.</param>
        /// <param name="query">The query restricts the invoices which are returned by the search.</param>
        /// <returns>Task of List&lt;TransactionInvoice&gt;</returns>
        public async System.Threading.Tasks.Task<List<TransactionInvoice>> SearchSubscriptionInvoicesAsync (long? spaceId, long? subscriptionId, EntityQuery query)
        {
             ApiResponse<List<TransactionInvoice>> localVarResponse = await SearchSubscriptionInvoicesAsyncWithHttpInfo(spaceId, subscriptionId, query);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Subscription Invoices This operation allows to search for subscription invoices.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId">The id of the subscription for which the invoices should be searched for.</param>
        /// <param name="query">The query restricts the invoices which are returned by the search.</param>
        /// <returns>Task of ApiResponse (List&lt;TransactionInvoice&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<TransactionInvoice>>> SearchSubscriptionInvoicesAsyncWithHttpInfo (long? spaceId, long? subscriptionId, EntityQuery query)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionService->SearchSubscriptionInvoices");
            }
            // verify the required parameter 'subscriptionId' is set
            if (subscriptionId == null)
            {
                throw new ApiException(400, "Missing required parameter 'subscriptionId' when calling SubscriptionService->SearchSubscriptionInvoices");
            }
            // verify the required parameter 'query' is set
            if (query == null)
            {
                throw new ApiException(400, "Missing required parameter 'query' when calling SubscriptionService->SearchSubscriptionInvoices");
            }

            var localVarPath = "/subscription/searchSubscriptionInvoices";
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
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (subscriptionId != null) localVarQueryParams.Add("subscriptionId", ApiClient.ParameterToString(subscriptionId)); // query parameter
            if (query != null && query.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(query); // http body (model) parameter
            }
            else
            {
                localVarPostBody = query; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchSubscriptionInvoices", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<TransactionInvoice>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<TransactionInvoice>) ApiClient.Deserialize(localVarResponse, typeof(List<TransactionInvoice>)));
        }

        /// <summary>
        /// terminate This operation allows to terminate a subscription.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId">The subscription id identifies the subscription which should be terminated.</param>
        /// <param name="respectTerminationPeriod">The respect termination period controls whether the termination period configured on the product version should be respected or if the operation should take effect immediately.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> TerminateWithHttpInfo (long? spaceId, long? subscriptionId, bool? respectTerminationPeriod)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionService->Terminate");
            }
            // verify the required parameter 'subscriptionId' is set
            if (subscriptionId == null)
            {
                throw new ApiException(400, "Missing required parameter 'subscriptionId' when calling SubscriptionService->Terminate");
            }
            // verify the required parameter 'respectTerminationPeriod' is set
            if (respectTerminationPeriod == null)
            {
                throw new ApiException(400, "Missing required parameter 'respectTerminationPeriod' when calling SubscriptionService->Terminate");
            }

            var localVarPath = "/subscription/terminate";
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

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (subscriptionId != null) localVarQueryParams.Add("subscriptionId", ApiClient.ParameterToString(subscriptionId)); // query parameter
            if (respectTerminationPeriod != null) localVarQueryParams.Add("respectTerminationPeriod", ApiClient.ParameterToString(respectTerminationPeriod)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Terminate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// terminate This operation allows to terminate a subscription.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId">The subscription id identifies the subscription which should be terminated.</param>
        /// <param name="respectTerminationPeriod">The respect termination period controls whether the termination period configured on the product version should be respected or if the operation should take effect immediately.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task TerminateAsync (long? spaceId, long? subscriptionId, bool? respectTerminationPeriod)
        {
             await TerminateAsyncWithHttpInfo(spaceId, subscriptionId, respectTerminationPeriod);
        }

        /// <summary>
        /// terminate This operation allows to terminate a subscription.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId">The subscription id identifies the subscription which should be terminated.</param>
        /// <param name="respectTerminationPeriod">The respect termination period controls whether the termination period configured on the product version should be respected or if the operation should take effect immediately.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> TerminateAsyncWithHttpInfo (long? spaceId, long? subscriptionId, bool? respectTerminationPeriod)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionService->Terminate");
            }
            // verify the required parameter 'subscriptionId' is set
            if (subscriptionId == null)
            {
                throw new ApiException(400, "Missing required parameter 'subscriptionId' when calling SubscriptionService->Terminate");
            }
            // verify the required parameter 'respectTerminationPeriod' is set
            if (respectTerminationPeriod == null)
            {
                throw new ApiException(400, "Missing required parameter 'respectTerminationPeriod' when calling SubscriptionService->Terminate");
            }

            var localVarPath = "/subscription/terminate";
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

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (subscriptionId != null) localVarQueryParams.Add("subscriptionId", ApiClient.ParameterToString(subscriptionId)); // query parameter
            if (respectTerminationPeriod != null) localVarQueryParams.Add("respectTerminationPeriod", ApiClient.ParameterToString(respectTerminationPeriod)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Terminate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// update product version The update product version operation updates the product version of the subscription to the latest active product version.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId">The subscription id identifies the subscription which should be updated to the latest version.</param>
        /// <param name="respectTerminationPeriod">The subscription version may be retired. The respect termination period controls whether the termination period configured on the product version should be respected or if the operation should take effect immediately.</param>
        /// <returns>ApiResponse of SubscriptionVersion</returns>
        public ApiResponse< SubscriptionVersion > UpdateProductVersionWithHttpInfo (long? spaceId, long? subscriptionId, bool? respectTerminationPeriod)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionService->UpdateProductVersion");
            }
            // verify the required parameter 'subscriptionId' is set
            if (subscriptionId == null)
            {
                throw new ApiException(400, "Missing required parameter 'subscriptionId' when calling SubscriptionService->UpdateProductVersion");
            }
            // verify the required parameter 'respectTerminationPeriod' is set
            if (respectTerminationPeriod == null)
            {
                throw new ApiException(400, "Missing required parameter 'respectTerminationPeriod' when calling SubscriptionService->UpdateProductVersion");
            }

            var localVarPath = "/subscription/updateProductVersion";
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

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (subscriptionId != null) localVarQueryParams.Add("subscriptionId", ApiClient.ParameterToString(subscriptionId)); // query parameter
            if (respectTerminationPeriod != null) localVarQueryParams.Add("respectTerminationPeriod", ApiClient.ParameterToString(respectTerminationPeriod)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateProductVersion", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SubscriptionVersion>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubscriptionVersion) ApiClient.Deserialize(localVarResponse, typeof(SubscriptionVersion)));
        }

        /// <summary>
        /// update product version The update product version operation updates the product version of the subscription to the latest active product version.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId">The subscription id identifies the subscription which should be updated to the latest version.</param>
        /// <param name="respectTerminationPeriod">The subscription version may be retired. The respect termination period controls whether the termination period configured on the product version should be respected or if the operation should take effect immediately.</param>
        /// <returns>Task of SubscriptionVersion</returns>
        public async System.Threading.Tasks.Task<SubscriptionVersion> UpdateProductVersionAsync (long? spaceId, long? subscriptionId, bool? respectTerminationPeriod)
        {
             ApiResponse<SubscriptionVersion> localVarResponse = await UpdateProductVersionAsyncWithHttpInfo(spaceId, subscriptionId, respectTerminationPeriod);
             return localVarResponse.Data;
        }

        /// <summary>
        /// update product version The update product version operation updates the product version of the subscription to the latest active product version.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="subscriptionId">The subscription id identifies the subscription which should be updated to the latest version.</param>
        /// <param name="respectTerminationPeriod">The subscription version may be retired. The respect termination period controls whether the termination period configured on the product version should be respected or if the operation should take effect immediately.</param>
        /// <returns>Task of ApiResponse (SubscriptionVersion)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SubscriptionVersion>> UpdateProductVersionAsyncWithHttpInfo (long? spaceId, long? subscriptionId, bool? respectTerminationPeriod)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling SubscriptionService->UpdateProductVersion");
            }
            // verify the required parameter 'subscriptionId' is set
            if (subscriptionId == null)
            {
                throw new ApiException(400, "Missing required parameter 'subscriptionId' when calling SubscriptionService->UpdateProductVersion");
            }
            // verify the required parameter 'respectTerminationPeriod' is set
            if (respectTerminationPeriod == null)
            {
                throw new ApiException(400, "Missing required parameter 'respectTerminationPeriod' when calling SubscriptionService->UpdateProductVersion");
            }

            var localVarPath = "/subscription/updateProductVersion";
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

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (subscriptionId != null) localVarQueryParams.Add("subscriptionId", ApiClient.ParameterToString(subscriptionId)); // query parameter
            if (respectTerminationPeriod != null) localVarQueryParams.Add("respectTerminationPeriod", ApiClient.ParameterToString(respectTerminationPeriod)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateProductVersion", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SubscriptionVersion>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubscriptionVersion) ApiClient.Deserialize(localVarResponse, typeof(SubscriptionVersion)));
        }

    }
}
