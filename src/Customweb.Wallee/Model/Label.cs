
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
    /// Label model.
    /// </summary>
    [DataContract]
    public partial class Label :  IEquatable<Label>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Label" /> class.
        /// </summary>
        /// <param name="Content">Content</param>
        /// <param name="ContentAsString">ContentAsString</param>
        /// <param name="Descriptor">Descriptor</param>
        /// <param name="Id">The ID is the primary key of the entity. The ID identifies the entity uniquely.</param>
        /// <param name="Version">The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</param>
        public Label(Object Content = default(Object), string ContentAsString = default(string), LabelDescriptor Descriptor = default(LabelDescriptor), long? Id = default(long?), int? Version = default(int?))
        {
            this.Content = Content;
            this.ContentAsString = ContentAsString;
            this.Descriptor = Descriptor;
            this.Id = Id;
            this.Version = Version;
        }

        /// <summary>
        /// Content
        /// </summary>
        /// <value>Content</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public Object Content { get; set; }

        /// <summary>
        /// ContentAsString
        /// </summary>
        /// <value>ContentAsString</value>
        [DataMember(Name="contentAsString", EmitDefaultValue=false)]
        public string ContentAsString { get; set; }

        /// <summary>
        /// Descriptor
        /// </summary>
        /// <value>Descriptor</value>
        [DataMember(Name="descriptor", EmitDefaultValue=false)]
        public LabelDescriptor Descriptor { get; set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

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
            sb.Append("class Label {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  ContentAsString: ").Append(ContentAsString).Append("\n");
            sb.Append("  Descriptor: ").Append(Descriptor).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(obj as Label);
        }

        /// <summary>
        /// Returns true if Label instances are equal
        /// </summary>
        /// <param name="other">Instance of Label to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Label other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.Equals(other.Content)
                ) && 
                (
                    this.ContentAsString == other.ContentAsString ||
                    this.ContentAsString != null &&
                    this.ContentAsString.Equals(other.ContentAsString)
                ) && 
                (
                    this.Descriptor == other.Descriptor ||
                    this.Descriptor != null &&
                    this.Descriptor.Equals(other.Descriptor)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                if (this.Content != null)
                    hash = hash * 59 + this.Content.GetHashCode();
                if (this.ContentAsString != null)
                    hash = hash * 59 + this.ContentAsString.GetHashCode();
                if (this.Descriptor != null)
                    hash = hash * 59 + this.Descriptor.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                return hash;
            }
        }

    }

}
