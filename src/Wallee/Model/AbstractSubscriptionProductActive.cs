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
    /// AbstractSubscriptionProductActive
    /// </summary>
    [DataContract]
    public partial class AbstractSubscriptionProductActive :  IEquatable<AbstractSubscriptionProductActive>
    {
        /// <summary>
        /// The object&#39;s current state.
        /// </summary>
        /// <value>The object&#39;s current state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public SubscriptionProductState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractSubscriptionProductActive" /> class.
        /// </summary>
        public AbstractSubscriptionProductActive()
        {
        }

        /// <summary>
        /// The payment methods that can be used to subscribe to this product. If none are selected, no restriction is applied.
        /// </summary>
        /// <value>The payment methods that can be used to subscribe to this product. If none are selected, no restriction is applied.</value>
        [DataMember(Name="allowedPaymentMethodConfigurations", EmitDefaultValue=false)]
        public List<long?> AllowedPaymentMethodConfigurations { get; set; }

        /// <summary>
        /// The period after which a subscription that has been suspended due to a failed payment is terminated.
        /// </summary>
        /// <value>The period after which a subscription that has been suspended due to a failed payment is terminated.</value>
        [DataMember(Name="failedPaymentSuspensionPeriod", EmitDefaultValue=false)]
        public string FailedPaymentSuspensionPeriod { get; set; }

        /// <summary>
        /// The name used to identify the product.
        /// </summary>
        /// <value>The name used to identify the product.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Whether subscriptions can be switched to or from this product, or whether they are locked in.
        /// </summary>
        /// <value>Whether subscriptions can be switched to or from this product, or whether they are locked in.</value>
        [DataMember(Name="productLocked", EmitDefaultValue=false)]
        public bool? ProductLocked { get; set; }

        /// <summary>
        /// When listing products, they can be sorted by this number.
        /// </summary>
        /// <value>When listing products, they can be sorted by this number.</value>
        [DataMember(Name="sortOrder", EmitDefaultValue=false)]
        public int? SortOrder { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AbstractSubscriptionProductActive {\n");
            sb.Append("  AllowedPaymentMethodConfigurations: ").Append(AllowedPaymentMethodConfigurations).Append("\n");
            sb.Append("  FailedPaymentSuspensionPeriod: ").Append(FailedPaymentSuspensionPeriod).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ProductLocked: ").Append(ProductLocked).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as AbstractSubscriptionProductActive);
        }

        /// <summary>
        /// Returns true if AbstractSubscriptionProductActive instances are equal
        /// </summary>
        /// <param name="input">Instance of AbstractSubscriptionProductActive to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbstractSubscriptionProductActive input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowedPaymentMethodConfigurations == input.AllowedPaymentMethodConfigurations ||
                    this.AllowedPaymentMethodConfigurations != null &&
                    input.AllowedPaymentMethodConfigurations != null &&
                    this.AllowedPaymentMethodConfigurations.SequenceEqual(input.AllowedPaymentMethodConfigurations)
                ) && 
                (
                    this.FailedPaymentSuspensionPeriod == input.FailedPaymentSuspensionPeriod ||
                    (this.FailedPaymentSuspensionPeriod != null &&
                    this.FailedPaymentSuspensionPeriod.Equals(input.FailedPaymentSuspensionPeriod))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ProductLocked == input.ProductLocked ||
                    (this.ProductLocked != null &&
                    this.ProductLocked.Equals(input.ProductLocked))
                ) && 
                (
                    this.SortOrder == input.SortOrder ||
                    (this.SortOrder != null &&
                    this.SortOrder.Equals(input.SortOrder))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                return hashCode;
            }
        }

    }

}
