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
    /// SubscriptionProductVersionPending
    /// </summary>
    [DataContract(Name = "SubscriptionProductVersion.Pending")]
    public partial class SubscriptionProductVersionPending : IValidatableObject
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
        /// Initializes a new instance of the <see cref="SubscriptionProductVersionPending" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionProductVersionPending() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductVersionPending" /> class.
        /// </summary>
        /// <param name="enabledCurrencies">The three-letter codes (ISO 4217 format) of the currencies that the product version supports..</param>
        /// <param name="product">The product that the version belongs to..</param>
        /// <param name="taxCalculation">taxCalculation.</param>
        /// <param name="billingCycle">The recurring period of time, typically monthly or annually, for which a subscriber is charged..</param>
        /// <param name="defaultCurrency">The three-letter code (ISO 4217 format) of the product version&#39;s default currency..</param>
        /// <param name="name">The localized name of the product that is displayed to the customer..</param>
        /// <param name="minimalNumberOfPeriods">The minimum number of periods the subscription will run before it can be terminated..</param>
        /// <param name="comment">A comment that describes the product version and why it was created. It is not disclosed to the subscriber..</param>
        /// <param name="state">state.</param>
        /// <param name="numberOfNoticePeriods">The number of periods the subscription will keep running after its termination was requested..</param>
        /// <param name="varVersion">The version number indicates the version of the entity. The version is incremented whenever the entity is changed. (required).</param>
        public SubscriptionProductVersionPending(List<string> enabledCurrencies = default, long product = default, TaxCalculation? taxCalculation = default, string billingCycle = default, string defaultCurrency = default, Dictionary<string, string> name = default, int minimalNumberOfPeriods = default, string comment = default, SubscriptionProductVersionState? state = default, int numberOfNoticePeriods = default, int varVersion = default)
        {
            this.VarVersion = varVersion;
            this.EnabledCurrencies = enabledCurrencies;
            this.Product = product;
            this.TaxCalculation = taxCalculation;
            this.BillingCycle = billingCycle;
            this.DefaultCurrency = defaultCurrency;
            this.Name = name;
            this.MinimalNumberOfPeriods = minimalNumberOfPeriods;
            this.Comment = comment;
            this.State = state;
            this.NumberOfNoticePeriods = numberOfNoticePeriods;
        }

        /// <summary>
        /// The three-letter codes (ISO 4217 format) of the currencies that the product version supports.
        /// </summary>
        /// <value>The three-letter codes (ISO 4217 format) of the currencies that the product version supports.</value>
        [DataMember(Name = "enabledCurrencies", EmitDefaultValue = false)]
        public List<string> EnabledCurrencies { get; set; }

        /// <summary>
        /// The product that the version belongs to.
        /// </summary>
        /// <value>The product that the version belongs to.</value>
        [DataMember(Name = "product", EmitDefaultValue = false)]
        public long Product { get; set; }

        /// <summary>
        /// The recurring period of time, typically monthly or annually, for which a subscriber is charged.
        /// </summary>
        /// <value>The recurring period of time, typically monthly or annually, for which a subscriber is charged.</value>
        [DataMember(Name = "billingCycle", EmitDefaultValue = false)]
        public string BillingCycle { get; set; }

        /// <summary>
        /// The three-letter code (ISO 4217 format) of the product version&#39;s default currency.
        /// </summary>
        /// <value>The three-letter code (ISO 4217 format) of the product version&#39;s default currency.</value>
        [DataMember(Name = "defaultCurrency", EmitDefaultValue = false)]
        public string DefaultCurrency { get; set; }

        /// <summary>
        /// The localized name of the product that is displayed to the customer.
        /// </summary>
        /// <value>The localized name of the product that is displayed to the customer.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public Dictionary<string, string> Name { get; set; }

        /// <summary>
        /// The minimum number of periods the subscription will run before it can be terminated.
        /// </summary>
        /// <value>The minimum number of periods the subscription will run before it can be terminated.</value>
        [DataMember(Name = "minimalNumberOfPeriods", EmitDefaultValue = false)]
        public int MinimalNumberOfPeriods { get; set; }

        /// <summary>
        /// A comment that describes the product version and why it was created. It is not disclosed to the subscriber.
        /// </summary>
        /// <value>A comment that describes the product version and why it was created. It is not disclosed to the subscriber.</value>
        [DataMember(Name = "comment", EmitDefaultValue = false)]
        public string Comment { get; set; }

        /// <summary>
        /// The number of periods the subscription will keep running after its termination was requested.
        /// </summary>
        /// <value>The number of periods the subscription will keep running after its termination was requested.</value>
        [DataMember(Name = "numberOfNoticePeriods", EmitDefaultValue = false)]
        public int NumberOfNoticePeriods { get; set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public int VarVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscriptionProductVersionPending {\n");
            sb.Append("  EnabledCurrencies: ").Append(EnabledCurrencies).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  TaxCalculation: ").Append(TaxCalculation).Append("\n");
            sb.Append("  BillingCycle: ").Append(BillingCycle).Append("\n");
            sb.Append("  DefaultCurrency: ").Append(DefaultCurrency).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MinimalNumberOfPeriods: ").Append(MinimalNumberOfPeriods).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  NumberOfNoticePeriods: ").Append(NumberOfNoticePeriods).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
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
