
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
    /// The installment plan slice defines a single slice of an installment plan.
    /// </summary>
    [DataContract]
    public partial class InstallmentPlanSliceConfiguration :  IEquatable<InstallmentPlanSliceConfiguration>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstallmentPlanSliceConfiguration" /> class.
        /// </summary>
        /// <param name="Id">The ID is the primary key of the entity. The ID identifies the entity uniquely.</param>
        /// <param name="LineItemTitle">The title of this slices line items. The title is visible to the buyer.</param>
        /// <param name="LinkedSpaceId">The linked space id holds the ID of the space to which the entity belongs to.</param>
        /// <param name="Period">The period defines how much time passes between the last slice and this slice. The charge is triggered at the end of the period. When the slice should be charged immediately the period needs to be zero.</param>
        /// <param name="Plan">The installment plan this slice belongs to.</param>
        /// <param name="PlannedPurgeDate">The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</param>
        /// <param name="Priority">The priority controls in which order the slices are applied. The lower the value the higher the precedence.</param>
        /// <param name="Proportion">The proportion defines how much of the total installment payment has to be paid in this slice. The value is summed up with the other slices and the ratio of all proportions compared to proportion of this slice determines how much the buyer has to pay in this slice.</param>
        /// <param name="State">State</param>
        /// <param name="Version">The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</param>
        public InstallmentPlanSliceConfiguration(long? Id = default(long?), DatabaseTranslatedString LineItemTitle = default(DatabaseTranslatedString), long? LinkedSpaceId = default(long?), string Period = default(string), InstallmentPlanConfiguration Plan = default(InstallmentPlanConfiguration), DateTime? PlannedPurgeDate = default(DateTime?), int? Priority = default(int?), decimal? Proportion = default(decimal?), CreationEntityState State = default(CreationEntityState), int? Version = default(int?))
        {
            this.Id = Id;
            this.LineItemTitle = LineItemTitle;
            this.LinkedSpaceId = LinkedSpaceId;
            this.Period = Period;
            this.Plan = Plan;
            this.PlannedPurgeDate = PlannedPurgeDate;
            this.Priority = Priority;
            this.Proportion = Proportion;
            this.State = State;
            this.Version = Version;
        }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The title of this slices line items. The title is visible to the buyer.
        /// </summary>
        /// <value>The title of this slices line items. The title is visible to the buyer.</value>
        [DataMember(Name="lineItemTitle", EmitDefaultValue=false)]
        public DatabaseTranslatedString LineItemTitle { get; set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; set; }

        /// <summary>
        /// The period defines how much time passes between the last slice and this slice. The charge is triggered at the end of the period. When the slice should be charged immediately the period needs to be zero.
        /// </summary>
        /// <value>The period defines how much time passes between the last slice and this slice. The charge is triggered at the end of the period. When the slice should be charged immediately the period needs to be zero.</value>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public string Period { get; set; }

        /// <summary>
        /// The installment plan this slice belongs to.
        /// </summary>
        /// <value>The installment plan this slice belongs to.</value>
        [DataMember(Name="plan", EmitDefaultValue=false)]
        public InstallmentPlanConfiguration Plan { get; set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; set; }

        /// <summary>
        /// The priority controls in which order the slices are applied. The lower the value the higher the precedence.
        /// </summary>
        /// <value>The priority controls in which order the slices are applied. The lower the value the higher the precedence.</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// The proportion defines how much of the total installment payment has to be paid in this slice. The value is summed up with the other slices and the ratio of all proportions compared to proportion of this slice determines how much the buyer has to pay in this slice.
        /// </summary>
        /// <value>The proportion defines how much of the total installment payment has to be paid in this slice. The value is summed up with the other slices and the ratio of all proportions compared to proportion of this slice determines how much the buyer has to pay in this slice.</value>
        [DataMember(Name="proportion", EmitDefaultValue=false)]
        public decimal? Proportion { get; set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public CreationEntityState State { get; set; }

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
            sb.Append("class InstallmentPlanSliceConfiguration {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LineItemTitle: ").Append(LineItemTitle).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Plan: ").Append(Plan).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Proportion: ").Append(Proportion).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(obj as InstallmentPlanSliceConfiguration);
        }

        /// <summary>
        /// Returns true if InstallmentPlanSliceConfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of InstallmentPlanSliceConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstallmentPlanSliceConfiguration other)
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
                    this.LineItemTitle == other.LineItemTitle ||
                    this.LineItemTitle != null &&
                    this.LineItemTitle.Equals(other.LineItemTitle)
                ) && 
                (
                    this.LinkedSpaceId == other.LinkedSpaceId ||
                    this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(other.LinkedSpaceId)
                ) && 
                (
                    this.Period == other.Period ||
                    this.Period != null &&
                    this.Period.Equals(other.Period)
                ) && 
                (
                    this.Plan == other.Plan ||
                    this.Plan != null &&
                    this.Plan.Equals(other.Plan)
                ) && 
                (
                    this.PlannedPurgeDate == other.PlannedPurgeDate ||
                    this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(other.PlannedPurgeDate)
                ) && 
                (
                    this.Priority == other.Priority ||
                    this.Priority != null &&
                    this.Priority.Equals(other.Priority)
                ) && 
                (
                    this.Proportion == other.Proportion ||
                    this.Proportion != null &&
                    this.Proportion.Equals(other.Proportion)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.LineItemTitle != null)
                    hash = hash * 59 + this.LineItemTitle.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hash = hash * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.Period != null)
                    hash = hash * 59 + this.Period.GetHashCode();
                if (this.Plan != null)
                    hash = hash * 59 + this.Plan.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hash = hash * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.Priority != null)
                    hash = hash * 59 + this.Priority.GetHashCode();
                if (this.Proportion != null)
                    hash = hash * 59 + this.Proportion.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                return hash;
            }
        }

    }

}
