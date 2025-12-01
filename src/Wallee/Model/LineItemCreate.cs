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
    /// LineItemCreate
    /// </summary>
    [DataContract(Name = "LineItem.Create")]
    public partial class LineItemCreate : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public LineItemType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LineItemCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LineItemCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LineItemCreate" /> class.
        /// </summary>
        /// <param name="shippingRequired">Whether the item required shipping..</param>
        /// <param name="quantity">The number of items that were purchased. (required).</param>
        /// <param name="name">The name of the product, ideally in the customer&#39;s language. (required).</param>
        /// <param name="taxes">A set of tax lines, each of which specifies a tax applied to the item..</param>
        /// <param name="attributes">A map of custom information for the item..</param>
        /// <param name="amountIncludingTax">The line item price with discounts applied, including taxes. (required).</param>
        /// <param name="discountIncludingTax">The discount allocated to the item, including taxes..</param>
        /// <param name="sku">The SKU (stock-keeping unit) of the product..</param>
        /// <param name="type">type (required).</param>
        /// <param name="uniqueId">The unique identifier of the line item within the set of line items. (required).</param>
        public LineItemCreate(bool shippingRequired = default, decimal quantity = default, string name = default, List<TaxCreate> taxes = default, Dictionary<string, LineItemAttributeCreate> attributes = default, decimal amountIncludingTax = default, decimal discountIncludingTax = default, string sku = default, LineItemType type = default, string uniqueId = default)
        {
            this.Quantity = quantity;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for LineItemCreate and cannot be null");
            }
            this.Name = name;
            this.AmountIncludingTax = amountIncludingTax;
            this.Type = type;
            // to ensure "uniqueId" is required (not null)
            if (uniqueId == null)
            {
                throw new ArgumentNullException("uniqueId is a required property for LineItemCreate and cannot be null");
            }
            this.UniqueId = uniqueId;
            this.ShippingRequired = shippingRequired;
            this.Taxes = taxes;
            this.Attributes = attributes;
            this.DiscountIncludingTax = discountIncludingTax;
            this.Sku = sku;
        }

        /// <summary>
        /// Whether the item required shipping.
        /// </summary>
        /// <value>Whether the item required shipping.</value>
        [DataMember(Name = "shippingRequired", EmitDefaultValue = true)]
        public bool ShippingRequired { get; set; }

        /// <summary>
        /// The number of items that were purchased.
        /// </summary>
        /// <value>The number of items that were purchased.</value>
        [DataMember(Name = "quantity", IsRequired = true, EmitDefaultValue = true)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// The name of the product, ideally in the customer&#39;s language.
        /// </summary>
        /// <value>The name of the product, ideally in the customer&#39;s language.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// A set of tax lines, each of which specifies a tax applied to the item.
        /// </summary>
        /// <value>A set of tax lines, each of which specifies a tax applied to the item.</value>
        [DataMember(Name = "taxes", EmitDefaultValue = false)]
        public List<TaxCreate> Taxes { get; set; }

        /// <summary>
        /// A map of custom information for the item.
        /// </summary>
        /// <value>A map of custom information for the item.</value>
        [DataMember(Name = "attributes", EmitDefaultValue = false)]
        public Dictionary<string, LineItemAttributeCreate> Attributes { get; set; }

        /// <summary>
        /// The line item price with discounts applied, including taxes.
        /// </summary>
        /// <value>The line item price with discounts applied, including taxes.</value>
        [DataMember(Name = "amountIncludingTax", IsRequired = true, EmitDefaultValue = true)]
        public decimal AmountIncludingTax { get; set; }

        /// <summary>
        /// The discount allocated to the item, including taxes.
        /// </summary>
        /// <value>The discount allocated to the item, including taxes.</value>
        [DataMember(Name = "discountIncludingTax", EmitDefaultValue = false)]
        public decimal DiscountIncludingTax { get; set; }

        /// <summary>
        /// The SKU (stock-keeping unit) of the product.
        /// </summary>
        /// <value>The SKU (stock-keeping unit) of the product.</value>
        [DataMember(Name = "sku", EmitDefaultValue = false)]
        public string Sku { get; set; }

        /// <summary>
        /// The unique identifier of the line item within the set of line items.
        /// </summary>
        /// <value>The unique identifier of the line item within the set of line items.</value>
        [DataMember(Name = "uniqueId", IsRequired = true, EmitDefaultValue = true)]
        public string UniqueId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LineItemCreate {\n");
            sb.Append("  ShippingRequired: ").Append(ShippingRequired).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Taxes: ").Append(Taxes).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  AmountIncludingTax: ").Append(AmountIncludingTax).Append("\n");
            sb.Append("  DiscountIncludingTax: ").Append(DiscountIncludingTax).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
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
