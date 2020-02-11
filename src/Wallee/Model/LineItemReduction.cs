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
    /// LineItemReduction
    /// </summary>
    [DataContract]
    public partial class LineItemReduction :  IEquatable<LineItemReduction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LineItemReduction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public LineItemReduction()
        {
        }

        /// <summary>
        /// The unique id identifies the line item on which the reduction is applied on.
        /// </summary>
        /// <value>The unique id identifies the line item on which the reduction is applied on.</value>
        [DataMember(Name="lineItemUniqueId", EmitDefaultValue=true)]
        public string LineItemUniqueId { get; private set; }

        /// <summary>
        /// Gets or Sets QuantityReduction
        /// </summary>
        [DataMember(Name="quantityReduction", EmitDefaultValue=true)]
        public decimal? QuantityReduction { get; private set; }

        /// <summary>
        /// Gets or Sets UnitPriceReduction
        /// </summary>
        [DataMember(Name="unitPriceReduction", EmitDefaultValue=true)]
        public decimal? UnitPriceReduction { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LineItemReduction {\n");
            sb.Append("  LineItemUniqueId: ").Append(LineItemUniqueId).Append("\n");
            sb.Append("  QuantityReduction: ").Append(QuantityReduction).Append("\n");
            sb.Append("  UnitPriceReduction: ").Append(UnitPriceReduction).Append("\n");
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
            return this.Equals(input as LineItemReduction);
        }

        /// <summary>
        /// Returns true if LineItemReduction instances are equal
        /// </summary>
        /// <param name="input">Instance of LineItemReduction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LineItemReduction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LineItemUniqueId == input.LineItemUniqueId ||
                    (this.LineItemUniqueId != null &&
                    this.LineItemUniqueId.Equals(input.LineItemUniqueId))
                ) && 
                (
                    this.QuantityReduction == input.QuantityReduction ||
                    (this.QuantityReduction != null &&
                    this.QuantityReduction.Equals(input.QuantityReduction))
                ) && 
                (
                    this.UnitPriceReduction == input.UnitPriceReduction ||
                    (this.UnitPriceReduction != null &&
                    this.UnitPriceReduction.Equals(input.UnitPriceReduction))
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
                if (this.LineItemUniqueId != null)
                    hashCode = hashCode * 59 + this.LineItemUniqueId.GetHashCode();
                if (this.QuantityReduction != null)
                    hashCode = hashCode * 59 + this.QuantityReduction.GetHashCode();
                if (this.UnitPriceReduction != null)
                    hashCode = hashCode * 59 + this.UnitPriceReduction.GetHashCode();
                return hashCode;
            }
        }

    }

}
