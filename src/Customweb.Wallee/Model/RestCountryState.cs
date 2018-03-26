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
    /// State
    /// </summary>
    [DataContract]
    public partial class RestCountryState :  IEquatable<RestCountryState>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="RestCountryState" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public RestCountryState()
        {
        }

        /// <summary>
        /// The code of the state identifies the state. The code is typically used within addresses. Some countries may not provide a code. For those the field is null.
        /// </summary>
        /// <value>The code of the state identifies the state. The code is typically used within addresses. Some countries may not provide a code. For those the field is null.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; private set; }

        /// <summary>
        /// The country code in ISO two letter format (e.g. UK, DE, CH, US).
        /// </summary>
        /// <value>The country code in ISO two letter format (e.g. UK, DE, CH, US).</value>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; private set; }

        /// <summary>
        /// The ID of the state corresponds to the subdivision identifier defined in ISO 3166-2. The format consists of the country code followed by a dash and a subdivision identifier.
        /// </summary>
        /// <value>The ID of the state corresponds to the subdivision identifier defined in ISO 3166-2. The format consists of the country code followed by a dash and a subdivision identifier.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }

        /// <summary>
        /// The name is a human readable label of the state in the language of the region.
        /// </summary>
        /// <value>The name is a human readable label of the state in the language of the region.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

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
            return this.Equals(obj as RestCountryState);
        }

        /// <summary>
        /// Returns true if RestCountryState instances are equal
        /// </summary>
        /// <param name="other">Instance of RestCountryState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestCountryState other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.CountryCode == other.CountryCode ||
                    this.CountryCode != null &&
                    this.CountryCode.Equals(other.CountryCode)
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
                if (this.Code != null)
                {
                    hash = hash * 59 + this.Code.GetHashCode();
                }
                if (this.CountryCode != null)
                {
                    hash = hash * 59 + this.CountryCode.GetHashCode();
                }
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hash = hash * 59 + this.Name.GetHashCode();
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
