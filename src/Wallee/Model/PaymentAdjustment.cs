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
    /// PaymentAdjustment
    /// </summary>
    [DataContract]
    public partial class PaymentAdjustment :  IEquatable<PaymentAdjustment>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentAdjustment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentAdjustment()
        {
        }

        /// <summary>
        /// Gets or Sets AmountExcludingTax
        /// </summary>
        [DataMember(Name="amountExcludingTax", EmitDefaultValue=false)]
        public decimal? AmountExcludingTax { get; private set; }

        /// <summary>
        /// The total amount of this adjustment including taxes.
        /// </summary>
        /// <value>The total amount of this adjustment including taxes.</value>
        [DataMember(Name="amountIncludingTax", EmitDefaultValue=false)]
        public decimal? AmountIncludingTax { get; private set; }

        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The rate in percentage is the rate on which the adjustment amount was calculated with.
        /// </summary>
        /// <value>The rate in percentage is the rate on which the adjustment amount was calculated with.</value>
        [DataMember(Name="rateInPercentage", EmitDefaultValue=false)]
        public decimal? RateInPercentage { get; private set; }

        /// <summary>
        /// Gets or Sets Tax
        /// </summary>
        [DataMember(Name="tax", EmitDefaultValue=false)]
        public Tax Tax { get; private set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public long? Type { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentAdjustment {\n");
            sb.Append("  AmountExcludingTax: ").Append(AmountExcludingTax).Append("\n");
            sb.Append("  AmountIncludingTax: ").Append(AmountIncludingTax).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RateInPercentage: ").Append(RateInPercentage).Append("\n");
            sb.Append("  Tax: ").Append(Tax).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as PaymentAdjustment);
        }

        /// <summary>
        /// Returns true if PaymentAdjustment instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentAdjustment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentAdjustment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AmountExcludingTax == input.AmountExcludingTax ||
                    (this.AmountExcludingTax != null &&
                    this.AmountExcludingTax.Equals(input.AmountExcludingTax))
                ) && 
                (
                    this.AmountIncludingTax == input.AmountIncludingTax ||
                    (this.AmountIncludingTax != null &&
                    this.AmountIncludingTax.Equals(input.AmountIncludingTax))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.RateInPercentage == input.RateInPercentage ||
                    (this.RateInPercentage != null &&
                    this.RateInPercentage.Equals(input.RateInPercentage))
                ) && 
                (
                    this.Tax == input.Tax ||
                    (this.Tax != null &&
                    this.Tax.Equals(input.Tax))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.AmountExcludingTax != null)
                    hashCode = hashCode * 59 + this.AmountExcludingTax.GetHashCode();
                if (this.AmountIncludingTax != null)
                    hashCode = hashCode * 59 + this.AmountIncludingTax.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.RateInPercentage != null)
                    hashCode = hashCode * 59 + this.RateInPercentage.GetHashCode();
                if (this.Tax != null)
                    hashCode = hashCode * 59 + this.Tax.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}
