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
    /// Debt Collection Case Document
    /// </summary>
    [DataContract]
    public partial class DebtCollectionCaseDocument :  IEquatable<DebtCollectionCaseDocument>, IValidatableObject
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
        /// DebtCollectionCase
        /// </summary>
        /// <value>DebtCollectionCase</value>
        [DataMember(Name="debtCollectionCase", EmitDefaultValue=false)]
        public long? DebtCollectionCase { get; private set; }

        /// <summary>
        /// FileName
        /// </summary>
        /// <value>FileName</value>
        [DataMember(Name="fileName", EmitDefaultValue=false)]
        public string FileName { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// Labels
        /// </summary>
        /// <value>Labels</value>
        [DataMember(Name="labels", EmitDefaultValue=false)]
        public List<Label> Labels { get; private set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// MimeType
        /// </summary>
        /// <value>MimeType</value>
        [DataMember(Name="mimeType", EmitDefaultValue=false)]
        public string MimeType { get; private set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// StorageId
        /// </summary>
        /// <value>StorageId</value>
        [DataMember(Name="storageId", EmitDefaultValue=false)]
        public string StorageId { get; private set; }

        /// <summary>
        /// UniqueId
        /// </summary>
        /// <value>UniqueId</value>
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
            return this.Equals(obj as DebtCollectionCaseDocument);
        }

        /// <summary>
        /// Returns true if DebtCollectionCaseDocument instances are equal
        /// </summary>
        /// <param name="other">Instance of DebtCollectionCaseDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DebtCollectionCaseDocument other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.CreatedOn == other.CreatedOn ||
                    this.CreatedOn != null &&
                    this.CreatedOn.Equals(other.CreatedOn)
                ) && 
                (
                    this.DebtCollectionCase == other.DebtCollectionCase ||
                    this.DebtCollectionCase != null &&
                    this.DebtCollectionCase.Equals(other.DebtCollectionCase)
                ) && 
                (
                    this.FileName == other.FileName ||
                    this.FileName != null &&
                    this.FileName.Equals(other.FileName)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Labels == other.Labels ||
                    this.Labels != null &&
                    this.Labels.SequenceEqual(other.Labels)
                ) && 
                (
                    this.LinkedSpaceId == other.LinkedSpaceId ||
                    this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(other.LinkedSpaceId)
                ) && 
                (
                    this.MimeType == other.MimeType ||
                    this.MimeType != null &&
                    this.MimeType.Equals(other.MimeType)
                ) && 
                (
                    this.PlannedPurgeDate == other.PlannedPurgeDate ||
                    this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(other.PlannedPurgeDate)
                ) && 
                (
                    this.StorageId == other.StorageId ||
                    this.StorageId != null &&
                    this.StorageId.Equals(other.StorageId)
                ) && 
                (
                    this.UniqueId == other.UniqueId ||
                    this.UniqueId != null &&
                    this.UniqueId.Equals(other.UniqueId)
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
                if (this.CreatedOn != null)
                {
                    hash = hash * 59 + this.CreatedOn.GetHashCode();
                }
                if (this.DebtCollectionCase != null)
                {
                    hash = hash * 59 + this.DebtCollectionCase.GetHashCode();
                }
                if (this.FileName != null)
                {
                    hash = hash * 59 + this.FileName.GetHashCode();
                }
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.Labels != null)
                {
                    hash = hash * 59 + this.Labels.GetHashCode();
                }
                if (this.LinkedSpaceId != null)
                {
                    hash = hash * 59 + this.LinkedSpaceId.GetHashCode();
                }
                if (this.MimeType != null)
                {
                    hash = hash * 59 + this.MimeType.GetHashCode();
                }
                if (this.PlannedPurgeDate != null)
                {
                    hash = hash * 59 + this.PlannedPurgeDate.GetHashCode();
                }
                if (this.StorageId != null)
                {
                    hash = hash * 59 + this.StorageId.GetHashCode();
                }
                if (this.UniqueId != null)
                {
                    hash = hash * 59 + this.UniqueId.GetHashCode();
                }
                if (this.Version != null)
                {
                    hash = hash * 59 + this.Version.GetHashCode();
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
