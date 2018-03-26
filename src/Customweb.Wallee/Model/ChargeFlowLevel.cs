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
    /// Charge Flow Level
    /// </summary>
    [DataContract]
    public partial class ChargeFlowLevel : TransactionAwareEntity,  IEquatable<ChargeFlowLevel>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeFlowLevel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ChargeFlowLevel()
        {
        }

        /// <summary>
        /// AsynchronousCharge
        /// </summary>
        /// <value>AsynchronousCharge</value>
        [DataMember(Name="asynchronousCharge", EmitDefaultValue=false)]
        public long? AsynchronousCharge { get; private set; }

        /// <summary>
        /// Configuration
        /// </summary>
        /// <value>Configuration</value>
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
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public ChargeFlowLevelState? State { get; private set; }

        /// <summary>
        /// SynchronousCharge
        /// </summary>
        /// <value>SynchronousCharge</value>
        [DataMember(Name="synchronousCharge", EmitDefaultValue=false)]
        public long? SynchronousCharge { get; private set; }

        /// <summary>
        /// TimeoutOn
        /// </summary>
        /// <value>TimeoutOn</value>
        [DataMember(Name="timeoutOn", EmitDefaultValue=false)]
        public DateTime? TimeoutOn { get; private set; }

        /// <summary>
        /// TokenCharge
        /// </summary>
        /// <value>TokenCharge</value>
        [DataMember(Name="tokenCharge", EmitDefaultValue=false)]
        public long? TokenCharge { get; private set; }

        /// <summary>
        /// Transaction
        /// </summary>
        /// <value>Transaction</value>
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
            return this.ToJson();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public new string ToJson()
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
                    this.LinkedTransaction == other.LinkedTransaction ||
                    this.LinkedTransaction != null &&
                    this.LinkedTransaction.Equals(other.LinkedTransaction)
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
                if (this.AsynchronousCharge != null)
                {
                    hash = hash * 59 + this.AsynchronousCharge.GetHashCode();
                }
                if (this.Configuration != null)
                {
                    hash = hash * 59 + this.Configuration.GetHashCode();
                }
                if (this.CreatedOn != null)
                {
                    hash = hash * 59 + this.CreatedOn.GetHashCode();
                }
                if (this.PlannedPurgeDate != null)
                {
                    hash = hash * 59 + this.PlannedPurgeDate.GetHashCode();
                }
                if (this.State != null)
                {
                    hash = hash * 59 + this.State.GetHashCode();
                }
                if (this.SynchronousCharge != null)
                {
                    hash = hash * 59 + this.SynchronousCharge.GetHashCode();
                }
                if (this.TimeoutOn != null)
                {
                    hash = hash * 59 + this.TimeoutOn.GetHashCode();
                }
                if (this.TokenCharge != null)
                {
                    hash = hash * 59 + this.TokenCharge.GetHashCode();
                }
                if (this.Transaction != null)
                {
                    hash = hash * 59 + this.Transaction.GetHashCode();
                }
                if (this.Version != null)
                {
                    hash = hash * 59 + this.Version.GetHashCode();
                }
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.LinkedSpaceId != null)
                {
                    hash = hash * 59 + this.LinkedSpaceId.GetHashCode();
                }
                if (this.LinkedTransaction != null)
                {
                    hash = hash * 59 + this.LinkedTransaction.GetHashCode();
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
