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
    /// WalleejoinAdminPartnerConfigurationResponseDto
    /// </summary>
    [DataContract(Name = "WalleejoinAdminPartnerConfigurationResponseDto")]
    public partial class WalleejoinAdminPartnerConfigurationResponseDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets PricingType
        /// </summary>
        [DataMember(Name = "pricingType", EmitDefaultValue = false)]
        public WalleejoinAdminPricingType? PricingType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WalleejoinAdminPartnerConfigurationResponseDto" /> class.
        /// </summary>
        /// <param name="pricingProfileSellRates">pricingProfileSellRates.</param>
        /// <param name="revenueShare">revenueShare.</param>
        /// <param name="subscriptionProducts">subscriptionProducts.</param>
        /// <param name="oneOffReferral">oneOffReferral.</param>
        /// <param name="pricingProfileBuyRate">pricingProfileBuyRate.</param>
        /// <param name="partnershipTypes">partnershipTypes.</param>
        /// <param name="partnerAccount">partnerAccount.</param>
        /// <param name="pricingType">pricingType.</param>
        public WalleejoinAdminPartnerConfigurationResponseDto(List<PaymentFacilitatorPricingProfileDto> pricingProfileSellRates = default, decimal revenueShare = default, List<SubscriptionProductDto> subscriptionProducts = default, int oneOffReferral = default, PaymentFacilitatorPricingProfileDto pricingProfileBuyRate = default, List<WalleejoinPartnershipType> partnershipTypes = default, long partnerAccount = default, WalleejoinAdminPricingType? pricingType = default)
        {
            this.PricingProfileSellRates = pricingProfileSellRates;
            this.RevenueShare = revenueShare;
            this.SubscriptionProducts = subscriptionProducts;
            this.OneOffReferral = oneOffReferral;
            this.PricingProfileBuyRate = pricingProfileBuyRate;
            this.PartnershipTypes = partnershipTypes;
            this.PartnerAccount = partnerAccount;
            this.PricingType = pricingType;
        }

        /// <summary>
        /// Gets or Sets PricingProfileSellRates
        /// </summary>
        [DataMember(Name = "pricingProfileSellRates", EmitDefaultValue = false)]
        public List<PaymentFacilitatorPricingProfileDto> PricingProfileSellRates { get; set; }

        /// <summary>
        /// Gets or Sets RevenueShare
        /// </summary>
        [DataMember(Name = "revenueShare", EmitDefaultValue = false)]
        public decimal RevenueShare { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionProducts
        /// </summary>
        [DataMember(Name = "subscriptionProducts", EmitDefaultValue = false)]
        public List<SubscriptionProductDto> SubscriptionProducts { get; set; }

        /// <summary>
        /// Gets or Sets OneOffReferral
        /// </summary>
        [DataMember(Name = "oneOffReferral", EmitDefaultValue = false)]
        public int OneOffReferral { get; set; }

        /// <summary>
        /// Gets or Sets PricingProfileBuyRate
        /// </summary>
        [DataMember(Name = "pricingProfileBuyRate", EmitDefaultValue = false)]
        public PaymentFacilitatorPricingProfileDto PricingProfileBuyRate { get; set; }

        /// <summary>
        /// Gets or Sets PartnershipTypes
        /// </summary>
        [DataMember(Name = "partnershipTypes", EmitDefaultValue = false)]
        public List<WalleejoinPartnershipType> PartnershipTypes { get; set; }

        /// <summary>
        /// Gets or Sets PartnerAccount
        /// </summary>
        [DataMember(Name = "partnerAccount", EmitDefaultValue = false)]
        public long PartnerAccount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WalleejoinAdminPartnerConfigurationResponseDto {\n");
            sb.Append("  PricingProfileSellRates: ").Append(PricingProfileSellRates).Append("\n");
            sb.Append("  RevenueShare: ").Append(RevenueShare).Append("\n");
            sb.Append("  SubscriptionProducts: ").Append(SubscriptionProducts).Append("\n");
            sb.Append("  OneOffReferral: ").Append(OneOffReferral).Append("\n");
            sb.Append("  PricingProfileBuyRate: ").Append(PricingProfileBuyRate).Append("\n");
            sb.Append("  PartnershipTypes: ").Append(PartnershipTypes).Append("\n");
            sb.Append("  PartnerAccount: ").Append(PartnerAccount).Append("\n");
            sb.Append("  PricingType: ").Append(PricingType).Append("\n");
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
