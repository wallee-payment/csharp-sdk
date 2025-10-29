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
    /// SingleSignOnUser
    /// </summary>
    [DataContract(Name = "SingleSignOnUser")]
    public partial class SingleSignOnUser : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SingleSignOnUser" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public SingleSignOnUser()
        {
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
        /// The single sign-on provider that this user belongs to.
        /// </summary>
        /// <value>The single sign-on provider that this user belongs to.</value>
        [DataMember(Name = "provider", EmitDefaultValue = false)]
        public long Provider { get; private set; }

        /// <summary>
        /// Returns false as Provider should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProvider()
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
            sb.Append("class SingleSignOnUser {\n");
            sb.Append("  Firstname: ").Append(Firstname).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  VarTimeZone: ").Append(VarTimeZone).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
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
