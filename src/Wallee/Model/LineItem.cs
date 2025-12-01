/**
 * Wallee AG C# SDK
 *
 * This library allows to interact with the Wallee AG payment service.
 *
 * Copyright owner: Wallee AG
 * Website: https://en.wallee.com
 * Developer email: ecosystem-team@wallee.com
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Wallee.Client.OpenAPIDateConverter;

namespace Wallee.Model
{
    /// <summary>
    /// LineItem
    /// </summary>
    [DataContract(Name = "LineItem")]
    public partial class LineItem : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public LineItemType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LineItem" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        public LineItem(LineItemType? type = default)
        {
            this.Type = type;
        }

        /// <summary>
        /// The calculated tax amount per unit.
        /// </summary>
        /// <value>The calculated tax amount per unit.</value>
        [DataMember(Name = "taxAmountPerUnit", EmitDefaultValue = false)]
        public decimal TaxAmountPerUnit { get; private set; }

        /// <summary>
        /// Returns false as TaxAmountPerUnit should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTaxAmountPerUnit()
        {
            return false;
        }
        /// <summary>
        /// The line item price with discounts not applied, excluding taxes.
        /// </summary>
        /// <value>The line item price with discounts not applied, excluding taxes.</value>
        [DataMember(Name = "undiscountedAmountExcludingTax", EmitDefaultValue = false)]
        public decimal UndiscountedAmountExcludingTax { get; private set; }

        /// <summary>
        /// Returns false as UndiscountedAmountExcludingTax should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUndiscountedAmountExcludingTax()
        {
            return false;
        }
        /// <summary>
        /// The number of items that were purchased.
        /// </summary>
        /// <value>The number of items that were purchased.</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public decimal Quantity { get; private set; }

        /// <summary>
        /// Returns false as Quantity should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeQuantity()
        {
            return false;
        }
        /// <summary>
        /// The calculated price per unit with discounts not applied, including taxes.
        /// </summary>
        /// <value>The calculated price per unit with discounts not applied, including taxes.</value>
        [DataMember(Name = "undiscountedUnitPriceIncludingTax", EmitDefaultValue = false)]
        public decimal UndiscountedUnitPriceIncludingTax { get; private set; }

        /// <summary>
        /// Returns false as UndiscountedUnitPriceIncludingTax should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUndiscountedUnitPriceIncludingTax()
        {
            return false;
        }
        /// <summary>
        /// The line item price with discounts applied, excluding taxes.
        /// </summary>
        /// <value>The line item price with discounts applied, excluding taxes.</value>
        [DataMember(Name = "amountExcludingTax", EmitDefaultValue = false)]
        public decimal AmountExcludingTax { get; private set; }

        /// <summary>
        /// Returns false as AmountExcludingTax should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAmountExcludingTax()
        {
            return false;
        }
        /// <summary>
        /// The line item price with discounts not applied, including taxes.
        /// </summary>
        /// <value>The line item price with discounts not applied, including taxes.</value>
        [DataMember(Name = "undiscountedAmountIncludingTax", EmitDefaultValue = false)]
        public decimal UndiscountedAmountIncludingTax { get; private set; }

        /// <summary>
        /// Returns false as UndiscountedAmountIncludingTax should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUndiscountedAmountIncludingTax()
        {
            return false;
        }
        /// <summary>
        /// A set of tax lines, each of which specifies a tax applied to the item.
        /// </summary>
        /// <value>A set of tax lines, each of which specifies a tax applied to the item.</value>
        [DataMember(Name = "taxes", EmitDefaultValue = false)]
        public List<Tax> Taxes { get; private set; }

        /// <summary>
        /// Returns false as Taxes should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTaxes()
        {
            return false;
        }
        /// <summary>
        /// The calculated price per unit with discounts applied, including taxes.
        /// </summary>
        /// <value>The calculated price per unit with discounts applied, including taxes.</value>
        [DataMember(Name = "unitPriceIncludingTax", EmitDefaultValue = false)]
        public decimal UnitPriceIncludingTax { get; private set; }

        /// <summary>
        /// Returns false as UnitPriceIncludingTax should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUnitPriceIncludingTax()
        {
            return false;
        }
        /// <summary>
        /// The discount allocated to the item, excluding taxes.
        /// </summary>
        /// <value>The discount allocated to the item, excluding taxes.</value>
        [DataMember(Name = "discountExcludingTax", EmitDefaultValue = false)]
        public decimal DiscountExcludingTax { get; private set; }

        /// <summary>
        /// Returns false as DiscountExcludingTax should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDiscountExcludingTax()
        {
            return false;
        }
        /// <summary>
        /// Whether the item required shipping.
        /// </summary>
        /// <value>Whether the item required shipping.</value>
        [DataMember(Name = "shippingRequired", EmitDefaultValue = true)]
        public bool ShippingRequired { get; private set; }

        /// <summary>
        /// Returns false as ShippingRequired should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeShippingRequired()
        {
            return false;
        }
        /// <summary>
        /// The calculated price per unit with discounts applied, excluding taxes.
        /// </summary>
        /// <value>The calculated price per unit with discounts applied, excluding taxes.</value>
        [DataMember(Name = "unitPriceExcludingTax", EmitDefaultValue = false)]
        public decimal UnitPriceExcludingTax { get; private set; }

        /// <summary>
        /// Returns false as UnitPriceExcludingTax should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUnitPriceExcludingTax()
        {
            return false;
        }
        /// <summary>
        /// The name of the product, ideally in the customer&#39;s language.
        /// </summary>
        /// <value>The name of the product, ideally in the customer&#39;s language.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; private set; }

        /// <summary>
        /// Returns false as Name should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeName()
        {
            return false;
        }
        /// <summary>
        /// A map of custom information for the item.
        /// </summary>
        /// <value>A map of custom information for the item.</value>
        [DataMember(Name = "attributes", EmitDefaultValue = false)]
        public Dictionary<string, LineItemAttribute> Attributes { get; private set; }

        /// <summary>
        /// Returns false as Attributes should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAttributes()
        {
            return false;
        }
        /// <summary>
        /// The calculated price per unit with discounts not applied, excluding taxes.
        /// </summary>
        /// <value>The calculated price per unit with discounts not applied, excluding taxes.</value>
        [DataMember(Name = "undiscountedUnitPriceExcludingTax", EmitDefaultValue = false)]
        public decimal UndiscountedUnitPriceExcludingTax { get; private set; }

        /// <summary>
        /// Returns false as UndiscountedUnitPriceExcludingTax should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUndiscountedUnitPriceExcludingTax()
        {
            return false;
        }
        /// <summary>
        /// The line item price with discounts applied, including taxes.
        /// </summary>
        /// <value>The line item price with discounts applied, including taxes.</value>
        [DataMember(Name = "amountIncludingTax", EmitDefaultValue = false)]
        public decimal AmountIncludingTax { get; private set; }

        /// <summary>
        /// Returns false as AmountIncludingTax should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAmountIncludingTax()
        {
            return false;
        }
        /// <summary>
        /// The discount allocated to the item, including taxes.
        /// </summary>
        /// <value>The discount allocated to the item, including taxes.</value>
        [DataMember(Name = "discountIncludingTax", EmitDefaultValue = false)]
        public decimal DiscountIncludingTax { get; private set; }

        /// <summary>
        /// Returns false as DiscountIncludingTax should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDiscountIncludingTax()
        {
            return false;
        }
        /// <summary>
        /// The SKU (stock-keeping unit) of the product.
        /// </summary>
        /// <value>The SKU (stock-keeping unit) of the product.</value>
        [DataMember(Name = "sku", EmitDefaultValue = false)]
        public string Sku { get; private set; }

        /// <summary>
        /// Returns false as Sku should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSku()
        {
            return false;
        }
        /// <summary>
        /// The sum of all taxes applied to the item.
        /// </summary>
        /// <value>The sum of all taxes applied to the item.</value>
        [DataMember(Name = "taxAmount", EmitDefaultValue = false)]
        public decimal TaxAmount { get; private set; }

        /// <summary>
        /// Returns false as TaxAmount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTaxAmount()
        {
            return false;
        }
        /// <summary>
        /// The total tax rate applied to the item, calculated from the rates of all tax lines.
        /// </summary>
        /// <value>The total tax rate applied to the item, calculated from the rates of all tax lines.</value>
        [DataMember(Name = "aggregatedTaxRate", EmitDefaultValue = false)]
        public decimal AggregatedTaxRate { get; private set; }

        /// <summary>
        /// Returns false as AggregatedTaxRate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAggregatedTaxRate()
        {
            return false;
        }
        /// <summary>
        /// The unique identifier of the line item within the set of line items.
        /// </summary>
        /// <value>The unique identifier of the line item within the set of line items.</value>
        [DataMember(Name = "uniqueId", EmitDefaultValue = false)]
        public string UniqueId { get; private set; }

        /// <summary>
        /// Returns false as UniqueId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUniqueId()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LineItem {\n");
            sb.Append("  TaxAmountPerUnit: ").Append(TaxAmountPerUnit).Append("\n");
            sb.Append("  UndiscountedAmountExcludingTax: ").Append(UndiscountedAmountExcludingTax).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  UndiscountedUnitPriceIncludingTax: ").Append(UndiscountedUnitPriceIncludingTax).Append("\n");
            sb.Append("  AmountExcludingTax: ").Append(AmountExcludingTax).Append("\n");
            sb.Append("  UndiscountedAmountIncludingTax: ").Append(UndiscountedAmountIncludingTax).Append("\n");
            sb.Append("  Taxes: ").Append(Taxes).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UnitPriceIncludingTax: ").Append(UnitPriceIncludingTax).Append("\n");
            sb.Append("  DiscountExcludingTax: ").Append(DiscountExcludingTax).Append("\n");
            sb.Append("  ShippingRequired: ").Append(ShippingRequired).Append("\n");
            sb.Append("  UnitPriceExcludingTax: ").Append(UnitPriceExcludingTax).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  UndiscountedUnitPriceExcludingTax: ").Append(UndiscountedUnitPriceExcludingTax).Append("\n");
            sb.Append("  AmountIncludingTax: ").Append(AmountIncludingTax).Append("\n");
            sb.Append("  DiscountIncludingTax: ").Append(DiscountIncludingTax).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  AggregatedTaxRate: ").Append(AggregatedTaxRate).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 150)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 150.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // Sku (string) maxLength
            if (this.Sku != null && this.Sku.Length > 200)
            {
                yield return new ValidationResult("Invalid value for Sku, length must be less than 200.", new [] { "Sku" });
            }

            // UniqueId (string) maxLength
            if (this.UniqueId != null && this.UniqueId.Length > 200)
            {
                yield return new ValidationResult("Invalid value for UniqueId, length must be less than 200.", new [] { "UniqueId" });
            }

            yield break;
        }
    }

}
