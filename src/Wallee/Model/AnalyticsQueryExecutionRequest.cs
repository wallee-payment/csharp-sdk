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
    /// AnalyticsQueryExecutionRequest
    /// </summary>
    [DataContract(Name = "AnalyticsQueryExecutionRequest")]
    public partial class AnalyticsQueryExecutionRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueryExecutionRequest" /> class.
        /// </summary>
        /// <param name="sftpDispatchSettingsId">Optional. ID of the active SFTP configuration to use (associated with the target account). This is only required if the result file is scheduled for delivery to a remote SFTP server..</param>
        /// <param name="sftpDispatchResultFileRenamePattern">Optional. Renaming pattern used for the result file during SFTP delivery. You can use a combination of fixed Latin text and timestamp variables (e.g., \&quot;transaction_report_{YYYMMDD_hhmmss}\&quot;). Supported variable formats: DDMMYY, MMDDYY, YYYYMMDD, DD_MM_YY, DD-MM-YY, YYYY-MM-DD, YYYY_MM_DD, YYYYMMDD_hhmmss, YYYY-MM-DD_hh-mm-ss..</param>
        /// <param name="sql">The SQL query (in PrestoDB dialect) to execute on the analytics database. This query defines exactly which data should be retrieved..</param>
        public AnalyticsQueryExecutionRequest(long sftpDispatchSettingsId = default(long), string sftpDispatchResultFileRenamePattern = default(string), string sql = default(string))
        {
            this.SftpDispatchSettingsId = sftpDispatchSettingsId;
            this.SftpDispatchResultFileRenamePattern = sftpDispatchResultFileRenamePattern;
            this.Sql = sql;
        }

        /// <summary>
        /// Optional. ID of the active SFTP configuration to use (associated with the target account). This is only required if the result file is scheduled for delivery to a remote SFTP server.
        /// </summary>
        /// <value>Optional. ID of the active SFTP configuration to use (associated with the target account). This is only required if the result file is scheduled for delivery to a remote SFTP server.</value>
        [DataMember(Name = "sftpDispatchSettingsId", EmitDefaultValue = false)]
        public long SftpDispatchSettingsId { get; set; }

        /// <summary>
        /// Optional. Renaming pattern used for the result file during SFTP delivery. You can use a combination of fixed Latin text and timestamp variables (e.g., \&quot;transaction_report_{YYYMMDD_hhmmss}\&quot;). Supported variable formats: DDMMYY, MMDDYY, YYYYMMDD, DD_MM_YY, DD-MM-YY, YYYY-MM-DD, YYYY_MM_DD, YYYYMMDD_hhmmss, YYYY-MM-DD_hh-mm-ss.
        /// </summary>
        /// <value>Optional. Renaming pattern used for the result file during SFTP delivery. You can use a combination of fixed Latin text and timestamp variables (e.g., \&quot;transaction_report_{YYYMMDD_hhmmss}\&quot;). Supported variable formats: DDMMYY, MMDDYY, YYYYMMDD, DD_MM_YY, DD-MM-YY, YYYY-MM-DD, YYYY_MM_DD, YYYYMMDD_hhmmss, YYYY-MM-DD_hh-mm-ss.</value>
        [DataMember(Name = "sftpDispatchResultFileRenamePattern", EmitDefaultValue = false)]
        public string SftpDispatchResultFileRenamePattern { get; set; }

        /// <summary>
        /// The SQL query (in PrestoDB dialect) to execute on the analytics database. This query defines exactly which data should be retrieved.
        /// </summary>
        /// <value>The SQL query (in PrestoDB dialect) to execute on the analytics database. This query defines exactly which data should be retrieved.</value>
        [DataMember(Name = "sql", EmitDefaultValue = false)]
        public string Sql { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AnalyticsQueryExecutionRequest {\n");
            sb.Append("  SftpDispatchSettingsId: ").Append(SftpDispatchSettingsId).Append("\n");
            sb.Append("  SftpDispatchResultFileRenamePattern: ").Append(SftpDispatchResultFileRenamePattern).Append("\n");
            sb.Append("  Sql: ").Append(Sql).Append("\n");
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
            // Sql (string) maxLength
            if (this.Sql != null && this.Sql.Length > 100000)
            {
                yield return new ValidationResult("Invalid value for Sql, length must be less than 100000.", new [] { "Sql" });
            }

            // Sql (string) minLength
            if (this.Sql != null && this.Sql.Length < 3)
            {
                yield return new ValidationResult("Invalid value for Sql, length must be greater than 3.", new [] { "Sql" });
            }

            yield break;
        }
    }

}
