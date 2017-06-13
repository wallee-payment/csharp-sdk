
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
    /// DatabaseTranslatedString model.
    /// </summary>
    [DataContract]
    public partial class DatabaseTranslatedString :  IEquatable<DatabaseTranslatedString>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseTranslatedString" /> class.
        /// </summary>
        /// <param name="AvailableLanguages">AvailableLanguages</param>
        /// <param name="Id">The ID is the primary key of the entity. The ID identifies the entity uniquely.</param>
        /// <param name="Items">Items</param>
        /// <param name="Version">The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</param>
        public DatabaseTranslatedString(List<string> AvailableLanguages = default(List<string>), long? Id = default(long?), List<DatabaseTranslatedStringItem> Items = default(List<DatabaseTranslatedStringItem>), int? Version = default(int?))
        {
            this.AvailableLanguages = AvailableLanguages;
            this.Id = Id;
            this.Items = Items;
            this.Version = Version;
        }

        /// <summary>
        /// AvailableLanguages
        /// </summary>
        /// <value>AvailableLanguages</value>
        [DataMember(Name="availableLanguages", EmitDefaultValue=false)]
        public List<string> AvailableLanguages { get; set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Items
        /// </summary>
        /// <value>Items</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<DatabaseTranslatedStringItem> Items { get; set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatabaseTranslatedString {\n");
            sb.Append("  AvailableLanguages: ").Append(AvailableLanguages).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Items == other.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(other.Items)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                if (this.AvailableLanguages != null)
                    hash = hash * 59 + this.AvailableLanguages.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Items != null)
                    hash = hash * 59 + this.Items.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                return hash;
            }
        }

    }

}
