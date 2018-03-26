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
    /// Database Translated String
    /// </summary>
    [DataContract]
    public partial class DatabaseTranslatedString :  IEquatable<DatabaseTranslatedString>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseTranslatedString" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public DatabaseTranslatedString()
        {
        }

        /// <summary>
        /// AvailableLanguages
        /// </summary>
        /// <value>AvailableLanguages</value>
        [DataMember(Name="availableLanguages", EmitDefaultValue=false)]
        public List<string> AvailableLanguages { get; private set; }

        /// <summary>
        /// DisplayName
        /// </summary>
        /// <value>DisplayName</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Items
        /// </summary>
        /// <value>Items</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<DatabaseTranslatedStringItem> Items { get; private set; }

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
            return this.Equals(obj as DatabaseTranslatedString);
        }

        /// <summary>
        /// Returns true if DatabaseTranslatedString instances are equal
        /// </summary>
        /// <param name="other">Instance of DatabaseTranslatedString to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatabaseTranslatedString other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.AvailableLanguages == other.AvailableLanguages ||
                    this.AvailableLanguages != null &&
                    this.AvailableLanguages.SequenceEqual(other.AvailableLanguages)
                ) && 
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    this.Items == other.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(other.Items)
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
                if (this.AvailableLanguages != null)
                {
                    hash = hash * 59 + this.AvailableLanguages.GetHashCode();
                }
                if (this.DisplayName != null)
                {
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                }
                if (this.Items != null)
                {
                    hash = hash * 59 + this.Items.GetHashCode();
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
