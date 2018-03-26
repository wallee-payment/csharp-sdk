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
    public partial class LineItem :  IEquatable<LineItem>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="LineItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public LineItem()
        {
        }

        /// <summary>
        /// The aggregated tax rate is the sum of all tax rates of the line item.
        /// </summary>
        /// <value>The aggregated tax rate is the sum of all tax rates of the line item.</value>
        [DataMember(Name="aggregatedTaxRate", EmitDefaultValue=false)]
        public decimal? AggregatedTaxRate { get; private set; }

        /// <summary>
        /// AmountExcludingTax
        /// </summary>
        /// <value>AmountExcludingTax</value>
        [DataMember(Name="amountExcludingTax", EmitDefaultValue=false)]
        public decimal? AmountExcludingTax { get; private set; }

        /// <summary>
        /// AmountIncludingTax
        /// </summary>
        /// <value>AmountIncludingTax</value>
        [DataMember(Name="amountIncludingTax", EmitDefaultValue=false)]
        public decimal? AmountIncludingTax { get; private set; }

        /// <summary>
        /// Attributes
        /// </summary>
        /// <value>Attributes</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Dictionary<string, LineItemAttribute> Attributes { get; private set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// Quantity
        /// </summary>
        /// <value>Quantity</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public decimal? Quantity { get; private set; }

        /// <summary>
        /// ShippingRequired
        /// </summary>
        /// <value>ShippingRequired</value>
        [DataMember(Name="shippingRequired", EmitDefaultValue=false)]
        public bool? ShippingRequired { get; private set; }

        /// <summary>
        /// Sku
        /// </summary>
        /// <value>Sku</value>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; private set; }

        /// <summary>
        /// TaxAmount
        /// </summary>
        /// <value>TaxAmount</value>
        [DataMember(Name="taxAmount", EmitDefaultValue=false)]
        public decimal? TaxAmount { get; private set; }

        /// <summary>
        /// TaxAmountPerUnit
        /// </summary>
        /// <value>TaxAmountPerUnit</value>
        [DataMember(Name="taxAmountPerUnit", EmitDefaultValue=false)]
        public decimal? TaxAmountPerUnit { get; private set; }

        /// <summary>
        /// Taxes
        /// </summary>
        /// <value>Taxes</value>
        [DataMember(Name="taxes", EmitDefaultValue=false)]
        public List<Tax> Taxes { get; private set; }

        /// <summary>
        /// Type
        /// </summary>
        /// <value>Type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public LineItemType? Type { get; private set; }

        /// <summary>
        /// The unique id identifies the line item within the set of line items associated with the transaction.
        /// </summary>
        /// <value>The unique id identifies the line item within the set of line items associated with the transaction.</value>
        [DataMember(Name="uniqueId", EmitDefaultValue=false)]
        public string UniqueId { get; private set; }

        /// <summary>
        /// UnitPriceExcludingTax
        /// </summary>
        /// <value>UnitPriceExcludingTax</value>
        [DataMember(Name="unitPriceExcludingTax", EmitDefaultValue=false)]
        public decimal? UnitPriceExcludingTax { get; private set; }

        /// <summary>
        /// UnitPriceIncludingTax
        /// </summary>
        /// <value>UnitPriceIncludingTax</value>
        [DataMember(Name="unitPriceIncludingTax", EmitDefaultValue=false)]
        public decimal? UnitPriceIncludingTax { get; private set; }

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
            return this.Equals(obj as LineItem);
        }

        /// <summary>
        /// Returns true if LineItem instances are equal
        /// </summary>
        /// <param name="other">Instance of LineItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LineItem other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.AggregatedTaxRate == other.AggregatedTaxRate ||
                    this.AggregatedTaxRate != null &&
                    this.AggregatedTaxRate.Equals(other.AggregatedTaxRate)
                ) && 
                (
                    this.AmountExcludingTax == other.AmountExcludingTax ||
                    this.AmountExcludingTax != null &&
                    this.AmountExcludingTax.Equals(other.AmountExcludingTax)
                ) && 
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
                    this.TaxAmount == other.TaxAmount ||
                    this.TaxAmount != null &&
                    this.TaxAmount.Equals(other.TaxAmount)
                ) && 
                (
                    this.TaxAmountPerUnit == other.TaxAmountPerUnit ||
                    this.TaxAmountPerUnit != null &&
                    this.TaxAmountPerUnit.Equals(other.TaxAmountPerUnit)
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
                ) && 
                (
                    this.UnitPriceExcludingTax == other.UnitPriceExcludingTax ||
                    this.UnitPriceExcludingTax != null &&
                    this.UnitPriceExcludingTax.Equals(other.UnitPriceExcludingTax)
                ) && 
                (
                    this.UnitPriceIncludingTax == other.UnitPriceIncludingTax ||
                    this.UnitPriceIncludingTax != null &&
                    this.UnitPriceIncludingTax.Equals(other.UnitPriceIncludingTax)
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
                if (this.AggregatedTaxRate != null)
                {
                    hash = hash * 59 + this.AggregatedTaxRate.GetHashCode();
                }
                if (this.AmountExcludingTax != null)
                {
                    hash = hash * 59 + this.AmountExcludingTax.GetHashCode();
                }
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
                if (this.TaxAmount != null)
                {
                    hash = hash * 59 + this.TaxAmount.GetHashCode();
                }
                if (this.TaxAmountPerUnit != null)
                {
                    hash = hash * 59 + this.TaxAmountPerUnit.GetHashCode();
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
                if (this.UnitPriceExcludingTax != null)
                {
                    hash = hash * 59 + this.UnitPriceExcludingTax.GetHashCode();
                }
                if (this.UnitPriceIncludingTax != null)
                {
                    hash = hash * 59 + this.UnitPriceIncludingTax.GetHashCode();
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
