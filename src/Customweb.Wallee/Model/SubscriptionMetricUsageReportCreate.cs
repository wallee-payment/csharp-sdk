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

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// The metric usage is the actual usage of a metric for a particular subscription as collected by an external application.
    /// </summary>
    [DataContract]
    public partial class SubscriptionMetricUsageReportCreate :  IEquatable<SubscriptionMetricUsageReportCreate>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionMetricUsageReportCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionMetricUsageReportCreate() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionMetricUsageReportCreate" /> class.
        /// </summary>
        /// <param name="ConsumedUnits">The consumed units describe the amount of resources consumed. Those consumed units will be billed in the next billing cycle. (required)</param>
        /// <param name="Description">The metric usage report description describe the reported usage. This description may be shown to the end user.</param>
        /// <param name="ExternalId">The external id identifies the metric usage uniquely. (required)</param>
        /// <param name="Metric">The metric usage report is linked to the metric for which the usage should be recorded. (required)</param>
        /// <param name="Subscription">The subscription to which the usage is added to. (required)</param>
        public SubscriptionMetricUsageReportCreate(string ExternalId = default(string), long? Subscription = default(long?), long? Metric = default(long?), decimal? ConsumedUnits = default(decimal?), string Description = default(string))
        {
            // to ensure "ConsumedUnits" is required (not null)
            if (ConsumedUnits == null)
            {
                throw new ArgumentNullException("ConsumedUnits is a required property for SubscriptionMetricUsageReportCreate and cannot be null");
            }
            else
            {
                this.ConsumedUnits = ConsumedUnits;
            }
            // to ensure "ExternalId" is required (not null)
            if (ExternalId == null)
            {
                throw new ArgumentNullException("ExternalId is a required property for SubscriptionMetricUsageReportCreate and cannot be null");
            }
            else
            {
                this.ExternalId = ExternalId;
            }
            // to ensure "Metric" is required (not null)
            if (Metric == null)
            {
                throw new ArgumentNullException("Metric is a required property for SubscriptionMetricUsageReportCreate and cannot be null");
            }
            else
            {
                this.Metric = Metric;
            }
            // to ensure "Subscription" is required (not null)
            if (Subscription == null)
            {
                throw new ArgumentNullException("Subscription is a required property for SubscriptionMetricUsageReportCreate and cannot be null");
            }
            else
            {
                this.Subscription = Subscription;
            }
            this.Description = Description;
        }

        /// <summary>
        /// The consumed units describe the amount of resources consumed. Those consumed units will be billed in the next billing cycle.
        /// </summary>
        /// <value>The consumed units describe the amount of resources consumed. Those consumed units will be billed in the next billing cycle.</value>
        [DataMember(Name="consumedUnits", EmitDefaultValue=false)]
        public decimal? ConsumedUnits { get; set; }

        /// <summary>
        /// The metric usage report description describe the reported usage. This description may be shown to the end user.
        /// </summary>
        /// <value>The metric usage report description describe the reported usage. This description may be shown to the end user.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The external id identifies the metric usage uniquely.
        /// </summary>
        /// <value>The external id identifies the metric usage uniquely.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The metric usage report is linked to the metric for which the usage should be recorded.
        /// </summary>
        /// <value>The metric usage report is linked to the metric for which the usage should be recorded.</value>
        [DataMember(Name="metric", EmitDefaultValue=false)]
        public long? Metric { get; set; }

        /// <summary>
        /// The subscription to which the usage is added to.
        /// </summary>
        /// <value>The subscription to which the usage is added to.</value>
        [DataMember(Name="subscription", EmitDefaultValue=false)]
        public long? Subscription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return this.ToJson();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            return this.Equals(obj as SubscriptionMetricUsageReportCreate);
        }

        /// <summary>
        /// Returns true if SubscriptionMetricUsageReportCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of SubscriptionMetricUsageReportCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionMetricUsageReportCreate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.ConsumedUnits == other.ConsumedUnits ||
                    this.ConsumedUnits != null &&
                    this.ConsumedUnits.Equals(other.ConsumedUnits)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.ExternalId == other.ExternalId ||
                    this.ExternalId != null &&
                    this.ExternalId.Equals(other.ExternalId)
                ) && 
                (
                    this.Metric == other.Metric ||
                    this.Metric != null &&
                    this.Metric.Equals(other.Metric)
                ) && 
                (
                    this.Subscription == other.Subscription ||
                    this.Subscription != null &&
                    this.Subscription.Equals(other.Subscription)
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
                int hash = 41;
                if (this.ConsumedUnits != null)
                {
                    hash = hash * 59 + this.ConsumedUnits.GetHashCode();
                }
                if (this.Description != null)
                {
                    hash = hash * 59 + this.Description.GetHashCode();
                }
                if (this.ExternalId != null)
                {
                    hash = hash * 59 + this.ExternalId.GetHashCode();
                }
                if (this.Metric != null)
                {
                    hash = hash * 59 + this.Metric.GetHashCode();
                }
                if (this.Subscription != null)
                {
                    hash = hash * 59 + this.Subscription.GetHashCode();
                }
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
