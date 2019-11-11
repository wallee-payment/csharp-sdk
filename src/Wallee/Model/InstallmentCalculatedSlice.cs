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
    /// InstallmentCalculatedSlice
    /// </summary>
    [DataContract]
    public partial class InstallmentCalculatedSlice :  IEquatable<InstallmentCalculatedSlice>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstallmentCalculatedSlice" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public InstallmentCalculatedSlice()
        {
        }

        /// <summary>
        /// Gets or Sets AmountIncludingTax
        /// </summary>
        [DataMember(Name="amountIncludingTax", EmitDefaultValue=false)]
        public decimal? AmountIncludingTax { get; private set; }

        /// <summary>
        /// Gets or Sets DueOn
        /// </summary>
        [DataMember(Name="dueOn", EmitDefaultValue=false)]
        public DateTime? DueOn { get; private set; }

        /// <summary>
        /// Gets or Sets LineItems
        /// </summary>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<LineItem> LineItems { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstallmentCalculatedSlice {\n");
            sb.Append("  AmountIncludingTax: ").Append(AmountIncludingTax).Append("\n");
            sb.Append("  DueOn: ").Append(DueOn).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
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
            return this.Equals(input as InstallmentCalculatedSlice);
        }

        /// <summary>
        /// Returns true if InstallmentCalculatedSlice instances are equal
        /// </summary>
        /// <param name="input">Instance of InstallmentCalculatedSlice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstallmentCalculatedSlice input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AmountIncludingTax == input.AmountIncludingTax ||
                    (this.AmountIncludingTax != null &&
                    this.AmountIncludingTax.Equals(input.AmountIncludingTax))
                ) && 
                (
                    this.DueOn == input.DueOn ||
                    (this.DueOn != null &&
                    this.DueOn.Equals(input.DueOn))
                ) && 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
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
                if (this.AmountIncludingTax != null)
                    hashCode = hashCode * 59 + this.AmountIncludingTax.GetHashCode();
                if (this.DueOn != null)
                    hashCode = hashCode * 59 + this.DueOn.GetHashCode();
                if (this.LineItems != null)
                    hashCode = hashCode * 59 + this.LineItems.GetHashCode();
                return hashCode;
            }
        }

    }

}
