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
    /// The metric usage provides details about the consumption of a particular metric.
    /// </summary>
    [DataContract]
    public partial class MetricUsage :  IEquatable<MetricUsage>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricUsage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public MetricUsage()
        {
        }

        /// <summary>
        /// The consumed units provide the value of how much has been consumed of the particular metric.
        /// </summary>
        /// <value>The consumed units provide the value of how much has been consumed of the particular metric.</value>
        [DataMember(Name="consumedUnits", EmitDefaultValue=false)]
        public decimal? ConsumedUnits { get; private set; }

        /// <summary>
        /// The metric description describes the metric.
        /// </summary>
        /// <value>The metric description describes the metric.</value>
        [DataMember(Name="metricDescription", EmitDefaultValue=false)]
        public Dictionary<string, string> MetricDescription { get; private set; }

        /// <summary>
        /// The metric ID identifies the metric for consumed units.
        /// </summary>
        /// <value>The metric ID identifies the metric for consumed units.</value>
        [DataMember(Name="metricId", EmitDefaultValue=false)]
        public long? MetricId { get; private set; }

        /// <summary>
        /// The metric name defines the name of the consumed units.
        /// </summary>
        /// <value>The metric name defines the name of the consumed units.</value>
        [DataMember(Name="metricName", EmitDefaultValue=false)]
        public Dictionary<string, string> MetricName { get; private set; }

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
            return this.Equals(obj as MetricUsage);
        }

        /// <summary>
        /// Returns true if MetricUsage instances are equal
        /// </summary>
        /// <param name="other">Instance of MetricUsage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetricUsage other)
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
                    this.MetricDescription == other.MetricDescription ||
                    this.MetricDescription != null &&
                    this.MetricDescription.SequenceEqual(other.MetricDescription)
                ) && 
                (
                    this.MetricId == other.MetricId ||
                    this.MetricId != null &&
                    this.MetricId.Equals(other.MetricId)
                ) && 
                (
                    this.MetricName == other.MetricName ||
                    this.MetricName != null &&
                    this.MetricName.SequenceEqual(other.MetricName)
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
                if (this.MetricDescription != null)
                {
                    hash = hash * 59 + this.MetricDescription.GetHashCode();
                }
                if (this.MetricId != null)
                {
                    hash = hash * 59 + this.MetricId.GetHashCode();
                }
                if (this.MetricName != null)
                {
                    hash = hash * 59 + this.MetricName.GetHashCode();
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
