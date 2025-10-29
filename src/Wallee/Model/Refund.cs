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
    /// A refund is a credit issued to the customer, which can be initiated either by the merchant or by the customer as a reversal.
    /// </summary>
    [DataContract(Name = "Refund")]
    public partial class Refund : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public RefundType? Type { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public RefundState? State { get; set; }

        /// <summary>
        /// Gets or Sets VarEnvironment
        /// </summary>
        [DataMember(Name = "environment", EmitDefaultValue = false)]
        public ModelEnvironment? VarEnvironment { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Refund" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="state">state.</param>
        /// <param name="varEnvironment">varEnvironment.</param>
        /// <param name="failureReason">failureReason.</param>
        /// <param name="transaction">transaction.</param>
        public Refund(RefundType? type = default(RefundType?), RefundState? state = default(RefundState?), ModelEnvironment? varEnvironment = default(ModelEnvironment?), FailureReason failureReason = default(FailureReason), Transaction transaction = default(Transaction))
        {
            this.Type = type;
            this.State = state;
            this.VarEnvironment = varEnvironment;
            this.FailureReason = failureReason;
            this.Transaction = transaction;
        }

        /// <summary>
        /// The total amount settled for the refund, factoring in reductions, taxes, and any additional applied fees.
        /// </summary>
        /// <value>The total amount settled for the refund, factoring in reductions, taxes, and any additional applied fees.</value>
        [DataMember(Name = "totalSettledAmount", EmitDefaultValue = false)]
        public decimal TotalSettledAmount { get; private set; }

        /// <summary>
        /// Returns false as TotalSettledAmount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTotalSettledAmount()
        {
            return false;
        }
        /// <summary>
        /// The reductions applied on the original transaction items, detailing specific adjustments associated with the refund.
        /// </summary>
        /// <value>The reductions applied on the original transaction items, detailing specific adjustments associated with the refund.</value>
        [DataMember(Name = "reductions", EmitDefaultValue = false)]
        public List<LineItemReduction> Reductions { get; private set; }

        /// <summary>
        /// Returns false as Reductions should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeReductions()
        {
            return false;
        }
        /// <summary>
        /// The original base line items from the transaction prior to the refund, serving as a reference for the refunded amounts.
        /// </summary>
        /// <value>The original base line items from the transaction prior to the refund, serving as a reference for the refunded amounts.</value>
        [DataMember(Name = "baseLineItems", EmitDefaultValue = false)]
        public List<LineItem> BaseLineItems { get; private set; }

        /// <summary>
        /// Returns false as BaseLineItems should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBaseLineItems()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the processing of the refund was started.
        /// </summary>
        /// <value>The date and time when the processing of the refund was started.</value>
        [DataMember(Name = "processingOn", EmitDefaultValue = false)]
        public DateTime ProcessingOn { get; private set; }

        /// <summary>
        /// Returns false as ProcessingOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProcessingOn()
        {
            return false;
        }
        /// <summary>
        /// The tax breakdown applied to the refund amount, helping with tax calculations or reporting.
        /// </summary>
        /// <value>The tax breakdown applied to the refund amount, helping with tax calculations or reporting.</value>
        [DataMember(Name = "taxes", EmitDefaultValue = false)]
        public List<Tax> Taxes { get; private set; }

        /// <summary>
        /// Returns false as Taxes should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTaxes()
        {
            return false;
        }
        /// <summary>
        /// The language that is linked to the object.
        /// </summary>
        /// <value>The language that is linked to the object.</value>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public string Language { get; private set; }

        /// <summary>
        /// Returns false as Language should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLanguage()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the object was created.
        /// </summary>
        /// <value>The date and time when the object was created.</value>
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
        /// The line items included in the refund, representing the reductions.
        /// </summary>
        /// <value>The line items included in the refund, representing the reductions.</value>
        [DataMember(Name = "lineItems", EmitDefaultValue = false)]
        public List<LineItem> LineItems { get; private set; }

        /// <summary>
        /// Returns false as LineItems should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLineItems()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the refund succeeded.
        /// </summary>
        /// <value>The date and time when the refund succeeded.</value>
        [DataMember(Name = "succeededOn", EmitDefaultValue = false)]
        public DateTime SucceededOn { get; private set; }

        /// <summary>
        /// Returns false as SucceededOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSucceededOn()
        {
            return false;
        }
        /// <summary>
        /// The line items from the original transaction, adjusted to reflect any reductions applied during the refund process.
        /// </summary>
        /// <value>The line items from the original transaction, adjusted to reflect any reductions applied during the refund process.</value>
        [DataMember(Name = "reducedLineItems", EmitDefaultValue = false)]
        public List<LineItem> ReducedLineItems { get; private set; }

        /// <summary>
        /// Returns false as ReducedLineItems should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeReducedLineItems()
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
        /// The merchant&#39;s reference used to identify the refund.
        /// </summary>
        /// <value>The merchant&#39;s reference used to identify the refund.</value>
        [DataMember(Name = "merchantReference", EmitDefaultValue = false)]
        public string MerchantReference { get; private set; }

        /// <summary>
        /// Returns false as MerchantReference should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMerchantReference()
        {
            return false;
        }
        /// <summary>
        /// The transaction completion that the refund belongs to.
        /// </summary>
        /// <value>The transaction completion that the refund belongs to.</value>
        [DataMember(Name = "completion", EmitDefaultValue = false)]
        public long Completion { get; private set; }

        /// <summary>
        /// Returns false as Completion should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCompletion()
        {
            return false;
        }
        /// <summary>
        /// The total monetary amount of the refund, representing the exact credit issued to the customer.
        /// </summary>
        /// <value>The total monetary amount of the refund, representing the exact credit issued to the customer.</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public decimal Amount { get; private set; }

        /// <summary>
        /// Returns false as Amount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAmount()
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
        /// A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.
        /// </summary>
        /// <value>A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.</value>
        [DataMember(Name = "externalId", EmitDefaultValue = false)]
        public string ExternalId { get; private set; }

        /// <summary>
        /// Returns false as ExternalId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeExternalId()
        {
            return false;
        }
        /// <summary>
        /// The time zone that this object is associated with.
        /// </summary>
        /// <value>The time zone that this object is associated with.</value>
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
        /// The labels providing additional information about the object.
        /// </summary>
        /// <value>The labels providing additional information about the object.</value>
        [DataMember(Name = "labels", EmitDefaultValue = false)]
        public List<Label> Labels { get; private set; }

        /// <summary>
        /// Returns false as Labels should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLabels()
        {
            return false;
        }
        /// <summary>
        /// The ID of the space this object belongs to.
        /// </summary>
        /// <value>The ID of the space this object belongs to.</value>
        [DataMember(Name = "linkedSpaceId", EmitDefaultValue = false)]
        public long LinkedSpaceId { get; private set; }

        /// <summary>
        /// Returns false as LinkedSpaceId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLinkedSpaceId()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the object will expire.
        /// </summary>
        /// <value>The date and time when the object will expire.</value>
        [DataMember(Name = "timeoutOn", EmitDefaultValue = false)]
        public DateTime TimeoutOn { get; private set; }

        /// <summary>
        /// Returns false as TimeoutOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTimeoutOn()
        {
            return false;
        }
        /// <summary>
        /// The ID of the user the refund was created by.
        /// </summary>
        /// <value>The ID of the user the refund was created by.</value>
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
        /// The date and time when the next update of the object&#39;s state is planned.
        /// </summary>
        /// <value>The date and time when the next update of the object&#39;s state is planned.</value>
        [DataMember(Name = "nextUpdateOn", EmitDefaultValue = false)]
        public DateTime NextUpdateOn { get; private set; }

        /// <summary>
        /// Returns false as NextUpdateOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNextUpdateOn()
        {
            return false;
        }
        /// <summary>
        /// An updated invoice reflecting adjustments made by the refund.
        /// </summary>
        /// <value>An updated invoice reflecting adjustments made by the refund.</value>
        [DataMember(Name = "updatedInvoice", EmitDefaultValue = false)]
        public long UpdatedInvoice { get; private set; }

        /// <summary>
        /// Returns false as UpdatedInvoice should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedInvoice()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets FailureReason
        /// </summary>
        [DataMember(Name = "failureReason", EmitDefaultValue = false)]
        public FailureReason FailureReason { get; set; }

        /// <summary>
        /// The sum of fees applied to the refund transaction, such as processing or service charges.
        /// </summary>
        /// <value>The sum of fees applied to the refund transaction, such as processing or service charges.</value>
        [DataMember(Name = "totalAppliedFees", EmitDefaultValue = false)]
        public decimal TotalAppliedFees { get; private set; }

        /// <summary>
        /// Returns false as TotalAppliedFees should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTotalAppliedFees()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the refund failed.
        /// </summary>
        /// <value>The date and time when the refund failed.</value>
        [DataMember(Name = "failedOn", EmitDefaultValue = false)]
        public DateTime FailedOn { get; private set; }

        /// <summary>
        /// Returns false as FailedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFailedOn()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Transaction
        /// </summary>
        [DataMember(Name = "transaction", EmitDefaultValue = false)]
        public Transaction Transaction { get; set; }

        /// <summary>
        /// The reference ID provided by the payment processor, used to trace the refund through the external payment system.
        /// </summary>
        /// <value>The reference ID provided by the payment processor, used to trace the refund through the external payment system.</value>
        [DataMember(Name = "processorReference", EmitDefaultValue = false)]
        public string ProcessorReference { get; private set; }

        /// <summary>
        /// Returns false as ProcessorReference should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProcessorReference()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Refund {\n");
            sb.Append("  TotalSettledAmount: ").Append(TotalSettledAmount).Append("\n");
            sb.Append("  Reductions: ").Append(Reductions).Append("\n");
            sb.Append("  BaseLineItems: ").Append(BaseLineItems).Append("\n");
            sb.Append("  ProcessingOn: ").Append(ProcessingOn).Append("\n");
            sb.Append("  Taxes: ").Append(Taxes).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  SucceededOn: ").Append(SucceededOn).Append("\n");
            sb.Append("  ReducedLineItems: ").Append(ReducedLineItems).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
            sb.Append("  Completion: ").Append(Completion).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  VarTimeZone: ").Append(VarTimeZone).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  TimeoutOn: ").Append(TimeoutOn).Append("\n");
            sb.Append("  VarEnvironment: ").Append(VarEnvironment).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  NextUpdateOn: ").Append(NextUpdateOn).Append("\n");
            sb.Append("  UpdatedInvoice: ").Append(UpdatedInvoice).Append("\n");
            sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
            sb.Append("  TotalAppliedFees: ").Append(TotalAppliedFees).Append("\n");
            sb.Append("  FailedOn: ").Append(FailedOn).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
            sb.Append("  ProcessorReference: ").Append(ProcessorReference).Append("\n");
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
            // MerchantReference (string) maxLength
            if (this.MerchantReference != null && this.MerchantReference.Length > 100)
            {
                yield return new ValidationResult("Invalid value for MerchantReference, length must be less than 100.", new [] { "MerchantReference" });
            }

            if (this.MerchantReference != null) {
                // MerchantReference (string) pattern
                Regex regexMerchantReference = new Regex(@"[	\x20-\x7e]*", RegexOptions.CultureInvariant);
                if (!regexMerchantReference.Match(this.MerchantReference).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantReference, must match a pattern of " + regexMerchantReference, new [] { "MerchantReference" });
                }
            }

            // ExternalId (string) maxLength
            if (this.ExternalId != null && this.ExternalId.Length > 100)
            {
                yield return new ValidationResult("Invalid value for ExternalId, length must be less than 100.", new [] { "ExternalId" });
            }

            // ExternalId (string) minLength
            if (this.ExternalId != null && this.ExternalId.Length < 1)
            {
                yield return new ValidationResult("Invalid value for ExternalId, length must be greater than 1.", new [] { "ExternalId" });
            }

            if (this.ExternalId != null) {
                // ExternalId (string) pattern
                Regex regexExternalId = new Regex(@"[	\x20-\x7e]*", RegexOptions.CultureInvariant);
                if (!regexExternalId.Match(this.ExternalId).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExternalId, must match a pattern of " + regexExternalId, new [] { "ExternalId" });
                }
            }

            // ProcessorReference (string) maxLength
            if (this.ProcessorReference != null && this.ProcessorReference.Length > 150)
            {
                yield return new ValidationResult("Invalid value for ProcessorReference, length must be less than 150.", new [] { "ProcessorReference" });
            }

            yield break;
        }
    }

}
