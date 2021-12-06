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
    /// The charge attempt update request allows to change the state of a charge attempt. The charge attempt must be linked with a processor that was created by the payment Web App that invokes the operation.
    /// </summary>
    [DataContract]
    public partial class PaymentAppChargeAttemptUpdateRequest :  IEquatable<PaymentAppChargeAttemptUpdateRequest>
    {
        /// <summary>
        /// The target state defines the state into which the charge attempt should be switched into. Once the charge attempt changed the state it will not be possible to change it again.
        /// </summary>
        /// <value>The target state defines the state into which the charge attempt should be switched into. Once the charge attempt changed the state it will not be possible to change it again.</value>
        [DataMember(Name="targetState", EmitDefaultValue=true)]
        public PaymentAppChargeAttemptTargetState? TargetState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentAppChargeAttemptUpdateRequest" /> class.
        /// </summary>
        public PaymentAppChargeAttemptUpdateRequest()
        {
        }

        /// <summary>
        /// This is the ID of the charge attempt that should be updated.
        /// </summary>
        /// <value>This is the ID of the charge attempt that should be updated.</value>
        [DataMember(Name="chargeAttemptId", EmitDefaultValue=true)]
        public long? ChargeAttemptId { get; set; }

        /// <summary>
        /// The end user failure message indicates to the end user (buyer) why the payment failed. The message has to be in the language of the end user. The language is provided within the payment page invocation URL.
        /// </summary>
        /// <value>The end user failure message indicates to the end user (buyer) why the payment failed. The message has to be in the language of the end user. The language is provided within the payment page invocation URL.</value>
        [DataMember(Name="endUserFailureMessage", EmitDefaultValue=true)]
        public string EndUserFailureMessage { get; set; }

        /// <summary>
        /// The failure reason indicates why the charge attempt failed. It is required when the target state is FAILED.
        /// </summary>
        /// <value>The failure reason indicates why the charge attempt failed. It is required when the target state is FAILED.</value>
        [DataMember(Name="failureReasonId", EmitDefaultValue=true)]
        public long? FailureReasonId { get; set; }

        /// <summary>
        /// The reference identifies the charge attempt within the systems of the external service provider. It is required when the target state is SUCCESSFUL.
        /// </summary>
        /// <value>The reference identifies the charge attempt within the systems of the external service provider. It is required when the target state is SUCCESSFUL.</value>
        [DataMember(Name="reference", EmitDefaultValue=true)]
        public string Reference { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentAppChargeAttemptUpdateRequest {\n");
            sb.Append("  ChargeAttemptId: ").Append(ChargeAttemptId).Append("\n");
            sb.Append("  EndUserFailureMessage: ").Append(EndUserFailureMessage).Append("\n");
            sb.Append("  FailureReasonId: ").Append(FailureReasonId).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
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
            return this.Equals(input as PaymentAppChargeAttemptUpdateRequest);
        }

        /// <summary>
        /// Returns true if PaymentAppChargeAttemptUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentAppChargeAttemptUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentAppChargeAttemptUpdateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChargeAttemptId == input.ChargeAttemptId ||
                    (this.ChargeAttemptId != null &&
                    this.ChargeAttemptId.Equals(input.ChargeAttemptId))
                ) && 
                (
                    this.EndUserFailureMessage == input.EndUserFailureMessage ||
                    (this.EndUserFailureMessage != null &&
                    this.EndUserFailureMessage.Equals(input.EndUserFailureMessage))
                ) && 
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
                if (this.ChargeAttemptId != null)
                    hashCode = hashCode * 59 + this.ChargeAttemptId.GetHashCode();
                if (this.EndUserFailureMessage != null)
                    hashCode = hashCode * 59 + this.EndUserFailureMessage.GetHashCode();
                if (this.FailureReasonId != null)
                    hashCode = hashCode * 59 + this.FailureReasonId.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.TargetState != null)
                    hashCode = hashCode * 59 + this.TargetState.GetHashCode();
                return hashCode;
            }
        }

    }

}
