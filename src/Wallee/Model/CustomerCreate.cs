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
    /// CustomerCreate
    /// </summary>
    [DataContract(Name = "Customer.Create")]
    public partial class CustomerCreate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerCreate" /> class.
        /// </summary>
        /// <param name="metaData">Allow to store additional information about the object..</param>
        /// <param name="emailAddress">The customer&#39;s email address..</param>
        /// <param name="familyName">The customer&#39;s family or last name..</param>
        /// <param name="givenName">The customer&#39;s given or first name..</param>
        /// <param name="preferredCurrency">The customer&#39;s preferred currency..</param>
        /// <param name="customerId">The customer&#39;s ID in the merchant&#39;s system..</param>
        /// <param name="language">The language that is linked to the object..</param>
        public CustomerCreate(Dictionary<string, string> metaData = default(Dictionary<string, string>), string emailAddress = default(string), string familyName = default(string), string givenName = default(string), string preferredCurrency = default(string), string customerId = default(string), string language = default(string))
        {
            this.MetaData = metaData;
            this.EmailAddress = emailAddress;
            this.FamilyName = familyName;
            this.GivenName = givenName;
            this.PreferredCurrency = preferredCurrency;
            this.CustomerId = customerId;
            this.Language = language;
        }

        /// <summary>
        /// Allow to store additional information about the object.
        /// </summary>
        /// <value>Allow to store additional information about the object.</value>
        [DataMember(Name = "metaData", EmitDefaultValue = false)]
        public Dictionary<string, string> MetaData { get; set; }

        /// <summary>
        /// The customer&#39;s email address.
        /// </summary>
        /// <value>The customer&#39;s email address.</value>
        [DataMember(Name = "emailAddress", EmitDefaultValue = false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The customer&#39;s family or last name.
        /// </summary>
        /// <value>The customer&#39;s family or last name.</value>
        [DataMember(Name = "familyName", EmitDefaultValue = false)]
        public string FamilyName { get; set; }

        /// <summary>
        /// The customer&#39;s given or first name.
        /// </summary>
        /// <value>The customer&#39;s given or first name.</value>
        [DataMember(Name = "givenName", EmitDefaultValue = false)]
        public string GivenName { get; set; }

        /// <summary>
        /// The customer&#39;s preferred currency.
        /// </summary>
        /// <value>The customer&#39;s preferred currency.</value>
        [DataMember(Name = "preferredCurrency", EmitDefaultValue = false)]
        public string PreferredCurrency { get; set; }

        /// <summary>
        /// The customer&#39;s ID in the merchant&#39;s system.
        /// </summary>
        /// <value>The customer&#39;s ID in the merchant&#39;s system.</value>
        [DataMember(Name = "customerId", EmitDefaultValue = false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// The language that is linked to the object.
        /// </summary>
        /// <value>The language that is linked to the object.</value>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public string Language { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomerCreate {\n");
            sb.Append("  MetaData: ").Append(MetaData).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  FamilyName: ").Append(FamilyName).Append("\n");
            sb.Append("  GivenName: ").Append(GivenName).Append("\n");
            sb.Append("  PreferredCurrency: ").Append(PreferredCurrency).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
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
            // EmailAddress (string) maxLength
            if (this.EmailAddress != null && this.EmailAddress.Length > 254)
            {
                yield return new ValidationResult("Invalid value for EmailAddress, length must be less than 254.", new [] { "EmailAddress" });
            }

            // FamilyName (string) maxLength
            if (this.FamilyName != null && this.FamilyName.Length > 100)
            {
                yield return new ValidationResult("Invalid value for FamilyName, length must be less than 100.", new [] { "FamilyName" });
            }

            // GivenName (string) maxLength
            if (this.GivenName != null && this.GivenName.Length > 100)
            {
                yield return new ValidationResult("Invalid value for GivenName, length must be less than 100.", new [] { "GivenName" });
            }

            // CustomerId (string) maxLength
            if (this.CustomerId != null && this.CustomerId.Length > 100)
            {
                yield return new ValidationResult("Invalid value for CustomerId, length must be less than 100.", new [] { "CustomerId" });
            }

            if (this.CustomerId != null) {
                // CustomerId (string) pattern
                Regex regexCustomerId = new Regex(@"[	\x20-\x7e]*", RegexOptions.CultureInvariant);
                if (!regexCustomerId.Match(this.CustomerId).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomerId, must match a pattern of " + regexCustomerId, new [] { "CustomerId" });
                }
            }

            yield break;
        }
    }

}
