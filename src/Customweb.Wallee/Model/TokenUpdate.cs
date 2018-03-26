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
    /// Token
    /// </summary>
    [DataContract]
    public partial class TokenUpdate : AbstractTokenUpdate,  IEquatable<TokenUpdate>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TokenUpdate() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenUpdate" /> class.
        /// </summary>
        /// <param name="Id">The ID is the primary key of the entity. The ID identifies the entity uniquely. (required)</param>
        /// <param name="Version">The version number indicates the version of the entity. The version is incremented whenever the entity is changed. (required)</param>
        public TokenUpdate(long? Id = default(long?), string CustomerEmailAddress = default(string), bool? EnabledForOneClickPayment = default(bool?), long? Version = default(long?), string Language = default(string), string TokenReference = default(string), string CustomerId = default(string), string TimeZone = default(string))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new ArgumentNullException("Id is a required property for TokenUpdate and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Version" is required (not null)
            if (Version == null)
            {
                throw new ArgumentNullException("Version is a required property for TokenUpdate and cannot be null");
            }
            else
            {
                this.Version = Version;
            }
            this.CustomerEmailAddress = CustomerEmailAddress;
            this.CustomerId = CustomerId;
            this.EnabledForOneClickPayment = EnabledForOneClickPayment;
            this.Language = Language;
            this.TimeZone = TimeZone;
            this.TokenReference = TokenReference;
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
            return this.Equals(obj as TokenUpdate);
        }

        /// <summary>
        /// Returns true if TokenUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of TokenUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenUpdate other)
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
                    this.CustomerEmailAddress == other.CustomerEmailAddress ||
                    this.CustomerEmailAddress != null &&
                    this.CustomerEmailAddress.Equals(other.CustomerEmailAddress)
                ) && 
                (
                    this.CustomerId == other.CustomerId ||
                    this.CustomerId != null &&
                    this.CustomerId.Equals(other.CustomerId)
                ) && 
                (
                    this.EnabledForOneClickPayment == other.EnabledForOneClickPayment ||
                    this.EnabledForOneClickPayment != null &&
                    this.EnabledForOneClickPayment.Equals(other.EnabledForOneClickPayment)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.TimeZone == other.TimeZone ||
                    this.TimeZone != null &&
                    this.TimeZone.Equals(other.TimeZone)
                ) && 
                (
                    this.TokenReference == other.TokenReference ||
                    this.TokenReference != null &&
                    this.TokenReference.Equals(other.TokenReference)
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
                if (this.CustomerEmailAddress != null)
                {
                    hash = hash * 59 + this.CustomerEmailAddress.GetHashCode();
                }
                if (this.CustomerId != null)
                {
                    hash = hash * 59 + this.CustomerId.GetHashCode();
                }
                if (this.EnabledForOneClickPayment != null)
                {
                    hash = hash * 59 + this.EnabledForOneClickPayment.GetHashCode();
                }
                if (this.Language != null)
                {
                    hash = hash * 59 + this.Language.GetHashCode();
                }
                if (this.TimeZone != null)
                {
                    hash = hash * 59 + this.TimeZone.GetHashCode();
                }
                if (this.TokenReference != null)
                {
                    hash = hash * 59 + this.TokenReference.GetHashCode();
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
