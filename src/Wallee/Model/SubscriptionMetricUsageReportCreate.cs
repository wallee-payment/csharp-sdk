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
    public partial class SubscriptionMetricUsageReportCreate :  IEquatable<SubscriptionMetricUsageReportCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionMetricUsageReportCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionMetricUsageReportCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionMetricUsageReportCreate" /> class.
        /// </summary>
        /// <param name="consumedUnits">The number of resources consumed, will be charged in the next billing cycle. (required).</param>
        /// <param name="externalId">A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result. (required).</param>
        /// <param name="metric">The metric that the usage report is recorded for. (required).</param>
        /// <param name="subscription">The subscription that the usage report is recorded for. (required).</param>
        public SubscriptionMetricUsageReportCreate(decimal? consumedUnits, string externalId, long? metric, long? subscription)
        {
            // to ensure "consumedUnits" is required (not null)
            if (consumedUnits == null)
            {
                throw new InvalidDataException("consumedUnits is a required property for SubscriptionMetricUsageReportCreate and cannot be null");
            }
            this.ConsumedUnits = consumedUnits;
            // to ensure "externalId" is required (not null)
            if (externalId == null)
            {
                throw new InvalidDataException("externalId is a required property for SubscriptionMetricUsageReportCreate and cannot be null");
            }
            this.ExternalId = externalId;
            // to ensure "metric" is required (not null)
            if (metric == null)
            {
                throw new InvalidDataException("metric is a required property for SubscriptionMetricUsageReportCreate and cannot be null");
            }
            this.Metric = metric;
            // to ensure "subscription" is required (not null)
            if (subscription == null)
            {
                throw new InvalidDataException("subscription is a required property for SubscriptionMetricUsageReportCreate and cannot be null");
            }
            this.Subscription = subscription;
        }

        /// <summary>
        /// The number of resources consumed, will be charged in the next billing cycle.
        /// </summary>
        /// <value>The number of resources consumed, will be charged in the next billing cycle.</value>
        [DataMember(Name="consumedUnits", EmitDefaultValue=false)]
        public decimal? ConsumedUnits { get; set; }

        /// <summary>
        /// A description used to identify the usage report.
        /// </summary>
        /// <value>A description used to identify the usage report.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.
        /// </summary>
        /// <value>A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The metric that the usage report is recorded for.
        /// </summary>
        /// <value>The metric that the usage report is recorded for.</value>
        [DataMember(Name="metric", EmitDefaultValue=false)]
        public long? Metric { get; set; }

        /// <summary>
        /// The subscription that the usage report is recorded for.
        /// </summary>
        /// <value>The subscription that the usage report is recorded for.</value>
        [DataMember(Name="subscription", EmitDefaultValue=false)]
        public long? Subscription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionMetricUsageReportCreate {\n");
            sb.Append("  ConsumedUnits: ").Append(ConsumedUnits).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Metric: ").Append(Metric).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
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
            return this.Equals(input as SubscriptionMetricUsageReportCreate);
        }

        /// <summary>
        /// Returns true if SubscriptionMetricUsageReportCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionMetricUsageReportCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionMetricUsageReportCreate input)
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
                    this.Metric == input.Metric ||
                    (this.Metric != null &&
                    this.Metric.Equals(input.Metric))
                ) && 
                (
                    this.Subscription == input.Subscription ||
                    (this.Subscription != null &&
                    this.Subscription.Equals(input.Subscription))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Metric != null)
                    hashCode = hashCode * 59 + this.Metric.GetHashCode();
                if (this.Subscription != null)
                    hashCode = hashCode * 59 + this.Subscription.GetHashCode();
                return hashCode;
            }
        }

    }

}
