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
    /// User Account Role
    /// </summary>
    [DataContract]
    public partial class UserAccountRole :  IEquatable<UserAccountRole>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UserAccountRole" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public UserAccountRole()
        {
        }

        /// <summary>
        /// Account
        /// </summary>
        /// <value>Account</value>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public long? Account { get; private set; }

        /// <summary>
        /// AppliesOnSubAccount
        /// </summary>
        /// <value>AppliesOnSubAccount</value>
        [DataMember(Name="appliesOnSubAccount", EmitDefaultValue=false)]
        public bool? AppliesOnSubAccount { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// Role
        /// </summary>
        /// <value>Role</value>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public long? Role { get; private set; }

        /// <summary>
        /// User
        /// </summary>
        /// <value>User</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public long? User { get; private set; }

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
            return this.Equals(obj as UserAccountRole);
        }

        /// <summary>
        /// Returns true if UserAccountRole instances are equal
        /// </summary>
        /// <param name="other">Instance of UserAccountRole to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAccountRole other)
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
                    this.AppliesOnSubAccount == other.AppliesOnSubAccount ||
                    this.AppliesOnSubAccount != null &&
                    this.AppliesOnSubAccount.Equals(other.AppliesOnSubAccount)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Role == other.Role ||
                    this.Role != null &&
                    this.Role.Equals(other.Role)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
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
                if (this.AppliesOnSubAccount != null)
                {
                    hash = hash * 59 + this.AppliesOnSubAccount.GetHashCode();
                }
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.Role != null)
                {
                    hash = hash * 59 + this.Role.GetHashCode();
                }
                if (this.User != null)
                {
                    hash = hash * 59 + this.User.GetHashCode();
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
