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
    /// PaymentLink
    /// </summary>
    [DataContract]
    public partial class PaymentLink :  IEquatable<PaymentLink>
    {
        /// <summary>
        /// The handling mode defines whether a billing address is required and specifies how it should be provided.
        /// </summary>
        /// <value>The handling mode defines whether a billing address is required and specifies how it should be provided.</value>
        [DataMember(Name="billingAddressHandlingMode", EmitDefaultValue=false)]
        public PaymentLinkAddressHandlingMode? BillingAddressHandlingMode { get; private set; }
        /// <summary>
        /// The protection mode defines whether the payment link is protected against tampering and specifies the protection method.
        /// </summary>
        /// <value>The protection mode defines whether the payment link is protected against tampering and specifies the protection method.</value>
        [DataMember(Name="protectionMode", EmitDefaultValue=false)]
        public PaymentLinkProtectionMode? ProtectionMode { get; private set; }
        /// <summary>
        /// The handling mode defines whether a shipping address is required and specifies how it should be provided.
        /// </summary>
        /// <value>The handling mode defines whether a shipping address is required and specifies how it should be provided.</value>
        [DataMember(Name="shippingAddressHandlingMode", EmitDefaultValue=false)]
        public PaymentLinkAddressHandlingMode? ShippingAddressHandlingMode { get; private set; }
        /// <summary>
        /// The object&#39;s current state.
        /// </summary>
        /// <value>The object&#39;s current state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public CreationEntityState? State { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentLink" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentLink()
        {
        }

        /// <summary>
        /// The payment method configurations that customers can use for making payments.
        /// </summary>
        /// <value>The payment method configurations that customers can use for making payments.</value>
        [DataMember(Name="allowedPaymentMethodConfigurations", EmitDefaultValue=false)]
        public List<PaymentMethodConfiguration> AllowedPaymentMethodConfigurations { get; private set; }

        /// <summary>
        /// The domains to which the user is allowed to be redirected after the payment is completed. The following options can be configured: Exact domain: enter a full domain, e.g. (https://example.com). Wildcard domain: use to allow subdomains, e.g. (https://_*.example.com). All domains: use (ALL) to allow redirection to any domain (not recommended for security reasons). No domains : use (NONE) to disallow any redirection. Only one option per line is allowed. Invalid entries will be rejected. 
        /// </summary>
        /// <value>The domains to which the user is allowed to be redirected after the payment is completed. The following options can be configured: Exact domain: enter a full domain, e.g. (https://example.com). Wildcard domain: use to allow subdomains, e.g. (https://_*.example.com). All domains: use (ALL) to allow redirection to any domain (not recommended for security reasons). No domains : use (NONE) to disallow any redirection. Only one option per line is allowed. Invalid entries will be rejected. </value>
        [DataMember(Name="allowedRedirectionDomains", EmitDefaultValue=false)]
        public List<string> AllowedRedirectionDomains { get; private set; }

        /// <summary>
        /// The payment link can be used within a specific space view, which may apply a customized design to the payment page.
        /// </summary>
        /// <value>The payment link can be used within a specific space view, which may apply a customized design to the payment page.</value>
        [DataMember(Name="appliedSpaceView", EmitDefaultValue=false)]
        public long? AppliedSpaceView { get; private set; }

        /// <summary>
        /// The earliest date the payment link can be used to initiate a transaction. If no date is provided, the link will be available immediately.
        /// </summary>
        /// <value>The earliest date the payment link can be used to initiate a transaction. If no date is provided, the link will be available immediately.</value>
        [DataMember(Name="availableFrom", EmitDefaultValue=false)]
        public DateTime? AvailableFrom { get; private set; }

        /// <summary>
        /// The latest date the payment link can be used to initiate a transaction. If no date is provided, the link will remain available indefinitely.
        /// </summary>
        /// <value>The latest date the payment link can be used to initiate a transaction. If no date is provided, the link will remain available indefinitely.</value>
        [DataMember(Name="availableUntil", EmitDefaultValue=false)]
        public DateTime? AvailableUntil { get; private set; }


        /// <summary>
        /// The three-letter currency code (ISO 4217). If not specified, it must be provided in the &#39;currency&#39; request parameter.
        /// </summary>
        /// <value>The three-letter currency code (ISO 4217). If not specified, it must be provided in the &#39;currency&#39; request parameter.</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; private set; }

        /// <summary>
        /// A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.
        /// </summary>
        /// <value>A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; private set; }

        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The language for displaying the payment page. If not specified, it can be supplied via the &#39;language&#39; request parameter.
        /// </summary>
        /// <value>The language for displaying the payment page. If not specified, it can be supplied via the &#39;language&#39; request parameter.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; private set; }

        /// <summary>
        /// The line items representing what is being sold. If not specified, they can be supplied via request parameters.
        /// </summary>
        /// <value>The line items representing what is being sold. If not specified, they can be supplied via request parameters.</value>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<LineItem> LineItems { get; private set; }

        /// <summary>
        /// The ID of the space this object belongs to.
        /// </summary>
        /// <value>The ID of the space this object belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// The maximum number of transactions that can be initiated using the payment link.
        /// </summary>
        /// <value>The maximum number of transactions that can be initiated using the payment link.</value>
        [DataMember(Name="maximalNumberOfTransactions", EmitDefaultValue=false)]
        public int? MaximalNumberOfTransactions { get; private set; }

        /// <summary>
        /// The name used to identify the payment link.
        /// </summary>
        /// <value>The name used to identify the payment link.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.
        /// </summary>
        /// <value>The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }




        /// <summary>
        /// The public URL to share with customers for making payments.
        /// </summary>
        /// <value>The public URL to share with customers for making payments.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; private set; }

        /// <summary>
        /// The version is used for optimistic locking and incremented whenever the object is updated.
        /// </summary>
        /// <value>The version is used for optimistic locking and incremented whenever the object is updated.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentLink {\n");
            sb.Append("  AllowedPaymentMethodConfigurations: ").Append(AllowedPaymentMethodConfigurations).Append("\n");
            sb.Append("  AllowedRedirectionDomains: ").Append(AllowedRedirectionDomains).Append("\n");
            sb.Append("  AppliedSpaceView: ").Append(AppliedSpaceView).Append("\n");
            sb.Append("  AvailableFrom: ").Append(AvailableFrom).Append("\n");
            sb.Append("  AvailableUntil: ").Append(AvailableUntil).Append("\n");
            sb.Append("  BillingAddressHandlingMode: ").Append(BillingAddressHandlingMode).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  MaximalNumberOfTransactions: ").Append(MaximalNumberOfTransactions).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  ProtectionMode: ").Append(ProtectionMode).Append("\n");
            sb.Append("  ShippingAddressHandlingMode: ").Append(ShippingAddressHandlingMode).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as PaymentLink);
        }

        /// <summary>
        /// Returns true if PaymentLink instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentLink input)
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
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                    this.LinkedSpaceId == input.LinkedSpaceId ||
                    (this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(input.LinkedSpaceId))
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
                    this.PlannedPurgeDate == input.PlannedPurgeDate ||
                    (this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(input.PlannedPurgeDate))
                ) && 
                (
                    this.ProtectionMode == input.ProtectionMode ||
                    (this.ProtectionMode != null &&
                    this.ProtectionMode.Equals(input.ProtectionMode))
                ) && 
                (
                    this.ShippingAddressHandlingMode == input.ShippingAddressHandlingMode ||
                    (this.ShippingAddressHandlingMode != null &&
                    this.ShippingAddressHandlingMode.Equals(input.ShippingAddressHandlingMode))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.LineItems != null)
                    hashCode = hashCode * 59 + this.LineItems.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.MaximalNumberOfTransactions != null)
                    hashCode = hashCode * 59 + this.MaximalNumberOfTransactions.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.ProtectionMode != null)
                    hashCode = hashCode * 59 + this.ProtectionMode.GetHashCode();
                if (this.ShippingAddressHandlingMode != null)
                    hashCode = hashCode * 59 + this.ShippingAddressHandlingMode.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
