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
    public partial class DeliveryIndication : TransactionAwareEntity,  IEquatable<DeliveryIndication>
    {
        /// <summary>
        /// Gets or Sets State
        /// </summary>
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
        /// Gets or Sets AutomaticDecisionReason
        /// </summary>
        [DataMember(Name="automaticDecisionReason", EmitDefaultValue=false)]
        public DeliveryIndicationDecisionReason AutomaticDecisionReason { get; private set; }

        /// <summary>
        /// Gets or Sets AutomaticallyDecidedOn
        /// </summary>
        [DataMember(Name="automaticallyDecidedOn", EmitDefaultValue=false)]
        public DateTime? AutomaticallyDecidedOn { get; private set; }

        /// <summary>
        /// Gets or Sets Completion
        /// </summary>
        [DataMember(Name="completion", EmitDefaultValue=false)]
        public long? Completion { get; private set; }

        /// <summary>
        /// The created on date indicates the date on which the entity was stored into the database.
        /// </summary>
        /// <value>The created on date indicates the date on which the entity was stored into the database.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// Gets or Sets ManualDecisionTimeoutOn
        /// </summary>
        [DataMember(Name="manualDecisionTimeoutOn", EmitDefaultValue=false)]
        public DateTime? ManualDecisionTimeoutOn { get; private set; }

        /// <summary>
        /// Gets or Sets ManuallyDecidedBy
        /// </summary>
        [DataMember(Name="manuallyDecidedBy", EmitDefaultValue=false)]
        public long? ManuallyDecidedBy { get; private set; }

        /// <summary>
        /// Gets or Sets ManuallyDecidedOn
        /// </summary>
        [DataMember(Name="manuallyDecidedOn", EmitDefaultValue=false)]
        public DateTime? ManuallyDecidedOn { get; private set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }


        /// <summary>
        /// Gets or Sets TimeoutOn
        /// </summary>
        [DataMember(Name="timeoutOn", EmitDefaultValue=false)]
        public DateTime? TimeoutOn { get; private set; }

        /// <summary>
        /// Gets or Sets Transaction
        /// </summary>
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
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  LinkedTransaction: ").Append(LinkedTransaction).Append("\n");
            sb.Append("  AutomaticDecisionReason: ").Append(AutomaticDecisionReason).Append("\n");
            sb.Append("  AutomaticallyDecidedOn: ").Append(AutomaticallyDecidedOn).Append("\n");
            sb.Append("  Completion: ").Append(Completion).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
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
        public override string ToJson()
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

            return base.Equals(input) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && base.Equals(input) && 
                (
                    this.LinkedSpaceId == input.LinkedSpaceId ||
                    (this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(input.LinkedSpaceId))
                ) && base.Equals(input) && 
                (
                    this.LinkedTransaction == input.LinkedTransaction ||
                    (this.LinkedTransaction != null &&
                    this.LinkedTransaction.Equals(input.LinkedTransaction))
                ) && base.Equals(input) && 
                (
                    this.AutomaticDecisionReason == input.AutomaticDecisionReason ||
                    (this.AutomaticDecisionReason != null &&
                    this.AutomaticDecisionReason.Equals(input.AutomaticDecisionReason))
                ) && base.Equals(input) && 
                (
                    this.AutomaticallyDecidedOn == input.AutomaticallyDecidedOn ||
                    (this.AutomaticallyDecidedOn != null &&
                    this.AutomaticallyDecidedOn.Equals(input.AutomaticallyDecidedOn))
                ) && base.Equals(input) && 
                (
                    this.Completion == input.Completion ||
                    (this.Completion != null &&
                    this.Completion.Equals(input.Completion))
                ) && base.Equals(input) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && base.Equals(input) && 
                (
                    this.ManualDecisionTimeoutOn == input.ManualDecisionTimeoutOn ||
                    (this.ManualDecisionTimeoutOn != null &&
                    this.ManualDecisionTimeoutOn.Equals(input.ManualDecisionTimeoutOn))
                ) && base.Equals(input) && 
                (
                    this.ManuallyDecidedBy == input.ManuallyDecidedBy ||
                    (this.ManuallyDecidedBy != null &&
                    this.ManuallyDecidedBy.Equals(input.ManuallyDecidedBy))
                ) && base.Equals(input) && 
                (
                    this.ManuallyDecidedOn == input.ManuallyDecidedOn ||
                    (this.ManuallyDecidedOn != null &&
                    this.ManuallyDecidedOn.Equals(input.ManuallyDecidedOn))
                ) && base.Equals(input) && 
                (
                    this.PlannedPurgeDate == input.PlannedPurgeDate ||
                    (this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(input.PlannedPurgeDate))
                ) && base.Equals(input) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && base.Equals(input) && 
                (
                    this.TimeoutOn == input.TimeoutOn ||
                    (this.TimeoutOn != null &&
                    this.TimeoutOn.Equals(input.TimeoutOn))
                ) && base.Equals(input) && 
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
                int hashCode = base.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.LinkedTransaction != null)
                    hashCode = hashCode * 59 + this.LinkedTransaction.GetHashCode();
                if (this.AutomaticDecisionReason != null)
                    hashCode = hashCode * 59 + this.AutomaticDecisionReason.GetHashCode();
                if (this.AutomaticallyDecidedOn != null)
                    hashCode = hashCode * 59 + this.AutomaticallyDecidedOn.GetHashCode();
                if (this.Completion != null)
                    hashCode = hashCode * 59 + this.Completion.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
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
