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
    /// A document template contains the customizations for a particular document template type.
    /// </summary>
    [DataContract]
    public partial class DocumentTemplate :  IEquatable<DocumentTemplate>
    {
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public CreationEntityState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentTemplate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public DocumentTemplate()
        {
        }

        /// <summary>
        /// The default document template is used whenever no specific template is specified for a particular template type.
        /// </summary>
        /// <value>The default document template is used whenever no specific template is specified for a particular template type.</value>
        [DataMember(Name="defaultTemplate", EmitDefaultValue=false)]
        public bool? DefaultTemplate { get; private set; }

        /// <summary>
        /// Gets or Sets DeliveryEnabled
        /// </summary>
        [DataMember(Name="deliveryEnabled", EmitDefaultValue=false)]
        public bool? DeliveryEnabled { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// Gets or Sets SpaceId
        /// </summary>
        [DataMember(Name="spaceId", EmitDefaultValue=false)]
        public long? SpaceId { get; private set; }


        /// <summary>
        /// Gets or Sets TemplateResource
        /// </summary>
        [DataMember(Name="templateResource", EmitDefaultValue=false)]
        public ResourcePath TemplateResource { get; private set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public long? Type { get; private set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentTemplate {\n");
            sb.Append("  DefaultTemplate: ").Append(DefaultTemplate).Append("\n");
            sb.Append("  DeliveryEnabled: ").Append(DeliveryEnabled).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  SpaceId: ").Append(SpaceId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  TemplateResource: ").Append(TemplateResource).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as DocumentTemplate);
        }

        /// <summary>
        /// Returns true if DocumentTemplate instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentTemplate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DefaultTemplate == input.DefaultTemplate ||
                    (this.DefaultTemplate != null &&
                    this.DefaultTemplate.Equals(input.DefaultTemplate))
                ) && 
                (
                    this.DeliveryEnabled == input.DeliveryEnabled ||
                    (this.DeliveryEnabled != null &&
                    this.DeliveryEnabled.Equals(input.DeliveryEnabled))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LinkedSpaceId == input.LinkedSpaceId ||
                    (this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(input.LinkedSpaceId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PlannedPurgeDate == input.PlannedPurgeDate ||
                    (this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(input.PlannedPurgeDate))
                ) && 
                (
                    this.SpaceId == input.SpaceId ||
                    (this.SpaceId != null &&
                    this.SpaceId.Equals(input.SpaceId))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.TemplateResource == input.TemplateResource ||
                    (this.TemplateResource != null &&
                    this.TemplateResource.Equals(input.TemplateResource))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.DefaultTemplate != null)
                    hashCode = hashCode * 59 + this.DefaultTemplate.GetHashCode();
                if (this.DeliveryEnabled != null)
                    hashCode = hashCode * 59 + this.DeliveryEnabled.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.SpaceId != null)
                    hashCode = hashCode * 59 + this.SpaceId.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.TemplateResource != null)
                    hashCode = hashCode * 59 + this.TemplateResource.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
