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
    /// Database Translated String Item
    /// </summary>
    [DataContract]
    public partial class DatabaseTranslatedStringItemCreate :  IEquatable<DatabaseTranslatedStringItemCreate>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseTranslatedStringItemCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DatabaseTranslatedStringItemCreate() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseTranslatedStringItemCreate" /> class.
        /// </summary>
        /// <param name="Language">Language (required)</param>
        /// <param name="Translation">Translation</param>
        public DatabaseTranslatedStringItemCreate(string Translation = default(string), string Language = default(string))
        {
            // to ensure "Language" is required (not null)
            if (Language == null)
            {
                throw new ArgumentNullException("Language is a required property for DatabaseTranslatedStringItemCreate and cannot be null");
            }
            else
            {
                this.Language = Language;
            }
            this.Translation = Translation;
        }

        /// <summary>
        /// Language
        /// </summary>
        /// <value>Language</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// Translation
        /// </summary>
        /// <value>Translation</value>
        [DataMember(Name="translation", EmitDefaultValue=false)]
        public string Translation { get; set; }

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
            return this.Equals(obj as DatabaseTranslatedStringItemCreate);
        }

        /// <summary>
        /// Returns true if DatabaseTranslatedStringItemCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of DatabaseTranslatedStringItemCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatabaseTranslatedStringItemCreate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.Translation == other.Translation ||
                    this.Translation != null &&
                    this.Translation.Equals(other.Translation)
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
                if (this.Language != null)
                {
                    hash = hash * 59 + this.Language.GetHashCode();
                }
                if (this.Translation != null)
                {
                    hash = hash * 59 + this.Translation.GetHashCode();
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
