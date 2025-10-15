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
    /// PaymentLinkUpdate
    /// </summary>
    [DataContract]
    public partial class PaymentLinkUpdate :  IEquatable<PaymentLinkUpdate>
    {
        /// <summary>
        /// The handling mode defines whether a billing address is required and specifies how it should be provided.
        /// </summary>
        /// <value>The handling mode defines whether a billing address is required and specifies how it should be provided.</value>
        [DataMember(Name="billingAddressHandlingMode", EmitDefaultValue=false)]
        public PaymentLinkAddressHandlingMode? BillingAddressHandlingMode { get; set; }
        /// <summary>
        /// The handling mode defines whether a shipping address is required and specifies how it should be provided.
        /// </summary>
        /// <value>The handling mode defines whether a shipping address is required and specifies how it should be provided.</value>
        [DataMember(Name="shippingAddressHandlingMode", EmitDefaultValue=false)]
        public PaymentLinkAddressHandlingMode? ShippingAddressHandlingMode { get; set; }
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
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public long? Version { get; set; }

        /// <summary>
        /// The payment method configurations that customers can use for making payments.
        /// </summary>
        /// <value>The payment method configurations that customers can use for making payments.</value>
        [DataMember(Name="allowedPaymentMethodConfigurations", EmitDefaultValue=false)]
        public List<PaymentMethodConfiguration> AllowedPaymentMethodConfigurations { get; set; }

        /// <summary>
        /// The domains to which the user is allowed to be redirected after the payment is completed. The following options can be configured: Exact domain: enter a full domain, e.g. (https://example.com). Wildcard domain: use to allow subdomains, e.g. (https://_*.example.com). All domains: use (ALL) to allow redirection to any domain (not recommended for security reasons). No domains : use (NONE) to disallow any redirection. Only one option per line is allowed. Invalid entries will be rejected. 
        /// </summary>
        /// <value>The domains to which the user is allowed to be redirected after the payment is completed. The following options can be configured: Exact domain: enter a full domain, e.g. (https://example.com). Wildcard domain: use to allow subdomains, e.g. (https://_*.example.com). All domains: use (ALL) to allow redirection to any domain (not recommended for security reasons). No domains : use (NONE) to disallow any redirection. Only one option per line is allowed. Invalid entries will be rejected. </value>
        [DataMember(Name="allowedRedirectionDomains", EmitDefaultValue=false)]
        public List<string> AllowedRedirectionDomains { get; set; }

        /// <summary>
        /// The payment link can be used within a specific space view, which may apply a customized design to the payment page.
        /// </summary>
        /// <value>The payment link can be used within a specific space view, which may apply a customized design to the payment page.</value>
        [DataMember(Name="appliedSpaceView", EmitDefaultValue=false)]
        public long? AppliedSpaceView { get; set; }

        /// <summary>
        /// The earliest date the payment link can be used to initiate a transaction. If no date is provided, the link will be available immediately.
        /// </summary>
        /// <value>The earliest date the payment link can be used to initiate a transaction. If no date is provided, the link will be available immediately.</value>
        [DataMember(Name="availableFrom", EmitDefaultValue=false)]
        public DateTime? AvailableFrom { get; set; }

        /// <summary>
        /// The latest date the payment link can be used to initiate a transaction. If no date is provided, the link will remain available indefinitely.
        /// </summary>
        /// <value>The latest date the payment link can be used to initiate a transaction. If no date is provided, the link will remain available indefinitely.</value>
        [DataMember(Name="availableUntil", EmitDefaultValue=false)]
        public DateTime? AvailableUntil { get; set; }


        /// <summary>
        /// The three-letter currency code (ISO 4217). If not specified, it must be provided in the &#39;currency&#39; request parameter.
        /// </summary>
        /// <value>The three-letter currency code (ISO 4217). If not specified, it must be provided in the &#39;currency&#39; request parameter.</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// The language for displaying the payment page. If not specified, it can be supplied via the &#39;language&#39; request parameter.
        /// </summary>
        /// <value>The language for displaying the payment page. If not specified, it can be supplied via the &#39;language&#39; request parameter.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// The line items representing what is being sold. If not specified, they can be supplied via request parameters.
        /// </summary>
        /// <value>The line items representing what is being sold. If not specified, they can be supplied via request parameters.</value>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<LineItemCreate> LineItems { get; set; }

        /// <summary>
        /// The maximum number of transactions that can be initiated using the payment link.
        /// </summary>
        /// <value>The maximum number of transactions that can be initiated using the payment link.</value>
        [DataMember(Name="maximalNumberOfTransactions", EmitDefaultValue=false)]
        public int? MaximalNumberOfTransactions { get; set; }

        /// <summary>
        /// The name used to identify the payment link.
        /// </summary>
        /// <value>The name used to identify the payment link.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


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
            sb.Append("  AllowedRedirectionDomains: ").Append(AllowedRedirectionDomains).Append("\n");
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
                    input.AllowedPaymentMethodConfigurations != null &&
                    this.AllowedPaymentMethodConfigurations.SequenceEqual(input.AllowedPaymentMethodConfigurations)
                ) && 
                (
                    this.AllowedRedirectionDomains == input.AllowedRedirectionDomains ||
                    this.AllowedRedirectionDomains != null &&
                    input.AllowedRedirectionDomains != null &&
                    this.AllowedRedirectionDomains.SequenceEqual(input.AllowedRedirectionDomains)
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
                    this.BillingAddressHandlingMode == input.BillingAddressHandlingMode ||
                    (this.BillingAddressHandlingMode != null &&
                    this.BillingAddressHandlingMode.Equals(input.BillingAddressHandlingMode))
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
                    input.LineItems != null &&
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
                    this.ShippingAddressHandlingMode == input.ShippingAddressHandlingMode ||
                    (this.ShippingAddressHandlingMode != null &&
                    this.ShippingAddressHandlingMode.Equals(input.ShippingAddressHandlingMode))
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
                if (this.AllowedRedirectionDomains != null)
                    hashCode = hashCode * 59 + this.AllowedRedirectionDomains.GetHashCode();
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
                return hashCode;
            }
        }

    }

}
