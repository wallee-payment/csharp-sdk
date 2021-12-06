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
    /// PaymentAppConnectorCreationRequest
    /// </summary>
    [DataContract]
    public partial class PaymentAppConnectorCreationRequest :  IEquatable<PaymentAppConnectorCreationRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentAppConnectorCreationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentAppConnectorCreationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentAppConnectorCreationRequest" /> class.
        /// </summary>
        /// <param name="authorizationTimeoutInMinutes">When the transaction is not authorized within this timeout the transaction is considered as failed. (required).</param>
        /// <param name="connector">The ID of the connector identifies which connector that should be linked with this web app connector. The connector defines the payment method. (required).</param>
        /// <param name="externalId">The external ID identifies the connector within the external system. It has to be unique per processor external ID and for any subsequent update the same ID must be sent. (required).</param>
        /// <param name="name">The name of the connector will be displayed within the user interfaces that the merchant is interacting with. (required).</param>
        /// <param name="paymentPageEndpoint">The payment page endpoint URL will be invoked by the buyer to carry out the authorization of the payment. (required).</param>
        /// <param name="processorExternalId">The external ID of the processor identifies the processor to which this connector belongs to. The processor cannot be changed once it has been set on a connector. (required).</param>
        public PaymentAppConnectorCreationRequest(int? authorizationTimeoutInMinutes, long? connector, string externalId, string name, string paymentPageEndpoint, string processorExternalId)
        {
            // to ensure "authorizationTimeoutInMinutes" is required (not null)
            if (authorizationTimeoutInMinutes == null)
            {
                throw new InvalidDataException("authorizationTimeoutInMinutes is a required property for PaymentAppConnectorCreationRequest and cannot be null");
            }
            this.AuthorizationTimeoutInMinutes = authorizationTimeoutInMinutes;
            // to ensure "connector" is required (not null)
            if (connector == null)
            {
                throw new InvalidDataException("connector is a required property for PaymentAppConnectorCreationRequest and cannot be null");
            }
            this.Connector = connector;
            // to ensure "externalId" is required (not null)
            if (externalId == null)
            {
                throw new InvalidDataException("externalId is a required property for PaymentAppConnectorCreationRequest and cannot be null");
            }
            this.ExternalId = externalId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for PaymentAppConnectorCreationRequest and cannot be null");
            }
            this.Name = name;
            // to ensure "paymentPageEndpoint" is required (not null)
            if (paymentPageEndpoint == null)
            {
                throw new InvalidDataException("paymentPageEndpoint is a required property for PaymentAppConnectorCreationRequest and cannot be null");
            }
            this.PaymentPageEndpoint = paymentPageEndpoint;
            // to ensure "processorExternalId" is required (not null)
            if (processorExternalId == null)
            {
                throw new InvalidDataException("processorExternalId is a required property for PaymentAppConnectorCreationRequest and cannot be null");
            }
            this.ProcessorExternalId = processorExternalId;
        }

        /// <summary>
        /// When the transaction is not authorized within this timeout the transaction is considered as failed.
        /// </summary>
        /// <value>When the transaction is not authorized within this timeout the transaction is considered as failed.</value>
        [DataMember(Name="authorizationTimeoutInMinutes", EmitDefaultValue=true)]
        public int? AuthorizationTimeoutInMinutes { get; set; }

        /// <summary>
        /// The completion configuration allows the connector to support deferred completions on a transaction. If it is not provided the connector will not process transactions in deferred mode.
        /// </summary>
        /// <value>The completion configuration allows the connector to support deferred completions on a transaction. If it is not provided the connector will not process transactions in deferred mode.</value>
        [DataMember(Name="completionConfiguration", EmitDefaultValue=true)]
        public PaymentAppCompletionConfigurationCreate CompletionConfiguration { get; set; }

        /// <summary>
        /// The ID of the connector identifies which connector that should be linked with this web app connector. The connector defines the payment method.
        /// </summary>
        /// <value>The ID of the connector identifies which connector that should be linked with this web app connector. The connector defines the payment method.</value>
        [DataMember(Name="connector", EmitDefaultValue=true)]
        public long? Connector { get; set; }

        /// <summary>
        /// The external ID identifies the connector within the external system. It has to be unique per processor external ID and for any subsequent update the same ID must be sent.
        /// </summary>
        /// <value>The external ID identifies the connector within the external system. It has to be unique per processor external ID and for any subsequent update the same ID must be sent.</value>
        [DataMember(Name="externalId", EmitDefaultValue=true)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The name of the connector will be displayed within the user interfaces that the merchant is interacting with.
        /// </summary>
        /// <value>The name of the connector will be displayed within the user interfaces that the merchant is interacting with.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// The payment page endpoint URL will be invoked by the buyer to carry out the authorization of the payment.
        /// </summary>
        /// <value>The payment page endpoint URL will be invoked by the buyer to carry out the authorization of the payment.</value>
        [DataMember(Name="paymentPageEndpoint", EmitDefaultValue=true)]
        public string PaymentPageEndpoint { get; set; }

        /// <summary>
        /// The external ID of the processor identifies the processor to which this connector belongs to. The processor cannot be changed once it has been set on a connector.
        /// </summary>
        /// <value>The external ID of the processor identifies the processor to which this connector belongs to. The processor cannot be changed once it has been set on a connector.</value>
        [DataMember(Name="processorExternalId", EmitDefaultValue=true)]
        public string ProcessorExternalId { get; set; }

        /// <summary>
        /// The refund configuration allows the connector to support refunds on transactions. In case no refund configuration is provided the connector will not support refunds.
        /// </summary>
        /// <value>The refund configuration allows the connector to support refunds on transactions. In case no refund configuration is provided the connector will not support refunds.</value>
        [DataMember(Name="refundConfiguration", EmitDefaultValue=true)]
        public PaymentAppRefundConfigurationCreate RefundConfiguration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentAppConnectorCreationRequest {\n");
            sb.Append("  AuthorizationTimeoutInMinutes: ").Append(AuthorizationTimeoutInMinutes).Append("\n");
            sb.Append("  CompletionConfiguration: ").Append(CompletionConfiguration).Append("\n");
            sb.Append("  Connector: ").Append(Connector).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PaymentPageEndpoint: ").Append(PaymentPageEndpoint).Append("\n");
            sb.Append("  ProcessorExternalId: ").Append(ProcessorExternalId).Append("\n");
            sb.Append("  RefundConfiguration: ").Append(RefundConfiguration).Append("\n");
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
            return this.Equals(input as PaymentAppConnectorCreationRequest);
        }

        /// <summary>
        /// Returns true if PaymentAppConnectorCreationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentAppConnectorCreationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentAppConnectorCreationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthorizationTimeoutInMinutes == input.AuthorizationTimeoutInMinutes ||
                    (this.AuthorizationTimeoutInMinutes != null &&
                    this.AuthorizationTimeoutInMinutes.Equals(input.AuthorizationTimeoutInMinutes))
                ) && 
                (
                    this.CompletionConfiguration == input.CompletionConfiguration ||
                    (this.CompletionConfiguration != null &&
                    this.CompletionConfiguration.Equals(input.CompletionConfiguration))
                ) && 
                (
                    this.Connector == input.Connector ||
                    (this.Connector != null &&
                    this.Connector.Equals(input.Connector))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
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
                    this.ProcessorExternalId == input.ProcessorExternalId ||
                    (this.ProcessorExternalId != null &&
                    this.ProcessorExternalId.Equals(input.ProcessorExternalId))
                ) && 
                (
                    this.RefundConfiguration == input.RefundConfiguration ||
                    (this.RefundConfiguration != null &&
                    this.RefundConfiguration.Equals(input.RefundConfiguration))
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
                if (this.AuthorizationTimeoutInMinutes != null)
                    hashCode = hashCode * 59 + this.AuthorizationTimeoutInMinutes.GetHashCode();
                if (this.CompletionConfiguration != null)
                    hashCode = hashCode * 59 + this.CompletionConfiguration.GetHashCode();
                if (this.Connector != null)
                    hashCode = hashCode * 59 + this.Connector.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PaymentPageEndpoint != null)
                    hashCode = hashCode * 59 + this.PaymentPageEndpoint.GetHashCode();
                if (this.ProcessorExternalId != null)
                    hashCode = hashCode * 59 + this.ProcessorExternalId.GetHashCode();
                if (this.RefundConfiguration != null)
                    hashCode = hashCode * 59 + this.RefundConfiguration.GetHashCode();
                return hashCode;
            }
        }

    }

}
