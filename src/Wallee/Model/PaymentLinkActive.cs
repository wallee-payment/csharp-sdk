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
    public partial class PaymentLinkActive : PaymentLinkUpdate,  IEquatable<PaymentLinkActive>
    {
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public CreationEntityState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentLinkActive" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentLinkActive() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentLinkActive" /> class.
        /// </summary>
        /// <param name="id">The ID is the primary key of the entity. The ID identifies the entity uniquely. (required).</param>
        /// <param name="version">The version number indicates the version of the entity. The version is incremented whenever the entity is changed. (required).</param>
        public PaymentLinkActive(long? id, long? version)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for PaymentLinkActive and cannot be null");
            }
            this.Id = id;
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for PaymentLinkActive and cannot be null");
            }
            this.Version = version;
        }















        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentLinkActive {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as PaymentLinkActive);
        }

        /// <summary>
        /// Returns true if PaymentLinkActive instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentLinkActive to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentLinkActive input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && base.Equals(input) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && base.Equals(input) && 
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
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
                return hashCode;
            }
        }

    }

}
