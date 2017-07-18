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
    /// Delivery Indication
    /// </summary>
    [DataContract]
    public partial class DeliveryIndication : TransactionAwareEntity,  IEquatable<DeliveryIndication>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryIndication" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public DeliveryIndication()
        {
        }

        /// <summary>
        /// AutomaticDecisionReason
        /// </summary>
        /// <value>AutomaticDecisionReason</value>
        [DataMember(Name="automaticDecisionReason", EmitDefaultValue=false)]
        public DeliveryIndicationDecisionReason AutomaticDecisionReason { get; private set; }

        /// <summary>
        /// AutomaticallyDecidedOn
        /// </summary>
        /// <value>AutomaticallyDecidedOn</value>
        [DataMember(Name="automaticallyDecidedOn", EmitDefaultValue=false)]
        public DateTime? AutomaticallyDecidedOn { get; private set; }

        /// <summary>
        /// The created on date indicates the date on which the entity was stored into the database.
        /// </summary>
        /// <value>The created on date indicates the date on which the entity was stored into the database.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// ManualDecisionTimeoutOn
        /// </summary>
        /// <value>ManualDecisionTimeoutOn</value>
        [DataMember(Name="manualDecisionTimeoutOn", EmitDefaultValue=false)]
        public DateTime? ManualDecisionTimeoutOn { get; private set; }

        /// <summary>
        /// ManuallyDecidedBy
        /// </summary>
        /// <value>ManuallyDecidedBy</value>
        [DataMember(Name="manuallyDecidedBy", EmitDefaultValue=false)]
        public long? ManuallyDecidedBy { get; private set; }

        /// <summary>
        /// ManuallyDecidedOn
        /// </summary>
        /// <value>ManuallyDecidedOn</value>
        [DataMember(Name="manuallyDecidedOn", EmitDefaultValue=false)]
        public DateTime? ManuallyDecidedOn { get; private set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public DeliveryIndicationState? State { get; private set; }

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
            return this.Equals(obj as DeliveryIndication);
        }

        /// <summary>
        /// Returns true if DeliveryIndication instances are equal
        /// </summary>
        /// <param name="other">Instance of DeliveryIndication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliveryIndication other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.AutomaticDecisionReason == other.AutomaticDecisionReason ||
                    this.AutomaticDecisionReason != null &&
                    this.AutomaticDecisionReason.Equals(other.AutomaticDecisionReason)
                ) && 
                (
                    this.AutomaticallyDecidedOn == other.AutomaticallyDecidedOn ||
                    this.AutomaticallyDecidedOn != null &&
                    this.AutomaticallyDecidedOn.Equals(other.AutomaticallyDecidedOn)
                ) && 
                (
                    this.CreatedOn == other.CreatedOn ||
                    this.CreatedOn != null &&
                    this.CreatedOn.Equals(other.CreatedOn)
                ) && 
                (
                    this.ManualDecisionTimeoutOn == other.ManualDecisionTimeoutOn ||
                    this.ManualDecisionTimeoutOn != null &&
                    this.ManualDecisionTimeoutOn.Equals(other.ManualDecisionTimeoutOn)
                ) && 
                (
                    this.ManuallyDecidedBy == other.ManuallyDecidedBy ||
                    this.ManuallyDecidedBy != null &&
                    this.ManuallyDecidedBy.Equals(other.ManuallyDecidedBy)
                ) && 
                (
                    this.ManuallyDecidedOn == other.ManuallyDecidedOn ||
                    this.ManuallyDecidedOn != null &&
                    this.ManuallyDecidedOn.Equals(other.ManuallyDecidedOn)
                ) && 
                (
                    this.PlannedPurgeDate == other.PlannedPurgeDate ||
                    this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(other.PlannedPurgeDate)
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
                if (this.AutomaticDecisionReason != null)
                {
                    hash = hash * 59 + this.AutomaticDecisionReason.GetHashCode();
                }
                if (this.AutomaticallyDecidedOn != null)
                {
                    hash = hash * 59 + this.AutomaticallyDecidedOn.GetHashCode();
                }
                if (this.CreatedOn != null)
                {
                    hash = hash * 59 + this.CreatedOn.GetHashCode();
                }
                if (this.ManualDecisionTimeoutOn != null)
                {
                    hash = hash * 59 + this.ManualDecisionTimeoutOn.GetHashCode();
                }
                if (this.ManuallyDecidedBy != null)
                {
                    hash = hash * 59 + this.ManuallyDecidedBy.GetHashCode();
                }
                if (this.ManuallyDecidedOn != null)
                {
                    hash = hash * 59 + this.ManuallyDecidedOn.GetHashCode();
                }
                if (this.PlannedPurgeDate != null)
                {
                    hash = hash * 59 + this.PlannedPurgeDate.GetHashCode();
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
