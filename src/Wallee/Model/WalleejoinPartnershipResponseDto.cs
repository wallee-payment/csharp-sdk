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
    /// WalleejoinPartnershipResponseDto
    /// </summary>
    [DataContract(Name = "WalleejoinPartnershipResponseDto")]
    public partial class WalleejoinPartnershipResponseDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets PartnershipType
        /// </summary>
        [DataMember(Name = "partnershipType", EmitDefaultValue = false)]
        public WalleejoinPartnershipType? PartnershipType { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public WalleejoinPartnershipState? State { get; set; }

        /// <summary>
        /// Gets or Sets AllowedPricingType
        /// </summary>
        [DataMember(Name = "allowedPricingType", EmitDefaultValue = false)]
        public WalleejoinAdminPricingType? AllowedPricingType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WalleejoinPartnershipResponseDto" /> class.
        /// </summary>
        /// <param name="partnership">partnership.</param>
        /// <param name="merchantAccount">merchantAccount.</param>
        /// <param name="allowedToSellScopeProducts">allowedToSellScopeProducts.</param>
        /// <param name="pricingHistory">pricingHistory.</param>
        /// <param name="partnershipType">partnershipType.</param>
        /// <param name="state">state.</param>
        /// <param name="updatedOn">updatedOn.</param>
        /// <param name="allowedPricingType">allowedPricingType.</param>
        /// <param name="createdOn">createdOn.</param>
        /// <param name="subscriptionProductId">subscriptionProductId.</param>
        /// <param name="partnerAccount">partnerAccount.</param>
        public WalleejoinPartnershipResponseDto(WalleejoinPartnership partnership = default, long merchantAccount = default, bool allowedToSellScopeProducts = default, PricingHistoryDto pricingHistory = default, WalleejoinPartnershipType? partnershipType = default, WalleejoinPartnershipState? state = default, DateTime updatedOn = default, WalleejoinAdminPricingType? allowedPricingType = default, DateTime createdOn = default, long subscriptionProductId = default, long partnerAccount = default)
        {
            this.Partnership = partnership;
            this.MerchantAccount = merchantAccount;
            this.AllowedToSellScopeProducts = allowedToSellScopeProducts;
            this.PricingHistory = pricingHistory;
            this.PartnershipType = partnershipType;
            this.State = state;
            this.UpdatedOn = updatedOn;
            this.AllowedPricingType = allowedPricingType;
            this.CreatedOn = createdOn;
            this.SubscriptionProductId = subscriptionProductId;
            this.PartnerAccount = partnerAccount;
        }

        /// <summary>
        /// Gets or Sets Partnership
        /// </summary>
        [DataMember(Name = "partnership", EmitDefaultValue = false)]
        public WalleejoinPartnership Partnership { get; set; }

        /// <summary>
        /// Gets or Sets MerchantAccount
        /// </summary>
        [DataMember(Name = "merchantAccount", EmitDefaultValue = false)]
        public long MerchantAccount { get; set; }

        /// <summary>
        /// Gets or Sets AllowedToSellScopeProducts
        /// </summary>
        [DataMember(Name = "allowedToSellScopeProducts", EmitDefaultValue = true)]
        public bool AllowedToSellScopeProducts { get; set; }

        /// <summary>
        /// Gets or Sets PricingHistory
        /// </summary>
        [DataMember(Name = "pricingHistory", EmitDefaultValue = false)]
        public PricingHistoryDto PricingHistory { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedOn
        /// </summary>
        [DataMember(Name = "updatedOn", EmitDefaultValue = false)]
        public DateTime UpdatedOn { get; set; }

        /// <summary>
        /// Gets or Sets CreatedOn
        /// </summary>
        [DataMember(Name = "createdOn", EmitDefaultValue = false)]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionProductId
        /// </summary>
        [DataMember(Name = "subscriptionProductId", EmitDefaultValue = false)]
        public long SubscriptionProductId { get; set; }

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
            sb.Append("class WalleejoinPartnershipResponseDto {\n");
            sb.Append("  Partnership: ").Append(Partnership).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  AllowedToSellScopeProducts: ").Append(AllowedToSellScopeProducts).Append("\n");
            sb.Append("  PricingHistory: ").Append(PricingHistory).Append("\n");
            sb.Append("  PartnershipType: ").Append(PartnershipType).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  UpdatedOn: ").Append(UpdatedOn).Append("\n");
            sb.Append("  AllowedPricingType: ").Append(AllowedPricingType).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  SubscriptionProductId: ").Append(SubscriptionProductId).Append("\n");
            sb.Append("  PartnerAccount: ").Append(PartnerAccount).Append("\n");
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
