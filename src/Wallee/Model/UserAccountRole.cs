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
    /// UserAccountRole
    /// </summary>
    [DataContract(Name = "UserAccountRole")]
    public partial class UserAccountRole : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAccountRole" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public UserAccountRole()
        {
        }

        /// <summary>
        /// The role that is assigned to the user.
        /// </summary>
        /// <value>The role that is assigned to the user.</value>
        [DataMember(Name = "role", EmitDefaultValue = false)]
        public long Role { get; private set; }

        /// <summary>
        /// Returns false as Role should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRole()
        {
            return false;
        }
        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// Whether the role is assigned to the user in subaccounts only.
        /// </summary>
        /// <value>Whether the role is assigned to the user in subaccounts only.</value>
        [DataMember(Name = "appliesOnSubAccount", EmitDefaultValue = true)]
        public bool AppliesOnSubAccount { get; private set; }

        /// <summary>
        /// Returns false as AppliesOnSubAccount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAppliesOnSubAccount()
        {
            return false;
        }
        /// <summary>
        /// The user whose role this defines.
        /// </summary>
        /// <value>The user whose role this defines.</value>
        [DataMember(Name = "user", EmitDefaultValue = false)]
        public long User { get; private set; }

        /// <summary>
        /// Returns false as User should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUser()
        {
            return false;
        }
        /// <summary>
        /// The version is used for optimistic locking and incremented whenever the object is updated.
        /// </summary>
        /// <value>The version is used for optimistic locking and incremented whenever the object is updated.</value>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int VarVersion { get; private set; }

        /// <summary>
        /// Returns false as VarVersion should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVarVersion()
        {
            return false;
        }
        /// <summary>
        /// The account in which the role is assigned to the user.
        /// </summary>
        /// <value>The account in which the role is assigned to the user.</value>
        [DataMember(Name = "account", EmitDefaultValue = false)]
        public long Account { get; private set; }

        /// <summary>
        /// Returns false as Account should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAccount()
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
            sb.Append("class UserAccountRole {\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AppliesOnSubAccount: ").Append(AppliesOnSubAccount).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
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
