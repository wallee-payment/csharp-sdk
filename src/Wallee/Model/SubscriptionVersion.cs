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
    /// SubscriptionVersion
    /// </summary>
    [DataContract(Name = "SubscriptionVersion")]
    public partial class SubscriptionVersion : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public SubscriptionVersionState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionVersion" /> class.
        /// </summary>
        /// <param name="subscription">subscription.</param>
        /// <param name="productVersion">productVersion.</param>
        /// <param name="billingCycleModel">billingCycleModel.</param>
        /// <param name="state">state.</param>
        public SubscriptionVersion(Subscription subscription = default(Subscription), SubscriptionProductVersion productVersion = default(SubscriptionProductVersion), BillingCycleModel billingCycleModel = default(BillingCycleModel), SubscriptionVersionState? state = default(SubscriptionVersionState?))
        {
            this.Subscription = subscription;
            this.ProductVersion = productVersion;
            this.BillingCycleModel = billingCycleModel;
            this.State = state;
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
        /// The date and time when the subscription version was created.
        /// </summary>
        /// <value>The date and time when the subscription version was created.</value>
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
        /// The date and time when the subscription version was terminated.
        /// </summary>
        /// <value>The date and time when the subscription version was terminated.</value>
        [DataMember(Name = "terminatedOn", EmitDefaultValue = false)]
        public DateTime TerminatedOn { get; private set; }

        /// <summary>
        /// Returns false as TerminatedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTerminatedOn()
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
        /// The date and time when the termination of the subscription version was issued.
        /// </summary>
        /// <value>The date and time when the termination of the subscription version was issued.</value>
        [DataMember(Name = "terminationIssuedOn", EmitDefaultValue = false)]
        public DateTime TerminationIssuedOn { get; private set; }

        /// <summary>
        /// Returns false as TerminationIssuedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTerminationIssuedOn()
        {
            return false;
        }
        /// <summary>
        /// The configurations of the subscription&#39;s components.
        /// </summary>
        /// <value>The configurations of the subscription&#39;s components.</value>
        [DataMember(Name = "componentConfigurations", EmitDefaultValue = false)]
        public List<SubscriptionComponentConfiguration> ComponentConfigurations { get; private set; }

        /// <summary>
        /// Returns false as ComponentConfigurations should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeComponentConfigurations()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ProductVersion
        /// </summary>
        [DataMember(Name = "productVersion", EmitDefaultValue = false)]
        public SubscriptionProductVersion ProductVersion { get; set; }

        /// <summary>
        /// The date and time when the subscription version was activated.
        /// </summary>
        /// <value>The date and time when the subscription version was activated.</value>
        [DataMember(Name = "activatedOn", EmitDefaultValue = false)]
        public DateTime ActivatedOn { get; private set; }

        /// <summary>
        /// Returns false as ActivatedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeActivatedOn()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the termination of the subscription version started.
        /// </summary>
        /// <value>The date and time when the termination of the subscription version started.</value>
        [DataMember(Name = "terminatingOn", EmitDefaultValue = false)]
        public DateTime TerminatingOn { get; private set; }

        /// <summary>
        /// Returns false as TerminatingOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTerminatingOn()
        {
            return false;
        }
        /// <summary>
        /// The three-letter code (ISO 4217 format) of the currency used to invoice the customer. Must be one of the currencies supported by the product.
        /// </summary>
        /// <value>The three-letter code (ISO 4217 format) of the currency used to invoice the customer. Must be one of the currencies supported by the product.</value>
        [DataMember(Name = "billingCurrency", EmitDefaultValue = false)]
        public string BillingCurrency { get; private set; }

        /// <summary>
        /// Returns false as BillingCurrency should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBillingCurrency()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the last period is expected to end.
        /// </summary>
        /// <value>The date and time when the last period is expected to end.</value>
        [DataMember(Name = "expectedLastPeriodEnd", EmitDefaultValue = false)]
        public DateTime ExpectedLastPeriodEnd { get; private set; }

        /// <summary>
        /// Returns false as ExpectedLastPeriodEnd should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeExpectedLastPeriodEnd()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets BillingCycleModel
        /// </summary>
        [DataMember(Name = "billingCycleModel", EmitDefaultValue = false)]
        public BillingCycleModel BillingCycleModel { get; set; }

        /// <summary>
        /// The date and time when the termination of the subscription version is planned.
        /// </summary>
        /// <value>The date and time when the termination of the subscription version is planned.</value>
        [DataMember(Name = "plannedTerminationDate", EmitDefaultValue = false)]
        public DateTime PlannedTerminationDate { get; private set; }

        /// <summary>
        /// Returns false as PlannedTerminationDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePlannedTerminationDate()
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
        /// The date and time when the subscription version failed.
        /// </summary>
        /// <value>The date and time when the subscription version failed.</value>
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscriptionVersion {\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  TerminatedOn: ").Append(TerminatedOn).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  TerminationIssuedOn: ").Append(TerminationIssuedOn).Append("\n");
            sb.Append("  ComponentConfigurations: ").Append(ComponentConfigurations).Append("\n");
            sb.Append("  ProductVersion: ").Append(ProductVersion).Append("\n");
            sb.Append("  ActivatedOn: ").Append(ActivatedOn).Append("\n");
            sb.Append("  TerminatingOn: ").Append(TerminatingOn).Append("\n");
            sb.Append("  BillingCurrency: ").Append(BillingCurrency).Append("\n");
            sb.Append("  ExpectedLastPeriodEnd: ").Append(ExpectedLastPeriodEnd).Append("\n");
            sb.Append("  BillingCycleModel: ").Append(BillingCycleModel).Append("\n");
            sb.Append("  PlannedTerminationDate: ").Append(PlannedTerminationDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  FailedOn: ").Append(FailedOn).Append("\n");
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
