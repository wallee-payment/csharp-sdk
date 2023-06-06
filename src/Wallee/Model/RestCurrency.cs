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
        /// The currency&#39;s three-letter code (ISO 4217 format).
        /// </summary>
        /// <value>The currency&#39;s three-letter code (ISO 4217 format).</value>
        [DataMember(Name="currencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; private set; }

        /// <summary>
        /// The currency&#39;s number of decimals. When calculating amounts in this currency, the fraction digits determine the accuracy.
        /// </summary>
        /// <value>The currency&#39;s number of decimals. When calculating amounts in this currency, the fraction digits determine the accuracy.</value>
        [DataMember(Name="fractionDigits", EmitDefaultValue=false)]
        public int? FractionDigits { get; private set; }

        /// <summary>
        /// The name of the currency.
        /// </summary>
        /// <value>The name of the currency.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// The currency&#39;s three-digit code (ISO 4217 format).
        /// </summary>
        /// <value>The currency&#39;s three-digit code (ISO 4217 format).</value>
        [DataMember(Name="numericCode", EmitDefaultValue=false)]
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
            sb.Append("  Name: ").Append(Name).Append("\n");
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NumericCode != null)
                    hashCode = hashCode * 59 + this.NumericCode.GetHashCode();
                return hashCode;
            }
        }

    }

}
