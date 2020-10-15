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
    /// RestCurrency
    /// </summary>
    [DataContract]
    public partial class RestCurrency :  IEquatable<RestCurrency>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestCurrency" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public RestCurrency()
        {
        }

        /// <summary>
        /// The currency code identifies the currency with the three char long ISO 4217 code (e.g. USD, CHF, EUR).
        /// </summary>
        /// <value>The currency code identifies the currency with the three char long ISO 4217 code (e.g. USD, CHF, EUR).</value>
        [DataMember(Name="currencyCode", EmitDefaultValue=true)]
        public string CurrencyCode { get; private set; }

        /// <summary>
        /// The fraction digits indicates how many places the currency has. This also indicates with which precision we calculate internally when we do calculations with this currency.
        /// </summary>
        /// <value>The fraction digits indicates how many places the currency has. This also indicates with which precision we calculate internally when we do calculations with this currency.</value>
        [DataMember(Name="fractionDigits", EmitDefaultValue=true)]
        public int? FractionDigits { get; private set; }

        /// <summary>
        /// The numeric code identifies the currency with the three digit long ISO 4217 code (e.g. 978, 756, 840).
        /// </summary>
        /// <value>The numeric code identifies the currency with the three digit long ISO 4217 code (e.g. 978, 756, 840).</value>
        [DataMember(Name="numericCode", EmitDefaultValue=true)]
        public int? NumericCode { get; private set; }

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
            return this.Equals(input as RestCurrency);
        }

        /// <summary>
        /// Returns true if RestCurrency instances are equal
        /// </summary>
        /// <param name="input">Instance of RestCurrency to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestCurrency input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.FractionDigits == input.FractionDigits ||
                    (this.FractionDigits != null &&
                    this.FractionDigits.Equals(input.FractionDigits))
                ) && 
                (
                    this.NumericCode == input.NumericCode ||
                    (this.NumericCode != null &&
                    this.NumericCode.Equals(input.NumericCode))
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
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.FractionDigits != null)
                    hashCode = hashCode * 59 + this.FractionDigits.GetHashCode();
                if (this.NumericCode != null)
                    hashCode = hashCode * 59 + this.NumericCode.GetHashCode();
                return hashCode;
            }
        }

    }

}
