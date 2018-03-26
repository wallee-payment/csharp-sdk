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
    /// Account
    /// </summary>
    [DataContract]
    public partial class Account :  IEquatable<Account>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Account()
        {
        }

        /// <summary>
        /// Active means that this account and all accounts in the hierarchy are active.
        /// </summary>
        /// <value>Active means that this account and all accounts in the hierarchy are active.</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; private set; }

        /// <summary>
        /// This property is true when all accounts in the hierarchy are active or restricted active.
        /// </summary>
        /// <value>This property is true when all accounts in the hierarchy are active or restricted active.</value>
        [DataMember(Name="activeOrRestrictedActive", EmitDefaultValue=false)]
        public bool? ActiveOrRestrictedActive { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The name of the account identifies the account within the administrative interface.
        /// </summary>
        /// <value>The name of the account identifies the account within the administrative interface.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// The account which is responsible for administering the account.
        /// </summary>
        /// <value>The account which is responsible for administering the account.</value>
        [DataMember(Name="parentAccount", EmitDefaultValue=false)]
        public Account ParentAccount { get; private set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// Restricted active means that at least one account in the hierarchy is only restricted active, but all are either restricted active or active.
        /// </summary>
        /// <value>Restricted active means that at least one account in the hierarchy is only restricted active, but all are either restricted active or active.</value>
        [DataMember(Name="restrictedActive", EmitDefaultValue=false)]
        public bool? RestrictedActive { get; private set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public AccountState? State { get; private set; }

        /// <summary>
        /// This property restricts the number of subaccounts which can be created within this account.
        /// </summary>
        /// <value>This property restricts the number of subaccounts which can be created within this account.</value>
        [DataMember(Name="subaccountLimit", EmitDefaultValue=false)]
        public long? SubaccountLimit { get; private set; }

        /// <summary>
        /// The account type defines which role and capabilities it has.
        /// </summary>
        /// <value>The account type defines which role and capabilities it has.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public AccountType? Type { get; private set; }

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
            return this.Equals(obj as Account);
        }

        /// <summary>
        /// Returns true if Account instances are equal
        /// </summary>
        /// <param name="other">Instance of Account to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Account other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
                ) && 
                (
                    this.ActiveOrRestrictedActive == other.ActiveOrRestrictedActive ||
                    this.ActiveOrRestrictedActive != null &&
                    this.ActiveOrRestrictedActive.Equals(other.ActiveOrRestrictedActive)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.ParentAccount == other.ParentAccount ||
                    this.ParentAccount != null &&
                    this.ParentAccount.Equals(other.ParentAccount)
                ) && 
                (
                    this.PlannedPurgeDate == other.PlannedPurgeDate ||
                    this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(other.PlannedPurgeDate)
                ) && 
                (
                    this.RestrictedActive == other.RestrictedActive ||
                    this.RestrictedActive != null &&
                    this.RestrictedActive.Equals(other.RestrictedActive)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.SubaccountLimit == other.SubaccountLimit ||
                    this.SubaccountLimit != null &&
                    this.SubaccountLimit.Equals(other.SubaccountLimit)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.Active != null)
                {
                    hash = hash * 59 + this.Active.GetHashCode();
                }
                if (this.ActiveOrRestrictedActive != null)
                {
                    hash = hash * 59 + this.ActiveOrRestrictedActive.GetHashCode();
                }
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hash = hash * 59 + this.Name.GetHashCode();
                }
                if (this.ParentAccount != null)
                {
                    hash = hash * 59 + this.ParentAccount.GetHashCode();
                }
                if (this.PlannedPurgeDate != null)
                {
                    hash = hash * 59 + this.PlannedPurgeDate.GetHashCode();
                }
                if (this.RestrictedActive != null)
                {
                    hash = hash * 59 + this.RestrictedActive.GetHashCode();
                }
                if (this.State != null)
                {
                    hash = hash * 59 + this.State.GetHashCode();
                }
                if (this.SubaccountLimit != null)
                {
                    hash = hash * 59 + this.SubaccountLimit.GetHashCode();
                }
                if (this.Type != null)
                {
                    hash = hash * 59 + this.Type.GetHashCode();
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
