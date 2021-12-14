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
    /// The payment link defines an URL to automatically create transactions.
    /// </summary>
    [DataContract]
    public partial class PaymentLinkCreate : AbstractPaymentLinkUpdate,  IEquatable<PaymentLinkCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentLinkCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentLinkCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentLinkCreate" /> class.
        /// </summary>
        /// <param name="externalId">A client generated nonce which identifies the entity to be created. Subsequent creation requests with the same external ID will not create new entities but return the initially created entity instead. (required).</param>
        public PaymentLinkCreate(string externalId)
        {
            // to ensure "externalId" is required (not null)
            if (externalId == null)
            {
                throw new InvalidDataException("externalId is a required property for PaymentLinkCreate and cannot be null");
            }
            this.ExternalId = externalId;
        }












        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public CreationEntityState State { get; set; }

        /// <summary>
        /// A client generated nonce which identifies the entity to be created. Subsequent creation requests with the same external ID will not create new entities but return the initially created entity instead.
        /// </summary>
        /// <value>A client generated nonce which identifies the entity to be created. Subsequent creation requests with the same external ID will not create new entities but return the initially created entity instead.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The protection mode determines if the payment link is protected against tampering and in what way.
        /// </summary>
        /// <value>The protection mode determines if the payment link is protected against tampering and in what way.</value>
        [DataMember(Name="protectionMode", EmitDefaultValue=false)]
        public PaymentLinkProtectionMode ProtectionMode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentLinkCreate {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AllowedPaymentMethodConfigurations: ").Append(AllowedPaymentMethodConfigurations).Append("\n");
            sb.Append("  AppliedSpaceView: ").Append(AppliedSpaceView).Append("\n");
            sb.Append("  AvailableFrom: ").Append(AvailableFrom).Append("\n");
            sb.Append("  AvailableUntil: ").Append(AvailableUntil).Append("\n");
            sb.Append("  BillingAddressHandlingMode: ").Append(BillingAddressHandlingMode).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  MaximalNumberOfTransactions: ").Append(MaximalNumberOfTransactions).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ShippingAddressHandlingMode: ").Append(ShippingAddressHandlingMode).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  ProtectionMode: ").Append(ProtectionMode).Append("\n");
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
            return this.Equals(input as PaymentLinkCreate);
        }

        /// <summary>
        /// Returns true if PaymentLinkCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentLinkCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentLinkCreate input)
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
                    this.AppliedSpaceView == input.AppliedSpaceView ||
                    (this.AppliedSpaceView != null &&
                    this.AppliedSpaceView.Equals(input.AppliedSpaceView))
                ) && base.Equals(input) && 
                (
                    this.AvailableFrom == input.AvailableFrom ||
                    (this.AvailableFrom != null &&
                    this.AvailableFrom.Equals(input.AvailableFrom))
                ) && base.Equals(input) && 
                (
                    this.AvailableUntil == input.AvailableUntil ||
                    (this.AvailableUntil != null &&
                    this.AvailableUntil.Equals(input.AvailableUntil))
                ) && base.Equals(input) && 
                (
                    this.BillingAddressHandlingMode == input.BillingAddressHandlingMode ||
                    (this.BillingAddressHandlingMode != null &&
                    this.BillingAddressHandlingMode.Equals(input.BillingAddressHandlingMode))
                ) && base.Equals(input) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && base.Equals(input) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && base.Equals(input) && 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    input.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) && base.Equals(input) && 
                (
                    this.MaximalNumberOfTransactions == input.MaximalNumberOfTransactions ||
                    (this.MaximalNumberOfTransactions != null &&
                    this.MaximalNumberOfTransactions.Equals(input.MaximalNumberOfTransactions))
                ) && base.Equals(input) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && base.Equals(input) && 
                (
                    this.ShippingAddressHandlingMode == input.ShippingAddressHandlingMode ||
                    (this.ShippingAddressHandlingMode != null &&
                    this.ShippingAddressHandlingMode.Equals(input.ShippingAddressHandlingMode))
                ) && base.Equals(input) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && base.Equals(input) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && base.Equals(input) && 
                (
                    this.ProtectionMode == input.ProtectionMode ||
                    (this.ProtectionMode != null &&
                    this.ProtectionMode.Equals(input.ProtectionMode))
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
                if (this.AppliedSpaceView != null)
                    hashCode = hashCode * 59 + this.AppliedSpaceView.GetHashCode();
                if (this.AvailableFrom != null)
                    hashCode = hashCode * 59 + this.AvailableFrom.GetHashCode();
                if (this.AvailableUntil != null)
                    hashCode = hashCode * 59 + this.AvailableUntil.GetHashCode();
                if (this.BillingAddressHandlingMode != null)
                    hashCode = hashCode * 59 + this.BillingAddressHandlingMode.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.LineItems != null)
                    hashCode = hashCode * 59 + this.LineItems.GetHashCode();
                if (this.MaximalNumberOfTransactions != null)
                    hashCode = hashCode * 59 + this.MaximalNumberOfTransactions.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ShippingAddressHandlingMode != null)
                    hashCode = hashCode * 59 + this.ShippingAddressHandlingMode.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.ProtectionMode != null)
                    hashCode = hashCode * 59 + this.ProtectionMode.GetHashCode();
                return hashCode;
            }
        }

    }

}
