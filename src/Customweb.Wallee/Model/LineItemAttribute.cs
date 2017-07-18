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
    /// Line Item Attribute
    /// </summary>
    [DataContract]
    public partial class LineItemAttribute :  IEquatable<LineItemAttribute>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="LineItemAttribute" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public LineItemAttribute()
        {
        }

        /// <summary>
        /// Label
        /// </summary>
        /// <value>Label</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; private set; }

        /// <summary>
        /// Value
        /// </summary>
        /// <value>Value</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; private set; }

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
            return this.Equals(obj as LineItemAttribute);
        }

        /// <summary>
        /// Returns true if LineItemAttribute instances are equal
        /// </summary>
        /// <param name="other">Instance of LineItemAttribute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LineItemAttribute other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Label == other.Label ||
                    this.Label != null &&
                    this.Label.Equals(other.Label)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                if (this.Label != null)
                {
                    hash = hash * 59 + this.Label.GetHashCode();
                }
                if (this.Value != null)
                {
                    hash = hash * 59 + this.Value.GetHashCode();
                }
                return hash;
            }
        }

    }

}
