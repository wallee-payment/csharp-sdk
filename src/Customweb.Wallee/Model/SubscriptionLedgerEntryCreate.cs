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
    /// The subscription ledger entry represents a single change on the subscription balance.
    /// </summary>
    [DataContract]
    public partial class SubscriptionLedgerEntryCreate :  IEquatable<SubscriptionLedgerEntryCreate>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionLedgerEntryCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionLedgerEntryCreate() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionLedgerEntryCreate" /> class.
        /// </summary>
        /// <param name="AmountIncludingTax">AmountIncludingTax (required)</param>
        /// <param name="ExternalId">The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity. (required)</param>
        /// <param name="Quantity">Quantity (required)</param>
        /// <param name="SubscriptionVersion">SubscriptionVersion (required)</param>
        /// <param name="Taxes">Taxes</param>
        /// <param name="Title">Title (required)</param>
        public SubscriptionLedgerEntryCreate(decimal? AmountIncludingTax = default(decimal?), string Title = default(string), long? SubscriptionVersion = default(long?), List<TaxCreate> Taxes = default(List<TaxCreate>), decimal? Quantity = default(decimal?), string ExternalId = default(string))
        {
            // to ensure "AmountIncludingTax" is required (not null)
            if (AmountIncludingTax == null)
            {
                throw new ArgumentNullException("AmountIncludingTax is a required property for SubscriptionLedgerEntryCreate and cannot be null");
            }
            else
            {
                this.AmountIncludingTax = AmountIncludingTax;
            }
            // to ensure "ExternalId" is required (not null)
            if (ExternalId == null)
            {
                throw new ArgumentNullException("ExternalId is a required property for SubscriptionLedgerEntryCreate and cannot be null");
            }
            else
            {
                this.ExternalId = ExternalId;
            }
            // to ensure "Quantity" is required (not null)
            if (Quantity == null)
            {
                throw new ArgumentNullException("Quantity is a required property for SubscriptionLedgerEntryCreate and cannot be null");
            }
            else
            {
                this.Quantity = Quantity;
            }
            // to ensure "SubscriptionVersion" is required (not null)
            if (SubscriptionVersion == null)
            {
                throw new ArgumentNullException("SubscriptionVersion is a required property for SubscriptionLedgerEntryCreate and cannot be null");
            }
            else
            {
                this.SubscriptionVersion = SubscriptionVersion;
            }
            // to ensure "Title" is required (not null)
            if (Title == null)
            {
                throw new ArgumentNullException("Title is a required property for SubscriptionLedgerEntryCreate and cannot be null");
            }
            else
            {
                this.Title = Title;
            }
            this.Taxes = Taxes;
        }

        /// <summary>
        /// AmountIncludingTax
        /// </summary>
        /// <value>AmountIncludingTax</value>
        [DataMember(Name="amountIncludingTax", EmitDefaultValue=false)]
        public decimal? AmountIncludingTax { get; set; }

        /// <summary>
        /// The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity.
        /// </summary>
        /// <value>The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Quantity
        /// </summary>
        /// <value>Quantity</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// SubscriptionVersion
        /// </summary>
        /// <value>SubscriptionVersion</value>
        [DataMember(Name="subscriptionVersion", EmitDefaultValue=false)]
        public long? SubscriptionVersion { get; set; }

        /// <summary>
        /// Taxes
        /// </summary>
        /// <value>Taxes</value>
        [DataMember(Name="taxes", EmitDefaultValue=false)]
        public List<TaxCreate> Taxes { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        /// <value>Title</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

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
        public string ToJson()
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
            return this.Equals(obj as SubscriptionLedgerEntryCreate);
        }

        /// <summary>
        /// Returns true if SubscriptionLedgerEntryCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of SubscriptionLedgerEntryCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionLedgerEntryCreate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.AmountIncludingTax == other.AmountIncludingTax ||
                    this.AmountIncludingTax != null &&
                    this.AmountIncludingTax.Equals(other.AmountIncludingTax)
                ) && 
                (
                    this.ExternalId == other.ExternalId ||
                    this.ExternalId != null &&
                    this.ExternalId.Equals(other.ExternalId)
                ) && 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
                ) && 
                (
                    this.SubscriptionVersion == other.SubscriptionVersion ||
                    this.SubscriptionVersion != null &&
                    this.SubscriptionVersion.Equals(other.SubscriptionVersion)
                ) && 
                (
                    this.Taxes == other.Taxes ||
                    this.Taxes != null &&
                    this.Taxes.SequenceEqual(other.Taxes)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
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
                if (this.AmountIncludingTax != null)
                {
                    hash = hash * 59 + this.AmountIncludingTax.GetHashCode();
                }
                if (this.ExternalId != null)
                {
                    hash = hash * 59 + this.ExternalId.GetHashCode();
                }
                if (this.Quantity != null)
                {
                    hash = hash * 59 + this.Quantity.GetHashCode();
                }
                if (this.SubscriptionVersion != null)
                {
                    hash = hash * 59 + this.SubscriptionVersion.GetHashCode();
                }
                if (this.Taxes != null)
                {
                    hash = hash * 59 + this.Taxes.GetHashCode();
                }
                if (this.Title != null)
                {
                    hash = hash * 59 + this.Title.GetHashCode();
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
