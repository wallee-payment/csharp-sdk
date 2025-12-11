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
    /// RenderedTerminalTransactionSummary
    /// </summary>
    [DataContract(Name = "RenderedTerminalTransactionSummary")]
    public partial class RenderedTerminalTransactionSummary : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenderedTerminalTransactionSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public RenderedTerminalTransactionSummary()
        {
        }

        /// <summary>
        /// The data property contains the binary data of the receipt document encoded as base 64 encoded string.
        /// </summary>
        /// <value>The data property contains the binary data of the receipt document encoded as base 64 encoded string.</value>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public byte[] Data { get; private set; }

        /// <summary>
        /// Returns false as Data should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeData()
        {
            return false;
        }
        /// <summary>
        /// The mime type indicates the format of the receipt document. The mime type depends on the requested receipt format.
        /// </summary>
        /// <value>The mime type indicates the format of the receipt document. The mime type depends on the requested receipt format.</value>
        [DataMember(Name = "mimeType", EmitDefaultValue = false)]
        public string MimeType { get; private set; }

        /// <summary>
        /// Returns false as MimeType should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMimeType()
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
            sb.Append("class RenderedTerminalTransactionSummary {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  MimeType: ").Append(MimeType).Append("\n");
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
