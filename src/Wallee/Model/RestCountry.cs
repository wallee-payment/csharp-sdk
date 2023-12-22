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
    /// RestCountry
    /// </summary>
    [DataContract]
    public partial class RestCountry :  IEquatable<RestCountry>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestCountry" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public RestCountry()
        {
        }

        /// <summary>
        /// Specifies the country&#39;s way of formatting addresses.
        /// </summary>
        /// <value>Specifies the country&#39;s way of formatting addresses.</value>
        [DataMember(Name="addressFormat", EmitDefaultValue=false)]
        public RestAddressFormat AddressFormat { get; private set; }

        /// <summary>
        /// The country&#39;s two-letter code (ISO 3166-1 alpha-2 format).
        /// </summary>
        /// <value>The country&#39;s two-letter code (ISO 3166-1 alpha-2 format).</value>
        [DataMember(Name="isoCode2", EmitDefaultValue=false)]
        public string IsoCode2 { get; private set; }

        /// <summary>
        /// The country&#39;s three-letter code (ISO 3166-1 alpha-3 format).
        /// </summary>
        /// <value>The country&#39;s three-letter code (ISO 3166-1 alpha-3 format).</value>
        [DataMember(Name="isoCode3", EmitDefaultValue=false)]
        public string IsoCode3 { get; private set; }

        /// <summary>
        /// The name of the country.
        /// </summary>
        /// <value>The name of the country.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// The country&#39;s three-digit code (ISO 3166-1 numeric format).
        /// </summary>
        /// <value>The country&#39;s three-digit code (ISO 3166-1 numeric format).</value>
        [DataMember(Name="numericCode", EmitDefaultValue=false)]
        public string NumericCode { get; private set; }

        /// <summary>
        /// The codes of all regions (e.g. states, provinces) of the country (ISO 3166-2 format).
        /// </summary>
        /// <value>The codes of all regions (e.g. states, provinces) of the country (ISO 3166-2 format).</value>
        [DataMember(Name="stateCodes", EmitDefaultValue=false)]
        public List<string> StateCodes { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestCountry {\n");
            sb.Append("  AddressFormat: ").Append(AddressFormat).Append("\n");
            sb.Append("  IsoCode2: ").Append(IsoCode2).Append("\n");
            sb.Append("  IsoCode3: ").Append(IsoCode3).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NumericCode: ").Append(NumericCode).Append("\n");
            sb.Append("  StateCodes: ").Append(StateCodes).Append("\n");
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
            return this.Equals(input as RestCountry);
        }

        /// <summary>
        /// Returns true if RestCountry instances are equal
        /// </summary>
        /// <param name="input">Instance of RestCountry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestCountry input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddressFormat == input.AddressFormat ||
                    (this.AddressFormat != null &&
                    this.AddressFormat.Equals(input.AddressFormat))
                ) && 
                (
                    this.IsoCode2 == input.IsoCode2 ||
                    (this.IsoCode2 != null &&
                    this.IsoCode2.Equals(input.IsoCode2))
                ) && 
                (
                    this.IsoCode3 == input.IsoCode3 ||
                    (this.IsoCode3 != null &&
                    this.IsoCode3.Equals(input.IsoCode3))
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
                ) && 
                (
                    this.StateCodes == input.StateCodes ||
                    this.StateCodes != null &&
                    input.StateCodes != null &&
                    this.StateCodes.SequenceEqual(input.StateCodes)
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
                if (this.AddressFormat != null)
                    hashCode = hashCode * 59 + this.AddressFormat.GetHashCode();
                if (this.IsoCode2 != null)
                    hashCode = hashCode * 59 + this.IsoCode2.GetHashCode();
                if (this.IsoCode3 != null)
                    hashCode = hashCode * 59 + this.IsoCode3.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NumericCode != null)
                    hashCode = hashCode * 59 + this.NumericCode.GetHashCode();
                if (this.StateCodes != null)
                    hashCode = hashCode * 59 + this.StateCodes.GetHashCode();
                return hashCode;
            }
        }

    }

}
