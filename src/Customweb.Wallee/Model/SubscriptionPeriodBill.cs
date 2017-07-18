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
    /// Subscription Period Bill
    /// </summary>
    [DataContract]
    public partial class SubscriptionPeriodBill :  IEquatable<SubscriptionPeriodBill>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPeriodBill" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public SubscriptionPeriodBill()
        {
        }

        /// <summary>
        /// CreatedOn
        /// </summary>
        /// <value>CreatedOn</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// EffectivePeriodEndDate
        /// </summary>
        /// <value>EffectivePeriodEndDate</value>
        [DataMember(Name="effectivePeriodEndDate", EmitDefaultValue=false)]
        public DateTime? EffectivePeriodEndDate { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// Language
        /// </summary>
        /// <value>Language</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; private set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// PeriodStartDate
        /// </summary>
        /// <value>PeriodStartDate</value>
        [DataMember(Name="periodStartDate", EmitDefaultValue=false)]
        public DateTime? PeriodStartDate { get; private set; }

        /// <summary>
        /// PlannedPeriodEndDate
        /// </summary>
        /// <value>PlannedPeriodEndDate</value>
        [DataMember(Name="plannedPeriodEndDate", EmitDefaultValue=false)]
        public DateTime? PlannedPeriodEndDate { get; private set; }

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
        public SubscriptionPeriodBillState? State { get; private set; }

        /// <summary>
        /// SubscriptionVersion
        /// </summary>
        /// <value>SubscriptionVersion</value>
        [DataMember(Name="subscriptionVersion", EmitDefaultValue=false)]
        public SubscriptionVersion SubscriptionVersion { get; private set; }

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
        public string ToJson()
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
            return this.Equals(obj as SubscriptionPeriodBill);
        }

        /// <summary>
        /// Returns true if SubscriptionPeriodBill instances are equal
        /// </summary>
        /// <param name="other">Instance of SubscriptionPeriodBill to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionPeriodBill other)
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
                    this.EffectivePeriodEndDate == other.EffectivePeriodEndDate ||
                    this.EffectivePeriodEndDate != null &&
                    this.EffectivePeriodEndDate.Equals(other.EffectivePeriodEndDate)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.LinkedSpaceId == other.LinkedSpaceId ||
                    this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(other.LinkedSpaceId)
                ) && 
                (
                    this.PeriodStartDate == other.PeriodStartDate ||
                    this.PeriodStartDate != null &&
                    this.PeriodStartDate.Equals(other.PeriodStartDate)
                ) && 
                (
                    this.PlannedPeriodEndDate == other.PlannedPeriodEndDate ||
                    this.PlannedPeriodEndDate != null &&
                    this.PlannedPeriodEndDate.Equals(other.PlannedPeriodEndDate)
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
                    this.SubscriptionVersion == other.SubscriptionVersion ||
                    this.SubscriptionVersion != null &&
                    this.SubscriptionVersion.Equals(other.SubscriptionVersion)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                if (this.EffectivePeriodEndDate != null)
                {
                    hash = hash * 59 + this.EffectivePeriodEndDate.GetHashCode();
                }
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.Language != null)
                {
                    hash = hash * 59 + this.Language.GetHashCode();
                }
                if (this.LinkedSpaceId != null)
                {
                    hash = hash * 59 + this.LinkedSpaceId.GetHashCode();
                }
                if (this.PeriodStartDate != null)
                {
                    hash = hash * 59 + this.PeriodStartDate.GetHashCode();
                }
                if (this.PlannedPeriodEndDate != null)
                {
                    hash = hash * 59 + this.PlannedPeriodEndDate.GetHashCode();
                }
                if (this.PlannedPurgeDate != null)
                {
                    hash = hash * 59 + this.PlannedPurgeDate.GetHashCode();
                }
                if (this.State != null)
                {
                    hash = hash * 59 + this.State.GetHashCode();
                }
                if (this.SubscriptionVersion != null)
                {
                    hash = hash * 59 + this.SubscriptionVersion.GetHashCode();
                }
                if (this.Version != null)
                {
                    hash = hash * 59 + this.Version.GetHashCode();
                }
                return hash;
            }
        }

    }

}
