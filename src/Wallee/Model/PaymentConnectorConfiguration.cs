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
        /// The object&#39;s current state.
        /// </summary>
        /// <value>The object&#39;s current state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public CreationEntityState? State { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentConnectorConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentConnectorConfiguration()
        {
        }

        /// <summary>
        /// Whether this connector configuration is enabled for processing payments, taking into account the state of the processor and payment method configurations.
        /// </summary>
        /// <value>Whether this connector configuration is enabled for processing payments, taking into account the state of the processor and payment method configurations.</value>
        [DataMember(Name="applicableForTransactionProcessing", EmitDefaultValue=false)]
        public bool? ApplicableForTransactionProcessing { get; private set; }

        /// <summary>
        /// Conditions allow to define criteria that a transaction must fulfill in order for the connector configuration to be considered for processing the payment.
        /// </summary>
        /// <value>Conditions allow to define criteria that a transaction must fulfill in order for the connector configuration to be considered for processing the payment.</value>
        [DataMember(Name="conditions", EmitDefaultValue=false)]
        public List<long?> Conditions { get; private set; }

        /// <summary>
        /// The connector that the configuration is for.
        /// </summary>
        /// <value>The connector that the configuration is for.</value>
        [DataMember(Name="connector", EmitDefaultValue=false)]
        public long? Connector { get; private set; }

        /// <summary>
        /// The sales channels for which the connector configuration is enabled. If empty, it is enabled for all sales channels.
        /// </summary>
        /// <value>The sales channels for which the connector configuration is enabled. If empty, it is enabled for all sales channels.</value>
        [DataMember(Name="enabledSalesChannels", EmitDefaultValue=false)]
        public List<SalesChannel> EnabledSalesChannels { get; private set; }

        /// <summary>
        /// The space views for which the connector configuration is enabled. If empty, it is enabled for all space views.
        /// </summary>
        /// <value>The space views for which the connector configuration is enabled. If empty, it is enabled for all space views.</value>
        [DataMember(Name="enabledSpaceViews", EmitDefaultValue=false)]
        public List<long?> EnabledSpaceViews { get; private set; }

        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The URL to the connector&#39;s image.
        /// </summary>
        /// <value>The URL to the connector&#39;s image.</value>
        [DataMember(Name="imagePath", EmitDefaultValue=false)]
        public string ImagePath { get; private set; }

        /// <summary>
        /// The ID of the space this object belongs to.
        /// </summary>
        /// <value>The ID of the space this object belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// The name used to identify the connector configuration.
        /// </summary>
        /// <value>The name used to identify the connector configuration.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// The payment method configuration that the connector configuration belongs to.
        /// </summary>
        /// <value>The payment method configuration that the connector configuration belongs to.</value>
        [DataMember(Name="paymentMethodConfiguration", EmitDefaultValue=false)]
        public PaymentMethodConfiguration PaymentMethodConfiguration { get; private set; }

        /// <summary>
        /// The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.
        /// </summary>
        /// <value>The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// The priority that determines the order in which connector configurations are taken into account when processing a payment. Low values are considered first.
        /// </summary>
        /// <value>The priority that determines the order in which connector configurations are taken into account when processing a payment. Low values are considered first.</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; private set; }

        /// <summary>
        /// The processor configuration that the connector configuration belongs to.
        /// </summary>
        /// <value>The processor configuration that the connector configuration belongs to.</value>
        [DataMember(Name="processorConfiguration", EmitDefaultValue=false)]
        public PaymentProcessorConfiguration ProcessorConfiguration { get; private set; }


        /// <summary>
        /// The version is used for optimistic locking and incremented whenever the object is updated.
        /// </summary>
        /// <value>The version is used for optimistic locking and incremented whenever the object is updated.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
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
            sb.Append("  EnabledSalesChannels: ").Append(EnabledSalesChannels).Append("\n");
            sb.Append("  EnabledSpaceViews: ").Append(EnabledSpaceViews).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ImagePath: ").Append(ImagePath).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
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
                    input.Conditions != null &&
                    this.Conditions.SequenceEqual(input.Conditions)
                ) && 
                (
                    this.Connector == input.Connector ||
                    (this.Connector != null &&
                    this.Connector.Equals(input.Connector))
                ) && 
                (
                    this.EnabledSalesChannels == input.EnabledSalesChannels ||
                    this.EnabledSalesChannels != null &&
                    input.EnabledSalesChannels != null &&
                    this.EnabledSalesChannels.SequenceEqual(input.EnabledSalesChannels)
                ) && 
                (
                    this.EnabledSpaceViews == input.EnabledSpaceViews ||
                    this.EnabledSpaceViews != null &&
                    input.EnabledSpaceViews != null &&
                    this.EnabledSpaceViews.SequenceEqual(input.EnabledSpaceViews)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ImagePath == input.ImagePath ||
                    (this.ImagePath != null &&
                    this.ImagePath.Equals(input.ImagePath))
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
                if (this.EnabledSalesChannels != null)
                    hashCode = hashCode * 59 + this.EnabledSalesChannels.GetHashCode();
                if (this.EnabledSpaceViews != null)
                    hashCode = hashCode * 59 + this.EnabledSpaceViews.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ImagePath != null)
                    hashCode = hashCode * 59 + this.ImagePath.GetHashCode();
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
