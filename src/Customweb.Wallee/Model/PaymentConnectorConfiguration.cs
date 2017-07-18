/**
 * Wallee SDK Client
 *
 * This client allows to interact with the Wallee API.
 *
 * Wallee API: 1.0.0
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Connector Configuration
    /// </summary>
    [DataContract]
    public partial class PaymentConnectorConfiguration :  IEquatable<PaymentConnectorConfiguration>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentConnectorConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentConnectorConfiguration()
        {
        }

        /// <summary>
        /// This property indicates if the connector is currently used for processing transactions. In case either the payment method configuration or the processor configuration is not active the connector will not be used even though the connector state is active.
        /// </summary>
        /// <value>This property indicates if the connector is currently used for processing transactions. In case either the payment method configuration or the processor configuration is not active the connector will not be used even though the connector state is active.</value>
        [DataMember(Name="applicableForTransactionProcessing", EmitDefaultValue=false)]
        public bool? ApplicableForTransactionProcessing { get; private set; }

        /// <summary>
        /// If a transaction meet all selected conditions the connector configuration will be used to process the transaction otherwise the next connector configuration in line will be chosen according to the priorities.
        /// </summary>
        /// <value>If a transaction meet all selected conditions the connector configuration will be used to process the transaction otherwise the next connector configuration in line will be chosen according to the priorities.</value>
        [DataMember(Name="conditions", EmitDefaultValue=false)]
        public List<long?> Conditions { get; private set; }

        /// <summary>
        /// Connector
        /// </summary>
        /// <value>Connector</value>
        [DataMember(Name="connector", EmitDefaultValue=false)]
        public long? Connector { get; private set; }

        /// <summary>
        /// The connector configuration is only enabled for the selected space views. In case the set is empty the connector configuration is enabled for all space views.
        /// </summary>
        /// <value>The connector configuration is only enabled for the selected space views. In case the set is empty the connector configuration is enabled for all space views.</value>
        [DataMember(Name="enabledSpaceViews", EmitDefaultValue=false)]
        public List<long?> EnabledSpaceViews { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// The connector configuration name is used internally to identify the configuration in administrative interfaces. For example it is used within search fields and hence it should be distinct and descriptive.
        /// </summary>
        /// <value>The connector configuration name is used internally to identify the configuration in administrative interfaces. For example it is used within search fields and hence it should be distinct and descriptive.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// PaymentMethodConfiguration
        /// </summary>
        /// <value>PaymentMethodConfiguration</value>
        [DataMember(Name="paymentMethodConfiguration", EmitDefaultValue=false)]
        public PaymentMethodConfiguration PaymentMethodConfiguration { get; private set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// The priority will define the order of choice of the connector configurations. The lower the value, the higher the priority is going to be. This value can also be a negative number in case you are adding a new configuration that you want to have a high priority and you dont want to change the priority of all the other configurations.
        /// </summary>
        /// <value>The priority will define the order of choice of the connector configurations. The lower the value, the higher the priority is going to be. This value can also be a negative number in case you are adding a new configuration that you want to have a high priority and you dont want to change the priority of all the other configurations.</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; private set; }

        /// <summary>
        /// ProcessorConfiguration
        /// </summary>
        /// <value>ProcessorConfiguration</value>
        [DataMember(Name="processorConfiguration", EmitDefaultValue=false)]
        public PaymentProcessorConfiguration ProcessorConfiguration { get; private set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public CreationEntityState? State { get; private set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return this.ToJson();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            return this.Equals(obj as PaymentConnectorConfiguration);
        }

        /// <summary>
        /// Returns true if PaymentConnectorConfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentConnectorConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentConnectorConfiguration other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.ApplicableForTransactionProcessing == other.ApplicableForTransactionProcessing ||
                    this.ApplicableForTransactionProcessing != null &&
                    this.ApplicableForTransactionProcessing.Equals(other.ApplicableForTransactionProcessing)
                ) && 
                (
                    this.Conditions == other.Conditions ||
                    this.Conditions != null &&
                    this.Conditions.SequenceEqual(other.Conditions)
                ) && 
                (
                    this.Connector == other.Connector ||
                    this.Connector != null &&
                    this.Connector.Equals(other.Connector)
                ) && 
                (
                    this.EnabledSpaceViews == other.EnabledSpaceViews ||
                    this.EnabledSpaceViews != null &&
                    this.EnabledSpaceViews.SequenceEqual(other.EnabledSpaceViews)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.LinkedSpaceId == other.LinkedSpaceId ||
                    this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(other.LinkedSpaceId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.PaymentMethodConfiguration == other.PaymentMethodConfiguration ||
                    this.PaymentMethodConfiguration != null &&
                    this.PaymentMethodConfiguration.Equals(other.PaymentMethodConfiguration)
                ) && 
                (
                    this.PlannedPurgeDate == other.PlannedPurgeDate ||
                    this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(other.PlannedPurgeDate)
                ) && 
                (
                    this.Priority == other.Priority ||
                    this.Priority != null &&
                    this.Priority.Equals(other.Priority)
                ) && 
                (
                    this.ProcessorConfiguration == other.ProcessorConfiguration ||
                    this.ProcessorConfiguration != null &&
                    this.ProcessorConfiguration.Equals(other.ProcessorConfiguration)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                if (this.ApplicableForTransactionProcessing != null)
                {
                    hash = hash * 59 + this.ApplicableForTransactionProcessing.GetHashCode();
                }
                if (this.Conditions != null)
                {
                    hash = hash * 59 + this.Conditions.GetHashCode();
                }
                if (this.Connector != null)
                {
                    hash = hash * 59 + this.Connector.GetHashCode();
                }
                if (this.EnabledSpaceViews != null)
                {
                    hash = hash * 59 + this.EnabledSpaceViews.GetHashCode();
                }
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.LinkedSpaceId != null)
                {
                    hash = hash * 59 + this.LinkedSpaceId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hash = hash * 59 + this.Name.GetHashCode();
                }
                if (this.PaymentMethodConfiguration != null)
                {
                    hash = hash * 59 + this.PaymentMethodConfiguration.GetHashCode();
                }
                if (this.PlannedPurgeDate != null)
                {
                    hash = hash * 59 + this.PlannedPurgeDate.GetHashCode();
                }
                if (this.Priority != null)
                {
                    hash = hash * 59 + this.Priority.GetHashCode();
                }
                if (this.ProcessorConfiguration != null)
                {
                    hash = hash * 59 + this.ProcessorConfiguration.GetHashCode();
                }
                if (this.State != null)
                {
                    hash = hash * 59 + this.State.GetHashCode();
                }
                if (this.Version != null)
                {
                    hash = hash * 59 + this.Version.GetHashCode();
                }
                return hash;
            }
        }

    }

}
