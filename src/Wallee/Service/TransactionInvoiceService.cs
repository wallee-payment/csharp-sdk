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
    public interface ITransactionInvoiceService : IApiAccessor
    {
        #region Synchronous Operations
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
        /// getInvoiceDocument
        /// </summary>
        /// <remarks>
        /// Returns the PDF document for the transaction invoice with given id.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice to get the document for.</param>
        /// <returns>RenderedDocument</returns>
        RenderedDocument GetInvoiceDocument (long? spaceId, long? id);

        /// <summary>
        /// getInvoiceDocument
        /// </summary>
        /// <remarks>
        /// Returns the PDF document for the transaction invoice with given id.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice to get the document for.</param>
        /// <returns>ApiResponse of RenderedDocument</returns>
        ApiResponse<RenderedDocument> GetInvoiceDocumentWithHttpInfo (long? spaceId, long? id);



        /// <summary>
        /// getInvoiceDocumentWithTargetMediaType
        /// </summary>
        /// <remarks>
        /// Returns the PDF document for the transaction invoice with given id and target media type id.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice to get the document for.</param>
        /// <param name="targetMediaTypeId">The id of the target media type for which the invoice should be generated for.</param>
        /// <returns>RenderedDocument</returns>
        RenderedDocument GetInvoiceDocumentWithTargetMediaType (long? spaceId, long? id, long? targetMediaTypeId);

        /// <summary>
        /// getInvoiceDocumentWithTargetMediaType
        /// </summary>
        /// <remarks>
        /// Returns the PDF document for the transaction invoice with given id and target media type id.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice to get the document for.</param>
        /// <param name="targetMediaTypeId">The id of the target media type for which the invoice should be generated for.</param>
        /// <returns>ApiResponse of RenderedDocument</returns>
        ApiResponse<RenderedDocument> GetInvoiceDocumentWithTargetMediaTypeWithHttpInfo (long? spaceId, long? id, long? targetMediaTypeId);



        /// <summary>
        /// isReplacementPossible
        /// </summary>
        /// <remarks>
        /// Returns whether the transaction invoice with the given id can be replaced.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The invoice which should be checked if a replacement is possible.</param>
        /// <returns>bool?</returns>
        bool? IsReplacementPossible (long? spaceId, long? id);

        /// <summary>
        /// isReplacementPossible
        /// </summary>
        /// <remarks>
        /// Returns whether the transaction invoice with the given id can be replaced.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The invoice which should be checked if a replacement is possible.</param>
        /// <returns>ApiResponse of bool?</returns>
        ApiResponse<bool?> IsReplacementPossibleWithHttpInfo (long? spaceId, long? id);



        /// <summary>
        /// Mark as Derecognized
        /// </summary>
        /// <remarks>
        /// Marks the transaction invoice with the given id as derecognized.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice which should be marked as derecognized.</param>
        /// <returns>TransactionInvoice</returns>
        TransactionInvoice MarkAsDerecognized (long? spaceId, long? id);

        /// <summary>
        /// Mark as Derecognized
        /// </summary>
        /// <remarks>
        /// Marks the transaction invoice with the given id as derecognized.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice which should be marked as derecognized.</param>
        /// <returns>ApiResponse of TransactionInvoice</returns>
        ApiResponse<TransactionInvoice> MarkAsDerecognizedWithHttpInfo (long? spaceId, long? id);



        /// <summary>
        /// Mark as Paid
        /// </summary>
        /// <remarks>
        /// Marks the transaction invoice with the given id as paid.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice which should be marked as paid.</param>
        /// <returns>TransactionInvoice</returns>
        TransactionInvoice MarkAsPaid (long? spaceId, long? id);

        /// <summary>
        /// Mark as Paid
        /// </summary>
        /// <remarks>
        /// Marks the transaction invoice with the given id as paid.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice which should be marked as paid.</param>
        /// <returns>ApiResponse of TransactionInvoice</returns>
        ApiResponse<TransactionInvoice> MarkAsPaidWithHttpInfo (long? spaceId, long? id);



        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoices which should be returned.</param>
        /// <returns>TransactionInvoice</returns>
        TransactionInvoice Read (long? spaceId, long? id);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoices which should be returned.</param>
        /// <returns>ApiResponse of TransactionInvoice</returns>
        ApiResponse<TransactionInvoice> ReadWithHttpInfo (long? spaceId, long? id);



        /// <summary>
        /// replace
        /// </summary>
        /// <remarks>
        /// Replaces the transaction invoice with given id with the replacement and returns the new transaction invoice.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoices which should be replaced.</param>
        /// <param name="replacement"></param>
        /// <returns>TransactionInvoice</returns>
        TransactionInvoice Replace (long? spaceId, long? id, TransactionInvoiceReplacement replacement);

        /// <summary>
        /// replace
        /// </summary>
        /// <remarks>
        /// Replaces the transaction invoice with given id with the replacement and returns the new transaction invoice.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoices which should be replaced.</param>
        /// <param name="replacement"></param>
        /// <returns>ApiResponse of TransactionInvoice</returns>
        ApiResponse<TransactionInvoice> ReplaceWithHttpInfo (long? spaceId, long? id, TransactionInvoiceReplacement replacement);



        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the transaction invoices which are returned by the search.</param>
        /// <returns>List&lt;TransactionInvoice&gt;</returns>
        List<TransactionInvoice> Search (long? spaceId, EntityQuery query);

        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the transaction invoices which are returned by the search.</param>
        /// <returns>ApiResponse of List&lt;TransactionInvoice&gt;</returns>
        ApiResponse<List<TransactionInvoice>> SearchWithHttpInfo (long? spaceId, EntityQuery query);



        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TransactionInvoiceService : ITransactionInvoiceService
    {
        private Wallee.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionInvoiceService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TransactionInvoiceService(Wallee.Client.Configuration configuration = null)
        {
            if (configuration == null) {
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
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionInvoiceService->Count");

            var localVarPath = "/transaction-invoice/count";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
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
            if (filter != null && filter.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(filter); // http body (model) parameter
            }
            else
            {
                localVarPostBody = filter; // byte array
            }

			int requestTimeout = this.Configuration.Timeout * 1000;

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
                localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

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
        /// getInvoiceDocument Returns the PDF document for the transaction invoice with given id.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice to get the document for.</param>
        /// <returns>RenderedDocument</returns>
        public RenderedDocument GetInvoiceDocument (long? spaceId, long? id)
        {
             ApiResponse<RenderedDocument> localVarResponse = GetInvoiceDocumentWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// getInvoiceDocument Returns the PDF document for the transaction invoice with given id.
        
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice to get the document for.</param>
        /// <returns>ApiResponse of RenderedDocument</returns>
        public ApiResponse< RenderedDocument > GetInvoiceDocumentWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionInvoiceService->GetInvoiceDocument");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionInvoiceService->GetInvoiceDocument");

            var localVarPath = "/transaction-invoice/getInvoiceDocument";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
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
            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter

			int requestTimeout = this.Configuration.Timeout * 1000;

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
                localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetInvoiceDocument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RenderedDocument>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (RenderedDocument) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RenderedDocument)));
        }
        /// <summary>
        /// getInvoiceDocumentWithTargetMediaType Returns the PDF document for the transaction invoice with given id and target media type id.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice to get the document for.</param>
        /// <param name="targetMediaTypeId">The id of the target media type for which the invoice should be generated for.</param>
        /// <returns>RenderedDocument</returns>
        public RenderedDocument GetInvoiceDocumentWithTargetMediaType (long? spaceId, long? id, long? targetMediaTypeId)
        {
             ApiResponse<RenderedDocument> localVarResponse = GetInvoiceDocumentWithTargetMediaTypeWithHttpInfo(spaceId, id, targetMediaTypeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// getInvoiceDocumentWithTargetMediaType Returns the PDF document for the transaction invoice with given id and target media type id.
        
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice to get the document for.</param>
        /// <param name="targetMediaTypeId">The id of the target media type for which the invoice should be generated for.</param>
        /// <returns>ApiResponse of RenderedDocument</returns>
        public ApiResponse< RenderedDocument > GetInvoiceDocumentWithTargetMediaTypeWithHttpInfo (long? spaceId, long? id, long? targetMediaTypeId)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionInvoiceService->GetInvoiceDocumentWithTargetMediaType");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionInvoiceService->GetInvoiceDocumentWithTargetMediaType");
            // verify the required parameter 'targetMediaTypeId' is set
            if (targetMediaTypeId == null)
                throw new ApiException(400, "Missing required parameter 'targetMediaTypeId' when calling TransactionInvoiceService->GetInvoiceDocumentWithTargetMediaType");

            var localVarPath = "/transaction-invoice/getInvoiceDocumentWithTargetMediaType";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
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
            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter
            if (targetMediaTypeId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "targetMediaTypeId", targetMediaTypeId)); // query parameter

			int requestTimeout = this.Configuration.Timeout * 1000;

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
                localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetInvoiceDocumentWithTargetMediaType", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RenderedDocument>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (RenderedDocument) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RenderedDocument)));
        }
        /// <summary>
        /// isReplacementPossible Returns whether the transaction invoice with the given id can be replaced.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The invoice which should be checked if a replacement is possible.</param>
        /// <returns>bool?</returns>
        public bool? IsReplacementPossible (long? spaceId, long? id)
        {
             ApiResponse<bool?> localVarResponse = IsReplacementPossibleWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// isReplacementPossible Returns whether the transaction invoice with the given id can be replaced.
        
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The invoice which should be checked if a replacement is possible.</param>
        /// <returns>ApiResponse of bool?</returns>
        public ApiResponse< bool? > IsReplacementPossibleWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionInvoiceService->IsReplacementPossible");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionInvoiceService->IsReplacementPossible");

            var localVarPath = "/transaction-invoice/isReplacementPossible";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
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
            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter

			int requestTimeout = this.Configuration.Timeout * 1000;

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
                localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("IsReplacementPossible", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<bool?>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (bool?) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(bool?)));
        }
        /// <summary>
        /// Mark as Derecognized Marks the transaction invoice with the given id as derecognized.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice which should be marked as derecognized.</param>
        /// <returns>TransactionInvoice</returns>
        public TransactionInvoice MarkAsDerecognized (long? spaceId, long? id)
        {
             ApiResponse<TransactionInvoice> localVarResponse = MarkAsDerecognizedWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Mark as Derecognized Marks the transaction invoice with the given id as derecognized.
        
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice which should be marked as derecognized.</param>
        /// <returns>ApiResponse of TransactionInvoice</returns>
        public ApiResponse< TransactionInvoice > MarkAsDerecognizedWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionInvoiceService->MarkAsDerecognized");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionInvoiceService->MarkAsDerecognized");

            var localVarPath = "/transaction-invoice/markAsDerecognized";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
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
            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter

			int requestTimeout = this.Configuration.Timeout * 1000;

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
                localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("MarkAsDerecognized", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransactionInvoice>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (TransactionInvoice) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransactionInvoice)));
        }
        /// <summary>
        /// Mark as Paid Marks the transaction invoice with the given id as paid.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice which should be marked as paid.</param>
        /// <returns>TransactionInvoice</returns>
        public TransactionInvoice MarkAsPaid (long? spaceId, long? id)
        {
             ApiResponse<TransactionInvoice> localVarResponse = MarkAsPaidWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Mark as Paid Marks the transaction invoice with the given id as paid.
        
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice which should be marked as paid.</param>
        /// <returns>ApiResponse of TransactionInvoice</returns>
        public ApiResponse< TransactionInvoice > MarkAsPaidWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionInvoiceService->MarkAsPaid");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionInvoiceService->MarkAsPaid");

            var localVarPath = "/transaction-invoice/markAsPaid";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
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
            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter

			int requestTimeout = this.Configuration.Timeout * 1000;

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
                localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("MarkAsPaid", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransactionInvoice>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (TransactionInvoice) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransactionInvoice)));
        }
        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoices which should be returned.</param>
        /// <returns>TransactionInvoice</returns>
        public TransactionInvoice Read (long? spaceId, long? id)
        {
             ApiResponse<TransactionInvoice> localVarResponse = ReadWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoices which should be returned.</param>
        /// <returns>ApiResponse of TransactionInvoice</returns>
        public ApiResponse< TransactionInvoice > ReadWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionInvoiceService->Read");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionInvoiceService->Read");

            var localVarPath = "/transaction-invoice/read";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
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
            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter

			int requestTimeout = this.Configuration.Timeout * 1000;

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
                localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Read", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransactionInvoice>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (TransactionInvoice) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransactionInvoice)));
        }
        /// <summary>
        /// replace Replaces the transaction invoice with given id with the replacement and returns the new transaction invoice.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoices which should be replaced.</param>
        /// <param name="replacement"></param>
        /// <returns>TransactionInvoice</returns>
        public TransactionInvoice Replace (long? spaceId, long? id, TransactionInvoiceReplacement replacement)
        {
             ApiResponse<TransactionInvoice> localVarResponse = ReplaceWithHttpInfo(spaceId, id, replacement);
             return localVarResponse.Data;
        }

        /// <summary>
        /// replace Replaces the transaction invoice with given id with the replacement and returns the new transaction invoice.
        
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoices which should be replaced.</param>
        /// <param name="replacement"></param>
        /// <returns>ApiResponse of TransactionInvoice</returns>
        public ApiResponse< TransactionInvoice > ReplaceWithHttpInfo (long? spaceId, long? id, TransactionInvoiceReplacement replacement)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionInvoiceService->Replace");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionInvoiceService->Replace");
            // verify the required parameter 'replacement' is set
            if (replacement == null)
                throw new ApiException(400, "Missing required parameter 'replacement' when calling TransactionInvoiceService->Replace");

            var localVarPath = "/transaction-invoice/replace";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
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
            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter
            if (replacement != null && replacement.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(replacement); // http body (model) parameter
            }
            else
            {
                localVarPostBody = replacement; // byte array
            }

			int requestTimeout = this.Configuration.Timeout * 1000;

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
                localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Replace", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransactionInvoice>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (TransactionInvoice) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransactionInvoice)));
        }
        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the transaction invoices which are returned by the search.</param>
        /// <returns>List&lt;TransactionInvoice&gt;</returns>
        public List<TransactionInvoice> Search (long? spaceId, EntityQuery query)
        {
             ApiResponse<List<TransactionInvoice>> localVarResponse = SearchWithHttpInfo(spaceId, query);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the transaction invoices which are returned by the search.</param>
        /// <returns>ApiResponse of List&lt;TransactionInvoice&gt;</returns>
        public ApiResponse< List<TransactionInvoice> > SearchWithHttpInfo (long? spaceId, EntityQuery query)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionInvoiceService->Search");
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling TransactionInvoiceService->Search");

            var localVarPath = "/transaction-invoice/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
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
            if (query != null && query.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(query); // http body (model) parameter
            }
            else
            {
                localVarPostBody = query; // byte array
            }

			int requestTimeout = this.Configuration.Timeout * 1000;

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
                localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Search", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<TransactionInvoice>>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (List<TransactionInvoice>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<TransactionInvoice>)));
        }
    }
}
