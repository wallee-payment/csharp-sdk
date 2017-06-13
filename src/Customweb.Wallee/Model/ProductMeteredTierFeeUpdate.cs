
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
    /// ProductMeteredTierFeeUpdate model.
    /// </summary>
    [DataContract]
    public partial class ProductMeteredTierFeeUpdate :  IEquatable<ProductMeteredTierFeeUpdate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductMeteredTierFeeUpdate" /> class.
        /// </summary>
        /// <param name="Fee">The fee determines the amount which is charged. The consumed metric is multiplied by the defined fee. The resulting amount is charged at the end of the period.</param>
        /// <param name="Id">The ID is the primary key of the entity. The ID identifies the entity uniquely.</param>
        /// <param name="MeteredFee">MeteredFee</param>
        /// <param name="StartRange">The start range defines the metered consumption of the metric from which on the defined fee gets applied. This means when a subscription consumes a value of 10 or more and the start range is set to 10 the fee defined on the tier will be applied.</param>
        /// <param name="Version">The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</param>
        public ProductMeteredTierFeeUpdate(List<PersistableCurrencyAmountUpdate> Fee = default(List<PersistableCurrencyAmountUpdate>), long? Id = default(long?), long? MeteredFee = default(long?), decimal? StartRange = default(decimal?), long? Version = default(long?))
        {
            this.Fee = Fee;
            this.Id = Id;
            this.MeteredFee = MeteredFee;
            this.StartRange = StartRange;
            this.Version = Version;
        }

        /// <summary>
        /// The fee determines the amount which is charged. The consumed metric is multiplied by the defined fee. The resulting amount is charged at the end of the period.
        /// </summary>
        /// <value>The fee determines the amount which is charged. The consumed metric is multiplied by the defined fee. The resulting amount is charged at the end of the period.</value>
        [DataMember(Name="fee", EmitDefaultValue=false)]
        public List<PersistableCurrencyAmountUpdate> Fee { get; set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// MeteredFee
        /// </summary>
        /// <value>MeteredFee</value>
        [DataMember(Name="meteredFee", EmitDefaultValue=false)]
        public long? MeteredFee { get; set; }

        /// <summary>
        /// The start range defines the metered consumption of the metric from which on the defined fee gets applied. This means when a subscription consumes a value of 10 or more and the start range is set to 10 the fee defined on the tier will be applied.
        /// </summary>
        /// <value>The start range defines the metered consumption of the metric from which on the defined fee gets applied. This means when a subscription consumes a value of 10 or more and the start range is set to 10 the fee defined on the tier will be applied.</value>
        [DataMember(Name="startRange", EmitDefaultValue=false)]
        public decimal? StartRange { get; set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public long? Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductMeteredTierFeeUpdate {\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MeteredFee: ").Append(MeteredFee).Append("\n");
            sb.Append("  StartRange: ").Append(StartRange).Append("\n");
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
            return this.Equals(obj as ProductMeteredTierFeeUpdate);
        }

        /// <summary>
        /// Returns true if ProductMeteredTierFeeUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductMeteredTierFeeUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductMeteredTierFeeUpdate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Fee == other.Fee ||
                    this.Fee != null &&
                    this.Fee.SequenceEqual(other.Fee)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.MeteredFee == other.MeteredFee ||
                    this.MeteredFee != null &&
                    this.MeteredFee.Equals(other.MeteredFee)
                ) && 
                (
                    this.StartRange == other.StartRange ||
                    this.StartRange != null &&
                    this.StartRange.Equals(other.StartRange)
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
                if (this.Fee != null)
                    hash = hash * 59 + this.Fee.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.MeteredFee != null)
                    hash = hash * 59 + this.MeteredFee.GetHashCode();
                if (this.StartRange != null)
                    hash = hash * 59 + this.StartRange.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                return hash;
            }
        }

    }

}
