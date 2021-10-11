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
    /// SubscriptionProductVersionRetirement
    /// </summary>
    [DataContract]
    public partial class SubscriptionProductVersionRetirement :  IEquatable<SubscriptionProductVersionRetirement>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductVersionRetirement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public SubscriptionProductVersionRetirement()
        {
        }

        /// <summary>
        /// The created on date indicates the date on which the entity was stored into the database.
        /// </summary>
        /// <value>The created on date indicates the date on which the entity was stored into the database.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=true)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; private set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=true)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// Gets or Sets ProductVersion
        /// </summary>
        [DataMember(Name="productVersion", EmitDefaultValue=true)]
        public SubscriptionProductVersion ProductVersion { get; private set; }

        /// <summary>
        /// Gets or Sets RespectTerminiationPeriodsEnabled
        /// </summary>
        [DataMember(Name="respectTerminiationPeriodsEnabled", EmitDefaultValue=true)]
        public bool? RespectTerminiationPeriodsEnabled { get; private set; }

        /// <summary>
        /// When a target product is not chosen, all customers with the retired product will be terminated.
        /// </summary>
        /// <value>When a target product is not chosen, all customers with the retired product will be terminated.</value>
        [DataMember(Name="targetProduct", EmitDefaultValue=true)]
        public SubscriptionProduct TargetProduct { get; private set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public int? Version { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionProductVersionRetirement {\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  ProductVersion: ").Append(ProductVersion).Append("\n");
            sb.Append("  RespectTerminiationPeriodsEnabled: ").Append(RespectTerminiationPeriodsEnabled).Append("\n");
            sb.Append("  TargetProduct: ").Append(TargetProduct).Append("\n");
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
            return this.Equals(input as SubscriptionProductVersionRetirement);
        }

        /// <summary>
        /// Returns true if SubscriptionProductVersionRetirement instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionProductVersionRetirement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionProductVersionRetirement input)
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
                    this.ProductVersion == input.ProductVersion ||
                    (this.ProductVersion != null &&
                    this.ProductVersion.Equals(input.ProductVersion))
                ) && 
                (
                    this.RespectTerminiationPeriodsEnabled == input.RespectTerminiationPeriodsEnabled ||
                    (this.RespectTerminiationPeriodsEnabled != null &&
                    this.RespectTerminiationPeriodsEnabled.Equals(input.RespectTerminiationPeriodsEnabled))
                ) && 
                (
                    this.TargetProduct == input.TargetProduct ||
                    (this.TargetProduct != null &&
                    this.TargetProduct.Equals(input.TargetProduct))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.ProductVersion != null)
                    hashCode = hashCode * 59 + this.ProductVersion.GetHashCode();
                if (this.RespectTerminiationPeriodsEnabled != null)
                    hashCode = hashCode * 59 + this.RespectTerminiationPeriodsEnabled.GetHashCode();
                if (this.TargetProduct != null)
                    hashCode = hashCode * 59 + this.TargetProduct.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
