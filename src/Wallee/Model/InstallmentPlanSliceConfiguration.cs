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
    /// The installment plan slice defines a single slice of an installment plan.
    /// </summary>
    [DataContract]
    public partial class InstallmentPlanSliceConfiguration :  IEquatable<InstallmentPlanSliceConfiguration>
    {
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public CreationEntityState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InstallmentPlanSliceConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public InstallmentPlanSliceConfiguration()
        {
        }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The title of this slices line items. The title is visible to the buyer.
        /// </summary>
        /// <value>The title of this slices line items. The title is visible to the buyer.</value>
        [DataMember(Name="lineItemTitle", EmitDefaultValue=false)]
        public DatabaseTranslatedString LineItemTitle { get; private set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// The period defines how much time passes between the last slice and this slice. The charge is triggered at the end of the period. When the slice should be charged immediately the period needs to be zero.
        /// </summary>
        /// <value>The period defines how much time passes between the last slice and this slice. The charge is triggered at the end of the period. When the slice should be charged immediately the period needs to be zero.</value>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public string Period { get; private set; }

        /// <summary>
        /// The installment plan this slice belongs to.
        /// </summary>
        /// <value>The installment plan this slice belongs to.</value>
        [DataMember(Name="plan", EmitDefaultValue=false)]
        public InstallmentPlanConfiguration Plan { get; private set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// The priority controls in which order the slices are applied. The lower the value the higher the precedence.
        /// </summary>
        /// <value>The priority controls in which order the slices are applied. The lower the value the higher the precedence.</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; private set; }

        /// <summary>
        /// The proportion defines how much of the total installment payment has to be paid in this slice. The value is summed up with the other slices and the ratio of all proportions compared to proportion of this slice determines how much the buyer has to pay in this slice.
        /// </summary>
        /// <value>The proportion defines how much of the total installment payment has to be paid in this slice. The value is summed up with the other slices and the ratio of all proportions compared to proportion of this slice determines how much the buyer has to pay in this slice.</value>
        [DataMember(Name="proportion", EmitDefaultValue=false)]
        public decimal? Proportion { get; private set; }


        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; private set; }

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
        public virtual string ToJson()
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
            return this.Equals(input as InstallmentPlanSliceConfiguration);
        }

        /// <summary>
        /// Returns true if InstallmentPlanSliceConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of InstallmentPlanSliceConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstallmentPlanSliceConfiguration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LineItemTitle == input.LineItemTitle ||
                    (this.LineItemTitle != null &&
                    this.LineItemTitle.Equals(input.LineItemTitle))
                ) && 
                (
                    this.LinkedSpaceId == input.LinkedSpaceId ||
                    (this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(input.LinkedSpaceId))
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.Plan == input.Plan ||
                    (this.Plan != null &&
                    this.Plan.Equals(input.Plan))
                ) && 
                (
                    this.PlannedPurgeDate == input.PlannedPurgeDate ||
                    (this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(input.PlannedPurgeDate))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.Proportion == input.Proportion ||
                    (this.Proportion != null &&
                    this.Proportion.Equals(input.Proportion))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LineItemTitle != null)
                    hashCode = hashCode * 59 + this.LineItemTitle.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.Plan != null)
                    hashCode = hashCode * 59 + this.Plan.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.Proportion != null)
                    hashCode = hashCode * 59 + this.Proportion.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
