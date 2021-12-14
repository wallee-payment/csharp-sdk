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
    /// DatabaseTranslatedString
    /// </summary>
    [DataContract]
    public partial class DatabaseTranslatedString :  IEquatable<DatabaseTranslatedString>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseTranslatedString" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public DatabaseTranslatedString()
        {
        }

        /// <summary>
        /// Gets or Sets AvailableLanguages
        /// </summary>
        [DataMember(Name="availableLanguages", EmitDefaultValue=false)]
        public List<string> AvailableLanguages { get; private set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<DatabaseTranslatedStringItem> Items { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatabaseTranslatedString {\n");
            sb.Append("  AvailableLanguages: ").Append(AvailableLanguages).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return this.Equals(input as DatabaseTranslatedString);
        }

        /// <summary>
        /// Returns true if DatabaseTranslatedString instances are equal
        /// </summary>
        /// <param name="input">Instance of DatabaseTranslatedString to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatabaseTranslatedString input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AvailableLanguages == input.AvailableLanguages ||
                    this.AvailableLanguages != null &&
                    input.AvailableLanguages != null &&
                    this.AvailableLanguages.SequenceEqual(input.AvailableLanguages)
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
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
                if (this.AvailableLanguages != null)
                    hashCode = hashCode * 59 + this.AvailableLanguages.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                return hashCode;
            }
        }

    }

}
