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
    /// DebtCollectionCaseDocument
    /// </summary>
    [DataContract]
    public partial class DebtCollectionCaseDocument :  IEquatable<DebtCollectionCaseDocument>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DebtCollectionCaseDocument" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public DebtCollectionCaseDocument()
        {
        }

        /// <summary>
        /// The created on date indicates the date on which the entity was stored into the database.
        /// </summary>
        /// <value>The created on date indicates the date on which the entity was stored into the database.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// Gets or Sets DebtCollectionCase
        /// </summary>
        [DataMember(Name="debtCollectionCase", EmitDefaultValue=false)]
        public long? DebtCollectionCase { get; private set; }

        /// <summary>
        /// Gets or Sets FileName
        /// </summary>
        [DataMember(Name="fileName", EmitDefaultValue=false)]
        public string FileName { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// Gets or Sets Labels
        /// </summary>
        [DataMember(Name="labels", EmitDefaultValue=false)]
        public List<Label> Labels { get; private set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// Gets or Sets MimeType
        /// </summary>
        [DataMember(Name="mimeType", EmitDefaultValue=false)]
        public string MimeType { get; private set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// Gets or Sets StorageId
        /// </summary>
        [DataMember(Name="storageId", EmitDefaultValue=false)]
        public string StorageId { get; private set; }

        /// <summary>
        /// Gets or Sets UniqueId
        /// </summary>
        [DataMember(Name="uniqueId", EmitDefaultValue=false)]
        public string UniqueId { get; private set; }

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
            sb.Append("class DebtCollectionCaseDocument {\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  DebtCollectionCase: ").Append(DebtCollectionCase).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  MimeType: ").Append(MimeType).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  StorageId: ").Append(StorageId).Append("\n");
            sb.Append("  UniqueId: ").Append(UniqueId).Append("\n");
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
            return this.Equals(input as DebtCollectionCaseDocument);
        }

        /// <summary>
        /// Returns true if DebtCollectionCaseDocument instances are equal
        /// </summary>
        /// <param name="input">Instance of DebtCollectionCaseDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DebtCollectionCaseDocument input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && 
                (
                    this.DebtCollectionCase == input.DebtCollectionCase ||
                    (this.DebtCollectionCase != null &&
                    this.DebtCollectionCase.Equals(input.DebtCollectionCase))
                ) && 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Labels == input.Labels ||
                    this.Labels != null &&
                    this.Labels.SequenceEqual(input.Labels)
                ) && 
                (
                    this.LinkedSpaceId == input.LinkedSpaceId ||
                    (this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(input.LinkedSpaceId))
                ) && 
                (
                    this.MimeType == input.MimeType ||
                    (this.MimeType != null &&
                    this.MimeType.Equals(input.MimeType))
                ) && 
                (
                    this.PlannedPurgeDate == input.PlannedPurgeDate ||
                    (this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(input.PlannedPurgeDate))
                ) && 
                (
                    this.StorageId == input.StorageId ||
                    (this.StorageId != null &&
                    this.StorageId.Equals(input.StorageId))
                ) && 
                (
                    this.UniqueId == input.UniqueId ||
                    (this.UniqueId != null &&
                    this.UniqueId.Equals(input.UniqueId))
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
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.DebtCollectionCase != null)
                    hashCode = hashCode * 59 + this.DebtCollectionCase.GetHashCode();
                if (this.FileName != null)
                    hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Labels != null)
                    hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.MimeType != null)
                    hashCode = hashCode * 59 + this.MimeType.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.StorageId != null)
                    hashCode = hashCode * 59 + this.StorageId.GetHashCode();
                if (this.UniqueId != null)
                    hashCode = hashCode * 59 + this.UniqueId.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
