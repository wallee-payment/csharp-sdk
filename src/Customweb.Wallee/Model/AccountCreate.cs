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
    public partial class AccountCreate : AbstractAccountUpdate,  IEquatable<AccountCreate>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountCreate" /> class.
        /// </summary>
        /// <param name="ParentAccount">The account which is responsible for administering the account.</param>
        public AccountCreate(string Name = default(string), long? SubaccountLimit = default(long?), long? ParentAccount = default(long?))
        {
            this.ParentAccount = ParentAccount;
            this.Name = Name;
            this.SubaccountLimit = SubaccountLimit;
        }

        /// <summary>
        /// The account which is responsible for administering the account.
        /// </summary>
        /// <value>The account which is responsible for administering the account.</value>
        [DataMember(Name="parentAccount", EmitDefaultValue=false)]
        public long? ParentAccount { get; set; }

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
            return this.Equals(obj as AccountCreate);
        }

        /// <summary>
        /// Returns true if AccountCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountCreate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.ParentAccount == other.ParentAccount ||
                    this.ParentAccount != null &&
                    this.ParentAccount.Equals(other.ParentAccount)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.SubaccountLimit == other.SubaccountLimit ||
                    this.SubaccountLimit != null &&
                    this.SubaccountLimit.Equals(other.SubaccountLimit)
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
                if (this.ParentAccount != null)
                {
                    hash = hash * 59 + this.ParentAccount.GetHashCode();
                }
                if (this.Name != null)
                {
                    hash = hash * 59 + this.Name.GetHashCode();
                }
                if (this.SubaccountLimit != null)
                {
                    hash = hash * 59 + this.SubaccountLimit.GetHashCode();
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
