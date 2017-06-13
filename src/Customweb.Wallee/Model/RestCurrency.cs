
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
    /// RestCurrency model.
    /// </summary>
    [DataContract]
    public partial class RestCurrency :  IEquatable<RestCurrency>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestCurrency" /> class.
        /// </summary>
        /// <param name="CurrencyCode">The currency code identifies the currency with the three char long ISO 4217 code (e.g. USD, CHF, EUR).</param>
        /// <param name="FractionDigits">The fraction digits indicates how many places the currency has. This also indicates with which precision we calculate internally when we do calculations with this currency.</param>
        /// <param name="NumericCode">The numeric code identifies the currency with the three digit long ISO 4217 code (e.g. 978, 756, 840).</param>
        public RestCurrency(string CurrencyCode = default(string), int? FractionDigits = default(int?), int? NumericCode = default(int?))
        {
            this.CurrencyCode = CurrencyCode;
            this.FractionDigits = FractionDigits;
            this.NumericCode = NumericCode;
        }

        /// <summary>
        /// The currency code identifies the currency with the three char long ISO 4217 code (e.g. USD, CHF, EUR).
        /// </summary>
        /// <value>The currency code identifies the currency with the three char long ISO 4217 code (e.g. USD, CHF, EUR).</value>
        [DataMember(Name="currencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// The fraction digits indicates how many places the currency has. This also indicates with which precision we calculate internally when we do calculations with this currency.
        /// </summary>
        /// <value>The fraction digits indicates how many places the currency has. This also indicates with which precision we calculate internally when we do calculations with this currency.</value>
        [DataMember(Name="fractionDigits", EmitDefaultValue=false)]
        public int? FractionDigits { get; set; }

        /// <summary>
        /// The numeric code identifies the currency with the three digit long ISO 4217 code (e.g. 978, 756, 840).
        /// </summary>
        /// <value>The numeric code identifies the currency with the three digit long ISO 4217 code (e.g. 978, 756, 840).</value>
        [DataMember(Name="numericCode", EmitDefaultValue=false)]
        public int? NumericCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestCurrency {\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  FractionDigits: ").Append(FractionDigits).Append("\n");
            sb.Append("  NumericCode: ").Append(NumericCode).Append("\n");
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
            return this.Equals(obj as RestCurrency);
        }

        /// <summary>
        /// Returns true if RestCurrency instances are equal
        /// </summary>
        /// <param name="other">Instance of RestCurrency to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestCurrency other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.CurrencyCode == other.CurrencyCode ||
                    this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(other.CurrencyCode)
                ) && 
                (
                    this.FractionDigits == other.FractionDigits ||
                    this.FractionDigits != null &&
                    this.FractionDigits.Equals(other.FractionDigits)
                ) && 
                (
                    this.NumericCode == other.NumericCode ||
                    this.NumericCode != null &&
                    this.NumericCode.Equals(other.NumericCode)
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
                if (this.CurrencyCode != null)
                    hash = hash * 59 + this.CurrencyCode.GetHashCode();
                if (this.FractionDigits != null)
                    hash = hash * 59 + this.FractionDigits.GetHashCode();
                if (this.NumericCode != null)
                    hash = hash * 59 + this.NumericCode.GetHashCode();
                return hash;
            }
        }

    }

}
