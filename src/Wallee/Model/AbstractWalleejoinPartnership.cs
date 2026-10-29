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
    /// AbstractWalleejoinPartnership
    /// </summary>
    [DataContract(Name = "Abstract.WalleejoinPartnership")]
    public partial class AbstractWalleejoinPartnership : IValidatableObject
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
        /// Initializes a new instance of the <see cref="AbstractWalleejoinPartnership" /> class.
        /// </summary>
        /// <param name="terminatedOn">The date and time when the partnership was terminated..</param>
        /// <param name="pricingProfileSellRate">pricingProfileSellRate.</param>
        /// <param name="activatedOn">The date and time when the partnership was activated..</param>
        /// <param name="merchantAccount">The ID of the merchant account..</param>
        /// <param name="invitationEmailAddress">The email address the merchant was invited with..</param>
        /// <param name="partnershipType">partnershipType.</param>
        /// <param name="state">state.</param>
        /// <param name="subscriptionProductId">The ID of the product..</param>
        /// <param name="partnerAccount">The ID of the partner account..</param>
        public AbstractWalleejoinPartnership(DateTime terminatedOn = default, Object pricingProfileSellRate = default, DateTime activatedOn = default, long merchantAccount = default, string invitationEmailAddress = default, WalleejoinPartnershipType? partnershipType = default, WalleejoinPartnershipState? state = default, long subscriptionProductId = default, long partnerAccount = default)
        {
            this.TerminatedOn = terminatedOn;
            this.PricingProfileSellRate = pricingProfileSellRate;
            this.ActivatedOn = activatedOn;
            this.MerchantAccount = merchantAccount;
            this.InvitationEmailAddress = invitationEmailAddress;
            this.PartnershipType = partnershipType;
            this.State = state;
            this.SubscriptionProductId = subscriptionProductId;
            this.PartnerAccount = partnerAccount;
        }

        /// <summary>
        /// The date and time when the partnership was terminated.
        /// </summary>
        /// <value>The date and time when the partnership was terminated.</value>
        [DataMember(Name = "terminatedOn", EmitDefaultValue = false)]
        public DateTime TerminatedOn { get; set; }

        /// <summary>
        /// Gets or Sets PricingProfileSellRate
        /// </summary>
        [DataMember(Name = "pricingProfileSellRate", EmitDefaultValue = false)]
        public Object PricingProfileSellRate { get; set; }

        /// <summary>
        /// The date and time when the partnership was activated.
        /// </summary>
        /// <value>The date and time when the partnership was activated.</value>
        [DataMember(Name = "activatedOn", EmitDefaultValue = false)]
        public DateTime ActivatedOn { get; set; }

        /// <summary>
        /// The ID of the merchant account.
        /// </summary>
        /// <value>The ID of the merchant account.</value>
        [DataMember(Name = "merchantAccount", EmitDefaultValue = false)]
        public long MerchantAccount { get; set; }

        /// <summary>
        /// The email address the merchant was invited with.
        /// </summary>
        /// <value>The email address the merchant was invited with.</value>
        [DataMember(Name = "invitationEmailAddress", EmitDefaultValue = false)]
        public string InvitationEmailAddress { get; set; }

        /// <summary>
        /// The ID of the product.
        /// </summary>
        /// <value>The ID of the product.</value>
        [DataMember(Name = "subscriptionProductId", EmitDefaultValue = false)]
        public long SubscriptionProductId { get; set; }

        /// <summary>
        /// The ID of the partner account.
        /// </summary>
        /// <value>The ID of the partner account.</value>
        [DataMember(Name = "partnerAccount", EmitDefaultValue = false)]
        public long PartnerAccount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AbstractWalleejoinPartnership {\n");
            sb.Append("  TerminatedOn: ").Append(TerminatedOn).Append("\n");
            sb.Append("  PricingProfileSellRate: ").Append(PricingProfileSellRate).Append("\n");
            sb.Append("  ActivatedOn: ").Append(ActivatedOn).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  InvitationEmailAddress: ").Append(InvitationEmailAddress).Append("\n");
            sb.Append("  PartnershipType: ").Append(PartnershipType).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
