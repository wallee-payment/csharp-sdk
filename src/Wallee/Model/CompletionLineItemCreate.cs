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
    /// CompletionLineItemCreate
    /// </summary>
    [DataContract(Name = "CompletionLineItem.Create")]
    public partial class CompletionLineItemCreate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionLineItemCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CompletionLineItemCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionLineItemCreate" /> class.
        /// </summary>
        /// <param name="amount">The total amount of the line item to be captured, including taxes. (required).</param>
        /// <param name="quantity">The number of items to be captured. (required).</param>
        /// <param name="uniqueId">The unique identifier of the line item within the set of line items. (required).</param>
        public CompletionLineItemCreate(decimal amount = default(decimal), decimal quantity = default(decimal), string uniqueId = default(string))
        {
            this.Amount = amount;
            this.Quantity = quantity;
            // to ensure "uniqueId" is required (not null)
            if (uniqueId == null)
            {
                throw new ArgumentNullException("uniqueId is a required property for CompletionLineItemCreate and cannot be null");
            }
            this.UniqueId = uniqueId;
        }

        /// <summary>
        /// The total amount of the line item to be captured, including taxes.
        /// </summary>
        /// <value>The total amount of the line item to be captured, including taxes.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public decimal Amount { get; set; }

        /// <summary>
        /// The number of items to be captured.
        /// </summary>
        /// <value>The number of items to be captured.</value>
        [DataMember(Name = "quantity", IsRequired = true, EmitDefaultValue = true)]
        public decimal Quantity { get; set; }

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
            sb.Append("class CompletionLineItemCreate {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
            // UniqueId (string) maxLength
            if (this.UniqueId != null && this.UniqueId.Length > 200)
            {
                yield return new ValidationResult("Invalid value for UniqueId, length must be less than 200.", new [] { "UniqueId" });
            }

            yield break;
        }
    }

}
