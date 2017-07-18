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
    /// Charge
    /// </summary>
    [DataContract]
    public partial class Charge : TransactionAwareEntity,  IEquatable<Charge>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Charge" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Charge()
        {
        }

        /// <summary>
        /// The date on which the charge was created on.
        /// </summary>
        /// <value>The date on which the charge was created on.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// FailureReason
        /// </summary>
        /// <value>FailureReason</value>
        [DataMember(Name="failureReason", EmitDefaultValue=false)]
        public FailureReason FailureReason { get; private set; }

        /// <summary>
        /// Language
        /// </summary>
        /// <value>Language</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; private set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// SpaceViewId
        /// </summary>
        /// <value>SpaceViewId</value>
        [DataMember(Name="spaceViewId", EmitDefaultValue=false)]
        public long? SpaceViewId { get; private set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public ChargeState? State { get; private set; }

        /// <summary>
        /// TimeoutOn
        /// </summary>
        /// <value>TimeoutOn</value>
        [DataMember(Name="timeoutOn", EmitDefaultValue=false)]
        public DateTime? TimeoutOn { get; private set; }

        /// <summary>
        /// Transaction
        /// </summary>
        /// <value>Transaction</value>
        [DataMember(Name="transaction", EmitDefaultValue=false)]
        public Transaction Transaction { get; private set; }

        /// <summary>
        /// Type
        /// </summary>
        /// <value>Type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public ChargeType? Type { get; private set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; private set; }

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
            return this.Equals(obj as Charge);
        }

        /// <summary>
        /// Returns true if Charge instances are equal
        /// </summary>
        /// <param name="other">Instance of Charge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Charge other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.CreatedOn == other.CreatedOn ||
                    this.CreatedOn != null &&
                    this.CreatedOn.Equals(other.CreatedOn)
                ) && 
                (
                    this.FailureReason == other.FailureReason ||
                    this.FailureReason != null &&
                    this.FailureReason.Equals(other.FailureReason)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.PlannedPurgeDate == other.PlannedPurgeDate ||
                    this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(other.PlannedPurgeDate)
                ) && 
                (
                    this.SpaceViewId == other.SpaceViewId ||
                    this.SpaceViewId != null &&
                    this.SpaceViewId.Equals(other.SpaceViewId)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.TimeoutOn == other.TimeoutOn ||
                    this.TimeoutOn != null &&
                    this.TimeoutOn.Equals(other.TimeoutOn)
                ) && 
                (
                    this.Transaction == other.Transaction ||
                    this.Transaction != null &&
                    this.Transaction.Equals(other.Transaction)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.LinkedSpaceId == other.LinkedSpaceId ||
                    this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(other.LinkedSpaceId)
                ) && 
                (
                    this.LinkedTransaction == other.LinkedTransaction ||
                    this.LinkedTransaction != null &&
                    this.LinkedTransaction.Equals(other.LinkedTransaction)
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
                if (this.CreatedOn != null)
                {
                    hash = hash * 59 + this.CreatedOn.GetHashCode();
                }
                if (this.FailureReason != null)
                {
                    hash = hash * 59 + this.FailureReason.GetHashCode();
                }
                if (this.Language != null)
                {
                    hash = hash * 59 + this.Language.GetHashCode();
                }
                if (this.PlannedPurgeDate != null)
                {
                    hash = hash * 59 + this.PlannedPurgeDate.GetHashCode();
                }
                if (this.SpaceViewId != null)
                {
                    hash = hash * 59 + this.SpaceViewId.GetHashCode();
                }
                if (this.State != null)
                {
                    hash = hash * 59 + this.State.GetHashCode();
                }
                if (this.TimeoutOn != null)
                {
                    hash = hash * 59 + this.TimeoutOn.GetHashCode();
                }
                if (this.Transaction != null)
                {
                    hash = hash * 59 + this.Transaction.GetHashCode();
                }
                if (this.Type != null)
                {
                    hash = hash * 59 + this.Type.GetHashCode();
                }
                if (this.Version != null)
                {
                    hash = hash * 59 + this.Version.GetHashCode();
                }
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.LinkedSpaceId != null)
                {
                    hash = hash * 59 + this.LinkedSpaceId.GetHashCode();
                }
                if (this.LinkedTransaction != null)
                {
                    hash = hash * 59 + this.LinkedTransaction.GetHashCode();
                }
                return hash;
            }
        }

    }

}
