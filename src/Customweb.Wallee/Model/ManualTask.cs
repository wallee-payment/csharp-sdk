
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
    /// A manual task requires a manual intervention by a human.
    /// </summary>
    [DataContract]
    public partial class ManualTask :  IEquatable<ManualTask>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManualTask" /> class.
        /// </summary>
        /// <param name="Actions">Actions</param>
        /// <param name="ContextEntityId">The context entity ID links the manual task to the entity which caused its creation.</param>
        /// <param name="CreatedOn">The created on date indicates the date on which the entity was stored into the database.</param>
        /// <param name="ExpiresOn">The expiry date indicates until when the manual task has to be executed.</param>
        /// <param name="Id">The ID is the primary key of the entity. The ID identifies the entity uniquely.</param>
        /// <param name="LinkedSpaceId">The linked space id holds the ID of the space to which the entity belongs to.</param>
        /// <param name="PlannedPurgeDate">The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</param>
        /// <param name="SpaceId">SpaceId</param>
        /// <param name="State">State</param>
        /// <param name="Type">The type categorizes the manual task.</param>
        public ManualTask(List<long?> Actions = default(List<long?>), long? ContextEntityId = default(long?), DateTime? CreatedOn = default(DateTime?), DateTime? ExpiresOn = default(DateTime?), long? Id = default(long?), long? LinkedSpaceId = default(long?), DateTime? PlannedPurgeDate = default(DateTime?), long? SpaceId = default(long?), ManualTaskState State = default(ManualTaskState), long? Type = default(long?))
        {
            this.Actions = Actions;
            this.ContextEntityId = ContextEntityId;
            this.CreatedOn = CreatedOn;
            this.ExpiresOn = ExpiresOn;
            this.Id = Id;
            this.LinkedSpaceId = LinkedSpaceId;
            this.PlannedPurgeDate = PlannedPurgeDate;
            this.SpaceId = SpaceId;
            this.State = State;
            this.Type = Type;
        }

        /// <summary>
        /// Actions
        /// </summary>
        /// <value>Actions</value>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<long?> Actions { get; set; }

        /// <summary>
        /// The context entity ID links the manual task to the entity which caused its creation.
        /// </summary>
        /// <value>The context entity ID links the manual task to the entity which caused its creation.</value>
        [DataMember(Name="contextEntityId", EmitDefaultValue=false)]
        public long? ContextEntityId { get; set; }

        /// <summary>
        /// The created on date indicates the date on which the entity was stored into the database.
        /// </summary>
        /// <value>The created on date indicates the date on which the entity was stored into the database.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// The expiry date indicates until when the manual task has to be executed.
        /// </summary>
        /// <value>The expiry date indicates until when the manual task has to be executed.</value>
        [DataMember(Name="expiresOn", EmitDefaultValue=false)]
        public DateTime? ExpiresOn { get; set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; set; }

        /// <summary>
        /// SpaceId
        /// </summary>
        /// <value>SpaceId</value>
        [DataMember(Name="spaceId", EmitDefaultValue=false)]
        public long? SpaceId { get; set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public ManualTaskState State { get; set; }

        /// <summary>
        /// The type categorizes the manual task.
        /// </summary>
        /// <value>The type categorizes the manual task.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public long? Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManualTask {\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  ContextEntityId: ").Append(ContextEntityId).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  ExpiresOn: ").Append(ExpiresOn).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  SpaceId: ").Append(SpaceId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as ManualTask);
        }

        /// <summary>
        /// Returns true if ManualTask instances are equal
        /// </summary>
        /// <param name="other">Instance of ManualTask to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManualTask other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Actions == other.Actions ||
                    this.Actions != null &&
                    this.Actions.SequenceEqual(other.Actions)
                ) && 
                (
                    this.ContextEntityId == other.ContextEntityId ||
                    this.ContextEntityId != null &&
                    this.ContextEntityId.Equals(other.ContextEntityId)
                ) && 
                (
                    this.CreatedOn == other.CreatedOn ||
                    this.CreatedOn != null &&
                    this.CreatedOn.Equals(other.CreatedOn)
                ) && 
                (
                    this.ExpiresOn == other.ExpiresOn ||
                    this.ExpiresOn != null &&
                    this.ExpiresOn.Equals(other.ExpiresOn)
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
                    this.PlannedPurgeDate == other.PlannedPurgeDate ||
                    this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(other.PlannedPurgeDate)
                ) && 
                (
                    this.SpaceId == other.SpaceId ||
                    this.SpaceId != null &&
                    this.SpaceId.Equals(other.SpaceId)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.Actions != null)
                    hash = hash * 59 + this.Actions.GetHashCode();
                if (this.ContextEntityId != null)
                    hash = hash * 59 + this.ContextEntityId.GetHashCode();
                if (this.CreatedOn != null)
                    hash = hash * 59 + this.CreatedOn.GetHashCode();
                if (this.ExpiresOn != null)
                    hash = hash * 59 + this.ExpiresOn.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hash = hash * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hash = hash * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.SpaceId != null)
                    hash = hash * 59 + this.SpaceId.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                return hash;
            }
        }

    }

}
