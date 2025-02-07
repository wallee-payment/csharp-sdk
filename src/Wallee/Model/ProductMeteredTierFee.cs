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
    /// ProductMeteredTierFee
    /// </summary>
    [DataContract]
    public partial class ProductMeteredTierFee :  IEquatable<ProductMeteredTierFee>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductMeteredTierFee" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ProductMeteredTierFee()
        {
        }

        /// <summary>
        /// The amount charged to the customer for each consumed unit at the end of a billing cycle.
        /// </summary>
        /// <value>The amount charged to the customer for each consumed unit at the end of a billing cycle.</value>
        [DataMember(Name="fee", EmitDefaultValue=false)]
        public List<PersistableCurrencyAmount> Fee { get; private set; }

        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The metered fee that this tier belongs to.
        /// </summary>
        /// <value>The metered fee that this tier belongs to.</value>
        [DataMember(Name="meteredFee", EmitDefaultValue=false)]
        public ProductMeteredFee MeteredFee { get; private set; }

        /// <summary>
        /// Starting from and including this quantity is contained in the tier.
        /// </summary>
        /// <value>Starting from and including this quantity is contained in the tier.</value>
        [DataMember(Name="startRange", EmitDefaultValue=false)]
        public decimal? StartRange { get; private set; }

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
            sb.Append("class ProductMeteredTierFee {\n");
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
            return this.Equals(input as ProductMeteredTierFee);
        }

        /// <summary>
        /// Returns true if ProductMeteredTierFee instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductMeteredTierFee to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductMeteredTierFee input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Fee == input.Fee ||
                    this.Fee != null &&
                    input.Fee != null &&
                    this.Fee.SequenceEqual(input.Fee)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.Fee != null)
                    hashCode = hashCode * 59 + this.Fee.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.MeteredFee != null)
                    hashCode = hashCode * 59 + this.MeteredFee.GetHashCode();
                if (this.StartRange != null)
                    hashCode = hashCode * 59 + this.StartRange.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
