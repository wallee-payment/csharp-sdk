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
    /// MerchantPaymentChannelsDto
    /// </summary>
    [DataContract(Name = "MerchantPaymentChannelsDto")]
    public partial class MerchantPaymentChannelsDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantPaymentChannelsDto" /> class.
        /// </summary>
        /// <param name="salesChannels">The channels through which the merchant accepts payments..</param>
        /// <param name="expectedYearlyTurnoverCurrencyRange">The expected yearly turnover range for the merchant..</param>
        /// <param name="averageBasketValue">The expected average basket value for a transaction..</param>
        public MerchantPaymentChannelsDto(List<SalesChannel> salesChannels = default, string expectedYearlyTurnoverCurrencyRange = default, string averageBasketValue = default)
        {
            this.SalesChannels = salesChannels;
            this.ExpectedYearlyTurnoverCurrencyRange = expectedYearlyTurnoverCurrencyRange;
            this.AverageBasketValue = averageBasketValue;
        }

        /// <summary>
        /// The channels through which the merchant accepts payments.
        /// </summary>
        /// <value>The channels through which the merchant accepts payments.</value>
        [DataMember(Name = "salesChannels", EmitDefaultValue = false)]
        public List<SalesChannel> SalesChannels { get; set; }

        /// <summary>
        /// The expected yearly turnover range for the merchant.
        /// </summary>
        /// <value>The expected yearly turnover range for the merchant.</value>
        [DataMember(Name = "expectedYearlyTurnoverCurrencyRange", EmitDefaultValue = false)]
        public string ExpectedYearlyTurnoverCurrencyRange { get; set; }

        /// <summary>
        /// The expected average basket value for a transaction.
        /// </summary>
        /// <value>The expected average basket value for a transaction.</value>
        [DataMember(Name = "averageBasketValue", EmitDefaultValue = false)]
        public string AverageBasketValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MerchantPaymentChannelsDto {\n");
            sb.Append("  SalesChannels: ").Append(SalesChannels).Append("\n");
            sb.Append("  ExpectedYearlyTurnoverCurrencyRange: ").Append(ExpectedYearlyTurnoverCurrencyRange).Append("\n");
            sb.Append("  AverageBasketValue: ").Append(AverageBasketValue).Append("\n");
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
