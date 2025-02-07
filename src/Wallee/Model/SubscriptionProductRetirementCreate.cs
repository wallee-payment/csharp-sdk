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
    /// SubscriptionProductRetirementCreate
    /// </summary>
    [DataContract]
    public partial class SubscriptionProductRetirementCreate :  IEquatable<SubscriptionProductRetirementCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductRetirementCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionProductRetirementCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductRetirementCreate" /> class.
        /// </summary>
        /// <param name="product">The product that is to be retired. (required).</param>
        public SubscriptionProductRetirementCreate(long? product)
        {
            // to ensure "product" is required (not null)
            if (product == null)
            {
                throw new InvalidDataException("product is a required property for SubscriptionProductRetirementCreate and cannot be null");
            }
            this.Product = product;
        }

        /// <summary>
        /// The product that is to be retired.
        /// </summary>
        /// <value>The product that is to be retired.</value>
        [DataMember(Name="product", EmitDefaultValue=false)]
        public long? Product { get; set; }

        /// <summary>
        /// Whether the subscriptions&#39; termination periods should be respected.
        /// </summary>
        /// <value>Whether the subscriptions&#39; termination periods should be respected.</value>
        [DataMember(Name="respectTerminationPeriods", EmitDefaultValue=false)]
        public bool? RespectTerminationPeriods { get; set; }

        /// <summary>
        /// The product to which the subscriptions with the retiring product are to be migrated. If none is defined, the subscriptions are terminated.
        /// </summary>
        /// <value>The product to which the subscriptions with the retiring product are to be migrated. If none is defined, the subscriptions are terminated.</value>
        [DataMember(Name="targetProduct", EmitDefaultValue=false)]
        public long? TargetProduct { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionProductRetirementCreate {\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
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
            return this.Equals(input as SubscriptionProductRetirementCreate);
        }

        /// <summary>
        /// Returns true if SubscriptionProductRetirementCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionProductRetirementCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionProductRetirementCreate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Product == input.Product ||
                    (this.Product != null &&
                    this.Product.Equals(input.Product))
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
                if (this.Product != null)
                    hashCode = hashCode * 59 + this.Product.GetHashCode();
                if (this.RespectTerminationPeriods != null)
                    hashCode = hashCode * 59 + this.RespectTerminationPeriods.GetHashCode();
                if (this.TargetProduct != null)
                    hashCode = hashCode * 59 + this.TargetProduct.GetHashCode();
                return hashCode;
            }
        }

    }

}
