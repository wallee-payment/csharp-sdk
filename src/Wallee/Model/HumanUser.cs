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
    /// HumanUser
    /// </summary>
    [DataContract(Name = "HumanUser")]
    public partial class HumanUser : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HumanUser" /> class.
        /// </summary>
        /// <param name="twoFactorType">twoFactorType.</param>
        public HumanUser(TwoFactorAuthenticationType twoFactorType = default)
        {
            this.TwoFactorType = twoFactorType;
        }

        /// <summary>
        /// The user&#39;s mobile phone number.
        /// </summary>
        /// <value>The user&#39;s mobile phone number.</value>
        [DataMember(Name = "mobilePhoneNumber", EmitDefaultValue = false)]
        public string MobilePhoneNumber { get; private set; }

        /// <summary>
        /// Returns false as MobilePhoneNumber should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMobilePhoneNumber()
        {
            return false;
        }
        /// <summary>
        /// Whether two-factor authentication is enabled for this user.
        /// </summary>
        /// <value>Whether two-factor authentication is enabled for this user.</value>
        [DataMember(Name = "twoFactorEnabled", EmitDefaultValue = true)]
        public bool TwoFactorEnabled { get; private set; }

        /// <summary>
        /// Returns false as TwoFactorEnabled should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTwoFactorEnabled()
        {
            return false;
        }
        /// <summary>
        /// The user&#39;s email address.
        /// </summary>
        /// <value>The user&#39;s email address.</value>
        [DataMember(Name = "emailAddress", EmitDefaultValue = false)]
        public string EmailAddress { get; private set; }

        /// <summary>
        /// Returns false as EmailAddress should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEmailAddress()
        {
            return false;
        }
        /// <summary>
        /// The user&#39;s first name.
        /// </summary>
        /// <value>The user&#39;s first name.</value>
        [DataMember(Name = "firstname", EmitDefaultValue = false)]
        public string Firstname { get; private set; }

        /// <summary>
        /// Returns false as Firstname should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFirstname()
        {
            return false;
        }
        /// <summary>
        /// Whether the user&#39;s email address has been verified.
        /// </summary>
        /// <value>Whether the user&#39;s email address has been verified.</value>
        [DataMember(Name = "emailAddressVerified", EmitDefaultValue = true)]
        public bool EmailAddressVerified { get; private set; }

        /// <summary>
        /// Returns false as EmailAddressVerified should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEmailAddressVerified()
        {
            return false;
        }
        /// <summary>
        /// The scope that the user belongs to.
        /// </summary>
        /// <value>The scope that the user belongs to.</value>
        [DataMember(Name = "scope", EmitDefaultValue = false)]
        public long Scope { get; private set; }

        /// <summary>
        /// Returns false as Scope should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeScope()
        {
            return false;
        }
        /// <summary>
        /// The user&#39;s time zone. If none is specified, the one provided by the browser will be used.
        /// </summary>
        /// <value>The user&#39;s time zone. If none is specified, the one provided by the browser will be used.</value>
        [DataMember(Name = "timeZone", EmitDefaultValue = false)]
        public string VarTimeZone { get; private set; }

        /// <summary>
        /// Returns false as VarTimeZone should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVarTimeZone()
        {
            return false;
        }
        /// <summary>
        /// The user&#39;s preferred language.
        /// </summary>
        /// <value>The user&#39;s preferred language.</value>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public string Language { get; private set; }

        /// <summary>
        /// Returns false as Language should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLanguage()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets TwoFactorType
        /// </summary>
        [DataMember(Name = "twoFactorType", EmitDefaultValue = false)]
        public TwoFactorAuthenticationType TwoFactorType { get; set; }

        /// <summary>
        /// Whether the user&#39;s mobile phone number has been verified.
        /// </summary>
        /// <value>Whether the user&#39;s mobile phone number has been verified.</value>
        [DataMember(Name = "mobilePhoneVerified", EmitDefaultValue = true)]
        public bool MobilePhoneVerified { get; private set; }

        /// <summary>
        /// Returns false as MobilePhoneVerified should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMobilePhoneVerified()
        {
            return false;
        }
        /// <summary>
        /// The primary account that the user belongs to.
        /// </summary>
        /// <value>The primary account that the user belongs to.</value>
        [DataMember(Name = "primaryAccount", EmitDefaultValue = false)]
        public long PrimaryAccount { get; private set; }

        /// <summary>
        /// Returns false as PrimaryAccount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePrimaryAccount()
        {
            return false;
        }
        /// <summary>
        /// The user&#39;s last name.
        /// </summary>
        /// <value>The user&#39;s last name.</value>
        [DataMember(Name = "lastname", EmitDefaultValue = false)]
        public string Lastname { get; private set; }

        /// <summary>
        /// Returns false as Lastname should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastname()
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
            sb.Append("class HumanUser {\n");
            sb.Append("  MobilePhoneNumber: ").Append(MobilePhoneNumber).Append("\n");
            sb.Append("  TwoFactorEnabled: ").Append(TwoFactorEnabled).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  Firstname: ").Append(Firstname).Append("\n");
            sb.Append("  EmailAddressVerified: ").Append(EmailAddressVerified).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  VarTimeZone: ").Append(VarTimeZone).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  TwoFactorType: ").Append(TwoFactorType).Append("\n");
            sb.Append("  MobilePhoneVerified: ").Append(MobilePhoneVerified).Append("\n");
            sb.Append("  PrimaryAccount: ").Append(PrimaryAccount).Append("\n");
            sb.Append("  Lastname: ").Append(Lastname).Append("\n");
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
            // MobilePhoneNumber (string) maxLength
            if (this.MobilePhoneNumber != null && this.MobilePhoneNumber.Length > 30)
            {
                yield return new ValidationResult("Invalid value for MobilePhoneNumber, length must be less than 30.", new [] { "MobilePhoneNumber" });
            }

            // EmailAddress (string) maxLength
            if (this.EmailAddress != null && this.EmailAddress.Length > 128)
            {
                yield return new ValidationResult("Invalid value for EmailAddress, length must be less than 128.", new [] { "EmailAddress" });
            }

            // Firstname (string) maxLength
            if (this.Firstname != null && this.Firstname.Length > 100)
            {
                yield return new ValidationResult("Invalid value for Firstname, length must be less than 100.", new [] { "Firstname" });
            }

            // Lastname (string) maxLength
            if (this.Lastname != null && this.Lastname.Length > 100)
            {
                yield return new ValidationResult("Invalid value for Lastname, length must be less than 100.", new [] { "Lastname" });
            }

            yield break;
        }
    }

}
