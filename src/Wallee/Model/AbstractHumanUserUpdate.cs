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
    /// AbstractHumanUserUpdate
    /// </summary>
    [DataContract(Name = "Abstract.HumanUser.Update")]
    public partial class AbstractHumanUserUpdate : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public CreationEntityState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractHumanUserUpdate" /> class.
        /// </summary>
        /// <param name="mobilePhoneNumber">The user&#39;s mobile phone number..</param>
        /// <param name="twoFactorEnabled">Whether two-factor authentication is enabled for this user..</param>
        /// <param name="emailAddress">The user&#39;s email address..</param>
        /// <param name="firstname">The user&#39;s first name..</param>
        /// <param name="varTimeZone">The user&#39;s time zone. If none is specified, the one provided by the browser will be used..</param>
        /// <param name="language">The user&#39;s preferred language..</param>
        /// <param name="state">state.</param>
        /// <param name="lastname">The user&#39;s last name..</param>
        public AbstractHumanUserUpdate(string mobilePhoneNumber = default(string), bool twoFactorEnabled = default(bool), string emailAddress = default(string), string firstname = default(string), string varTimeZone = default(string), string language = default(string), CreationEntityState? state = default(CreationEntityState?), string lastname = default(string))
        {
            this.MobilePhoneNumber = mobilePhoneNumber;
            this.TwoFactorEnabled = twoFactorEnabled;
            this.EmailAddress = emailAddress;
            this.Firstname = firstname;
            this.VarTimeZone = varTimeZone;
            this.Language = language;
            this.State = state;
            this.Lastname = lastname;
        }

        /// <summary>
        /// The user&#39;s mobile phone number.
        /// </summary>
        /// <value>The user&#39;s mobile phone number.</value>
        [DataMember(Name = "mobilePhoneNumber", EmitDefaultValue = false)]
        public string MobilePhoneNumber { get; set; }

        /// <summary>
        /// Whether two-factor authentication is enabled for this user.
        /// </summary>
        /// <value>Whether two-factor authentication is enabled for this user.</value>
        [DataMember(Name = "twoFactorEnabled", EmitDefaultValue = true)]
        public bool TwoFactorEnabled { get; set; }

        /// <summary>
        /// The user&#39;s email address.
        /// </summary>
        /// <value>The user&#39;s email address.</value>
        [DataMember(Name = "emailAddress", EmitDefaultValue = false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The user&#39;s first name.
        /// </summary>
        /// <value>The user&#39;s first name.</value>
        [DataMember(Name = "firstname", EmitDefaultValue = false)]
        public string Firstname { get; set; }

        /// <summary>
        /// The user&#39;s time zone. If none is specified, the one provided by the browser will be used.
        /// </summary>
        /// <value>The user&#39;s time zone. If none is specified, the one provided by the browser will be used.</value>
        [DataMember(Name = "timeZone", EmitDefaultValue = false)]
        public string VarTimeZone { get; set; }

        /// <summary>
        /// The user&#39;s preferred language.
        /// </summary>
        /// <value>The user&#39;s preferred language.</value>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public string Language { get; set; }

        /// <summary>
        /// The user&#39;s last name.
        /// </summary>
        /// <value>The user&#39;s last name.</value>
        [DataMember(Name = "lastname", EmitDefaultValue = false)]
        public string Lastname { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AbstractHumanUserUpdate {\n");
            sb.Append("  MobilePhoneNumber: ").Append(MobilePhoneNumber).Append("\n");
            sb.Append("  TwoFactorEnabled: ").Append(TwoFactorEnabled).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  Firstname: ").Append(Firstname).Append("\n");
            sb.Append("  VarTimeZone: ").Append(VarTimeZone).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
