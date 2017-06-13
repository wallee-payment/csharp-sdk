
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
    /// ManualTaskAction model.
    /// </summary>
    [DataContract]
    public partial class ManualTaskAction :  IEquatable<ManualTaskAction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManualTaskAction" /> class.
        /// </summary>
        /// <param name="Id">The ID is the primary key of the entity. The ID identifies the entity uniquely.</param>
        /// <param name="Label">Label</param>
        /// <param name="Style">Style</param>
        /// <param name="TaskType">TaskType</param>
        public ManualTaskAction(long? Id = default(long?), Dictionary<string, string> Label = default(Dictionary<string, string>), ManualTaskActionStyle Style = default(ManualTaskActionStyle), long? TaskType = default(long?))
        {
            this.Id = Id;
            this.Label = Label;
            this.Style = Style;
            this.TaskType = TaskType;
        }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Label
        /// </summary>
        /// <value>Label</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public Dictionary<string, string> Label { get; set; }

        /// <summary>
        /// Style
        /// </summary>
        /// <value>Style</value>
        [DataMember(Name="style", EmitDefaultValue=false)]
        public ManualTaskActionStyle Style { get; set; }

        /// <summary>
        /// TaskType
        /// </summary>
        /// <value>TaskType</value>
        [DataMember(Name="taskType", EmitDefaultValue=false)]
        public long? TaskType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManualTaskAction {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Style: ").Append(Style).Append("\n");
            sb.Append("  TaskType: ").Append(TaskType).Append("\n");
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
            return this.Equals(obj as ManualTaskAction);
        }

        /// <summary>
        /// Returns true if ManualTaskAction instances are equal
        /// </summary>
        /// <param name="other">Instance of ManualTaskAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManualTaskAction other)
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
                    this.Label == other.Label ||
                    this.Label != null &&
                    this.Label.SequenceEqual(other.Label)
                ) && 
                (
                    this.Style == other.Style ||
                    this.Style != null &&
                    this.Style.Equals(other.Style)
                ) && 
                (
                    this.TaskType == other.TaskType ||
                    this.TaskType != null &&
                    this.TaskType.Equals(other.TaskType)
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
                if (this.Label != null)
                    hash = hash * 59 + this.Label.GetHashCode();
                if (this.Style != null)
                    hash = hash * 59 + this.Style.GetHashCode();
                if (this.TaskType != null)
                    hash = hash * 59 + this.TaskType.GetHashCode();
                return hash;
            }
        }

    }

}
