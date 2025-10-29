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
    /// DeliveryIndication
    /// </summary>
    [DataContract(Name = "DeliveryIndication")]
    public partial class DeliveryIndication : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public DeliveryIndicationState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryIndication" /> class.
        /// </summary>
        /// <param name="completion">completion.</param>
        /// <param name="automaticDecisionReason">automaticDecisionReason.</param>
        /// <param name="state">state.</param>
        /// <param name="transaction">transaction.</param>
        public DeliveryIndication(TransactionCompletion completion = default(TransactionCompletion), DeliveryIndicationDecisionReason automaticDecisionReason = default(DeliveryIndicationDecisionReason), DeliveryIndicationState? state = default(DeliveryIndicationState?), Transaction transaction = default(Transaction))
        {
            this.Completion = completion;
            this.AutomaticDecisionReason = automaticDecisionReason;
            this.State = state;
            this.Transaction = transaction;
        }

        /// <summary>
        /// Gets or Sets Completion
        /// </summary>
        [DataMember(Name = "completion", EmitDefaultValue = false)]
        public TransactionCompletion Completion { get; set; }

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
        /// Gets or Sets AutomaticDecisionReason
        /// </summary>
        [DataMember(Name = "automaticDecisionReason", EmitDefaultValue = false)]
        public DeliveryIndicationDecisionReason AutomaticDecisionReason { get; set; }

        /// <summary>
        /// The date and time when an automatic decision was made.
        /// </summary>
        /// <value>The date and time when an automatic decision was made.</value>
        [DataMember(Name = "automaticallyDecidedOn", EmitDefaultValue = false)]
        public DateTime AutomaticallyDecidedOn { get; private set; }

        /// <summary>
        /// Returns false as AutomaticallyDecidedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAutomaticallyDecidedOn()
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
        /// The ID of the user who manually decided the delivery indication&#39;s state.
        /// </summary>
        /// <value>The ID of the user who manually decided the delivery indication&#39;s state.</value>
        [DataMember(Name = "manuallyDecidedBy", EmitDefaultValue = false)]
        public long ManuallyDecidedBy { get; private set; }

        /// <summary>
        /// Returns false as ManuallyDecidedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeManuallyDecidedBy()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the delivery indication will expire.
        /// </summary>
        /// <value>The date and time when the delivery indication will expire.</value>
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
        /// The date and time by which a decision must be made before the system automatically proceeds according to the connector&#39;s predefined settings.
        /// </summary>
        /// <value>The date and time by which a decision must be made before the system automatically proceeds according to the connector&#39;s predefined settings.</value>
        [DataMember(Name = "manualDecisionTimeoutOn", EmitDefaultValue = false)]
        public DateTime ManualDecisionTimeoutOn { get; private set; }

        /// <summary>
        /// Returns false as ManualDecisionTimeoutOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeManualDecisionTimeoutOn()
        {
            return false;
        }
        /// <summary>
        /// The date and time when a manual decision was made.
        /// </summary>
        /// <value>The date and time when a manual decision was made.</value>
        [DataMember(Name = "manuallyDecidedOn", EmitDefaultValue = false)]
        public DateTime ManuallyDecidedOn { get; private set; }

        /// <summary>
        /// Returns false as ManuallyDecidedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeManuallyDecidedOn()
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
            sb.Append("class DeliveryIndication {\n");
            sb.Append("  Completion: ").Append(Completion).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  AutomaticDecisionReason: ").Append(AutomaticDecisionReason).Append("\n");
            sb.Append("  AutomaticallyDecidedOn: ").Append(AutomaticallyDecidedOn).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  ManuallyDecidedBy: ").Append(ManuallyDecidedBy).Append("\n");
            sb.Append("  TimeoutOn: ").Append(TimeoutOn).Append("\n");
            sb.Append("  ManualDecisionTimeoutOn: ").Append(ManualDecisionTimeoutOn).Append("\n");
            sb.Append("  ManuallyDecidedOn: ").Append(ManuallyDecidedOn).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  LinkedTransaction: ").Append(LinkedTransaction).Append("\n");
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
