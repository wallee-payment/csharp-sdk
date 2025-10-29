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
    /// LineItemReductionCreate
    /// </summary>
    [DataContract(Name = "LineItemReduction.Create")]
    public partial class LineItemReductionCreate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LineItemReductionCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LineItemReductionCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LineItemReductionCreate" /> class.
        /// </summary>
        /// <param name="quantityReduction">The quantity removed or reduced from the line item. This value reflects the decrease in the item count due to the reduction. (required).</param>
        /// <param name="unitPriceReduction">The monetary amount by which the line item&#39;s unit price is discounted. This reduction adjusts the price without altering the quantity. (required).</param>
        /// <param name="lineItemUniqueId">The unique identifier of the line item to which the reduction is applied. This ID ensures the reduction is accurately associated with the correct item. (required).</param>
        public LineItemReductionCreate(decimal quantityReduction = default(decimal), decimal unitPriceReduction = default(decimal), string lineItemUniqueId = default(string))
        {
            this.QuantityReduction = quantityReduction;
            this.UnitPriceReduction = unitPriceReduction;
            // to ensure "lineItemUniqueId" is required (not null)
            if (lineItemUniqueId == null)
            {
                throw new ArgumentNullException("lineItemUniqueId is a required property for LineItemReductionCreate and cannot be null");
            }
            this.LineItemUniqueId = lineItemUniqueId;
        }

        /// <summary>
        /// The quantity removed or reduced from the line item. This value reflects the decrease in the item count due to the reduction.
        /// </summary>
        /// <value>The quantity removed or reduced from the line item. This value reflects the decrease in the item count due to the reduction.</value>
        [DataMember(Name = "quantityReduction", IsRequired = true, EmitDefaultValue = true)]
        public decimal QuantityReduction { get; set; }

        /// <summary>
        /// The monetary amount by which the line item&#39;s unit price is discounted. This reduction adjusts the price without altering the quantity.
        /// </summary>
        /// <value>The monetary amount by which the line item&#39;s unit price is discounted. This reduction adjusts the price without altering the quantity.</value>
        [DataMember(Name = "unitPriceReduction", IsRequired = true, EmitDefaultValue = true)]
        public decimal UnitPriceReduction { get; set; }

        /// <summary>
        /// The unique identifier of the line item to which the reduction is applied. This ID ensures the reduction is accurately associated with the correct item.
        /// </summary>
        /// <value>The unique identifier of the line item to which the reduction is applied. This ID ensures the reduction is accurately associated with the correct item.</value>
        [DataMember(Name = "lineItemUniqueId", IsRequired = true, EmitDefaultValue = true)]
        public string LineItemUniqueId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LineItemReductionCreate {\n");
            sb.Append("  QuantityReduction: ").Append(QuantityReduction).Append("\n");
            sb.Append("  UnitPriceReduction: ").Append(UnitPriceReduction).Append("\n");
            sb.Append("  LineItemUniqueId: ").Append(LineItemUniqueId).Append("\n");
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
            // LineItemUniqueId (string) maxLength
            if (this.LineItemUniqueId != null && this.LineItemUniqueId.Length > 200)
            {
                yield return new ValidationResult("Invalid value for LineItemUniqueId, length must be less than 200.", new [] { "LineItemUniqueId" });
            }

            yield break;
        }
    }

}
