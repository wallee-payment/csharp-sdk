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
    /// PaymentTerminalConfigurationVersion
    /// </summary>
    [DataContract(Name = "PaymentTerminalConfigurationVersion")]
    public partial class PaymentTerminalConfigurationVersion : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public PaymentTerminalConfigurationVersionState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTerminalConfigurationVersion" /> class.
        /// </summary>
        /// <param name="varConfiguration">varConfiguration.</param>
        /// <param name="state">state.</param>
        public PaymentTerminalConfigurationVersion(PaymentTerminalConfiguration varConfiguration = default(PaymentTerminalConfiguration), PaymentTerminalConfigurationVersionState? state = default(PaymentTerminalConfigurationVersionState?))
        {
            this.VarConfiguration = varConfiguration;
            this.State = state;
        }

        /// <summary>
        /// The start time of the terminal&#39;s maintenance window.
        /// </summary>
        /// <value>The start time of the terminal&#39;s maintenance window.</value>
        [DataMember(Name = "maintenanceWindowStart", EmitDefaultValue = false)]
        public string MaintenanceWindowStart { get; private set; }

        /// <summary>
        /// Returns false as MaintenanceWindowStart should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMaintenanceWindowStart()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets VarConfiguration
        /// </summary>
        [DataMember(Name = "configuration", EmitDefaultValue = false)]
        public PaymentTerminalConfiguration VarConfiguration { get; set; }

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
        /// The time zone of the payment terminal used to determine the maintenance window.
        /// </summary>
        /// <value>The time zone of the payment terminal used to determine the maintenance window.</value>
        [DataMember(Name = "timeZone", EmitDefaultValue = false)]
        public string VarTimeZone { get; private set; }

        /// <summary>
        /// Returns false as VarTimeZone should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVarTimeZone()
        {
            return false;
        }
        /// <summary>
        /// Whether payment terminals are immediately updated to this configuration version. If not, it will be applied during the maintenance window.
        /// </summary>
        /// <value>Whether payment terminals are immediately updated to this configuration version. If not, it will be applied during the maintenance window.</value>
        [DataMember(Name = "versionAppliedImmediately", EmitDefaultValue = true)]
        public bool VersionAppliedImmediately { get; private set; }

        /// <summary>
        /// Returns false as VersionAppliedImmediately should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVersionAppliedImmediately()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the object was created.
        /// </summary>
        /// <value>The date and time when the object was created.</value>
        [DataMember(Name = "createdOn", EmitDefaultValue = false)]
        public DateTime CreatedOn { get; private set; }

        /// <summary>
        /// Returns false as CreatedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedOn()
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
        /// The payment connector configurations that are available on the payment terminal.
        /// </summary>
        /// <value>The payment connector configurations that are available on the payment terminal.</value>
        [DataMember(Name = "connectorConfigurations", EmitDefaultValue = false)]
        public List<long> ConnectorConfigurations { get; private set; }

        /// <summary>
        /// Returns false as ConnectorConfigurations should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeConnectorConfigurations()
        {
            return false;
        }
        /// <summary>
        /// The ID of the user the payment terminal configuration version was created by.
        /// </summary>
        /// <value>The ID of the user the payment terminal configuration version was created by.</value>
        [DataMember(Name = "createdBy", EmitDefaultValue = false)]
        public long CreatedBy { get; private set; }

        /// <summary>
        /// Returns false as CreatedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedBy()
        {
            return false;
        }
        /// <summary>
        /// The default currency that is used if none is set on the payment terminal itself. If it is empty, the currency is derived from the location of the terminal.
        /// </summary>
        /// <value>The default currency that is used if none is set on the payment terminal itself. If it is empty, the currency is derived from the location of the terminal.</value>
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
        /// The permitted duration of the terminal&#39;s maintenance window.
        /// </summary>
        /// <value>The permitted duration of the terminal&#39;s maintenance window.</value>
        [DataMember(Name = "maintenanceWindowDuration", EmitDefaultValue = false)]
        public string MaintenanceWindowDuration { get; private set; }

        /// <summary>
        /// Returns false as MaintenanceWindowDuration should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMaintenanceWindowDuration()
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
            sb.Append("class PaymentTerminalConfigurationVersion {\n");
            sb.Append("  MaintenanceWindowStart: ").Append(MaintenanceWindowStart).Append("\n");
            sb.Append("  VarConfiguration: ").Append(VarConfiguration).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  VarTimeZone: ").Append(VarTimeZone).Append("\n");
            sb.Append("  VersionAppliedImmediately: ").Append(VersionAppliedImmediately).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  ConnectorConfigurations: ").Append(ConnectorConfigurations).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  DefaultCurrency: ").Append(DefaultCurrency).Append("\n");
            sb.Append("  MaintenanceWindowDuration: ").Append(MaintenanceWindowDuration).Append("\n");
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
            yield break;
        }
    }

}
