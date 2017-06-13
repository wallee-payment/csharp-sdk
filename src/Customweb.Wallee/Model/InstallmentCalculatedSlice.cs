
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
    /// InstallmentCalculatedSlice model.
    /// </summary>
    [DataContract]
    public partial class InstallmentCalculatedSlice :  IEquatable<InstallmentCalculatedSlice>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstallmentCalculatedSlice" /> class.
        /// </summary>
        /// <param name="AmountIncludingTax">AmountIncludingTax</param>
        /// <param name="DueOn">DueOn</param>
        /// <param name="LineItems">LineItems</param>
        public InstallmentCalculatedSlice(decimal? AmountIncludingTax = default(decimal?), DateTime? DueOn = default(DateTime?), List<LineItem> LineItems = default(List<LineItem>))
        {
            this.AmountIncludingTax = AmountIncludingTax;
            this.DueOn = DueOn;
            this.LineItems = LineItems;
        }

        /// <summary>
        /// AmountIncludingTax
        /// </summary>
        /// <value>AmountIncludingTax</value>
        [DataMember(Name="amountIncludingTax", EmitDefaultValue=false)]
        public decimal? AmountIncludingTax { get; set; }

        /// <summary>
        /// DueOn
        /// </summary>
        /// <value>DueOn</value>
        [DataMember(Name="dueOn", EmitDefaultValue=false)]
        public DateTime? DueOn { get; set; }

        /// <summary>
        /// LineItems
        /// </summary>
        /// <value>LineItems</value>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<LineItem> LineItems { get; set; }

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
            return this.Equals(obj as InstallmentCalculatedSlice);
        }

        /// <summary>
        /// Returns true if InstallmentCalculatedSlice instances are equal
        /// </summary>
        /// <param name="other">Instance of InstallmentCalculatedSlice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstallmentCalculatedSlice other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.AmountIncludingTax == other.AmountIncludingTax ||
                    this.AmountIncludingTax != null &&
                    this.AmountIncludingTax.Equals(other.AmountIncludingTax)
                ) && 
                (
                    this.DueOn == other.DueOn ||
                    this.DueOn != null &&
                    this.DueOn.Equals(other.DueOn)
                ) && 
                (
                    this.LineItems == other.LineItems ||
                    this.LineItems != null &&
                    this.LineItems.SequenceEqual(other.LineItems)
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
                if (this.AmountIncludingTax != null)
                    hash = hash * 59 + this.AmountIncludingTax.GetHashCode();
                if (this.DueOn != null)
                    hash = hash * 59 + this.DueOn.GetHashCode();
                if (this.LineItems != null)
                    hash = hash * 59 + this.LineItems.GetHashCode();
                return hash;
            }
        }

    }

}
