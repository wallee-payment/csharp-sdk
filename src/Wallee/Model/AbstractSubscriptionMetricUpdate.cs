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
    /// AbstractSubscriptionMetricUpdate
    /// </summary>
    [DataContract]
    public partial class AbstractSubscriptionMetricUpdate :  IEquatable<AbstractSubscriptionMetricUpdate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractSubscriptionMetricUpdate" /> class.
        /// </summary>
        public AbstractSubscriptionMetricUpdate()
        {
        }

        /// <summary>
        /// The localized description of the metric that is displayed to the customer.
        /// </summary>
        /// <value>The localized description of the metric that is displayed to the customer.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public Dictionary<string, string> Description { get; set; }

        /// <summary>
        /// The localized name of the metric that is displayed to the customer.
        /// </summary>
        /// <value>The localized name of the metric that is displayed to the customer.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public Dictionary<string, string> Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AbstractSubscriptionMetricUpdate {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as AbstractSubscriptionMetricUpdate);
        }

        /// <summary>
        /// Returns true if AbstractSubscriptionMetricUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of AbstractSubscriptionMetricUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbstractSubscriptionMetricUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    this.Description != null &&
                    input.Description != null &&
                    this.Description.SequenceEqual(input.Description)
                ) && 
                (
                    this.Name == input.Name ||
                    this.Name != null &&
                    input.Name != null &&
                    this.Name.SequenceEqual(input.Name)
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }

    }

}
