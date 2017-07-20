/**
 * Wallee SDK Client
 *
 * This client allows to interact with the Wallee API.
 *
 * Wallee API: 1.0.0
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
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
    /// Language
    /// </summary>
    [DataContract]
    public partial class RestLanguage :  IEquatable<RestLanguage>, IValidatableObject
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
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; private set; }

        /// <summary>
        /// The IETF code represents the language as the two letter ISO code including the region (e.g. en-US).
        /// </summary>
        /// <value>The IETF code represents the language as the two letter ISO code including the region (e.g. en-US).</value>
        [DataMember(Name="ietfCode", EmitDefaultValue=false)]
        public string IetfCode { get; private set; }

        /// <summary>
        /// The ISO 2 letter code represents the language with two letters.
        /// </summary>
        /// <value>The ISO 2 letter code represents the language with two letters.</value>
        [DataMember(Name="iso2Code", EmitDefaultValue=false)]
        public string Iso2Code { get; private set; }

        /// <summary>
        /// The ISO 3 letter code represents the language with three letters.
        /// </summary>
        /// <value>The ISO 3 letter code represents the language with three letters.</value>
        [DataMember(Name="iso3Code", EmitDefaultValue=false)]
        public string Iso3Code { get; private set; }

        /// <summary>
        /// The plural expression defines how to map a plural into the language index. This expression is used to determine the plural form for the translations.
        /// </summary>
        /// <value>The plural expression defines how to map a plural into the language index. This expression is used to determine the plural form for the translations.</value>
        [DataMember(Name="pluralExpression", EmitDefaultValue=false)]
        public string PluralExpression { get; private set; }

        /// <summary>
        /// The primary language of a group indicates whether a language is the primary language of a group of languages. The group is determine by the ISO 2 letter code.
        /// </summary>
        /// <value>The primary language of a group indicates whether a language is the primary language of a group of languages. The group is determine by the ISO 2 letter code.</value>
        [DataMember(Name="primaryOfGroup", EmitDefaultValue=false)]
        public bool? PrimaryOfGroup { get; private set; }

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
                if (this.CountryCode != null)
                {
                    hash = hash * 59 + this.CountryCode.GetHashCode();
                }
                if (this.IetfCode != null)
                {
                    hash = hash * 59 + this.IetfCode.GetHashCode();
                }
                if (this.Iso2Code != null)
                {
                    hash = hash * 59 + this.Iso2Code.GetHashCode();
                }
                if (this.Iso3Code != null)
                {
                    hash = hash * 59 + this.Iso3Code.GetHashCode();
                }
                if (this.PluralExpression != null)
                {
                    hash = hash * 59 + this.PluralExpression.GetHashCode();
                }
                if (this.PrimaryOfGroup != null)
                {
                    hash = hash * 59 + this.PrimaryOfGroup.GetHashCode();
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
