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
    /// LegalOrganizationForm
    /// </summary>
    [DataContract(Name = "LegalOrganizationForm")]
    public partial class LegalOrganizationForm : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LegalOrganizationForm" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public LegalOrganizationForm()
        {
        }

        /// <summary>
        /// The two-letter code of the country the legal organization form is used in (ISO 3166-1 alpha-2 format).
        /// </summary>
        /// <value>The two-letter code of the country the legal organization form is used in (ISO 3166-1 alpha-2 format).</value>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; private set; }

        /// <summary>
        /// Returns false as Country should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCountry()
        {
            return false;
        }
        /// <summary>
        /// The localized shortcuts of the legal organization form.
        /// </summary>
        /// <value>The localized shortcuts of the legal organization form.</value>
        [DataMember(Name = "shortcut", EmitDefaultValue = false)]
        public List<LocalizedString> Shortcut { get; private set; }

        /// <summary>
        /// Returns false as Shortcut should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeShortcut()
        {
            return false;
        }
        /// <summary>
        /// The English name of the legal organization form.
        /// </summary>
        /// <value>The English name of the legal organization form.</value>
        [DataMember(Name = "englishDescription", EmitDefaultValue = false)]
        public string EnglishDescription { get; private set; }

        /// <summary>
        /// Returns false as EnglishDescription should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEnglishDescription()
        {
            return false;
        }
        /// <summary>
        /// The localized descriptions of the legal organization form.
        /// </summary>
        /// <value>The localized descriptions of the legal organization form.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public List<LocalizedString> Description { get; private set; }

        /// <summary>
        /// Returns false as Description should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDescription()
        {
            return false;
        }
        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
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
            sb.Append("class LegalOrganizationForm {\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Shortcut: ").Append(Shortcut).Append("\n");
            sb.Append("  EnglishDescription: ").Append(EnglishDescription).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
