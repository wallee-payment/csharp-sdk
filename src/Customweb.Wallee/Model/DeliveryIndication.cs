
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

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// DeliveryIndication model.
    /// </summary>
    [DataContract]
    public partial class DeliveryIndication :  IEquatable<DeliveryIndication>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryIndication" /> class.
        /// </summary>
        /// <param name="Id">The ID is the primary key of the entity. The ID identifies the entity uniquely.</param>
        /// <param name="LinkedSpaceId">The linked space id holds the ID of the space to which the entity belongs to.</param>
        /// <param name="LinkedTransaction">LinkedTransaction</param>
        /// <param name="AutomaticDecisionReason">AutomaticDecisionReason</param>
        /// <param name="AutomaticallyDecidedOn">AutomaticallyDecidedOn</param>
        /// <param name="CreatedOn">The created on date indicates the date on which the entity was stored into the database.</param>
        /// <param name="ManualDecisionTimeoutOn">ManualDecisionTimeoutOn</param>
        /// <param name="ManuallyDecidedBy">ManuallyDecidedBy</param>
        /// <param name="ManuallyDecidedOn">ManuallyDecidedOn</param>
        /// <param name="PlannedPurgeDate">The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</param>
        /// <param name="State">State</param>
        /// <param name="TimeoutOn">TimeoutOn</param>
        /// <param name="Transaction">Transaction</param>
        public DeliveryIndication(long? Id = default(long?), long? LinkedSpaceId = default(long?), long? LinkedTransaction = default(long?), DeliveryIndicationDecisionReason AutomaticDecisionReason = default(DeliveryIndicationDecisionReason), DateTime? AutomaticallyDecidedOn = default(DateTime?), DateTime? CreatedOn = default(DateTime?), DateTime? ManualDecisionTimeoutOn = default(DateTime?), long? ManuallyDecidedBy = default(long?), DateTime? ManuallyDecidedOn = default(DateTime?), DateTime? PlannedPurgeDate = default(DateTime?), DeliveryIndicationState State = default(DeliveryIndicationState), DateTime? TimeoutOn = default(DateTime?), Transaction Transaction = default(Transaction))
        {
            this.Id = Id;
            this.LinkedSpaceId = LinkedSpaceId;
            this.LinkedTransaction = LinkedTransaction;
            this.AutomaticDecisionReason = AutomaticDecisionReason;
            this.AutomaticallyDecidedOn = AutomaticallyDecidedOn;
            this.CreatedOn = CreatedOn;
            this.ManualDecisionTimeoutOn = ManualDecisionTimeoutOn;
            this.ManuallyDecidedBy = ManuallyDecidedBy;
            this.ManuallyDecidedOn = ManuallyDecidedOn;
            this.PlannedPurgeDate = PlannedPurgeDate;
            this.State = State;
            this.TimeoutOn = TimeoutOn;
            this.Transaction = Transaction;
        }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; set; }

        /// <summary>
        /// LinkedTransaction
        /// </summary>
        /// <value>LinkedTransaction</value>
        [DataMember(Name="linkedTransaction", EmitDefaultValue=false)]
        public long? LinkedTransaction { get; set; }

        /// <summary>
        /// AutomaticDecisionReason
        /// </summary>
        /// <value>AutomaticDecisionReason</value>
        [DataMember(Name="automaticDecisionReason", EmitDefaultValue=false)]
        public DeliveryIndicationDecisionReason AutomaticDecisionReason { get; set; }

        /// <summary>
        /// AutomaticallyDecidedOn
        /// </summary>
        /// <value>AutomaticallyDecidedOn</value>
        [DataMember(Name="automaticallyDecidedOn", EmitDefaultValue=false)]
        public DateTime? AutomaticallyDecidedOn { get; set; }

        /// <summary>
        /// The created on date indicates the date on which the entity was stored into the database.
        /// </summary>
        /// <value>The created on date indicates the date on which the entity was stored into the database.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// ManualDecisionTimeoutOn
        /// </summary>
        /// <value>ManualDecisionTimeoutOn</value>
        [DataMember(Name="manualDecisionTimeoutOn", EmitDefaultValue=false)]
        public DateTime? ManualDecisionTimeoutOn { get; set; }

        /// <summary>
        /// ManuallyDecidedBy
        /// </summary>
        /// <value>ManuallyDecidedBy</value>
        [DataMember(Name="manuallyDecidedBy", EmitDefaultValue=false)]
        public long? ManuallyDecidedBy { get; set; }

        /// <summary>
        /// ManuallyDecidedOn
        /// </summary>
        /// <value>ManuallyDecidedOn</value>
        [DataMember(Name="manuallyDecidedOn", EmitDefaultValue=false)]
        public DateTime? ManuallyDecidedOn { get; set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public DeliveryIndicationState State { get; set; }

        /// <summary>
        /// TimeoutOn
        /// </summary>
        /// <value>TimeoutOn</value>
        [DataMember(Name="timeoutOn", EmitDefaultValue=false)]
        public DateTime? TimeoutOn { get; set; }

        /// <summary>
        /// Transaction
        /// </summary>
        /// <value>Transaction</value>
        [DataMember(Name="transaction", EmitDefaultValue=false)]
        public Transaction Transaction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeliveryIndication {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  LinkedTransaction: ").Append(LinkedTransaction).Append("\n");
            sb.Append("  AutomaticDecisionReason: ").Append(AutomaticDecisionReason).Append("\n");
            sb.Append("  AutomaticallyDecidedOn: ").Append(AutomaticallyDecidedOn).Append("\n");
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
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            return this.Equals(obj as DeliveryIndication);
        }

        /// <summary>
        /// Returns true if DeliveryIndication instances are equal
        /// </summary>
        /// <param name="other">Instance of DeliveryIndication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliveryIndication other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.LinkedSpaceId == other.LinkedSpaceId ||
                    this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(other.LinkedSpaceId)
                ) && 
                (
                    this.LinkedTransaction == other.LinkedTransaction ||
                    this.LinkedTransaction != null &&
                    this.LinkedTransaction.Equals(other.LinkedTransaction)
                ) && 
                (
                    this.AutomaticDecisionReason == other.AutomaticDecisionReason ||
                    this.AutomaticDecisionReason != null &&
                    this.AutomaticDecisionReason.Equals(other.AutomaticDecisionReason)
                ) && 
                (
                    this.AutomaticallyDecidedOn == other.AutomaticallyDecidedOn ||
                    this.AutomaticallyDecidedOn != null &&
                    this.AutomaticallyDecidedOn.Equals(other.AutomaticallyDecidedOn)
                ) && 
                (
                    this.CreatedOn == other.CreatedOn ||
                    this.CreatedOn != null &&
                    this.CreatedOn.Equals(other.CreatedOn)
                ) && 
                (
                    this.ManualDecisionTimeoutOn == other.ManualDecisionTimeoutOn ||
                    this.ManualDecisionTimeoutOn != null &&
                    this.ManualDecisionTimeoutOn.Equals(other.ManualDecisionTimeoutOn)
                ) && 
                (
                    this.ManuallyDecidedBy == other.ManuallyDecidedBy ||
                    this.ManuallyDecidedBy != null &&
                    this.ManuallyDecidedBy.Equals(other.ManuallyDecidedBy)
                ) && 
                (
                    this.ManuallyDecidedOn == other.ManuallyDecidedOn ||
                    this.ManuallyDecidedOn != null &&
                    this.ManuallyDecidedOn.Equals(other.ManuallyDecidedOn)
                ) && 
                (
                    this.PlannedPurgeDate == other.PlannedPurgeDate ||
                    this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(other.PlannedPurgeDate)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.TimeoutOn == other.TimeoutOn ||
                    this.TimeoutOn != null &&
                    this.TimeoutOn.Equals(other.TimeoutOn)
                ) && 
                (
                    this.Transaction == other.Transaction ||
                    this.Transaction != null &&
                    this.Transaction.Equals(other.Transaction)
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
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hash = hash * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.LinkedTransaction != null)
                    hash = hash * 59 + this.LinkedTransaction.GetHashCode();
                if (this.AutomaticDecisionReason != null)
                    hash = hash * 59 + this.AutomaticDecisionReason.GetHashCode();
                if (this.AutomaticallyDecidedOn != null)
                    hash = hash * 59 + this.AutomaticallyDecidedOn.GetHashCode();
                if (this.CreatedOn != null)
                    hash = hash * 59 + this.CreatedOn.GetHashCode();
                if (this.ManualDecisionTimeoutOn != null)
                    hash = hash * 59 + this.ManualDecisionTimeoutOn.GetHashCode();
                if (this.ManuallyDecidedBy != null)
                    hash = hash * 59 + this.ManuallyDecidedBy.GetHashCode();
                if (this.ManuallyDecidedOn != null)
                    hash = hash * 59 + this.ManuallyDecidedOn.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hash = hash * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.TimeoutOn != null)
                    hash = hash * 59 + this.TimeoutOn.GetHashCode();
                if (this.Transaction != null)
                    hash = hash * 59 + this.Transaction.GetHashCode();
                return hash;
            }
        }

    }

}
