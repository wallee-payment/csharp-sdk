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
    /// Account
    /// </summary>
    [DataContract(Name = "Account")]
    public partial class Account : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public AccountType? Type { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public AccountState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        /// <param name="parentAccount">parentAccount.</param>
        /// <param name="type">type.</param>
        /// <param name="scope">scope.</param>
        /// <param name="state">state.</param>
        public Account(Account parentAccount = default, AccountType? type = default, Scope scope = default, AccountState? state = default)
        {
            this.ParentAccount = parentAccount;
            this.Type = type;
            this.Scope = scope;
            this.State = state;
        }

        /// <summary>
        /// Whether this account and all its parent accounts are active or restricted active.
        /// </summary>
        /// <value>Whether this account and all its parent accounts are active or restricted active.</value>
        [DataMember(Name = "activeOrRestrictedActive", EmitDefaultValue = true)]
        public bool ActiveOrRestrictedActive { get; private set; }

        /// <summary>
        /// Returns false as ActiveOrRestrictedActive should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeActiveOrRestrictedActive()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the account was deleted.
        /// </summary>
        /// <value>The date and time when the account was deleted.</value>
        [DataMember(Name = "deletedOn", EmitDefaultValue = false)]
        public DateTime DeletedOn { get; private set; }

        /// <summary>
        /// Returns false as DeletedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDeletedOn()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.
        /// </summary>
        /// <value>The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.</value>
        [DataMember(Name = "plannedPurgeDate", EmitDefaultValue = false)]
        public DateTime PlannedPurgeDate { get; private set; }

        /// <summary>
        /// Returns false as PlannedPurgeDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePlannedPurgeDate()
        {
            return false;
        }
        /// <summary>
        /// Whether this account and all its parent accounts are active.
        /// </summary>
        /// <value>Whether this account and all its parent accounts are active.</value>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active { get; private set; }

        /// <summary>
        /// Returns false as Active should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeActive()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ParentAccount
        /// </summary>
        [DataMember(Name = "parentAccount", EmitDefaultValue = false)]
        public Account ParentAccount { get; set; }

        /// <summary>
        /// The date and time when the account was created.
        /// </summary>
        /// <value>The date and time when the account was created.</value>
        [DataMember(Name = "createdOn", EmitDefaultValue = false)]
        public DateTime CreatedOn { get; private set; }

        /// <summary>
        /// Returns false as CreatedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedOn()
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
        /// The ID of a user the account was deleted by.
        /// </summary>
        /// <value>The ID of a user the account was deleted by.</value>
        [DataMember(Name = "deletedBy", EmitDefaultValue = false)]
        public long DeletedBy { get; private set; }

        /// <summary>
        /// Returns false as DeletedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDeletedBy()
        {
            return false;
        }
        /// <summary>
        /// Whether this account and all its parent accounts are active or restricted active. There is at least one account that is restricted active.
        /// </summary>
        /// <value>Whether this account and all its parent accounts are active or restricted active. There is at least one account that is restricted active.</value>
        [DataMember(Name = "restrictedActive", EmitDefaultValue = true)]
        public bool RestrictedActive { get; private set; }

        /// <summary>
        /// Returns false as RestrictedActive should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRestrictedActive()
        {
            return false;
        }
        /// <summary>
        /// The ID of the user the account was created by.
        /// </summary>
        /// <value>The ID of the user the account was created by.</value>
        [DataMember(Name = "createdBy", EmitDefaultValue = false)]
        public long CreatedBy { get; private set; }

        /// <summary>
        /// Returns false as CreatedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedBy()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name = "scope", EmitDefaultValue = false)]
        public Scope Scope { get; set; }

        /// <summary>
        /// The name used to identify the account.
        /// </summary>
        /// <value>The name used to identify the account.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; private set; }

        /// <summary>
        /// Returns false as Name should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeName()
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
        /// The number of sub-accounts that can be created within this account.
        /// </summary>
        /// <value>The number of sub-accounts that can be created within this account.</value>
        [DataMember(Name = "subaccountLimit", EmitDefaultValue = false)]
        public long SubaccountLimit { get; private set; }

        /// <summary>
        /// Returns false as SubaccountLimit should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSubaccountLimit()
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
            sb.Append("class Account {\n");
            sb.Append("  ActiveOrRestrictedActive: ").Append(ActiveOrRestrictedActive).Append("\n");
            sb.Append("  DeletedOn: ").Append(DeletedOn).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  ParentAccount: ").Append(ParentAccount).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  DeletedBy: ").Append(DeletedBy).Append("\n");
            sb.Append("  RestrictedActive: ").Append(RestrictedActive).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  SubaccountLimit: ").Append(SubaccountLimit).Append("\n");
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
