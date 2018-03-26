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
    public partial class SpaceUpdate : AbstractSpaceUpdate,  IEquatable<SpaceUpdate>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SpaceUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SpaceUpdate() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpaceUpdate" /> class.
        /// </summary>
        /// <param name="Id">The ID is the primary key of the entity. The ID identifies the entity uniquely. (required)</param>
        /// <param name="Version">The version number indicates the version of the entity. The version is incremented whenever the entity is changed. (required)</param>
        public SpaceUpdate(string Name = default(string), long? Id = default(long?), SpaceAddressCreate PostalAddress = default(SpaceAddressCreate), long? Version = default(long?), List<string> TechnicalContactAddresses = default(List<string>), long? RequestLimit = default(long?), CreationEntityState? State = default(CreationEntityState?), string TimeZone = default(string))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new ArgumentNullException("Id is a required property for SpaceUpdate and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Version" is required (not null)
            if (Version == null)
            {
                throw new ArgumentNullException("Version is a required property for SpaceUpdate and cannot be null");
            }
            else
            {
                this.Version = Version;
            }
            this.Name = Name;
            this.PostalAddress = PostalAddress;
            this.RequestLimit = RequestLimit;
            this.State = State;
            this.TechnicalContactAddresses = TechnicalContactAddresses;
            this.TimeZone = TimeZone;
        }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public long? Version { get; set; }

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
            return this.Equals(obj as SpaceUpdate);
        }

        /// <summary>
        /// Returns true if SpaceUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of SpaceUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpaceUpdate other)
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
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.Version != null)
                {
                    hash = hash * 59 + this.Version.GetHashCode();
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
