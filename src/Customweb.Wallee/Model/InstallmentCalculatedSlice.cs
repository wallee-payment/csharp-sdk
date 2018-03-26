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
    /// Installment Calculated Slice
    /// </summary>
    [DataContract]
    public partial class InstallmentCalculatedSlice :  IEquatable<InstallmentCalculatedSlice>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="InstallmentCalculatedSlice" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public InstallmentCalculatedSlice()
        {
        }

        /// <summary>
        /// AmountIncludingTax
        /// </summary>
        /// <value>AmountIncludingTax</value>
        [DataMember(Name="amountIncludingTax", EmitDefaultValue=false)]
        public decimal? AmountIncludingTax { get; private set; }

        /// <summary>
        /// DueOn
        /// </summary>
        /// <value>DueOn</value>
        [DataMember(Name="dueOn", EmitDefaultValue=false)]
        public DateTime? DueOn { get; private set; }

        /// <summary>
        /// LineItems
        /// </summary>
        /// <value>LineItems</value>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<LineItem> LineItems { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return this.ToJson();
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
                if (this.AmountIncludingTax != null)
                {
                    hash = hash * 59 + this.AmountIncludingTax.GetHashCode();
                }
                if (this.DueOn != null)
                {
                    hash = hash * 59 + this.DueOn.GetHashCode();
                }
                if (this.LineItems != null)
                {
                    hash = hash * 59 + this.LineItems.GetHashCode();
                }
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
