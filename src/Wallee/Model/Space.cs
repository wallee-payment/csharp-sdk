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
    /// Space
    /// </summary>
    [DataContract(Name = "Space")]
    public partial class Space : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public CreationEntityState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Space" /> class.
        /// </summary>
        /// <param name="database">database.</param>
        /// <param name="postalAddress">postalAddress.</param>
        /// <param name="state">state.</param>
        /// <param name="account">account.</param>
        public Space(TenantDatabase database = default, SpaceAddress postalAddress = default, CreationEntityState? state = default, Account account = default)
        {
            this.Database = database;
            this.PostalAddress = postalAddress;
            this.State = state;
            this.Account = account;
        }

        /// <summary>
        /// Whether this space and all its parent accounts are active or restricted active.
        /// </summary>
        /// <value>Whether this space and all its parent accounts are active or restricted active.</value>
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
        /// The date and time when the space was deleted.
        /// </summary>
        /// <value>The date and time when the space was deleted.</value>
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
        /// Whether this space and all its parent accounts are active.
        /// </summary>
        /// <value>Whether this space and all its parent accounts are active.</value>
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
        /// The time zone that is used to schedule and run background processes. This does not affect the formatting of dates in the user interface.
        /// </summary>
        /// <value>The time zone that is used to schedule and run background processes. This does not affect the formatting of dates in the user interface.</value>
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
        /// The date and time when the space was created.
        /// </summary>
        /// <value>The date and time when the space was created.</value>
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
        /// The currency that is used to display aggregated amounts in the space.
        /// </summary>
        /// <value>The currency that is used to display aggregated amounts in the space.</value>
        [DataMember(Name = "primaryCurrency", EmitDefaultValue = false)]
        public string PrimaryCurrency { get; private set; }

        /// <summary>
        /// Returns false as PrimaryCurrency should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePrimaryCurrency()
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
        /// The ID of the user the space was deleted by.
        /// </summary>
        /// <value>The ID of the user the space was deleted by.</value>
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
        /// The maximum number of API requests that are accepted within two minutes. This limit can only be changed with special privileges.
        /// </summary>
        /// <value>The maximum number of API requests that are accepted within two minutes. This limit can only be changed with special privileges.</value>
        [DataMember(Name = "requestLimit", EmitDefaultValue = false)]
        public long RequestLimit { get; private set; }

        /// <summary>
        /// Returns false as RequestLimit should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRequestLimit()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Database
        /// </summary>
        [DataMember(Name = "database", EmitDefaultValue = false)]
        public TenantDatabase Database { get; set; }

        /// <summary>
        /// Gets or Sets PostalAddress
        /// </summary>
        [DataMember(Name = "postalAddress", EmitDefaultValue = false)]
        public SpaceAddress PostalAddress { get; set; }

        /// <summary>
        /// Whether this space and all its parent accounts are active or restricted active. There is least one parent account that is restricted active.
        /// </summary>
        /// <value>Whether this space and all its parent accounts are active or restricted active. There is least one parent account that is restricted active.</value>
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
        /// The ID of the user the space was created by.
        /// </summary>
        /// <value>The ID of the user the space was created by.</value>
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
        /// The name used to identify the space.
        /// </summary>
        /// <value>The name used to identify the space.</value>
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
        /// The email address that will receive messages about technical issues and errors that occur in the space.
        /// </summary>
        /// <value>The email address that will receive messages about technical issues and errors that occur in the space.</value>
        [DataMember(Name = "technicalContactAddresses", EmitDefaultValue = false)]
        public List<string> TechnicalContactAddresses { get; private set; }

        /// <summary>
        /// Returns false as TechnicalContactAddresses should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTechnicalContactAddresses()
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
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name = "account", EmitDefaultValue = false)]
        public Account Account { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Space {\n");
            sb.Append("  ActiveOrRestrictedActive: ").Append(ActiveOrRestrictedActive).Append("\n");
            sb.Append("  DeletedOn: ").Append(DeletedOn).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  VarTimeZone: ").Append(VarTimeZone).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  PrimaryCurrency: ").Append(PrimaryCurrency).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  DeletedBy: ").Append(DeletedBy).Append("\n");
            sb.Append("  RequestLimit: ").Append(RequestLimit).Append("\n");
            sb.Append("  Database: ").Append(Database).Append("\n");
            sb.Append("  PostalAddress: ").Append(PostalAddress).Append("\n");
            sb.Append("  RestrictedActive: ").Append(RestrictedActive).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TechnicalContactAddresses: ").Append(TechnicalContactAddresses).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
