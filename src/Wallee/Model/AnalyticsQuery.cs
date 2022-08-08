using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Wallee.Client.SwaggerDateConverter;

namespace Wallee.Model
{
    /// <summary>
    /// Represents a query to be submitted for execution in Analytics.
    /// </summary>
    [DataContract]
    public partial class AnalyticsQuery :  IEquatable<AnalyticsQuery>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQuery" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AnalyticsQuery() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQuery" /> class.
        /// </summary>
        /// <param name="accountId">The mandatory ID of an account in which the query shall be executed. Must be a valid account ID greater than 0. (required).</param>
        public AnalyticsQuery(long? accountId)
        {
            // to ensure "accountId" is required (not null)
            if (accountId == null)
            {
                throw new InvalidDataException("accountId is a required property for AnalyticsQuery and cannot be null");
            }
            this.AccountId = accountId;
        }

        /// <summary>
        /// The mandatory ID of an account in which the query shall be executed. Must be a valid account ID greater than 0.
        /// </summary>
        /// <value>The mandatory ID of an account in which the query shall be executed. Must be a valid account ID greater than 0.</value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public long? AccountId { get; set; }

        /// <summary>
        /// A client generated nonce which uniquely identifies the query to be executed. Subsequent submissions with the same external ID will not re-execute the query but instead return the existing execution with that ID. Either the External ID or a Maximal Cache Age greater than 0 must be specified. If both are specified the External ID will have precedence and the Maximal Cache Age will be ignored.
        /// </summary>
        /// <value>A client generated nonce which uniquely identifies the query to be executed. Subsequent submissions with the same external ID will not re-execute the query but instead return the existing execution with that ID. Either the External ID or a Maximal Cache Age greater than 0 must be specified. If both are specified the External ID will have precedence and the Maximal Cache Age will be ignored.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The maximal age in minutes of cached query executions to return. If an equivalent query execution with the same Query String, Account ID and Spaces parameters not older than the specified age is already available that execution will be returned instead of a newly started execution. Set to 0 or null (and set a unique, previously unused External ID) to force a new query execution irrespective of previous executions. Either the External ID or a Cache Duration greater than 0 must be specified. If both are specified, the External ID will be preferred (and the Maximal Cache Age ignored).
        /// </summary>
        /// <value>The maximal age in minutes of cached query executions to return. If an equivalent query execution with the same Query String, Account ID and Spaces parameters not older than the specified age is already available that execution will be returned instead of a newly started execution. Set to 0 or null (and set a unique, previously unused External ID) to force a new query execution irrespective of previous executions. Either the External ID or a Cache Duration greater than 0 must be specified. If both are specified, the External ID will be preferred (and the Maximal Cache Age ignored).</value>
        [DataMember(Name="maxCacheAge", EmitDefaultValue=false)]
        public int? MaxCacheAge { get; set; }

        /// <summary>
        /// The SQL statement which is being submitted for execution. Must be a valid PrestoDB/Athena SQL statement.
        /// </summary>
        /// <value>The SQL statement which is being submitted for execution. Must be a valid PrestoDB/Athena SQL statement.</value>
        [DataMember(Name="queryString", EmitDefaultValue=false)]
        public string QueryString { get; set; }

        /// <summary>
        /// The maximal amount of scanned data that this query is allowed to scan. After this limit is reached query will be canceled by the system. 
        /// </summary>
        /// <value>The maximal amount of scanned data that this query is allowed to scan. After this limit is reached query will be canceled by the system. </value>
        [DataMember(Name="scannedDataLimit", EmitDefaultValue=false)]
        public decimal? ScannedDataLimit { get; set; }

        /// <summary>
        /// The IDs of the spaces in which the query shall be executed. At most 5 space IDs may be specified. All specified spaces must be owned by the account specified by the accountId property. The spaces property may be missing or empty to query all spaces of the specified account.
        /// </summary>
        /// <value>The IDs of the spaces in which the query shall be executed. At most 5 space IDs may be specified. All specified spaces must be owned by the account specified by the accountId property. The spaces property may be missing or empty to query all spaces of the specified account.</value>
        [DataMember(Name="spaceIds", EmitDefaultValue=false)]
        public List<long?> SpaceIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsQuery {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  MaxCacheAge: ").Append(MaxCacheAge).Append("\n");
            sb.Append("  QueryString: ").Append(QueryString).Append("\n");
            sb.Append("  ScannedDataLimit: ").Append(ScannedDataLimit).Append("\n");
            sb.Append("  SpaceIds: ").Append(SpaceIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AnalyticsQuery);
        }

        /// <summary>
        /// Returns true if AnalyticsQuery instances are equal
        /// </summary>
        /// <param name="input">Instance of AnalyticsQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsQuery input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.MaxCacheAge == input.MaxCacheAge ||
                    (this.MaxCacheAge != null &&
                    this.MaxCacheAge.Equals(input.MaxCacheAge))
                ) && 
                (
                    this.QueryString == input.QueryString ||
                    (this.QueryString != null &&
                    this.QueryString.Equals(input.QueryString))
                ) && 
                (
                    this.ScannedDataLimit == input.ScannedDataLimit ||
                    (this.ScannedDataLimit != null &&
                    this.ScannedDataLimit.Equals(input.ScannedDataLimit))
                ) && 
                (
                    this.SpaceIds == input.SpaceIds ||
                    this.SpaceIds != null &&
                    input.SpaceIds != null &&
                    this.SpaceIds.SequenceEqual(input.SpaceIds)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.MaxCacheAge != null)
                    hashCode = hashCode * 59 + this.MaxCacheAge.GetHashCode();
                if (this.QueryString != null)
                    hashCode = hashCode * 59 + this.QueryString.GetHashCode();
                if (this.ScannedDataLimit != null)
                    hashCode = hashCode * 59 + this.ScannedDataLimit.GetHashCode();
                if (this.SpaceIds != null)
                    hashCode = hashCode * 59 + this.SpaceIds.GetHashCode();
                return hashCode;
            }
        }

    }

}
