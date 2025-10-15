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
        /// The object&#39;s current state.
        /// </summary>
        /// <value>The object&#39;s current state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public PaymentAppConnectorState? State { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentAppConnector" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentAppConnector()
        {
        }

        /// <summary>
        /// The duration within which the authorization process for a payment should complete.
        /// </summary>
        /// <value>The duration within which the authorization process for a payment should complete.</value>
        [DataMember(Name="authorizationTimeout", EmitDefaultValue=false)]
        public string AuthorizationTimeout { get; private set; }

        /// <summary>
        /// The completion configuration controlling how deferred completion is processed. If not present, deferred completion is not supported for this connector.
        /// </summary>
        /// <value>The completion configuration controlling how deferred completion is processed. If not present, deferred completion is not supported for this connector.</value>
        [DataMember(Name="completionConfiguration", EmitDefaultValue=false)]
        public PaymentAppCompletionConfiguration CompletionConfiguration { get; private set; }

        /// <summary>
        /// The connector configuration created alongside the connector within its designated space. This configuration is used in transactions created using this connector.
        /// </summary>
        /// <value>The connector configuration created alongside the connector within its designated space. This configuration is used in transactions created using this connector.</value>
        [DataMember(Name="connectorConfiguration", EmitDefaultValue=false)]
        public PaymentConnectorConfiguration ConnectorConfiguration { get; private set; }

        /// <summary>
        /// The date and time when the connector was created.
        /// </summary>
        /// <value>The date and time when the connector was created.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.
        /// </summary>
        /// <value>A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; private set; }

        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The ID of the space this object belongs to.
        /// </summary>
        /// <value>The ID of the space this object belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// The name used to identify the connector.
        /// </summary>
        /// <value>The name used to identify the connector.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// The URL where the user is redirected to process a payment. This endpoint is provided by the external service provider.
        /// </summary>
        /// <value>The URL where the user is redirected to process a payment. This endpoint is provided by the external service provider.</value>
        [DataMember(Name="paymentPageEndpoint", EmitDefaultValue=false)]
        public string PaymentPageEndpoint { get; private set; }

        /// <summary>
        /// The payment app processor that the connector belongs to. This relationship is defined when the connector is created.
        /// </summary>
        /// <value>The payment app processor that the connector belongs to. This relationship is defined when the connector is created.</value>
        [DataMember(Name="processor", EmitDefaultValue=false)]
        public PaymentAppProcessor Processor { get; private set; }

        /// <summary>
        /// The refund configuration controlling the behavior for processing refunds. If not present, refunds are not supported for this connector.
        /// </summary>
        /// <value>The refund configuration controlling the behavior for processing refunds. If not present, refunds are not supported for this connector.</value>
        [DataMember(Name="refundConfiguration", EmitDefaultValue=false)]
        public PaymentAppRefundConfiguration RefundConfiguration { get; private set; }


        /// <summary>
        /// The date and time when the connector was last updated.
        /// </summary>
        /// <value>The date and time when the connector was last updated.</value>
        [DataMember(Name="updatedOn", EmitDefaultValue=false)]
        public DateTime? UpdatedOn { get; private set; }

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
