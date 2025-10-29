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
    /// RoleCreate
    /// </summary>
    [DataContract(Name = "Role.Create")]
    public partial class RoleCreate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RoleCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleCreate" /> class.
        /// </summary>
        /// <param name="permissions">The permissions granted to users with this role..</param>
        /// <param name="name">The name used to identify the role..</param>
        /// <param name="twoFactorRequired">Whether users with this role are required to use two-factor authentication..</param>
        /// <param name="account">The account the role belongs to. The role can only be assigned within this account. (required).</param>
        public RoleCreate(List<Permission> permissions = default(List<Permission>), Dictionary<string, string> name = default(Dictionary<string, string>), bool twoFactorRequired = default(bool), long account = default(long))
        {
            this.Account = account;
            this.Permissions = permissions;
            this.Name = name;
            this.TwoFactorRequired = twoFactorRequired;
        }

        /// <summary>
        /// The permissions granted to users with this role.
        /// </summary>
        /// <value>The permissions granted to users with this role.</value>
        [DataMember(Name = "permissions", EmitDefaultValue = false)]
        public List<Permission> Permissions { get; set; }

        /// <summary>
        /// The name used to identify the role.
        /// </summary>
        /// <value>The name used to identify the role.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public Dictionary<string, string> Name { get; set; }

        /// <summary>
        /// Whether users with this role are required to use two-factor authentication.
        /// </summary>
        /// <value>Whether users with this role are required to use two-factor authentication.</value>
        [DataMember(Name = "twoFactorRequired", EmitDefaultValue = true)]
        public bool TwoFactorRequired { get; set; }

        /// <summary>
        /// The account the role belongs to. The role can only be assigned within this account.
        /// </summary>
        /// <value>The account the role belongs to. The role can only be assigned within this account.</value>
        [DataMember(Name = "account", IsRequired = true, EmitDefaultValue = true)]
        public long Account { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RoleCreate {\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TwoFactorRequired: ").Append(TwoFactorRequired).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
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
