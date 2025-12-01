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
    /// SubscriptionProductVersion
    /// </summary>
    [DataContract(Name = "SubscriptionProductVersion")]
    public partial class SubscriptionProductVersion : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets TaxCalculation
        /// </summary>
        [DataMember(Name = "taxCalculation", EmitDefaultValue = false)]
        public TaxCalculation? TaxCalculation { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public SubscriptionProductVersionState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductVersion" /> class.
        /// </summary>
        /// <param name="product">product.</param>
        /// <param name="taxCalculation">taxCalculation.</param>
        /// <param name="billingCycleModel">billingCycleModel.</param>
        /// <param name="state">state.</param>
        public SubscriptionProductVersion(SubscriptionProduct product = default, TaxCalculation? taxCalculation = default, BillingCycleModel billingCycleModel = default, SubscriptionProductVersionState? state = default)
        {
            this.Product = product;
            this.TaxCalculation = taxCalculation;
            this.BillingCycleModel = billingCycleModel;
            this.State = state;
        }

        /// <summary>
        /// The date and time when the product version was retired.
        /// </summary>
        /// <value>The date and time when the product version was retired.</value>
        [DataMember(Name = "retiringFinishedOn", EmitDefaultValue = false)]
        public DateTime RetiringFinishedOn { get; private set; }

        /// <summary>
        /// Returns false as RetiringFinishedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRetiringFinishedOn()
        {
            return false;
        }
        /// <summary>
        /// The three-letter codes (ISO 4217 format) of the currencies that the product version supports.
        /// </summary>
        /// <value>The three-letter codes (ISO 4217 format) of the currencies that the product version supports.</value>
        [DataMember(Name = "enabledCurrencies", EmitDefaultValue = false)]
        public List<string> EnabledCurrencies { get; private set; }

        /// <summary>
        /// Returns false as EnabledCurrencies should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEnabledCurrencies()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Product
        /// </summary>
        [DataMember(Name = "product", EmitDefaultValue = false)]
        public SubscriptionProduct Product { get; set; }

        /// <summary>
        /// The date and time when the product version&#39;s retirement was started.
        /// </summary>
        /// <value>The date and time when the product version&#39;s retirement was started.</value>
        [DataMember(Name = "retiringStartedOn", EmitDefaultValue = false)]
        public DateTime RetiringStartedOn { get; private set; }

        /// <summary>
        /// Returns false as RetiringStartedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRetiringStartedOn()
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
        /// The date and time when the product version was created.
        /// </summary>
        /// <value>The date and time when the product version was created.</value>
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
        /// The reference used to identify the product version.
        /// </summary>
        /// <value>The reference used to identify the product version.</value>
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
        /// The date and time when the product version was activated.
        /// </summary>
        /// <value>The date and time when the product version was activated.</value>
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
        /// The recurring period of time, typically monthly or annually, for which a subscriber is charged.
        /// </summary>
        /// <value>The recurring period of time, typically monthly or annually, for which a subscriber is charged.</value>
        [DataMember(Name = "billingCycle", EmitDefaultValue = false)]
        public string BillingCycle { get; private set; }

        /// <summary>
        /// Returns false as BillingCycle should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBillingCycle()
        {
            return false;
        }
        /// <summary>
        /// The three-letter code (ISO 4217 format) of the product version&#39;s default currency.
        /// </summary>
        /// <value>The three-letter code (ISO 4217 format) of the product version&#39;s default currency.</value>
        [DataMember(Name = "defaultCurrency", EmitDefaultValue = false)]
        public string DefaultCurrency { get; private set; }

        /// <summary>
        /// Returns false as DefaultCurrency should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDefaultCurrency()
        {
            return false;
        }
        /// <summary>
        /// The localized name of the product that is displayed to the customer.
        /// </summary>
        /// <value>The localized name of the product that is displayed to the customer.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public Dictionary<string, string> Name { get; private set; }

        /// <summary>
        /// Returns false as Name should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeName()
        {
            return false;
        }
        /// <summary>
        /// The minimum number of periods the subscription will run before it can be terminated.
        /// </summary>
        /// <value>The minimum number of periods the subscription will run before it can be terminated.</value>
        [DataMember(Name = "minimalNumberOfPeriods", EmitDefaultValue = false)]
        public int MinimalNumberOfPeriods { get; private set; }

        /// <summary>
        /// Returns false as MinimalNumberOfPeriods should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMinimalNumberOfPeriods()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the product version was made obsolete.
        /// </summary>
        /// <value>The date and time when the product version was made obsolete.</value>
        [DataMember(Name = "obsoletedOn", EmitDefaultValue = false)]
        public DateTime ObsoletedOn { get; private set; }

        /// <summary>
        /// Returns false as ObsoletedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeObsoletedOn()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets BillingCycleModel
        /// </summary>
        [DataMember(Name = "billingCycleModel", EmitDefaultValue = false)]
        public BillingCycleModel BillingCycleModel { get; set; }

        /// <summary>
        /// A comment that describes the product version and why it was created. It is not disclosed to the subscriber.
        /// </summary>
        /// <value>A comment that describes the product version and why it was created. It is not disclosed to the subscriber.</value>
        [DataMember(Name = "comment", EmitDefaultValue = false)]
        public string Comment { get; private set; }

        /// <summary>
        /// Returns false as Comment should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeComment()
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
        /// Whenever a new version of a product is created, the number is increased and assigned.
        /// </summary>
        /// <value>Whenever a new version of a product is created, the number is increased and assigned.</value>
        [DataMember(Name = "incrementNumber", EmitDefaultValue = false)]
        public int IncrementNumber { get; private set; }

        /// <summary>
        /// Returns false as IncrementNumber should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIncrementNumber()
        {
            return false;
        }
        /// <summary>
        /// The number of periods the subscription will keep running after its termination was requested.
        /// </summary>
        /// <value>The number of periods the subscription will keep running after its termination was requested.</value>
        [DataMember(Name = "numberOfNoticePeriods", EmitDefaultValue = false)]
        public int NumberOfNoticePeriods { get; private set; }

        /// <summary>
        /// Returns false as NumberOfNoticePeriods should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNumberOfNoticePeriods()
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
            sb.Append("class SubscriptionProductVersion {\n");
            sb.Append("  RetiringFinishedOn: ").Append(RetiringFinishedOn).Append("\n");
            sb.Append("  EnabledCurrencies: ").Append(EnabledCurrencies).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  RetiringStartedOn: ").Append(RetiringStartedOn).Append("\n");
            sb.Append("  TaxCalculation: ").Append(TaxCalculation).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  ActivatedOn: ").Append(ActivatedOn).Append("\n");
            sb.Append("  BillingCycle: ").Append(BillingCycle).Append("\n");
            sb.Append("  DefaultCurrency: ").Append(DefaultCurrency).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MinimalNumberOfPeriods: ").Append(MinimalNumberOfPeriods).Append("\n");
            sb.Append("  ObsoletedOn: ").Append(ObsoletedOn).Append("\n");
            sb.Append("  BillingCycleModel: ").Append(BillingCycleModel).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IncrementNumber: ").Append(IncrementNumber).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  NumberOfNoticePeriods: ").Append(NumberOfNoticePeriods).Append("\n");
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
            // Reference (string) maxLength
            if (this.Reference != null && this.Reference.Length > 125)
            {
                yield return new ValidationResult("Invalid value for Reference, length must be less than 125.", new [] { "Reference" });
            }

            yield break;
        }
    }

}
