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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Wallee.Client.OpenAPIDateConverter;

namespace Wallee.Model
{
    /// <summary>
    /// SubmittedAnalyticsQueryExecution
    /// </summary>
    [DataContract(Name = "SubmittedAnalyticsQueryExecution")]
    public partial class SubmittedAnalyticsQueryExecution : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public FacadeUserFriendlyQueryStatusModel? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubmittedAnalyticsQueryExecution" /> class.
        /// </summary>
        /// <param name="status">status.</param>
        public SubmittedAnalyticsQueryExecution(FacadeUserFriendlyQueryStatusModel? status = default(FacadeUserFriendlyQueryStatusModel?))
        {
            this.Status = status;
        }

        /// <summary>
        /// The external id associated with this query, if any.
        /// </summary>
        /// <value>The external id associated with this query, if any.</value>
        [DataMember(Name = "queryExternalId", EmitDefaultValue = false)]
        public string QueryExternalId { get; private set; }

        /// <summary>
        /// Returns false as QueryExternalId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeQueryExternalId()
        {
            return false;
        }
        /// <summary>
        /// The ID of the target account for which the analytics query will be executed, determining the data scope for the request.
        /// </summary>
        /// <value>The ID of the target account for which the analytics query will be executed, determining the data scope for the request.</value>
        [DataMember(Name = "accountId", EmitDefaultValue = false)]
        public long AccountId { get; private set; }

        /// <summary>
        /// Returns false as AccountId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAccountId()
        {
            return false;
        }
        /// <summary>
        /// The total execution time, in milliseconds, that has been billed for the query.
        /// </summary>
        /// <value>The total execution time, in milliseconds, that has been billed for the query.</value>
        [DataMember(Name = "totalBilledExecutionTimeMs", EmitDefaultValue = false)]
        public int TotalBilledExecutionTimeMs { get; private set; }

        /// <summary>
        /// Returns false as TotalBilledExecutionTimeMs should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTotalBilledExecutionTimeMs()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the query was created.
        /// </summary>
        /// <value>The date and time when the query was created.</value>
        [DataMember(Name = "createdTimestamp", EmitDefaultValue = false)]
        public DateTime CreatedTimestamp { get; private set; }

        /// <summary>
        /// Returns false as CreatedTimestamp should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedTimestamp()
        {
            return false;
        }
        /// <summary>
        /// The number of times the query result file has been downloaded.
        /// </summary>
        /// <value>The number of times the query result file has been downloaded.</value>
        [DataMember(Name = "downloadRequests", EmitDefaultValue = false)]
        public long DownloadRequests { get; private set; }

        /// <summary>
        /// Returns false as DownloadRequests should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDownloadRequests()
        {
            return false;
        }
        /// <summary>
        /// The SQL query as originally submitted by the user.
        /// </summary>
        /// <value>The SQL query as originally submitted by the user.</value>
        [DataMember(Name = "originalQuery", EmitDefaultValue = false)]
        public string OriginalQuery { get; private set; }

        /// <summary>
        /// Returns false as OriginalQuery should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOriginalQuery()
        {
            return false;
        }
        /// <summary>
        /// The total bytes of data scanned by the submitted query.
        /// </summary>
        /// <value>The total bytes of data scanned by the submitted query.</value>
        [DataMember(Name = "scannedBytes", EmitDefaultValue = false)]
        public int ScannedBytes { get; private set; }

        /// <summary>
        /// Returns false as ScannedBytes should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeScannedBytes()
        {
            return false;
        }
        /// <summary>
        /// The unique query token associated with the analytics query execution.
        /// </summary>
        /// <value>The unique query token associated with the analytics query execution.</value>
        [DataMember(Name = "portalQueryToken", EmitDefaultValue = false)]
        public string PortalQueryToken { get; private set; }

        /// <summary>
        /// Returns false as PortalQueryToken should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePortalQueryToken()
        {
            return false;
        }
        /// <summary>
        /// The size, in bytes, of the result file generated by the query.
        /// </summary>
        /// <value>The size, in bytes, of the result file generated by the query.</value>
        [DataMember(Name = "resultFileBytes", EmitDefaultValue = false)]
        public int ResultFileBytes { get; private set; }

        /// <summary>
        /// Returns false as ResultFileBytes should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeResultFileBytes()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubmittedAnalyticsQueryExecution {\n");
            sb.Append("  QueryExternalId: ").Append(QueryExternalId).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  TotalBilledExecutionTimeMs: ").Append(TotalBilledExecutionTimeMs).Append("\n");
            sb.Append("  CreatedTimestamp: ").Append(CreatedTimestamp).Append("\n");
            sb.Append("  DownloadRequests: ").Append(DownloadRequests).Append("\n");
            sb.Append("  OriginalQuery: ").Append(OriginalQuery).Append("\n");
            sb.Append("  ScannedBytes: ").Append(ScannedBytes).Append("\n");
            sb.Append("  PortalQueryToken: ").Append(PortalQueryToken).Append("\n");
            sb.Append("  ResultFileBytes: ").Append(ResultFileBytes).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
