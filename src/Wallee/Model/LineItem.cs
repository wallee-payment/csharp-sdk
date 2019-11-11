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
    /// LineItem
    /// </summary>
    [DataContract]
    public partial class LineItem :  IEquatable<LineItem>
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public LineItemType? Type { get; set; }
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
        /// Gets or Sets AmountExcludingTax
        /// </summary>
        [DataMember(Name="amountExcludingTax", EmitDefaultValue=false)]
        public decimal? AmountExcludingTax { get; private set; }

        /// <summary>
        /// Gets or Sets AmountIncludingTax
        /// </summary>
        [DataMember(Name="amountIncludingTax", EmitDefaultValue=false)]
        public decimal? AmountIncludingTax { get; private set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Dictionary<string, LineItemAttribute> Attributes { get; private set; }

        /// <summary>
        /// Gets or Sets DiscountExcludingTax
        /// </summary>
        [DataMember(Name="discountExcludingTax", EmitDefaultValue=false)]
        public decimal? DiscountExcludingTax { get; private set; }

        /// <summary>
        /// Gets or Sets DiscountIncludingTax
        /// </summary>
        [DataMember(Name="discountIncludingTax", EmitDefaultValue=false)]
        public decimal? DiscountIncludingTax { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public decimal? Quantity { get; private set; }

        /// <summary>
        /// Gets or Sets ShippingRequired
        /// </summary>
        [DataMember(Name="shippingRequired", EmitDefaultValue=false)]
        public bool? ShippingRequired { get; private set; }

        /// <summary>
        /// Gets or Sets Sku
        /// </summary>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; private set; }

        /// <summary>
        /// Gets or Sets TaxAmount
        /// </summary>
        [DataMember(Name="taxAmount", EmitDefaultValue=false)]
        public decimal? TaxAmount { get; private set; }

        /// <summary>
        /// Gets or Sets TaxAmountPerUnit
        /// </summary>
        [DataMember(Name="taxAmountPerUnit", EmitDefaultValue=false)]
        public decimal? TaxAmountPerUnit { get; private set; }

        /// <summary>
        /// Gets or Sets Taxes
        /// </summary>
        [DataMember(Name="taxes", EmitDefaultValue=false)]
        public List<Tax> Taxes { get; private set; }


        /// <summary>
        /// Gets or Sets UndiscountedAmountExcludingTax
        /// </summary>
        [DataMember(Name="undiscountedAmountExcludingTax", EmitDefaultValue=false)]
        public decimal? UndiscountedAmountExcludingTax { get; private set; }

        /// <summary>
        /// Gets or Sets UndiscountedAmountIncludingTax
        /// </summary>
        [DataMember(Name="undiscountedAmountIncludingTax", EmitDefaultValue=false)]
        public decimal? UndiscountedAmountIncludingTax { get; private set; }

        /// <summary>
        /// Gets or Sets UndiscountedUnitPriceExcludingTax
        /// </summary>
        [DataMember(Name="undiscountedUnitPriceExcludingTax", EmitDefaultValue=false)]
        public decimal? UndiscountedUnitPriceExcludingTax { get; private set; }

        /// <summary>
        /// Gets or Sets UndiscountedUnitPriceIncludingTax
        /// </summary>
        [DataMember(Name="undiscountedUnitPriceIncludingTax", EmitDefaultValue=false)]
        public decimal? UndiscountedUnitPriceIncludingTax { get; private set; }

        /// <summary>
        /// The unique id identifies the line item within the set of line items associated with the transaction.
        /// </summary>
        /// <value>The unique id identifies the line item within the set of line items associated with the transaction.</value>
        [DataMember(Name="uniqueId", EmitDefaultValue=false)]
        public string UniqueId { get; private set; }

        /// <summary>
        /// Gets or Sets UnitPriceExcludingTax
        /// </summary>
        [DataMember(Name="unitPriceExcludingTax", EmitDefaultValue=false)]
        public decimal? UnitPriceExcludingTax { get; private set; }

        /// <summary>
        /// Gets or Sets UnitPriceIncludingTax
        /// </summary>
        [DataMember(Name="unitPriceIncludingTax", EmitDefaultValue=false)]
        public decimal? UnitPriceIncludingTax { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LineItem {\n");
            sb.Append("  AggregatedTaxRate: ").Append(AggregatedTaxRate).Append("\n");
            sb.Append("  AmountExcludingTax: ").Append(AmountExcludingTax).Append("\n");
            sb.Append("  AmountIncludingTax: ").Append(AmountIncludingTax).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  DiscountExcludingTax: ").Append(DiscountExcludingTax).Append("\n");
            sb.Append("  DiscountIncludingTax: ").Append(DiscountIncludingTax).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  ShippingRequired: ").Append(ShippingRequired).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  TaxAmountPerUnit: ").Append(TaxAmountPerUnit).Append("\n");
            sb.Append("  Taxes: ").Append(Taxes).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UndiscountedAmountExcludingTax: ").Append(UndiscountedAmountExcludingTax).Append("\n");
            sb.Append("  UndiscountedAmountIncludingTax: ").Append(UndiscountedAmountIncludingTax).Append("\n");
            sb.Append("  UndiscountedUnitPriceExcludingTax: ").Append(UndiscountedUnitPriceExcludingTax).Append("\n");
            sb.Append("  UndiscountedUnitPriceIncludingTax: ").Append(UndiscountedUnitPriceIncludingTax).Append("\n");
            sb.Append("  UniqueId: ").Append(UniqueId).Append("\n");
            sb.Append("  UnitPriceExcludingTax: ").Append(UnitPriceExcludingTax).Append("\n");
            sb.Append("  UnitPriceIncludingTax: ").Append(UnitPriceIncludingTax).Append("\n");
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
            return this.Equals(input as LineItem);
        }

        /// <summary>
        /// Returns true if LineItem instances are equal
        /// </summary>
        /// <param name="input">Instance of LineItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LineItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AggregatedTaxRate == input.AggregatedTaxRate ||
                    (this.AggregatedTaxRate != null &&
                    this.AggregatedTaxRate.Equals(input.AggregatedTaxRate))
                ) && 
                (
                    this.AmountExcludingTax == input.AmountExcludingTax ||
                    (this.AmountExcludingTax != null &&
                    this.AmountExcludingTax.Equals(input.AmountExcludingTax))
                ) && 
                (
                    this.AmountIncludingTax == input.AmountIncludingTax ||
                    (this.AmountIncludingTax != null &&
                    this.AmountIncludingTax.Equals(input.AmountIncludingTax))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
                ) && 
                (
                    this.DiscountExcludingTax == input.DiscountExcludingTax ||
                    (this.DiscountExcludingTax != null &&
                    this.DiscountExcludingTax.Equals(input.DiscountExcludingTax))
                ) && 
                (
                    this.DiscountIncludingTax == input.DiscountIncludingTax ||
                    (this.DiscountIncludingTax != null &&
                    this.DiscountIncludingTax.Equals(input.DiscountIncludingTax))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.ShippingRequired == input.ShippingRequired ||
                    (this.ShippingRequired != null &&
                    this.ShippingRequired.Equals(input.ShippingRequired))
                ) && 
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
                ) && 
                (
                    this.TaxAmount == input.TaxAmount ||
                    (this.TaxAmount != null &&
                    this.TaxAmount.Equals(input.TaxAmount))
                ) && 
                (
                    this.TaxAmountPerUnit == input.TaxAmountPerUnit ||
                    (this.TaxAmountPerUnit != null &&
                    this.TaxAmountPerUnit.Equals(input.TaxAmountPerUnit))
                ) && 
                (
                    this.Taxes == input.Taxes ||
                    this.Taxes != null &&
                    this.Taxes.SequenceEqual(input.Taxes)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.UndiscountedAmountExcludingTax == input.UndiscountedAmountExcludingTax ||
                    (this.UndiscountedAmountExcludingTax != null &&
                    this.UndiscountedAmountExcludingTax.Equals(input.UndiscountedAmountExcludingTax))
                ) && 
                (
                    this.UndiscountedAmountIncludingTax == input.UndiscountedAmountIncludingTax ||
                    (this.UndiscountedAmountIncludingTax != null &&
                    this.UndiscountedAmountIncludingTax.Equals(input.UndiscountedAmountIncludingTax))
                ) && 
                (
                    this.UndiscountedUnitPriceExcludingTax == input.UndiscountedUnitPriceExcludingTax ||
                    (this.UndiscountedUnitPriceExcludingTax != null &&
                    this.UndiscountedUnitPriceExcludingTax.Equals(input.UndiscountedUnitPriceExcludingTax))
                ) && 
                (
                    this.UndiscountedUnitPriceIncludingTax == input.UndiscountedUnitPriceIncludingTax ||
                    (this.UndiscountedUnitPriceIncludingTax != null &&
                    this.UndiscountedUnitPriceIncludingTax.Equals(input.UndiscountedUnitPriceIncludingTax))
                ) && 
                (
                    this.UniqueId == input.UniqueId ||
                    (this.UniqueId != null &&
                    this.UniqueId.Equals(input.UniqueId))
                ) && 
                (
                    this.UnitPriceExcludingTax == input.UnitPriceExcludingTax ||
                    (this.UnitPriceExcludingTax != null &&
                    this.UnitPriceExcludingTax.Equals(input.UnitPriceExcludingTax))
                ) && 
                (
                    this.UnitPriceIncludingTax == input.UnitPriceIncludingTax ||
                    (this.UnitPriceIncludingTax != null &&
                    this.UnitPriceIncludingTax.Equals(input.UnitPriceIncludingTax))
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
                if (this.AggregatedTaxRate != null)
                    hashCode = hashCode * 59 + this.AggregatedTaxRate.GetHashCode();
                if (this.AmountExcludingTax != null)
                    hashCode = hashCode * 59 + this.AmountExcludingTax.GetHashCode();
                if (this.AmountIncludingTax != null)
                    hashCode = hashCode * 59 + this.AmountIncludingTax.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.DiscountExcludingTax != null)
                    hashCode = hashCode * 59 + this.DiscountExcludingTax.GetHashCode();
                if (this.DiscountIncludingTax != null)
                    hashCode = hashCode * 59 + this.DiscountIncludingTax.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.ShippingRequired != null)
                    hashCode = hashCode * 59 + this.ShippingRequired.GetHashCode();
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                if (this.TaxAmount != null)
                    hashCode = hashCode * 59 + this.TaxAmount.GetHashCode();
                if (this.TaxAmountPerUnit != null)
                    hashCode = hashCode * 59 + this.TaxAmountPerUnit.GetHashCode();
                if (this.Taxes != null)
                    hashCode = hashCode * 59 + this.Taxes.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.UndiscountedAmountExcludingTax != null)
                    hashCode = hashCode * 59 + this.UndiscountedAmountExcludingTax.GetHashCode();
                if (this.UndiscountedAmountIncludingTax != null)
                    hashCode = hashCode * 59 + this.UndiscountedAmountIncludingTax.GetHashCode();
                if (this.UndiscountedUnitPriceExcludingTax != null)
                    hashCode = hashCode * 59 + this.UndiscountedUnitPriceExcludingTax.GetHashCode();
                if (this.UndiscountedUnitPriceIncludingTax != null)
                    hashCode = hashCode * 59 + this.UndiscountedUnitPriceIncludingTax.GetHashCode();
                if (this.UniqueId != null)
                    hashCode = hashCode * 59 + this.UniqueId.GetHashCode();
                if (this.UnitPriceExcludingTax != null)
                    hashCode = hashCode * 59 + this.UnitPriceExcludingTax.GetHashCode();
                if (this.UnitPriceIncludingTax != null)
                    hashCode = hashCode * 59 + this.UnitPriceIncludingTax.GetHashCode();
                return hashCode;
            }
        }

    }

}
