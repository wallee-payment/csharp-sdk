
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
    /// RestLanguage model.
    /// </summary>
    [DataContract]
    public partial class RestLanguage :  IEquatable<RestLanguage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestLanguage" /> class.
        /// </summary>
        /// <param name="CountryCode">The country code represents the region of the language as a 2 letter ISO code.</param>
        /// <param name="IetfCode">The IETF code represents the language as the two letter ISO code including the region (e.g. en-US).</param>
        /// <param name="Iso2Code">The ISO 2 letter code represents the language with two letters.</param>
        /// <param name="Iso3Code">The ISO 3 letter code represents the language with three letters.</param>
        /// <param name="PluralExpression">The plural expression defines how to map a plural into the language index. This expression is used to determine the plural form for the translations.</param>
        /// <param name="PrimaryOfGroup">The primary language of a group indicates whether a language is the primary language of a group of languages. The group is determine by the ISO 2 letter code.</param>
        public RestLanguage(string CountryCode = default(string), string IetfCode = default(string), string Iso2Code = default(string), string Iso3Code = default(string), string PluralExpression = default(string), bool? PrimaryOfGroup = default(bool?))
        {
            this.CountryCode = CountryCode;
            this.IetfCode = IetfCode;
            this.Iso2Code = Iso2Code;
            this.Iso3Code = Iso3Code;
            this.PluralExpression = PluralExpression;
            this.PrimaryOfGroup = PrimaryOfGroup;
        }

        /// <summary>
        /// The country code represents the region of the language as a 2 letter ISO code.
        /// </summary>
        /// <value>The country code represents the region of the language as a 2 letter ISO code.</value>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The IETF code represents the language as the two letter ISO code including the region (e.g. en-US).
        /// </summary>
        /// <value>The IETF code represents the language as the two letter ISO code including the region (e.g. en-US).</value>
        [DataMember(Name="ietfCode", EmitDefaultValue=false)]
        public string IetfCode { get; set; }

        /// <summary>
        /// The ISO 2 letter code represents the language with two letters.
        /// </summary>
        /// <value>The ISO 2 letter code represents the language with two letters.</value>
        [DataMember(Name="iso2Code", EmitDefaultValue=false)]
        public string Iso2Code { get; set; }

        /// <summary>
        /// The ISO 3 letter code represents the language with three letters.
        /// </summary>
        /// <value>The ISO 3 letter code represents the language with three letters.</value>
        [DataMember(Name="iso3Code", EmitDefaultValue=false)]
        public string Iso3Code { get; set; }

        /// <summary>
        /// The plural expression defines how to map a plural into the language index. This expression is used to determine the plural form for the translations.
        /// </summary>
        /// <value>The plural expression defines how to map a plural into the language index. This expression is used to determine the plural form for the translations.</value>
        [DataMember(Name="pluralExpression", EmitDefaultValue=false)]
        public string PluralExpression { get; set; }

        /// <summary>
        /// The primary language of a group indicates whether a language is the primary language of a group of languages. The group is determine by the ISO 2 letter code.
        /// </summary>
        /// <value>The primary language of a group indicates whether a language is the primary language of a group of languages. The group is determine by the ISO 2 letter code.</value>
        [DataMember(Name="primaryOfGroup", EmitDefaultValue=false)]
        public bool? PrimaryOfGroup { get; set; }

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
            return this.Equals(obj as RestLanguage);
        }

        /// <summary>
        /// Returns true if RestLanguage instances are equal
        /// </summary>
        /// <param name="other">Instance of RestLanguage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestLanguage other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.CountryCode == other.CountryCode ||
                    this.CountryCode != null &&
                    this.CountryCode.Equals(other.CountryCode)
                ) && 
                (
                    this.IetfCode == other.IetfCode ||
                    this.IetfCode != null &&
                    this.IetfCode.Equals(other.IetfCode)
                ) && 
                (
                    this.Iso2Code == other.Iso2Code ||
                    this.Iso2Code != null &&
                    this.Iso2Code.Equals(other.Iso2Code)
                ) && 
                (
                    this.Iso3Code == other.Iso3Code ||
                    this.Iso3Code != null &&
                    this.Iso3Code.Equals(other.Iso3Code)
                ) && 
                (
                    this.PluralExpression == other.PluralExpression ||
                    this.PluralExpression != null &&
                    this.PluralExpression.Equals(other.PluralExpression)
                ) && 
                (
                    this.PrimaryOfGroup == other.PrimaryOfGroup ||
                    this.PrimaryOfGroup != null &&
                    this.PrimaryOfGroup.Equals(other.PrimaryOfGroup)
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
                if (this.CountryCode != null)
                    hash = hash * 59 + this.CountryCode.GetHashCode();
                if (this.IetfCode != null)
                    hash = hash * 59 + this.IetfCode.GetHashCode();
                if (this.Iso2Code != null)
                    hash = hash * 59 + this.Iso2Code.GetHashCode();
                if (this.Iso3Code != null)
                    hash = hash * 59 + this.Iso3Code.GetHashCode();
                if (this.PluralExpression != null)
                    hash = hash * 59 + this.PluralExpression.GetHashCode();
                if (this.PrimaryOfGroup != null)
                    hash = hash * 59 + this.PrimaryOfGroup.GetHashCode();
                return hash;
            }
        }

    }

}
