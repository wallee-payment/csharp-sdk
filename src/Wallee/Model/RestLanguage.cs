/**
 * Wallee AG C# SDK
 *
 * This library allows to interact with the Wallee AG payment service.
 *
 * Copyright owner: Wallee AG
 * Website: https://en.wallee.com
 * Developer email: ecosystem-team@wallee.com
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Wallee.Client.OpenAPIDateConverter;

namespace Wallee.Model
{
    /// <summary>
    /// RestLanguage
    /// </summary>
    [DataContract(Name = "RestLanguage")]
    public partial class RestLanguage : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestLanguage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public RestLanguage()
        {
        }

        /// <summary>
        /// Whether this is the primary language in a group of languages.
        /// </summary>
        /// <value>Whether this is the primary language in a group of languages.</value>
        [DataMember(Name = "primaryOfGroup", EmitDefaultValue = true)]
        public bool PrimaryOfGroup { get; private set; }

        /// <summary>
        /// Returns false as PrimaryOfGroup should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePrimaryOfGroup()
        {
            return false;
        }
        /// <summary>
        /// The two-letter code of the language&#39;s region (ISO 3166-1 alpha-2 format).
        /// </summary>
        /// <value>The two-letter code of the language&#39;s region (ISO 3166-1 alpha-2 format).</value>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        public string CountryCode { get; private set; }

        /// <summary>
        /// Returns false as CountryCode should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCountryCode()
        {
            return false;
        }
        /// <summary>
        /// The language&#39;s two-letter code (ISO 639-1 format).
        /// </summary>
        /// <value>The language&#39;s two-letter code (ISO 639-1 format).</value>
        [DataMember(Name = "iso2Code", EmitDefaultValue = false)]
        public string Iso2Code { get; private set; }

        /// <summary>
        /// Returns false as Iso2Code should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIso2Code()
        {
            return false;
        }
        /// <summary>
        /// The name of the language.
        /// </summary>
        /// <value>The name of the language.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; private set; }

        /// <summary>
        /// Returns false as Name should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeName()
        {
            return false;
        }
        /// <summary>
        /// The language&#39;s IETF tag consisting of the two-letter ISO code and region e.g. en-US, de-CH.
        /// </summary>
        /// <value>The language&#39;s IETF tag consisting of the two-letter ISO code and region e.g. en-US, de-CH.</value>
        [DataMember(Name = "ietfCode", EmitDefaultValue = false)]
        public string IetfCode { get; private set; }

        /// <summary>
        /// Returns false as IetfCode should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIetfCode()
        {
            return false;
        }
        /// <summary>
        /// The language&#39;s three-letter code (ISO 639-2/T format).
        /// </summary>
        /// <value>The language&#39;s three-letter code (ISO 639-2/T format).</value>
        [DataMember(Name = "iso3Code", EmitDefaultValue = false)]
        public string Iso3Code { get; private set; }

        /// <summary>
        /// Returns false as Iso3Code should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIso3Code()
        {
            return false;
        }
        /// <summary>
        /// The expression to determine the plural index for a given number of items used to find the proper plural form for translations.
        /// </summary>
        /// <value>The expression to determine the plural index for a given number of items used to find the proper plural form for translations.</value>
        [DataMember(Name = "pluralExpression", EmitDefaultValue = false)]
        public string PluralExpression { get; private set; }

        /// <summary>
        /// Returns false as PluralExpression should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePluralExpression()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RestLanguage {\n");
            sb.Append("  PrimaryOfGroup: ").Append(PrimaryOfGroup).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Iso2Code: ").Append(Iso2Code).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IetfCode: ").Append(IetfCode).Append("\n");
            sb.Append("  Iso3Code: ").Append(Iso3Code).Append("\n");
            sb.Append("  PluralExpression: ").Append(PluralExpression).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
