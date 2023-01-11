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
    public interface IDebtCollectionCaseService : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Add Collected Amount
        /// </summary>
        /// <remarks>
        /// Adds a new collected amount to the case, creating a new payment receipt.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case for which the amount should be added.</param>
        /// <param name="collectedAmount">The amount that has been collected.</param>
        /// <param name="externalId">The unique external id of this payment receipt.</param>
        /// <returns>DebtCollectionReceipt</returns>
        DebtCollectionReceipt AddCollectedAmount (long? spaceId, long? id, decimal? collectedAmount, string externalId);

        /// <summary>
        /// Add Collected Amount
        /// </summary>
        /// <remarks>
        /// Adds a new collected amount to the case, creating a new payment receipt.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case for which the amount should be added.</param>
        /// <param name="collectedAmount">The amount that has been collected.</param>
        /// <param name="externalId">The unique external id of this payment receipt.</param>
        /// <returns>ApiResponse of DebtCollectionReceipt</returns>
        ApiResponse<DebtCollectionReceipt> AddCollectedAmountWithHttpInfo (long? spaceId, long? id, decimal? collectedAmount, string externalId);
        /// <summary>
        /// Attach Document
        /// </summary>
        /// <remarks>
        /// Attach an additional supporting document to the case.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case.</param>
        /// <param name="fileName">The file name of the document that is uploaded.</param>
        /// <param name="contentBase64">The BASE64 encoded contents of the document.</param>
        /// <returns>DebtCollectionCaseDocument</returns>
        DebtCollectionCaseDocument AttachDocument (long? spaceId, long? id, string fileName, string contentBase64);

        /// <summary>
        /// Attach Document
        /// </summary>
        /// <remarks>
        /// Attach an additional supporting document to the case.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case.</param>
        /// <param name="fileName">The file name of the document that is uploaded.</param>
        /// <param name="contentBase64">The BASE64 encoded contents of the document.</param>
        /// <returns>ApiResponse of DebtCollectionCaseDocument</returns>
        ApiResponse<DebtCollectionCaseDocument> AttachDocumentWithHttpInfo (long? spaceId, long? id, string fileName, string contentBase64);
        /// <summary>
        /// Close
        /// </summary>
        /// <remarks>
        /// Closes the debt collection case, meaning no further money can be collected.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case which should be closed.</param>
        /// <returns>DebtCollectionCase</returns>
        DebtCollectionCase Close (long? spaceId, long? id);

        /// <summary>
        /// Close
        /// </summary>
        /// <remarks>
        /// Closes the debt collection case, meaning no further money can be collected.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case which should be closed.</param>
        /// <returns>ApiResponse of DebtCollectionCase</returns>
        ApiResponse<DebtCollectionCase> CloseWithHttpInfo (long? spaceId, long? id);
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
        /// Creates the entity with the given properties.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The debt collection case object with the properties which should be created.</param>
        /// <returns>DebtCollectionCase</returns>
        DebtCollectionCase Create (long? spaceId, DebtCollectionCaseCreate entity);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// Creates the entity with the given properties.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The debt collection case object with the properties which should be created.</param>
        /// <returns>ApiResponse of DebtCollectionCase</returns>
        ApiResponse<DebtCollectionCase> CreateWithHttpInfo (long? spaceId, DebtCollectionCaseCreate entity);
        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// Deletes the entity with the given id.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        void Delete (long? spaceId, long? id);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// Deletes the entity with the given id.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteWithHttpInfo (long? spaceId, long? id);
        /// <summary>
        /// Documents
        /// </summary>
        /// <remarks>
        /// Returns all documents that are attached to a debt collection case.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case for which the attached documents are returned.</param>
        /// <returns>List&lt;DebtCollectionCaseDocument&gt;</returns>
        List<DebtCollectionCaseDocument> Documents (long? spaceId, long? id);

        /// <summary>
        /// Documents
        /// </summary>
        /// <remarks>
        /// Returns all documents that are attached to a debt collection case.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case for which the attached documents are returned.</param>
        /// <returns>ApiResponse of List&lt;DebtCollectionCaseDocument&gt;</returns>
        ApiResponse<List<DebtCollectionCaseDocument>> DocumentsWithHttpInfo (long? spaceId, long? id);
        /// <summary>
        /// Mark Case As Prepared
        /// </summary>
        /// <remarks>
        /// This operation will mark a debt collection case as prepared and allow the collection process to proceed.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case which should be marked as prepared.</param>
        /// <returns>DebtCollectionCase</returns>
        DebtCollectionCase MarkAsPrepared (long? spaceId, long? id);

        /// <summary>
        /// Mark Case As Prepared
        /// </summary>
        /// <remarks>
        /// This operation will mark a debt collection case as prepared and allow the collection process to proceed.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case which should be marked as prepared.</param>
        /// <returns>ApiResponse of DebtCollectionCase</returns>
        ApiResponse<DebtCollectionCase> MarkAsPreparedWithHttpInfo (long? spaceId, long? id);
        /// <summary>
        /// Mark Case As Reviewed
        /// </summary>
        /// <remarks>
        /// This operation will mark a debt collection case as reviewed and allow the collection process to proceed.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case which should be reviewed.</param>
        /// <returns>DebtCollectionCase</returns>
        DebtCollectionCase MarkAsReviewed (long? spaceId, long? id);

        /// <summary>
        /// Mark Case As Reviewed
        /// </summary>
        /// <remarks>
        /// This operation will mark a debt collection case as reviewed and allow the collection process to proceed.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case which should be reviewed.</param>
        /// <returns>ApiResponse of DebtCollectionCase</returns>
        ApiResponse<DebtCollectionCase> MarkAsReviewedWithHttpInfo (long? spaceId, long? id);
        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case which should be returned.</param>
        /// <returns>DebtCollectionCase</returns>
        DebtCollectionCase Read (long? spaceId, long? id);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case which should be returned.</param>
        /// <returns>ApiResponse of DebtCollectionCase</returns>
        ApiResponse<DebtCollectionCase> ReadWithHttpInfo (long? spaceId, long? id);
        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the cases which are returned by the search.</param>
        /// <returns>List&lt;DebtCollectionCase&gt;</returns>
        List<DebtCollectionCase> Search (long? spaceId, EntityQuery query);

        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the cases which are returned by the search.</param>
        /// <returns>ApiResponse of List&lt;DebtCollectionCase&gt;</returns>
        ApiResponse<List<DebtCollectionCase>> SearchWithHttpInfo (long? spaceId, EntityQuery query);
        /// <summary>
        /// Update
        /// </summary>
        /// <remarks>
        /// This updates the entity with the given properties. Only those properties which should be updated can be provided. The &#39;id&#39; and &#39;version&#39; are required to identify the entity.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The object with all the properties which should be updated. The id and the version are required properties.</param>
        /// <returns>DebtCollectionCase</returns>
        DebtCollectionCase Update (long? spaceId, DebtCollectionCaseUpdate entity);

        /// <summary>
        /// Update
        /// </summary>
        /// <remarks>
        /// This updates the entity with the given properties. Only those properties which should be updated can be provided. The &#39;id&#39; and &#39;version&#39; are required to identify the entity.
        /// </remarks>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The object with all the properties which should be updated. The id and the version are required properties.</param>
        /// <returns>ApiResponse of DebtCollectionCase</returns>
        ApiResponse<DebtCollectionCase> UpdateWithHttpInfo (long? spaceId, DebtCollectionCaseUpdate entity);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DebtCollectionCaseService : IDebtCollectionCaseService
    {
        private Wallee.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DebtCollectionCaseService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DebtCollectionCaseService(Wallee.Client.Configuration configuration = null)
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
        /// Add Collected Amount Adds a new collected amount to the case, creating a new payment receipt.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case for which the amount should be added.</param>
        /// <param name="collectedAmount">The amount that has been collected.</param>
        /// <param name="externalId">The unique external id of this payment receipt.</param>
        /// <returns>DebtCollectionReceipt</returns>
        public DebtCollectionReceipt AddCollectedAmount (long? spaceId, long? id, decimal? collectedAmount, string externalId)
        {
             ApiResponse<DebtCollectionReceipt> localVarResponse = AddCollectedAmountWithHttpInfo(spaceId, id, collectedAmount, externalId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add Collected Amount Adds a new collected amount to the case, creating a new payment receipt.
        
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case for which the amount should be added.</param>
        /// <param name="collectedAmount">The amount that has been collected.</param>
        /// <param name="externalId">The unique external id of this payment receipt.</param>
        /// <returns>ApiResponse of DebtCollectionReceipt</returns>
        public ApiResponse< DebtCollectionReceipt > AddCollectedAmountWithHttpInfo (long? spaceId, long? id, decimal? collectedAmount, string externalId)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling DebtCollectionCaseService->AddCollectedAmount");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DebtCollectionCaseService->AddCollectedAmount");
            // verify the required parameter 'collectedAmount' is set
            if (collectedAmount == null)
                throw new ApiException(400, "Missing required parameter 'collectedAmount' when calling DebtCollectionCaseService->AddCollectedAmount");
            // verify the required parameter 'externalId' is set
            if (externalId == null)
                throw new ApiException(400, "Missing required parameter 'externalId' when calling DebtCollectionCaseService->AddCollectedAmount");

            var localVarPath = "/debt-collection-case/addCollectedAmount";
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
            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter
            if (collectedAmount != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "collectedAmount", collectedAmount)); // query parameter
            if (externalId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "externalId", externalId)); // query parameter

			
            int requestTimeout = this.Configuration.Timeout * 1000;

                // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddCollectedAmount", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DebtCollectionReceipt>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (DebtCollectionReceipt) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DebtCollectionReceipt)));
        }
        /// <summary>
        /// Attach Document Attach an additional supporting document to the case.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case.</param>
        /// <param name="fileName">The file name of the document that is uploaded.</param>
        /// <param name="contentBase64">The BASE64 encoded contents of the document.</param>
        /// <returns>DebtCollectionCaseDocument</returns>
        public DebtCollectionCaseDocument AttachDocument (long? spaceId, long? id, string fileName, string contentBase64)
        {
             ApiResponse<DebtCollectionCaseDocument> localVarResponse = AttachDocumentWithHttpInfo(spaceId, id, fileName, contentBase64);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Attach Document Attach an additional supporting document to the case.
        
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case.</param>
        /// <param name="fileName">The file name of the document that is uploaded.</param>
        /// <param name="contentBase64">The BASE64 encoded contents of the document.</param>
        /// <returns>ApiResponse of DebtCollectionCaseDocument</returns>
        public ApiResponse< DebtCollectionCaseDocument > AttachDocumentWithHttpInfo (long? spaceId, long? id, string fileName, string contentBase64)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling DebtCollectionCaseService->AttachDocument");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DebtCollectionCaseService->AttachDocument");
            // verify the required parameter 'fileName' is set
            if (fileName == null)
                throw new ApiException(400, "Missing required parameter 'fileName' when calling DebtCollectionCaseService->AttachDocument");
            // verify the required parameter 'contentBase64' is set
            if (contentBase64 == null)
                throw new ApiException(400, "Missing required parameter 'contentBase64' when calling DebtCollectionCaseService->AttachDocument");

            var localVarPath = "/debt-collection-case/attachDocument";
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
            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter
            if (fileName != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "fileName", fileName)); // query parameter
            if (contentBase64 != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "contentBase64", contentBase64)); // query parameter

			
            int requestTimeout = this.Configuration.Timeout * 1000;

                // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AttachDocument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DebtCollectionCaseDocument>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (DebtCollectionCaseDocument) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DebtCollectionCaseDocument)));
        }
        /// <summary>
        /// Close Closes the debt collection case, meaning no further money can be collected.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case which should be closed.</param>
        /// <returns>DebtCollectionCase</returns>
        public DebtCollectionCase Close (long? spaceId, long? id)
        {
             ApiResponse<DebtCollectionCase> localVarResponse = CloseWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Close Closes the debt collection case, meaning no further money can be collected.
        
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case which should be closed.</param>
        /// <returns>ApiResponse of DebtCollectionCase</returns>
        public ApiResponse< DebtCollectionCase > CloseWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling DebtCollectionCaseService->Close");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DebtCollectionCaseService->Close");

            var localVarPath = "/debt-collection-case/close";
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
            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter

			
            int requestTimeout = this.Configuration.Timeout * 1000;

                // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Close", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DebtCollectionCase>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (DebtCollectionCase) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DebtCollectionCase)));
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
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling DebtCollectionCaseService->Count");

            var localVarPath = "/debt-collection-case/count";
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

			
            int requestTimeout = this.Configuration.Timeout * 1000;

                // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
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
        /// Create Creates the entity with the given properties.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The debt collection case object with the properties which should be created.</param>
        /// <returns>DebtCollectionCase</returns>
        public DebtCollectionCase Create (long? spaceId, DebtCollectionCaseCreate entity)
        {
             ApiResponse<DebtCollectionCase> localVarResponse = CreateWithHttpInfo(spaceId, entity);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Creates the entity with the given properties.
        
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The debt collection case object with the properties which should be created.</param>
        /// <returns>ApiResponse of DebtCollectionCase</returns>
        public ApiResponse< DebtCollectionCase > CreateWithHttpInfo (long? spaceId, DebtCollectionCaseCreate entity)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling DebtCollectionCaseService->Create");
            // verify the required parameter 'entity' is set
            if (entity == null)
                throw new ApiException(400, "Missing required parameter 'entity' when calling DebtCollectionCaseService->Create");

            var localVarPath = "/debt-collection-case/create";
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
            if (entity != null && entity.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(entity); // http body (model) parameter
            }
            else
            {
                localVarPostBody = entity; // byte array
            }

			
            int requestTimeout = this.Configuration.Timeout * 1000;

                // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Create", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DebtCollectionCase>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (DebtCollectionCase) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DebtCollectionCase)));
        }
        /// <summary>
        /// Delete Deletes the entity with the given id.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public void Delete (long? spaceId, long? id)
        {
             DeleteWithHttpInfo(spaceId, id);
        }

        /// <summary>
        /// Delete Deletes the entity with the given id.
        
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling DebtCollectionCaseService->Delete");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DebtCollectionCaseService->Delete");

            var localVarPath = "/debt-collection-case/delete";
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
            if (id != null && id.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(id); // http body (model) parameter
            }
            else
            {
                localVarPostBody = id; // byte array
            }

			
            int requestTimeout = this.Configuration.Timeout * 1000;

                // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Delete", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers
                    .GroupBy(x => x.Name, x => x.Value.ToString())
                    .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                null);
        }
        /// <summary>
        /// Documents Returns all documents that are attached to a debt collection case.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case for which the attached documents are returned.</param>
        /// <returns>List&lt;DebtCollectionCaseDocument&gt;</returns>
        public List<DebtCollectionCaseDocument> Documents (long? spaceId, long? id)
        {
             ApiResponse<List<DebtCollectionCaseDocument>> localVarResponse = DocumentsWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Documents Returns all documents that are attached to a debt collection case.
        
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case for which the attached documents are returned.</param>
        /// <returns>ApiResponse of List&lt;DebtCollectionCaseDocument&gt;</returns>
        public ApiResponse< List<DebtCollectionCaseDocument> > DocumentsWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling DebtCollectionCaseService->Documents");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DebtCollectionCaseService->Documents");

            var localVarPath = "/debt-collection-case/documents";
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
            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter

			
            int requestTimeout = this.Configuration.Timeout * 1000;

                // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Documents", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<DebtCollectionCaseDocument>>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (List<DebtCollectionCaseDocument>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<DebtCollectionCaseDocument>)));
        }
        /// <summary>
        /// Mark Case As Prepared This operation will mark a debt collection case as prepared and allow the collection process to proceed.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case which should be marked as prepared.</param>
        /// <returns>DebtCollectionCase</returns>
        public DebtCollectionCase MarkAsPrepared (long? spaceId, long? id)
        {
             ApiResponse<DebtCollectionCase> localVarResponse = MarkAsPreparedWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Mark Case As Prepared This operation will mark a debt collection case as prepared and allow the collection process to proceed.
        
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case which should be marked as prepared.</param>
        /// <returns>ApiResponse of DebtCollectionCase</returns>
        public ApiResponse< DebtCollectionCase > MarkAsPreparedWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling DebtCollectionCaseService->MarkAsPrepared");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DebtCollectionCaseService->MarkAsPrepared");

            var localVarPath = "/debt-collection-case/markAsPrepared";
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
            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter

			
            int requestTimeout = this.Configuration.Timeout * 1000;

                // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("MarkAsPrepared", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DebtCollectionCase>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (DebtCollectionCase) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DebtCollectionCase)));
        }
        /// <summary>
        /// Mark Case As Reviewed This operation will mark a debt collection case as reviewed and allow the collection process to proceed.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case which should be reviewed.</param>
        /// <returns>DebtCollectionCase</returns>
        public DebtCollectionCase MarkAsReviewed (long? spaceId, long? id)
        {
             ApiResponse<DebtCollectionCase> localVarResponse = MarkAsReviewedWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Mark Case As Reviewed This operation will mark a debt collection case as reviewed and allow the collection process to proceed.
        
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case which should be reviewed.</param>
        /// <returns>ApiResponse of DebtCollectionCase</returns>
        public ApiResponse< DebtCollectionCase > MarkAsReviewedWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling DebtCollectionCaseService->MarkAsReviewed");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DebtCollectionCaseService->MarkAsReviewed");

            var localVarPath = "/debt-collection-case/markAsReviewed";
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
            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter

			
            int requestTimeout = this.Configuration.Timeout * 1000;

                // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("MarkAsReviewed", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DebtCollectionCase>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (DebtCollectionCase) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DebtCollectionCase)));
        }
        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case which should be returned.</param>
        /// <returns>DebtCollectionCase</returns>
        public DebtCollectionCase Read (long? spaceId, long? id)
        {
             ApiResponse<DebtCollectionCase> localVarResponse = ReadWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case which should be returned.</param>
        /// <returns>ApiResponse of DebtCollectionCase</returns>
        public ApiResponse< DebtCollectionCase > ReadWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling DebtCollectionCaseService->Read");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DebtCollectionCaseService->Read");

            var localVarPath = "/debt-collection-case/read";
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

			
            int requestTimeout = this.Configuration.Timeout * 1000;

                // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Read", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DebtCollectionCase>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (DebtCollectionCase) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DebtCollectionCase)));
        }
        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the cases which are returned by the search.</param>
        /// <returns>List&lt;DebtCollectionCase&gt;</returns>
        public List<DebtCollectionCase> Search (long? spaceId, EntityQuery query)
        {
             ApiResponse<List<DebtCollectionCase>> localVarResponse = SearchWithHttpInfo(spaceId, query);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the cases which are returned by the search.</param>
        /// <returns>ApiResponse of List&lt;DebtCollectionCase&gt;</returns>
        public ApiResponse< List<DebtCollectionCase> > SearchWithHttpInfo (long? spaceId, EntityQuery query)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling DebtCollectionCaseService->Search");
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling DebtCollectionCaseService->Search");

            var localVarPath = "/debt-collection-case/search";
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

			
            int requestTimeout = this.Configuration.Timeout * 1000;

                // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Search", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<DebtCollectionCase>>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (List<DebtCollectionCase>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<DebtCollectionCase>)));
        }
        /// <summary>
        /// Update This updates the entity with the given properties. Only those properties which should be updated can be provided. The &#39;id&#39; and &#39;version&#39; are required to identify the entity.
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The object with all the properties which should be updated. The id and the version are required properties.</param>
        /// <returns>DebtCollectionCase</returns>
        public DebtCollectionCase Update (long? spaceId, DebtCollectionCaseUpdate entity)
        {
             ApiResponse<DebtCollectionCase> localVarResponse = UpdateWithHttpInfo(spaceId, entity);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update This updates the entity with the given properties. Only those properties which should be updated can be provided. The &#39;id&#39; and &#39;version&#39; are required to identify the entity.
        
        /// </summary>
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The object with all the properties which should be updated. The id and the version are required properties.</param>
        /// <returns>ApiResponse of DebtCollectionCase</returns>
        public ApiResponse< DebtCollectionCase > UpdateWithHttpInfo (long? spaceId, DebtCollectionCaseUpdate entity)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling DebtCollectionCaseService->Update");
            // verify the required parameter 'entity' is set
            if (entity == null)
                throw new ApiException(400, "Missing required parameter 'entity' when calling DebtCollectionCaseService->Update");

            var localVarPath = "/debt-collection-case/update";
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
            if (entity != null && entity.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(entity); // http body (model) parameter
            }
            else
            {
                localVarPostBody = entity; // byte array
            }

			
            int requestTimeout = this.Configuration.Timeout * 1000;

                // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Update", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DebtCollectionCase>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (DebtCollectionCase) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DebtCollectionCase)));
        }
    }
}
