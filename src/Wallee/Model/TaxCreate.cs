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
    /// TaxCreate
    /// </summary>
    [DataContract(Name = "Tax.Create")]
    public partial class TaxCreate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaxCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxCreate" /> class.
        /// </summary>
        /// <param name="rate">The tax rate to be applied. (required).</param>
        /// <param name="title">The name of the tax. (required).</param>
        public TaxCreate(decimal rate = default, string title = default)
        {
            this.Rate = rate;
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for TaxCreate and cannot be null");
            }
            this.Title = title;
        }

        /// <summary>
        /// The tax rate to be applied.
        /// </summary>
        /// <value>The tax rate to be applied.</value>
        [DataMember(Name = "rate", IsRequired = true, EmitDefaultValue = true)]
        public decimal Rate { get; set; }

        /// <summary>
        /// The name of the tax.
        /// </summary>
        /// <value>The name of the tax.</value>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TaxCreate {\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            // Rate (decimal) maximum
            if (this.Rate > (decimal)100)
            {
                yield return new ValidationResult("Invalid value for Rate, must be a value less than or equal to 100.", new [] { "Rate" });
            }

            // Title (string) maxLength
            if (this.Title != null && this.Title.Length > 40)
            {
                yield return new ValidationResult("Invalid value for Title, length must be less than 40.", new [] { "Title" });
            }

            // Title (string) minLength
            if (this.Title != null && this.Title.Length < 2)
            {
                yield return new ValidationResult("Invalid value for Title, length must be greater than 2.", new [] { "Title" });
            }

            yield break;
        }
    }

}
