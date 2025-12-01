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
    /// PaymentTerminal
    /// </summary>
    [DataContract(Name = "PaymentTerminal")]
    public partial class PaymentTerminal : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public PaymentTerminalState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTerminal" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="configurationVersion">configurationVersion.</param>
        /// <param name="locationVersion">locationVersion.</param>
        /// <param name="state">state.</param>
        public PaymentTerminal(PaymentTerminalType type = default, PaymentTerminalConfigurationVersion configurationVersion = default, PaymentTerminalLocationVersion locationVersion = default, PaymentTerminalState? state = default)
        {
            this.Type = type;
            this.ConfigurationVersion = configurationVersion;
            this.LocationVersion = locationVersion;
            this.State = state;
        }

        /// <summary>
        /// The unique identifier of the terminal, that is displayed on the device.
        /// </summary>
        /// <value>The unique identifier of the terminal, that is displayed on the device.</value>
        [DataMember(Name = "identifier", EmitDefaultValue = false)]
        public string Identifier { get; private set; }

        /// <summary>
        /// Returns false as Identifier should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIdentifier()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.
        /// </summary>
        /// <value>The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.</value>
        [DataMember(Name = "plannedPurgeDate", EmitDefaultValue = false)]
        public DateTime PlannedPurgeDate { get; private set; }

        /// <summary>
        /// Returns false as PlannedPurgeDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePlannedPurgeDate()
        {
            return false;
        }
        /// <summary>
        /// A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.
        /// </summary>
        /// <value>A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.</value>
        [DataMember(Name = "externalId", EmitDefaultValue = false)]
        public string ExternalId { get; private set; }

        /// <summary>
        /// Returns false as ExternalId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeExternalId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public PaymentTerminalType Type { get; set; }

        /// <summary>
        /// The name of the device that is currently linked to the payment terminal.
        /// </summary>
        /// <value>The name of the device that is currently linked to the payment terminal.</value>
        [DataMember(Name = "deviceName", EmitDefaultValue = false)]
        public string DeviceName { get; private set; }

        /// <summary>
        /// Returns false as DeviceName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDeviceName()
        {
            return false;
        }
        /// <summary>
        /// The version is used for optimistic locking and incremented whenever the object is updated.
        /// </summary>
        /// <value>The version is used for optimistic locking and incremented whenever the object is updated.</value>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int VarVersion { get; private set; }

        /// <summary>
        /// Returns false as VarVersion should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVarVersion()
        {
            return false;
        }
        /// <summary>
        /// The serial number of the device that is currently linked to the payment terminal.
        /// </summary>
        /// <value>The serial number of the device that is currently linked to the payment terminal.</value>
        [DataMember(Name = "deviceSerialNumber", EmitDefaultValue = false)]
        public string DeviceSerialNumber { get; private set; }

        /// <summary>
        /// Returns false as DeviceSerialNumber should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDeviceSerialNumber()
        {
            return false;
        }
        /// <summary>
        /// The ID of the space this object belongs to.
        /// </summary>
        /// <value>The ID of the space this object belongs to.</value>
        [DataMember(Name = "linkedSpaceId", EmitDefaultValue = false)]
        public long LinkedSpaceId { get; private set; }

        /// <summary>
        /// Returns false as LinkedSpaceId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLinkedSpaceId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ConfigurationVersion
        /// </summary>
        [DataMember(Name = "configurationVersion", EmitDefaultValue = false)]
        public PaymentTerminalConfigurationVersion ConfigurationVersion { get; set; }

        /// <summary>
        /// Gets or Sets LocationVersion
        /// </summary>
        [DataMember(Name = "locationVersion", EmitDefaultValue = false)]
        public PaymentTerminalLocationVersion LocationVersion { get; set; }

        /// <summary>
        /// The default currency of the terminal.
        /// </summary>
        /// <value>The default currency of the terminal.</value>
        [DataMember(Name = "defaultCurrency", EmitDefaultValue = false)]
        public string DefaultCurrency { get; private set; }

        /// <summary>
        /// Returns false as DefaultCurrency should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDefaultCurrency()
        {
            return false;
        }
        /// <summary>
        /// The name used to identify the payment terminal.
        /// </summary>
        /// <value>The name used to identify the payment terminal.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; private set; }

        /// <summary>
        /// Returns false as Name should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeName()
        {
            return false;
        }
        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
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
            sb.Append("class PaymentTerminal {\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DeviceName: ").Append(DeviceName).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  DeviceSerialNumber: ").Append(DeviceSerialNumber).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  ConfigurationVersion: ").Append(ConfigurationVersion).Append("\n");
            sb.Append("  LocationVersion: ").Append(LocationVersion).Append("\n");
            sb.Append("  DefaultCurrency: ").Append(DefaultCurrency).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
