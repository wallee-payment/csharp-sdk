
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
    /// ChargeFlowLevel model.
    /// </summary>
    [DataContract]
    public partial class ChargeFlowLevel :  IEquatable<ChargeFlowLevel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeFlowLevel" /> class.
        /// </summary>
        /// <param name="Id">The ID is the primary key of the entity. The ID identifies the entity uniquely.</param>
        /// <param name="LinkedSpaceId">The linked space id holds the ID of the space to which the entity belongs to.</param>
        /// <param name="LinkedTransaction">LinkedTransaction</param>
        /// <param name="AsynchronousCharge">AsynchronousCharge</param>
        /// <param name="Configuration">Configuration</param>
        /// <param name="CreatedOn">The created on date indicates the date on which the entity was stored into the database.</param>
        /// <param name="PlannedPurgeDate">The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</param>
        /// <param name="State">State</param>
        /// <param name="SynchronousCharge">SynchronousCharge</param>
        /// <param name="TimeoutOn">TimeoutOn</param>
        /// <param name="TokenCharge">TokenCharge</param>
        /// <param name="Transaction">Transaction</param>
        /// <param name="Version">The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</param>
        public ChargeFlowLevel(long? Id = default(long?), long? LinkedSpaceId = default(long?), long? LinkedTransaction = default(long?), long? AsynchronousCharge = default(long?), ChargeFlowLevelConfiguration Configuration = default(ChargeFlowLevelConfiguration), DateTime? CreatedOn = default(DateTime?), DateTime? PlannedPurgeDate = default(DateTime?), ChargeFlowLevelState State = default(ChargeFlowLevelState), long? SynchronousCharge = default(long?), DateTime? TimeoutOn = default(DateTime?), long? TokenCharge = default(long?), Transaction Transaction = default(Transaction), int? Version = default(int?))
        {
            this.Id = Id;
            this.LinkedSpaceId = LinkedSpaceId;
            this.LinkedTransaction = LinkedTransaction;
            this.AsynchronousCharge = AsynchronousCharge;
            this.Configuration = Configuration;
            this.CreatedOn = CreatedOn;
            this.PlannedPurgeDate = PlannedPurgeDate;
            this.State = State;
            this.SynchronousCharge = SynchronousCharge;
            this.TimeoutOn = TimeoutOn;
            this.TokenCharge = TokenCharge;
            this.Transaction = Transaction;
            this.Version = Version;
        }

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
        /// LinkedTransaction
        /// </summary>
        /// <value>LinkedTransaction</value>
        [DataMember(Name="linkedTransaction", EmitDefaultValue=false)]
        public long? LinkedTransaction { get; set; }

        /// <summary>
        /// AsynchronousCharge
        /// </summary>
        /// <value>AsynchronousCharge</value>
        [DataMember(Name="asynchronousCharge", EmitDefaultValue=false)]
        public long? AsynchronousCharge { get; set; }

        /// <summary>
        /// Configuration
        /// </summary>
        /// <value>Configuration</value>
        [DataMember(Name="configuration", EmitDefaultValue=false)]
        public ChargeFlowLevelConfiguration Configuration { get; set; }

        /// <summary>
        /// The created on date indicates the date on which the entity was stored into the database.
        /// </summary>
        /// <value>The created on date indicates the date on which the entity was stored into the database.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public ChargeFlowLevelState State { get; set; }

        /// <summary>
        /// SynchronousCharge
        /// </summary>
        /// <value>SynchronousCharge</value>
        [DataMember(Name="synchronousCharge", EmitDefaultValue=false)]
        public long? SynchronousCharge { get; set; }

        /// <summary>
        /// TimeoutOn
        /// </summary>
        /// <value>TimeoutOn</value>
        [DataMember(Name="timeoutOn", EmitDefaultValue=false)]
        public DateTime? TimeoutOn { get; set; }

        /// <summary>
        /// TokenCharge
        /// </summary>
        /// <value>TokenCharge</value>
        [DataMember(Name="tokenCharge", EmitDefaultValue=false)]
        public long? TokenCharge { get; set; }

        /// <summary>
        /// Transaction
        /// </summary>
        /// <value>Transaction</value>
        [DataMember(Name="transaction", EmitDefaultValue=false)]
        public Transaction Transaction { get; set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChargeFlowLevel {\n");
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
            return this.Equals(obj as ChargeFlowLevel);
        }

        /// <summary>
        /// Returns true if ChargeFlowLevel instances are equal
        /// </summary>
        /// <param name="other">Instance of ChargeFlowLevel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChargeFlowLevel other)
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
                    this.LinkedSpaceId == other.LinkedSpaceId ||
                    this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(other.LinkedSpaceId)
                ) && 
                (
                    this.LinkedTransaction == other.LinkedTransaction ||
                    this.LinkedTransaction != null &&
                    this.LinkedTransaction.Equals(other.LinkedTransaction)
                ) && 
                (
                    this.AsynchronousCharge == other.AsynchronousCharge ||
                    this.AsynchronousCharge != null &&
                    this.AsynchronousCharge.Equals(other.AsynchronousCharge)
                ) && 
                (
                    this.Configuration == other.Configuration ||
                    this.Configuration != null &&
                    this.Configuration.Equals(other.Configuration)
                ) && 
                (
                    this.CreatedOn == other.CreatedOn ||
                    this.CreatedOn != null &&
                    this.CreatedOn.Equals(other.CreatedOn)
                ) && 
                (
                    this.PlannedPurgeDate == other.PlannedPurgeDate ||
                    this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(other.PlannedPurgeDate)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.SynchronousCharge == other.SynchronousCharge ||
                    this.SynchronousCharge != null &&
                    this.SynchronousCharge.Equals(other.SynchronousCharge)
                ) && 
                (
                    this.TimeoutOn == other.TimeoutOn ||
                    this.TimeoutOn != null &&
                    this.TimeoutOn.Equals(other.TimeoutOn)
                ) && 
                (
                    this.TokenCharge == other.TokenCharge ||
                    this.TokenCharge != null &&
                    this.TokenCharge.Equals(other.TokenCharge)
                ) && 
                (
                    this.Transaction == other.Transaction ||
                    this.Transaction != null &&
                    this.Transaction.Equals(other.Transaction)
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
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hash = hash * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.LinkedTransaction != null)
                    hash = hash * 59 + this.LinkedTransaction.GetHashCode();
                if (this.AsynchronousCharge != null)
                    hash = hash * 59 + this.AsynchronousCharge.GetHashCode();
                if (this.Configuration != null)
                    hash = hash * 59 + this.Configuration.GetHashCode();
                if (this.CreatedOn != null)
                    hash = hash * 59 + this.CreatedOn.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hash = hash * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.SynchronousCharge != null)
                    hash = hash * 59 + this.SynchronousCharge.GetHashCode();
                if (this.TimeoutOn != null)
                    hash = hash * 59 + this.TimeoutOn.GetHashCode();
                if (this.TokenCharge != null)
                    hash = hash * 59 + this.TokenCharge.GetHashCode();
                if (this.Transaction != null)
                    hash = hash * 59 + this.Transaction.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                return hash;
            }
        }

    }

}
