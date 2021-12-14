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
    /// A subscription product represents a product to which a subscriber can subscribe to. A product defines how much the subscription costs and in what cycles the subscribe is charged.
    /// </summary>
    [DataContract]
    public partial class SubscriptionProductCreate : AbstractSubscriptionProductActive,  IEquatable<SubscriptionProductCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionProductCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductCreate" /> class.
        /// </summary>
        /// <param name="reference">The product reference identifies the product for external systems. This field may contain the product&#39;s SKU. (required).</param>
        public SubscriptionProductCreate(string reference)
        {
            // to ensure "reference" is required (not null)
            if (reference == null)
            {
                throw new InvalidDataException("reference is a required property for SubscriptionProductCreate and cannot be null");
            }
            this.Reference = reference;
        }







        /// <summary>
        /// The product reference identifies the product for external systems. This field may contain the product&#39;s SKU.
        /// </summary>
        /// <value>The product reference identifies the product for external systems. This field may contain the product&#39;s SKU.</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionProductCreate {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AllowedPaymentMethodConfigurations: ").Append(AllowedPaymentMethodConfigurations).Append("\n");
            sb.Append("  FailedPaymentSuspensionPeriod: ").Append(FailedPaymentSuspensionPeriod).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ProductLocked: ").Append(ProductLocked).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as SubscriptionProductCreate);
        }

        /// <summary>
        /// Returns true if SubscriptionProductCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionProductCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionProductCreate input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.AllowedPaymentMethodConfigurations == input.AllowedPaymentMethodConfigurations ||
                    this.AllowedPaymentMethodConfigurations != null &&
                    input.AllowedPaymentMethodConfigurations != null &&
                    this.AllowedPaymentMethodConfigurations.SequenceEqual(input.AllowedPaymentMethodConfigurations)
                ) && base.Equals(input) && 
                (
                    this.FailedPaymentSuspensionPeriod == input.FailedPaymentSuspensionPeriod ||
                    (this.FailedPaymentSuspensionPeriod != null &&
                    this.FailedPaymentSuspensionPeriod.Equals(input.FailedPaymentSuspensionPeriod))
                ) && base.Equals(input) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && base.Equals(input) && 
                (
                    this.ProductLocked == input.ProductLocked ||
                    (this.ProductLocked != null &&
                    this.ProductLocked.Equals(input.ProductLocked))
                ) && base.Equals(input) && 
                (
                    this.SortOrder == input.SortOrder ||
                    (this.SortOrder != null &&
                    this.SortOrder.Equals(input.SortOrder))
                ) && base.Equals(input) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && base.Equals(input) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
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
                int hashCode = base.GetHashCode();
                if (this.AllowedPaymentMethodConfigurations != null)
                    hashCode = hashCode * 59 + this.AllowedPaymentMethodConfigurations.GetHashCode();
                if (this.FailedPaymentSuspensionPeriod != null)
                    hashCode = hashCode * 59 + this.FailedPaymentSuspensionPeriod.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProductLocked != null)
                    hashCode = hashCode * 59 + this.ProductLocked.GetHashCode();
                if (this.SortOrder != null)
                    hashCode = hashCode * 59 + this.SortOrder.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                return hashCode;
            }
        }

    }

}
