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
    /// Application User
    /// </summary>
    [DataContract]
    public partial class ApplicationUserCreateWithMacKey : ApplicationUser,  IEquatable<ApplicationUserCreateWithMacKey>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationUserCreateWithMacKey" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ApplicationUserCreateWithMacKey()
        {
        }

        /// <summary>
        /// MacKey
        /// </summary>
        /// <value>MacKey</value>
        [DataMember(Name="macKey", EmitDefaultValue=false)]
        public string MacKey { get; private set; }

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
            return this.Equals(obj as ApplicationUserCreateWithMacKey);
        }

        /// <summary>
        /// Returns true if ApplicationUserCreateWithMacKey instances are equal
        /// </summary>
        /// <param name="other">Instance of ApplicationUserCreateWithMacKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationUserCreateWithMacKey other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.MacKey == other.MacKey ||
                    this.MacKey != null &&
                    this.MacKey.Equals(other.MacKey)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.PlannedPurgeDate == other.PlannedPurgeDate ||
                    this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(other.PlannedPurgeDate)
                ) && 
                (
                    this.Scope == other.Scope ||
                    this.Scope != null &&
                    this.Scope.Equals(other.Scope)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.UserType == other.UserType ||
                    this.UserType != null &&
                    this.UserType.Equals(other.UserType)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.PrimaryAccount == other.PrimaryAccount ||
                    this.PrimaryAccount != null &&
                    this.PrimaryAccount.Equals(other.PrimaryAccount)
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
                if (this.MacKey != null)
                {
                    hash = hash * 59 + this.MacKey.GetHashCode();
                }
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.PlannedPurgeDate != null)
                {
                    hash = hash * 59 + this.PlannedPurgeDate.GetHashCode();
                }
                if (this.Scope != null)
                {
                    hash = hash * 59 + this.Scope.GetHashCode();
                }
                if (this.State != null)
                {
                    hash = hash * 59 + this.State.GetHashCode();
                }
                if (this.UserType != null)
                {
                    hash = hash * 59 + this.UserType.GetHashCode();
                }
                if (this.Version != null)
                {
                    hash = hash * 59 + this.Version.GetHashCode();
                }
                if (this.Name != null)
                {
                    hash = hash * 59 + this.Name.GetHashCode();
                }
                if (this.PrimaryAccount != null)
                {
                    hash = hash * 59 + this.PrimaryAccount.GetHashCode();
                }
                return hash;
            }
        }

    }

}
