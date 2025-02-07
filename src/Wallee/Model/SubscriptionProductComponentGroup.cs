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
    /// SubscriptionProductComponentGroup
    /// </summary>
    [DataContract]
    public partial class SubscriptionProductComponentGroup :  IEquatable<SubscriptionProductComponentGroup>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductComponentGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public SubscriptionProductComponentGroup()
        {
        }

        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The ID of the space this object belongs to.
        /// </summary>
        /// <value>The ID of the space this object belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// The localized name of the component group that is displayed to the customer.
        /// </summary>
        /// <value>The localized name of the component group that is displayed to the customer.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public Dictionary<string, string> Name { get; private set; }

        /// <summary>
        /// Whether the component group is optional, i.e. the customer does not have to select any component.
        /// </summary>
        /// <value>Whether the component group is optional, i.e. the customer does not have to select any component.</value>
        [DataMember(Name="optional", EmitDefaultValue=false)]
        public bool? Optional { get; private set; }

        /// <summary>
        /// The product version that the component group belongs to.
        /// </summary>
        /// <value>The product version that the component group belongs to.</value>
        [DataMember(Name="productVersion", EmitDefaultValue=false)]
        public SubscriptionProductVersion ProductVersion { get; private set; }

        /// <summary>
        /// When listing component groups, they can be sorted by this number.
        /// </summary>
        /// <value>When listing component groups, they can be sorted by this number.</value>
        [DataMember(Name="sortOrder", EmitDefaultValue=false)]
        public int? SortOrder { get; private set; }

        /// <summary>
        /// The version is used for optimistic locking and incremented whenever the object is updated.
        /// </summary>
        /// <value>The version is used for optimistic locking and incremented whenever the object is updated.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionProductComponentGroup {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Optional: ").Append(Optional).Append("\n");
            sb.Append("  ProductVersion: ").Append(ProductVersion).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubscriptionProductComponentGroup);
        }

        /// <summary>
        /// Returns true if SubscriptionProductComponentGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionProductComponentGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionProductComponentGroup input)
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
                    this.LinkedSpaceId == input.LinkedSpaceId ||
                    (this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(input.LinkedSpaceId))
                ) && 
                (
                    this.Name == input.Name ||
                    this.Name != null &&
                    input.Name != null &&
                    this.Name.SequenceEqual(input.Name)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Optional != null)
                    hashCode = hashCode * 59 + this.Optional.GetHashCode();
                if (this.ProductVersion != null)
                    hashCode = hashCode * 59 + this.ProductVersion.GetHashCode();
                if (this.SortOrder != null)
                    hashCode = hashCode * 59 + this.SortOrder.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
