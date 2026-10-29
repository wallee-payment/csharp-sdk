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
    public interface IInvoiceReimbursementsServiceSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// List all invoice reimbursements
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="after">Set to an object&#39;s ID to retrieve the page of objects coming immediately after the named object. (optional)</param>
        /// <param name="before">Set to an object&#39;s ID to retrieve the page of objects coming immediately before the named object. (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="order">Specify to retrieve objects in chronological (ASC) or reverse chronological (DESC) order. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>InvoiceReimbursementListResponse</returns>
        InvoiceReimbursementListResponse GetPaymentInvoiceReimbursements(long space, long? after = default, long? before = default, List<string>? expand = default, int? limit = default, SortingOrder? order = default, int operationIndex = 0);

        /// <summary>
        /// List all invoice reimbursements
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
        /// <returns>ApiResponse of InvoiceReimbursementListResponse</returns>
        ApiResponse<InvoiceReimbursementListResponse> GetPaymentInvoiceReimbursementsWithHttpInfo(long space, long? after = default, long? before = default, List<string>? expand = default, int? limit = default, SortingOrder? order = default, int operationIndex = 0);
        /// <summary>
        /// Retrieve an invoice reimbursement
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>InvoiceReimbursement</returns>
        InvoiceReimbursement GetPaymentInvoiceReimbursementsId(long id, long space, List<string>? expand = default, int operationIndex = 0);

        /// <summary>
        /// Retrieve an invoice reimbursement
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of InvoiceReimbursement</returns>
        ApiResponse<InvoiceReimbursement> GetPaymentInvoiceReimbursementsIdWithHttpInfo(long id, long space, List<string>? expand = default, int operationIndex = 0);
        /// <summary>
        /// Search invoice reimbursements
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="offset">A cursor for pagination, specifies the number of objects to skip. (optional)</param>
        /// <param name="order">The fields and order to sort the objects by. (optional)</param>
        /// <param name="query">The search query to filter the objects by. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>InvoiceReimbursementSearchResponse</returns>
        InvoiceReimbursementSearchResponse GetPaymentInvoiceReimbursementsSearch(long space, List<string>? expand = default, int? limit = default, int? offset = default, string? order = default, string? query = default, int operationIndex = 0);

        /// <summary>
        /// Search invoice reimbursements
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
        /// <returns>ApiResponse of InvoiceReimbursementSearchResponse</returns>
        ApiResponse<InvoiceReimbursementSearchResponse> GetPaymentInvoiceReimbursementsSearchWithHttpInfo(long space, List<string>? expand = default, int? limit = default, int? offset = default, string? order = default, string? query = default, int operationIndex = 0);
        /// <summary>
        /// Update payment connector configuration
        /// </summary>
        /// <remarks>
        /// Updates payment connector configuration for a reimbursement which is in manual review.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="paymentConnectorConfigurationId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>InvoiceReimbursement</returns>
        InvoiceReimbursement PostPaymentInvoiceReimbursementsIdConnector(long id, long paymentConnectorConfigurationId, long space, List<string>? expand = default, int operationIndex = 0);

        /// <summary>
        /// Update payment connector configuration
        /// </summary>
        /// <remarks>
        /// Updates payment connector configuration for a reimbursement which is in manual review.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="paymentConnectorConfigurationId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of InvoiceReimbursement</returns>
        ApiResponse<InvoiceReimbursement> PostPaymentInvoiceReimbursementsIdConnectorWithHttpInfo(long id, long paymentConnectorConfigurationId, long space, List<string>? expand = default, int operationIndex = 0);
        /// <summary>
        /// Update IBAN
        /// </summary>
        /// <remarks>
        /// Updates recipient and/or sender IBAN for a reimbursement which is in manual review.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="recipientIban"> (optional)</param>
        /// <param name="senderIban"> (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>InvoiceReimbursement</returns>
        InvoiceReimbursement PostPaymentInvoiceReimbursementsIdIban(long id, long space, string? recipientIban = default, string? senderIban = default, List<string>? expand = default, int operationIndex = 0);

        /// <summary>
        /// Update IBAN
        /// </summary>
        /// <remarks>
        /// Updates recipient and/or sender IBAN for a reimbursement which is in manual review.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="recipientIban"> (optional)</param>
        /// <param name="senderIban"> (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of InvoiceReimbursement</returns>
        ApiResponse<InvoiceReimbursement> PostPaymentInvoiceReimbursementsIdIbanWithHttpInfo(long id, long space, string? recipientIban = default, string? senderIban = default, List<string>? expand = default, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInvoiceReimbursementsService : IInvoiceReimbursementsServiceSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class InvoiceReimbursementsService : IInvoiceReimbursementsService
    {

        private Wallee.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceReimbursementsService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public InvoiceReimbursementsService(Wallee.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            this.Configuration = configuration;
            this.Client = new Wallee.Client.ApiClient(this.Configuration);
            ExceptionFactory = Wallee.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceReimbursementsService"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public InvoiceReimbursementsService(Wallee.Client.ISynchronousClient client, Wallee.Client.IReadableConfiguration configuration)
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
        /// List all invoice reimbursements 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="after">Set to an object&#39;s ID to retrieve the page of objects coming immediately after the named object. (optional)</param>
        /// <param name="before">Set to an object&#39;s ID to retrieve the page of objects coming immediately before the named object. (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="order">Specify to retrieve objects in chronological (ASC) or reverse chronological (DESC) order. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>InvoiceReimbursementListResponse</returns>
        public InvoiceReimbursementListResponse GetPaymentInvoiceReimbursements(long space, long? after = default, long? before = default, List<string>? expand = default, int? limit = default, SortingOrder? order = default, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<InvoiceReimbursementListResponse> localVarResponse = GetPaymentInvoiceReimbursementsWithHttpInfo(space, after, before, expand, limit, order);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List all invoice reimbursements 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="after">Set to an object&#39;s ID to retrieve the page of objects coming immediately after the named object. (optional)</param>
        /// <param name="before">Set to an object&#39;s ID to retrieve the page of objects coming immediately before the named object. (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="order">Specify to retrieve objects in chronological (ASC) or reverse chronological (DESC) order. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of InvoiceReimbursementListResponse</returns>
        public Wallee.Client.ApiResponse<InvoiceReimbursementListResponse> GetPaymentInvoiceReimbursementsWithHttpInfo(long space, long? after = default, long? before = default, List<string>? expand = default, int? limit = default, SortingOrder? order = default, int operationIndex = 0)
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

            localVarRequestOptions.Operation = "InvoiceReimbursementsService.GetPaymentInvoiceReimbursements";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Get<InvoiceReimbursementListResponse>("/payment/invoice-reimbursements",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPaymentInvoiceReimbursements", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Retrieve an invoice reimbursement 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>InvoiceReimbursement</returns>
        public InvoiceReimbursement GetPaymentInvoiceReimbursementsId(long id, long space, List<string>? expand = default, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<InvoiceReimbursement> localVarResponse = GetPaymentInvoiceReimbursementsIdWithHttpInfo(id, space, expand);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve an invoice reimbursement 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of InvoiceReimbursement</returns>
        public Wallee.Client.ApiResponse<InvoiceReimbursement> GetPaymentInvoiceReimbursementsIdWithHttpInfo(long id, long space, List<string>? expand = default, int operationIndex = 0)
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

            localVarRequestOptions.Operation = "InvoiceReimbursementsService.GetPaymentInvoiceReimbursementsId";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Get<InvoiceReimbursement>("/payment/invoice-reimbursements/{id}",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPaymentInvoiceReimbursementsId", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Search invoice reimbursements 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="offset">A cursor for pagination, specifies the number of objects to skip. (optional)</param>
        /// <param name="order">The fields and order to sort the objects by. (optional)</param>
        /// <param name="query">The search query to filter the objects by. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>InvoiceReimbursementSearchResponse</returns>
        public InvoiceReimbursementSearchResponse GetPaymentInvoiceReimbursementsSearch(long space, List<string>? expand = default, int? limit = default, int? offset = default, string? order = default, string? query = default, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<InvoiceReimbursementSearchResponse> localVarResponse = GetPaymentInvoiceReimbursementsSearchWithHttpInfo(space, expand, limit, offset, order, query);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Search invoice reimbursements 
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="offset">A cursor for pagination, specifies the number of objects to skip. (optional)</param>
        /// <param name="order">The fields and order to sort the objects by. (optional)</param>
        /// <param name="query">The search query to filter the objects by. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of InvoiceReimbursementSearchResponse</returns>
        public Wallee.Client.ApiResponse<InvoiceReimbursementSearchResponse> GetPaymentInvoiceReimbursementsSearchWithHttpInfo(long space, List<string>? expand = default, int? limit = default, int? offset = default, string? order = default, string? query = default, int operationIndex = 0)
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

            localVarRequestOptions.Operation = "InvoiceReimbursementsService.GetPaymentInvoiceReimbursementsSearch";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Get<InvoiceReimbursementSearchResponse>("/payment/invoice-reimbursements/search",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPaymentInvoiceReimbursementsSearch", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Update payment connector configuration Updates payment connector configuration for a reimbursement which is in manual review.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="paymentConnectorConfigurationId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>InvoiceReimbursement</returns>
        public InvoiceReimbursement PostPaymentInvoiceReimbursementsIdConnector(long id, long paymentConnectorConfigurationId, long space, List<string>? expand = default, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<InvoiceReimbursement> localVarResponse = PostPaymentInvoiceReimbursementsIdConnectorWithHttpInfo(id, paymentConnectorConfigurationId, space, expand);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update payment connector configuration Updates payment connector configuration for a reimbursement which is in manual review.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="paymentConnectorConfigurationId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of InvoiceReimbursement</returns>
        public Wallee.Client.ApiResponse<InvoiceReimbursement> PostPaymentInvoiceReimbursementsIdConnectorWithHttpInfo(long id, long paymentConnectorConfigurationId, long space, List<string>? expand = default, int operationIndex = 0)
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
            localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("", "paymentConnectorConfigurationId", paymentConnectorConfigurationId));
            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("multi", "expand", expand));
            }
            localVarRequestOptions.HeaderParameters.Add("space", Wallee.Client.ClientUtils.ParameterToString(space)); // header parameter

            localVarRequestOptions.Operation = "InvoiceReimbursementsService.PostPaymentInvoiceReimbursementsIdConnector";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Post<InvoiceReimbursement>("/payment/invoice-reimbursements/{id}/connector",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostPaymentInvoiceReimbursementsIdConnector", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Update IBAN Updates recipient and/or sender IBAN for a reimbursement which is in manual review.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="recipientIban"> (optional)</param>
        /// <param name="senderIban"> (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>InvoiceReimbursement</returns>
        public InvoiceReimbursement PostPaymentInvoiceReimbursementsIdIban(long id, long space, string? recipientIban = default, string? senderIban = default, List<string>? expand = default, int operationIndex = 0)
        {
            Wallee.Client.ApiResponse<InvoiceReimbursement> localVarResponse = PostPaymentInvoiceReimbursementsIdIbanWithHttpInfo(id, space, recipientIban, senderIban, expand);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update IBAN Updates recipient and/or sender IBAN for a reimbursement which is in manual review.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="recipientIban"> (optional)</param>
        /// <param name="senderIban"> (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of InvoiceReimbursement</returns>
        public Wallee.Client.ApiResponse<InvoiceReimbursement> PostPaymentInvoiceReimbursementsIdIbanWithHttpInfo(long id, long space, string? recipientIban = default, string? senderIban = default, List<string>? expand = default, int operationIndex = 0)
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
            if (recipientIban != null)
            {
                localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("", "recipientIban", recipientIban));
            }
            if (senderIban != null)
            {
                localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("", "senderIban", senderIban));
            }
            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(Wallee.Client.ClientUtils.ParameterToMultiMap("multi", "expand", expand));
            }
            localVarRequestOptions.HeaderParameters.Add("space", Wallee.Client.ClientUtils.ParameterToString(space)); // header parameter

            localVarRequestOptions.Operation = "InvoiceReimbursementsService.PostPaymentInvoiceReimbursementsIdIban";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Post<InvoiceReimbursement>("/payment/invoice-reimbursements/{id}/iban",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostPaymentInvoiceReimbursementsIdIban", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }


    }
}
