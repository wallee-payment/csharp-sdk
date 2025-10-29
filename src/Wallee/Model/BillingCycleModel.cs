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
    /// BillingCycleModel
    /// </summary>
    [DataContract(Name = "BillingCycleModel")]
    public partial class BillingCycleModel : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Month
        /// </summary>
        [DataMember(Name = "month", EmitDefaultValue = false)]
        public DisplayableMonth? Month { get; set; }

        /// <summary>
        /// Gets or Sets Customization
        /// </summary>
        [DataMember(Name = "customization", EmitDefaultValue = false)]
        public BillingDayCustomization? Customization { get; set; }

        /// <summary>
        /// Gets or Sets WeeklyDay
        /// </summary>
        [DataMember(Name = "weeklyDay", EmitDefaultValue = false)]
        public DisplayableDayOfWeek? WeeklyDay { get; set; }

        /// <summary>
        /// Gets or Sets BillingCycleType
        /// </summary>
        [DataMember(Name = "billingCycleType", IsRequired = true, EmitDefaultValue = true)]
        public BillingCycleType BillingCycleType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingCycleModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BillingCycleModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingCycleModel" /> class.
        /// </summary>
        /// <param name="month">month.</param>
        /// <param name="customization">customization.</param>
        /// <param name="dayOfMonth">dayOfMonth.</param>
        /// <param name="weeklyDay">weeklyDay.</param>
        /// <param name="numberOfPeriods">Billing Cycle type multiplied by Number of Periods defines billing cycle duration, e.g. 3 months. Monthly types require 1-12; weekly and yearly types require 1-9 periods; and daily types require 1-30. (required).</param>
        /// <param name="billingCycleType">billingCycleType (required).</param>
        public BillingCycleModel(DisplayableMonth? month = default(DisplayableMonth?), BillingDayCustomization? customization = default(BillingDayCustomization?), int dayOfMonth = default(int), DisplayableDayOfWeek? weeklyDay = default(DisplayableDayOfWeek?), int numberOfPeriods = default(int), BillingCycleType billingCycleType = default(BillingCycleType))
        {
            this.NumberOfPeriods = numberOfPeriods;
            this.BillingCycleType = billingCycleType;
            this.Month = month;
            this.Customization = customization;
            this.DayOfMonth = dayOfMonth;
            this.WeeklyDay = weeklyDay;
        }

        /// <summary>
        /// Gets or Sets DayOfMonth
        /// </summary>
        [DataMember(Name = "dayOfMonth", EmitDefaultValue = false)]
        public int DayOfMonth { get; set; }

        /// <summary>
        /// Billing Cycle type multiplied by Number of Periods defines billing cycle duration, e.g. 3 months. Monthly types require 1-12; weekly and yearly types require 1-9 periods; and daily types require 1-30.
        /// </summary>
        /// <value>Billing Cycle type multiplied by Number of Periods defines billing cycle duration, e.g. 3 months. Monthly types require 1-12; weekly and yearly types require 1-9 periods; and daily types require 1-30.</value>
        [DataMember(Name = "numberOfPeriods", IsRequired = true, EmitDefaultValue = true)]
        public int NumberOfPeriods { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BillingCycleModel {\n");
            sb.Append("  Month: ").Append(Month).Append("\n");
            sb.Append("  Customization: ").Append(Customization).Append("\n");
            sb.Append("  DayOfMonth: ").Append(DayOfMonth).Append("\n");
            sb.Append("  WeeklyDay: ").Append(WeeklyDay).Append("\n");
            sb.Append("  NumberOfPeriods: ").Append(NumberOfPeriods).Append("\n");
            sb.Append("  BillingCycleType: ").Append(BillingCycleType).Append("\n");
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
            // NumberOfPeriods (int) minimum
            if (this.NumberOfPeriods < (int)1)
            {
                yield return new ValidationResult("Invalid value for NumberOfPeriods, must be a value greater than or equal to 1.", new [] { "NumberOfPeriods" });
            }

            yield break;
        }
    }

}
