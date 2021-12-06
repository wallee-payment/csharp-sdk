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
    /// PaymentAppRefundConfiguration
    /// </summary>
    [DataContract]
    public partial class PaymentAppRefundConfiguration :  IEquatable<PaymentAppRefundConfiguration>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentAppRefundConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentAppRefundConfiguration()
        {
        }

        /// <summary>
        /// This flag indicates whether the connector supports multiple refunds for a single transaction or not.
        /// </summary>
        /// <value>This flag indicates whether the connector supports multiple refunds for a single transaction or not.</value>
        [DataMember(Name="multipleRefundsSupported", EmitDefaultValue=true)]
        public bool? MultipleRefundsSupported { get; private set; }

        /// <summary>
        /// The refund endpoint is invoked to request the payment service provider to execute a refund.
        /// </summary>
        /// <value>The refund endpoint is invoked to request the payment service provider to execute a refund.</value>
        [DataMember(Name="refundEndpoint", EmitDefaultValue=true)]
        public string RefundEndpoint { get; private set; }

        /// <summary>
        /// When the refund is triggered we expect a feedback about the state of it. This timeout defines after how long we consider the refund as failed without receiving a final state update.
        /// </summary>
        /// <value>When the refund is triggered we expect a feedback about the state of it. This timeout defines after how long we consider the refund as failed without receiving a final state update.</value>
        [DataMember(Name="refundTimeoutInMinutes", EmitDefaultValue=true)]
        public int? RefundTimeoutInMinutes { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentAppRefundConfiguration {\n");
            sb.Append("  MultipleRefundsSupported: ").Append(MultipleRefundsSupported).Append("\n");
            sb.Append("  RefundEndpoint: ").Append(RefundEndpoint).Append("\n");
            sb.Append("  RefundTimeoutInMinutes: ").Append(RefundTimeoutInMinutes).Append("\n");
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
            return this.Equals(input as PaymentAppRefundConfiguration);
        }

        /// <summary>
        /// Returns true if PaymentAppRefundConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentAppRefundConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentAppRefundConfiguration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MultipleRefundsSupported == input.MultipleRefundsSupported ||
                    (this.MultipleRefundsSupported != null &&
                    this.MultipleRefundsSupported.Equals(input.MultipleRefundsSupported))
                ) && 
                (
                    this.RefundEndpoint == input.RefundEndpoint ||
                    (this.RefundEndpoint != null &&
                    this.RefundEndpoint.Equals(input.RefundEndpoint))
                ) && 
                (
                    this.RefundTimeoutInMinutes == input.RefundTimeoutInMinutes ||
                    (this.RefundTimeoutInMinutes != null &&
                    this.RefundTimeoutInMinutes.Equals(input.RefundTimeoutInMinutes))
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
                if (this.MultipleRefundsSupported != null)
                    hashCode = hashCode * 59 + this.MultipleRefundsSupported.GetHashCode();
                if (this.RefundEndpoint != null)
                    hashCode = hashCode * 59 + this.RefundEndpoint.GetHashCode();
                if (this.RefundTimeoutInMinutes != null)
                    hashCode = hashCode * 59 + this.RefundTimeoutInMinutes.GetHashCode();
                return hashCode;
            }
        }

    }

}
