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
    /// DatabaseTranslatedStringItemCreate
    /// </summary>
    [DataContract]
    public partial class DatabaseTranslatedStringItemCreate :  IEquatable<DatabaseTranslatedStringItemCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseTranslatedStringItemCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DatabaseTranslatedStringItemCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseTranslatedStringItemCreate" /> class.
        /// </summary>
        /// <param name="language">language (required).</param>
        public DatabaseTranslatedStringItemCreate(string language)
        {
            // to ensure "language" is required (not null)
            if (language == null)
            {
                throw new InvalidDataException("language is a required property for DatabaseTranslatedStringItemCreate and cannot be null");
            }
            this.Language = language;
        }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// Gets or Sets Translation
        /// </summary>
        [DataMember(Name="translation", EmitDefaultValue=false)]
        public string Translation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatabaseTranslatedStringItemCreate {\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Translation: ").Append(Translation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DatabaseTranslatedStringItemCreate);
        }

        /// <summary>
        /// Returns true if DatabaseTranslatedStringItemCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of DatabaseTranslatedStringItemCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatabaseTranslatedStringItemCreate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.Translation == input.Translation ||
                    (this.Translation != null &&
                    this.Translation.Equals(input.Translation))
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
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Translation != null)
                    hashCode = hashCode * 59 + this.Translation.GetHashCode();
                return hashCode;
            }
        }

    }

}
