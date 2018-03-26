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
    public partial class DatabaseTranslatedStringItem :  IEquatable<DatabaseTranslatedStringItem>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseTranslatedStringItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public DatabaseTranslatedStringItem()
        {
        }

        /// <summary>
        /// Language
        /// </summary>
        /// <value>Language</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; private set; }

        /// <summary>
        /// LanguageCode
        /// </summary>
        /// <value>LanguageCode</value>
        [DataMember(Name="languageCode", EmitDefaultValue=false)]
        public string LanguageCode { get; private set; }

        /// <summary>
        /// Translation
        /// </summary>
        /// <value>Translation</value>
        [DataMember(Name="translation", EmitDefaultValue=false)]
        public string Translation { get; private set; }

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
            return this.Equals(obj as DatabaseTranslatedStringItem);
        }

        /// <summary>
        /// Returns true if DatabaseTranslatedStringItem instances are equal
        /// </summary>
        /// <param name="other">Instance of DatabaseTranslatedStringItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatabaseTranslatedStringItem other)
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
                    this.LanguageCode == other.LanguageCode ||
                    this.LanguageCode != null &&
                    this.LanguageCode.Equals(other.LanguageCode)
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
                if (this.LanguageCode != null)
                {
                    hash = hash * 59 + this.LanguageCode.GetHashCode();
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
