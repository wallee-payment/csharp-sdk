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
    /// AccountCreate
    /// </summary>
    [DataContract(Name = "Account.Create")]
    public partial class AccountCreate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountCreate" /> class.
        /// </summary>
        /// <param name="name">The name used to identify the account..</param>
        /// <param name="subaccountLimit">The number of sub-accounts that can be created within this account..</param>
        /// <param name="scope">The scope that the account belongs to. (required).</param>
        /// <param name="parentAccount">The parent account responsible for administering this account..</param>
        public AccountCreate(string name = default(string), long subaccountLimit = default(long), long scope = default(long), long parentAccount = default(long))
        {
            this.Scope = scope;
            this.Name = name;
            this.SubaccountLimit = subaccountLimit;
            this.ParentAccount = parentAccount;
        }

        /// <summary>
        /// The name used to identify the account.
        /// </summary>
        /// <value>The name used to identify the account.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The number of sub-accounts that can be created within this account.
        /// </summary>
        /// <value>The number of sub-accounts that can be created within this account.</value>
        [DataMember(Name = "subaccountLimit", EmitDefaultValue = false)]
        public long SubaccountLimit { get; set; }

        /// <summary>
        /// The scope that the account belongs to.
        /// </summary>
        /// <value>The scope that the account belongs to.</value>
        [DataMember(Name = "scope", IsRequired = true, EmitDefaultValue = true)]
        public long Scope { get; set; }

        /// <summary>
        /// The parent account responsible for administering this account.
        /// </summary>
        /// <value>The parent account responsible for administering this account.</value>
        [DataMember(Name = "parentAccount", EmitDefaultValue = false)]
        public long ParentAccount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccountCreate {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SubaccountLimit: ").Append(SubaccountLimit).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  ParentAccount: ").Append(ParentAccount).Append("\n");
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 200)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 200.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 3)
            {
                yield return new ValidationResult("Invalid value for Name, length must be greater than 3.", new [] { "Name" });
            }

            yield break;
        }
    }

}
