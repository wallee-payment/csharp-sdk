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
    /// RelatedPerson
    /// </summary>
    [DataContract(Name = "RelatedPerson")]
    public partial class RelatedPerson : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RelatedPerson" /> class.
        /// </summary>
        /// <param name="emailAddress">emailAddress.</param>
        /// <param name="isSelectedShareholderOrDirector">isSelectedShareholderOrDirector.</param>
        /// <param name="placeOfBirth">placeOfBirth.</param>
        /// <param name="identityInfo">identityInfo.</param>
        /// <param name="nationality">nationality.</param>
        /// <param name="contactLanguage">contactLanguage.</param>
        /// <param name="isDirector">isDirector.</param>
        /// <param name="representativeInfo">representativeInfo.</param>
        /// <param name="jobRole">jobRole.</param>
        /// <param name="id">id.</param>
        /// <param name="companyShare">companyShare.</param>
        /// <param name="residenceAddress">residenceAddress.</param>
        public RelatedPerson(string emailAddress = default, bool isSelectedShareholderOrDirector = default, string placeOfBirth = default, IdentityInfo identityInfo = default, string nationality = default, string contactLanguage = default, bool isDirector = default, RepresentativeInfo representativeInfo = default, string jobRole = default, string id = default, decimal companyShare = default, BasicAddress residenceAddress = default)
        {
            this.EmailAddress = emailAddress;
            this.IsSelectedShareholderOrDirector = isSelectedShareholderOrDirector;
            this.PlaceOfBirth = placeOfBirth;
            this.IdentityInfo = identityInfo;
            this.Nationality = nationality;
            this.ContactLanguage = contactLanguage;
            this.IsDirector = isDirector;
            this.RepresentativeInfo = representativeInfo;
            this.JobRole = jobRole;
            this.Id = id;
            this.CompanyShare = companyShare;
            this.ResidenceAddress = residenceAddress;
        }

        /// <summary>
        /// Gets or Sets EmailAddress
        /// </summary>
        [DataMember(Name = "emailAddress", EmitDefaultValue = false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets IsSelectedShareholderOrDirector
        /// </summary>
        [DataMember(Name = "isSelectedShareholderOrDirector", EmitDefaultValue = true)]
        public bool IsSelectedShareholderOrDirector { get; set; }

        /// <summary>
        /// Gets or Sets PlaceOfBirth
        /// </summary>
        [DataMember(Name = "placeOfBirth", EmitDefaultValue = false)]
        public string PlaceOfBirth { get; set; }

        /// <summary>
        /// Gets or Sets IdentityInfo
        /// </summary>
        [DataMember(Name = "identityInfo", EmitDefaultValue = false)]
        public IdentityInfo IdentityInfo { get; set; }

        /// <summary>
        /// Gets or Sets Nationality
        /// </summary>
        [DataMember(Name = "nationality", EmitDefaultValue = false)]
        public string Nationality { get; set; }

        /// <summary>
        /// Gets or Sets ContactLanguage
        /// </summary>
        [DataMember(Name = "contactLanguage", EmitDefaultValue = false)]
        public string ContactLanguage { get; set; }

        /// <summary>
        /// Gets or Sets IsDirector
        /// </summary>
        [DataMember(Name = "isDirector", EmitDefaultValue = true)]
        public bool IsDirector { get; set; }

        /// <summary>
        /// Gets or Sets RepresentativeInfo
        /// </summary>
        [DataMember(Name = "representativeInfo", EmitDefaultValue = false)]
        public RepresentativeInfo RepresentativeInfo { get; set; }

        /// <summary>
        /// Gets or Sets JobRole
        /// </summary>
        [DataMember(Name = "jobRole", EmitDefaultValue = false)]
        public string JobRole { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets CompanyShare
        /// </summary>
        [DataMember(Name = "companyShare", EmitDefaultValue = false)]
        public decimal CompanyShare { get; set; }

        /// <summary>
        /// Gets or Sets ResidenceAddress
        /// </summary>
        [DataMember(Name = "residenceAddress", EmitDefaultValue = false)]
        public BasicAddress ResidenceAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RelatedPerson {\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  IsSelectedShareholderOrDirector: ").Append(IsSelectedShareholderOrDirector).Append("\n");
            sb.Append("  PlaceOfBirth: ").Append(PlaceOfBirth).Append("\n");
            sb.Append("  IdentityInfo: ").Append(IdentityInfo).Append("\n");
            sb.Append("  Nationality: ").Append(Nationality).Append("\n");
            sb.Append("  ContactLanguage: ").Append(ContactLanguage).Append("\n");
            sb.Append("  IsDirector: ").Append(IsDirector).Append("\n");
            sb.Append("  RepresentativeInfo: ").Append(RepresentativeInfo).Append("\n");
            sb.Append("  JobRole: ").Append(JobRole).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CompanyShare: ").Append(CompanyShare).Append("\n");
            sb.Append("  ResidenceAddress: ").Append(ResidenceAddress).Append("\n");
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
