
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
    /// SubscriptionSuspensionRunning model.
    /// </summary>
    [DataContract]
    public partial class SubscriptionSuspensionRunning :  IEquatable<SubscriptionSuspensionRunning>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionSuspensionRunning" /> class.
        /// </summary>
        /// <param name="CreatedOn">The created on date indicates the date on which the entity was stored into the database.</param>
        /// <param name="EffectiveEndDate">EffectiveEndDate</param>
        /// <param name="EndAction">When the suspension reaches the planned end date the end action will be carried out. This action is only executed when the suspension is ended automatically based on the end date.</param>
        /// <param name="Id">The ID is the primary key of the entity. The ID identifies the entity uniquely.</param>
        /// <param name="Language">Language</param>
        /// <param name="LinkedSpaceId">The linked space id holds the ID of the space to which the entity belongs to.</param>
        /// <param name="Note">The note may contain some internal information for the suspension. The note will not be disclosed to the subscriber.</param>
        /// <param name="PeriodBill">PeriodBill</param>
        /// <param name="PlannedEndDate">The planned end date of the suspension identifies the date on which the suspension will be ended automatically.</param>
        /// <param name="PlannedPurgeDate">The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</param>
        /// <param name="Reason">The suspension reason indicates why a suspension has been created.</param>
        /// <param name="State">State</param>
        /// <param name="Subscription">Subscription</param>
        /// <param name="Version">The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</param>
        public SubscriptionSuspensionRunning(DateTime? CreatedOn = default(DateTime?), DateTime? EffectiveEndDate = default(DateTime?), SubscriptionSuspensionAction EndAction = default(SubscriptionSuspensionAction), long? Id = default(long?), string Language = default(string), long? LinkedSpaceId = default(long?), string Note = default(string), long? PeriodBill = default(long?), DateTime? PlannedEndDate = default(DateTime?), DateTime? PlannedPurgeDate = default(DateTime?), SubscriptionSuspensionReason Reason = default(SubscriptionSuspensionReason), SubscriptionSuspensionState State = default(SubscriptionSuspensionState), long? Subscription = default(long?), int? Version = default(int?))
        {
            this.CreatedOn = CreatedOn;
            this.EffectiveEndDate = EffectiveEndDate;
            this.EndAction = EndAction;
            this.Id = Id;
            this.Language = Language;
            this.LinkedSpaceId = LinkedSpaceId;
            this.Note = Note;
            this.PeriodBill = PeriodBill;
            this.PlannedEndDate = PlannedEndDate;
            this.PlannedPurgeDate = PlannedPurgeDate;
            this.Reason = Reason;
            this.State = State;
            this.Subscription = Subscription;
            this.Version = Version;
        }

        /// <summary>
        /// The created on date indicates the date on which the entity was stored into the database.
        /// </summary>
        /// <value>The created on date indicates the date on which the entity was stored into the database.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// EffectiveEndDate
        /// </summary>
        /// <value>EffectiveEndDate</value>
        [DataMember(Name="effectiveEndDate", EmitDefaultValue=false)]
        public DateTime? EffectiveEndDate { get; set; }

        /// <summary>
        /// When the suspension reaches the planned end date the end action will be carried out. This action is only executed when the suspension is ended automatically based on the end date.
        /// </summary>
        /// <value>When the suspension reaches the planned end date the end action will be carried out. This action is only executed when the suspension is ended automatically based on the end date.</value>
        [DataMember(Name="endAction", EmitDefaultValue=false)]
        public SubscriptionSuspensionAction EndAction { get; set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Language
        /// </summary>
        /// <value>Language</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; set; }

        /// <summary>
        /// The note may contain some internal information for the suspension. The note will not be disclosed to the subscriber.
        /// </summary>
        /// <value>The note may contain some internal information for the suspension. The note will not be disclosed to the subscriber.</value>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }

        /// <summary>
        /// PeriodBill
        /// </summary>
        /// <value>PeriodBill</value>
        [DataMember(Name="periodBill", EmitDefaultValue=false)]
        public long? PeriodBill { get; set; }

        /// <summary>
        /// The planned end date of the suspension identifies the date on which the suspension will be ended automatically.
        /// </summary>
        /// <value>The planned end date of the suspension identifies the date on which the suspension will be ended automatically.</value>
        [DataMember(Name="plannedEndDate", EmitDefaultValue=false)]
        public DateTime? PlannedEndDate { get; set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; set; }

        /// <summary>
        /// The suspension reason indicates why a suspension has been created.
        /// </summary>
        /// <value>The suspension reason indicates why a suspension has been created.</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public SubscriptionSuspensionReason Reason { get; set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public SubscriptionSuspensionState State { get; set; }

        /// <summary>
        /// Subscription
        /// </summary>
        /// <value>Subscription</value>
        [DataMember(Name="subscription", EmitDefaultValue=false)]
        public long? Subscription { get; set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionSuspensionRunning {\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  EffectiveEndDate: ").Append(EffectiveEndDate).Append("\n");
            sb.Append("  EndAction: ").Append(EndAction).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  PeriodBill: ").Append(PeriodBill).Append("\n");
            sb.Append("  PlannedEndDate: ").Append(PlannedEndDate).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(obj as SubscriptionSuspensionRunning);
        }

        /// <summary>
        /// Returns true if SubscriptionSuspensionRunning instances are equal
        /// </summary>
        /// <param name="other">Instance of SubscriptionSuspensionRunning to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionSuspensionRunning other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.CreatedOn == other.CreatedOn ||
                    this.CreatedOn != null &&
                    this.CreatedOn.Equals(other.CreatedOn)
                ) && 
                (
                    this.EffectiveEndDate == other.EffectiveEndDate ||
                    this.EffectiveEndDate != null &&
                    this.EffectiveEndDate.Equals(other.EffectiveEndDate)
                ) && 
                (
                    this.EndAction == other.EndAction ||
                    this.EndAction != null &&
                    this.EndAction.Equals(other.EndAction)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.LinkedSpaceId == other.LinkedSpaceId ||
                    this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(other.LinkedSpaceId)
                ) && 
                (
                    this.Note == other.Note ||
                    this.Note != null &&
                    this.Note.Equals(other.Note)
                ) && 
                (
                    this.PeriodBill == other.PeriodBill ||
                    this.PeriodBill != null &&
                    this.PeriodBill.Equals(other.PeriodBill)
                ) && 
                (
                    this.PlannedEndDate == other.PlannedEndDate ||
                    this.PlannedEndDate != null &&
                    this.PlannedEndDate.Equals(other.PlannedEndDate)
                ) && 
                (
                    this.PlannedPurgeDate == other.PlannedPurgeDate ||
                    this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(other.PlannedPurgeDate)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Subscription == other.Subscription ||
                    this.Subscription != null &&
                    this.Subscription.Equals(other.Subscription)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                if (this.CreatedOn != null)
                    hash = hash * 59 + this.CreatedOn.GetHashCode();
                if (this.EffectiveEndDate != null)
                    hash = hash * 59 + this.EffectiveEndDate.GetHashCode();
                if (this.EndAction != null)
                    hash = hash * 59 + this.EndAction.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hash = hash * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.Note != null)
                    hash = hash * 59 + this.Note.GetHashCode();
                if (this.PeriodBill != null)
                    hash = hash * 59 + this.PeriodBill.GetHashCode();
                if (this.PlannedEndDate != null)
                    hash = hash * 59 + this.PlannedEndDate.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hash = hash * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Subscription != null)
                    hash = hash * 59 + this.Subscription.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                return hash;
            }
        }

    }

}
