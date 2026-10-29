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
    /// IdentityInfo
    /// </summary>
    [DataContract(Name = "IdentityInfo")]
    public partial class IdentityInfo : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public PersonSalutation? Title { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityInfo" /> class.
        /// </summary>
        /// <param name="familyName">familyName.</param>
        /// <param name="givenName">givenName.</param>
        /// <param name="title">title.</param>
        /// <param name="birthDate">birthDate.</param>
        public IdentityInfo(string familyName = default, string givenName = default, PersonSalutation? title = default, DateOnly birthDate = default)
        {
            this.FamilyName = familyName;
            this.GivenName = givenName;
            this.Title = title;
            this.BirthDate = birthDate;
        }

        /// <summary>
        /// Gets or Sets FamilyName
        /// </summary>
        [DataMember(Name = "familyName", EmitDefaultValue = false)]
        public string FamilyName { get; set; }

        /// <summary>
        /// Gets or Sets GivenName
        /// </summary>
        [DataMember(Name = "givenName", EmitDefaultValue = false)]
        public string GivenName { get; set; }

        /// <summary>
        /// Gets or Sets BirthDate
        /// </summary>
        [DataMember(Name = "birthDate", EmitDefaultValue = false)]
        public DateOnly BirthDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IdentityInfo {\n");
            sb.Append("  FamilyName: ").Append(FamilyName).Append("\n");
            sb.Append("  GivenName: ").Append(GivenName).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
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
