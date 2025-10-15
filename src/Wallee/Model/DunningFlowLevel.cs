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
    /// DunningFlowLevel
    /// </summary>
    [DataContract]
    public partial class DunningFlowLevel :  IEquatable<DunningFlowLevel>
    {
        /// <summary>
        /// The object&#39;s current state.
        /// </summary>
        /// <value>The object&#39;s current state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public CreationEntityState? State { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DunningFlowLevel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public DunningFlowLevel()
        {
        }

        /// <summary>
        /// This text is put in the reminder document of this dunning flow level.
        /// </summary>
        /// <value>This text is put in the reminder document of this dunning flow level.</value>
        [DataMember(Name="documentText", EmitDefaultValue=false)]
        public Dictionary<string, string> DocumentText { get; private set; }

        /// <summary>
        /// Gets or Sets Flow
        /// </summary>
        [DataMember(Name="flow", EmitDefaultValue=false)]
        public DunningFlow Flow { get; private set; }

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
        /// The dunning flow level name is used internally to identify the dunning flow level. For example the name is used within search fields and hence it should be distinct and descriptive.
        /// </summary>
        /// <value>The dunning flow level name is used internally to identify the dunning flow level. For example the name is used within search fields and hence it should be distinct and descriptive.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// The duration of the level before switching to the next one.
        /// </summary>
        /// <value>The duration of the level before switching to the next one.</value>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public string Period { get; private set; }

        /// <summary>
        /// The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.
        /// </summary>
        /// <value>The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// The priority indicates the sort order of the level. A low value indicates that the level is executed before any level with a higher value. Any change to this value affects future level selections. The value has to pe unique per dunning flow.
        /// </summary>
        /// <value>The priority indicates the sort order of the level. A low value indicates that the level is executed before any level with a higher value. Any change to this value affects future level selections. The value has to pe unique per dunning flow.</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; private set; }

        /// <summary>
        /// Gets or Sets Processor
        /// </summary>
        [DataMember(Name="processor", EmitDefaultValue=false)]
        public long? Processor { get; private set; }

        /// <summary>
        /// Gets or Sets ReminderTemplate
        /// </summary>
        [DataMember(Name="reminderTemplate", EmitDefaultValue=false)]
        public DocumentTemplate ReminderTemplate { get; private set; }


        /// <summary>
        /// The title is used to communicate the dunning level to the customer within the reminder.
        /// </summary>
        /// <value>The title is used to communicate the dunning level to the customer within the reminder.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public Dictionary<string, string> Title { get; private set; }

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
            sb.Append("class DunningFlowLevel {\n");
            sb.Append("  DocumentText: ").Append(DocumentText).Append("\n");
            sb.Append("  Flow: ").Append(Flow).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Processor: ").Append(Processor).Append("\n");
            sb.Append("  ReminderTemplate: ").Append(ReminderTemplate).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as DunningFlowLevel);
        }

        /// <summary>
        /// Returns true if DunningFlowLevel instances are equal
        /// </summary>
        /// <param name="input">Instance of DunningFlowLevel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DunningFlowLevel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DocumentText == input.DocumentText ||
                    this.DocumentText != null &&
                    input.DocumentText != null &&
                    this.DocumentText.SequenceEqual(input.DocumentText)
                ) && 
                (
                    this.Flow == input.Flow ||
                    (this.Flow != null &&
                    this.Flow.Equals(input.Flow))
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
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
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
                    this.Processor == input.Processor ||
                    (this.Processor != null &&
                    this.Processor.Equals(input.Processor))
                ) && 
                (
                    this.ReminderTemplate == input.ReminderTemplate ||
                    (this.ReminderTemplate != null &&
                    this.ReminderTemplate.Equals(input.ReminderTemplate))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Title == input.Title ||
                    this.Title != null &&
                    input.Title != null &&
                    this.Title.SequenceEqual(input.Title)
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
                if (this.DocumentText != null)
                    hashCode = hashCode * 59 + this.DocumentText.GetHashCode();
                if (this.Flow != null)
                    hashCode = hashCode * 59 + this.Flow.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.Processor != null)
                    hashCode = hashCode * 59 + this.Processor.GetHashCode();
                if (this.ReminderTemplate != null)
                    hashCode = hashCode * 59 + this.ReminderTemplate.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
