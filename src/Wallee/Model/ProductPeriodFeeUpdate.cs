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
    /// ProductPeriodFeeUpdate
    /// </summary>
    [DataContract(Name = "ProductPeriodFee.Update")]
    public partial class ProductPeriodFeeUpdate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductPeriodFeeUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProductPeriodFeeUpdate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductPeriodFeeUpdate" /> class.
        /// </summary>
        /// <param name="periodFee">The amount charged to the customer for each billing cycle during the term of a subscription..</param>
        /// <param name="component">The product component that the fee belongs to..</param>
        /// <param name="numberOfFreeTrialPeriods">The number of subscription billing cycles that count as a trial phase and during which no fees are charged..</param>
        /// <param name="name">The localized name of the fee that is displayed to the customer..</param>
        /// <param name="description">The localized description of the fee that is displayed to the customer..</param>
        /// <param name="varVersion">The version number indicates the version of the entity. The version is incremented whenever the entity is changed. (required).</param>
        /// <param name="ledgerEntryTitle">The localized title that be used on ledger entries and invoices..</param>
        public ProductPeriodFeeUpdate(List<PersistableCurrencyAmountUpdate> periodFee = default(List<PersistableCurrencyAmountUpdate>), long component = default(long), int numberOfFreeTrialPeriods = default(int), Dictionary<string, string> name = default(Dictionary<string, string>), Dictionary<string, string> description = default(Dictionary<string, string>), int varVersion = default(int), Dictionary<string, string> ledgerEntryTitle = default(Dictionary<string, string>))
        {
            this.VarVersion = varVersion;
            this.PeriodFee = periodFee;
            this.Component = component;
            this.NumberOfFreeTrialPeriods = numberOfFreeTrialPeriods;
            this.Name = name;
            this.Description = description;
            this.LedgerEntryTitle = ledgerEntryTitle;
        }

        /// <summary>
        /// The amount charged to the customer for each billing cycle during the term of a subscription.
        /// </summary>
        /// <value>The amount charged to the customer for each billing cycle during the term of a subscription.</value>
        [DataMember(Name = "periodFee", EmitDefaultValue = false)]
        public List<PersistableCurrencyAmountUpdate> PeriodFee { get; set; }

        /// <summary>
        /// The product component that the fee belongs to.
        /// </summary>
        /// <value>The product component that the fee belongs to.</value>
        [DataMember(Name = "component", EmitDefaultValue = false)]
        public long Component { get; set; }

        /// <summary>
        /// The number of subscription billing cycles that count as a trial phase and during which no fees are charged.
        /// </summary>
        /// <value>The number of subscription billing cycles that count as a trial phase and during which no fees are charged.</value>
        [DataMember(Name = "numberOfFreeTrialPeriods", EmitDefaultValue = false)]
        public int NumberOfFreeTrialPeriods { get; set; }

        /// <summary>
        /// The localized name of the fee that is displayed to the customer.
        /// </summary>
        /// <value>The localized name of the fee that is displayed to the customer.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public Dictionary<string, string> Name { get; set; }

        /// <summary>
        /// The localized description of the fee that is displayed to the customer.
        /// </summary>
        /// <value>The localized description of the fee that is displayed to the customer.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public Dictionary<string, string> Description { get; set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public int VarVersion { get; set; }

        /// <summary>
        /// The localized title that be used on ledger entries and invoices.
        /// </summary>
        /// <value>The localized title that be used on ledger entries and invoices.</value>
        [DataMember(Name = "ledgerEntryTitle", EmitDefaultValue = false)]
        public Dictionary<string, string> LedgerEntryTitle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductPeriodFeeUpdate {\n");
            sb.Append("  PeriodFee: ").Append(PeriodFee).Append("\n");
            sb.Append("  Component: ").Append(Component).Append("\n");
            sb.Append("  NumberOfFreeTrialPeriods: ").Append(NumberOfFreeTrialPeriods).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
