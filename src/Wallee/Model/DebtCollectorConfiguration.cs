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
    /// The debt collector configuration defines the behavior of the collection process for a particular collector.
    /// </summary>
    [DataContract]
    public partial class DebtCollectorConfiguration :  IEquatable<DebtCollectorConfiguration>
    {
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=true)]
        public CreationEntityState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DebtCollectorConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public DebtCollectorConfiguration()
        {
        }

        /// <summary>
        /// The collector handles the debt collection case based on the settings of this configuration.
        /// </summary>
        /// <value>The collector handles the debt collection case based on the settings of this configuration.</value>
        [DataMember(Name="collector", EmitDefaultValue=true)]
        public long? Collector { get; private set; }

        /// <summary>
        /// The conditions applied to the collector configuration restricts the application of this configuration onto a particular debt collection case.
        /// </summary>
        /// <value>The conditions applied to the collector configuration restricts the application of this configuration onto a particular debt collection case.</value>
        [DataMember(Name="conditions", EmitDefaultValue=true)]
        public List<long?> Conditions { get; private set; }

        /// <summary>
        /// The collector configuration is only enabled for the selected space views. In case the set is empty the collector configuration is enabled for all space views.
        /// </summary>
        /// <value>The collector configuration is only enabled for the selected space views. In case the set is empty the collector configuration is enabled for all space views.</value>
        [DataMember(Name="enabledSpaceViews", EmitDefaultValue=true)]
        public List<long?> EnabledSpaceViews { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; private set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=true)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// The collector configuration name is used internally to identify a specific collector configuration. For example the name is used within search fields and hence it should be distinct and descriptive.
        /// </summary>
        /// <value>The collector configuration name is used internally to identify a specific collector configuration. For example the name is used within search fields and hence it should be distinct and descriptive.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; private set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=true)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// The priority defines the order in which the collector configuration is tried to be applied onto a debt collection case. The higher the value the less likely the configuration is applied on a case.
        /// </summary>
        /// <value>The priority defines the order in which the collector configuration is tried to be applied onto a debt collection case. The higher the value the less likely the configuration is applied on a case.</value>
        [DataMember(Name="priority", EmitDefaultValue=true)]
        public int? Priority { get; private set; }

        /// <summary>
        /// When the review is skipped there will be no review for cases which use this configuration.
        /// </summary>
        /// <value>When the review is skipped there will be no review for cases which use this configuration.</value>
        [DataMember(Name="skipReviewEnabled", EmitDefaultValue=true)]
        public bool? SkipReviewEnabled { get; private set; }


        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public int? Version { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DebtCollectorConfiguration {\n");
            sb.Append("  Collector: ").Append(Collector).Append("\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
            sb.Append("  EnabledSpaceViews: ").Append(EnabledSpaceViews).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  SkipReviewEnabled: ").Append(SkipReviewEnabled).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DebtCollectorConfiguration);
        }

        /// <summary>
        /// Returns true if DebtCollectorConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of DebtCollectorConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DebtCollectorConfiguration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Collector == input.Collector ||
                    (this.Collector != null &&
                    this.Collector.Equals(input.Collector))
                ) && 
                (
                    this.Conditions == input.Conditions ||
                    this.Conditions != null &&
                    input.Conditions != null &&
                    this.Conditions.SequenceEqual(input.Conditions)
                ) && 
                (
                    this.EnabledSpaceViews == input.EnabledSpaceViews ||
                    this.EnabledSpaceViews != null &&
                    input.EnabledSpaceViews != null &&
                    this.EnabledSpaceViews.SequenceEqual(input.EnabledSpaceViews)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                    this.SkipReviewEnabled == input.SkipReviewEnabled ||
                    (this.SkipReviewEnabled != null &&
                    this.SkipReviewEnabled.Equals(input.SkipReviewEnabled))
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
                if (this.Collector != null)
                    hashCode = hashCode * 59 + this.Collector.GetHashCode();
                if (this.Conditions != null)
                    hashCode = hashCode * 59 + this.Conditions.GetHashCode();
                if (this.EnabledSpaceViews != null)
                    hashCode = hashCode * 59 + this.EnabledSpaceViews.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.SkipReviewEnabled != null)
                    hashCode = hashCode * 59 + this.SkipReviewEnabled.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
