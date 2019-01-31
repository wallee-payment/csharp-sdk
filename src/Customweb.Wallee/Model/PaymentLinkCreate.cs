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
    public partial class PaymentLinkCreate : AbstractPaymentLinkUpdate,  IEquatable<PaymentLinkCreate>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentLinkCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentLinkCreate() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentLinkCreate" /> class.
        /// </summary>
        /// <param name="State">State</param>
        /// <param name="ExternalId">The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity. (required)</param>
        /// <param name="ProtectionMode">The protection mode determines if the payment link is protected against tampering and in what way.</param>
        public PaymentLinkCreate(string Name = default(string), DateTime? AvailableFrom = default(DateTime?), string Currency = default(string), List<PaymentMethodConfiguration> AllowedPaymentMethodConfigurations = default(List<PaymentMethodConfiguration>), DateTime? AvailableUntil = default(DateTime?), PaymentLinkProtectionMode? ProtectionMode = default(PaymentLinkProtectionMode?), bool? ShippingAddressRequired = default(bool?), int? MaximalNumberOfTransactions = default(int?), CreationEntityState? State = default(CreationEntityState?), List<LineItemCreate> LineItems = default(List<LineItemCreate>), long? AppliedSpaceView = default(long?), string ExternalId = default(string), bool? BillingAddressRequired = default(bool?), string Language = default(string))
        {
            // to ensure "ExternalId" is required (not null)
            if (ExternalId == null)
            {
                throw new ArgumentNullException("ExternalId is a required property for PaymentLinkCreate and cannot be null");
            }
            else
            {
                this.ExternalId = ExternalId;
            }
            this.State = State;
            this.ProtectionMode = ProtectionMode;
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
        /// The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity.
        /// </summary>
        /// <value>The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The protection mode determines if the payment link is protected against tampering and in what way.
        /// </summary>
        /// <value>The protection mode determines if the payment link is protected against tampering and in what way.</value>
        [DataMember(Name="protectionMode", EmitDefaultValue=false)]
        public PaymentLinkProtectionMode? ProtectionMode { get; set; }

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
            return this.Equals(obj as PaymentLinkCreate);
        }

        /// <summary>
        /// Returns true if PaymentLinkCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentLinkCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentLinkCreate other)
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
                    this.ExternalId == other.ExternalId ||
                    this.ExternalId != null &&
                    this.ExternalId.Equals(other.ExternalId)
                ) && 
                (
                    this.ProtectionMode == other.ProtectionMode ||
                    this.ProtectionMode != null &&
                    this.ProtectionMode.Equals(other.ProtectionMode)
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
                if (this.ExternalId != null)
                {
                    hash = hash * 59 + this.ExternalId.GetHashCode();
                }
                if (this.ProtectionMode != null)
                {
                    hash = hash * 59 + this.ProtectionMode.GetHashCode();
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
