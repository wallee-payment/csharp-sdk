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
    /// PaymentTerminalDeviceModel
    /// </summary>
    [DataContract]
    public partial class PaymentTerminalDeviceModel :  IEquatable<PaymentTerminalDeviceModel>
    {
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public CreationEntityState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTerminalDeviceModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentTerminalDeviceModel()
        {
        }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public DatabaseTranslatedString Description { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public List<byte[]> Image { get; private set; }

        /// <summary>
        /// Gets or Sets ImageType
        /// </summary>
        [DataMember(Name="imageType", EmitDefaultValue=false)]
        public string ImageType { get; private set; }

        /// <summary>
        /// Gets or Sets Manufacturer
        /// </summary>
        [DataMember(Name="manufacturer", EmitDefaultValue=false)]
        public PaymentTerminalDeviceManufacturer Manufacturer { get; private set; }

        /// <summary>
        /// The model identifier of the device. The model identifier can be a number (e.g. a part number) or a name of the device model.
        /// </summary>
        /// <value>The model identifier of the device. The model identifier can be a number (e.g. a part number) or a name of the device model.</value>
        [DataMember(Name="modelId", EmitDefaultValue=false)]
        public string ModelId { get; private set; }

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
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public Scope Scope { get; private set; }


        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public DatabaseTranslatedString Title { get; private set; }

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
            sb.Append("class PaymentTerminalDeviceModel {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  ImageType: ").Append(ImageType).Append("\n");
            sb.Append("  Manufacturer: ").Append(Manufacturer).Append("\n");
            sb.Append("  ModelId: ").Append(ModelId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as PaymentTerminalDeviceModel);
        }

        /// <summary>
        /// Returns true if PaymentTerminalDeviceModel instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentTerminalDeviceModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentTerminalDeviceModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Image == input.Image ||
                    this.Image != null &&
                    this.Image.SequenceEqual(input.Image)
                ) && 
                (
                    this.ImageType == input.ImageType ||
                    (this.ImageType != null &&
                    this.ImageType.Equals(input.ImageType))
                ) && 
                (
                    this.Manufacturer == input.Manufacturer ||
                    (this.Manufacturer != null &&
                    this.Manufacturer.Equals(input.Manufacturer))
                ) && 
                (
                    this.ModelId == input.ModelId ||
                    (this.ModelId != null &&
                    this.ModelId.Equals(input.ModelId))
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
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.ImageType != null)
                    hashCode = hashCode * 59 + this.ImageType.GetHashCode();
                if (this.Manufacturer != null)
                    hashCode = hashCode * 59 + this.Manufacturer.GetHashCode();
                if (this.ModelId != null)
                    hashCode = hashCode * 59 + this.ModelId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
