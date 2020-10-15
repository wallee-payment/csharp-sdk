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
        /// <param name="amountIncludingTax">amountIncludingTax (required).</param>
        /// <param name="externalId">The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity. (required).</param>
        /// <param name="quantity">quantity (required).</param>
        /// <param name="subscriptionVersion">subscriptionVersion (required).</param>
        /// <param name="title">title (required).</param>
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
        /// Gets or Sets AmountIncludingTax
        /// </summary>
        [DataMember(Name="amountIncludingTax", EmitDefaultValue=true)]
        public decimal? AmountIncludingTax { get; set; }

        /// <summary>
        /// The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity.
        /// </summary>
        /// <value>The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity.</value>
        [DataMember(Name="externalId", EmitDefaultValue=true)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=true)]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionVersion
        /// </summary>
        [DataMember(Name="subscriptionVersion", EmitDefaultValue=true)]
        public long? SubscriptionVersion { get; set; }

        /// <summary>
        /// Gets or Sets Taxes
        /// </summary>
        [DataMember(Name="taxes", EmitDefaultValue=true)]
        public List<TaxCreate> Taxes { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=true)]
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
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
                    this.SubscriptionVersion == input.SubscriptionVersion ||
                    (this.SubscriptionVersion != null &&
                    this.SubscriptionVersion.Equals(input.SubscriptionVersion))
                ) && 
                (
                    this.Taxes == input.Taxes ||
                    this.Taxes != null &&
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
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
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
