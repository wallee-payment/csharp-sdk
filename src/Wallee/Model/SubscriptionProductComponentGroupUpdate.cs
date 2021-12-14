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
    /// SubscriptionProductComponentGroupUpdate
    /// </summary>
    [DataContract]
    public partial class SubscriptionProductComponentGroupUpdate :  IEquatable<SubscriptionProductComponentGroupUpdate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductComponentGroupUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionProductComponentGroupUpdate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductComponentGroupUpdate" /> class.
        /// </summary>
        /// <param name="id">The ID is the primary key of the entity. The ID identifies the entity uniquely. (required).</param>
        /// <param name="version">The version number indicates the version of the entity. The version is incremented whenever the entity is changed. (required).</param>
        public SubscriptionProductComponentGroupUpdate(long? id, long? version)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for SubscriptionProductComponentGroupUpdate and cannot be null");
            }
            this.Id = id;
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for SubscriptionProductComponentGroupUpdate and cannot be null");
            }
            this.Version = version;
        }

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
        public long? Version { get; set; }

        /// <summary>
        /// The component group name will be shown when the components are selected. This can be visible to the subscriber.
        /// </summary>
        /// <value>The component group name will be shown when the components are selected. This can be visible to the subscriber.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public DatabaseTranslatedStringCreate Name { get; set; }

        /// <summary>
        /// The component group can be optional. This means no component has to be selected by the subscriber.
        /// </summary>
        /// <value>The component group can be optional. This means no component has to be selected by the subscriber.</value>
        [DataMember(Name="optional", EmitDefaultValue=false)]
        public bool? Optional { get; set; }

        /// <summary>
        /// Gets or Sets ProductVersion
        /// </summary>
        [DataMember(Name="productVersion", EmitDefaultValue=false)]
        public long? ProductVersion { get; set; }

        /// <summary>
        /// The sort order controls in which order the component group is listed. The sort order is used to order the component groups in ascending order.
        /// </summary>
        /// <value>The sort order controls in which order the component group is listed. The sort order is used to order the component groups in ascending order.</value>
        [DataMember(Name="sortOrder", EmitDefaultValue=false)]
        public int? SortOrder { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionProductComponentGroupUpdate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Optional: ").Append(Optional).Append("\n");
            sb.Append("  ProductVersion: ").Append(ProductVersion).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
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
            return this.Equals(input as SubscriptionProductComponentGroupUpdate);
        }

        /// <summary>
        /// Returns true if SubscriptionProductComponentGroupUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionProductComponentGroupUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionProductComponentGroupUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Optional == input.Optional ||
                    (this.Optional != null &&
                    this.Optional.Equals(input.Optional))
                ) && 
                (
                    this.ProductVersion == input.ProductVersion ||
                    (this.ProductVersion != null &&
                    this.ProductVersion.Equals(input.ProductVersion))
                ) && 
                (
                    this.SortOrder == input.SortOrder ||
                    (this.SortOrder != null &&
                    this.SortOrder.Equals(input.SortOrder))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Optional != null)
                    hashCode = hashCode * 59 + this.Optional.GetHashCode();
                if (this.ProductVersion != null)
                    hashCode = hashCode * 59 + this.ProductVersion.GetHashCode();
                if (this.SortOrder != null)
                    hashCode = hashCode * 59 + this.SortOrder.GetHashCode();
                return hashCode;
            }
        }

    }

}
