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
    /// SubscriptionProductVersionRetirementCreate
    /// </summary>
    [DataContract]
    public partial class SubscriptionProductVersionRetirementCreate :  IEquatable<SubscriptionProductVersionRetirementCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductVersionRetirementCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionProductVersionRetirementCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductVersionRetirementCreate" /> class.
        /// </summary>
        /// <param name="productVersion">The product version that is to be retired. (required).</param>
        public SubscriptionProductVersionRetirementCreate(long? productVersion)
        {
            // to ensure "productVersion" is required (not null)
            if (productVersion == null)
            {
                throw new InvalidDataException("productVersion is a required property for SubscriptionProductVersionRetirementCreate and cannot be null");
            }
            this.ProductVersion = productVersion;
        }

        /// <summary>
        /// The product version that is to be retired.
        /// </summary>
        /// <value>The product version that is to be retired.</value>
        [DataMember(Name="productVersion", EmitDefaultValue=false)]
        public long? ProductVersion { get; set; }

        /// <summary>
        /// Whether the subscriptions&#39; termination periods should be respected.
        /// </summary>
        /// <value>Whether the subscriptions&#39; termination periods should be respected.</value>
        [DataMember(Name="respectTerminationPeriods", EmitDefaultValue=false)]
        public bool? RespectTerminationPeriods { get; set; }

        /// <summary>
        /// The product to which the subscriptions with the retiring product version are to be migrated. If none is defined, the subscriptions are terminated.
        /// </summary>
        /// <value>The product to which the subscriptions with the retiring product version are to be migrated. If none is defined, the subscriptions are terminated.</value>
        [DataMember(Name="targetProduct", EmitDefaultValue=false)]
        public long? TargetProduct { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionProductVersionRetirementCreate {\n");
            sb.Append("  ProductVersion: ").Append(ProductVersion).Append("\n");
            sb.Append("  RespectTerminationPeriods: ").Append(RespectTerminationPeriods).Append("\n");
            sb.Append("  TargetProduct: ").Append(TargetProduct).Append("\n");
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
            return this.Equals(input as SubscriptionProductVersionRetirementCreate);
        }

        /// <summary>
        /// Returns true if SubscriptionProductVersionRetirementCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionProductVersionRetirementCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionProductVersionRetirementCreate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProductVersion == input.ProductVersion ||
                    (this.ProductVersion != null &&
                    this.ProductVersion.Equals(input.ProductVersion))
                ) && 
                (
                    this.RespectTerminationPeriods == input.RespectTerminationPeriods ||
                    (this.RespectTerminationPeriods != null &&
                    this.RespectTerminationPeriods.Equals(input.RespectTerminationPeriods))
                ) && 
                (
                    this.TargetProduct == input.TargetProduct ||
                    (this.TargetProduct != null &&
                    this.TargetProduct.Equals(input.TargetProduct))
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
                if (this.ProductVersion != null)
                    hashCode = hashCode * 59 + this.ProductVersion.GetHashCode();
                if (this.RespectTerminationPeriods != null)
                    hashCode = hashCode * 59 + this.RespectTerminationPeriods.GetHashCode();
                if (this.TargetProduct != null)
                    hashCode = hashCode * 59 + this.TargetProduct.GetHashCode();
                return hashCode;
            }
        }

    }

}
