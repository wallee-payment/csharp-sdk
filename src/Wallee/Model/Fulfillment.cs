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
    /// Fulfillment
    /// </summary>
    [DataContract(Name = "Fulfillment")]
    public partial class Fulfillment : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public FulfillmentState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Fulfillment" /> class.
        /// </summary>
        /// <param name="completion">completion.</param>
        /// <param name="state">state.</param>
        public Fulfillment(TransactionCompletion completion = default, FulfillmentState? state = default)
        {
            this.Completion = completion;
            this.State = state;
        }

        /// <summary>
        /// Gets or Sets Completion
        /// </summary>
        [DataMember(Name = "completion", EmitDefaultValue = false)]
        public TransactionCompletion Completion { get; set; }

        /// <summary>
        /// Gets or Sets OverriddenBy
        /// </summary>
        [DataMember(Name = "overriddenBy", EmitDefaultValue = false)]
        public long OverriddenBy { get; private set; }

        /// <summary>
        /// Returns false as OverriddenBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOverriddenBy()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets OverrideReason
        /// </summary>
        [DataMember(Name = "overrideReason", EmitDefaultValue = false)]
        public string OverrideReason { get; private set; }

        /// <summary>
        /// Returns false as OverrideReason should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOverrideReason()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; private set; }

        /// <summary>
        /// Returns false as Description should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDescription()
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
        /// Gets or Sets GrossAmount
        /// </summary>
        [DataMember(Name = "grossAmount", EmitDefaultValue = false)]
        public decimal GrossAmount { get; private set; }

        /// <summary>
        /// Returns false as GrossAmount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeGrossAmount()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CreatedOn
        /// </summary>
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
        /// Gets or Sets CreatedBy
        /// </summary>
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
        /// Gets or Sets FailureReason
        /// </summary>
        [DataMember(Name = "failureReason", EmitDefaultValue = false)]
        public string FailureReason { get; private set; }

        /// <summary>
        /// Returns false as FailureReason should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFailureReason()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets FulfilledBy
        /// </summary>
        [DataMember(Name = "fulfilledBy", EmitDefaultValue = false)]
        public long FulfilledBy { get; private set; }

        /// <summary>
        /// Returns false as FulfilledBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFulfilledBy()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets InStorePickup
        /// </summary>
        [DataMember(Name = "inStorePickup", EmitDefaultValue = true)]
        public bool InStorePickup { get; private set; }

        /// <summary>
        /// Returns false as InStorePickup should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeInStorePickup()
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
        /// Gets or Sets TrackingNumber
        /// </summary>
        [DataMember(Name = "trackingNumber", EmitDefaultValue = false)]
        public string TrackingNumber { get; private set; }

        /// <summary>
        /// Returns false as TrackingNumber should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTrackingNumber()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets FailedOn
        /// </summary>
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
        /// Gets or Sets OverriddenOn
        /// </summary>
        [DataMember(Name = "overriddenOn", EmitDefaultValue = false)]
        public DateTime OverriddenOn { get; private set; }

        /// <summary>
        /// Returns false as OverriddenOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOverriddenOn()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets FulfilledOn
        /// </summary>
        [DataMember(Name = "fulfilledOn", EmitDefaultValue = false)]
        public DateTime FulfilledOn { get; private set; }

        /// <summary>
        /// Returns false as FulfilledOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFulfilledOn()
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
            sb.Append("class Fulfillment {\n");
            sb.Append("  Completion: ").Append(Completion).Append("\n");
            sb.Append("  OverriddenBy: ").Append(OverriddenBy).Append("\n");
            sb.Append("  OverrideReason: ").Append(OverrideReason).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  GrossAmount: ").Append(GrossAmount).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
            sb.Append("  FulfilledBy: ").Append(FulfilledBy).Append("\n");
            sb.Append("  InStorePickup: ").Append(InStorePickup).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  LinkedTransaction: ").Append(LinkedTransaction).Append("\n");
            sb.Append("  TrackingNumber: ").Append(TrackingNumber).Append("\n");
            sb.Append("  FailedOn: ").Append(FailedOn).Append("\n");
            sb.Append("  OverriddenOn: ").Append(OverriddenOn).Append("\n");
            sb.Append("  FulfilledOn: ").Append(FulfilledOn).Append("\n");
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
