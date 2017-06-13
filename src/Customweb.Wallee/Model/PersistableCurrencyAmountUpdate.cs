
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
    /// PersistableCurrencyAmountUpdate model.
    /// </summary>
    [DataContract]
    public partial class PersistableCurrencyAmountUpdate :  IEquatable<PersistableCurrencyAmountUpdate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersistableCurrencyAmountUpdate" /> class.
        /// </summary>
        /// <param name="Amount">Amount</param>
        /// <param name="Currency">Currency</param>
        public PersistableCurrencyAmountUpdate(decimal? Amount = default(decimal?), string Currency = default(string))
        {
            this.Amount = Amount;
            this.Currency = Currency;
        }

        /// <summary>
        /// Amount
        /// </summary>
        /// <value>Amount</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Currency
        /// </summary>
        /// <value>Currency</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PersistableCurrencyAmountUpdate {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
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
            return this.Equals(obj as PersistableCurrencyAmountUpdate);
        }

        /// <summary>
        /// Returns true if PersistableCurrencyAmountUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of PersistableCurrencyAmountUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PersistableCurrencyAmountUpdate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
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
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                return hash;
            }
        }

    }

}
