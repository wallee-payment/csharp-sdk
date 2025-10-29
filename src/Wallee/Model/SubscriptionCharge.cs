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
    /// The subscription charge represents a single charge carried out for a particular subscription.
    /// </summary>
    [DataContract(Name = "SubscriptionCharge")]
    public partial class SubscriptionCharge : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ProcessingType
        /// </summary>
        [DataMember(Name = "processingType", EmitDefaultValue = false)]
        public SubscriptionChargeProcessingType? ProcessingType { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public SubscriptionChargeType? Type { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public SubscriptionChargeState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionCharge" /> class.
        /// </summary>
        /// <param name="processingType">processingType.</param>
        /// <param name="subscription">subscription.</param>
        /// <param name="type">type.</param>
        /// <param name="state">state.</param>
        /// <param name="transaction">transaction.</param>
        public SubscriptionCharge(SubscriptionChargeProcessingType? processingType = default(SubscriptionChargeProcessingType?), Subscription subscription = default(Subscription), SubscriptionChargeType? type = default(SubscriptionChargeType?), SubscriptionChargeState? state = default(SubscriptionChargeState?), Transaction transaction = default(Transaction))
        {
            this.ProcessingType = processingType;
            this.Subscription = subscription;
            this.Type = type;
            this.State = state;
            this.Transaction = transaction;
        }

        /// <summary>
        /// The date and time when the charge was discarded.
        /// </summary>
        /// <value>The date and time when the charge was discarded.</value>
        [DataMember(Name = "discardedOn", EmitDefaultValue = false)]
        public DateTime DiscardedOn { get; private set; }

        /// <summary>
        /// Returns false as DiscardedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDiscardedOn()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the execution of the charge is planned.
        /// </summary>
        /// <value>The date and time when the execution of the charge is planned.</value>
        [DataMember(Name = "plannedExecutionDate", EmitDefaultValue = false)]
        public DateTime PlannedExecutionDate { get; private set; }

        /// <summary>
        /// Returns false as PlannedExecutionDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePlannedExecutionDate()
        {
            return false;
        }
        /// <summary>
        /// The ledger entries that belong to the charge.
        /// </summary>
        /// <value>The ledger entries that belong to the charge.</value>
        [DataMember(Name = "ledgerEntries", EmitDefaultValue = false)]
        public List<SubscriptionLedgerEntry> LedgerEntries { get; private set; }

        /// <summary>
        /// Returns false as LedgerEntries should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLedgerEntries()
        {
            return false;
        }
        /// <summary>
        /// The ID of the user the charge was discarded by.
        /// </summary>
        /// <value>The ID of the user the charge was discarded by.</value>
        [DataMember(Name = "discardedBy", EmitDefaultValue = false)]
        public long DiscardedBy { get; private set; }

        /// <summary>
        /// Returns false as DiscardedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDiscardedBy()
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
        /// The URL to redirect the customer back to after they successfully authenticated their payment.
        /// </summary>
        /// <value>The URL to redirect the customer back to after they successfully authenticated their payment.</value>
        [DataMember(Name = "successUrl", EmitDefaultValue = false)]
        public string SuccessUrl { get; private set; }

        /// <summary>
        /// Returns false as SuccessUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSuccessUrl()
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
        /// Gets or Sets Subscription
        /// </summary>
        [DataMember(Name = "subscription", EmitDefaultValue = false)]
        public Subscription Subscription { get; set; }

        /// <summary>
        /// The date and time when the charge was created.
        /// </summary>
        /// <value>The date and time when the charge was created.</value>
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
        /// The merchant&#39;s reference used to identify the charge.
        /// </summary>
        /// <value>The merchant&#39;s reference used to identify the charge.</value>
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
        /// The date and time when the charge failed.
        /// </summary>
        /// <value>The date and time when the charge failed.</value>
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
        /// The URL to redirect the customer back to after they canceled or failed to authenticated their payment.
        /// </summary>
        /// <value>The URL to redirect the customer back to after they canceled or failed to authenticated their payment.</value>
        [DataMember(Name = "failedUrl", EmitDefaultValue = false)]
        public string FailedUrl { get; private set; }

        /// <summary>
        /// Returns false as FailedUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFailedUrl()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the charge succeeded.
        /// </summary>
        /// <value>The date and time when the charge succeeded.</value>
        [DataMember(Name = "succeedOn", EmitDefaultValue = false)]
        public DateTime SucceedOn { get; private set; }

        /// <summary>
        /// Returns false as SucceedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSucceedOn()
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
            sb.Append("class SubscriptionCharge {\n");
            sb.Append("  DiscardedOn: ").Append(DiscardedOn).Append("\n");
            sb.Append("  PlannedExecutionDate: ").Append(PlannedExecutionDate).Append("\n");
            sb.Append("  ProcessingType: ").Append(ProcessingType).Append("\n");
            sb.Append("  LedgerEntries: ").Append(LedgerEntries).Append("\n");
            sb.Append("  DiscardedBy: ").Append(DiscardedBy).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  SuccessUrl: ").Append(SuccessUrl).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  FailedOn: ").Append(FailedOn).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
            sb.Append("  FailedUrl: ").Append(FailedUrl).Append("\n");
            sb.Append("  SucceedOn: ").Append(SucceedOn).Append("\n");
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
            // SuccessUrl (string) maxLength
            if (this.SuccessUrl != null && this.SuccessUrl.Length > 500)
            {
                yield return new ValidationResult("Invalid value for SuccessUrl, length must be less than 500.", new [] { "SuccessUrl" });
            }

            // SuccessUrl (string) minLength
            if (this.SuccessUrl != null && this.SuccessUrl.Length < 9)
            {
                yield return new ValidationResult("Invalid value for SuccessUrl, length must be greater than 9.", new [] { "SuccessUrl" });
            }

            // Reference (string) maxLength
            if (this.Reference != null && this.Reference.Length > 100)
            {
                yield return new ValidationResult("Invalid value for Reference, length must be less than 100.", new [] { "Reference" });
            }

            if (this.Reference != null) {
                // Reference (string) pattern
                Regex regexReference = new Regex(@"[	\x20-\x7e]*", RegexOptions.CultureInvariant);
                if (!regexReference.Match(this.Reference).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Reference, must match a pattern of " + regexReference, new [] { "Reference" });
                }
            }

            // FailedUrl (string) maxLength
            if (this.FailedUrl != null && this.FailedUrl.Length > 500)
            {
                yield return new ValidationResult("Invalid value for FailedUrl, length must be less than 500.", new [] { "FailedUrl" });
            }

            // FailedUrl (string) minLength
            if (this.FailedUrl != null && this.FailedUrl.Length < 9)
            {
                yield return new ValidationResult("Invalid value for FailedUrl, length must be greater than 9.", new [] { "FailedUrl" });
            }

            yield break;
        }
    }

}
