/**
 * Wallee SDK Client
 *
 * This client allows to interact with the Wallee API.
 *
 * Wallee API: 1.0.0
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Account
    /// </summary>
    [DataContract]
    public partial class AccountCreate : AbstractAccountUpdate,  IEquatable<AccountCreate>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountCreate" /> class.
        /// </summary>
        /// <param name="ParentAccount">The account which is responsible for administering the account.</param>
        public AccountCreate(string Name = default(string), long? ParentAccount = default(long?), long? SubaccountLimit = default(long?))
        {
            this.ParentAccount = ParentAccount;
            this.Name = Name;
            this.SubaccountLimit = SubaccountLimit;
        }

        /// <summary>
        /// The account which is responsible for administering the account.
        /// </summary>
        /// <value>The account which is responsible for administering the account.</value>
        [DataMember(Name="parentAccount", EmitDefaultValue=false)]
        public long? ParentAccount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return this.ToJson();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public new string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            return this.Equals(obj as AccountCreate);
        }

        /// <summary>
        /// Returns true if AccountCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountCreate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.ParentAccount == other.ParentAccount ||
                    this.ParentAccount != null &&
                    this.ParentAccount.Equals(other.ParentAccount)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.SubaccountLimit == other.SubaccountLimit ||
                    this.SubaccountLimit != null &&
                    this.SubaccountLimit.Equals(other.SubaccountLimit)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                if (this.ParentAccount != null)
                {
                    hash = hash * 59 + this.ParentAccount.GetHashCode();
                }
                if (this.Name != null)
                {
                    hash = hash * 59 + this.Name.GetHashCode();
                }
                if (this.SubaccountLimit != null)
                {
                    hash = hash * 59 + this.SubaccountLimit.GetHashCode();
                }
                return hash;
            }
        }

    }

}
