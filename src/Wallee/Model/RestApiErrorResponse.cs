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
    /// RestApiErrorResponse
    /// </summary>
    [DataContract(Name = "RestApiErrorResponse")]
    public partial class RestApiErrorResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestApiErrorResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public RestApiErrorResponse()
        {
        }

        /// <summary>
        /// The date and time when the error occurred.
        /// </summary>
        /// <value>The date and time when the error occurred.</value>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public DateTime Date { get; private set; }

        /// <summary>
        /// Returns false as Date should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDate()
        {
            return false;
        }
        /// <summary>
        /// A brief explanation of the error that can be used to programmatically handle it.
        /// </summary>
        /// <value>A brief explanation of the error that can be used to programmatically handle it.</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; private set; }

        /// <summary>
        /// Returns false as Code should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCode()
        {
            return false;
        }
        /// <summary>
        /// The unique identifier of the error.
        /// </summary>
        /// <value>The unique identifier of the error.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// A human-readable message providing more details about the error.
        /// </summary>
        /// <value>A human-readable message providing more details about the error.</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; private set; }

        /// <summary>
        /// Returns false as Message should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMessage()
        {
            return false;
        }
        /// <summary>
        /// A map of errors where the key represents the error identifier (such as field name or error context) and the value contains the detailed error message.
        /// </summary>
        /// <value>A map of errors where the key represents the error identifier (such as field name or error context) and the value contains the detailed error message.</value>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public Dictionary<string, string> Errors { get; private set; }

        /// <summary>
        /// Returns false as Errors should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeErrors()
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
            sb.Append("class RestApiErrorResponse {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
