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
    /// The subscription ledger entry represents a single change on the subscription balance.
    /// </summary>
    [DataContract]
    public partial class SubscriptionLedgerEntryCreate :  IEquatable<SubscriptionLedgerEntryCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionLedgerEntryCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionLedgerEntryCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionLedgerEntryCreate" /> class.
        /// </summary>
        /// <param name="amountIncludingTax">The leger entry&#39;s amount with discounts applied, including taxes. (required).</param>
        /// <param name="externalId">A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result. (required).</param>
        /// <param name="quantity">The number of items that were consumed. (required).</param>
        /// <param name="subscriptionVersion">The subscription version that the ledger entry belongs to. (required).</param>
        /// <param name="title">The title that indicates what the ledger entry is about. (required).</param>
        public SubscriptionLedgerEntryCreate(decimal? amountIncludingTax, string externalId, decimal? quantity, long? subscriptionVersion, string title)
        {
            // to ensure "amountIncludingTax" is required (not null)
            if (amountIncludingTax == null)
            {
                throw new InvalidDataException("amountIncludingTax is a required property for SubscriptionLedgerEntryCreate and cannot be null");
            }
            this.AmountIncludingTax = amountIncludingTax;
            // to ensure "externalId" is required (not null)
            if (externalId == null)
            {
                throw new InvalidDataException("externalId is a required property for SubscriptionLedgerEntryCreate and cannot be null");
            }
            this.ExternalId = externalId;
            // to ensure "quantity" is required (not null)
            if (quantity == null)
            {
                throw new InvalidDataException("quantity is a required property for SubscriptionLedgerEntryCreate and cannot be null");
            }
            this.Quantity = quantity;
            // to ensure "subscriptionVersion" is required (not null)
            if (subscriptionVersion == null)
            {
                throw new InvalidDataException("subscriptionVersion is a required property for SubscriptionLedgerEntryCreate and cannot be null");
            }
            this.SubscriptionVersion = subscriptionVersion;
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for SubscriptionLedgerEntryCreate and cannot be null");
            }
            this.Title = title;
        }

        /// <summary>
        /// The leger entry&#39;s amount with discounts applied, including taxes.
        /// </summary>
        /// <value>The leger entry&#39;s amount with discounts applied, including taxes.</value>
        [DataMember(Name="amountIncludingTax", EmitDefaultValue=false)]
        public decimal? AmountIncludingTax { get; set; }

        /// <summary>
        /// Gets or Sets ComponentReferenceName
        /// </summary>
        [DataMember(Name="componentReferenceName", EmitDefaultValue=false)]
        public string ComponentReferenceName { get; set; }

        /// <summary>
        /// A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.
        /// </summary>
        /// <value>A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The number of items that were consumed.
        /// </summary>
        /// <value>The number of items that were consumed.</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionMetricId
        /// </summary>
        [DataMember(Name="subscriptionMetricId", EmitDefaultValue=false)]
        public long? SubscriptionMetricId { get; set; }

        /// <summary>
        /// The subscription version that the ledger entry belongs to.
        /// </summary>
        /// <value>The subscription version that the ledger entry belongs to.</value>
        [DataMember(Name="subscriptionVersion", EmitDefaultValue=false)]
        public long? SubscriptionVersion { get; set; }

        /// <summary>
        /// A set of tax lines, each of which specifies a tax applied to the ledger entry.
        /// </summary>
        /// <value>A set of tax lines, each of which specifies a tax applied to the ledger entry.</value>
        [DataMember(Name="taxes", EmitDefaultValue=false)]
        public List<TaxCreate> Taxes { get; set; }

        /// <summary>
        /// The title that indicates what the ledger entry is about.
        /// </summary>
        /// <value>The title that indicates what the ledger entry is about.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionLedgerEntryCreate {\n");
            sb.Append("  AmountIncludingTax: ").Append(AmountIncludingTax).Append("\n");
            sb.Append("  ComponentReferenceName: ").Append(ComponentReferenceName).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  SubscriptionMetricId: ").Append(SubscriptionMetricId).Append("\n");
            sb.Append("  SubscriptionVersion: ").Append(SubscriptionVersion).Append("\n");
            sb.Append("  Taxes: ").Append(Taxes).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as SubscriptionLedgerEntryCreate);
        }

        /// <summary>
        /// Returns true if SubscriptionLedgerEntryCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionLedgerEntryCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionLedgerEntryCreate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AmountIncludingTax == input.AmountIncludingTax ||
                    (this.AmountIncludingTax != null &&
                    this.AmountIncludingTax.Equals(input.AmountIncludingTax))
                ) && 
                (
                    this.ComponentReferenceName == input.ComponentReferenceName ||
                    (this.ComponentReferenceName != null &&
                    this.ComponentReferenceName.Equals(input.ComponentReferenceName))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.SubscriptionMetricId == input.SubscriptionMetricId ||
                    (this.SubscriptionMetricId != null &&
                    this.SubscriptionMetricId.Equals(input.SubscriptionMetricId))
                ) && 
                (
                    this.SubscriptionVersion == input.SubscriptionVersion ||
                    (this.SubscriptionVersion != null &&
                    this.SubscriptionVersion.Equals(input.SubscriptionVersion))
                ) && 
                (
                    this.Taxes == input.Taxes ||
                    this.Taxes != null &&
                    input.Taxes != null &&
                    this.Taxes.SequenceEqual(input.Taxes)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.AmountIncludingTax != null)
                    hashCode = hashCode * 59 + this.AmountIncludingTax.GetHashCode();
                if (this.ComponentReferenceName != null)
                    hashCode = hashCode * 59 + this.ComponentReferenceName.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.SubscriptionMetricId != null)
                    hashCode = hashCode * 59 + this.SubscriptionMetricId.GetHashCode();
                if (this.SubscriptionVersion != null)
                    hashCode = hashCode * 59 + this.SubscriptionVersion.GetHashCode();
                if (this.Taxes != null)
                    hashCode = hashCode * 59 + this.Taxes.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                return hashCode;
            }
        }

    }

}
