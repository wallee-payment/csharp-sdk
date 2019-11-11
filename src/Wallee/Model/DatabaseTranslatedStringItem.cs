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
    /// DatabaseTranslatedStringItem
    /// </summary>
    [DataContract]
    public partial class DatabaseTranslatedStringItem :  IEquatable<DatabaseTranslatedStringItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseTranslatedStringItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public DatabaseTranslatedStringItem()
        {
        }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; private set; }

        /// <summary>
        /// Gets or Sets LanguageCode
        /// </summary>
        [DataMember(Name="languageCode", EmitDefaultValue=false)]
        public string LanguageCode { get; private set; }

        /// <summary>
        /// Gets or Sets Translation
        /// </summary>
        [DataMember(Name="translation", EmitDefaultValue=false)]
        public string Translation { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatabaseTranslatedStringItem {\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
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
            return this.Equals(input as DatabaseTranslatedStringItem);
        }

        /// <summary>
        /// Returns true if DatabaseTranslatedStringItem instances are equal
        /// </summary>
        /// <param name="input">Instance of DatabaseTranslatedStringItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatabaseTranslatedStringItem input)
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
                    this.LanguageCode == input.LanguageCode ||
                    (this.LanguageCode != null &&
                    this.LanguageCode.Equals(input.LanguageCode))
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
                if (this.LanguageCode != null)
                    hashCode = hashCode * 59 + this.LanguageCode.GetHashCode();
                if (this.Translation != null)
                    hashCode = hashCode * 59 + this.Translation.GetHashCode();
                return hashCode;
            }
        }

    }

}
