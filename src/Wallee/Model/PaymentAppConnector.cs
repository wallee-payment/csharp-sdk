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
    /// PaymentAppConnector
    /// </summary>
    [DataContract]
    public partial class PaymentAppConnector :  IEquatable<PaymentAppConnector>
    {
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=true)]
        public PaymentAppConnectorState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentAppConnector" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentAppConnector()
        {
        }

        /// <summary>
        /// Gets or Sets AuthorizationTimeout
        /// </summary>
        [DataMember(Name="authorizationTimeout", EmitDefaultValue=true)]
        public string AuthorizationTimeout { get; private set; }

        /// <summary>
        /// The completion configuration defines how the deferred completion is processed. If it is not present it means that deferred completion is not supported by this connector.
        /// </summary>
        /// <value>The completion configuration defines how the deferred completion is processed. If it is not present it means that deferred completion is not supported by this connector.</value>
        [DataMember(Name="completionConfiguration", EmitDefaultValue=true)]
        public PaymentAppCompletionConfiguration CompletionConfiguration { get; private set; }

        /// <summary>
        /// The connector configuration references the configuration that was created as part of this connector within the space. The connector configuration is referenced within transactions created with this connector.
        /// </summary>
        /// <value>The connector configuration references the configuration that was created as part of this connector within the space. The connector configuration is referenced within transactions created with this connector.</value>
        [DataMember(Name="connectorConfiguration", EmitDefaultValue=true)]
        public PaymentConnectorConfiguration ConnectorConfiguration { get; private set; }

        /// <summary>
        /// The created on date indicates when the connector was added.
        /// </summary>
        /// <value>The created on date indicates when the connector was added.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=true)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// The external ID corresponds to the ID provided during inserting of the processor.
        /// </summary>
        /// <value>The external ID corresponds to the ID provided during inserting of the processor.</value>
        [DataMember(Name="externalId", EmitDefaultValue=true)]
        public string ExternalId { get; private set; }

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
        /// The name of the connector will be displayed within the user interfaces that the merchant is interacting with.
        /// </summary>
        /// <value>The name of the connector will be displayed within the user interfaces that the merchant is interacting with.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; private set; }

        /// <summary>
        /// The payment page endpoint is invoked to process the transaction. The endpoint is defined by the external service provider.
        /// </summary>
        /// <value>The payment page endpoint is invoked to process the transaction. The endpoint is defined by the external service provider.</value>
        [DataMember(Name="paymentPageEndpoint", EmitDefaultValue=true)]
        public string PaymentPageEndpoint { get; private set; }

        /// <summary>
        /// The processor references the app processor to which this connector belongs to. The relationship is established during the creation of the connector.
        /// </summary>
        /// <value>The processor references the app processor to which this connector belongs to. The relationship is established during the creation of the connector.</value>
        [DataMember(Name="processor", EmitDefaultValue=true)]
        public PaymentAppProcessor Processor { get; private set; }

        /// <summary>
        /// The refund configuration defines how refunds are processed. If it is not present it means that refunds are not supported by this connector.
        /// </summary>
        /// <value>The refund configuration defines how refunds are processed. If it is not present it means that refunds are not supported by this connector.</value>
        [DataMember(Name="refundConfiguration", EmitDefaultValue=true)]
        public PaymentAppRefundConfiguration RefundConfiguration { get; private set; }


        /// <summary>
        /// The updated on date indicates when the last time the connector was updated on.
        /// </summary>
        /// <value>The updated on date indicates when the last time the connector was updated on.</value>
        [DataMember(Name="updatedOn", EmitDefaultValue=true)]
        public DateTime? UpdatedOn { get; private set; }

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
            sb.Append("class PaymentAppConnector {\n");
            sb.Append("  AuthorizationTimeout: ").Append(AuthorizationTimeout).Append("\n");
            sb.Append("  CompletionConfiguration: ").Append(CompletionConfiguration).Append("\n");
            sb.Append("  ConnectorConfiguration: ").Append(ConnectorConfiguration).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PaymentPageEndpoint: ").Append(PaymentPageEndpoint).Append("\n");
            sb.Append("  Processor: ").Append(Processor).Append("\n");
            sb.Append("  RefundConfiguration: ").Append(RefundConfiguration).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  UpdatedOn: ").Append(UpdatedOn).Append("\n");
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
            return this.Equals(input as PaymentAppConnector);
        }

        /// <summary>
        /// Returns true if PaymentAppConnector instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentAppConnector to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentAppConnector input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthorizationTimeout == input.AuthorizationTimeout ||
                    (this.AuthorizationTimeout != null &&
                    this.AuthorizationTimeout.Equals(input.AuthorizationTimeout))
                ) && 
                (
                    this.CompletionConfiguration == input.CompletionConfiguration ||
                    (this.CompletionConfiguration != null &&
                    this.CompletionConfiguration.Equals(input.CompletionConfiguration))
                ) && 
                (
                    this.ConnectorConfiguration == input.ConnectorConfiguration ||
                    (this.ConnectorConfiguration != null &&
                    this.ConnectorConfiguration.Equals(input.ConnectorConfiguration))
                ) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
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
                    this.PaymentPageEndpoint == input.PaymentPageEndpoint ||
                    (this.PaymentPageEndpoint != null &&
                    this.PaymentPageEndpoint.Equals(input.PaymentPageEndpoint))
                ) && 
                (
                    this.Processor == input.Processor ||
                    (this.Processor != null &&
                    this.Processor.Equals(input.Processor))
                ) && 
                (
                    this.RefundConfiguration == input.RefundConfiguration ||
                    (this.RefundConfiguration != null &&
                    this.RefundConfiguration.Equals(input.RefundConfiguration))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.UpdatedOn == input.UpdatedOn ||
                    (this.UpdatedOn != null &&
                    this.UpdatedOn.Equals(input.UpdatedOn))
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
                if (this.AuthorizationTimeout != null)
                    hashCode = hashCode * 59 + this.AuthorizationTimeout.GetHashCode();
                if (this.CompletionConfiguration != null)
                    hashCode = hashCode * 59 + this.CompletionConfiguration.GetHashCode();
                if (this.ConnectorConfiguration != null)
                    hashCode = hashCode * 59 + this.ConnectorConfiguration.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PaymentPageEndpoint != null)
                    hashCode = hashCode * 59 + this.PaymentPageEndpoint.GetHashCode();
                if (this.Processor != null)
                    hashCode = hashCode * 59 + this.Processor.GetHashCode();
                if (this.RefundConfiguration != null)
                    hashCode = hashCode * 59 + this.RefundConfiguration.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.UpdatedOn != null)
                    hashCode = hashCode * 59 + this.UpdatedOn.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
