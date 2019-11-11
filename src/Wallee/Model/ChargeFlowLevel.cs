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
    /// ChargeFlowLevel
    /// </summary>
    [DataContract]
    public partial class ChargeFlowLevel : TransactionAwareEntity,  IEquatable<ChargeFlowLevel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeFlowLevel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ChargeFlowLevel()
        {
        }




        /// <summary>
        /// Gets or Sets AsynchronousCharge
        /// </summary>
        [DataMember(Name="asynchronousCharge", EmitDefaultValue=false)]
        public long? AsynchronousCharge { get; private set; }

        /// <summary>
        /// Gets or Sets Configuration
        /// </summary>
        [DataMember(Name="configuration", EmitDefaultValue=false)]
        public ChargeFlowLevelConfiguration Configuration { get; private set; }

        /// <summary>
        /// The created on date indicates the date on which the entity was stored into the database.
        /// </summary>
        /// <value>The created on date indicates the date on which the entity was stored into the database.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public ChargeFlowLevelState State { get; private set; }

        /// <summary>
        /// Gets or Sets SynchronousCharge
        /// </summary>
        [DataMember(Name="synchronousCharge", EmitDefaultValue=false)]
        public long? SynchronousCharge { get; private set; }

        /// <summary>
        /// Gets or Sets TimeoutOn
        /// </summary>
        [DataMember(Name="timeoutOn", EmitDefaultValue=false)]
        public DateTime? TimeoutOn { get; private set; }

        /// <summary>
        /// Gets or Sets TokenCharge
        /// </summary>
        [DataMember(Name="tokenCharge", EmitDefaultValue=false)]
        public long? TokenCharge { get; private set; }

        /// <summary>
        /// Gets or Sets Transaction
        /// </summary>
        [DataMember(Name="transaction", EmitDefaultValue=false)]
        public Transaction Transaction { get; private set; }

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
            sb.Append("class ChargeFlowLevel {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  LinkedTransaction: ").Append(LinkedTransaction).Append("\n");
            sb.Append("  AsynchronousCharge: ").Append(AsynchronousCharge).Append("\n");
            sb.Append("  Configuration: ").Append(Configuration).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  SynchronousCharge: ").Append(SynchronousCharge).Append("\n");
            sb.Append("  TimeoutOn: ").Append(TimeoutOn).Append("\n");
            sb.Append("  TokenCharge: ").Append(TokenCharge).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as ChargeFlowLevel);
        }

        /// <summary>
        /// Returns true if ChargeFlowLevel instances are equal
        /// </summary>
        /// <param name="input">Instance of ChargeFlowLevel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChargeFlowLevel input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && base.Equals(input) && 
                (
                    this.LinkedSpaceId == input.LinkedSpaceId ||
                    (this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(input.LinkedSpaceId))
                ) && base.Equals(input) && 
                (
                    this.LinkedTransaction == input.LinkedTransaction ||
                    (this.LinkedTransaction != null &&
                    this.LinkedTransaction.Equals(input.LinkedTransaction))
                ) && base.Equals(input) && 
                (
                    this.AsynchronousCharge == input.AsynchronousCharge ||
                    (this.AsynchronousCharge != null &&
                    this.AsynchronousCharge.Equals(input.AsynchronousCharge))
                ) && base.Equals(input) && 
                (
                    this.Configuration == input.Configuration ||
                    (this.Configuration != null &&
                    this.Configuration.Equals(input.Configuration))
                ) && base.Equals(input) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && base.Equals(input) && 
                (
                    this.PlannedPurgeDate == input.PlannedPurgeDate ||
                    (this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(input.PlannedPurgeDate))
                ) && base.Equals(input) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && base.Equals(input) && 
                (
                    this.SynchronousCharge == input.SynchronousCharge ||
                    (this.SynchronousCharge != null &&
                    this.SynchronousCharge.Equals(input.SynchronousCharge))
                ) && base.Equals(input) && 
                (
                    this.TimeoutOn == input.TimeoutOn ||
                    (this.TimeoutOn != null &&
                    this.TimeoutOn.Equals(input.TimeoutOn))
                ) && base.Equals(input) && 
                (
                    this.TokenCharge == input.TokenCharge ||
                    (this.TokenCharge != null &&
                    this.TokenCharge.Equals(input.TokenCharge))
                ) && base.Equals(input) && 
                (
                    this.Transaction == input.Transaction ||
                    (this.Transaction != null &&
                    this.Transaction.Equals(input.Transaction))
                ) && base.Equals(input) && 
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
                int hashCode = base.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.LinkedTransaction != null)
                    hashCode = hashCode * 59 + this.LinkedTransaction.GetHashCode();
                if (this.AsynchronousCharge != null)
                    hashCode = hashCode * 59 + this.AsynchronousCharge.GetHashCode();
                if (this.Configuration != null)
                    hashCode = hashCode * 59 + this.Configuration.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.SynchronousCharge != null)
                    hashCode = hashCode * 59 + this.SynchronousCharge.GetHashCode();
                if (this.TimeoutOn != null)
                    hashCode = hashCode * 59 + this.TimeoutOn.GetHashCode();
                if (this.TokenCharge != null)
                    hashCode = hashCode * 59 + this.TokenCharge.GetHashCode();
                if (this.Transaction != null)
                    hashCode = hashCode * 59 + this.Transaction.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
