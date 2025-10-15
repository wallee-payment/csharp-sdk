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
    /// DeliveryIndication
    /// </summary>
    [DataContract]
    public partial class DeliveryIndication :  IEquatable<DeliveryIndication>
    {
        /// <summary>
        /// The object&#39;s current state.
        /// </summary>
        /// <value>The object&#39;s current state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public DeliveryIndicationState? State { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryIndication" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public DeliveryIndication()
        {
        }

        /// <summary>
        /// The reason for the automatic system decision about the delivery indication.
        /// </summary>
        /// <value>The reason for the automatic system decision about the delivery indication.</value>
        [DataMember(Name="automaticDecisionReason", EmitDefaultValue=false)]
        public DeliveryIndicationDecisionReason AutomaticDecisionReason { get; private set; }

        /// <summary>
        /// The date and time when an automatic decision was made.
        /// </summary>
        /// <value>The date and time when an automatic decision was made.</value>
        [DataMember(Name="automaticallyDecidedOn", EmitDefaultValue=false)]
        public DateTime? AutomaticallyDecidedOn { get; private set; }

        /// <summary>
        /// The transaction completion that the delivery indication is linked to.
        /// </summary>
        /// <value>The transaction completion that the delivery indication is linked to.</value>
        [DataMember(Name="completion", EmitDefaultValue=false)]
        public long? Completion { get; private set; }

        /// <summary>
        /// The date and time when the object was created.
        /// </summary>
        /// <value>The date and time when the object was created.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

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
        /// The payment transaction this object is linked to.
        /// </summary>
        /// <value>The payment transaction this object is linked to.</value>
        [DataMember(Name="linkedTransaction", EmitDefaultValue=false)]
        public long? LinkedTransaction { get; private set; }

        /// <summary>
        /// The date and time by which a decision must be made before the system automatically proceeds according to the connector&#39;s predefined settings.
        /// </summary>
        /// <value>The date and time by which a decision must be made before the system automatically proceeds according to the connector&#39;s predefined settings.</value>
        [DataMember(Name="manualDecisionTimeoutOn", EmitDefaultValue=false)]
        public DateTime? ManualDecisionTimeoutOn { get; private set; }

        /// <summary>
        /// The ID of the user who manually decided the delivery indication&#39;s state.
        /// </summary>
        /// <value>The ID of the user who manually decided the delivery indication&#39;s state.</value>
        [DataMember(Name="manuallyDecidedBy", EmitDefaultValue=false)]
        public long? ManuallyDecidedBy { get; private set; }

        /// <summary>
        /// The date and time when a manual decision was made.
        /// </summary>
        /// <value>The date and time when a manual decision was made.</value>
        [DataMember(Name="manuallyDecidedOn", EmitDefaultValue=false)]
        public DateTime? ManuallyDecidedOn { get; private set; }

        /// <summary>
        /// The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.
        /// </summary>
        /// <value>The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }


        /// <summary>
        /// The date and time when the delivery indication will expire.
        /// </summary>
        /// <value>The date and time when the delivery indication will expire.</value>
        [DataMember(Name="timeoutOn", EmitDefaultValue=false)]
        public DateTime? TimeoutOn { get; private set; }

        /// <summary>
        /// The payment transaction that the delivery indication is linked to.
        /// </summary>
        /// <value>The payment transaction that the delivery indication is linked to.</value>
        [DataMember(Name="transaction", EmitDefaultValue=false)]
        public Transaction Transaction { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeliveryIndication {\n");
            sb.Append("  AutomaticDecisionReason: ").Append(AutomaticDecisionReason).Append("\n");
            sb.Append("  AutomaticallyDecidedOn: ").Append(AutomaticallyDecidedOn).Append("\n");
            sb.Append("  Completion: ").Append(Completion).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  LinkedTransaction: ").Append(LinkedTransaction).Append("\n");
            sb.Append("  ManualDecisionTimeoutOn: ").Append(ManualDecisionTimeoutOn).Append("\n");
            sb.Append("  ManuallyDecidedBy: ").Append(ManuallyDecidedBy).Append("\n");
            sb.Append("  ManuallyDecidedOn: ").Append(ManuallyDecidedOn).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  TimeoutOn: ").Append(TimeoutOn).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
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
            return this.Equals(input as DeliveryIndication);
        }

        /// <summary>
        /// Returns true if DeliveryIndication instances are equal
        /// </summary>
        /// <param name="input">Instance of DeliveryIndication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliveryIndication input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AutomaticDecisionReason == input.AutomaticDecisionReason ||
                    (this.AutomaticDecisionReason != null &&
                    this.AutomaticDecisionReason.Equals(input.AutomaticDecisionReason))
                ) && 
                (
                    this.AutomaticallyDecidedOn == input.AutomaticallyDecidedOn ||
                    (this.AutomaticallyDecidedOn != null &&
                    this.AutomaticallyDecidedOn.Equals(input.AutomaticallyDecidedOn))
                ) && 
                (
                    this.Completion == input.Completion ||
                    (this.Completion != null &&
                    this.Completion.Equals(input.Completion))
                ) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
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
                    this.LinkedTransaction == input.LinkedTransaction ||
                    (this.LinkedTransaction != null &&
                    this.LinkedTransaction.Equals(input.LinkedTransaction))
                ) && 
                (
                    this.ManualDecisionTimeoutOn == input.ManualDecisionTimeoutOn ||
                    (this.ManualDecisionTimeoutOn != null &&
                    this.ManualDecisionTimeoutOn.Equals(input.ManualDecisionTimeoutOn))
                ) && 
                (
                    this.ManuallyDecidedBy == input.ManuallyDecidedBy ||
                    (this.ManuallyDecidedBy != null &&
                    this.ManuallyDecidedBy.Equals(input.ManuallyDecidedBy))
                ) && 
                (
                    this.ManuallyDecidedOn == input.ManuallyDecidedOn ||
                    (this.ManuallyDecidedOn != null &&
                    this.ManuallyDecidedOn.Equals(input.ManuallyDecidedOn))
                ) && 
                (
                    this.PlannedPurgeDate == input.PlannedPurgeDate ||
                    (this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(input.PlannedPurgeDate))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.TimeoutOn == input.TimeoutOn ||
                    (this.TimeoutOn != null &&
                    this.TimeoutOn.Equals(input.TimeoutOn))
                ) && 
                (
                    this.Transaction == input.Transaction ||
                    (this.Transaction != null &&
                    this.Transaction.Equals(input.Transaction))
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
                if (this.AutomaticDecisionReason != null)
                    hashCode = hashCode * 59 + this.AutomaticDecisionReason.GetHashCode();
                if (this.AutomaticallyDecidedOn != null)
                    hashCode = hashCode * 59 + this.AutomaticallyDecidedOn.GetHashCode();
                if (this.Completion != null)
                    hashCode = hashCode * 59 + this.Completion.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.LinkedTransaction != null)
                    hashCode = hashCode * 59 + this.LinkedTransaction.GetHashCode();
                if (this.ManualDecisionTimeoutOn != null)
                    hashCode = hashCode * 59 + this.ManualDecisionTimeoutOn.GetHashCode();
                if (this.ManuallyDecidedBy != null)
                    hashCode = hashCode * 59 + this.ManuallyDecidedBy.GetHashCode();
                if (this.ManuallyDecidedOn != null)
                    hashCode = hashCode * 59 + this.ManuallyDecidedOn.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.TimeoutOn != null)
                    hashCode = hashCode * 59 + this.TimeoutOn.GetHashCode();
                if (this.Transaction != null)
                    hashCode = hashCode * 59 + this.Transaction.GetHashCode();
                return hashCode;
            }
        }

    }

}
