
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
    /// LineItemReductionCreate model.
    /// </summary>
    [DataContract]
    public partial class LineItemReductionCreate :  IEquatable<LineItemReductionCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LineItemReductionCreate" /> class.
        /// </summary>
        /// <param name="LineItemUniqueId">The unique id identifies the line item on which the reduction is applied on.</param>
        /// <param name="QuantityReduction">QuantityReduction</param>
        /// <param name="UnitPriceReduction">UnitPriceReduction</param>
        public LineItemReductionCreate(string LineItemUniqueId = default(string), decimal? QuantityReduction = default(decimal?), decimal? UnitPriceReduction = default(decimal?))
        {
            this.LineItemUniqueId = LineItemUniqueId;
            this.QuantityReduction = QuantityReduction;
            this.UnitPriceReduction = UnitPriceReduction;
        }

        /// <summary>
        /// The unique id identifies the line item on which the reduction is applied on.
        /// </summary>
        /// <value>The unique id identifies the line item on which the reduction is applied on.</value>
        [DataMember(Name="lineItemUniqueId", EmitDefaultValue=false)]
        public string LineItemUniqueId { get; set; }

        /// <summary>
        /// QuantityReduction
        /// </summary>
        /// <value>QuantityReduction</value>
        [DataMember(Name="quantityReduction", EmitDefaultValue=false)]
        public decimal? QuantityReduction { get; set; }

        /// <summary>
        /// UnitPriceReduction
        /// </summary>
        /// <value>UnitPriceReduction</value>
        [DataMember(Name="unitPriceReduction", EmitDefaultValue=false)]
        public decimal? UnitPriceReduction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LineItemReductionCreate {\n");
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
            return this.Equals(obj as LineItemReductionCreate);
        }

        /// <summary>
        /// Returns true if LineItemReductionCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of LineItemReductionCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LineItemReductionCreate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.LineItemUniqueId == other.LineItemUniqueId ||
                    this.LineItemUniqueId != null &&
                    this.LineItemUniqueId.Equals(other.LineItemUniqueId)
                ) && 
                (
                    this.QuantityReduction == other.QuantityReduction ||
                    this.QuantityReduction != null &&
                    this.QuantityReduction.Equals(other.QuantityReduction)
                ) && 
                (
                    this.UnitPriceReduction == other.UnitPriceReduction ||
                    this.UnitPriceReduction != null &&
                    this.UnitPriceReduction.Equals(other.UnitPriceReduction)
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
                if (this.LineItemUniqueId != null)
                    hash = hash * 59 + this.LineItemUniqueId.GetHashCode();
                if (this.QuantityReduction != null)
                    hash = hash * 59 + this.QuantityReduction.GetHashCode();
                if (this.UnitPriceReduction != null)
                    hash = hash * 59 + this.UnitPriceReduction.GetHashCode();
                return hash;
            }
        }

    }

}
