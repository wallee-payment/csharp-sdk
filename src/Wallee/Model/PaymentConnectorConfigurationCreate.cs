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
    /// PaymentConnectorConfigurationCreate
    /// </summary>
    [DataContract(Name = "PaymentConnectorConfiguration.Create")]
    public partial class PaymentConnectorConfigurationCreate : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public CreationEntityState State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentConnectorConfigurationCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentConnectorConfigurationCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentConnectorConfigurationCreate" /> class.
        /// </summary>
        /// <param name="name">The name used to identify the connector configuration..</param>
        /// <param name="enabledSpaceViews">The space views for which the connector configuration is enabled. If empty, it is enabled for all space views..</param>
        /// <param name="conditions">Conditions allow to define criteria that a transaction must fulfill in order for the connector configuration to be considered for processing the payment..</param>
        /// <param name="priority">The priority that determines the order in which connector configurations are taken into account when processing a payment. Low values are considered first..</param>
        /// <param name="enabledSalesChannels">The sales channels for which the connector configuration is enabled. If empty, it is enabled for all sales channels..</param>
        /// <param name="paymentMethodConfiguration">The payment method configuration that the connector configuration belongs to. (required).</param>
        /// <param name="connector">The connector that the configuration is for. (required).</param>
        /// <param name="state">state (required).</param>
        /// <param name="processorConfiguration">The processor configuration that the connector configuration belongs to. (required).</param>
        public PaymentConnectorConfigurationCreate(string name = default(string), List<long> enabledSpaceViews = default(List<long>), List<Condition> conditions = default(List<Condition>), int priority = default(int), List<SalesChannel> enabledSalesChannels = default(List<SalesChannel>), long paymentMethodConfiguration = default(long), long connector = default(long), CreationEntityState state = default(CreationEntityState), long processorConfiguration = default(long))
        {
            this.PaymentMethodConfiguration = paymentMethodConfiguration;
            this.Connector = connector;
            this.State = state;
            this.ProcessorConfiguration = processorConfiguration;
            this.Name = name;
            this.EnabledSpaceViews = enabledSpaceViews;
            this.Conditions = conditions;
            this.Priority = priority;
            this.EnabledSalesChannels = enabledSalesChannels;
        }

        /// <summary>
        /// The name used to identify the connector configuration.
        /// </summary>
        /// <value>The name used to identify the connector configuration.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The space views for which the connector configuration is enabled. If empty, it is enabled for all space views.
        /// </summary>
        /// <value>The space views for which the connector configuration is enabled. If empty, it is enabled for all space views.</value>
        [DataMember(Name = "enabledSpaceViews", EmitDefaultValue = false)]
        public List<long> EnabledSpaceViews { get; set; }

        /// <summary>
        /// Conditions allow to define criteria that a transaction must fulfill in order for the connector configuration to be considered for processing the payment.
        /// </summary>
        /// <value>Conditions allow to define criteria that a transaction must fulfill in order for the connector configuration to be considered for processing the payment.</value>
        [DataMember(Name = "conditions", EmitDefaultValue = false)]
        public List<Condition> Conditions { get; set; }

        /// <summary>
        /// The priority that determines the order in which connector configurations are taken into account when processing a payment. Low values are considered first.
        /// </summary>
        /// <value>The priority that determines the order in which connector configurations are taken into account when processing a payment. Low values are considered first.</value>
        [DataMember(Name = "priority", EmitDefaultValue = false)]
        public int Priority { get; set; }

        /// <summary>
        /// The sales channels for which the connector configuration is enabled. If empty, it is enabled for all sales channels.
        /// </summary>
        /// <value>The sales channels for which the connector configuration is enabled. If empty, it is enabled for all sales channels.</value>
        [DataMember(Name = "enabledSalesChannels", EmitDefaultValue = false)]
        public List<SalesChannel> EnabledSalesChannels { get; set; }

        /// <summary>
        /// The payment method configuration that the connector configuration belongs to.
        /// </summary>
        /// <value>The payment method configuration that the connector configuration belongs to.</value>
        [DataMember(Name = "paymentMethodConfiguration", IsRequired = true, EmitDefaultValue = true)]
        public long PaymentMethodConfiguration { get; set; }

        /// <summary>
        /// The connector that the configuration is for.
        /// </summary>
        /// <value>The connector that the configuration is for.</value>
        [DataMember(Name = "connector", IsRequired = true, EmitDefaultValue = true)]
        public long Connector { get; set; }

        /// <summary>
        /// The processor configuration that the connector configuration belongs to.
        /// </summary>
        /// <value>The processor configuration that the connector configuration belongs to.</value>
        [DataMember(Name = "processorConfiguration", IsRequired = true, EmitDefaultValue = true)]
        public long ProcessorConfiguration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentConnectorConfigurationCreate {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  EnabledSpaceViews: ").Append(EnabledSpaceViews).Append("\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  EnabledSalesChannels: ").Append(EnabledSalesChannels).Append("\n");
            sb.Append("  PaymentMethodConfiguration: ").Append(PaymentMethodConfiguration).Append("\n");
            sb.Append("  Connector: ").Append(Connector).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ProcessorConfiguration: ").Append(ProcessorConfiguration).Append("\n");
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
