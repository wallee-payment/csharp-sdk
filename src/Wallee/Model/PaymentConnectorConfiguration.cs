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
using SwaggerDateConverter = Wallee.Client.SwaggerDateConverter;

namespace Wallee.Model
{
    /// <summary>
    /// PaymentConnectorConfiguration
    /// </summary>
    [DataContract]
    public partial class PaymentConnectorConfiguration :  IEquatable<PaymentConnectorConfiguration>
    {
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=true)]
        public CreationEntityState? State { get; set; }
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
        [DataMember(Name="applicableForTransactionProcessing", EmitDefaultValue=true)]
        public bool? ApplicableForTransactionProcessing { get; private set; }

        /// <summary>
        /// If a transaction meet all selected conditions the connector configuration will be used to process the transaction otherwise the next connector configuration in line will be chosen according to the priorities.
        /// </summary>
        /// <value>If a transaction meet all selected conditions the connector configuration will be used to process the transaction otherwise the next connector configuration in line will be chosen according to the priorities.</value>
        [DataMember(Name="conditions", EmitDefaultValue=true)]
        public List<long?> Conditions { get; private set; }

        /// <summary>
        /// Gets or Sets Connector
        /// </summary>
        [DataMember(Name="connector", EmitDefaultValue=true)]
        public long? Connector { get; private set; }

        /// <summary>
        /// The connector configuration is only enabled for the selected space views. In case the set is empty the connector configuration is enabled for all space views.
        /// </summary>
        /// <value>The connector configuration is only enabled for the selected space views. In case the set is empty the connector configuration is enabled for all space views.</value>
        [DataMember(Name="enabledSpaceViews", EmitDefaultValue=true)]
        public List<long?> EnabledSpaceViews { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; private set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=true)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// The connector configuration name is used internally to identify the configuration in administrative interfaces. For example it is used within search fields and hence it should be distinct and descriptive.
        /// </summary>
        /// <value>The connector configuration name is used internally to identify the configuration in administrative interfaces. For example it is used within search fields and hence it should be distinct and descriptive.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; private set; }

        /// <summary>
        /// Gets or Sets PaymentMethodConfiguration
        /// </summary>
        [DataMember(Name="paymentMethodConfiguration", EmitDefaultValue=true)]
        public PaymentMethodConfiguration PaymentMethodConfiguration { get; private set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=true)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// The priority will define the order of choice of the connector configurations. The lower the value, the higher the priority is going to be. This value can also be a negative number in case you are adding a new configuration that you want to have a high priority and you dont want to change the priority of all the other configurations.
        /// </summary>
        /// <value>The priority will define the order of choice of the connector configurations. The lower the value, the higher the priority is going to be. This value can also be a negative number in case you are adding a new configuration that you want to have a high priority and you dont want to change the priority of all the other configurations.</value>
        [DataMember(Name="priority", EmitDefaultValue=true)]
        public int? Priority { get; private set; }

        /// <summary>
        /// Gets or Sets ProcessorConfiguration
        /// </summary>
        [DataMember(Name="processorConfiguration", EmitDefaultValue=true)]
        public PaymentProcessorConfiguration ProcessorConfiguration { get; private set; }


        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public int? Version { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentConnectorConfiguration {\n");
            sb.Append("  ApplicableForTransactionProcessing: ").Append(ApplicableForTransactionProcessing).Append("\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
            sb.Append("  Connector: ").Append(Connector).Append("\n");
            sb.Append("  EnabledSpaceViews: ").Append(EnabledSpaceViews).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PaymentMethodConfiguration: ").Append(PaymentMethodConfiguration).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  ProcessorConfiguration: ").Append(ProcessorConfiguration).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PaymentConnectorConfiguration);
        }

        /// <summary>
        /// Returns true if PaymentConnectorConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentConnectorConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentConnectorConfiguration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicableForTransactionProcessing == input.ApplicableForTransactionProcessing ||
                    (this.ApplicableForTransactionProcessing != null &&
                    this.ApplicableForTransactionProcessing.Equals(input.ApplicableForTransactionProcessing))
                ) && 
                (
                    this.Conditions == input.Conditions ||
                    this.Conditions != null &&
                    this.Conditions.SequenceEqual(input.Conditions)
                ) && 
                (
                    this.Connector == input.Connector ||
                    (this.Connector != null &&
                    this.Connector.Equals(input.Connector))
                ) && 
                (
                    this.EnabledSpaceViews == input.EnabledSpaceViews ||
                    this.EnabledSpaceViews != null &&
                    this.EnabledSpaceViews.SequenceEqual(input.EnabledSpaceViews)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LinkedSpaceId == input.LinkedSpaceId ||
                    (this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(input.LinkedSpaceId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PaymentMethodConfiguration == input.PaymentMethodConfiguration ||
                    (this.PaymentMethodConfiguration != null &&
                    this.PaymentMethodConfiguration.Equals(input.PaymentMethodConfiguration))
                ) && 
                (
                    this.PlannedPurgeDate == input.PlannedPurgeDate ||
                    (this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(input.PlannedPurgeDate))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.ProcessorConfiguration == input.ProcessorConfiguration ||
                    (this.ProcessorConfiguration != null &&
                    this.ProcessorConfiguration.Equals(input.ProcessorConfiguration))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                int hashCode = 41;
                if (this.ApplicableForTransactionProcessing != null)
                    hashCode = hashCode * 59 + this.ApplicableForTransactionProcessing.GetHashCode();
                if (this.Conditions != null)
                    hashCode = hashCode * 59 + this.Conditions.GetHashCode();
                if (this.Connector != null)
                    hashCode = hashCode * 59 + this.Connector.GetHashCode();
                if (this.EnabledSpaceViews != null)
                    hashCode = hashCode * 59 + this.EnabledSpaceViews.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PaymentMethodConfiguration != null)
                    hashCode = hashCode * 59 + this.PaymentMethodConfiguration.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.ProcessorConfiguration != null)
                    hashCode = hashCode * 59 + this.ProcessorConfiguration.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
