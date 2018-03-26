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
    public interface IDebtCollectionCaseService : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Add Collected Amount
        /// </summary>
        /// <remarks>
        /// Adds a new collected amount to the case, creating a new payment receipt.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// Creates the entity with the given properties.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The object with all the properties which should be updated. The id and the version are required properties.</param>
        /// <returns>ApiResponse of DebtCollectionCase</returns>
        ApiResponse<DebtCollectionCase> UpdateWithHttpInfo (long? spaceId, DebtCollectionCaseUpdate entity);

        #endregion Synchronous Operations
        #region Asynchronous Operations

        /// <summary>
        /// Add Collected Amount
        /// </summary>
        /// <remarks>
        /// Adds a new collected amount to the case, creating a new payment receipt.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case for which the amount should be added.</param>
        /// <param name="collectedAmount">The amount that has been collected.</param>
        /// <param name="externalId">The unique external id of this payment receipt.</param>
        /// <returns>Task of DebtCollectionReceipt</returns>
        System.Threading.Tasks.Task<DebtCollectionReceipt> AddCollectedAmountAsync (long? spaceId, long? id, decimal? collectedAmount, string externalId);

        /// <summary>
        /// Add Collected Amount
        /// </summary>
        /// <remarks>
        /// Adds a new collected amount to the case, creating a new payment receipt.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case for which the amount should be added.</param>
        /// <param name="collectedAmount">The amount that has been collected.</param>
        /// <param name="externalId">The unique external id of this payment receipt.</param>
        /// <returns>Task of ApiResponse (DebtCollectionReceipt)</returns>
        System.Threading.Tasks.Task<ApiResponse<DebtCollectionReceipt>> AddCollectedAmountAsyncWithHttpInfo (long? spaceId, long? id, decimal? collectedAmount, string externalId);

        /// <summary>
        /// Attach Document
        /// </summary>
        /// <remarks>
        /// Attach an additional supporting document to the case.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case.</param>
        /// <param name="fileName">The file name of the document that is uploaded.</param>
        /// <param name="contentBase64">The BASE64 encoded contents of the document.</param>
        /// <returns>Task of DebtCollectionCaseDocument</returns>
        System.Threading.Tasks.Task<DebtCollectionCaseDocument> AttachDocumentAsync (long? spaceId, long? id, string fileName, string contentBase64);

        /// <summary>
        /// Attach Document
        /// </summary>
        /// <remarks>
        /// Attach an additional supporting document to the case.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case.</param>
        /// <param name="fileName">The file name of the document that is uploaded.</param>
        /// <param name="contentBase64">The BASE64 encoded contents of the document.</param>
        /// <returns>Task of ApiResponse (DebtCollectionCaseDocument)</returns>
        System.Threading.Tasks.Task<ApiResponse<DebtCollectionCaseDocument>> AttachDocumentAsyncWithHttpInfo (long? spaceId, long? id, string fileName, string contentBase64);

        /// <summary>
        /// Close
        /// </summary>
        /// <remarks>
        /// Closes the debt collection case, meaning no further money can be collected.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case which should be closed.</param>
        /// <returns>Task of DebtCollectionCase</returns>
        System.Threading.Tasks.Task<DebtCollectionCase> CloseAsync (long? spaceId, long? id);

        /// <summary>
        /// Close
        /// </summary>
        /// <remarks>
        /// Closes the debt collection case, meaning no further money can be collected.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case which should be closed.</param>
        /// <returns>Task of ApiResponse (DebtCollectionCase)</returns>
        System.Threading.Tasks.Task<ApiResponse<DebtCollectionCase>> CloseAsyncWithHttpInfo (long? spaceId, long? id);

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
        /// Creates the entity with the given properties.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The debt collection case object with the properties which should be created.</param>
        /// <returns>Task of DebtCollectionCase</returns>
        System.Threading.Tasks.Task<DebtCollectionCase> CreateAsync (long? spaceId, DebtCollectionCaseCreate entity);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// Creates the entity with the given properties.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The debt collection case object with the properties which should be created.</param>
        /// <returns>Task of ApiResponse (DebtCollectionCase)</returns>
        System.Threading.Tasks.Task<ApiResponse<DebtCollectionCase>> CreateAsyncWithHttpInfo (long? spaceId, DebtCollectionCaseCreate entity);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// Deletes the entity with the given id.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteAsync (long? spaceId, long? id);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// Deletes the entity with the given id.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAsyncWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// Documents
        /// </summary>
        /// <remarks>
        /// Returns all documents that are attached to a debt collection case.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case for which the attached documents are returned.</param>
        /// <returns>Task of List&lt;DebtCollectionCaseDocument&gt;</returns>
        System.Threading.Tasks.Task<List<DebtCollectionCaseDocument>> DocumentsAsync (long? spaceId, long? id);

        /// <summary>
        /// Documents
        /// </summary>
        /// <remarks>
        /// Returns all documents that are attached to a debt collection case.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case for which the attached documents are returned.</param>
        /// <returns>Task of ApiResponse (List&lt;DebtCollectionCaseDocument&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<DebtCollectionCaseDocument>>> DocumentsAsyncWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// Mark Case As Prepared
        /// </summary>
        /// <remarks>
        /// This operation will mark a debt collection case as prepared and allow the collection process to proceed.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case which should be marked as prepared.</param>
        /// <returns>Task of DebtCollectionCase</returns>
        System.Threading.Tasks.Task<DebtCollectionCase> MarkAsPreparedAsync (long? spaceId, long? id);

        /// <summary>
        /// Mark Case As Prepared
        /// </summary>
        /// <remarks>
        /// This operation will mark a debt collection case as prepared and allow the collection process to proceed.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case which should be marked as prepared.</param>
        /// <returns>Task of ApiResponse (DebtCollectionCase)</returns>
        System.Threading.Tasks.Task<ApiResponse<DebtCollectionCase>> MarkAsPreparedAsyncWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// Mark Case As Reviewed
        /// </summary>
        /// <remarks>
        /// This operation will mark a debt collection case as reviewed and allow the collection process to proceed.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case which should be reviewed.</param>
        /// <returns>Task of DebtCollectionCase</returns>
        System.Threading.Tasks.Task<DebtCollectionCase> MarkAsReviewedAsync (long? spaceId, long? id);

        /// <summary>
        /// Mark Case As Reviewed
        /// </summary>
        /// <remarks>
        /// This operation will mark a debt collection case as reviewed and allow the collection process to proceed.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case which should be reviewed.</param>
        /// <returns>Task of ApiResponse (DebtCollectionCase)</returns>
        System.Threading.Tasks.Task<ApiResponse<DebtCollectionCase>> MarkAsReviewedAsyncWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case which should be returned.</param>
        /// <returns>Task of DebtCollectionCase</returns>
        System.Threading.Tasks.Task<DebtCollectionCase> ReadAsync (long? spaceId, long? id);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case which should be returned.</param>
        /// <returns>Task of ApiResponse (DebtCollectionCase)</returns>
        System.Threading.Tasks.Task<ApiResponse<DebtCollectionCase>> ReadAsyncWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the cases which are returned by the search.</param>
        /// <returns>Task of List&lt;DebtCollectionCase&gt;</returns>
        System.Threading.Tasks.Task<List<DebtCollectionCase>> SearchAsync (long? spaceId, EntityQuery query);

        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the cases which are returned by the search.</param>
        /// <returns>Task of ApiResponse (List&lt;DebtCollectionCase&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<DebtCollectionCase>>> SearchAsyncWithHttpInfo (long? spaceId, EntityQuery query);

        /// <summary>
        /// Update
        /// </summary>
        /// <remarks>
        /// This updates the entity with the given properties. Only those properties which should be updated can be provided. The &#39;id&#39; and &#39;version&#39; are required to identify the entity.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The object with all the properties which should be updated. The id and the version are required properties.</param>
        /// <returns>Task of DebtCollectionCase</returns>
        System.Threading.Tasks.Task<DebtCollectionCase> UpdateAsync (long? spaceId, DebtCollectionCaseUpdate entity);

        /// <summary>
        /// Update
        /// </summary>
        /// <remarks>
        /// This updates the entity with the given properties. Only those properties which should be updated can be provided. The &#39;id&#39; and &#39;version&#39; are required to identify the entity.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The object with all the properties which should be updated. The id and the version are required properties.</param>
        /// <returns>Task of ApiResponse (DebtCollectionCase)</returns>
        System.Threading.Tasks.Task<ApiResponse<DebtCollectionCase>> UpdateAsyncWithHttpInfo (long? spaceId, DebtCollectionCaseUpdate entity);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DebtCollectionCaseService : IDebtCollectionCaseService
    {
        private readonly Customweb.Wallee.Client.ExceptionFactory _exceptionFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="DebtCollectionCaseService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DebtCollectionCaseService(Configuration configuration = null)
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
        /// Add Collected Amount Adds a new collected amount to the case, creating a new payment receipt.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case for which the amount should be added.</param>
        /// <param name="collectedAmount">The amount that has been collected.</param>
        /// <param name="externalId">The unique external id of this payment receipt.</param>
        /// <returns>ApiResponse of DebtCollectionReceipt</returns>
        public ApiResponse< DebtCollectionReceipt > AddCollectedAmountWithHttpInfo (long? spaceId, long? id, decimal? collectedAmount, string externalId)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling DebtCollectionCaseService->AddCollectedAmount");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling DebtCollectionCaseService->AddCollectedAmount");
            }
            // verify the required parameter 'collectedAmount' is set
            if (collectedAmount == null)
            {
                throw new ApiException(400, "Missing required parameter 'collectedAmount' when calling DebtCollectionCaseService->AddCollectedAmount");
            }
            // verify the required parameter 'externalId' is set
            if (externalId == null)
            {
                throw new ApiException(400, "Missing required parameter 'externalId' when calling DebtCollectionCaseService->AddCollectedAmount");
            }

            var localVarPath = "/debt-collection-case/addCollectedAmount";
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
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
            if (collectedAmount != null) localVarQueryParams.Add("collectedAmount", ApiClient.ParameterToString(collectedAmount)); // query parameter
            if (externalId != null) localVarQueryParams.Add("externalId", ApiClient.ParameterToString(externalId)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddCollectedAmount", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DebtCollectionReceipt>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DebtCollectionReceipt) ApiClient.Deserialize(localVarResponse, typeof(DebtCollectionReceipt)));
        }

        /// <summary>
        /// Add Collected Amount Adds a new collected amount to the case, creating a new payment receipt.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case for which the amount should be added.</param>
        /// <param name="collectedAmount">The amount that has been collected.</param>
        /// <param name="externalId">The unique external id of this payment receipt.</param>
        /// <returns>Task of DebtCollectionReceipt</returns>
        public async System.Threading.Tasks.Task<DebtCollectionReceipt> AddCollectedAmountAsync (long? spaceId, long? id, decimal? collectedAmount, string externalId)
        {
             ApiResponse<DebtCollectionReceipt> localVarResponse = await AddCollectedAmountAsyncWithHttpInfo(spaceId, id, collectedAmount, externalId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add Collected Amount Adds a new collected amount to the case, creating a new payment receipt.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case for which the amount should be added.</param>
        /// <param name="collectedAmount">The amount that has been collected.</param>
        /// <param name="externalId">The unique external id of this payment receipt.</param>
        /// <returns>Task of ApiResponse (DebtCollectionReceipt)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DebtCollectionReceipt>> AddCollectedAmountAsyncWithHttpInfo (long? spaceId, long? id, decimal? collectedAmount, string externalId)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling DebtCollectionCaseService->AddCollectedAmount");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling DebtCollectionCaseService->AddCollectedAmount");
            }
            // verify the required parameter 'collectedAmount' is set
            if (collectedAmount == null)
            {
                throw new ApiException(400, "Missing required parameter 'collectedAmount' when calling DebtCollectionCaseService->AddCollectedAmount");
            }
            // verify the required parameter 'externalId' is set
            if (externalId == null)
            {
                throw new ApiException(400, "Missing required parameter 'externalId' when calling DebtCollectionCaseService->AddCollectedAmount");
            }

            var localVarPath = "/debt-collection-case/addCollectedAmount";
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
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
            if (collectedAmount != null) localVarQueryParams.Add("collectedAmount", ApiClient.ParameterToString(collectedAmount)); // query parameter
            if (externalId != null) localVarQueryParams.Add("externalId", ApiClient.ParameterToString(externalId)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddCollectedAmount", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DebtCollectionReceipt>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DebtCollectionReceipt) ApiClient.Deserialize(localVarResponse, typeof(DebtCollectionReceipt)));
        }

        /// <summary>
        /// Attach Document Attach an additional supporting document to the case.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case.</param>
        /// <param name="fileName">The file name of the document that is uploaded.</param>
        /// <param name="contentBase64">The BASE64 encoded contents of the document.</param>
        /// <returns>ApiResponse of DebtCollectionCaseDocument</returns>
        public ApiResponse< DebtCollectionCaseDocument > AttachDocumentWithHttpInfo (long? spaceId, long? id, string fileName, string contentBase64)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling DebtCollectionCaseService->AttachDocument");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling DebtCollectionCaseService->AttachDocument");
            }
            // verify the required parameter 'fileName' is set
            if (fileName == null)
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling DebtCollectionCaseService->AttachDocument");
            }
            // verify the required parameter 'contentBase64' is set
            if (contentBase64 == null)
            {
                throw new ApiException(400, "Missing required parameter 'contentBase64' when calling DebtCollectionCaseService->AttachDocument");
            }

            var localVarPath = "/debt-collection-case/attachDocument";
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
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
            if (fileName != null) localVarQueryParams.Add("fileName", ApiClient.ParameterToString(fileName)); // query parameter
            if (contentBase64 != null) localVarQueryParams.Add("contentBase64", ApiClient.ParameterToString(contentBase64)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AttachDocument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DebtCollectionCaseDocument>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DebtCollectionCaseDocument) ApiClient.Deserialize(localVarResponse, typeof(DebtCollectionCaseDocument)));
        }

        /// <summary>
        /// Attach Document Attach an additional supporting document to the case.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case.</param>
        /// <param name="fileName">The file name of the document that is uploaded.</param>
        /// <param name="contentBase64">The BASE64 encoded contents of the document.</param>
        /// <returns>Task of DebtCollectionCaseDocument</returns>
        public async System.Threading.Tasks.Task<DebtCollectionCaseDocument> AttachDocumentAsync (long? spaceId, long? id, string fileName, string contentBase64)
        {
             ApiResponse<DebtCollectionCaseDocument> localVarResponse = await AttachDocumentAsyncWithHttpInfo(spaceId, id, fileName, contentBase64);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Attach Document Attach an additional supporting document to the case.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case.</param>
        /// <param name="fileName">The file name of the document that is uploaded.</param>
        /// <param name="contentBase64">The BASE64 encoded contents of the document.</param>
        /// <returns>Task of ApiResponse (DebtCollectionCaseDocument)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DebtCollectionCaseDocument>> AttachDocumentAsyncWithHttpInfo (long? spaceId, long? id, string fileName, string contentBase64)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling DebtCollectionCaseService->AttachDocument");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling DebtCollectionCaseService->AttachDocument");
            }
            // verify the required parameter 'fileName' is set
            if (fileName == null)
            {
                throw new ApiException(400, "Missing required parameter 'fileName' when calling DebtCollectionCaseService->AttachDocument");
            }
            // verify the required parameter 'contentBase64' is set
            if (contentBase64 == null)
            {
                throw new ApiException(400, "Missing required parameter 'contentBase64' when calling DebtCollectionCaseService->AttachDocument");
            }

            var localVarPath = "/debt-collection-case/attachDocument";
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
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
            if (fileName != null) localVarQueryParams.Add("fileName", ApiClient.ParameterToString(fileName)); // query parameter
            if (contentBase64 != null) localVarQueryParams.Add("contentBase64", ApiClient.ParameterToString(contentBase64)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AttachDocument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DebtCollectionCaseDocument>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DebtCollectionCaseDocument) ApiClient.Deserialize(localVarResponse, typeof(DebtCollectionCaseDocument)));
        }

        /// <summary>
        /// Close Closes the debt collection case, meaning no further money can be collected.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case which should be closed.</param>
        /// <returns>ApiResponse of DebtCollectionCase</returns>
        public ApiResponse< DebtCollectionCase > CloseWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling DebtCollectionCaseService->Close");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling DebtCollectionCaseService->Close");
            }

            var localVarPath = "/debt-collection-case/close";
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
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Close", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DebtCollectionCase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DebtCollectionCase) ApiClient.Deserialize(localVarResponse, typeof(DebtCollectionCase)));
        }

        /// <summary>
        /// Close Closes the debt collection case, meaning no further money can be collected.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case which should be closed.</param>
        /// <returns>Task of DebtCollectionCase</returns>
        public async System.Threading.Tasks.Task<DebtCollectionCase> CloseAsync (long? spaceId, long? id)
        {
             ApiResponse<DebtCollectionCase> localVarResponse = await CloseAsyncWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Close Closes the debt collection case, meaning no further money can be collected.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case which should be closed.</param>
        /// <returns>Task of ApiResponse (DebtCollectionCase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DebtCollectionCase>> CloseAsyncWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling DebtCollectionCaseService->Close");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling DebtCollectionCaseService->Close");
            }

            var localVarPath = "/debt-collection-case/close";
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Close", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DebtCollectionCase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DebtCollectionCase) ApiClient.Deserialize(localVarResponse, typeof(DebtCollectionCase)));
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
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling DebtCollectionCaseService->Count");
            }

            var localVarPath = "/debt-collection-case/count";
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
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling DebtCollectionCaseService->Count");
            }

            var localVarPath = "/debt-collection-case/count";
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
        /// Create Creates the entity with the given properties.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The debt collection case object with the properties which should be created.</param>
        /// <returns>ApiResponse of DebtCollectionCase</returns>
        public ApiResponse< DebtCollectionCase > CreateWithHttpInfo (long? spaceId, DebtCollectionCaseCreate entity)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling DebtCollectionCaseService->Create");
            }
            // verify the required parameter 'entity' is set
            if (entity == null)
            {
                throw new ApiException(400, "Missing required parameter 'entity' when calling DebtCollectionCaseService->Create");
            }

            var localVarPath = "/debt-collection-case/create";
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
            if (entity != null && entity.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(entity); // http body (model) parameter
            }
            else
            {
                localVarPostBody = entity; // byte array
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

            return new ApiResponse<DebtCollectionCase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DebtCollectionCase) ApiClient.Deserialize(localVarResponse, typeof(DebtCollectionCase)));
        }

        /// <summary>
        /// Create Creates the entity with the given properties.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The debt collection case object with the properties which should be created.</param>
        /// <returns>Task of DebtCollectionCase</returns>
        public async System.Threading.Tasks.Task<DebtCollectionCase> CreateAsync (long? spaceId, DebtCollectionCaseCreate entity)
        {
             ApiResponse<DebtCollectionCase> localVarResponse = await CreateAsyncWithHttpInfo(spaceId, entity);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Creates the entity with the given properties.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The debt collection case object with the properties which should be created.</param>
        /// <returns>Task of ApiResponse (DebtCollectionCase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DebtCollectionCase>> CreateAsyncWithHttpInfo (long? spaceId, DebtCollectionCaseCreate entity)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling DebtCollectionCaseService->Create");
            }
            // verify the required parameter 'entity' is set
            if (entity == null)
            {
                throw new ApiException(400, "Missing required parameter 'entity' when calling DebtCollectionCaseService->Create");
            }

            var localVarPath = "/debt-collection-case/create";
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
            if (entity != null && entity.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(entity); // http body (model) parameter
            }
            else
            {
                localVarPostBody = entity; // byte array
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

            return new ApiResponse<DebtCollectionCase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DebtCollectionCase) ApiClient.Deserialize(localVarResponse, typeof(DebtCollectionCase)));
        }

        /// <summary>
        /// Delete Deletes the entity with the given id.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling DebtCollectionCaseService->Delete");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling DebtCollectionCaseService->Delete");
            }

            var localVarPath = "/debt-collection-case/delete";
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
            if (id != null && id.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(id); // http body (model) parameter
            }
            else
            {
                localVarPostBody = id; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Delete", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete Deletes the entity with the given id.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteAsync (long? spaceId, long? id)
        {
             await DeleteAsyncWithHttpInfo(spaceId, id);
        }

        /// <summary>
        /// Delete Deletes the entity with the given id.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAsyncWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling DebtCollectionCaseService->Delete");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling DebtCollectionCaseService->Delete");
            }

            var localVarPath = "/debt-collection-case/delete";
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
            if (id != null && id.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(id); // http body (model) parameter
            }
            else
            {
                localVarPostBody = id; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Delete", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Documents Returns all documents that are attached to a debt collection case.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case for which the attached documents are returned.</param>
        /// <returns>ApiResponse of List&lt;DebtCollectionCaseDocument&gt;</returns>
        public ApiResponse< List<DebtCollectionCaseDocument> > DocumentsWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling DebtCollectionCaseService->Documents");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling DebtCollectionCaseService->Documents");
            }

            var localVarPath = "/debt-collection-case/documents";
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
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Documents", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<DebtCollectionCaseDocument>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<DebtCollectionCaseDocument>) ApiClient.Deserialize(localVarResponse, typeof(List<DebtCollectionCaseDocument>)));
        }

        /// <summary>
        /// Documents Returns all documents that are attached to a debt collection case.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case for which the attached documents are returned.</param>
        /// <returns>Task of List&lt;DebtCollectionCaseDocument&gt;</returns>
        public async System.Threading.Tasks.Task<List<DebtCollectionCaseDocument>> DocumentsAsync (long? spaceId, long? id)
        {
             ApiResponse<List<DebtCollectionCaseDocument>> localVarResponse = await DocumentsAsyncWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Documents Returns all documents that are attached to a debt collection case.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case for which the attached documents are returned.</param>
        /// <returns>Task of ApiResponse (List&lt;DebtCollectionCaseDocument&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<DebtCollectionCaseDocument>>> DocumentsAsyncWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling DebtCollectionCaseService->Documents");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling DebtCollectionCaseService->Documents");
            }

            var localVarPath = "/debt-collection-case/documents";
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Documents", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<DebtCollectionCaseDocument>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<DebtCollectionCaseDocument>) ApiClient.Deserialize(localVarResponse, typeof(List<DebtCollectionCaseDocument>)));
        }

        /// <summary>
        /// Mark Case As Prepared This operation will mark a debt collection case as prepared and allow the collection process to proceed.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case which should be marked as prepared.</param>
        /// <returns>ApiResponse of DebtCollectionCase</returns>
        public ApiResponse< DebtCollectionCase > MarkAsPreparedWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling DebtCollectionCaseService->MarkAsPrepared");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling DebtCollectionCaseService->MarkAsPrepared");
            }

            var localVarPath = "/debt-collection-case/markAsPrepared";
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
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("MarkAsPrepared", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DebtCollectionCase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DebtCollectionCase) ApiClient.Deserialize(localVarResponse, typeof(DebtCollectionCase)));
        }

        /// <summary>
        /// Mark Case As Prepared This operation will mark a debt collection case as prepared and allow the collection process to proceed.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case which should be marked as prepared.</param>
        /// <returns>Task of DebtCollectionCase</returns>
        public async System.Threading.Tasks.Task<DebtCollectionCase> MarkAsPreparedAsync (long? spaceId, long? id)
        {
             ApiResponse<DebtCollectionCase> localVarResponse = await MarkAsPreparedAsyncWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Mark Case As Prepared This operation will mark a debt collection case as prepared and allow the collection process to proceed.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case which should be marked as prepared.</param>
        /// <returns>Task of ApiResponse (DebtCollectionCase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DebtCollectionCase>> MarkAsPreparedAsyncWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling DebtCollectionCaseService->MarkAsPrepared");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling DebtCollectionCaseService->MarkAsPrepared");
            }

            var localVarPath = "/debt-collection-case/markAsPrepared";
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("MarkAsPrepared", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DebtCollectionCase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DebtCollectionCase) ApiClient.Deserialize(localVarResponse, typeof(DebtCollectionCase)));
        }

        /// <summary>
        /// Mark Case As Reviewed This operation will mark a debt collection case as reviewed and allow the collection process to proceed.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case which should be reviewed.</param>
        /// <returns>ApiResponse of DebtCollectionCase</returns>
        public ApiResponse< DebtCollectionCase > MarkAsReviewedWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling DebtCollectionCaseService->MarkAsReviewed");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling DebtCollectionCaseService->MarkAsReviewed");
            }

            var localVarPath = "/debt-collection-case/markAsReviewed";
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
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("MarkAsReviewed", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DebtCollectionCase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DebtCollectionCase) ApiClient.Deserialize(localVarResponse, typeof(DebtCollectionCase)));
        }

        /// <summary>
        /// Mark Case As Reviewed This operation will mark a debt collection case as reviewed and allow the collection process to proceed.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case which should be reviewed.</param>
        /// <returns>Task of DebtCollectionCase</returns>
        public async System.Threading.Tasks.Task<DebtCollectionCase> MarkAsReviewedAsync (long? spaceId, long? id)
        {
             ApiResponse<DebtCollectionCase> localVarResponse = await MarkAsReviewedAsyncWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Mark Case As Reviewed This operation will mark a debt collection case as reviewed and allow the collection process to proceed.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case which should be reviewed.</param>
        /// <returns>Task of ApiResponse (DebtCollectionCase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DebtCollectionCase>> MarkAsReviewedAsyncWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling DebtCollectionCaseService->MarkAsReviewed");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling DebtCollectionCaseService->MarkAsReviewed");
            }

            var localVarPath = "/debt-collection-case/markAsReviewed";
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("MarkAsReviewed", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DebtCollectionCase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DebtCollectionCase) ApiClient.Deserialize(localVarResponse, typeof(DebtCollectionCase)));
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case which should be returned.</param>
        /// <returns>ApiResponse of DebtCollectionCase</returns>
        public ApiResponse< DebtCollectionCase > ReadWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling DebtCollectionCaseService->Read");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling DebtCollectionCaseService->Read");
            }

            var localVarPath = "/debt-collection-case/read";
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

            return new ApiResponse<DebtCollectionCase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DebtCollectionCase) ApiClient.Deserialize(localVarResponse, typeof(DebtCollectionCase)));
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case which should be returned.</param>
        /// <returns>Task of DebtCollectionCase</returns>
        public async System.Threading.Tasks.Task<DebtCollectionCase> ReadAsync (long? spaceId, long? id)
        {
             ApiResponse<DebtCollectionCase> localVarResponse = await ReadAsyncWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the debt collection case which should be returned.</param>
        /// <returns>Task of ApiResponse (DebtCollectionCase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DebtCollectionCase>> ReadAsyncWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling DebtCollectionCaseService->Read");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling DebtCollectionCaseService->Read");
            }

            var localVarPath = "/debt-collection-case/read";
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

            return new ApiResponse<DebtCollectionCase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DebtCollectionCase) ApiClient.Deserialize(localVarResponse, typeof(DebtCollectionCase)));
        }

        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the cases which are returned by the search.</param>
        /// <returns>ApiResponse of List&lt;DebtCollectionCase&gt;</returns>
        public ApiResponse< List<DebtCollectionCase> > SearchWithHttpInfo (long? spaceId, EntityQuery query)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling DebtCollectionCaseService->Search");
            }
            // verify the required parameter 'query' is set
            if (query == null)
            {
                throw new ApiException(400, "Missing required parameter 'query' when calling DebtCollectionCaseService->Search");
            }

            var localVarPath = "/debt-collection-case/search";
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

            return new ApiResponse<List<DebtCollectionCase>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<DebtCollectionCase>) ApiClient.Deserialize(localVarResponse, typeof(List<DebtCollectionCase>)));
        }

        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the cases which are returned by the search.</param>
        /// <returns>Task of List&lt;DebtCollectionCase&gt;</returns>
        public async System.Threading.Tasks.Task<List<DebtCollectionCase>> SearchAsync (long? spaceId, EntityQuery query)
        {
             ApiResponse<List<DebtCollectionCase>> localVarResponse = await SearchAsyncWithHttpInfo(spaceId, query);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the cases which are returned by the search.</param>
        /// <returns>Task of ApiResponse (List&lt;DebtCollectionCase&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<DebtCollectionCase>>> SearchAsyncWithHttpInfo (long? spaceId, EntityQuery query)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling DebtCollectionCaseService->Search");
            }
            // verify the required parameter 'query' is set
            if (query == null)
            {
                throw new ApiException(400, "Missing required parameter 'query' when calling DebtCollectionCaseService->Search");
            }

            var localVarPath = "/debt-collection-case/search";
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

            return new ApiResponse<List<DebtCollectionCase>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<DebtCollectionCase>) ApiClient.Deserialize(localVarResponse, typeof(List<DebtCollectionCase>)));
        }

        /// <summary>
        /// Update This updates the entity with the given properties. Only those properties which should be updated can be provided. The &#39;id&#39; and &#39;version&#39; are required to identify the entity.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The object with all the properties which should be updated. The id and the version are required properties.</param>
        /// <returns>ApiResponse of DebtCollectionCase</returns>
        public ApiResponse< DebtCollectionCase > UpdateWithHttpInfo (long? spaceId, DebtCollectionCaseUpdate entity)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling DebtCollectionCaseService->Update");
            }
            // verify the required parameter 'entity' is set
            if (entity == null)
            {
                throw new ApiException(400, "Missing required parameter 'entity' when calling DebtCollectionCaseService->Update");
            }

            var localVarPath = "/debt-collection-case/update";
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
            if (entity != null && entity.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(entity); // http body (model) parameter
            }
            else
            {
                localVarPostBody = entity; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Update", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DebtCollectionCase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DebtCollectionCase) ApiClient.Deserialize(localVarResponse, typeof(DebtCollectionCase)));
        }

        /// <summary>
        /// Update This updates the entity with the given properties. Only those properties which should be updated can be provided. The &#39;id&#39; and &#39;version&#39; are required to identify the entity.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The object with all the properties which should be updated. The id and the version are required properties.</param>
        /// <returns>Task of DebtCollectionCase</returns>
        public async System.Threading.Tasks.Task<DebtCollectionCase> UpdateAsync (long? spaceId, DebtCollectionCaseUpdate entity)
        {
             ApiResponse<DebtCollectionCase> localVarResponse = await UpdateAsyncWithHttpInfo(spaceId, entity);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update This updates the entity with the given properties. Only those properties which should be updated can be provided. The &#39;id&#39; and &#39;version&#39; are required to identify the entity.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="entity">The object with all the properties which should be updated. The id and the version are required properties.</param>
        /// <returns>Task of ApiResponse (DebtCollectionCase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DebtCollectionCase>> UpdateAsyncWithHttpInfo (long? spaceId, DebtCollectionCaseUpdate entity)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling DebtCollectionCaseService->Update");
            }
            // verify the required parameter 'entity' is set
            if (entity == null)
            {
                throw new ApiException(400, "Missing required parameter 'entity' when calling DebtCollectionCaseService->Update");
            }

            var localVarPath = "/debt-collection-case/update";
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
            if (entity != null && entity.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(entity); // http body (model) parameter
            }
            else
            {
                localVarPostBody = entity; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Update", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DebtCollectionCase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DebtCollectionCase) ApiClient.Deserialize(localVarResponse, typeof(DebtCollectionCase)));
        }

    }
}
