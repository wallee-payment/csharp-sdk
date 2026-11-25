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
    /// PaymentTerminalUpdateRequest
    /// </summary>
    [DataContract(Name = "PaymentTerminalUpdateRequest")]
    public partial class PaymentTerminalUpdateRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTerminalUpdateRequest" /> class.
        /// </summary>
        /// <param name="varConfiguration">The configuration that is assigned to the terminal and determines how it works..</param>
        /// <param name="name">The name used to identify the payment terminal..</param>
        /// <param name="varVersion">The version is used for optimistic locking and incremented whenever the payment terminal is updated..</param>
        public PaymentTerminalUpdateRequest(long varConfiguration = default, string name = default, int varVersion = default)
        {
            this.VarConfiguration = varConfiguration;
            this.Name = name;
            this.VarVersion = varVersion;
        }

        /// <summary>
        /// The configuration that is assigned to the terminal and determines how it works.
        /// </summary>
        /// <value>The configuration that is assigned to the terminal and determines how it works.</value>
        [DataMember(Name = "configuration", EmitDefaultValue = false)]
        public long VarConfiguration { get; set; }

        /// <summary>
        /// The name used to identify the payment terminal.
        /// </summary>
        /// <value>The name used to identify the payment terminal.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The version is used for optimistic locking and incremented whenever the payment terminal is updated.
        /// </summary>
        /// <value>The version is used for optimistic locking and incremented whenever the payment terminal is updated.</value>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int VarVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentTerminalUpdateRequest {\n");
            sb.Append("  VarConfiguration: ").Append(VarConfiguration).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
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
