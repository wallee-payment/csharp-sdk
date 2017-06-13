
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
    /// SubscriptionPeriodBill model.
    /// </summary>
    [DataContract]
    public partial class SubscriptionPeriodBill :  IEquatable<SubscriptionPeriodBill>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPeriodBill" /> class.
        /// </summary>
        /// <param name="CreatedOn">CreatedOn</param>
        /// <param name="EffectivePeriodEndDate">EffectivePeriodEndDate</param>
        /// <param name="Id">The ID is the primary key of the entity. The ID identifies the entity uniquely.</param>
        /// <param name="Language">Language</param>
        /// <param name="LinkedSpaceId">The linked space id holds the ID of the space to which the entity belongs to.</param>
        /// <param name="PeriodStartDate">PeriodStartDate</param>
        /// <param name="PlannedPeriodEndDate">PlannedPeriodEndDate</param>
        /// <param name="PlannedPurgeDate">The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</param>
        /// <param name="State">State</param>
        /// <param name="SubscriptionVersion">SubscriptionVersion</param>
        /// <param name="Version">The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</param>
        public SubscriptionPeriodBill(DateTime? CreatedOn = default(DateTime?), DateTime? EffectivePeriodEndDate = default(DateTime?), long? Id = default(long?), string Language = default(string), long? LinkedSpaceId = default(long?), DateTime? PeriodStartDate = default(DateTime?), DateTime? PlannedPeriodEndDate = default(DateTime?), DateTime? PlannedPurgeDate = default(DateTime?), SubscriptionPeriodBillState State = default(SubscriptionPeriodBillState), SubscriptionVersion SubscriptionVersion = default(SubscriptionVersion), int? Version = default(int?))
        {
            this.CreatedOn = CreatedOn;
            this.EffectivePeriodEndDate = EffectivePeriodEndDate;
            this.Id = Id;
            this.Language = Language;
            this.LinkedSpaceId = LinkedSpaceId;
            this.PeriodStartDate = PeriodStartDate;
            this.PlannedPeriodEndDate = PlannedPeriodEndDate;
            this.PlannedPurgeDate = PlannedPurgeDate;
            this.State = State;
            this.SubscriptionVersion = SubscriptionVersion;
            this.Version = Version;
        }

        /// <summary>
        /// CreatedOn
        /// </summary>
        /// <value>CreatedOn</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// EffectivePeriodEndDate
        /// </summary>
        /// <value>EffectivePeriodEndDate</value>
        [DataMember(Name="effectivePeriodEndDate", EmitDefaultValue=false)]
        public DateTime? EffectivePeriodEndDate { get; set; }

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
        /// PeriodStartDate
        /// </summary>
        /// <value>PeriodStartDate</value>
        [DataMember(Name="periodStartDate", EmitDefaultValue=false)]
        public DateTime? PeriodStartDate { get; set; }

        /// <summary>
        /// PlannedPeriodEndDate
        /// </summary>
        /// <value>PlannedPeriodEndDate</value>
        [DataMember(Name="plannedPeriodEndDate", EmitDefaultValue=false)]
        public DateTime? PlannedPeriodEndDate { get; set; }

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
        public SubscriptionPeriodBillState State { get; set; }

        /// <summary>
        /// SubscriptionVersion
        /// </summary>
        /// <value>SubscriptionVersion</value>
        [DataMember(Name="subscriptionVersion", EmitDefaultValue=false)]
        public SubscriptionVersion SubscriptionVersion { get; set; }

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
            return this.Equals(obj as SubscriptionPeriodBill);
        }

        /// <summary>
        /// Returns true if SubscriptionPeriodBill instances are equal
        /// </summary>
        /// <param name="other">Instance of SubscriptionPeriodBill to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionPeriodBill other)
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
                    this.EffectivePeriodEndDate == other.EffectivePeriodEndDate ||
                    this.EffectivePeriodEndDate != null &&
                    this.EffectivePeriodEndDate.Equals(other.EffectivePeriodEndDate)
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
                    this.PeriodStartDate == other.PeriodStartDate ||
                    this.PeriodStartDate != null &&
                    this.PeriodStartDate.Equals(other.PeriodStartDate)
                ) && 
                (
                    this.PlannedPeriodEndDate == other.PlannedPeriodEndDate ||
                    this.PlannedPeriodEndDate != null &&
                    this.PlannedPeriodEndDate.Equals(other.PlannedPeriodEndDate)
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
                    this.SubscriptionVersion == other.SubscriptionVersion ||
                    this.SubscriptionVersion != null &&
                    this.SubscriptionVersion.Equals(other.SubscriptionVersion)
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
                if (this.EffectivePeriodEndDate != null)
                    hash = hash * 59 + this.EffectivePeriodEndDate.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hash = hash * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.PeriodStartDate != null)
                    hash = hash * 59 + this.PeriodStartDate.GetHashCode();
                if (this.PlannedPeriodEndDate != null)
                    hash = hash * 59 + this.PlannedPeriodEndDate.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hash = hash * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.SubscriptionVersion != null)
                    hash = hash * 59 + this.SubscriptionVersion.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                return hash;
            }
        }

    }

}
