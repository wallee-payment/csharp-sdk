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
    /// The refund update request allows to change the state of a refund. The refund must be linked with a processor that was created by the payment Web App that invokes the operation.
    /// </summary>
    [DataContract]
    public partial class PaymentAppRefundUpdateRequest :  IEquatable<PaymentAppRefundUpdateRequest>
    {
        /// <summary>
        /// The target state defines the state into which the refund should be switched into. Once the refund changed the state it will not be possible to change it again.
        /// </summary>
        /// <value>The target state defines the state into which the refund should be switched into. Once the refund changed the state it will not be possible to change it again.</value>
        [DataMember(Name="targetState", EmitDefaultValue=true)]
        public PaymentAppRefundTargetState? TargetState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentAppRefundUpdateRequest" /> class.
        /// </summary>
        public PaymentAppRefundUpdateRequest()
        {
        }

        /// <summary>
        /// The failure reason indicates why the refund failed. It is required when the target state is FAILED.
        /// </summary>
        /// <value>The failure reason indicates why the refund failed. It is required when the target state is FAILED.</value>
        [DataMember(Name="failureReasonId", EmitDefaultValue=true)]
        public long? FailureReasonId { get; set; }

        /// <summary>
        /// The reference identifies the refund within the systems of the external service provider. It is required when the target state is SUCCESSFUL.
        /// </summary>
        /// <value>The reference identifies the refund within the systems of the external service provider. It is required when the target state is SUCCESSFUL.</value>
        [DataMember(Name="reference", EmitDefaultValue=true)]
        public string Reference { get; set; }

        /// <summary>
        /// This is the ID of the refund that should be updated.
        /// </summary>
        /// <value>This is the ID of the refund that should be updated.</value>
        [DataMember(Name="refundId", EmitDefaultValue=true)]
        public long? RefundId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentAppRefundUpdateRequest {\n");
            sb.Append("  FailureReasonId: ").Append(FailureReasonId).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  RefundId: ").Append(RefundId).Append("\n");
            sb.Append("  TargetState: ").Append(TargetState).Append("\n");
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
            return this.Equals(input as PaymentAppRefundUpdateRequest);
        }

        /// <summary>
        /// Returns true if PaymentAppRefundUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentAppRefundUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentAppRefundUpdateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FailureReasonId == input.FailureReasonId ||
                    (this.FailureReasonId != null &&
                    this.FailureReasonId.Equals(input.FailureReasonId))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.RefundId == input.RefundId ||
                    (this.RefundId != null &&
                    this.RefundId.Equals(input.RefundId))
                ) && 
                (
                    this.TargetState == input.TargetState ||
                    (this.TargetState != null &&
                    this.TargetState.Equals(input.TargetState))
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
                if (this.FailureReasonId != null)
                    hashCode = hashCode * 59 + this.FailureReasonId.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.RefundId != null)
                    hashCode = hashCode * 59 + this.RefundId.GetHashCode();
                if (this.TargetState != null)
                    hashCode = hashCode * 59 + this.TargetState.GetHashCode();
                return hashCode;
            }
        }

    }

}
