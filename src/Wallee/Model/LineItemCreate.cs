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
    /// LineItemCreate
    /// </summary>
    [DataContract]
    public partial class LineItemCreate :  IEquatable<LineItemCreate>
    {
        /// <summary>
        /// The type of the line item.
        /// </summary>
        /// <value>The type of the line item.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public LineItemType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LineItemCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LineItemCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LineItemCreate" /> class.
        /// </summary>
        /// <param name="amountIncludingTax">The line item price with discounts applied, including taxes. (required).</param>
        /// <param name="name">The name of the product, ideally in the customer&#39;s language. (required).</param>
        /// <param name="quantity">The number of items that were purchased. (required).</param>
        /// <param name="type">The type of the line item. (required).</param>
        /// <param name="uniqueId">The unique identifier of the line item within the set of line items. (required).</param>
        public LineItemCreate(decimal? amountIncludingTax, string name, decimal? quantity, LineItemType type, string uniqueId)
        {
            // to ensure "amountIncludingTax" is required (not null)
            if (amountIncludingTax == null)
            {
                throw new InvalidDataException("amountIncludingTax is a required property for LineItemCreate and cannot be null");
            }
            this.AmountIncludingTax = amountIncludingTax;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for LineItemCreate and cannot be null");
            }
            this.Name = name;
            // to ensure "quantity" is required (not null)
            if (quantity == null)
            {
                throw new InvalidDataException("quantity is a required property for LineItemCreate and cannot be null");
            }
            this.Quantity = quantity;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for LineItemCreate and cannot be null");
            }
            this.Type = type;
            // to ensure "uniqueId" is required (not null)
            if (uniqueId == null)
            {
                throw new InvalidDataException("uniqueId is a required property for LineItemCreate and cannot be null");
            }
            this.UniqueId = uniqueId;
        }

        /// <summary>
        /// The line item price with discounts applied, including taxes.
        /// </summary>
        /// <value>The line item price with discounts applied, including taxes.</value>
        [DataMember(Name="amountIncludingTax", EmitDefaultValue=false)]
        public decimal? AmountIncludingTax { get; set; }

        /// <summary>
        /// A map of custom information for the item.
        /// </summary>
        /// <value>A map of custom information for the item.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Dictionary<string, LineItemAttributeCreate> Attributes { get; set; }

        /// <summary>
        /// The discount allocated to the item, including taxes.
        /// </summary>
        /// <value>The discount allocated to the item, including taxes.</value>
        [DataMember(Name="discountIncludingTax", EmitDefaultValue=false)]
        public decimal? DiscountIncludingTax { get; set; }

        /// <summary>
        /// The name of the product, ideally in the customer&#39;s language.
        /// </summary>
        /// <value>The name of the product, ideally in the customer&#39;s language.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The number of items that were purchased.
        /// </summary>
        /// <value>The number of items that were purchased.</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// Whether the item required shipping.
        /// </summary>
        /// <value>Whether the item required shipping.</value>
        [DataMember(Name="shippingRequired", EmitDefaultValue=false)]
        public bool? ShippingRequired { get; set; }

        /// <summary>
        /// The SKU (stock-keeping unit) of the product.
        /// </summary>
        /// <value>The SKU (stock-keeping unit) of the product.</value>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }

        /// <summary>
        /// A set of tax lines, each of which specifies a tax applied to the item.
        /// </summary>
        /// <value>A set of tax lines, each of which specifies a tax applied to the item.</value>
        [DataMember(Name="taxes", EmitDefaultValue=false)]
        public List<TaxCreate> Taxes { get; set; }


        /// <summary>
        /// The unique identifier of the line item within the set of line items.
        /// </summary>
        /// <value>The unique identifier of the line item within the set of line items.</value>
        [DataMember(Name="uniqueId", EmitDefaultValue=false)]
        public string UniqueId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LineItemCreate {\n");
            sb.Append("  AmountIncludingTax: ").Append(AmountIncludingTax).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  DiscountIncludingTax: ").Append(DiscountIncludingTax).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  ShippingRequired: ").Append(ShippingRequired).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Taxes: ").Append(Taxes).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UniqueId: ").Append(UniqueId).Append("\n");
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
            return this.Equals(input as LineItemCreate);
        }

        /// <summary>
        /// Returns true if LineItemCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of LineItemCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LineItemCreate input)
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
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    input.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
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
                    this.Taxes == input.Taxes ||
                    this.Taxes != null &&
                    input.Taxes != null &&
                    this.Taxes.SequenceEqual(input.Taxes)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.UniqueId == input.UniqueId ||
                    (this.UniqueId != null &&
                    this.UniqueId.Equals(input.UniqueId))
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
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
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
                if (this.Taxes != null)
                    hashCode = hashCode * 59 + this.Taxes.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.UniqueId != null)
                    hashCode = hashCode * 59 + this.UniqueId.GetHashCode();
                return hashCode;
            }
        }

    }

}
