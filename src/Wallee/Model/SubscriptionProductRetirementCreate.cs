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
        /// <param name="product">product (required).</param>
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
        /// Gets or Sets Product
        /// </summary>
        [DataMember(Name="product", EmitDefaultValue=false)]
        public long? Product { get; set; }

        /// <summary>
        /// Gets or Sets RespectTerminiationPeriodsEnabled
        /// </summary>
        [DataMember(Name="respectTerminiationPeriodsEnabled", EmitDefaultValue=false)]
        public bool? RespectTerminiationPeriodsEnabled { get; set; }

        /// <summary>
        /// Gets or Sets TargetProduct
        /// </summary>
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
            sb.Append("  RespectTerminiationPeriodsEnabled: ").Append(RespectTerminiationPeriodsEnabled).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
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
                    this.RespectTerminiationPeriodsEnabled == input.RespectTerminiationPeriodsEnabled ||
                    (this.RespectTerminiationPeriodsEnabled != null &&
                    this.RespectTerminiationPeriodsEnabled.Equals(input.RespectTerminiationPeriodsEnabled))
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
                if (this.RespectTerminiationPeriodsEnabled != null)
                    hashCode = hashCode * 59 + this.RespectTerminiationPeriodsEnabled.GetHashCode();
                if (this.TargetProduct != null)
                    hashCode = hashCode * 59 + this.TargetProduct.GetHashCode();
                return hashCode;
            }
        }

    }

}
