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
    /// ProductMeteredTierFeeUpdate
    /// </summary>
    [DataContract]
    public partial class ProductMeteredTierFeeUpdate :  IEquatable<ProductMeteredTierFeeUpdate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductMeteredTierFeeUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProductMeteredTierFeeUpdate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductMeteredTierFeeUpdate" /> class.
        /// </summary>
        /// <param name="id">The ID is the primary key of the entity. The ID identifies the entity uniquely. (required).</param>
        /// <param name="version">The version number indicates the version of the entity. The version is incremented whenever the entity is changed. (required).</param>
        public ProductMeteredTierFeeUpdate(long? id, long? version)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for ProductMeteredTierFeeUpdate and cannot be null");
            }
            this.Id = id;
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for ProductMeteredTierFeeUpdate and cannot be null");
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
        /// The fee determines the amount which is charged. The consumed metric is multiplied by the defined fee. The resulting amount is charged at the end of the period.
        /// </summary>
        /// <value>The fee determines the amount which is charged. The consumed metric is multiplied by the defined fee. The resulting amount is charged at the end of the period.</value>
        [DataMember(Name="fee", EmitDefaultValue=false)]
        public List<PersistableCurrencyAmountUpdate> Fee { get; set; }

        /// <summary>
        /// Gets or Sets MeteredFee
        /// </summary>
        [DataMember(Name="meteredFee", EmitDefaultValue=false)]
        public long? MeteredFee { get; set; }

        /// <summary>
        /// The start range defines the metered consumption of the metric from which on the defined fee gets applied. This means when a subscription consumes a value of 10 or more and the start range is set to 10 the fee defined on the tier will be applied.
        /// </summary>
        /// <value>The start range defines the metered consumption of the metric from which on the defined fee gets applied. This means when a subscription consumes a value of 10 or more and the start range is set to 10 the fee defined on the tier will be applied.</value>
        [DataMember(Name="startRange", EmitDefaultValue=false)]
        public decimal? StartRange { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductMeteredTierFeeUpdate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  MeteredFee: ").Append(MeteredFee).Append("\n");
            sb.Append("  StartRange: ").Append(StartRange).Append("\n");
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
            return this.Equals(input as ProductMeteredTierFeeUpdate);
        }

        /// <summary>
        /// Returns true if ProductMeteredTierFeeUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductMeteredTierFeeUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductMeteredTierFeeUpdate input)
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
                    this.Fee == input.Fee ||
                    this.Fee != null &&
                    input.Fee != null &&
                    this.Fee.SequenceEqual(input.Fee)
                ) && 
                (
                    this.MeteredFee == input.MeteredFee ||
                    (this.MeteredFee != null &&
                    this.MeteredFee.Equals(input.MeteredFee))
                ) && 
                (
                    this.StartRange == input.StartRange ||
                    (this.StartRange != null &&
                    this.StartRange.Equals(input.StartRange))
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
                if (this.Fee != null)
                    hashCode = hashCode * 59 + this.Fee.GetHashCode();
                if (this.MeteredFee != null)
                    hashCode = hashCode * 59 + this.MeteredFee.GetHashCode();
                if (this.StartRange != null)
                    hashCode = hashCode * 59 + this.StartRange.GetHashCode();
                return hashCode;
            }
        }

    }

}
