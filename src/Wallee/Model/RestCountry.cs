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
    /// RestCountry
    /// </summary>
    [DataContract(Name = "RestCountry")]
    public partial class RestCountry : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestCountry" /> class.
        /// </summary>
        /// <param name="addressFormat">addressFormat.</param>
        public RestCountry(RestAddressFormat addressFormat = default(RestAddressFormat))
        {
            this.AddressFormat = addressFormat;
        }

        /// <summary>
        /// The country&#39;s two-letter code (ISO 3166-1 alpha-2 format).
        /// </summary>
        /// <value>The country&#39;s two-letter code (ISO 3166-1 alpha-2 format).</value>
        [DataMember(Name = "isoCode2", EmitDefaultValue = false)]
        public string IsoCode2 { get; private set; }

        /// <summary>
        /// Returns false as IsoCode2 should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsoCode2()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets AddressFormat
        /// </summary>
        [DataMember(Name = "addressFormat", EmitDefaultValue = false)]
        public RestAddressFormat AddressFormat { get; set; }

        /// <summary>
        /// The country&#39;s three-letter code (ISO 3166-1 alpha-3 format).
        /// </summary>
        /// <value>The country&#39;s three-letter code (ISO 3166-1 alpha-3 format).</value>
        [DataMember(Name = "isoCode3", EmitDefaultValue = false)]
        public string IsoCode3 { get; private set; }

        /// <summary>
        /// Returns false as IsoCode3 should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsoCode3()
        {
            return false;
        }
        /// <summary>
        /// The codes of all regions (e.g. states, provinces) of the country (ISO 3166-2 format).
        /// </summary>
        /// <value>The codes of all regions (e.g. states, provinces) of the country (ISO 3166-2 format).</value>
        [DataMember(Name = "stateCodes", EmitDefaultValue = false)]
        public List<string> StateCodes { get; private set; }

        /// <summary>
        /// Returns false as StateCodes should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStateCodes()
        {
            return false;
        }
        /// <summary>
        /// The name of the country.
        /// </summary>
        /// <value>The name of the country.</value>
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
        /// The country&#39;s three-digit code (ISO 3166-1 numeric format).
        /// </summary>
        /// <value>The country&#39;s three-digit code (ISO 3166-1 numeric format).</value>
        [DataMember(Name = "numericCode", EmitDefaultValue = false)]
        public string NumericCode { get; private set; }

        /// <summary>
        /// Returns false as NumericCode should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNumericCode()
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
            sb.Append("class RestCountry {\n");
            sb.Append("  IsoCode2: ").Append(IsoCode2).Append("\n");
            sb.Append("  AddressFormat: ").Append(AddressFormat).Append("\n");
            sb.Append("  IsoCode3: ").Append(IsoCode3).Append("\n");
            sb.Append("  StateCodes: ").Append(StateCodes).Append("\n");
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
