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
    /// The metric usage is the actual usage of a metric for a particular subscription as collected by an external application.
    /// </summary>
    [DataContract]
    public partial class SubscriptionMetricUsageReport :  IEquatable<SubscriptionMetricUsageReport>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionMetricUsageReport" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public SubscriptionMetricUsageReport()
        {
        }

        /// <summary>
        /// The number of resources consumed, will be charged in the next billing cycle.
        /// </summary>
        /// <value>The number of resources consumed, will be charged in the next billing cycle.</value>
        [DataMember(Name="consumedUnits", EmitDefaultValue=false)]
        public decimal? ConsumedUnits { get; private set; }

        /// <summary>
        /// The ID of the user the usage report was created by.
        /// </summary>
        /// <value>The ID of the user the usage report was created by.</value>
        [DataMember(Name="createdByUserId", EmitDefaultValue=false)]
        public long? CreatedByUserId { get; private set; }

        /// <summary>
        /// The date and time when the usage report was created.
        /// </summary>
        /// <value>The date and time when the usage report was created.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// A description used to identify the usage report.
        /// </summary>
        /// <value>A description used to identify the usage report.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; private set; }

        /// <summary>
        /// A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.
        /// </summary>
        /// <value>A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; private set; }

        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The ID of the space this object belongs to.
        /// </summary>
        /// <value>The ID of the space this object belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// The metric that the usage report is recorded for.
        /// </summary>
        /// <value>The metric that the usage report is recorded for.</value>
        [DataMember(Name="metric", EmitDefaultValue=false)]
        public long? Metric { get; private set; }

        /// <summary>
        /// The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.
        /// </summary>
        /// <value>The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// The subscription that the usage report is recorded for.
        /// </summary>
        /// <value>The subscription that the usage report is recorded for.</value>
        [DataMember(Name="subscription", EmitDefaultValue=false)]
        public long? Subscription { get; private set; }

        /// <summary>
        /// The version is used for optimistic locking and incremented whenever the object is updated.
        /// </summary>
        /// <value>The version is used for optimistic locking and incremented whenever the object is updated.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionMetricUsageReport {\n");
            sb.Append("  ConsumedUnits: ").Append(ConsumedUnits).Append("\n");
            sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  Metric: ").Append(Metric).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as SubscriptionMetricUsageReport);
        }

        /// <summary>
        /// Returns true if SubscriptionMetricUsageReport instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionMetricUsageReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionMetricUsageReport input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConsumedUnits == input.ConsumedUnits ||
                    (this.ConsumedUnits != null &&
                    this.ConsumedUnits.Equals(input.ConsumedUnits))
                ) && 
                (
                    this.CreatedByUserId == input.CreatedByUserId ||
                    (this.CreatedByUserId != null &&
                    this.CreatedByUserId.Equals(input.CreatedByUserId))
                ) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LinkedSpaceId == input.LinkedSpaceId ||
                    (this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(input.LinkedSpaceId))
                ) && 
                (
                    this.Metric == input.Metric ||
                    (this.Metric != null &&
                    this.Metric.Equals(input.Metric))
                ) && 
                (
                    this.PlannedPurgeDate == input.PlannedPurgeDate ||
                    (this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(input.PlannedPurgeDate))
                ) && 
                (
                    this.Subscription == input.Subscription ||
                    (this.Subscription != null &&
                    this.Subscription.Equals(input.Subscription))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.ConsumedUnits != null)
                    hashCode = hashCode * 59 + this.ConsumedUnits.GetHashCode();
                if (this.CreatedByUserId != null)
                    hashCode = hashCode * 59 + this.CreatedByUserId.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.Metric != null)
                    hashCode = hashCode * 59 + this.Metric.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.Subscription != null)
                    hashCode = hashCode * 59 + this.Subscription.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
