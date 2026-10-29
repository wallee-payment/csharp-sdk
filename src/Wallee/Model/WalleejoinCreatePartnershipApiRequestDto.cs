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
    /// WalleejoinCreatePartnershipApiRequestDto
    /// </summary>
    [DataContract(Name = "WalleejoinCreatePartnershipApiRequestDto")]
    public partial class WalleejoinCreatePartnershipApiRequestDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalleejoinCreatePartnershipApiRequestDto" /> class.
        /// </summary>
        /// <param name="emailMessage">emailMessage.</param>
        /// <param name="partnerAccountId">partnerAccountId.</param>
        /// <param name="pricingProfileSellRateId">pricingProfileSellRateId.</param>
        /// <param name="subscriptionProductId">subscriptionProductId.</param>
        /// <param name="merchantEmailAddress">merchantEmailAddress.</param>
        public WalleejoinCreatePartnershipApiRequestDto(string emailMessage = default, long partnerAccountId = default, long pricingProfileSellRateId = default, long subscriptionProductId = default, string merchantEmailAddress = default)
        {
            this.EmailMessage = emailMessage;
            this.PartnerAccountId = partnerAccountId;
            this.PricingProfileSellRateId = pricingProfileSellRateId;
            this.SubscriptionProductId = subscriptionProductId;
            this.MerchantEmailAddress = merchantEmailAddress;
        }

        /// <summary>
        /// Gets or Sets EmailMessage
        /// </summary>
        [DataMember(Name = "emailMessage", EmitDefaultValue = false)]
        public string EmailMessage { get; set; }

        /// <summary>
        /// Gets or Sets PartnerAccountId
        /// </summary>
        [DataMember(Name = "partnerAccountId", EmitDefaultValue = false)]
        public long PartnerAccountId { get; set; }

        /// <summary>
        /// Gets or Sets PricingProfileSellRateId
        /// </summary>
        [DataMember(Name = "pricingProfileSellRateId", EmitDefaultValue = false)]
        public long PricingProfileSellRateId { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionProductId
        /// </summary>
        [DataMember(Name = "subscriptionProductId", EmitDefaultValue = false)]
        public long SubscriptionProductId { get; set; }

        /// <summary>
        /// Gets or Sets MerchantEmailAddress
        /// </summary>
        [DataMember(Name = "merchantEmailAddress", EmitDefaultValue = false)]
        public string MerchantEmailAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WalleejoinCreatePartnershipApiRequestDto {\n");
            sb.Append("  EmailMessage: ").Append(EmailMessage).Append("\n");
            sb.Append("  PartnerAccountId: ").Append(PartnerAccountId).Append("\n");
            sb.Append("  PricingProfileSellRateId: ").Append(PricingProfileSellRateId).Append("\n");
            sb.Append("  SubscriptionProductId: ").Append(SubscriptionProductId).Append("\n");
            sb.Append("  MerchantEmailAddress: ").Append(MerchantEmailAddress).Append("\n");
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
