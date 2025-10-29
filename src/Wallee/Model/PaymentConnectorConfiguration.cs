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
    /// PaymentConnectorConfiguration
    /// </summary>
    [DataContract(Name = "PaymentConnectorConfiguration")]
    public partial class PaymentConnectorConfiguration : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public CreationEntityState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentConnectorConfiguration" /> class.
        /// </summary>
        /// <param name="paymentMethodConfiguration">paymentMethodConfiguration.</param>
        /// <param name="processorConfiguration">processorConfiguration.</param>
        /// <param name="connector">connector.</param>
        /// <param name="state">state.</param>
        public PaymentConnectorConfiguration(PaymentMethodConfiguration paymentMethodConfiguration = default(PaymentMethodConfiguration), PaymentProcessorConfiguration processorConfiguration = default(PaymentProcessorConfiguration), PaymentConnector connector = default(PaymentConnector), CreationEntityState? state = default(CreationEntityState?))
        {
            this.PaymentMethodConfiguration = paymentMethodConfiguration;
            this.ProcessorConfiguration = processorConfiguration;
            this.Connector = connector;
            this.State = state;
        }

        /// <summary>
        /// Gets or Sets PaymentMethodConfiguration
        /// </summary>
        [DataMember(Name = "paymentMethodConfiguration", EmitDefaultValue = false)]
        public PaymentMethodConfiguration PaymentMethodConfiguration { get; set; }

        /// <summary>
        /// The URL to the connector&#39;s image.
        /// </summary>
        /// <value>The URL to the connector&#39;s image.</value>
        [DataMember(Name = "imagePath", EmitDefaultValue = false)]
        public string ImagePath { get; private set; }

        /// <summary>
        /// Returns false as ImagePath should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeImagePath()
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
        /// The priority that determines the order in which connector configurations are taken into account when processing a payment. Low values are considered first.
        /// </summary>
        /// <value>The priority that determines the order in which connector configurations are taken into account when processing a payment. Low values are considered first.</value>
        [DataMember(Name = "priority", EmitDefaultValue = false)]
        public int Priority { get; private set; }

        /// <summary>
        /// Returns false as Priority should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePriority()
        {
            return false;
        }
        /// <summary>
        /// The sales channels for which the connector configuration is enabled. If empty, it is enabled for all sales channels.
        /// </summary>
        /// <value>The sales channels for which the connector configuration is enabled. If empty, it is enabled for all sales channels.</value>
        [DataMember(Name = "enabledSalesChannels", EmitDefaultValue = false)]
        public List<SalesChannel> EnabledSalesChannels { get; private set; }

        /// <summary>
        /// Returns false as EnabledSalesChannels should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEnabledSalesChannels()
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
        /// Gets or Sets ProcessorConfiguration
        /// </summary>
        [DataMember(Name = "processorConfiguration", EmitDefaultValue = false)]
        public PaymentProcessorConfiguration ProcessorConfiguration { get; set; }

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
        /// Gets or Sets Connector
        /// </summary>
        [DataMember(Name = "connector", EmitDefaultValue = false)]
        public PaymentConnector Connector { get; set; }

        /// <summary>
        /// The name used to identify the connector configuration.
        /// </summary>
        /// <value>The name used to identify the connector configuration.</value>
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
        /// The space views for which the connector configuration is enabled. If empty, it is enabled for all space views.
        /// </summary>
        /// <value>The space views for which the connector configuration is enabled. If empty, it is enabled for all space views.</value>
        [DataMember(Name = "enabledSpaceViews", EmitDefaultValue = false)]
        public List<long> EnabledSpaceViews { get; private set; }

        /// <summary>
        /// Returns false as EnabledSpaceViews should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEnabledSpaceViews()
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
        /// Whether this connector configuration is enabled for processing payments, taking into account the state of the processor and payment method configurations.
        /// </summary>
        /// <value>Whether this connector configuration is enabled for processing payments, taking into account the state of the processor and payment method configurations.</value>
        [DataMember(Name = "applicableForTransactionProcessing", EmitDefaultValue = true)]
        public bool ApplicableForTransactionProcessing { get; private set; }

        /// <summary>
        /// Returns false as ApplicableForTransactionProcessing should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeApplicableForTransactionProcessing()
        {
            return false;
        }
        /// <summary>
        /// Conditions allow to define criteria that a transaction must fulfill in order for the connector configuration to be considered for processing the payment.
        /// </summary>
        /// <value>Conditions allow to define criteria that a transaction must fulfill in order for the connector configuration to be considered for processing the payment.</value>
        [DataMember(Name = "conditions", EmitDefaultValue = false)]
        public List<Condition> Conditions { get; private set; }

        /// <summary>
        /// Returns false as Conditions should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeConditions()
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
            sb.Append("class PaymentConnectorConfiguration {\n");
            sb.Append("  PaymentMethodConfiguration: ").Append(PaymentMethodConfiguration).Append("\n");
            sb.Append("  ImagePath: ").Append(ImagePath).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  EnabledSalesChannels: ").Append(EnabledSalesChannels).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  ProcessorConfiguration: ").Append(ProcessorConfiguration).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  Connector: ").Append(Connector).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  EnabledSpaceViews: ").Append(EnabledSpaceViews).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ApplicableForTransactionProcessing: ").Append(ApplicableForTransactionProcessing).Append("\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
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
