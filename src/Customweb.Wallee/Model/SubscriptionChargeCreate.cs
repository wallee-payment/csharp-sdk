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
    /// The subscription charge represents a single charge carried out for a particular subscription.
    /// </summary>
    [DataContract]
    public partial class SubscriptionChargeCreate :  IEquatable<SubscriptionChargeCreate>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionChargeCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionChargeCreate() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionChargeCreate" /> class.
        /// </summary>
        /// <param name="ExternalId">The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity. (required)</param>
        /// <param name="FailedUrl">The user will be redirected to failed URL when the transaction could not be authorized or completed. In case no failed URL is specified a default failed page will be displayed.</param>
        /// <param name="PlannedExecutionDate">PlannedExecutionDate</param>
        /// <param name="ProcessingType">ProcessingType (required)</param>
        /// <param name="Reference">Reference</param>
        /// <param name="Subscription">The field subscription indicates the subscription to which the charge belongs to. (required)</param>
        /// <param name="SuccessUrl">The user will be redirected to success URL when the transaction could be authorized or completed. In case no success URL is specified a default success page will be displayed.</param>
        public SubscriptionChargeCreate(DateTime? PlannedExecutionDate = default(DateTime?), string SuccessUrl = default(string), SubscriptionChargeProcessingType? ProcessingType = default(SubscriptionChargeProcessingType?), long? Subscription = default(long?), string Reference = default(string), string ExternalId = default(string), string FailedUrl = default(string))
        {
            // to ensure "ExternalId" is required (not null)
            if (ExternalId == null)
            {
                throw new ArgumentNullException("ExternalId is a required property for SubscriptionChargeCreate and cannot be null");
            }
            else
            {
                this.ExternalId = ExternalId;
            }
            // to ensure "ProcessingType" is required (not null)
            if (ProcessingType == null)
            {
                throw new ArgumentNullException("ProcessingType is a required property for SubscriptionChargeCreate and cannot be null");
            }
            else
            {
                this.ProcessingType = ProcessingType;
            }
            // to ensure "Subscription" is required (not null)
            if (Subscription == null)
            {
                throw new ArgumentNullException("Subscription is a required property for SubscriptionChargeCreate and cannot be null");
            }
            else
            {
                this.Subscription = Subscription;
            }
            this.FailedUrl = FailedUrl;
            this.PlannedExecutionDate = PlannedExecutionDate;
            this.Reference = Reference;
            this.SuccessUrl = SuccessUrl;
        }

        /// <summary>
        /// The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity.
        /// </summary>
        /// <value>The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The user will be redirected to failed URL when the transaction could not be authorized or completed. In case no failed URL is specified a default failed page will be displayed.
        /// </summary>
        /// <value>The user will be redirected to failed URL when the transaction could not be authorized or completed. In case no failed URL is specified a default failed page will be displayed.</value>
        [DataMember(Name="failedUrl", EmitDefaultValue=false)]
        public string FailedUrl { get; set; }

        /// <summary>
        /// PlannedExecutionDate
        /// </summary>
        /// <value>PlannedExecutionDate</value>
        [DataMember(Name="plannedExecutionDate", EmitDefaultValue=false)]
        public DateTime? PlannedExecutionDate { get; set; }

        /// <summary>
        /// ProcessingType
        /// </summary>
        /// <value>ProcessingType</value>
        [DataMember(Name="processingType", EmitDefaultValue=false)]
        public SubscriptionChargeProcessingType? ProcessingType { get; set; }

        /// <summary>
        /// Reference
        /// </summary>
        /// <value>Reference</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// The field subscription indicates the subscription to which the charge belongs to.
        /// </summary>
        /// <value>The field subscription indicates the subscription to which the charge belongs to.</value>
        [DataMember(Name="subscription", EmitDefaultValue=false)]
        public long? Subscription { get; set; }

        /// <summary>
        /// The user will be redirected to success URL when the transaction could be authorized or completed. In case no success URL is specified a default success page will be displayed.
        /// </summary>
        /// <value>The user will be redirected to success URL when the transaction could be authorized or completed. In case no success URL is specified a default success page will be displayed.</value>
        [DataMember(Name="successUrl", EmitDefaultValue=false)]
        public string SuccessUrl { get; set; }

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
            return this.Equals(obj as SubscriptionChargeCreate);
        }

        /// <summary>
        /// Returns true if SubscriptionChargeCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of SubscriptionChargeCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionChargeCreate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.ExternalId == other.ExternalId ||
                    this.ExternalId != null &&
                    this.ExternalId.Equals(other.ExternalId)
                ) && 
                (
                    this.FailedUrl == other.FailedUrl ||
                    this.FailedUrl != null &&
                    this.FailedUrl.Equals(other.FailedUrl)
                ) && 
                (
                    this.PlannedExecutionDate == other.PlannedExecutionDate ||
                    this.PlannedExecutionDate != null &&
                    this.PlannedExecutionDate.Equals(other.PlannedExecutionDate)
                ) && 
                (
                    this.ProcessingType == other.ProcessingType ||
                    this.ProcessingType != null &&
                    this.ProcessingType.Equals(other.ProcessingType)
                ) && 
                (
                    this.Reference == other.Reference ||
                    this.Reference != null &&
                    this.Reference.Equals(other.Reference)
                ) && 
                (
                    this.Subscription == other.Subscription ||
                    this.Subscription != null &&
                    this.Subscription.Equals(other.Subscription)
                ) && 
                (
                    this.SuccessUrl == other.SuccessUrl ||
                    this.SuccessUrl != null &&
                    this.SuccessUrl.Equals(other.SuccessUrl)
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
                if (this.ExternalId != null)
                {
                    hash = hash * 59 + this.ExternalId.GetHashCode();
                }
                if (this.FailedUrl != null)
                {
                    hash = hash * 59 + this.FailedUrl.GetHashCode();
                }
                if (this.PlannedExecutionDate != null)
                {
                    hash = hash * 59 + this.PlannedExecutionDate.GetHashCode();
                }
                if (this.ProcessingType != null)
                {
                    hash = hash * 59 + this.ProcessingType.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hash = hash * 59 + this.Reference.GetHashCode();
                }
                if (this.Subscription != null)
                {
                    hash = hash * 59 + this.Subscription.GetHashCode();
                }
                if (this.SuccessUrl != null)
                {
                    hash = hash * 59 + this.SuccessUrl.GetHashCode();
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
