
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
    /// LegalOrganizationForm model.
    /// </summary>
    [DataContract]
    public partial class LegalOrganizationForm :  IEquatable<LegalOrganizationForm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LegalOrganizationForm" /> class.
        /// </summary>
        /// <param name="Country">Country</param>
        /// <param name="Description">Description</param>
        /// <param name="EnglishDescription">EnglishDescription</param>
        /// <param name="Id">The ID is the primary key of the entity. The ID identifies the entity uniquely.</param>
        /// <param name="Shortcut">Shortcut</param>
        public LegalOrganizationForm(string Country = default(string), List<LocalizedString> Description = default(List<LocalizedString>), string EnglishDescription = default(string), long? Id = default(long?), List<LocalizedString> Shortcut = default(List<LocalizedString>))
        {
            this.Country = Country;
            this.Description = Description;
            this.EnglishDescription = EnglishDescription;
            this.Id = Id;
            this.Shortcut = Shortcut;
        }

        /// <summary>
        /// Country
        /// </summary>
        /// <value>Country</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public List<LocalizedString> Description { get; set; }

        /// <summary>
        /// EnglishDescription
        /// </summary>
        /// <value>EnglishDescription</value>
        [DataMember(Name="englishDescription", EmitDefaultValue=false)]
        public string EnglishDescription { get; set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Shortcut
        /// </summary>
        /// <value>Shortcut</value>
        [DataMember(Name="shortcut", EmitDefaultValue=false)]
        public List<LocalizedString> Shortcut { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LegalOrganizationForm {\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EnglishDescription: ").Append(EnglishDescription).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Shortcut: ").Append(Shortcut).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
                // Suitable nullity checks etc, of course :)
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.EnglishDescription != null)
                    hash = hash * 59 + this.EnglishDescription.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Shortcut != null)
                    hash = hash * 59 + this.Shortcut.GetHashCode();
                return hash;
            }
        }

    }

}
