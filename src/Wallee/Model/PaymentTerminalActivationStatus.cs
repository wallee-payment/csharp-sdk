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
    /// PaymentTerminalActivationStatus
    /// </summary>
    [DataContract(Name = "PaymentTerminalActivationStatus")]
    public partial class PaymentTerminalActivationStatus : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTerminalActivationStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentTerminalActivationStatus()
        {
        }

        /// <summary>
        /// Whether the activation code is active on the acquirer side
        /// </summary>
        /// <value>Whether the activation code is active on the acquirer side</value>
        [DataMember(Name = "activationCodeActive", EmitDefaultValue = true)]
        public bool ActivationCodeActive { get; private set; }

        /// <summary>
        /// Returns false as ActivationCodeActive should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeActivationCodeActive()
        {
            return false;
        }
        /// <summary>
        /// The environment (TEST/PRODUCTION) the payment terminal belongs to.
        /// </summary>
        /// <value>The environment (TEST/PRODUCTION) the payment terminal belongs to.</value>
        [DataMember(Name = "environment", EmitDefaultValue = false)]
        public string VarEnvironment { get; private set; }

        /// <summary>
        /// Returns false as VarEnvironment should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVarEnvironment()
        {
            return false;
        }
        /// <summary>
        /// Time when the payment terminal got activated on acquirer side
        /// </summary>
        /// <value>Time when the payment terminal got activated on acquirer side</value>
        [DataMember(Name = "activatedOn", EmitDefaultValue = false)]
        public DateTime ActivatedOn { get; private set; }

        /// <summary>
        /// Returns false as ActivatedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeActivatedOn()
        {
            return false;
        }
        /// <summary>
        /// The ID of the location that the payment terminal belongs to
        /// </summary>
        /// <value>The ID of the location that the payment terminal belongs to</value>
        [DataMember(Name = "locationId", EmitDefaultValue = false)]
        public long LocationId { get; private set; }

        /// <summary>
        /// Returns false as LocationId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLocationId()
        {
            return false;
        }
        /// <summary>
        /// Activation code that is used to link the terminal
        /// </summary>
        /// <value>Activation code that is used to link the terminal</value>
        [DataMember(Name = "activationCode", EmitDefaultValue = false)]
        public string ActivationCode { get; private set; }

        /// <summary>
        /// Returns false as ActivationCode should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeActivationCode()
        {
            return false;
        }
        /// <summary>
        /// The ID of the configuration that the payment terminal belongs to
        /// </summary>
        /// <value>The ID of the configuration that the payment terminal belongs to</value>
        [DataMember(Name = "configurationId", EmitDefaultValue = false)]
        public long ConfigurationId { get; private set; }

        /// <summary>
        /// Returns false as ConfigurationId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeConfigurationId()
        {
            return false;
        }
        /// <summary>
        /// The ID of the payment terminal
        /// </summary>
        /// <value>The ID of the payment terminal</value>
        [DataMember(Name = "terminalId", EmitDefaultValue = false)]
        public string TerminalId { get; private set; }

        /// <summary>
        /// Returns false as TerminalId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTerminalId()
        {
            return false;
        }
        /// <summary>
        /// The ID of the space that the payment terminal belongs to
        /// </summary>
        /// <value>The ID of the space that the payment terminal belongs to</value>
        [DataMember(Name = "space", EmitDefaultValue = false)]
        public long Space { get; private set; }

        /// <summary>
        /// Returns false as Space should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSpace()
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
            sb.Append("class PaymentTerminalActivationStatus {\n");
            sb.Append("  ActivationCodeActive: ").Append(ActivationCodeActive).Append("\n");
            sb.Append("  VarEnvironment: ").Append(VarEnvironment).Append("\n");
            sb.Append("  ActivatedOn: ").Append(ActivatedOn).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  ActivationCode: ").Append(ActivationCode).Append("\n");
            sb.Append("  ConfigurationId: ").Append(ConfigurationId).Append("\n");
            sb.Append("  TerminalId: ").Append(TerminalId).Append("\n");
            sb.Append("  Space: ").Append(Space).Append("\n");
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
