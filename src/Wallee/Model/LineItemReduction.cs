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
    /// LineItemReduction
    /// </summary>
    [DataContract(Name = "LineItemReduction")]
    public partial class LineItemReduction : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LineItemReduction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public LineItemReduction()
        {
        }

        /// <summary>
        /// The quantity removed or reduced from the line item. This value reflects the decrease in the item count due to the reduction.
        /// </summary>
        /// <value>The quantity removed or reduced from the line item. This value reflects the decrease in the item count due to the reduction.</value>
        [DataMember(Name = "quantityReduction", EmitDefaultValue = false)]
        public decimal QuantityReduction { get; private set; }

        /// <summary>
        /// Returns false as QuantityReduction should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeQuantityReduction()
        {
            return false;
        }
        /// <summary>
        /// The monetary amount by which the line item&#39;s unit price is discounted. This reduction adjusts the price without altering the quantity.
        /// </summary>
        /// <value>The monetary amount by which the line item&#39;s unit price is discounted. This reduction adjusts the price without altering the quantity.</value>
        [DataMember(Name = "unitPriceReduction", EmitDefaultValue = false)]
        public decimal UnitPriceReduction { get; private set; }

        /// <summary>
        /// Returns false as UnitPriceReduction should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUnitPriceReduction()
        {
            return false;
        }
        /// <summary>
        /// The unique identifier of the line item to which the reduction is applied. This ID ensures the reduction is accurately associated with the correct item.
        /// </summary>
        /// <value>The unique identifier of the line item to which the reduction is applied. This ID ensures the reduction is accurately associated with the correct item.</value>
        [DataMember(Name = "lineItemUniqueId", EmitDefaultValue = false)]
        public string LineItemUniqueId { get; private set; }

        /// <summary>
        /// Returns false as LineItemUniqueId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLineItemUniqueId()
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
            sb.Append("class LineItemReduction {\n");
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
