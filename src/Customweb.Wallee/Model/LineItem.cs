
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
    /// LineItem model.
    /// </summary>
    [DataContract]
    public partial class LineItem :  IEquatable<LineItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LineItem" /> class.
        /// </summary>
        /// <param name="AggregatedTaxRate">The aggregated tax rate is the sum of all tax rates of the line item.</param>
        /// <param name="AmountExcludingTax">AmountExcludingTax</param>
        /// <param name="AmountIncludingTax">AmountIncludingTax</param>
        /// <param name="Name">Name</param>
        /// <param name="Quantity">Quantity</param>
        /// <param name="ShippingRequired">ShippingRequired</param>
        /// <param name="Sku">Sku</param>
        /// <param name="TaxAmount">TaxAmount</param>
        /// <param name="TaxAmountPerUnit">TaxAmountPerUnit</param>
        /// <param name="Taxes">Taxes</param>
        /// <param name="Type">Type</param>
        /// <param name="UniqueId">The unique id identifies the line item within the set of line items associated with the transaction.</param>
        /// <param name="UnitPriceExcludingTax">UnitPriceExcludingTax</param>
        /// <param name="UnitPriceIncludingTax">UnitPriceIncludingTax</param>
        public LineItem(decimal? AggregatedTaxRate = default(decimal?), decimal? AmountExcludingTax = default(decimal?), decimal? AmountIncludingTax = default(decimal?), string Name = default(string), decimal? Quantity = default(decimal?), bool? ShippingRequired = default(bool?), string Sku = default(string), decimal? TaxAmount = default(decimal?), decimal? TaxAmountPerUnit = default(decimal?), List<Tax> Taxes = default(List<Tax>), LineItemType Type = default(LineItemType), string UniqueId = default(string), decimal? UnitPriceExcludingTax = default(decimal?), decimal? UnitPriceIncludingTax = default(decimal?))
        {
            this.AggregatedTaxRate = AggregatedTaxRate;
            this.AmountExcludingTax = AmountExcludingTax;
            this.AmountIncludingTax = AmountIncludingTax;
            this.Name = Name;
            this.Quantity = Quantity;
            this.ShippingRequired = ShippingRequired;
            this.Sku = Sku;
            this.TaxAmount = TaxAmount;
            this.TaxAmountPerUnit = TaxAmountPerUnit;
            this.Taxes = Taxes;
            this.Type = Type;
            this.UniqueId = UniqueId;
            this.UnitPriceExcludingTax = UnitPriceExcludingTax;
            this.UnitPriceIncludingTax = UnitPriceIncludingTax;
        }

        /// <summary>
        /// The aggregated tax rate is the sum of all tax rates of the line item.
        /// </summary>
        /// <value>The aggregated tax rate is the sum of all tax rates of the line item.</value>
        [DataMember(Name="aggregatedTaxRate", EmitDefaultValue=false)]
        public decimal? AggregatedTaxRate { get; set; }

        /// <summary>
        /// AmountExcludingTax
        /// </summary>
        /// <value>AmountExcludingTax</value>
        [DataMember(Name="amountExcludingTax", EmitDefaultValue=false)]
        public decimal? AmountExcludingTax { get; set; }

        /// <summary>
        /// AmountIncludingTax
        /// </summary>
        /// <value>AmountIncludingTax</value>
        [DataMember(Name="amountIncludingTax", EmitDefaultValue=false)]
        public decimal? AmountIncludingTax { get; set; }

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
        /// TaxAmount
        /// </summary>
        /// <value>TaxAmount</value>
        [DataMember(Name="taxAmount", EmitDefaultValue=false)]
        public decimal? TaxAmount { get; set; }

        /// <summary>
        /// TaxAmountPerUnit
        /// </summary>
        /// <value>TaxAmountPerUnit</value>
        [DataMember(Name="taxAmountPerUnit", EmitDefaultValue=false)]
        public decimal? TaxAmountPerUnit { get; set; }

        /// <summary>
        /// Taxes
        /// </summary>
        /// <value>Taxes</value>
        [DataMember(Name="taxes", EmitDefaultValue=false)]
        public List<Tax> Taxes { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        /// <value>Type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public LineItemType Type { get; set; }

        /// <summary>
        /// The unique id identifies the line item within the set of line items associated with the transaction.
        /// </summary>
        /// <value>The unique id identifies the line item within the set of line items associated with the transaction.</value>
        [DataMember(Name="uniqueId", EmitDefaultValue=false)]
        public string UniqueId { get; set; }

        /// <summary>
        /// UnitPriceExcludingTax
        /// </summary>
        /// <value>UnitPriceExcludingTax</value>
        [DataMember(Name="unitPriceExcludingTax", EmitDefaultValue=false)]
        public decimal? UnitPriceExcludingTax { get; set; }

        /// <summary>
        /// UnitPriceIncludingTax
        /// </summary>
        /// <value>UnitPriceIncludingTax</value>
        [DataMember(Name="unitPriceIncludingTax", EmitDefaultValue=false)]
        public decimal? UnitPriceIncludingTax { get; set; }

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
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  ShippingRequired: ").Append(ShippingRequired).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  TaxAmountPerUnit: ").Append(TaxAmountPerUnit).Append("\n");
            sb.Append("  Taxes: ").Append(Taxes).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
                // Suitable nullity checks etc, of course :)
                if (this.AggregatedTaxRate != null)
                    hash = hash * 59 + this.AggregatedTaxRate.GetHashCode();
                if (this.AmountExcludingTax != null)
                    hash = hash * 59 + this.AmountExcludingTax.GetHashCode();
                if (this.AmountIncludingTax != null)
                    hash = hash * 59 + this.AmountIncludingTax.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                if (this.ShippingRequired != null)
                    hash = hash * 59 + this.ShippingRequired.GetHashCode();
                if (this.Sku != null)
                    hash = hash * 59 + this.Sku.GetHashCode();
                if (this.TaxAmount != null)
                    hash = hash * 59 + this.TaxAmount.GetHashCode();
                if (this.TaxAmountPerUnit != null)
                    hash = hash * 59 + this.TaxAmountPerUnit.GetHashCode();
                if (this.Taxes != null)
                    hash = hash * 59 + this.Taxes.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.UniqueId != null)
                    hash = hash * 59 + this.UniqueId.GetHashCode();
                if (this.UnitPriceExcludingTax != null)
                    hash = hash * 59 + this.UnitPriceExcludingTax.GetHashCode();
                if (this.UnitPriceIncludingTax != null)
                    hash = hash * 59 + this.UnitPriceIncludingTax.GetHashCode();
                return hash;
            }
        }

    }

}
