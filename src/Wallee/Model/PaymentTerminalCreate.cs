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
    /// PaymentTerminalCreate
    /// </summary>
    [DataContract(Name = "PaymentTerminal.Create")]
    public partial class PaymentTerminalCreate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTerminalCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentTerminalCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTerminalCreate" /> class.
        /// </summary>
        /// <param name="name">The name used to identify the payment terminal..</param>
        /// <param name="identifier">The unique identifier of the terminal, that is displayed on the device..</param>
        /// <param name="configurationVersion">The configuration that is assigned to the terminal and determines how it works..</param>
        /// <param name="locationVersion">The physical location where the terminal is used..</param>
        /// <param name="externalId">A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result. (required).</param>
        /// <param name="type">The type of the payment terminal. (required).</param>
        public PaymentTerminalCreate(string name = default(string), string identifier = default(string), long configurationVersion = default(long), long locationVersion = default(long), string externalId = default(string), long type = default(long))
        {
            // to ensure "externalId" is required (not null)
            if (externalId == null)
            {
                throw new ArgumentNullException("externalId is a required property for PaymentTerminalCreate and cannot be null");
            }
            this.ExternalId = externalId;
            this.Type = type;
            this.Name = name;
            this.Identifier = identifier;
            this.ConfigurationVersion = configurationVersion;
            this.LocationVersion = locationVersion;
        }

        /// <summary>
        /// The name used to identify the payment terminal.
        /// </summary>
        /// <value>The name used to identify the payment terminal.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The unique identifier of the terminal, that is displayed on the device.
        /// </summary>
        /// <value>The unique identifier of the terminal, that is displayed on the device.</value>
        [DataMember(Name = "identifier", EmitDefaultValue = false)]
        public string Identifier { get; set; }

        /// <summary>
        /// The configuration that is assigned to the terminal and determines how it works.
        /// </summary>
        /// <value>The configuration that is assigned to the terminal and determines how it works.</value>
        [DataMember(Name = "configurationVersion", EmitDefaultValue = false)]
        public long ConfigurationVersion { get; set; }

        /// <summary>
        /// The physical location where the terminal is used.
        /// </summary>
        /// <value>The physical location where the terminal is used.</value>
        [DataMember(Name = "locationVersion", EmitDefaultValue = false)]
        public long LocationVersion { get; set; }

        /// <summary>
        /// A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.
        /// </summary>
        /// <value>A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.</value>
        [DataMember(Name = "externalId", IsRequired = true, EmitDefaultValue = true)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The type of the payment terminal.
        /// </summary>
        /// <value>The type of the payment terminal.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public long Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentTerminalCreate {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  ConfigurationVersion: ").Append(ConfigurationVersion).Append("\n");
            sb.Append("  LocationVersion: ").Append(LocationVersion).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 100)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 100.", new [] { "Name" });
            }

            yield break;
        }
    }

}
