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
    /// SubscriptionSuspension
    /// </summary>
    [DataContract]
    public partial class SubscriptionSuspension :  IEquatable<SubscriptionSuspension>
    {
        /// <summary>
        /// Whether the subscription should be terminated or reactivated after the suspension has reached its end date.
        /// </summary>
        /// <value>Whether the subscription should be terminated or reactivated after the suspension has reached its end date.</value>
        [DataMember(Name="endAction", EmitDefaultValue=false)]
        public SubscriptionSuspensionAction? EndAction { get; private set; }
        /// <summary>
        /// The reason why the subscription was suspended.
        /// </summary>
        /// <value>The reason why the subscription was suspended.</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public SubscriptionSuspensionReason? Reason { get; private set; }
        /// <summary>
        /// The object&#39;s current state.
        /// </summary>
        /// <value>The object&#39;s current state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public SubscriptionSuspensionState? State { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionSuspension" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public SubscriptionSuspension()
        {
        }

        /// <summary>
        /// The date and time when the object was created.
        /// </summary>
        /// <value>The date and time when the object was created.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// The date and time when the suspension ended.
        /// </summary>
        /// <value>The date and time when the suspension ended.</value>
        [DataMember(Name="effectiveEndDate", EmitDefaultValue=false)]
        public DateTime? EffectiveEndDate { get; private set; }


        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The language that is linked to the object.
        /// </summary>
        /// <value>The language that is linked to the object.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; private set; }

        /// <summary>
        /// The ID of the space this object belongs to.
        /// </summary>
        /// <value>The ID of the space this object belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// A note that contains details about the suspension. It is not disclosed to the subscriber.
        /// </summary>
        /// <value>A note that contains details about the suspension. It is not disclosed to the subscriber.</value>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; private set; }

        /// <summary>
        /// The period bill that led to the suspension of the subscription.
        /// </summary>
        /// <value>The period bill that led to the suspension of the subscription.</value>
        [DataMember(Name="periodBill", EmitDefaultValue=false)]
        public long? PeriodBill { get; private set; }

        /// <summary>
        /// The date and time when the suspension is planned to end.
        /// </summary>
        /// <value>The date and time when the suspension is planned to end.</value>
        [DataMember(Name="plannedEndDate", EmitDefaultValue=false)]
        public DateTime? PlannedEndDate { get; private set; }

        /// <summary>
        /// The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.
        /// </summary>
        /// <value>The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }



        /// <summary>
        /// The subscription that this suspension belongs to.
        /// </summary>
        /// <value>The subscription that this suspension belongs to.</value>
        [DataMember(Name="subscription", EmitDefaultValue=false)]
        public long? Subscription { get; private set; }

        /// <summary>
        /// The version is used for optimistic locking and incremented whenever the object is updated.
        /// </summary>
        /// <value>The version is used for optimistic locking and incremented whenever the object is updated.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionSuspension {\n");
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
            return this.Equals(input as SubscriptionSuspension);
        }

        /// <summary>
        /// Returns true if SubscriptionSuspension instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionSuspension to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionSuspension input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && 
                (
                    this.EffectiveEndDate == input.EffectiveEndDate ||
                    (this.EffectiveEndDate != null &&
                    this.EffectiveEndDate.Equals(input.EffectiveEndDate))
                ) && 
                (
                    this.EndAction == input.EndAction ||
                    (this.EndAction != null &&
                    this.EndAction.Equals(input.EndAction))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.LinkedSpaceId == input.LinkedSpaceId ||
                    (this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(input.LinkedSpaceId))
                ) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
                ) && 
                (
                    this.PeriodBill == input.PeriodBill ||
                    (this.PeriodBill != null &&
                    this.PeriodBill.Equals(input.PeriodBill))
                ) && 
                (
                    this.PlannedEndDate == input.PlannedEndDate ||
                    (this.PlannedEndDate != null &&
                    this.PlannedEndDate.Equals(input.PlannedEndDate))
                ) && 
                (
                    this.PlannedPurgeDate == input.PlannedPurgeDate ||
                    (this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(input.PlannedPurgeDate))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Subscription == input.Subscription ||
                    (this.Subscription != null &&
                    this.Subscription.Equals(input.Subscription))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.EffectiveEndDate != null)
                    hashCode = hashCode * 59 + this.EffectiveEndDate.GetHashCode();
                if (this.EndAction != null)
                    hashCode = hashCode * 59 + this.EndAction.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.Note != null)
                    hashCode = hashCode * 59 + this.Note.GetHashCode();
                if (this.PeriodBill != null)
                    hashCode = hashCode * 59 + this.PeriodBill.GetHashCode();
                if (this.PlannedEndDate != null)
                    hashCode = hashCode * 59 + this.PlannedEndDate.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Subscription != null)
                    hashCode = hashCode * 59 + this.Subscription.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
