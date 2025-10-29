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
    /// ProductPeriodFee
    /// </summary>
    [DataContract(Name = "ProductPeriodFee")]
    public partial class ProductPeriodFee : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public ProductFeeType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductPeriodFee" /> class.
        /// </summary>
        /// <param name="component">component.</param>
        /// <param name="type">type.</param>
        public ProductPeriodFee(SubscriptionProductComponent component = default(SubscriptionProductComponent), ProductFeeType? type = default(ProductFeeType?))
        {
            this.Component = component;
            this.Type = type;
        }

        /// <summary>
        /// The amount charged to the customer for each billing cycle during the term of a subscription.
        /// </summary>
        /// <value>The amount charged to the customer for each billing cycle during the term of a subscription.</value>
        [DataMember(Name = "periodFee", EmitDefaultValue = false)]
        public List<PersistableCurrencyAmount> PeriodFee { get; private set; }

        /// <summary>
        /// Returns false as PeriodFee should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePeriodFee()
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
        /// Gets or Sets Component
        /// </summary>
        [DataMember(Name = "component", EmitDefaultValue = false)]
        public SubscriptionProductComponent Component { get; set; }

        /// <summary>
        /// The number of subscription billing cycles that count as a trial phase and during which no fees are charged.
        /// </summary>
        /// <value>The number of subscription billing cycles that count as a trial phase and during which no fees are charged.</value>
        [DataMember(Name = "numberOfFreeTrialPeriods", EmitDefaultValue = false)]
        public int NumberOfFreeTrialPeriods { get; private set; }

        /// <summary>
        /// Returns false as NumberOfFreeTrialPeriods should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNumberOfFreeTrialPeriods()
        {
            return false;
        }
        /// <summary>
        /// The localized name of the fee that is displayed to the customer.
        /// </summary>
        /// <value>The localized name of the fee that is displayed to the customer.</value>
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
        /// The localized description of the fee that is displayed to the customer.
        /// </summary>
        /// <value>The localized description of the fee that is displayed to the customer.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public Dictionary<string, string> Description { get; private set; }

        /// <summary>
        /// Returns false as Description should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDescription()
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
        /// The localized title that be used on ledger entries and invoices.
        /// </summary>
        /// <value>The localized title that be used on ledger entries and invoices.</value>
        [DataMember(Name = "ledgerEntryTitle", EmitDefaultValue = false)]
        public Dictionary<string, string> LedgerEntryTitle { get; private set; }

        /// <summary>
        /// Returns false as LedgerEntryTitle should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLedgerEntryTitle()
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
            sb.Append("class ProductPeriodFee {\n");
            sb.Append("  PeriodFee: ").Append(PeriodFee).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  Component: ").Append(Component).Append("\n");
            sb.Append("  NumberOfFreeTrialPeriods: ").Append(NumberOfFreeTrialPeriods).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  LedgerEntryTitle: ").Append(LedgerEntryTitle).Append("\n");
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
