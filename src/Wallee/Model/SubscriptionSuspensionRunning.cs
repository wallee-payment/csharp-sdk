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
    /// SubscriptionSuspensionRunning
    /// </summary>
    [DataContract]
    public partial class SubscriptionSuspensionRunning : SubscriptionSuspension,  IEquatable<SubscriptionSuspensionRunning>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionSuspensionRunning" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public SubscriptionSuspensionRunning()
        {
        }















        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionSuspensionRunning {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
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
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubscriptionSuspensionRunning);
        }

        /// <summary>
        /// Returns true if SubscriptionSuspensionRunning instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionSuspensionRunning to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionSuspensionRunning input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && base.Equals(input) && 
                (
                    this.EffectiveEndDate == input.EffectiveEndDate ||
                    (this.EffectiveEndDate != null &&
                    this.EffectiveEndDate.Equals(input.EffectiveEndDate))
                ) && base.Equals(input) && 
                (
                    this.EndAction == input.EndAction ||
                    (this.EndAction != null &&
                    this.EndAction.Equals(input.EndAction))
                ) && base.Equals(input) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && base.Equals(input) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && base.Equals(input) && 
                (
                    this.LinkedSpaceId == input.LinkedSpaceId ||
                    (this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(input.LinkedSpaceId))
                ) && base.Equals(input) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
                ) && base.Equals(input) && 
                (
                    this.PeriodBill == input.PeriodBill ||
                    (this.PeriodBill != null &&
                    this.PeriodBill.Equals(input.PeriodBill))
                ) && base.Equals(input) && 
                (
                    this.PlannedEndDate == input.PlannedEndDate ||
                    (this.PlannedEndDate != null &&
                    this.PlannedEndDate.Equals(input.PlannedEndDate))
                ) && base.Equals(input) && 
                (
                    this.PlannedPurgeDate == input.PlannedPurgeDate ||
                    (this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(input.PlannedPurgeDate))
                ) && base.Equals(input) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && base.Equals(input) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && base.Equals(input) && 
                (
                    this.Subscription == input.Subscription ||
                    (this.Subscription != null &&
                    this.Subscription.Equals(input.Subscription))
                ) && base.Equals(input) && 
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
                int hashCode = base.GetHashCode();
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
