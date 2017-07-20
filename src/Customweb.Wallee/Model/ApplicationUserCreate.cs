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
    public partial class ApplicationUserCreate : AbstractApplicationUserUpdate,  IEquatable<ApplicationUserCreate>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationUserCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApplicationUserCreate() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationUserCreate" /> class.
        /// </summary>
        /// <param name="PrimaryAccount">The account that this user is associated with. The account owner will be able to manage this user. (required)</param>
        public ApplicationUserCreate(string Name = default(string), CreationEntityState? State = default(CreationEntityState?), long? PrimaryAccount = default(long?))
        {
            // to ensure "PrimaryAccount" is required (not null)
            if (PrimaryAccount == null)
            {
                throw new ArgumentNullException("PrimaryAccount is a required property for ApplicationUserCreate and cannot be null");
            }
            else
            {
                this.PrimaryAccount = PrimaryAccount;
            }
            this.Name = Name;
            this.State = State;
        }

        /// <summary>
        /// The account that this user is associated with. The account owner will be able to manage this user.
        /// </summary>
        /// <value>The account that this user is associated with. The account owner will be able to manage this user.</value>
        [DataMember(Name="primaryAccount", EmitDefaultValue=false)]
        public long? PrimaryAccount { get; set; }

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
            return this.Equals(obj as ApplicationUserCreate);
        }

        /// <summary>
        /// Returns true if ApplicationUserCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of ApplicationUserCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationUserCreate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.PrimaryAccount == other.PrimaryAccount ||
                    this.PrimaryAccount != null &&
                    this.PrimaryAccount.Equals(other.PrimaryAccount)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
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
                if (this.PrimaryAccount != null)
                {
                    hash = hash * 59 + this.PrimaryAccount.GetHashCode();
                }
                if (this.Name != null)
                {
                    hash = hash * 59 + this.Name.GetHashCode();
                }
                if (this.State != null)
                {
                    hash = hash * 59 + this.State.GetHashCode();
                }
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
