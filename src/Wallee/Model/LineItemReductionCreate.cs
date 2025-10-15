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
    /// LineItemReductionCreate
    /// </summary>
    [DataContract]
    public partial class LineItemReductionCreate :  IEquatable<LineItemReductionCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LineItemReductionCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LineItemReductionCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LineItemReductionCreate" /> class.
        /// </summary>
        /// <param name="lineItemUniqueId">The unique identifier of the line item to which the reduction is applied. This ID ensures the reduction is accurately associated with the correct item. (required).</param>
        /// <param name="quantityReduction">The quantity removed or reduced from the line item. This value reflects the decrease in the item count due to the reduction. (required).</param>
        /// <param name="unitPriceReduction">The monetary amount by which the line item&#39;s unit price is discounted. This reduction adjusts the price without altering the quantity. (required).</param>
        public LineItemReductionCreate(string lineItemUniqueId, decimal? quantityReduction, decimal? unitPriceReduction)
        {
            // to ensure "lineItemUniqueId" is required (not null)
            if (lineItemUniqueId == null)
            {
                throw new InvalidDataException("lineItemUniqueId is a required property for LineItemReductionCreate and cannot be null");
            }
            this.LineItemUniqueId = lineItemUniqueId;
            // to ensure "quantityReduction" is required (not null)
            if (quantityReduction == null)
            {
                throw new InvalidDataException("quantityReduction is a required property for LineItemReductionCreate and cannot be null");
            }
            this.QuantityReduction = quantityReduction;
            // to ensure "unitPriceReduction" is required (not null)
            if (unitPriceReduction == null)
            {
                throw new InvalidDataException("unitPriceReduction is a required property for LineItemReductionCreate and cannot be null");
            }
            this.UnitPriceReduction = unitPriceReduction;
        }

        /// <summary>
        /// The unique identifier of the line item to which the reduction is applied. This ID ensures the reduction is accurately associated with the correct item.
        /// </summary>
        /// <value>The unique identifier of the line item to which the reduction is applied. This ID ensures the reduction is accurately associated with the correct item.</value>
        [DataMember(Name="lineItemUniqueId", EmitDefaultValue=false)]
        public string LineItemUniqueId { get; set; }

        /// <summary>
        /// The quantity removed or reduced from the line item. This value reflects the decrease in the item count due to the reduction.
        /// </summary>
        /// <value>The quantity removed or reduced from the line item. This value reflects the decrease in the item count due to the reduction.</value>
        [DataMember(Name="quantityReduction", EmitDefaultValue=false)]
        public decimal? QuantityReduction { get; set; }

        /// <summary>
        /// The monetary amount by which the line item&#39;s unit price is discounted. This reduction adjusts the price without altering the quantity.
        /// </summary>
        /// <value>The monetary amount by which the line item&#39;s unit price is discounted. This reduction adjusts the price without altering the quantity.</value>
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
            return this.Equals(input as LineItemReductionCreate);
        }

        /// <summary>
        /// Returns true if LineItemReductionCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of LineItemReductionCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LineItemReductionCreate input)
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
