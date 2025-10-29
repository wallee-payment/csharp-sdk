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
    /// RestAddressFormat
    /// </summary>
    [DataContract(Name = "RestAddressFormat")]
    public partial class RestAddressFormat : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestAddressFormat" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public RestAddressFormat()
        {
        }

        /// <summary>
        /// A list of sample post codes.
        /// </summary>
        /// <value>A list of sample post codes.</value>
        [DataMember(Name = "postCodeExamples", EmitDefaultValue = false)]
        public List<string> PostCodeExamples { get; private set; }

        /// <summary>
        /// Returns false as PostCodeExamples should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePostCodeExamples()
        {
            return false;
        }
        /// <summary>
        /// The fields that are required in the address format.
        /// </summary>
        /// <value>The fields that are required in the address format.</value>
        [DataMember(Name = "requiredFields", EmitDefaultValue = false)]
        public List<RestAddressFormatField> RequiredFields { get; private set; }

        /// <summary>
        /// Returns false as RequiredFields should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRequiredFields()
        {
            return false;
        }
        /// <summary>
        /// The fields that are used in the address format.
        /// </summary>
        /// <value>The fields that are used in the address format.</value>
        [DataMember(Name = "usedFields", EmitDefaultValue = false)]
        public List<RestAddressFormatField> UsedFields { get; private set; }

        /// <summary>
        /// Returns false as UsedFields should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUsedFields()
        {
            return false;
        }
        /// <summary>
        /// The regular expression to validate post codes.
        /// </summary>
        /// <value>The regular expression to validate post codes.</value>
        [DataMember(Name = "postCodeRegex", EmitDefaultValue = false)]
        public string PostCodeRegex { get; private set; }

        /// <summary>
        /// Returns false as PostCodeRegex should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePostCodeRegex()
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
            sb.Append("class RestAddressFormat {\n");
            sb.Append("  PostCodeExamples: ").Append(PostCodeExamples).Append("\n");
            sb.Append("  RequiredFields: ").Append(RequiredFields).Append("\n");
            sb.Append("  UsedFields: ").Append(UsedFields).Append("\n");
            sb.Append("  PostCodeRegex: ").Append(PostCodeRegex).Append("\n");
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
