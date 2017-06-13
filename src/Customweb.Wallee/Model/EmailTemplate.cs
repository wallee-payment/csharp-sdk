
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
    /// EmailTemplate model.
    /// </summary>
    [DataContract]
    public partial class EmailTemplate :  IEquatable<EmailTemplate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailTemplate" /> class.
        /// </summary>
        /// <param name="AttachedDocumentTemplateTypes">AttachedDocumentTemplateTypes</param>
        /// <param name="BlindCarbonCopyRecipients">BlindCarbonCopyRecipients</param>
        /// <param name="CarbonCopyRecipients">CarbonCopyRecipients</param>
        /// <param name="HtmlBodyTemplateResource">The HTML body resource is used to produce the actual HTML message of the email.</param>
        /// <param name="Id">The ID is the primary key of the entity. The ID identifies the entity uniquely.</param>
        /// <param name="LinkedSpaceId">The linked space id holds the ID of the space to which the entity belongs to.</param>
        /// <param name="Name">The template name is used internally to identify the template in administrative interfaces. For example it is used within search fields and hence it should be distinct and descriptive.</param>
        /// <param name="PlannedPurgeDate">The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</param>
        /// <param name="State">State</param>
        /// <param name="Subject">The subject is going to be shown to the customer as a title.</param>
        /// <param name="TextBodyTemplateResource">The HTML body resource is used to produce the actual text message of the email. In case no resource is selected the HTML message is translated into the text format.</param>
        /// <param name="Type">Type</param>
        /// <param name="Version">The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</param>
        public EmailTemplate(List<DocumentTemplateType> AttachedDocumentTemplateTypes = default(List<DocumentTemplateType>), List<string> BlindCarbonCopyRecipients = default(List<string>), List<string> CarbonCopyRecipients = default(List<string>), ResourcePath HtmlBodyTemplateResource = default(ResourcePath), long? Id = default(long?), long? LinkedSpaceId = default(long?), string Name = default(string), DateTime? PlannedPurgeDate = default(DateTime?), CreationEntityState State = default(CreationEntityState), DatabaseTranslatedString Subject = default(DatabaseTranslatedString), ResourcePath TextBodyTemplateResource = default(ResourcePath), long? Type = default(long?), int? Version = default(int?))
        {
            this.AttachedDocumentTemplateTypes = AttachedDocumentTemplateTypes;
            this.BlindCarbonCopyRecipients = BlindCarbonCopyRecipients;
            this.CarbonCopyRecipients = CarbonCopyRecipients;
            this.HtmlBodyTemplateResource = HtmlBodyTemplateResource;
            this.Id = Id;
            this.LinkedSpaceId = LinkedSpaceId;
            this.Name = Name;
            this.PlannedPurgeDate = PlannedPurgeDate;
            this.State = State;
            this.Subject = Subject;
            this.TextBodyTemplateResource = TextBodyTemplateResource;
            this.Type = Type;
            this.Version = Version;
        }

        /// <summary>
        /// AttachedDocumentTemplateTypes
        /// </summary>
        /// <value>AttachedDocumentTemplateTypes</value>
        [DataMember(Name="attachedDocumentTemplateTypes", EmitDefaultValue=false)]
        public List<DocumentTemplateType> AttachedDocumentTemplateTypes { get; set; }

        /// <summary>
        /// BlindCarbonCopyRecipients
        /// </summary>
        /// <value>BlindCarbonCopyRecipients</value>
        [DataMember(Name="blindCarbonCopyRecipients", EmitDefaultValue=false)]
        public List<string> BlindCarbonCopyRecipients { get; set; }

        /// <summary>
        /// CarbonCopyRecipients
        /// </summary>
        /// <value>CarbonCopyRecipients</value>
        [DataMember(Name="carbonCopyRecipients", EmitDefaultValue=false)]
        public List<string> CarbonCopyRecipients { get; set; }

        /// <summary>
        /// The HTML body resource is used to produce the actual HTML message of the email.
        /// </summary>
        /// <value>The HTML body resource is used to produce the actual HTML message of the email.</value>
        [DataMember(Name="htmlBodyTemplateResource", EmitDefaultValue=false)]
        public ResourcePath HtmlBodyTemplateResource { get; set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; set; }

        /// <summary>
        /// The template name is used internally to identify the template in administrative interfaces. For example it is used within search fields and hence it should be distinct and descriptive.
        /// </summary>
        /// <value>The template name is used internally to identify the template in administrative interfaces. For example it is used within search fields and hence it should be distinct and descriptive.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public CreationEntityState State { get; set; }

        /// <summary>
        /// The subject is going to be shown to the customer as a title.
        /// </summary>
        /// <value>The subject is going to be shown to the customer as a title.</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public DatabaseTranslatedString Subject { get; set; }

        /// <summary>
        /// The HTML body resource is used to produce the actual text message of the email. In case no resource is selected the HTML message is translated into the text format.
        /// </summary>
        /// <value>The HTML body resource is used to produce the actual text message of the email. In case no resource is selected the HTML message is translated into the text format.</value>
        [DataMember(Name="textBodyTemplateResource", EmitDefaultValue=false)]
        public ResourcePath TextBodyTemplateResource { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        /// <value>Type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public long? Type { get; set; }

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
            sb.Append("class EmailTemplate {\n");
            sb.Append("  AttachedDocumentTemplateTypes: ").Append(AttachedDocumentTemplateTypes).Append("\n");
            sb.Append("  BlindCarbonCopyRecipients: ").Append(BlindCarbonCopyRecipients).Append("\n");
            sb.Append("  CarbonCopyRecipients: ").Append(CarbonCopyRecipients).Append("\n");
            sb.Append("  HtmlBodyTemplateResource: ").Append(HtmlBodyTemplateResource).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  TextBodyTemplateResource: ").Append(TextBodyTemplateResource).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as EmailTemplate);
        }

        /// <summary>
        /// Returns true if EmailTemplate instances are equal
        /// </summary>
        /// <param name="other">Instance of EmailTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailTemplate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.AttachedDocumentTemplateTypes == other.AttachedDocumentTemplateTypes ||
                    this.AttachedDocumentTemplateTypes != null &&
                    this.AttachedDocumentTemplateTypes.SequenceEqual(other.AttachedDocumentTemplateTypes)
                ) && 
                (
                    this.BlindCarbonCopyRecipients == other.BlindCarbonCopyRecipients ||
                    this.BlindCarbonCopyRecipients != null &&
                    this.BlindCarbonCopyRecipients.SequenceEqual(other.BlindCarbonCopyRecipients)
                ) && 
                (
                    this.CarbonCopyRecipients == other.CarbonCopyRecipients ||
                    this.CarbonCopyRecipients != null &&
                    this.CarbonCopyRecipients.SequenceEqual(other.CarbonCopyRecipients)
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
                    this.LinkedSpaceId == other.LinkedSpaceId ||
                    this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(other.LinkedSpaceId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.PlannedPurgeDate == other.PlannedPurgeDate ||
                    this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(other.PlannedPurgeDate)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Subject == other.Subject ||
                    this.Subject != null &&
                    this.Subject.Equals(other.Subject)
                ) && 
                (
                    this.TextBodyTemplateResource == other.TextBodyTemplateResource ||
                    this.TextBodyTemplateResource != null &&
                    this.TextBodyTemplateResource.Equals(other.TextBodyTemplateResource)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.AttachedDocumentTemplateTypes != null)
                    hash = hash * 59 + this.AttachedDocumentTemplateTypes.GetHashCode();
                if (this.BlindCarbonCopyRecipients != null)
                    hash = hash * 59 + this.BlindCarbonCopyRecipients.GetHashCode();
                if (this.CarbonCopyRecipients != null)
                    hash = hash * 59 + this.CarbonCopyRecipients.GetHashCode();
                if (this.HtmlBodyTemplateResource != null)
                    hash = hash * 59 + this.HtmlBodyTemplateResource.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hash = hash * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hash = hash * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Subject != null)
                    hash = hash * 59 + this.Subject.GetHashCode();
                if (this.TextBodyTemplateResource != null)
                    hash = hash * 59 + this.TextBodyTemplateResource.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                return hash;
            }
        }

    }

}
