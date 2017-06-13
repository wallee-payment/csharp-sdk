
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
    /// EmailTemplateType model.
    /// </summary>
    [DataContract]
    public partial class EmailTemplateType :  IEquatable<EmailTemplateType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailTemplateType" /> class.
        /// </summary>
        /// <param name="AttachmentResources">AttachmentResources</param>
        /// <param name="Description">Description</param>
        /// <param name="DocumentAttachments">DocumentAttachments</param>
        /// <param name="Feature">Feature</param>
        /// <param name="HtmlBodyTemplateResource">HtmlBodyTemplateResource</param>
        /// <param name="Id">The ID is the primary key of the entity. The ID identifies the entity uniquely.</param>
        /// <param name="Name">Name</param>
        /// <param name="Subject">Subject</param>
        /// <param name="TextBodyTemplateResource">TextBodyTemplateResource</param>
        public EmailTemplateType(List<AttachmentResource> AttachmentResources = default(List<AttachmentResource>), Dictionary<string, string> Description = default(Dictionary<string, string>), List<DocumentTemplateType> DocumentAttachments = default(List<DocumentTemplateType>), long? Feature = default(long?), string HtmlBodyTemplateResource = default(string), long? Id = default(long?), Dictionary<string, string> Name = default(Dictionary<string, string>), Dictionary<string, string> Subject = default(Dictionary<string, string>), string TextBodyTemplateResource = default(string))
        {
            this.AttachmentResources = AttachmentResources;
            this.Description = Description;
            this.DocumentAttachments = DocumentAttachments;
            this.Feature = Feature;
            this.HtmlBodyTemplateResource = HtmlBodyTemplateResource;
            this.Id = Id;
            this.Name = Name;
            this.Subject = Subject;
            this.TextBodyTemplateResource = TextBodyTemplateResource;
        }

        /// <summary>
        /// AttachmentResources
        /// </summary>
        /// <value>AttachmentResources</value>
        [DataMember(Name="attachmentResources", EmitDefaultValue=false)]
        public List<AttachmentResource> AttachmentResources { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public Dictionary<string, string> Description { get; set; }

        /// <summary>
        /// DocumentAttachments
        /// </summary>
        /// <value>DocumentAttachments</value>
        [DataMember(Name="documentAttachments", EmitDefaultValue=false)]
        public List<DocumentTemplateType> DocumentAttachments { get; set; }

        /// <summary>
        /// Feature
        /// </summary>
        /// <value>Feature</value>
        [DataMember(Name="feature", EmitDefaultValue=false)]
        public long? Feature { get; set; }

        /// <summary>
        /// HtmlBodyTemplateResource
        /// </summary>
        /// <value>HtmlBodyTemplateResource</value>
        [DataMember(Name="htmlBodyTemplateResource", EmitDefaultValue=false)]
        public string HtmlBodyTemplateResource { get; set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public Dictionary<string, string> Name { get; set; }

        /// <summary>
        /// Subject
        /// </summary>
        /// <value>Subject</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public Dictionary<string, string> Subject { get; set; }

        /// <summary>
        /// TextBodyTemplateResource
        /// </summary>
        /// <value>TextBodyTemplateResource</value>
        [DataMember(Name="textBodyTemplateResource", EmitDefaultValue=false)]
        public string TextBodyTemplateResource { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailTemplateType {\n");
            sb.Append("  AttachmentResources: ").Append(AttachmentResources).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DocumentAttachments: ").Append(DocumentAttachments).Append("\n");
            sb.Append("  Feature: ").Append(Feature).Append("\n");
            sb.Append("  HtmlBodyTemplateResource: ").Append(HtmlBodyTemplateResource).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  TextBodyTemplateResource: ").Append(TextBodyTemplateResource).Append("\n");
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
            return this.Equals(obj as EmailTemplateType);
        }

        /// <summary>
        /// Returns true if EmailTemplateType instances are equal
        /// </summary>
        /// <param name="other">Instance of EmailTemplateType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailTemplateType other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.AttachmentResources == other.AttachmentResources ||
                    this.AttachmentResources != null &&
                    this.AttachmentResources.SequenceEqual(other.AttachmentResources)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.SequenceEqual(other.Description)
                ) && 
                (
                    this.DocumentAttachments == other.DocumentAttachments ||
                    this.DocumentAttachments != null &&
                    this.DocumentAttachments.SequenceEqual(other.DocumentAttachments)
                ) && 
                (
                    this.Feature == other.Feature ||
                    this.Feature != null &&
                    this.Feature.Equals(other.Feature)
                ) && 
                (
                    this.HtmlBodyTemplateResource == other.HtmlBodyTemplateResource ||
                    this.HtmlBodyTemplateResource != null &&
                    this.HtmlBodyTemplateResource.Equals(other.HtmlBodyTemplateResource)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.SequenceEqual(other.Name)
                ) && 
                (
                    this.Subject == other.Subject ||
                    this.Subject != null &&
                    this.Subject.SequenceEqual(other.Subject)
                ) && 
                (
                    this.TextBodyTemplateResource == other.TextBodyTemplateResource ||
                    this.TextBodyTemplateResource != null &&
                    this.TextBodyTemplateResource.Equals(other.TextBodyTemplateResource)
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
                if (this.AttachmentResources != null)
                    hash = hash * 59 + this.AttachmentResources.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.DocumentAttachments != null)
                    hash = hash * 59 + this.DocumentAttachments.GetHashCode();
                if (this.Feature != null)
                    hash = hash * 59 + this.Feature.GetHashCode();
                if (this.HtmlBodyTemplateResource != null)
                    hash = hash * 59 + this.HtmlBodyTemplateResource.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Subject != null)
                    hash = hash * 59 + this.Subject.GetHashCode();
                if (this.TextBodyTemplateResource != null)
                    hash = hash * 59 + this.TextBodyTemplateResource.GetHashCode();
                return hash;
            }
        }

    }

}
