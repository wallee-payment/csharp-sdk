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
    /// ShopifySubscriptionVersionItem
    /// </summary>
    [DataContract]
    public partial class ShopifySubscriptionVersionItem :  IEquatable<ShopifySubscriptionVersionItem>
    {
        /// <summary>
        /// Gets or Sets PriceStrategy
        /// </summary>
        [DataMember(Name="priceStrategy", EmitDefaultValue=true)]
        public ShopifySubscriptionVersionItemPriceStrategy? PriceStrategy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopifySubscriptionVersionItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ShopifySubscriptionVersionItem()
        {
        }

        /// <summary>
        /// Gets or Sets PriceIncludingTax
        /// </summary>
        [DataMember(Name="priceIncludingTax", EmitDefaultValue=true)]
        public decimal? PriceIncludingTax { get; private set; }


        /// <summary>
        /// Gets or Sets Product
        /// </summary>
        [DataMember(Name="product", EmitDefaultValue=true)]
        public long? Product { get; private set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=true)]
        public decimal? Quantity { get; private set; }

        /// <summary>
        /// Gets or Sets TaxLines
        /// </summary>
        [DataMember(Name="taxLines", EmitDefaultValue=true)]
        public List<ShopifyTaxLine> TaxLines { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShopifySubscriptionVersionItem {\n");
            sb.Append("  PriceIncludingTax: ").Append(PriceIncludingTax).Append("\n");
            sb.Append("  PriceStrategy: ").Append(PriceStrategy).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  TaxLines: ").Append(TaxLines).Append("\n");
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
            return this.Equals(input as ShopifySubscriptionVersionItem);
        }

        /// <summary>
        /// Returns true if ShopifySubscriptionVersionItem instances are equal
        /// </summary>
        /// <param name="input">Instance of ShopifySubscriptionVersionItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShopifySubscriptionVersionItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PriceIncludingTax == input.PriceIncludingTax ||
                    (this.PriceIncludingTax != null &&
                    this.PriceIncludingTax.Equals(input.PriceIncludingTax))
                ) && 
                (
                    this.PriceStrategy == input.PriceStrategy ||
                    (this.PriceStrategy != null &&
                    this.PriceStrategy.Equals(input.PriceStrategy))
                ) && 
                (
                    this.Product == input.Product ||
                    (this.Product != null &&
                    this.Product.Equals(input.Product))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.TaxLines == input.TaxLines ||
                    this.TaxLines != null &&
                    input.TaxLines != null &&
                    this.TaxLines.SequenceEqual(input.TaxLines)
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
                if (this.PriceIncludingTax != null)
                    hashCode = hashCode * 59 + this.PriceIncludingTax.GetHashCode();
                if (this.PriceStrategy != null)
                    hashCode = hashCode * 59 + this.PriceStrategy.GetHashCode();
                if (this.Product != null)
                    hashCode = hashCode * 59 + this.Product.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.TaxLines != null)
                    hashCode = hashCode * 59 + this.TaxLines.GetHashCode();
                return hashCode;
            }
        }

    }

}
