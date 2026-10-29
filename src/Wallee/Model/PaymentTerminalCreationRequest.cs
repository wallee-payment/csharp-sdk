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
    /// PaymentTerminalCreationRequest
    /// </summary>
    [DataContract(Name = "PaymentTerminalCreationRequest")]
    public partial class PaymentTerminalCreationRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTerminalCreationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentTerminalCreationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTerminalCreationRequest" /> class.
        /// </summary>
        /// <param name="varEnvironment">The environment used to create the payment terminal (TEST/PRODUCTION). (required).</param>
        /// <param name="varConfiguration">The configuration that is assigned to the terminal and determines how it works. (required).</param>
        /// <param name="name">The name used to identify the payment terminal. (required).</param>
        /// <param name="externalId">The ID assigned by the external system to this payment terminal (required).</param>
        /// <param name="location">The physical location where the terminal is used. (required).</param>
        public PaymentTerminalCreationRequest(string varEnvironment = default, long varConfiguration = default, string name = default, string externalId = default, long location = default)
        {
            // to ensure "varEnvironment" is required (not null)
            if (varEnvironment == null)
            {
                throw new ArgumentNullException("varEnvironment is a required property for PaymentTerminalCreationRequest and cannot be null");
            }
            this.VarEnvironment = varEnvironment;
            this.VarConfiguration = varConfiguration;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for PaymentTerminalCreationRequest and cannot be null");
            }
            this.Name = name;
            // to ensure "externalId" is required (not null)
            if (externalId == null)
            {
                throw new ArgumentNullException("externalId is a required property for PaymentTerminalCreationRequest and cannot be null");
            }
            this.ExternalId = externalId;
            this.Location = location;
        }

        /// <summary>
        /// The environment used to create the payment terminal (TEST/PRODUCTION).
        /// </summary>
        /// <value>The environment used to create the payment terminal (TEST/PRODUCTION).</value>
        [DataMember(Name = "environment", IsRequired = true, EmitDefaultValue = true)]
        public string VarEnvironment { get; set; }

        /// <summary>
        /// The configuration that is assigned to the terminal and determines how it works.
        /// </summary>
        /// <value>The configuration that is assigned to the terminal and determines how it works.</value>
        [DataMember(Name = "configuration", IsRequired = true, EmitDefaultValue = true)]
        public long VarConfiguration { get; set; }

        /// <summary>
        /// The name used to identify the payment terminal.
        /// </summary>
        /// <value>The name used to identify the payment terminal.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The ID assigned by the external system to this payment terminal
        /// </summary>
        /// <value>The ID assigned by the external system to this payment terminal</value>
        [DataMember(Name = "externalId", IsRequired = true, EmitDefaultValue = true)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The physical location where the terminal is used.
        /// </summary>
        /// <value>The physical location where the terminal is used.</value>
        [DataMember(Name = "location", IsRequired = true, EmitDefaultValue = true)]
        public long Location { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentTerminalCreationRequest {\n");
            sb.Append("  VarEnvironment: ").Append(VarEnvironment).Append("\n");
            sb.Append("  VarConfiguration: ").Append(VarConfiguration).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
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
            if (this.VarEnvironment != null) {
                // VarEnvironment (string) pattern
                Regex regexVarEnvironment = new Regex(@"^(TEST|PRODUCTION)$", RegexOptions.CultureInvariant);
                if (!regexVarEnvironment.Match(this.VarEnvironment).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VarEnvironment, must match a pattern of " + regexVarEnvironment, new [] { "VarEnvironment" });
                }
            }

            yield break;
        }
    }

}
