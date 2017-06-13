
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
    /// DocumentTemplateType model.
    /// </summary>
    [DataContract]
    public partial class DocumentTemplateType :  IEquatable<DocumentTemplateType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentTemplateType" /> class.
        /// </summary>
        /// <param name="Description">Description</param>
        /// <param name="Feature">Feature</param>
        /// <param name="Id">The ID is the primary key of the entity. The ID identifies the entity uniquely.</param>
        /// <param name="TemplateResource">TemplateResource</param>
        /// <param name="Title">Title</param>
        public DocumentTemplateType(Dictionary<string, string> Description = default(Dictionary<string, string>), long? Feature = default(long?), long? Id = default(long?), string TemplateResource = default(string), Dictionary<string, string> Title = default(Dictionary<string, string>))
        {
            this.Description = Description;
            this.Feature = Feature;
            this.Id = Id;
            this.TemplateResource = TemplateResource;
            this.Title = Title;
        }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public Dictionary<string, string> Description { get; set; }

        /// <summary>
        /// Feature
        /// </summary>
        /// <value>Feature</value>
        [DataMember(Name="feature", EmitDefaultValue=false)]
        public long? Feature { get; set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// TemplateResource
        /// </summary>
        /// <value>TemplateResource</value>
        [DataMember(Name="templateResource", EmitDefaultValue=false)]
        public string TemplateResource { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        /// <value>Title</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public Dictionary<string, string> Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentTemplateType {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Feature: ").Append(Feature).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TemplateResource: ").Append(TemplateResource).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(obj as DocumentTemplateType);
        }

        /// <summary>
        /// Returns true if DocumentTemplateType instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentTemplateType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentTemplateType other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.SequenceEqual(other.Description)
                ) && 
                (
                    this.Feature == other.Feature ||
                    this.Feature != null &&
                    this.Feature.Equals(other.Feature)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.TemplateResource == other.TemplateResource ||
                    this.TemplateResource != null &&
                    this.TemplateResource.Equals(other.TemplateResource)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.SequenceEqual(other.Title)
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
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Feature != null)
                    hash = hash * 59 + this.Feature.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.TemplateResource != null)
                    hash = hash * 59 + this.TemplateResource.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                return hash;
            }
        }

    }

}
