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
    /// SubscriptionPeriodBill
    /// </summary>
    [DataContract]
    public partial class SubscriptionPeriodBill :  IEquatable<SubscriptionPeriodBill>
    {
        /// <summary>
        /// The object&#39;s current state.
        /// </summary>
        /// <value>The object&#39;s current state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public SubscriptionPeriodBillState? State { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPeriodBill" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public SubscriptionPeriodBill()
        {
        }

        /// <summary>
        /// The date and time when the period bill was created.
        /// </summary>
        /// <value>The date and time when the period bill was created.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// The date and time when the period actually ended.
        /// </summary>
        /// <value>The date and time when the period actually ended.</value>
        [DataMember(Name="effectivePeriodEndDate", EmitDefaultValue=false)]
        public DateTime? EffectivePeriodEndDate { get; private set; }

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
        /// The date and time when the period started.
        /// </summary>
        /// <value>The date and time when the period started.</value>
        [DataMember(Name="periodStartDate", EmitDefaultValue=false)]
        public DateTime? PeriodStartDate { get; private set; }

        /// <summary>
        /// The date and time when the period is planned to end.
        /// </summary>
        /// <value>The date and time when the period is planned to end.</value>
        [DataMember(Name="plannedPeriodEndDate", EmitDefaultValue=false)]
        public DateTime? PlannedPeriodEndDate { get; private set; }

        /// <summary>
        /// The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.
        /// </summary>
        /// <value>The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }


        /// <summary>
        /// The subscription version that the period bill belongs to.
        /// </summary>
        /// <value>The subscription version that the period bill belongs to.</value>
        [DataMember(Name="subscriptionVersion", EmitDefaultValue=false)]
        public SubscriptionVersion SubscriptionVersion { get; private set; }

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
            sb.Append("class SubscriptionPeriodBill {\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  EffectivePeriodEndDate: ").Append(EffectivePeriodEndDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  PeriodStartDate: ").Append(PeriodStartDate).Append("\n");
            sb.Append("  PlannedPeriodEndDate: ").Append(PlannedPeriodEndDate).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  SubscriptionVersion: ").Append(SubscriptionVersion).Append("\n");
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
            return this.Equals(input as SubscriptionPeriodBill);
        }

        /// <summary>
        /// Returns true if SubscriptionPeriodBill instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionPeriodBill to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionPeriodBill input)
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
                    this.EffectivePeriodEndDate == input.EffectivePeriodEndDate ||
                    (this.EffectivePeriodEndDate != null &&
                    this.EffectivePeriodEndDate.Equals(input.EffectivePeriodEndDate))
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
                    this.PeriodStartDate == input.PeriodStartDate ||
                    (this.PeriodStartDate != null &&
                    this.PeriodStartDate.Equals(input.PeriodStartDate))
                ) && 
                (
                    this.PlannedPeriodEndDate == input.PlannedPeriodEndDate ||
                    (this.PlannedPeriodEndDate != null &&
                    this.PlannedPeriodEndDate.Equals(input.PlannedPeriodEndDate))
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
                    this.SubscriptionVersion == input.SubscriptionVersion ||
                    (this.SubscriptionVersion != null &&
                    this.SubscriptionVersion.Equals(input.SubscriptionVersion))
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
                if (this.EffectivePeriodEndDate != null)
                    hashCode = hashCode * 59 + this.EffectivePeriodEndDate.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.PeriodStartDate != null)
                    hashCode = hashCode * 59 + this.PeriodStartDate.GetHashCode();
                if (this.PlannedPeriodEndDate != null)
                    hashCode = hashCode * 59 + this.PlannedPeriodEndDate.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.SubscriptionVersion != null)
                    hashCode = hashCode * 59 + this.SubscriptionVersion.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
