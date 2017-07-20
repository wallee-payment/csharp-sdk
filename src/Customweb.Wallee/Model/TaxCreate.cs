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
    /// Tax (in creation)
    /// </summary>
    [DataContract]
    public partial class TaxCreate :  IEquatable<TaxCreate>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="TaxCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaxCreate() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaxCreate" /> class.
        /// </summary>
        /// <param name="Rate">Rate (required)</param>
        /// <param name="Title">Title (required)</param>
        public TaxCreate(string Title = default(string), decimal? Rate = default(decimal?))
        {
            // to ensure "Rate" is required (not null)
            if (Rate == null)
            {
                throw new ArgumentNullException("Rate is a required property for TaxCreate and cannot be null");
            }
            else
            {
                this.Rate = Rate;
            }
            // to ensure "Title" is required (not null)
            if (Title == null)
            {
                throw new ArgumentNullException("Title is a required property for TaxCreate and cannot be null");
            }
            else
            {
                this.Title = Title;
            }
        }

        /// <summary>
        /// Rate
        /// </summary>
        /// <value>Rate</value>
        [DataMember(Name="rate", EmitDefaultValue=false)]
        public decimal? Rate { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        /// <value>Title</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

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
            return this.Equals(obj as TaxCreate);
        }

        /// <summary>
        /// Returns true if TaxCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of TaxCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxCreate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Rate == other.Rate ||
                    this.Rate != null &&
                    this.Rate.Equals(other.Rate)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
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
                if (this.Rate != null)
                {
                    hash = hash * 59 + this.Rate.GetHashCode();
                }
                if (this.Title != null)
                {
                    hash = hash * 59 + this.Title.GetHashCode();
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
