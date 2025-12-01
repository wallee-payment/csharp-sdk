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
    /// Label
    /// </summary>
    [DataContract(Name = "Label")]
    public partial class Label : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Label" /> class.
        /// </summary>
        /// <param name="descriptor">descriptor.</param>
        public Label(LabelDescriptor descriptor = default)
        {
            this.Descriptor = descriptor;
        }

        /// <summary>
        /// The label&#39;s content formatted as string.
        /// </summary>
        /// <value>The label&#39;s content formatted as string.</value>
        [DataMember(Name = "contentAsString", EmitDefaultValue = false)]
        public string ContentAsString { get; private set; }

        /// <summary>
        /// Returns false as ContentAsString should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeContentAsString()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Descriptor
        /// </summary>
        [DataMember(Name = "descriptor", EmitDefaultValue = false)]
        public LabelDescriptor Descriptor { get; set; }

        /// <summary>
        /// The label&#39;s actual content.
        /// </summary>
        /// <value>The label&#39;s actual content.</value>
        [DataMember(Name = "content", EmitDefaultValue = true)]
        public Object Content { get; private set; }

        /// <summary>
        /// Returns false as Content should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeContent()
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
            sb.Append("class Label {\n");
            sb.Append("  ContentAsString: ").Append(ContentAsString).Append("\n");
            sb.Append("  Descriptor: ").Append(Descriptor).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
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
