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
    public partial class TokenCreate : AbstractTokenUpdate,  IEquatable<TokenCreate>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TokenCreate() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenCreate" /> class.
        /// </summary>
        /// <param name="ExternalId">The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity. (required)</param>
        /// <param name="State">State</param>
        public TokenCreate(string CustomerEmailAddress = default(string), bool? EnabledForOneClickPayment = default(bool?), CreationEntityState? State = default(CreationEntityState?), string Language = default(string), string TokenReference = default(string), string CustomerId = default(string), string ExternalId = default(string), string TimeZone = default(string))
        {
            // to ensure "ExternalId" is required (not null)
            if (ExternalId == null)
            {
                throw new ArgumentNullException("ExternalId is a required property for TokenCreate and cannot be null");
            }
            else
            {
                this.ExternalId = ExternalId;
            }
            this.State = State;
            this.CustomerEmailAddress = CustomerEmailAddress;
            this.CustomerId = CustomerId;
            this.EnabledForOneClickPayment = EnabledForOneClickPayment;
            this.Language = Language;
            this.TimeZone = TimeZone;
            this.TokenReference = TokenReference;
        }

        /// <summary>
        /// The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity.
        /// </summary>
        /// <value>The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public CreationEntityState? State { get; set; }

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
            return this.Equals(obj as TokenCreate);
        }

        /// <summary>
        /// Returns true if TokenCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of TokenCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenCreate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.ExternalId == other.ExternalId ||
                    this.ExternalId != null &&
                    this.ExternalId.Equals(other.ExternalId)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
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
                if (this.ExternalId != null)
                {
                    hash = hash * 59 + this.ExternalId.GetHashCode();
                }
                if (this.State != null)
                {
                    hash = hash * 59 + this.State.GetHashCode();
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
