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
    /// Line Item
    /// </summary>
    [DataContract]
    public partial class LineItemCreate :  IEquatable<LineItemCreate>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="LineItemCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LineItemCreate() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="LineItemCreate" /> class.
        /// </summary>
        /// <param name="AmountIncludingTax">AmountIncludingTax (required)</param>
        /// <param name="Attributes">Attributes</param>
        /// <param name="Name">Name (required)</param>
        /// <param name="Quantity">Quantity (required)</param>
        /// <param name="ShippingRequired">ShippingRequired</param>
        /// <param name="Sku">Sku</param>
        /// <param name="Taxes">Taxes</param>
        /// <param name="Type">Type (required)</param>
        /// <param name="UniqueId">The unique id identifies the line item within the set of line items associated with the transaction. (required)</param>
        public LineItemCreate(decimal? AmountIncludingTax = default(decimal?), string Sku = default(string), List<TaxCreate> Taxes = default(List<TaxCreate>), string UniqueId = default(string), LineItemType? Type = default(LineItemType?), decimal? Quantity = default(decimal?), Dictionary<string, LineItemAttributeCreate> Attributes = default(Dictionary<string, LineItemAttributeCreate>), string Name = default(string), bool? ShippingRequired = default(bool?))
        {
            // to ensure "AmountIncludingTax" is required (not null)
            if (AmountIncludingTax == null)
            {
                throw new ArgumentNullException("AmountIncludingTax is a required property for LineItemCreate and cannot be null");
            }
            else
            {
                this.AmountIncludingTax = AmountIncludingTax;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new ArgumentNullException("Name is a required property for LineItemCreate and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Quantity" is required (not null)
            if (Quantity == null)
            {
                throw new ArgumentNullException("Quantity is a required property for LineItemCreate and cannot be null");
            }
            else
            {
                this.Quantity = Quantity;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new ArgumentNullException("Type is a required property for LineItemCreate and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            // to ensure "UniqueId" is required (not null)
            if (UniqueId == null)
            {
                throw new ArgumentNullException("UniqueId is a required property for LineItemCreate and cannot be null");
            }
            else
            {
                this.UniqueId = UniqueId;
            }
            this.Attributes = Attributes;
            this.ShippingRequired = ShippingRequired;
            this.Sku = Sku;
            this.Taxes = Taxes;
        }

        /// <summary>
        /// AmountIncludingTax
        /// </summary>
        /// <value>AmountIncludingTax</value>
        [DataMember(Name="amountIncludingTax", EmitDefaultValue=false)]
        public decimal? AmountIncludingTax { get; set; }

        /// <summary>
        /// Attributes
        /// </summary>
        /// <value>Attributes</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Dictionary<string, LineItemAttributeCreate> Attributes { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Quantity
        /// </summary>
        /// <value>Quantity</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// ShippingRequired
        /// </summary>
        /// <value>ShippingRequired</value>
        [DataMember(Name="shippingRequired", EmitDefaultValue=false)]
        public bool? ShippingRequired { get; set; }

        /// <summary>
        /// Sku
        /// </summary>
        /// <value>Sku</value>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }

        /// <summary>
        /// Taxes
        /// </summary>
        /// <value>Taxes</value>
        [DataMember(Name="taxes", EmitDefaultValue=false)]
        public List<TaxCreate> Taxes { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        /// <value>Type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public LineItemType? Type { get; set; }

        /// <summary>
        /// The unique id identifies the line item within the set of line items associated with the transaction.
        /// </summary>
        /// <value>The unique id identifies the line item within the set of line items associated with the transaction.</value>
        [DataMember(Name="uniqueId", EmitDefaultValue=false)]
        public string UniqueId { get; set; }

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
            return this.Equals(obj as LineItemCreate);
        }

        /// <summary>
        /// Returns true if LineItemCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of LineItemCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LineItemCreate other)
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
                    this.Attributes == other.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(other.Attributes)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
                ) && 
                (
                    this.ShippingRequired == other.ShippingRequired ||
                    this.ShippingRequired != null &&
                    this.ShippingRequired.Equals(other.ShippingRequired)
                ) && 
                (
                    this.Sku == other.Sku ||
                    this.Sku != null &&
                    this.Sku.Equals(other.Sku)
                ) && 
                (
                    this.Taxes == other.Taxes ||
                    this.Taxes != null &&
                    this.Taxes.SequenceEqual(other.Taxes)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.UniqueId == other.UniqueId ||
                    this.UniqueId != null &&
                    this.UniqueId.Equals(other.UniqueId)
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
                if (this.Attributes != null)
                {
                    hash = hash * 59 + this.Attributes.GetHashCode();
                }
                if (this.Name != null)
                {
                    hash = hash * 59 + this.Name.GetHashCode();
                }
                if (this.Quantity != null)
                {
                    hash = hash * 59 + this.Quantity.GetHashCode();
                }
                if (this.ShippingRequired != null)
                {
                    hash = hash * 59 + this.ShippingRequired.GetHashCode();
                }
                if (this.Sku != null)
                {
                    hash = hash * 59 + this.Sku.GetHashCode();
                }
                if (this.Taxes != null)
                {
                    hash = hash * 59 + this.Taxes.GetHashCode();
                }
                if (this.Type != null)
                {
                    hash = hash * 59 + this.Type.GetHashCode();
                }
                if (this.UniqueId != null)
                {
                    hash = hash * 59 + this.UniqueId.GetHashCode();
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
