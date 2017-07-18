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
    /// Country
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
        [DataMember(Name="ISOCode2Letter", EmitDefaultValue=false)]
        public string ISOCode2Letter { get; private set; }

        /// <summary>
        /// The ISO code 3 letter identifies the country by three chars as defined in ISO 3166-1 (e.g. CHE, USA, GBR).
        /// </summary>
        /// <value>The ISO code 3 letter identifies the country by three chars as defined in ISO 3166-1 (e.g. CHE, USA, GBR).</value>
        [DataMember(Name="ISOCode3Letter", EmitDefaultValue=false)]
        public string ISOCode3Letter { get; private set; }

        /// <summary>
        /// The name labels the country by a name in English.
        /// </summary>
        /// <value>The name labels the country by a name in English.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// The numeric code identifies the country by a three digit number as defined in ISO 3166-1 (e.g. 840, 826, 756).
        /// </summary>
        /// <value>The numeric code identifies the country by a three digit number as defined in ISO 3166-1 (e.g. 840, 826, 756).</value>
        [DataMember(Name="numericCode", EmitDefaultValue=false)]
        public string NumericCode { get; private set; }

        /// <summary>
        /// The state codes field is a list of all states associated with this country. The list contains the identifiers of the states. The identifiers corresponds to the ISO 3166-2 subdivision identifier.
        /// </summary>
        /// <value>The state codes field is a list of all states associated with this country. The list contains the identifiers of the states. The identifiers corresponds to the ISO 3166-2 subdivision identifier.</value>
        [DataMember(Name="stateCodes", EmitDefaultValue=false)]
        public List<string> StateCodes { get; private set; }

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
            return this.Equals(obj as RestCountry);
        }

        /// <summary>
        /// Returns true if RestCountry instances are equal
        /// </summary>
        /// <param name="other">Instance of RestCountry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestCountry other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.ISOCode2Letter == other.ISOCode2Letter ||
                    this.ISOCode2Letter != null &&
                    this.ISOCode2Letter.Equals(other.ISOCode2Letter)
                ) && 
                (
                    this.ISOCode3Letter == other.ISOCode3Letter ||
                    this.ISOCode3Letter != null &&
                    this.ISOCode3Letter.Equals(other.ISOCode3Letter)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.NumericCode == other.NumericCode ||
                    this.NumericCode != null &&
                    this.NumericCode.Equals(other.NumericCode)
                ) && 
                (
                    this.StateCodes == other.StateCodes ||
                    this.StateCodes != null &&
                    this.StateCodes.SequenceEqual(other.StateCodes)
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
                if (this.ISOCode2Letter != null)
                {
                    hash = hash * 59 + this.ISOCode2Letter.GetHashCode();
                }
                if (this.ISOCode3Letter != null)
                {
                    hash = hash * 59 + this.ISOCode3Letter.GetHashCode();
                }
                if (this.Name != null)
                {
                    hash = hash * 59 + this.Name.GetHashCode();
                }
                if (this.NumericCode != null)
                {
                    hash = hash * 59 + this.NumericCode.GetHashCode();
                }
                if (this.StateCodes != null)
                {
                    hash = hash * 59 + this.StateCodes.GetHashCode();
                }
                return hash;
            }
        }

    }

}
