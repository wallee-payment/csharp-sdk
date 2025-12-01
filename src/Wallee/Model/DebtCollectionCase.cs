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
    /// The debt collection case represents a try to collect the money from the debtor.
    /// </summary>
    [DataContract(Name = "DebtCollectionCase")]
    public partial class DebtCollectionCase : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public DebtCollectionCaseState? State { get; set; }

        /// <summary>
        /// Gets or Sets VarEnvironment
        /// </summary>
        [DataMember(Name = "environment", EmitDefaultValue = false)]
        public DebtCollectionEnvironment? VarEnvironment { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DebtCollectionCase" /> class.
        /// </summary>
        /// <param name="source">source.</param>
        /// <param name="state">state.</param>
        /// <param name="collectorConfiguration">collectorConfiguration.</param>
        /// <param name="varEnvironment">varEnvironment.</param>
        /// <param name="failureReason">failureReason.</param>
        /// <param name="billingAddress">billingAddress.</param>
        public DebtCollectionCase(DebtCollectionCaseSource source = default, DebtCollectionCaseState? state = default, DebtCollectorConfiguration collectorConfiguration = default, DebtCollectionEnvironment? varEnvironment = default, FailureReason failureReason = default, Address billingAddress = default)
        {
            this.Source = source;
            this.State = state;
            this.CollectorConfiguration = collectorConfiguration;
            this.VarEnvironment = varEnvironment;
            this.FailureReason = failureReason;
            this.BillingAddress = billingAddress;
        }

        /// <summary>
        /// The date and time when the contract with the debtor was signed.
        /// </summary>
        /// <value>The date and time when the contract with the debtor was signed.</value>
        [DataMember(Name = "contractDate", EmitDefaultValue = false)]
        public DateTime ContractDate { get; private set; }

        /// <summary>
        /// Returns false as ContractDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeContractDate()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the claim was due.
        /// </summary>
        /// <value>The date and time when the claim was due.</value>
        [DataMember(Name = "dueDate", EmitDefaultValue = false)]
        public DateTime DueDate { get; private set; }

        /// <summary>
        /// Returns false as DueDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDueDate()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the case was closed.
        /// </summary>
        /// <value>The date and time when the case was closed.</value>
        [DataMember(Name = "closedOn", EmitDefaultValue = false)]
        public DateTime ClosedOn { get; private set; }

        /// <summary>
        /// Returns false as ClosedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeClosedOn()
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
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public DebtCollectionCaseSource Source { get; set; }

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
        /// The line items that are subject of this debt collection case.
        /// </summary>
        /// <value>The line items that are subject of this debt collection case.</value>
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
        /// A unique reference to identify the debt collection case in communication with the debtor.
        /// </summary>
        /// <value>A unique reference to identify the debt collection case in communication with the debtor.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; private set; }

        /// <summary>
        /// Returns false as Reference should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeReference()
        {
            return false;
        }
        /// <summary>
        /// The three-letter code (ISO 4217 format) of the case&#39;s currency.
        /// </summary>
        /// <value>The three-letter code (ISO 4217 format) of the case&#39;s currency.</value>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; private set; }

        /// <summary>
        /// Returns false as Currency should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCurrency()
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
        /// The date and time when the processing of the case times out.
        /// </summary>
        /// <value>The date and time when the processing of the case times out.</value>
        [DataMember(Name = "processingTimeoutOn", EmitDefaultValue = false)]
        public DateTime ProcessingTimeoutOn { get; private set; }

        /// <summary>
        /// Returns false as ProcessingTimeoutOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProcessingTimeoutOn()
        {
            return false;
        }
        /// <summary>
        /// The sum of all unpaid item prices in the case&#39;s currency. The amount can no longer be changed once the case has been reviewed.
        /// </summary>
        /// <value>The sum of all unpaid item prices in the case&#39;s currency. The amount can no longer be changed once the case has been reviewed.</value>
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
        /// The ID of the user the case was created by.
        /// </summary>
        /// <value>The ID of the user the case was created by.</value>
        [DataMember(Name = "creator", EmitDefaultValue = false)]
        public long Creator { get; private set; }

        /// <summary>
        /// Returns false as Creator should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreator()
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
        /// Gets or Sets CollectorConfiguration
        /// </summary>
        [DataMember(Name = "collectorConfiguration", EmitDefaultValue = false)]
        public DebtCollectorConfiguration CollectorConfiguration { get; set; }

        /// <summary>
        /// The ID of the user the case was reviewed by.
        /// </summary>
        /// <value>The ID of the user the case was reviewed by.</value>
        [DataMember(Name = "reviewer", EmitDefaultValue = false)]
        public long Reviewer { get; private set; }

        /// <summary>
        /// Returns false as Reviewer should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeReviewer()
        {
            return false;
        }
        /// <summary>
        /// The ID of the space view this object is linked to.
        /// </summary>
        /// <value>The ID of the space view this object is linked to.</value>
        [DataMember(Name = "spaceViewId", EmitDefaultValue = false)]
        public long SpaceViewId { get; private set; }

        /// <summary>
        /// Returns false as SpaceViewId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSpaceViewId()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the review of the case was started.
        /// </summary>
        /// <value>The date and time when the review of the case was started.</value>
        [DataMember(Name = "reviewStartedOn", EmitDefaultValue = false)]
        public DateTime ReviewStartedOn { get; private set; }

        /// <summary>
        /// Returns false as ReviewStartedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeReviewStartedOn()
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
        /// The date and time when the processing of the case was started.
        /// </summary>
        /// <value>The date and time when the processing of the case was started.</value>
        [DataMember(Name = "processingStartedOn", EmitDefaultValue = false)]
        public DateTime ProcessingStartedOn { get; private set; }

        /// <summary>
        /// Returns false as ProcessingStartedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProcessingStartedOn()
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
        /// The date and time when the case was reviewed.
        /// </summary>
        /// <value>The date and time when the case was reviewed.</value>
        [DataMember(Name = "reviewedOn", EmitDefaultValue = false)]
        public DateTime ReviewedOn { get; private set; }

        /// <summary>
        /// Returns false as ReviewedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeReviewedOn()
        {
            return false;
        }
        /// <summary>
        /// The ID of the object that is the source of the case. Only defined if the case was created by an internal process.
        /// </summary>
        /// <value>The ID of the object that is the source of the case. Only defined if the case was created by an internal process.</value>
        [DataMember(Name = "sourceEntityId", EmitDefaultValue = false)]
        public long SourceEntityId { get; private set; }

        /// <summary>
        /// Returns false as SourceEntityId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSourceEntityId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets FailureReason
        /// </summary>
        [DataMember(Name = "failureReason", EmitDefaultValue = false)]
        public FailureReason FailureReason { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name = "billingAddress", EmitDefaultValue = false)]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// The date and time when the case failed.
        /// </summary>
        /// <value>The date and time when the case failed.</value>
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
        /// The date and time when the next attempt at processing the case will be made.
        /// </summary>
        /// <value>The date and time when the next attempt at processing the case will be made.</value>
        [DataMember(Name = "nextAttemptOn", EmitDefaultValue = false)]
        public DateTime NextAttemptOn { get; private set; }

        /// <summary>
        /// Returns false as NextAttemptOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNextAttemptOn()
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
            sb.Append("class DebtCollectionCase {\n");
            sb.Append("  ContractDate: ").Append(ContractDate).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  ClosedOn: ").Append(ClosedOn).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ProcessingTimeoutOn: ").Append(ProcessingTimeoutOn).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Creator: ").Append(Creator).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  CollectorConfiguration: ").Append(CollectorConfiguration).Append("\n");
            sb.Append("  Reviewer: ").Append(Reviewer).Append("\n");
            sb.Append("  SpaceViewId: ").Append(SpaceViewId).Append("\n");
            sb.Append("  ReviewStartedOn: ").Append(ReviewStartedOn).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  ProcessingStartedOn: ").Append(ProcessingStartedOn).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  VarEnvironment: ").Append(VarEnvironment).Append("\n");
            sb.Append("  ReviewedOn: ").Append(ReviewedOn).Append("\n");
            sb.Append("  SourceEntityId: ").Append(SourceEntityId).Append("\n");
            sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  FailedOn: ").Append(FailedOn).Append("\n");
            sb.Append("  NextAttemptOn: ").Append(NextAttemptOn).Append("\n");
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
            yield break;
        }
    }

}
