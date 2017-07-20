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
    /// Subscription
    /// </summary>
    [DataContract]
    public partial class SubscriptionPending : SubscriptionUpdate,  IEquatable<SubscriptionPending>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPending" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionPending() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPending" /> class.
        /// </summary>
        /// <param name="Reference">Reference</param>
        /// <param name="Subscriber">Subscriber</param>
        /// <param name="Token">Token</param>
        public SubscriptionPending(string Description = default(string), long? Id = default(long?), DateTime? PlannedTerminationDate = default(DateTime?), long? Token = default(long?), long? Subscriber = default(long?), long? Version = default(long?), string Reference = default(string))
        {
            this.Reference = Reference;
            this.Subscriber = Subscriber;
            this.Token = Token;
            this.Id = Id;
            this.Version = Version;
            this.Description = Description;
            this.PlannedTerminationDate = PlannedTerminationDate;
        }

        /// <summary>
        /// Reference
        /// </summary>
        /// <value>Reference</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// Subscriber
        /// </summary>
        /// <value>Subscriber</value>
        [DataMember(Name="subscriber", EmitDefaultValue=false)]
        public long? Subscriber { get; set; }

        /// <summary>
        /// Token
        /// </summary>
        /// <value>Token</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public long? Token { get; set; }

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
            return this.Equals(obj as SubscriptionPending);
        }

        /// <summary>
        /// Returns true if SubscriptionPending instances are equal
        /// </summary>
        /// <param name="other">Instance of SubscriptionPending to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionPending other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Reference == other.Reference ||
                    this.Reference != null &&
                    this.Reference.Equals(other.Reference)
                ) && 
                (
                    this.Subscriber == other.Subscriber ||
                    this.Subscriber != null &&
                    this.Subscriber.Equals(other.Subscriber)
                ) && 
                (
                    this.Token == other.Token ||
                    this.Token != null &&
                    this.Token.Equals(other.Token)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.PlannedTerminationDate == other.PlannedTerminationDate ||
                    this.PlannedTerminationDate != null &&
                    this.PlannedTerminationDate.Equals(other.PlannedTerminationDate)
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
                if (this.Reference != null)
                {
                    hash = hash * 59 + this.Reference.GetHashCode();
                }
                if (this.Subscriber != null)
                {
                    hash = hash * 59 + this.Subscriber.GetHashCode();
                }
                if (this.Token != null)
                {
                    hash = hash * 59 + this.Token.GetHashCode();
                }
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.Version != null)
                {
                    hash = hash * 59 + this.Version.GetHashCode();
                }
                if (this.Description != null)
                {
                    hash = hash * 59 + this.Description.GetHashCode();
                }
                if (this.PlannedTerminationDate != null)
                {
                    hash = hash * 59 + this.PlannedTerminationDate.GetHashCode();
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
