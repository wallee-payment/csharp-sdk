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
    /// The transaction invoice represents the invoice document for a particular transaction.
    /// </summary>
    [DataContract]
    public partial class TransactionInvoice : TransactionAwareEntity,  IEquatable<TransactionInvoice>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionInvoice" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public TransactionInvoice()
        {
        }

        /// <summary>
        /// Amount
        /// </summary>
        /// <value>Amount</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; private set; }

        /// <summary>
        /// Completion
        /// </summary>
        /// <value>Completion</value>
        [DataMember(Name="completion", EmitDefaultValue=false)]
        public TransactionCompletion Completion { get; private set; }

        /// <summary>
        /// The date on which the invoice is created on.
        /// </summary>
        /// <value>The date on which the invoice is created on.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// The date on which the invoice is marked as derecognized.
        /// </summary>
        /// <value>The date on which the invoice is marked as derecognized.</value>
        [DataMember(Name="derecognizedOn", EmitDefaultValue=false)]
        public DateTime? DerecognizedOn { get; private set; }

        /// <summary>
        /// The date on which the invoice should be paid on.
        /// </summary>
        /// <value>The date on which the invoice should be paid on.</value>
        [DataMember(Name="dueOn", EmitDefaultValue=false)]
        public DateTime? DueOn { get; private set; }

        /// <summary>
        /// Environment
        /// </summary>
        /// <value>Environment</value>
        [DataMember(Name="environment", EmitDefaultValue=false)]
        public Environment? Environment { get; private set; }

        /// <summary>
        /// ExternalId
        /// </summary>
        /// <value>ExternalId</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; private set; }

        /// <summary>
        /// Language
        /// </summary>
        /// <value>Language</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; private set; }

        /// <summary>
        /// LineItems
        /// </summary>
        /// <value>LineItems</value>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<LineItem> LineItems { get; private set; }

        /// <summary>
        /// MerchantReference
        /// </summary>
        /// <value>MerchantReference</value>
        [DataMember(Name="merchantReference", EmitDefaultValue=false)]
        public string MerchantReference { get; private set; }

        /// <summary>
        /// The outstanding amount indicates how much the buyer owes the merchant. A negative amount indicates that the invoice is overpaid.
        /// </summary>
        /// <value>The outstanding amount indicates how much the buyer owes the merchant. A negative amount indicates that the invoice is overpaid.</value>
        [DataMember(Name="outstandingAmount", EmitDefaultValue=false)]
        public decimal? OutstandingAmount { get; private set; }

        /// <summary>
        /// The date on which the invoice is marked as paid. Eventually this date lags behind of the actual paid date.
        /// </summary>
        /// <value>The date on which the invoice is marked as paid. Eventually this date lags behind of the actual paid date.</value>
        [DataMember(Name="paidOn", EmitDefaultValue=false)]
        public DateTime? PaidOn { get; private set; }

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
        public TransactionInvoiceState? State { get; private set; }

        /// <summary>
        /// TaxAmount
        /// </summary>
        /// <value>TaxAmount</value>
        [DataMember(Name="taxAmount", EmitDefaultValue=false)]
        public decimal? TaxAmount { get; private set; }

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
            return this.Equals(obj as TransactionInvoice);
        }

        /// <summary>
        /// Returns true if TransactionInvoice instances are equal
        /// </summary>
        /// <param name="other">Instance of TransactionInvoice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionInvoice other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) && 
                (
                    this.Completion == other.Completion ||
                    this.Completion != null &&
                    this.Completion.Equals(other.Completion)
                ) && 
                (
                    this.CreatedOn == other.CreatedOn ||
                    this.CreatedOn != null &&
                    this.CreatedOn.Equals(other.CreatedOn)
                ) && 
                (
                    this.DerecognizedOn == other.DerecognizedOn ||
                    this.DerecognizedOn != null &&
                    this.DerecognizedOn.Equals(other.DerecognizedOn)
                ) && 
                (
                    this.DueOn == other.DueOn ||
                    this.DueOn != null &&
                    this.DueOn.Equals(other.DueOn)
                ) && 
                (
                    this.Environment == other.Environment ||
                    this.Environment != null &&
                    this.Environment.Equals(other.Environment)
                ) && 
                (
                    this.ExternalId == other.ExternalId ||
                    this.ExternalId != null &&
                    this.ExternalId.Equals(other.ExternalId)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.LineItems == other.LineItems ||
                    this.LineItems != null &&
                    this.LineItems.SequenceEqual(other.LineItems)
                ) && 
                (
                    this.MerchantReference == other.MerchantReference ||
                    this.MerchantReference != null &&
                    this.MerchantReference.Equals(other.MerchantReference)
                ) && 
                (
                    this.OutstandingAmount == other.OutstandingAmount ||
                    this.OutstandingAmount != null &&
                    this.OutstandingAmount.Equals(other.OutstandingAmount)
                ) && 
                (
                    this.PaidOn == other.PaidOn ||
                    this.PaidOn != null &&
                    this.PaidOn.Equals(other.PaidOn)
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
                    this.TaxAmount == other.TaxAmount ||
                    this.TaxAmount != null &&
                    this.TaxAmount.Equals(other.TaxAmount)
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
                if (this.Amount != null)
                {
                    hash = hash * 59 + this.Amount.GetHashCode();
                }
                if (this.Completion != null)
                {
                    hash = hash * 59 + this.Completion.GetHashCode();
                }
                if (this.CreatedOn != null)
                {
                    hash = hash * 59 + this.CreatedOn.GetHashCode();
                }
                if (this.DerecognizedOn != null)
                {
                    hash = hash * 59 + this.DerecognizedOn.GetHashCode();
                }
                if (this.DueOn != null)
                {
                    hash = hash * 59 + this.DueOn.GetHashCode();
                }
                if (this.Environment != null)
                {
                    hash = hash * 59 + this.Environment.GetHashCode();
                }
                if (this.ExternalId != null)
                {
                    hash = hash * 59 + this.ExternalId.GetHashCode();
                }
                if (this.Language != null)
                {
                    hash = hash * 59 + this.Language.GetHashCode();
                }
                if (this.LineItems != null)
                {
                    hash = hash * 59 + this.LineItems.GetHashCode();
                }
                if (this.MerchantReference != null)
                {
                    hash = hash * 59 + this.MerchantReference.GetHashCode();
                }
                if (this.OutstandingAmount != null)
                {
                    hash = hash * 59 + this.OutstandingAmount.GetHashCode();
                }
                if (this.PaidOn != null)
                {
                    hash = hash * 59 + this.PaidOn.GetHashCode();
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
                if (this.TaxAmount != null)
                {
                    hash = hash * 59 + this.TaxAmount.GetHashCode();
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
