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
    /// DunningCase
    /// </summary>
    [DataContract]
    public partial class DunningCase :  IEquatable<DunningCase>
    {
        /// <summary>
        /// The object&#39;s current state.
        /// </summary>
        /// <value>The object&#39;s current state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public DunningCaseState? State { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DunningCase" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public DunningCase()
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
        /// Gets or Sets DerecognizedOn
        /// </summary>
        [DataMember(Name="derecognizedOn", EmitDefaultValue=false)]
        public DateTime? DerecognizedOn { get; private set; }

        /// <summary>
        /// Gets or Sets FailedOn
        /// </summary>
        [DataMember(Name="failedOn", EmitDefaultValue=false)]
        public DateTime? FailedOn { get; private set; }

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
        /// Gets or Sets InitialInvoice
        /// </summary>
        [DataMember(Name="initialInvoice", EmitDefaultValue=false)]
        public TransactionInvoice InitialInvoice { get; private set; }

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
            sb.Append("class DunningCase {\n");
            sb.Append("  CanceledOn: ").Append(CanceledOn).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  DerecognizedOn: ").Append(DerecognizedOn).Append("\n");
            sb.Append("  FailedOn: ").Append(FailedOn).Append("\n");
            sb.Append("  Flow: ").Append(Flow).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InitialInvoice: ").Append(InitialInvoice).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  LinkedTransaction: ").Append(LinkedTransaction).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  SucceededOn: ").Append(SucceededOn).Append("\n");
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
            return this.Equals(input as DunningCase);
        }

        /// <summary>
        /// Returns true if DunningCase instances are equal
        /// </summary>
        /// <param name="input">Instance of DunningCase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DunningCase input)
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
                    this.DerecognizedOn == input.DerecognizedOn ||
                    (this.DerecognizedOn != null &&
                    this.DerecognizedOn.Equals(input.DerecognizedOn))
                ) && 
                (
                    this.FailedOn == input.FailedOn ||
                    (this.FailedOn != null &&
                    this.FailedOn.Equals(input.FailedOn))
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
                    this.InitialInvoice == input.InitialInvoice ||
                    (this.InitialInvoice != null &&
                    this.InitialInvoice.Equals(input.InitialInvoice))
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
                if (this.DerecognizedOn != null)
                    hashCode = hashCode * 59 + this.DerecognizedOn.GetHashCode();
                if (this.FailedOn != null)
                    hashCode = hashCode * 59 + this.FailedOn.GetHashCode();
                if (this.Flow != null)
                    hashCode = hashCode * 59 + this.Flow.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InitialInvoice != null)
                    hashCode = hashCode * 59 + this.InitialInvoice.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.LinkedTransaction != null)
                    hashCode = hashCode * 59 + this.LinkedTransaction.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.SucceededOn != null)
                    hashCode = hashCode * 59 + this.SucceededOn.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
