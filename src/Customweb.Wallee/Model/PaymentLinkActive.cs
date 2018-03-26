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
    /// The payment link defines an URL to automatically create transactions.
    /// </summary>
    [DataContract]
    public partial class PaymentLinkActive : PaymentLinkUpdate,  IEquatable<PaymentLinkActive>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentLinkActive" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentLinkActive() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentLinkActive" /> class.
        /// </summary>
        /// <param name="State">State</param>
        public PaymentLinkActive(string Name = default(string), long? Id = default(long?), DateTime? AvailableFrom = default(DateTime?), string Currency = default(string), List<PaymentMethodConfiguration> AllowedPaymentMethodConfigurations = default(List<PaymentMethodConfiguration>), DateTime? AvailableUntil = default(DateTime?), bool? ShippingAddressRequired = default(bool?), int? MaximalNumberOfTransactions = default(int?), CreationEntityState? State = default(CreationEntityState?), List<LineItemCreate> LineItems = default(List<LineItemCreate>), long? Version = default(long?), long? AppliedSpaceView = default(long?), bool? BillingAddressRequired = default(bool?), string Language = default(string))
        {
            this.State = State;
            this.Id = Id;
            this.Version = Version;
            this.AllowedPaymentMethodConfigurations = AllowedPaymentMethodConfigurations;
            this.AppliedSpaceView = AppliedSpaceView;
            this.AvailableFrom = AvailableFrom;
            this.AvailableUntil = AvailableUntil;
            this.BillingAddressRequired = BillingAddressRequired;
            this.Currency = Currency;
            this.Language = Language;
            this.LineItems = LineItems;
            this.MaximalNumberOfTransactions = MaximalNumberOfTransactions;
            this.Name = Name;
            this.ShippingAddressRequired = ShippingAddressRequired;
        }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public CreationEntityState? State { get; set; }

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
        public new string ToJson()
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
            return this.Equals(obj as PaymentLinkActive);
        }

        /// <summary>
        /// Returns true if PaymentLinkActive instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentLinkActive to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentLinkActive other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) && 
                (
                    this.AllowedPaymentMethodConfigurations == other.AllowedPaymentMethodConfigurations ||
                    this.AllowedPaymentMethodConfigurations != null &&
                    this.AllowedPaymentMethodConfigurations.SequenceEqual(other.AllowedPaymentMethodConfigurations)
                ) && 
                (
                    this.AppliedSpaceView == other.AppliedSpaceView ||
                    this.AppliedSpaceView != null &&
                    this.AppliedSpaceView.Equals(other.AppliedSpaceView)
                ) && 
                (
                    this.AvailableFrom == other.AvailableFrom ||
                    this.AvailableFrom != null &&
                    this.AvailableFrom.Equals(other.AvailableFrom)
                ) && 
                (
                    this.AvailableUntil == other.AvailableUntil ||
                    this.AvailableUntil != null &&
                    this.AvailableUntil.Equals(other.AvailableUntil)
                ) && 
                (
                    this.BillingAddressRequired == other.BillingAddressRequired ||
                    this.BillingAddressRequired != null &&
                    this.BillingAddressRequired.Equals(other.BillingAddressRequired)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.LineItems == other.LineItems ||
                    this.LineItems != null &&
                    this.LineItems.SequenceEqual(other.LineItems)
                ) && 
                (
                    this.MaximalNumberOfTransactions == other.MaximalNumberOfTransactions ||
                    this.MaximalNumberOfTransactions != null &&
                    this.MaximalNumberOfTransactions.Equals(other.MaximalNumberOfTransactions)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.ShippingAddressRequired == other.ShippingAddressRequired ||
                    this.ShippingAddressRequired != null &&
                    this.ShippingAddressRequired.Equals(other.ShippingAddressRequired)
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
                if (this.State != null)
                {
                    hash = hash * 59 + this.State.GetHashCode();
                }
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.Version != null)
                {
                    hash = hash * 59 + this.Version.GetHashCode();
                }
                if (this.AllowedPaymentMethodConfigurations != null)
                {
                    hash = hash * 59 + this.AllowedPaymentMethodConfigurations.GetHashCode();
                }
                if (this.AppliedSpaceView != null)
                {
                    hash = hash * 59 + this.AppliedSpaceView.GetHashCode();
                }
                if (this.AvailableFrom != null)
                {
                    hash = hash * 59 + this.AvailableFrom.GetHashCode();
                }
                if (this.AvailableUntil != null)
                {
                    hash = hash * 59 + this.AvailableUntil.GetHashCode();
                }
                if (this.BillingAddressRequired != null)
                {
                    hash = hash * 59 + this.BillingAddressRequired.GetHashCode();
                }
                if (this.Currency != null)
                {
                    hash = hash * 59 + this.Currency.GetHashCode();
                }
                if (this.Language != null)
                {
                    hash = hash * 59 + this.Language.GetHashCode();
                }
                if (this.LineItems != null)
                {
                    hash = hash * 59 + this.LineItems.GetHashCode();
                }
                if (this.MaximalNumberOfTransactions != null)
                {
                    hash = hash * 59 + this.MaximalNumberOfTransactions.GetHashCode();
                }
                if (this.Name != null)
                {
                    hash = hash * 59 + this.Name.GetHashCode();
                }
                if (this.ShippingAddressRequired != null)
                {
                    hash = hash * 59 + this.ShippingAddressRequired.GetHashCode();
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
