
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
    /// LocalizedString model.
    /// </summary>
    [DataContract]
    public partial class LocalizedString :  IEquatable<LocalizedString>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizedString" /> class.
        /// </summary>
        /// <param name="DisplayName">DisplayName</param>
        /// <param name="Language">Language</param>
        /// <param name="_String">_String</param>
        public LocalizedString(string DisplayName = default(string), string Language = default(string), string _String = default(string))
        {
            this.DisplayName = DisplayName;
            this.Language = Language;
            this._String = _String;
        }

        /// <summary>
        /// DisplayName
        /// </summary>
        /// <value>DisplayName</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Language
        /// </summary>
        /// <value>Language</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// _String
        /// </summary>
        /// <value>_String</value>
        [DataMember(Name="string", EmitDefaultValue=false)]
        public string _String { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LocalizedString {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  _String: ").Append(_String).Append("\n");
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
            return this.Equals(obj as LocalizedString);
        }

        /// <summary>
        /// Returns true if LocalizedString instances are equal
        /// </summary>
        /// <param name="other">Instance of LocalizedString to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocalizedString other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this._String == other._String ||
                    this._String != null &&
                    this._String.Equals(other._String)
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
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                if (this._String != null)
                    hash = hash * 59 + this._String.GetHashCode();
                return hash;
            }
        }

    }

}
