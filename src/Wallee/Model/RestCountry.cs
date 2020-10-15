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
        /// The ISO code 2 letter identifies the country by two chars as defined in ISO 3166-1 (e.g. US, DE, CH).
        /// </summary>
        /// <value>The ISO code 2 letter identifies the country by two chars as defined in ISO 3166-1 (e.g. US, DE, CH).</value>
        [DataMember(Name="ISOCode2Letter", EmitDefaultValue=true)]
        public string ISOCode2Letter { get; private set; }

        /// <summary>
        /// The ISO code 3 letter identifies the country by three chars as defined in ISO 3166-1 (e.g. CHE, USA, GBR).
        /// </summary>
        /// <value>The ISO code 3 letter identifies the country by three chars as defined in ISO 3166-1 (e.g. CHE, USA, GBR).</value>
        [DataMember(Name="ISOCode3Letter", EmitDefaultValue=true)]
        public string ISOCode3Letter { get; private set; }

        /// <summary>
        /// The address format of the country indicates how an address has to look like for the country.
        /// </summary>
        /// <value>The address format of the country indicates how an address has to look like for the country.</value>
        [DataMember(Name="addressFormat", EmitDefaultValue=true)]
        public RestAddressFormat AddressFormat { get; private set; }

        /// <summary>
        /// The name labels the country by a name in English.
        /// </summary>
        /// <value>The name labels the country by a name in English.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; private set; }

        /// <summary>
        /// The numeric code identifies the country by a three digit number as defined in ISO 3166-1 (e.g. 840, 826, 756).
        /// </summary>
        /// <value>The numeric code identifies the country by a three digit number as defined in ISO 3166-1 (e.g. 840, 826, 756).</value>
        [DataMember(Name="numericCode", EmitDefaultValue=true)]
        public string NumericCode { get; private set; }

        /// <summary>
        /// The state codes field is a list of all states associated with this country. The list contains the identifiers of the states. The identifiers corresponds to the ISO 3166-2 subdivision identifier.
        /// </summary>
        /// <value>The state codes field is a list of all states associated with this country. The list contains the identifiers of the states. The identifiers corresponds to the ISO 3166-2 subdivision identifier.</value>
        [DataMember(Name="stateCodes", EmitDefaultValue=true)]
        public List<string> StateCodes { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestCountry {\n");
            sb.Append("  ISOCode2Letter: ").Append(ISOCode2Letter).Append("\n");
            sb.Append("  ISOCode3Letter: ").Append(ISOCode3Letter).Append("\n");
            sb.Append("  AddressFormat: ").Append(AddressFormat).Append("\n");
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
                    this.ISOCode2Letter == input.ISOCode2Letter ||
                    (this.ISOCode2Letter != null &&
                    this.ISOCode2Letter.Equals(input.ISOCode2Letter))
                ) && 
                (
                    this.ISOCode3Letter == input.ISOCode3Letter ||
                    (this.ISOCode3Letter != null &&
                    this.ISOCode3Letter.Equals(input.ISOCode3Letter))
                ) && 
                (
                    this.AddressFormat == input.AddressFormat ||
                    (this.AddressFormat != null &&
                    this.AddressFormat.Equals(input.AddressFormat))
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
                if (this.ISOCode2Letter != null)
                    hashCode = hashCode * 59 + this.ISOCode2Letter.GetHashCode();
                if (this.ISOCode3Letter != null)
                    hashCode = hashCode * 59 + this.ISOCode3Letter.GetHashCode();
                if (this.AddressFormat != null)
                    hashCode = hashCode * 59 + this.AddressFormat.GetHashCode();
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
