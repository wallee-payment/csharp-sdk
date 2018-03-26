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
    /// The debt collector configuration defines the behavior of the collection process for a particular collector.
    /// </summary>
    [DataContract]
    public partial class DebtCollectorConfiguration :  IEquatable<DebtCollectorConfiguration>, IValidatableObject
    {

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
        [DataMember(Name="collector", EmitDefaultValue=false)]
        public long? Collector { get; private set; }

        /// <summary>
        /// The conditions applied to the collector configuration restricts the application of this configuration onto a particular debt collection case.
        /// </summary>
        /// <value>The conditions applied to the collector configuration restricts the application of this configuration onto a particular debt collection case.</value>
        [DataMember(Name="conditions", EmitDefaultValue=false)]
        public List<long?> Conditions { get; private set; }

        /// <summary>
        /// The collector configuration is only enabled for the selected space views. In case the set is empty the collector configuration is enabled for all space views.
        /// </summary>
        /// <value>The collector configuration is only enabled for the selected space views. In case the set is empty the collector configuration is enabled for all space views.</value>
        [DataMember(Name="enabledSpaceViews", EmitDefaultValue=false)]
        public List<long?> EnabledSpaceViews { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// The collector configuration name is used internally to identify a specific collector configuration. For example the name is used within search fields and hence it should be distinct and descriptive.
        /// </summary>
        /// <value>The collector configuration name is used internally to identify a specific collector configuration. For example the name is used within search fields and hence it should be distinct and descriptive.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// The priority defines the order in which the collector configuration is tried to be applied onto a debt collection case. The higher the value the less likely the configuration is applied on a case.
        /// </summary>
        /// <value>The priority defines the order in which the collector configuration is tried to be applied onto a debt collection case. The higher the value the less likely the configuration is applied on a case.</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; private set; }

        /// <summary>
        /// When the review is skipped there will be no review for cases which use this configuration.
        /// </summary>
        /// <value>When the review is skipped there will be no review for cases which use this configuration.</value>
        [DataMember(Name="skipReviewEnabled", EmitDefaultValue=false)]
        public bool? SkipReviewEnabled { get; private set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public CreationEntityState? State { get; private set; }

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
            return this.ToJson();
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
            return this.Equals(obj as DebtCollectorConfiguration);
        }

        /// <summary>
        /// Returns true if DebtCollectorConfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of DebtCollectorConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DebtCollectorConfiguration other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Collector == other.Collector ||
                    this.Collector != null &&
                    this.Collector.Equals(other.Collector)
                ) && 
                (
                    this.Conditions == other.Conditions ||
                    this.Conditions != null &&
                    this.Conditions.SequenceEqual(other.Conditions)
                ) && 
                (
                    this.EnabledSpaceViews == other.EnabledSpaceViews ||
                    this.EnabledSpaceViews != null &&
                    this.EnabledSpaceViews.SequenceEqual(other.EnabledSpaceViews)
                ) && 
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                    this.SkipReviewEnabled == other.SkipReviewEnabled ||
                    this.SkipReviewEnabled != null &&
                    this.SkipReviewEnabled.Equals(other.SkipReviewEnabled)
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
                if (this.Collector != null)
                {
                    hash = hash * 59 + this.Collector.GetHashCode();
                }
                if (this.Conditions != null)
                {
                    hash = hash * 59 + this.Conditions.GetHashCode();
                }
                if (this.EnabledSpaceViews != null)
                {
                    hash = hash * 59 + this.EnabledSpaceViews.GetHashCode();
                }
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.LinkedSpaceId != null)
                {
                    hash = hash * 59 + this.LinkedSpaceId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hash = hash * 59 + this.Name.GetHashCode();
                }
                if (this.PlannedPurgeDate != null)
                {
                    hash = hash * 59 + this.PlannedPurgeDate.GetHashCode();
                }
                if (this.Priority != null)
                {
                    hash = hash * 59 + this.Priority.GetHashCode();
                }
                if (this.SkipReviewEnabled != null)
                {
                    hash = hash * 59 + this.SkipReviewEnabled.GetHashCode();
                }
                if (this.State != null)
                {
                    hash = hash * 59 + this.State.GetHashCode();
                }
                if (this.Version != null)
                {
                    hash = hash * 59 + this.Version.GetHashCode();
                }
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
