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
using SwaggerDateConverter = Wallee.Client.SwaggerDateConverter;

namespace Wallee.Model
{
    /// <summary>
    /// LegalOrganizationForm
    /// </summary>
    [DataContract]
    public partial class LegalOrganizationForm :  IEquatable<LegalOrganizationForm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LegalOrganizationForm" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public LegalOrganizationForm()
        {
        }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=true)]
        public string Country { get; private set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public List<LocalizedString> Description { get; private set; }

        /// <summary>
        /// Gets or Sets EnglishDescription
        /// </summary>
        [DataMember(Name="englishDescription", EmitDefaultValue=true)]
        public string EnglishDescription { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; private set; }

        /// <summary>
        /// Gets or Sets Shortcut
        /// </summary>
        [DataMember(Name="shortcut", EmitDefaultValue=true)]
        public List<LocalizedString> Shortcut { get; private set; }

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
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as LegalOrganizationForm);
        }

        /// <summary>
        /// Returns true if LegalOrganizationForm instances are equal
        /// </summary>
        /// <param name="input">Instance of LegalOrganizationForm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LegalOrganizationForm input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Description == input.Description ||
                    this.Description != null &&
                    input.Description != null &&
                    this.Description.SequenceEqual(input.Description)
                ) && 
                (
                    this.EnglishDescription == input.EnglishDescription ||
                    (this.EnglishDescription != null &&
                    this.EnglishDescription.Equals(input.EnglishDescription))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Shortcut == input.Shortcut ||
                    this.Shortcut != null &&
                    input.Shortcut != null &&
                    this.Shortcut.SequenceEqual(input.Shortcut)
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
                int hashCode = 41;
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EnglishDescription != null)
                    hashCode = hashCode * 59 + this.EnglishDescription.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Shortcut != null)
                    hashCode = hashCode * 59 + this.Shortcut.GetHashCode();
                return hashCode;
            }
        }

    }

}
