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
    /// PaymentAdjustment
    /// </summary>
    [DataContract(Name = "PaymentAdjustment")]
    public partial class PaymentAdjustment : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentAdjustment" /> class.
        /// </summary>
        /// <param name="tax">tax.</param>
        public PaymentAdjustment(Tax tax = default(Tax))
        {
            this.Tax = tax;
        }

        /// <summary>
        /// The adjustment&#39;s amount, excluding taxes.
        /// </summary>
        /// <value>The adjustment&#39;s amount, excluding taxes.</value>
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
        /// The percentage rate used to calculate the adjustment amount.
        /// </summary>
        /// <value>The percentage rate used to calculate the adjustment amount.</value>
        [DataMember(Name = "rateInPercentage", EmitDefaultValue = false)]
        public decimal RateInPercentage { get; private set; }

        /// <summary>
        /// Returns false as RateInPercentage should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRateInPercentage()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Tax
        /// </summary>
        [DataMember(Name = "tax", EmitDefaultValue = false)]
        public Tax Tax { get; set; }

        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// The adjustment&#39;s amount, including taxes.
        /// </summary>
        /// <value>The adjustment&#39;s amount, including taxes.</value>
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
        /// The type of the adjustment.
        /// </summary>
        /// <value>The type of the adjustment.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public long Type { get; private set; }

        /// <summary>
        /// Returns false as Type should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeType()
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
            sb.Append("class PaymentAdjustment {\n");
            sb.Append("  AmountExcludingTax: ").Append(AmountExcludingTax).Append("\n");
            sb.Append("  RateInPercentage: ").Append(RateInPercentage).Append("\n");
            sb.Append("  Tax: ").Append(Tax).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AmountIncludingTax: ").Append(AmountIncludingTax).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            // RateInPercentage (decimal) maximum
            if (this.RateInPercentage > (decimal)100)
            {
                yield return new ValidationResult("Invalid value for RateInPercentage, must be a value less than or equal to 100.", new [] { "RateInPercentage" });
            }

            yield break;
        }
    }

}
