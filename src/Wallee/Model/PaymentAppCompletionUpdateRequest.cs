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
    /// The completion update request allows to change the state of a completion. The completion must be linked with a processor that was created by the payment Web App that invokes the operation.
    /// </summary>
    [DataContract]
    public partial class PaymentAppCompletionUpdateRequest :  IEquatable<PaymentAppCompletionUpdateRequest>
    {
        /// <summary>
        /// The target state defines the state into which the completion should be switched into. Once the completion changed the state it will not be possible to change it again.
        /// </summary>
        /// <value>The target state defines the state into which the completion should be switched into. Once the completion changed the state it will not be possible to change it again.</value>
        [DataMember(Name="targetState", EmitDefaultValue=false)]
        public PaymentAppCompletionTargetState? TargetState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentAppCompletionUpdateRequest" /> class.
        /// </summary>
        public PaymentAppCompletionUpdateRequest()
        {
        }

        /// <summary>
        /// This is the ID of the completion that should be updated.
        /// </summary>
        /// <value>This is the ID of the completion that should be updated.</value>
        [DataMember(Name="completionId", EmitDefaultValue=false)]
        public long? CompletionId { get; set; }

        /// <summary>
        /// The failure reason indicates why the completion failed. It is required when the target state is FAILED.
        /// </summary>
        /// <value>The failure reason indicates why the completion failed. It is required when the target state is FAILED.</value>
        [DataMember(Name="failureReasonId", EmitDefaultValue=false)]
        public long? FailureReasonId { get; set; }

        /// <summary>
        /// The reference identifies the completion within the systems of the external service provider. It is required when the target state is SUCCESSFUL.
        /// </summary>
        /// <value>The reference identifies the completion within the systems of the external service provider. It is required when the target state is SUCCESSFUL.</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentAppCompletionUpdateRequest {\n");
            sb.Append("  CompletionId: ").Append(CompletionId).Append("\n");
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
            return this.Equals(input as PaymentAppCompletionUpdateRequest);
        }

        /// <summary>
        /// Returns true if PaymentAppCompletionUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentAppCompletionUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentAppCompletionUpdateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CompletionId == input.CompletionId ||
                    (this.CompletionId != null &&
                    this.CompletionId.Equals(input.CompletionId))
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
                if (this.CompletionId != null)
                    hashCode = hashCode * 59 + this.CompletionId.GetHashCode();
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
