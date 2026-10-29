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
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Wallee.Client;
using Wallee.Model;

namespace Wallee.Service
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInvoiceReconciliationRecordInvoiceLinksServiceSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// List all invoice reconciliation record invoice links
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="after">Set to an object&#39;s ID to retrieve the page of objects coming immediately after the named object. (optional)</param>
        /// <param name="before">Set to an object&#39;s ID to retrieve the page of objects coming immediately before the named object. (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="order">Specify to retrieve objects in chronological (ASC) or reverse chronological (DESC) order. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>InvoiceReconciliationRecordInvoiceLinkListResponse</returns>
        InvoiceReconciliationRecordInvoiceLinkListResponse GetPaymentInvoiceReconciliationRecordInvoiceLinks(long space, long? after = default, long? before = default, List<string>? expand = default, int? limit = default, SortingOrder? order = default, int operationIndex = 0);

        /// <summary>
        /// List all invoice reconciliation record invoice links
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="after">Set to an object&#39;s ID to retrieve the page of objects coming immediately after the named object. (optional)</param>
        /// <param name="before">Set to an object&#39;s ID to retrieve the page of objects coming immediately before the named object. (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="order">Specify to retrieve objects in chronological (ASC) or reverse chronological (DESC) order. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of InvoiceReconciliationRecordInvoiceLinkListResponse</returns>
        ApiResponse<InvoiceReconciliationRecordInvoiceLinkListResponse> GetPaymentInvoiceReconciliationRecordInvoiceLinksWithHttpInfo(long space, long? after = default, long? before = default, List<string>? expand = default, int? limit = default, SortingOrder? order = default, int operationIndex = 0);
        /// <summary>
        /// Retrieve an invoice reconciliation record invoice link
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>InvoiceReconciliationRecordInvoiceLink</returns>
        InvoiceReconciliationRecordInvoiceLink GetPaymentInvoiceReconciliationRecordInvoiceLinksId(long id, long space, List<string>? expand = default, int operationIndex = 0);

        /// <summary>
        /// Retrieve an invoice reconciliation record invoice link
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of InvoiceReconciliationRecordInvoiceLink</returns>
        ApiResponse<InvoiceReconciliationRecordInvoiceLink> GetPaymentInvoiceReconciliationRecordInvoiceLinksIdWithHttpInfo(long id, long space, List<string>? expand = default, int operationIndex = 0);
        /// <summary>
        /// Search invoice reconciliation record invoice links
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="offset">A cursor for pagination, specifies the number of objects to skip. (optional)</param>
        /// <param name="order">The fields and order to sort the objects by. (optional)</param>
        /// <param name="query">The search query to filter the objects by. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>InvoiceReconciliationRecordInvoiceLinkSearchResponse</returns>
        InvoiceReconciliationRecordInvoiceLinkSearchResponse GetPaymentInvoiceReconciliationRecordInvoiceLinksSearch(long space, List<string>? expand = default, int? limit = default, int? offset = default, string? order = default, string? query = default, int operationIndex = 0);

        /// <summary>
        /// Search invoice reconciliation record invoice links
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="offset">A cursor for pagination, specifies the number of objects to skip. (optional)</param>
        /// <param name="order">The fields and order to sort the objects by. (optional)</param>
        /// <param name="query">The search query to filter the objects by. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of InvoiceReconciliationRecordInvoiceLinkSearchResponse</returns>
        ApiResponse<InvoiceReconciliationRecordInvoiceLinkSearchResponse> GetPaymentInvoiceReconciliationRecordInvoiceLinksSearchWithHttpInfo(long space, List<string>? expand = default, int? limit = default, int? offset = default, string? order = default, string? query = default, int operationIndex = 0);
        /// <summary>
        /// Link an invoice
        /// </summary>
        /// <remarks>
        /// Links the invoice reconciliation record with the provided invoice completion.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordId">The ID of the invoice reconciliation record which should be linked.</param>
        /// <param name="completionId">The ID of the completion which should be linked.</param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="amount">The amount of the invoice reconciliation record linked completion. When omitted the amount is calculated. (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>InvoiceReconciliationRecordInvoiceLink</returns>
        InvoiceReconciliationRecordInvoiceLink PostPaymentInvoiceReconciliationRecordInvoiceLinks(long recordId, long completionId, long space, decimal? amount = default, List<string>? expand = default, int operationIndex = 0);

        /// <summary>
        /// Link an invoice
        /// </summary>
        /// <remarks>
        /// Links the invoice reconciliation record with the provided invoice completion.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordId">The ID of the invoice reconciliation record which should be linked.</param>
        /// <param name="completionId">The ID of the completion which should be linked.</param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="amount">The amount of the invoice reconciliation record linked completion. When omitted the amount is calculated. (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of InvoiceReconciliationRecordInvoiceLink</returns>
        ApiResponse<InvoiceReconciliationRecordInvoiceLink> PostPaymentInvoiceReconciliationRecordInvoiceLinksWithHttpInfo(long recordId, long completionId, long space, decimal? amount = default, List<string>? expand = default, int operationIndex = 0);
        /// <summary>
        /// Unlink an invoice
        /// </summary>
        /// <remarks>
        /// Unlinks the invoice reconciliation record from the provided invoice completion.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordId">The ID of the invoice reconciliation record which should be unlinked.</param>
        /// <param name="completionId">The ID of the completion which should be unlinked.</param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void PostPaymentInvoiceReconciliationRecordInvoiceLinksUnlink(long recordId, long completionId, long space, int operationIndex = 0);

        /// <summary>
        /// Unlink an invoice
        /// </summary>
        /// <remarks>
        /// Unlinks the invoice reconciliation record from the provided invoice completion.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordId">The ID of the invoice reconciliation record which should be unlinked.</param>
        /// <param name="completionId">The ID of the completion which should be unlinked.</param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostPaymentInvoiceReconciliationRecordInvoiceLinksUnlinkWithHttpInfo(long recordId, long completionId, long space, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInvoiceReconciliationRecordInvoiceLinksService : IInvoiceReconciliationRecordInvoiceLinksServiceSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class InvoiceReconciliationRecordInvoiceLinksService : IInvoiceReconciliationRecordInvoiceLinksService
    {

        private Wallee.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceReconciliationRecordInvoiceLinksService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public InvoiceReconciliationRecordInvoiceLinksService(Wallee.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            this.Configuration = configuration;
            this.Client = new Wallee.Client.ApiClient(this.Configuration);
            ExceptionFactory = Wallee.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceReconciliationRecordInvoiceLinksService"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public InvoiceReconciliationRecordInvoiceLinksService(Wallee.Client.ISynchronousClient client, Wallee.Client.IReadableConfiguration configuration)
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
        /// List all invoice reconciliation record invoice links 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="after">Set to an object&#39;s ID to retrieve the page of objects coming immediately after the named object. (optional)</param>
        /// <param name="before">Set to an object&#39;s ID to retrieve the page of objects coming immediately before the named object. (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="order">Specify to retrieve objects in chronological (ASC) or reverse chronological (DESC) order. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>InvoiceReconciliationRecordInvoiceLinkListResponse</returns>
        public InvoiceReconciliationRecordInvoiceLinkListResponse GetPaymentInvoiceReconciliationRecordInvoiceLinks(long space, long? after = default, long? before = default, List<string>? expand = default, int? limit = default, SortingOrder? order = default, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<InvoiceReconciliationRecordInvoiceLinkListResponse> localVarResponse = GetPaymentInvoiceReconciliationRecordInvoiceLinksWithHttpInfo(space, after, before, expand, limit, order);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List all invoice reconciliation record invoice links 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="after">Set to an object&#39;s ID to retrieve the page of objects coming immediately after the named object. (optional)</param>
        /// <param name="before">Set to an object&#39;s ID to retrieve the page of objects coming immediately before the named object. (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="order">Specify to retrieve objects in chronological (ASC) or reverse chronological (DESC) order. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of InvoiceReconciliationRecordInvoiceLinkListResponse</returns>
        public Wallee.Client.ApiResponse<InvoiceReconciliationRecordInvoiceLinkListResponse> GetPaymentInvoiceReconciliationRecordInvoiceLinksWithHttpInfo(long space, long? after = default, long? before = default, List<string>? expand = default, int? limit = default, SortingOrder? order = default, int operationIndex = 0)
        {
            Wallee.Client.RequestOptions localVarRequestOptions = new Wallee.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Wallee.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            var localVarMultipartFormData = localVarContentType == "multipart/form-data";
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Wallee.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (after != null)
            {
                localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("", "after", after));
            }
            if (before != null)
            {
                localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("", "before", before));
            }
            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("multi", "expand", expand));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (order != null)
            {
                localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("", "order", order));
            }
            localVarRequestOptions.HeaderParameters.Add("space", Wallee.Client.ClientUtils.ParameterToString(space)); // header parameter

            localVarRequestOptions.Operation = "InvoiceReconciliationRecordInvoiceLinksService.GetPaymentInvoiceReconciliationRecordInvoiceLinks";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Get<InvoiceReconciliationRecordInvoiceLinkListResponse>("/payment/invoice-reconciliation-record-invoice-links",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPaymentInvoiceReconciliationRecordInvoiceLinks", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Retrieve an invoice reconciliation record invoice link 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>InvoiceReconciliationRecordInvoiceLink</returns>
        public InvoiceReconciliationRecordInvoiceLink GetPaymentInvoiceReconciliationRecordInvoiceLinksId(long id, long space, List<string>? expand = default, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<InvoiceReconciliationRecordInvoiceLink> localVarResponse = GetPaymentInvoiceReconciliationRecordInvoiceLinksIdWithHttpInfo(id, space, expand);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve an invoice reconciliation record invoice link 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of InvoiceReconciliationRecordInvoiceLink</returns>
        public Wallee.Client.ApiResponse<InvoiceReconciliationRecordInvoiceLink> GetPaymentInvoiceReconciliationRecordInvoiceLinksIdWithHttpInfo(long id, long space, List<string>? expand = default, int operationIndex = 0)
        {
            Wallee.Client.RequestOptions localVarRequestOptions = new Wallee.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Wallee.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            var localVarMultipartFormData = localVarContentType == "multipart/form-data";
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Wallee.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("id", Wallee.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("multi", "expand", expand));
            }
            localVarRequestOptions.HeaderParameters.Add("space", Wallee.Client.ClientUtils.ParameterToString(space)); // header parameter

            localVarRequestOptions.Operation = "InvoiceReconciliationRecordInvoiceLinksService.GetPaymentInvoiceReconciliationRecordInvoiceLinksId";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Get<InvoiceReconciliationRecordInvoiceLink>("/payment/invoice-reconciliation-record-invoice-links/{id}",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPaymentInvoiceReconciliationRecordInvoiceLinksId", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Search invoice reconciliation record invoice links 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="offset">A cursor for pagination, specifies the number of objects to skip. (optional)</param>
        /// <param name="order">The fields and order to sort the objects by. (optional)</param>
        /// <param name="query">The search query to filter the objects by. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>InvoiceReconciliationRecordInvoiceLinkSearchResponse</returns>
        public InvoiceReconciliationRecordInvoiceLinkSearchResponse GetPaymentInvoiceReconciliationRecordInvoiceLinksSearch(long space, List<string>? expand = default, int? limit = default, int? offset = default, string? order = default, string? query = default, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<InvoiceReconciliationRecordInvoiceLinkSearchResponse> localVarResponse = GetPaymentInvoiceReconciliationRecordInvoiceLinksSearchWithHttpInfo(space, expand, limit, offset, order, query);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Search invoice reconciliation record invoice links 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="offset">A cursor for pagination, specifies the number of objects to skip. (optional)</param>
        /// <param name="order">The fields and order to sort the objects by. (optional)</param>
        /// <param name="query">The search query to filter the objects by. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of InvoiceReconciliationRecordInvoiceLinkSearchResponse</returns>
        public Wallee.Client.ApiResponse<InvoiceReconciliationRecordInvoiceLinkSearchResponse> GetPaymentInvoiceReconciliationRecordInvoiceLinksSearchWithHttpInfo(long space, List<string>? expand = default, int? limit = default, int? offset = default, string? order = default, string? query = default, int operationIndex = 0)
        {
            Wallee.Client.RequestOptions localVarRequestOptions = new Wallee.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Wallee.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            var localVarMultipartFormData = localVarContentType == "multipart/form-data";
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Wallee.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("multi", "expand", expand));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (offset != null)
            {
                localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("", "offset", offset));
            }
            if (order != null)
            {
                localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("", "order", order));
            }
            if (query != null)
            {
                localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("", "query", query));
            }
            localVarRequestOptions.HeaderParameters.Add("space", Wallee.Client.ClientUtils.ParameterToString(space)); // header parameter

            localVarRequestOptions.Operation = "InvoiceReconciliationRecordInvoiceLinksService.GetPaymentInvoiceReconciliationRecordInvoiceLinksSearch";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Get<InvoiceReconciliationRecordInvoiceLinkSearchResponse>("/payment/invoice-reconciliation-record-invoice-links/search",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPaymentInvoiceReconciliationRecordInvoiceLinksSearch", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Link an invoice Links the invoice reconciliation record with the provided invoice completion.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordId">The ID of the invoice reconciliation record which should be linked.</param>
        /// <param name="completionId">The ID of the completion which should be linked.</param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="amount">The amount of the invoice reconciliation record linked completion. When omitted the amount is calculated. (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>InvoiceReconciliationRecordInvoiceLink</returns>
        public InvoiceReconciliationRecordInvoiceLink PostPaymentInvoiceReconciliationRecordInvoiceLinks(long recordId, long completionId, long space, decimal? amount = default, List<string>? expand = default, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<InvoiceReconciliationRecordInvoiceLink> localVarResponse = PostPaymentInvoiceReconciliationRecordInvoiceLinksWithHttpInfo(recordId, completionId, space, amount, expand);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Link an invoice Links the invoice reconciliation record with the provided invoice completion.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordId">The ID of the invoice reconciliation record which should be linked.</param>
        /// <param name="completionId">The ID of the completion which should be linked.</param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="amount">The amount of the invoice reconciliation record linked completion. When omitted the amount is calculated. (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of InvoiceReconciliationRecordInvoiceLink</returns>
        public Wallee.Client.ApiResponse<InvoiceReconciliationRecordInvoiceLink> PostPaymentInvoiceReconciliationRecordInvoiceLinksWithHttpInfo(long recordId, long completionId, long space, decimal? amount = default, List<string>? expand = default, int operationIndex = 0)
        {
            Wallee.Client.RequestOptions localVarRequestOptions = new Wallee.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Wallee.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            var localVarMultipartFormData = localVarContentType == "multipart/form-data";
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Wallee.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("", "recordId", recordId));
            localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("", "completionId", completionId));
            if (amount != null)
            {
                localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("", "amount", amount));
            }
            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("multi", "expand", expand));
            }
            localVarRequestOptions.HeaderParameters.Add("space", Wallee.Client.ClientUtils.ParameterToString(space)); // header parameter

            localVarRequestOptions.Operation = "InvoiceReconciliationRecordInvoiceLinksService.PostPaymentInvoiceReconciliationRecordInvoiceLinks";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Post<InvoiceReconciliationRecordInvoiceLink>("/payment/invoice-reconciliation-record-invoice-links",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostPaymentInvoiceReconciliationRecordInvoiceLinks", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Unlink an invoice Unlinks the invoice reconciliation record from the provided invoice completion.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordId">The ID of the invoice reconciliation record which should be unlinked.</param>
        /// <param name="completionId">The ID of the completion which should be unlinked.</param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void PostPaymentInvoiceReconciliationRecordInvoiceLinksUnlink(long recordId, long completionId, long space, int operationIndex = 0)
        {
            PostPaymentInvoiceReconciliationRecordInvoiceLinksUnlinkWithHttpInfo(recordId, completionId, space);
        }

        /// <summary>
        /// Unlink an invoice Unlinks the invoice reconciliation record from the provided invoice completion.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordId">The ID of the invoice reconciliation record which should be unlinked.</param>
        /// <param name="completionId">The ID of the completion which should be unlinked.</param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Wallee.Client.ApiResponse<Object> PostPaymentInvoiceReconciliationRecordInvoiceLinksUnlinkWithHttpInfo(long recordId, long completionId, long space, int operationIndex = 0)
        {
            Wallee.Client.RequestOptions localVarRequestOptions = new Wallee.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Wallee.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            var localVarMultipartFormData = localVarContentType == "multipart/form-data";
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Wallee.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("", "recordId", recordId));
            localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("", "completionId", completionId));
            localVarRequestOptions.HeaderParameters.Add("space", Wallee.Client.ClientUtils.ParameterToString(space)); // header parameter

            localVarRequestOptions.Operation = "InvoiceReconciliationRecordInvoiceLinksService.PostPaymentInvoiceReconciliationRecordInvoiceLinksUnlink";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/payment/invoice-reconciliation-record-invoice-links/unlink",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostPaymentInvoiceReconciliationRecordInvoiceLinksUnlink", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }


    }
}
