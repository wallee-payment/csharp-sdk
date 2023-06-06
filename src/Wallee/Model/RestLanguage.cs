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
        /// The two-letter code of the language&#39;s region (ISO 3166-1 alpha-2 format).
        /// </summary>
        /// <value>The two-letter code of the language&#39;s region (ISO 3166-1 alpha-2 format).</value>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; private set; }

        /// <summary>
        /// The language&#39;s IETF tag consisting of the two-letter ISO code and region e.g. en-US, de-CH.
        /// </summary>
        /// <value>The language&#39;s IETF tag consisting of the two-letter ISO code and region e.g. en-US, de-CH.</value>
        [DataMember(Name="ietfCode", EmitDefaultValue=false)]
        public string IetfCode { get; private set; }

        /// <summary>
        /// The language&#39;s two-letter code (ISO 639-1 format).
        /// </summary>
        /// <value>The language&#39;s two-letter code (ISO 639-1 format).</value>
        [DataMember(Name="iso2Code", EmitDefaultValue=false)]
        public string Iso2Code { get; private set; }

        /// <summary>
        /// The language&#39;s three-letter code (ISO 639-2/T format).
        /// </summary>
        /// <value>The language&#39;s three-letter code (ISO 639-2/T format).</value>
        [DataMember(Name="iso3Code", EmitDefaultValue=false)]
        public string Iso3Code { get; private set; }

        /// <summary>
        /// The name of the language.
        /// </summary>
        /// <value>The name of the language.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// The expression to determine the plural index for a given number of items used to find the proper plural form for translations.
        /// </summary>
        /// <value>The expression to determine the plural index for a given number of items used to find the proper plural form for translations.</value>
        [DataMember(Name="pluralExpression", EmitDefaultValue=false)]
        public string PluralExpression { get; private set; }

        /// <summary>
        /// Whether this is the primary language in a group of languages.
        /// </summary>
        /// <value>Whether this is the primary language in a group of languages.</value>
        [DataMember(Name="primaryOfGroup", EmitDefaultValue=false)]
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
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PluralExpression != null)
                    hashCode = hashCode * 59 + this.PluralExpression.GetHashCode();
                if (this.PrimaryOfGroup != null)
                    hashCode = hashCode * 59 + this.PrimaryOfGroup.GetHashCode();
                return hashCode;
            }
        }

    }

}
