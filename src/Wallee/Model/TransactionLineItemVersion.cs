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
    /// TransactionLineItemVersion
    /// </summary>
    [DataContract(Name = "TransactionLineItemVersion")]
    public partial class TransactionLineItemVersion : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public TransactionLineItemVersionState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionLineItemVersion" /> class.
        /// </summary>
        /// <param name="failureReason">failureReason.</param>
        /// <param name="state">state.</param>
        /// <param name="transaction">transaction.</param>
        public TransactionLineItemVersion(FailureReason failureReason = default, TransactionLineItemVersionState? state = default, Transaction transaction = default)
        {
            this.FailureReason = failureReason;
            this.State = state;
            this.Transaction = transaction;
        }

        /// <summary>
        /// The total amount of the updated line items, including taxes.
        /// </summary>
        /// <value>The total amount of the updated line items, including taxes.</value>
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
        /// The date and time when the processing of the line item version was started.
        /// </summary>
        /// <value>The date and time when the processing of the line item version was started.</value>
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
        /// The line items that replace the original line items in the transaction.
        /// </summary>
        /// <value>The line items that replace the original line items in the transaction.</value>
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
        /// The date and time by when the line item version is expected to be processed.
        /// </summary>
        /// <value>The date and time by when the line item version is expected to be processed.</value>
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
        /// The ID of the user the line item version was created by.
        /// </summary>
        /// <value>The ID of the user the line item version was created by.</value>
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
        /// The date and time when the next update of the line item version&#39;s state is planned.
        /// </summary>
        /// <value>The date and time when the next update of the line item version&#39;s state is planned.</value>
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
        /// Gets or Sets FailureReason
        /// </summary>
        [DataMember(Name = "failureReason", EmitDefaultValue = false)]
        public FailureReason FailureReason { get; set; }

        /// <summary>
        /// The date and time when the line item version was processed successfully.
        /// </summary>
        /// <value>The date and time when the line item version was processed successfully.</value>
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
        /// The payment transaction this object is linked to.
        /// </summary>
        /// <value>The payment transaction this object is linked to.</value>
        [DataMember(Name = "linkedTransaction", EmitDefaultValue = false)]
        public long LinkedTransaction { get; private set; }

        /// <summary>
        /// Returns false as LinkedTransaction should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLinkedTransaction()
        {
            return false;
        }
        /// <summary>
        /// The portion of the total amount that corresponds to taxes.
        /// </summary>
        /// <value>The portion of the total amount that corresponds to taxes.</value>
        [DataMember(Name = "taxAmount", EmitDefaultValue = false)]
        public decimal TaxAmount { get; private set; }

        /// <summary>
        /// Returns false as TaxAmount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTaxAmount()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the processing of the line item version failed.
        /// </summary>
        /// <value>The date and time when the processing of the line item version failed.</value>
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionLineItemVersion {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  ProcessingOn: ").Append(ProcessingOn).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  SpaceViewId: ").Append(SpaceViewId).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  TimeoutOn: ").Append(TimeoutOn).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  NextUpdateOn: ").Append(NextUpdateOn).Append("\n");
            sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
            sb.Append("  SucceededOn: ").Append(SucceededOn).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  LinkedTransaction: ").Append(LinkedTransaction).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  FailedOn: ").Append(FailedOn).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
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
