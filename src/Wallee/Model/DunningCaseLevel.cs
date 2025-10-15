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
    /// DunningCaseLevel
    /// </summary>
    [DataContract]
    public partial class DunningCaseLevel :  IEquatable<DunningCaseLevel>
    {
        /// <summary>
        /// The environment used when rendering resources.
        /// </summary>
        /// <value>The environment used when rendering resources.</value>
        [DataMember(Name="environment", EmitDefaultValue=false)]
        public Environment? Environment { get; private set; }
        /// <summary>
        /// The object&#39;s current state.
        /// </summary>
        /// <value>The object&#39;s current state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public DunningCaseLevelState? State { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DunningCaseLevel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public DunningCaseLevel()
        {
        }

        /// <summary>
        /// Gets or Sets CanceledOn
        /// </summary>
        [DataMember(Name="canceledOn", EmitDefaultValue=false)]
        public DateTime? CanceledOn { get; private set; }

        /// <summary>
        /// The date and time when the object was created.
        /// </summary>
        /// <value>The date and time when the object was created.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// Gets or Sets DunningCase
        /// </summary>
        [DataMember(Name="dunningCase", EmitDefaultValue=false)]
        public DunningCase DunningCase { get; private set; }


        /// <summary>
        /// Gets or Sets FailedOn
        /// </summary>
        [DataMember(Name="failedOn", EmitDefaultValue=false)]
        public DateTime? FailedOn { get; private set; }

        /// <summary>
        /// Gets or Sets FlowLevel
        /// </summary>
        [DataMember(Name="flowLevel", EmitDefaultValue=false)]
        public long? FlowLevel { get; private set; }

        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// Gets or Sets Invoice
        /// </summary>
        [DataMember(Name="invoice", EmitDefaultValue=false)]
        public long? Invoice { get; private set; }

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
        /// The payment transaction this object is linked to.
        /// </summary>
        /// <value>The payment transaction this object is linked to.</value>
        [DataMember(Name="linkedTransaction", EmitDefaultValue=false)]
        public long? LinkedTransaction { get; private set; }

        /// <summary>
        /// Gets or Sets MostRecentLevel
        /// </summary>
        [DataMember(Name="mostRecentLevel", EmitDefaultValue=false)]
        public bool? MostRecentLevel { get; private set; }

        /// <summary>
        /// The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.
        /// </summary>
        /// <value>The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }


        /// <summary>
        /// Gets or Sets SucceededOn
        /// </summary>
        [DataMember(Name="succeededOn", EmitDefaultValue=false)]
        public DateTime? SucceededOn { get; private set; }

        /// <summary>
        /// Gets or Sets TimeoutOn
        /// </summary>
        [DataMember(Name="timeoutOn", EmitDefaultValue=false)]
        public DateTime? TimeoutOn { get; private set; }

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
            sb.Append("class DunningCaseLevel {\n");
            sb.Append("  CanceledOn: ").Append(CanceledOn).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  DunningCase: ").Append(DunningCase).Append("\n");
            sb.Append("  Environment: ").Append(Environment).Append("\n");
            sb.Append("  FailedOn: ").Append(FailedOn).Append("\n");
            sb.Append("  FlowLevel: ").Append(FlowLevel).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Invoice: ").Append(Invoice).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  LinkedTransaction: ").Append(LinkedTransaction).Append("\n");
            sb.Append("  MostRecentLevel: ").Append(MostRecentLevel).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  SucceededOn: ").Append(SucceededOn).Append("\n");
            sb.Append("  TimeoutOn: ").Append(TimeoutOn).Append("\n");
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
            return this.Equals(input as DunningCaseLevel);
        }

        /// <summary>
        /// Returns true if DunningCaseLevel instances are equal
        /// </summary>
        /// <param name="input">Instance of DunningCaseLevel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DunningCaseLevel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CanceledOn == input.CanceledOn ||
                    (this.CanceledOn != null &&
                    this.CanceledOn.Equals(input.CanceledOn))
                ) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && 
                (
                    this.DunningCase == input.DunningCase ||
                    (this.DunningCase != null &&
                    this.DunningCase.Equals(input.DunningCase))
                ) && 
                (
                    this.Environment == input.Environment ||
                    (this.Environment != null &&
                    this.Environment.Equals(input.Environment))
                ) && 
                (
                    this.FailedOn == input.FailedOn ||
                    (this.FailedOn != null &&
                    this.FailedOn.Equals(input.FailedOn))
                ) && 
                (
                    this.FlowLevel == input.FlowLevel ||
                    (this.FlowLevel != null &&
                    this.FlowLevel.Equals(input.FlowLevel))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Invoice == input.Invoice ||
                    (this.Invoice != null &&
                    this.Invoice.Equals(input.Invoice))
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
                    this.LinkedTransaction == input.LinkedTransaction ||
                    (this.LinkedTransaction != null &&
                    this.LinkedTransaction.Equals(input.LinkedTransaction))
                ) && 
                (
                    this.MostRecentLevel == input.MostRecentLevel ||
                    (this.MostRecentLevel != null &&
                    this.MostRecentLevel.Equals(input.MostRecentLevel))
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
                    this.SucceededOn == input.SucceededOn ||
                    (this.SucceededOn != null &&
                    this.SucceededOn.Equals(input.SucceededOn))
                ) && 
                (
                    this.TimeoutOn == input.TimeoutOn ||
                    (this.TimeoutOn != null &&
                    this.TimeoutOn.Equals(input.TimeoutOn))
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
                if (this.CanceledOn != null)
                    hashCode = hashCode * 59 + this.CanceledOn.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.DunningCase != null)
                    hashCode = hashCode * 59 + this.DunningCase.GetHashCode();
                if (this.Environment != null)
                    hashCode = hashCode * 59 + this.Environment.GetHashCode();
                if (this.FailedOn != null)
                    hashCode = hashCode * 59 + this.FailedOn.GetHashCode();
                if (this.FlowLevel != null)
                    hashCode = hashCode * 59 + this.FlowLevel.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Invoice != null)
                    hashCode = hashCode * 59 + this.Invoice.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.LinkedTransaction != null)
                    hashCode = hashCode * 59 + this.LinkedTransaction.GetHashCode();
                if (this.MostRecentLevel != null)
                    hashCode = hashCode * 59 + this.MostRecentLevel.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.SucceededOn != null)
                    hashCode = hashCode * 59 + this.SucceededOn.GetHashCode();
                if (this.TimeoutOn != null)
                    hashCode = hashCode * 59 + this.TimeoutOn.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
