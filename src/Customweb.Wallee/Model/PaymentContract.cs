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
    /// Payment Contract
    /// </summary>
    [DataContract]
    public partial class PaymentContract :  IEquatable<PaymentContract>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentContract" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentContract()
        {
        }

        /// <summary>
        /// Account
        /// </summary>
        /// <value>Account</value>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public Account Account { get; private set; }

        /// <summary>
        /// ActivatedOn
        /// </summary>
        /// <value>ActivatedOn</value>
        [DataMember(Name="activatedOn", EmitDefaultValue=false)]
        public DateTime? ActivatedOn { get; private set; }

        /// <summary>
        /// ContractIdentifier
        /// </summary>
        /// <value>ContractIdentifier</value>
        [DataMember(Name="contractIdentifier", EmitDefaultValue=false)]
        public string ContractIdentifier { get; private set; }

        /// <summary>
        /// ContractType
        /// </summary>
        /// <value>ContractType</value>
        [DataMember(Name="contractType", EmitDefaultValue=false)]
        public PaymentContractType ContractType { get; private set; }

        /// <summary>
        /// CreatedBy
        /// </summary>
        /// <value>CreatedBy</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public User CreatedBy { get; private set; }

        /// <summary>
        /// The created on date indicates the date on which the entity was stored into the database.
        /// </summary>
        /// <value>The created on date indicates the date on which the entity was stored into the database.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity.
        /// </summary>
        /// <value>The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// RejectedOn
        /// </summary>
        /// <value>RejectedOn</value>
        [DataMember(Name="rejectedOn", EmitDefaultValue=false)]
        public DateTime? RejectedOn { get; private set; }

        /// <summary>
        /// RejectionReason
        /// </summary>
        /// <value>RejectionReason</value>
        [DataMember(Name="rejectionReason", EmitDefaultValue=false)]
        public FailureReason RejectionReason { get; private set; }

        /// <summary>
        /// StartTerminatingOn
        /// </summary>
        /// <value>StartTerminatingOn</value>
        [DataMember(Name="startTerminatingOn", EmitDefaultValue=false)]
        public DateTime? StartTerminatingOn { get; private set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public PaymentContractState? State { get; private set; }

        /// <summary>
        /// TerminatedBy
        /// </summary>
        /// <value>TerminatedBy</value>
        [DataMember(Name="terminatedBy", EmitDefaultValue=false)]
        public User TerminatedBy { get; private set; }

        /// <summary>
        /// TerminatedOn
        /// </summary>
        /// <value>TerminatedOn</value>
        [DataMember(Name="terminatedOn", EmitDefaultValue=false)]
        public DateTime? TerminatedOn { get; private set; }

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
            return this.Equals(obj as PaymentContract);
        }

        /// <summary>
        /// Returns true if PaymentContract instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentContract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentContract other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Account == other.Account ||
                    this.Account != null &&
                    this.Account.Equals(other.Account)
                ) && 
                (
                    this.ActivatedOn == other.ActivatedOn ||
                    this.ActivatedOn != null &&
                    this.ActivatedOn.Equals(other.ActivatedOn)
                ) && 
                (
                    this.ContractIdentifier == other.ContractIdentifier ||
                    this.ContractIdentifier != null &&
                    this.ContractIdentifier.Equals(other.ContractIdentifier)
                ) && 
                (
                    this.ContractType == other.ContractType ||
                    this.ContractType != null &&
                    this.ContractType.Equals(other.ContractType)
                ) && 
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) && 
                (
                    this.CreatedOn == other.CreatedOn ||
                    this.CreatedOn != null &&
                    this.CreatedOn.Equals(other.CreatedOn)
                ) && 
                (
                    this.ExternalId == other.ExternalId ||
                    this.ExternalId != null &&
                    this.ExternalId.Equals(other.ExternalId)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.RejectedOn == other.RejectedOn ||
                    this.RejectedOn != null &&
                    this.RejectedOn.Equals(other.RejectedOn)
                ) && 
                (
                    this.RejectionReason == other.RejectionReason ||
                    this.RejectionReason != null &&
                    this.RejectionReason.Equals(other.RejectionReason)
                ) && 
                (
                    this.StartTerminatingOn == other.StartTerminatingOn ||
                    this.StartTerminatingOn != null &&
                    this.StartTerminatingOn.Equals(other.StartTerminatingOn)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.TerminatedBy == other.TerminatedBy ||
                    this.TerminatedBy != null &&
                    this.TerminatedBy.Equals(other.TerminatedBy)
                ) && 
                (
                    this.TerminatedOn == other.TerminatedOn ||
                    this.TerminatedOn != null &&
                    this.TerminatedOn.Equals(other.TerminatedOn)
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
                if (this.Account != null)
                {
                    hash = hash * 59 + this.Account.GetHashCode();
                }
                if (this.ActivatedOn != null)
                {
                    hash = hash * 59 + this.ActivatedOn.GetHashCode();
                }
                if (this.ContractIdentifier != null)
                {
                    hash = hash * 59 + this.ContractIdentifier.GetHashCode();
                }
                if (this.ContractType != null)
                {
                    hash = hash * 59 + this.ContractType.GetHashCode();
                }
                if (this.CreatedBy != null)
                {
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                }
                if (this.CreatedOn != null)
                {
                    hash = hash * 59 + this.CreatedOn.GetHashCode();
                }
                if (this.ExternalId != null)
                {
                    hash = hash * 59 + this.ExternalId.GetHashCode();
                }
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.RejectedOn != null)
                {
                    hash = hash * 59 + this.RejectedOn.GetHashCode();
                }
                if (this.RejectionReason != null)
                {
                    hash = hash * 59 + this.RejectionReason.GetHashCode();
                }
                if (this.StartTerminatingOn != null)
                {
                    hash = hash * 59 + this.StartTerminatingOn.GetHashCode();
                }
                if (this.State != null)
                {
                    hash = hash * 59 + this.State.GetHashCode();
                }
                if (this.TerminatedBy != null)
                {
                    hash = hash * 59 + this.TerminatedBy.GetHashCode();
                }
                if (this.TerminatedOn != null)
                {
                    hash = hash * 59 + this.TerminatedOn.GetHashCode();
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
