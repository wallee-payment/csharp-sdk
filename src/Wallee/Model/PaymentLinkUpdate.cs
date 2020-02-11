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
    public partial class PaymentLinkUpdate :  IEquatable<PaymentLinkUpdate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentLinkUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentLinkUpdate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentLinkUpdate" /> class.
        /// </summary>
        /// <param name="id">The ID is the primary key of the entity. The ID identifies the entity uniquely. (required).</param>
        /// <param name="version">The version number indicates the version of the entity. The version is incremented whenever the entity is changed. (required).</param>
        public PaymentLinkUpdate(long? id, long? version)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for PaymentLinkUpdate and cannot be null");
            }
            this.Id = id;
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for PaymentLinkUpdate and cannot be null");
            }
            this.Version = version;
        }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public long? Version { get; set; }

        /// <summary>
        /// The allowed payment method configurations restrict the payment methods which can be used with this payment link.
        /// </summary>
        /// <value>The allowed payment method configurations restrict the payment methods which can be used with this payment link.</value>
        [DataMember(Name="allowedPaymentMethodConfigurations", EmitDefaultValue=true)]
        public List<PaymentMethodConfiguration> AllowedPaymentMethodConfigurations { get; set; }

        /// <summary>
        /// The payment link can be conducted in a specific space view. The space view may apply a specific design to the payment page.
        /// </summary>
        /// <value>The payment link can be conducted in a specific space view. The space view may apply a specific design to the payment page.</value>
        [DataMember(Name="appliedSpaceView", EmitDefaultValue=true)]
        public long? AppliedSpaceView { get; set; }

        /// <summary>
        /// The available from date defines the earliest date on which the payment link can be used. When no date is specified there will be no restriction.
        /// </summary>
        /// <value>The available from date defines the earliest date on which the payment link can be used. When no date is specified there will be no restriction.</value>
        [DataMember(Name="availableFrom", EmitDefaultValue=true)]
        public DateTime? AvailableFrom { get; set; }

        /// <summary>
        /// The available from date defines the latest date on which the payment link can be used to initialize a transaction. When no date is specified there will be no restriction.
        /// </summary>
        /// <value>The available from date defines the latest date on which the payment link can be used to initialize a transaction. When no date is specified there will be no restriction.</value>
        [DataMember(Name="availableUntil", EmitDefaultValue=true)]
        public DateTime? AvailableUntil { get; set; }

        /// <summary>
        /// By making the billing address required the transaction can only be created when a billing address is provided within the request.
        /// </summary>
        /// <value>By making the billing address required the transaction can only be created when a billing address is provided within the request.</value>
        [DataMember(Name="billingAddressRequired", EmitDefaultValue=true)]
        public bool? BillingAddressRequired { get; set; }

        /// <summary>
        /// The currency defines in which currency the payment is executed in. If no currency is defined it has to be specified within the request parameter &#39;currency&#39;.
        /// </summary>
        /// <value>The currency defines in which currency the payment is executed in. If no currency is defined it has to be specified within the request parameter &#39;currency&#39;.</value>
        [DataMember(Name="currency", EmitDefaultValue=true)]
        public string Currency { get; set; }

        /// <summary>
        /// The language defines the language of the payment page. If no language is provided it can be provided through the request parameter.
        /// </summary>
        /// <value>The language defines the language of the payment page. If no language is provided it can be provided through the request parameter.</value>
        [DataMember(Name="language", EmitDefaultValue=true)]
        public string Language { get; set; }

        /// <summary>
        /// The line items allows to define the line items for this payment link. When the line items are defined they cannot be overridden through the request parameters.
        /// </summary>
        /// <value>The line items allows to define the line items for this payment link. When the line items are defined they cannot be overridden through the request parameters.</value>
        [DataMember(Name="lineItems", EmitDefaultValue=true)]
        public List<LineItemCreate> LineItems { get; set; }

        /// <summary>
        /// The maximal number of transactions limits the number of transactions which can be created with this payment link.
        /// </summary>
        /// <value>The maximal number of transactions limits the number of transactions which can be created with this payment link.</value>
        [DataMember(Name="maximalNumberOfTransactions", EmitDefaultValue=true)]
        public int? MaximalNumberOfTransactions { get; set; }

        /// <summary>
        /// The payment link name is used internally to identify the payment link. For example the name is used within search fields and hence it should be distinct and descriptive.
        /// </summary>
        /// <value>The payment link name is used internally to identify the payment link. For example the name is used within search fields and hence it should be distinct and descriptive.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// By making the shipping address required the transaction can only be created when a shipping address is provided within the request.
        /// </summary>
        /// <value>By making the shipping address required the transaction can only be created when a shipping address is provided within the request.</value>
        [DataMember(Name="shippingAddressRequired", EmitDefaultValue=true)]
        public bool? ShippingAddressRequired { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentLinkUpdate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  AllowedPaymentMethodConfigurations: ").Append(AllowedPaymentMethodConfigurations).Append("\n");
            sb.Append("  AppliedSpaceView: ").Append(AppliedSpaceView).Append("\n");
            sb.Append("  AvailableFrom: ").Append(AvailableFrom).Append("\n");
            sb.Append("  AvailableUntil: ").Append(AvailableUntil).Append("\n");
            sb.Append("  BillingAddressRequired: ").Append(BillingAddressRequired).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  MaximalNumberOfTransactions: ").Append(MaximalNumberOfTransactions).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ShippingAddressRequired: ").Append(ShippingAddressRequired).Append("\n");
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
            return this.Equals(input as PaymentLinkUpdate);
        }

        /// <summary>
        /// Returns true if PaymentLinkUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentLinkUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentLinkUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.AllowedPaymentMethodConfigurations == input.AllowedPaymentMethodConfigurations ||
                    this.AllowedPaymentMethodConfigurations != null &&
                    this.AllowedPaymentMethodConfigurations.SequenceEqual(input.AllowedPaymentMethodConfigurations)
                ) && 
                (
                    this.AppliedSpaceView == input.AppliedSpaceView ||
                    (this.AppliedSpaceView != null &&
                    this.AppliedSpaceView.Equals(input.AppliedSpaceView))
                ) && 
                (
                    this.AvailableFrom == input.AvailableFrom ||
                    (this.AvailableFrom != null &&
                    this.AvailableFrom.Equals(input.AvailableFrom))
                ) && 
                (
                    this.AvailableUntil == input.AvailableUntil ||
                    (this.AvailableUntil != null &&
                    this.AvailableUntil.Equals(input.AvailableUntil))
                ) && 
                (
                    this.BillingAddressRequired == input.BillingAddressRequired ||
                    (this.BillingAddressRequired != null &&
                    this.BillingAddressRequired.Equals(input.BillingAddressRequired))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) && 
                (
                    this.MaximalNumberOfTransactions == input.MaximalNumberOfTransactions ||
                    (this.MaximalNumberOfTransactions != null &&
                    this.MaximalNumberOfTransactions.Equals(input.MaximalNumberOfTransactions))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ShippingAddressRequired == input.ShippingAddressRequired ||
                    (this.ShippingAddressRequired != null &&
                    this.ShippingAddressRequired.Equals(input.ShippingAddressRequired))
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
                if (this.BillingAddressRequired != null)
                    hashCode = hashCode * 59 + this.BillingAddressRequired.GetHashCode();
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
                if (this.ShippingAddressRequired != null)
                    hashCode = hashCode * 59 + this.ShippingAddressRequired.GetHashCode();
                return hashCode;
            }
        }

    }

}
