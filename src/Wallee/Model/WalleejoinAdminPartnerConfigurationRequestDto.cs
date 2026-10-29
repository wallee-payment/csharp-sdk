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
    /// WalleejoinAdminPartnerConfigurationRequestDto
    /// </summary>
    [DataContract(Name = "WalleejoinAdminPartnerConfigurationRequestDto")]
    public partial class WalleejoinAdminPartnerConfigurationRequestDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets PricingType
        /// </summary>
        [DataMember(Name = "pricingType", EmitDefaultValue = false)]
        public WalleejoinAdminPricingType? PricingType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WalleejoinAdminPartnerConfigurationRequestDto" /> class.
        /// </summary>
        /// <param name="allowedToSellScopeProducts">allowedToSellScopeProducts.</param>
        /// <param name="pricingProfileSellRateIds">pricingProfileSellRateIds.</param>
        /// <param name="revenueShare">revenueShare.</param>
        /// <param name="oneOffReferral">oneOffReferral.</param>
        /// <param name="partnerAccountId">partnerAccountId.</param>
        /// <param name="subscriptionProductIds">subscriptionProductIds.</param>
        /// <param name="pricingProfileBuyRateId">pricingProfileBuyRateId.</param>
        /// <param name="partnershipTypes">partnershipTypes.</param>
        /// <param name="pricingType">pricingType.</param>
        public WalleejoinAdminPartnerConfigurationRequestDto(bool allowedToSellScopeProducts = default, List<long> pricingProfileSellRateIds = default, decimal revenueShare = default, int oneOffReferral = default, long partnerAccountId = default, List<long> subscriptionProductIds = default, long pricingProfileBuyRateId = default, List<WalleejoinPartnershipType> partnershipTypes = default, WalleejoinAdminPricingType? pricingType = default)
        {
            this.AllowedToSellScopeProducts = allowedToSellScopeProducts;
            this.PricingProfileSellRateIds = pricingProfileSellRateIds;
            this.RevenueShare = revenueShare;
            this.OneOffReferral = oneOffReferral;
            this.PartnerAccountId = partnerAccountId;
            this.SubscriptionProductIds = subscriptionProductIds;
            this.PricingProfileBuyRateId = pricingProfileBuyRateId;
            this.PartnershipTypes = partnershipTypes;
            this.PricingType = pricingType;
        }

        /// <summary>
        /// Gets or Sets AllowedToSellScopeProducts
        /// </summary>
        [DataMember(Name = "allowedToSellScopeProducts", EmitDefaultValue = true)]
        public bool AllowedToSellScopeProducts { get; set; }

        /// <summary>
        /// Gets or Sets PricingProfileSellRateIds
        /// </summary>
        [DataMember(Name = "pricingProfileSellRateIds", EmitDefaultValue = false)]
        public List<long> PricingProfileSellRateIds { get; set; }

        /// <summary>
        /// Gets or Sets RevenueShare
        /// </summary>
        [DataMember(Name = "revenueShare", EmitDefaultValue = false)]
        public decimal RevenueShare { get; set; }

        /// <summary>
        /// Gets or Sets OneOffReferral
        /// </summary>
        [DataMember(Name = "oneOffReferral", EmitDefaultValue = false)]
        public int OneOffReferral { get; set; }

        /// <summary>
        /// Gets or Sets PartnerAccountId
        /// </summary>
        [DataMember(Name = "partnerAccountId", EmitDefaultValue = false)]
        public long PartnerAccountId { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionProductIds
        /// </summary>
        [DataMember(Name = "subscriptionProductIds", EmitDefaultValue = false)]
        public List<long> SubscriptionProductIds { get; set; }

        /// <summary>
        /// Gets or Sets PricingProfileBuyRateId
        /// </summary>
        [DataMember(Name = "pricingProfileBuyRateId", EmitDefaultValue = false)]
        public long PricingProfileBuyRateId { get; set; }

        /// <summary>
        /// Gets or Sets PartnershipTypes
        /// </summary>
        [DataMember(Name = "partnershipTypes", EmitDefaultValue = false)]
        public List<WalleejoinPartnershipType> PartnershipTypes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WalleejoinAdminPartnerConfigurationRequestDto {\n");
            sb.Append("  AllowedToSellScopeProducts: ").Append(AllowedToSellScopeProducts).Append("\n");
            sb.Append("  PricingProfileSellRateIds: ").Append(PricingProfileSellRateIds).Append("\n");
            sb.Append("  RevenueShare: ").Append(RevenueShare).Append("\n");
            sb.Append("  OneOffReferral: ").Append(OneOffReferral).Append("\n");
            sb.Append("  PartnerAccountId: ").Append(PartnerAccountId).Append("\n");
            sb.Append("  SubscriptionProductIds: ").Append(SubscriptionProductIds).Append("\n");
            sb.Append("  PricingProfileBuyRateId: ").Append(PricingProfileBuyRateId).Append("\n");
            sb.Append("  PartnershipTypes: ").Append(PartnershipTypes).Append("\n");
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
