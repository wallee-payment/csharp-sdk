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
    /// Space
    /// </summary>
    [DataContract]
    public partial class SpaceCreate : AbstractSpaceUpdate,  IEquatable<SpaceCreate>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SpaceCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SpaceCreate() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpaceCreate" /> class.
        /// </summary>
        /// <param name="Account">The account to which the space belongs to. (required)</param>
        public SpaceCreate(long? Account = default(long?), string Name = default(string), SpaceAddressCreate PostalAddress = default(SpaceAddressCreate), List<string> TechnicalContactAddresses = default(List<string>), CreationEntityState? State = default(CreationEntityState?), string TimeZone = default(string), long? RequestLimit = default(long?))
        {
            // to ensure "Account" is required (not null)
            if (Account == null)
            {
                throw new ArgumentNullException("Account is a required property for SpaceCreate and cannot be null");
            }
            else
            {
                this.Account = Account;
            }
            this.Name = Name;
            this.PostalAddress = PostalAddress;
            this.RequestLimit = RequestLimit;
            this.State = State;
            this.TechnicalContactAddresses = TechnicalContactAddresses;
            this.TimeZone = TimeZone;
        }

        /// <summary>
        /// The account to which the space belongs to.
        /// </summary>
        /// <value>The account to which the space belongs to.</value>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public long? Account { get; set; }

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
            return this.Equals(obj as SpaceCreate);
        }

        /// <summary>
        /// Returns true if SpaceCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of SpaceCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpaceCreate other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.PostalAddress == other.PostalAddress ||
                    this.PostalAddress != null &&
                    this.PostalAddress.Equals(other.PostalAddress)
                ) && 
                (
                    this.RequestLimit == other.RequestLimit ||
                    this.RequestLimit != null &&
                    this.RequestLimit.Equals(other.RequestLimit)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.TechnicalContactAddresses == other.TechnicalContactAddresses ||
                    this.TechnicalContactAddresses != null &&
                    this.TechnicalContactAddresses.SequenceEqual(other.TechnicalContactAddresses)
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
                if (this.Account != null)
                {
                    hash = hash * 59 + this.Account.GetHashCode();
                }
                if (this.Name != null)
                {
                    hash = hash * 59 + this.Name.GetHashCode();
                }
                if (this.PostalAddress != null)
                {
                    hash = hash * 59 + this.PostalAddress.GetHashCode();
                }
                if (this.RequestLimit != null)
                {
                    hash = hash * 59 + this.RequestLimit.GetHashCode();
                }
                if (this.State != null)
                {
                    hash = hash * 59 + this.State.GetHashCode();
                }
                if (this.TechnicalContactAddresses != null)
                {
                    hash = hash * 59 + this.TechnicalContactAddresses.GetHashCode();
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
