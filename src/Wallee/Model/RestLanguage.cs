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
    /// RestLanguage
    /// </summary>
    [DataContract]
    public partial class RestLanguage :  IEquatable<RestLanguage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestLanguage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public RestLanguage()
        {
        }

        /// <summary>
        /// The country code represents the region of the language as a 2 letter ISO code.
        /// </summary>
        /// <value>The country code represents the region of the language as a 2 letter ISO code.</value>
        [DataMember(Name="countryCode", EmitDefaultValue=true)]
        public string CountryCode { get; private set; }

        /// <summary>
        /// The IETF code represents the language as the two letter ISO code including the region (e.g. en-US).
        /// </summary>
        /// <value>The IETF code represents the language as the two letter ISO code including the region (e.g. en-US).</value>
        [DataMember(Name="ietfCode", EmitDefaultValue=true)]
        public string IetfCode { get; private set; }

        /// <summary>
        /// The ISO 2 letter code represents the language with two letters.
        /// </summary>
        /// <value>The ISO 2 letter code represents the language with two letters.</value>
        [DataMember(Name="iso2Code", EmitDefaultValue=true)]
        public string Iso2Code { get; private set; }

        /// <summary>
        /// The ISO 3 letter code represents the language with three letters.
        /// </summary>
        /// <value>The ISO 3 letter code represents the language with three letters.</value>
        [DataMember(Name="iso3Code", EmitDefaultValue=true)]
        public string Iso3Code { get; private set; }

        /// <summary>
        /// The plural expression defines how to map a plural into the language index. This expression is used to determine the plural form for the translations.
        /// </summary>
        /// <value>The plural expression defines how to map a plural into the language index. This expression is used to determine the plural form for the translations.</value>
        [DataMember(Name="pluralExpression", EmitDefaultValue=true)]
        public string PluralExpression { get; private set; }

        /// <summary>
        /// The primary language of a group indicates whether a language is the primary language of a group of languages. The group is determine by the ISO 2 letter code.
        /// </summary>
        /// <value>The primary language of a group indicates whether a language is the primary language of a group of languages. The group is determine by the ISO 2 letter code.</value>
        [DataMember(Name="primaryOfGroup", EmitDefaultValue=true)]
        public bool? PrimaryOfGroup { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestLanguage {\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  IetfCode: ").Append(IetfCode).Append("\n");
            sb.Append("  Iso2Code: ").Append(Iso2Code).Append("\n");
            sb.Append("  Iso3Code: ").Append(Iso3Code).Append("\n");
            sb.Append("  PluralExpression: ").Append(PluralExpression).Append("\n");
            sb.Append("  PrimaryOfGroup: ").Append(PrimaryOfGroup).Append("\n");
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
            return this.Equals(input as RestLanguage);
        }

        /// <summary>
        /// Returns true if RestLanguage instances are equal
        /// </summary>
        /// <param name="input">Instance of RestLanguage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestLanguage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.IetfCode == input.IetfCode ||
                    (this.IetfCode != null &&
                    this.IetfCode.Equals(input.IetfCode))
                ) && 
                (
                    this.Iso2Code == input.Iso2Code ||
                    (this.Iso2Code != null &&
                    this.Iso2Code.Equals(input.Iso2Code))
                ) && 
                (
                    this.Iso3Code == input.Iso3Code ||
                    (this.Iso3Code != null &&
                    this.Iso3Code.Equals(input.Iso3Code))
                ) && 
                (
                    this.PluralExpression == input.PluralExpression ||
                    (this.PluralExpression != null &&
                    this.PluralExpression.Equals(input.PluralExpression))
                ) && 
                (
                    this.PrimaryOfGroup == input.PrimaryOfGroup ||
                    (this.PrimaryOfGroup != null &&
                    this.PrimaryOfGroup.Equals(input.PrimaryOfGroup))
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
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.IetfCode != null)
                    hashCode = hashCode * 59 + this.IetfCode.GetHashCode();
                if (this.Iso2Code != null)
                    hashCode = hashCode * 59 + this.Iso2Code.GetHashCode();
                if (this.Iso3Code != null)
                    hashCode = hashCode * 59 + this.Iso3Code.GetHashCode();
                if (this.PluralExpression != null)
                    hashCode = hashCode * 59 + this.PluralExpression.GetHashCode();
                if (this.PrimaryOfGroup != null)
                    hashCode = hashCode * 59 + this.PrimaryOfGroup.GetHashCode();
                return hashCode;
            }
        }

    }

}
