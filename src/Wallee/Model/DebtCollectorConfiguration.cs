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
        /// The object&#39;s current state.
        /// </summary>
        /// <value>The object&#39;s current state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public CreationEntityState? State { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DebtCollectorConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public DebtCollectorConfiguration()
        {
        }

        /// <summary>
        /// The debt collector that the configuration is for.
        /// </summary>
        /// <value>The debt collector that the configuration is for.</value>
        [DataMember(Name="collector", EmitDefaultValue=false)]
        public long? Collector { get; private set; }

        /// <summary>
        /// Conditions allow to define criteria that a debt collection case must fulfill in order for the debt collector configuration to be considered for processing the case.
        /// </summary>
        /// <value>Conditions allow to define criteria that a debt collection case must fulfill in order for the debt collector configuration to be considered for processing the case.</value>
        [DataMember(Name="conditions", EmitDefaultValue=false)]
        public List<long?> Conditions { get; private set; }

        /// <summary>
        /// The space views for which the debt collector configuration is enabled. If empty, it is enabled for all space views.
        /// </summary>
        /// <value>The space views for which the debt collector configuration is enabled. If empty, it is enabled for all space views.</value>
        [DataMember(Name="enabledSpaceViews", EmitDefaultValue=false)]
        public List<long?> EnabledSpaceViews { get; private set; }

        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The ID of the space this object belongs to.
        /// </summary>
        /// <value>The ID of the space this object belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// The name used to identify the debt collector configuration.
        /// </summary>
        /// <value>The name used to identify the debt collector configuration.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.
        /// </summary>
        /// <value>The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// The priority that determines the order in which debt collector configurations are taken into account when processing a case. Low values are considered first.
        /// </summary>
        /// <value>The priority that determines the order in which debt collector configurations are taken into account when processing a case. Low values are considered first.</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; private set; }

        /// <summary>
        /// Whether the review of debt collection cases is skipped.
        /// </summary>
        /// <value>Whether the review of debt collection cases is skipped.</value>
        [DataMember(Name="skipReviewEnabled", EmitDefaultValue=false)]
        public bool? SkipReviewEnabled { get; private set; }


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
