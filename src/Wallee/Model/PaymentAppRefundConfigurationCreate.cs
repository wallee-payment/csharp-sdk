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
    /// PaymentAppRefundConfigurationCreate
    /// </summary>
    [DataContract]
    public partial class PaymentAppRefundConfigurationCreate :  IEquatable<PaymentAppRefundConfigurationCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentAppRefundConfigurationCreate" /> class.
        /// </summary>
        public PaymentAppRefundConfigurationCreate()
        {
        }

        /// <summary>
        /// Whether the payment connector can process multiple refunds for a single transaction.
        /// </summary>
        /// <value>Whether the payment connector can process multiple refunds for a single transaction.</value>
        [DataMember(Name="multipleRefundsSupported", EmitDefaultValue=false)]
        public bool? MultipleRefundsSupported { get; set; }

        /// <summary>
        /// The URL that the payment service provider will invoke to process a refund request. This endpoint handles communication with the provider for initiating and managing refunds.
        /// </summary>
        /// <value>The URL that the payment service provider will invoke to process a refund request. This endpoint handles communication with the provider for initiating and managing refunds.</value>
        [DataMember(Name="refundEndpoint", EmitDefaultValue=false)]
        public string RefundEndpoint { get; set; }

        /// <summary>
        /// The maximum time (in minutes) to wait for a response from the payment service provider after a refund request is triggered. If no feedback or final status is received within this period, the refund is considered failed.
        /// </summary>
        /// <value>The maximum time (in minutes) to wait for a response from the payment service provider after a refund request is triggered. If no feedback or final status is received within this period, the refund is considered failed.</value>
        [DataMember(Name="refundTimeoutInMinutes", EmitDefaultValue=false)]
        public int? RefundTimeoutInMinutes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentAppRefundConfigurationCreate {\n");
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
            return this.Equals(input as PaymentAppRefundConfigurationCreate);
        }

        /// <summary>
        /// Returns true if PaymentAppRefundConfigurationCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentAppRefundConfigurationCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentAppRefundConfigurationCreate input)
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
