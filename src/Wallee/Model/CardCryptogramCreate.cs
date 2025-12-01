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
    /// CardCryptogramCreate
    /// </summary>
    [DataContract(Name = "CardCryptogram.Create")]
    public partial class CardCryptogramCreate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardCryptogramCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CardCryptogramCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CardCryptogramCreate" /> class.
        /// </summary>
        /// <param name="eci">The Electronic Commerce Indicator (ECI) represents the authentication level and indicates liability shift during online or card-not-present transactions..</param>
        /// <param name="value">The cryptogram value used for securing card transactions, format varying based on the PAN type. (required).</param>
        public CardCryptogramCreate(string eci = default, string value = default)
        {
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for CardCryptogramCreate and cannot be null");
            }
            this.Value = value;
            this.Eci = eci;
        }

        /// <summary>
        /// The Electronic Commerce Indicator (ECI) represents the authentication level and indicates liability shift during online or card-not-present transactions.
        /// </summary>
        /// <value>The Electronic Commerce Indicator (ECI) represents the authentication level and indicates liability shift during online or card-not-present transactions.</value>
        [DataMember(Name = "eci", EmitDefaultValue = false)]
        public string Eci { get; set; }

        /// <summary>
        /// The cryptogram value used for securing card transactions, format varying based on the PAN type.
        /// </summary>
        /// <value>The cryptogram value used for securing card transactions, format varying based on the PAN type.</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CardCryptogramCreate {\n");
            sb.Append("  Eci: ").Append(Eci).Append("\n");
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
            yield break;
        }
    }

}
