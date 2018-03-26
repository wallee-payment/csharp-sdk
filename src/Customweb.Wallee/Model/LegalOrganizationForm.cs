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
    /// Legal Organization Form
    /// </summary>
    [DataContract]
    public partial class LegalOrganizationForm :  IEquatable<LegalOrganizationForm>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="LegalOrganizationForm" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public LegalOrganizationForm()
        {
        }

        /// <summary>
        /// Country
        /// </summary>
        /// <value>Country</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; private set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public List<LocalizedString> Description { get; private set; }

        /// <summary>
        /// EnglishDescription
        /// </summary>
        /// <value>EnglishDescription</value>
        [DataMember(Name="englishDescription", EmitDefaultValue=false)]
        public string EnglishDescription { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// Shortcut
        /// </summary>
        /// <value>Shortcut</value>
        [DataMember(Name="shortcut", EmitDefaultValue=false)]
        public List<LocalizedString> Shortcut { get; private set; }

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
            return this.Equals(obj as LegalOrganizationForm);
        }

        /// <summary>
        /// Returns true if LegalOrganizationForm instances are equal
        /// </summary>
        /// <param name="other">Instance of LegalOrganizationForm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LegalOrganizationForm other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.SequenceEqual(other.Description)
                ) && 
                (
                    this.EnglishDescription == other.EnglishDescription ||
                    this.EnglishDescription != null &&
                    this.EnglishDescription.Equals(other.EnglishDescription)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Shortcut == other.Shortcut ||
                    this.Shortcut != null &&
                    this.Shortcut.SequenceEqual(other.Shortcut)
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
                if (this.Country != null)
                {
                    hash = hash * 59 + this.Country.GetHashCode();
                }
                if (this.Description != null)
                {
                    hash = hash * 59 + this.Description.GetHashCode();
                }
                if (this.EnglishDescription != null)
                {
                    hash = hash * 59 + this.EnglishDescription.GetHashCode();
                }
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.Shortcut != null)
                {
                    hash = hash * 59 + this.Shortcut.GetHashCode();
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
