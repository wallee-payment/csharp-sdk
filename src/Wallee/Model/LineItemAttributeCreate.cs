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
    /// LineItemAttributeCreate
    /// </summary>
    [DataContract(Name = "LineItemAttribute.Create")]
    public partial class LineItemAttributeCreate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LineItemAttributeCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LineItemAttributeCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LineItemAttributeCreate" /> class.
        /// </summary>
        /// <param name="label">The label describing the line item attribute. (required).</param>
        /// <param name="value">The value of the line item attribute. (required).</param>
        public LineItemAttributeCreate(string label = default, string value = default)
        {
            // to ensure "label" is required (not null)
            if (label == null)
            {
                throw new ArgumentNullException("label is a required property for LineItemAttributeCreate and cannot be null");
            }
            this.Label = label;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for LineItemAttributeCreate and cannot be null");
            }
            this.Value = value;
        }

        /// <summary>
        /// The label describing the line item attribute.
        /// </summary>
        /// <value>The label describing the line item attribute.</value>
        [DataMember(Name = "label", IsRequired = true, EmitDefaultValue = true)]
        public string Label { get; set; }

        /// <summary>
        /// The value of the line item attribute.
        /// </summary>
        /// <value>The value of the line item attribute.</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LineItemAttributeCreate {\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            // Label (string) maxLength
            if (this.Label != null && this.Label.Length > 512)
            {
                yield return new ValidationResult("Invalid value for Label, length must be less than 512.", new [] { "Label" });
            }

            // Value (string) maxLength
            if (this.Value != null && this.Value.Length > 512)
            {
                yield return new ValidationResult("Invalid value for Value, length must be less than 512.", new [] { "Value" });
            }

            yield break;
        }
    }

}
