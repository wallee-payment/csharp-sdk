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
    /// Human User
    /// </summary>
    [DataContract]
    public partial class HumanUserCreate : AbstractHumanUserUpdate,  IEquatable<HumanUserCreate>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="HumanUserCreate" /> class.
        /// </summary>
        /// <param name="PrimaryAccount">The primary account links the user to a specific account.</param>
        public HumanUserCreate(string Language = default(string), long? PrimaryAccount = default(long?), string EmailAddress = default(string), string Lastname = default(string), CreationEntityState? State = default(CreationEntityState?), string TimeZone = default(string), string Firstname = default(string))
        {
            this.PrimaryAccount = PrimaryAccount;
            this.EmailAddress = EmailAddress;
            this.Firstname = Firstname;
            this.Language = Language;
            this.Lastname = Lastname;
            this.State = State;
            this.TimeZone = TimeZone;
        }

        /// <summary>
        /// The primary account links the user to a specific account.
        /// </summary>
        /// <value>The primary account links the user to a specific account.</value>
        [DataMember(Name="primaryAccount", EmitDefaultValue=false)]
        public long? PrimaryAccount { get; set; }

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
            return this.Equals(obj as HumanUserCreate);
        }

        /// <summary>
        /// Returns true if HumanUserCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of HumanUserCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HumanUserCreate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.PrimaryAccount == other.PrimaryAccount ||
                    this.PrimaryAccount != null &&
                    this.PrimaryAccount.Equals(other.PrimaryAccount)
                ) && 
                (
                    this.EmailAddress == other.EmailAddress ||
                    this.EmailAddress != null &&
                    this.EmailAddress.Equals(other.EmailAddress)
                ) && 
                (
                    this.Firstname == other.Firstname ||
                    this.Firstname != null &&
                    this.Firstname.Equals(other.Firstname)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.Lastname == other.Lastname ||
                    this.Lastname != null &&
                    this.Lastname.Equals(other.Lastname)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.TimeZone == other.TimeZone ||
                    this.TimeZone != null &&
                    this.TimeZone.Equals(other.TimeZone)
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
                if (this.PrimaryAccount != null)
                {
                    hash = hash * 59 + this.PrimaryAccount.GetHashCode();
                }
                if (this.EmailAddress != null)
                {
                    hash = hash * 59 + this.EmailAddress.GetHashCode();
                }
                if (this.Firstname != null)
                {
                    hash = hash * 59 + this.Firstname.GetHashCode();
                }
                if (this.Language != null)
                {
                    hash = hash * 59 + this.Language.GetHashCode();
                }
                if (this.Lastname != null)
                {
                    hash = hash * 59 + this.Lastname.GetHashCode();
                }
                if (this.State != null)
                {
                    hash = hash * 59 + this.State.GetHashCode();
                }
                if (this.TimeZone != null)
                {
                    hash = hash * 59 + this.TimeZone.GetHashCode();
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
