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
    /// MerchantEcommerceDetailsDto
    /// </summary>
    [DataContract(Name = "MerchantEcommerceDetailsDto")]
    public partial class MerchantEcommerceDetailsDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets DeliveryDestination
        /// </summary>
        [DataMember(Name = "deliveryDestination", EmitDefaultValue = false)]
        public DeliveryDestination? DeliveryDestination { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedInternationalTurnoverRange
        /// </summary>
        [DataMember(Name = "expectedInternationalTurnoverRange", EmitDefaultValue = false)]
        public RefundPercentageRange? ExpectedInternationalTurnoverRange { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryDaysRange
        /// </summary>
        [DataMember(Name = "deliveryDaysRange", EmitDefaultValue = false)]
        public DeliveryDaysRange? DeliveryDaysRange { get; set; }

        /// <summary>
        /// Gets or Sets RefundDaysRange
        /// </summary>
        [DataMember(Name = "refundDaysRange", EmitDefaultValue = false)]
        public RefundDaysRange? RefundDaysRange { get; set; }

        /// <summary>
        /// Gets or Sets RefundPercentageRange
        /// </summary>
        [DataMember(Name = "refundPercentageRange", EmitDefaultValue = false)]
        public RefundPercentageRange? RefundPercentageRange { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantEcommerceDetailsDto" /> class.
        /// </summary>
        /// <param name="password">The password used to access the protected ecommerce website..</param>
        /// <param name="voucherSalesOver5Percent">Whether voucher sales exceed five percent of turnover..</param>
        /// <param name="offerSubscriptionBasedProduct">Whether the merchant offers subscription-based products..</param>
        /// <param name="urlPasswordProtected">Whether the ecommerce website is protected by a login..</param>
        /// <param name="websiteUrl">The URL of the merchant&#39;s ecommerce website..</param>
        /// <param name="deliveryDestination">deliveryDestination.</param>
        /// <param name="expectedInternationalTurnoverRange">expectedInternationalTurnoverRange.</param>
        /// <param name="deliveryDaysRange">deliveryDaysRange.</param>
        /// <param name="refundDaysRange">refundDaysRange.</param>
        /// <param name="refundPercentageRange">refundPercentageRange.</param>
        /// <param name="username">The username used to access the protected ecommerce website..</param>
        public MerchantEcommerceDetailsDto(string password = default, bool voucherSalesOver5Percent = default, bool offerSubscriptionBasedProduct = default, bool urlPasswordProtected = default, string websiteUrl = default, DeliveryDestination? deliveryDestination = default, RefundPercentageRange? expectedInternationalTurnoverRange = default, DeliveryDaysRange? deliveryDaysRange = default, RefundDaysRange? refundDaysRange = default, RefundPercentageRange? refundPercentageRange = default, string username = default)
        {
            this.Password = password;
            this.VoucherSalesOver5Percent = voucherSalesOver5Percent;
            this.OfferSubscriptionBasedProduct = offerSubscriptionBasedProduct;
            this.UrlPasswordProtected = urlPasswordProtected;
            this.WebsiteUrl = websiteUrl;
            this.DeliveryDestination = deliveryDestination;
            this.ExpectedInternationalTurnoverRange = expectedInternationalTurnoverRange;
            this.DeliveryDaysRange = deliveryDaysRange;
            this.RefundDaysRange = refundDaysRange;
            this.RefundPercentageRange = refundPercentageRange;
            this.Username = username;
        }

        /// <summary>
        /// The password used to access the protected ecommerce website.
        /// </summary>
        /// <value>The password used to access the protected ecommerce website.</value>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// Whether voucher sales exceed five percent of turnover.
        /// </summary>
        /// <value>Whether voucher sales exceed five percent of turnover.</value>
        [DataMember(Name = "voucherSalesOver5Percent", EmitDefaultValue = true)]
        public bool VoucherSalesOver5Percent { get; set; }

        /// <summary>
        /// Whether the merchant offers subscription-based products.
        /// </summary>
        /// <value>Whether the merchant offers subscription-based products.</value>
        [DataMember(Name = "offerSubscriptionBasedProduct", EmitDefaultValue = true)]
        public bool OfferSubscriptionBasedProduct { get; set; }

        /// <summary>
        /// Whether the ecommerce website is protected by a login.
        /// </summary>
        /// <value>Whether the ecommerce website is protected by a login.</value>
        [DataMember(Name = "urlPasswordProtected", EmitDefaultValue = true)]
        public bool UrlPasswordProtected { get; set; }

        /// <summary>
        /// The URL of the merchant&#39;s ecommerce website.
        /// </summary>
        /// <value>The URL of the merchant&#39;s ecommerce website.</value>
        [DataMember(Name = "websiteUrl", EmitDefaultValue = false)]
        public string WebsiteUrl { get; set; }

        /// <summary>
        /// The username used to access the protected ecommerce website.
        /// </summary>
        /// <value>The username used to access the protected ecommerce website.</value>
        [DataMember(Name = "username", EmitDefaultValue = false)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MerchantEcommerceDetailsDto {\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  VoucherSalesOver5Percent: ").Append(VoucherSalesOver5Percent).Append("\n");
            sb.Append("  OfferSubscriptionBasedProduct: ").Append(OfferSubscriptionBasedProduct).Append("\n");
            sb.Append("  UrlPasswordProtected: ").Append(UrlPasswordProtected).Append("\n");
            sb.Append("  WebsiteUrl: ").Append(WebsiteUrl).Append("\n");
            sb.Append("  DeliveryDestination: ").Append(DeliveryDestination).Append("\n");
            sb.Append("  ExpectedInternationalTurnoverRange: ").Append(ExpectedInternationalTurnoverRange).Append("\n");
            sb.Append("  DeliveryDaysRange: ").Append(DeliveryDaysRange).Append("\n");
            sb.Append("  RefundDaysRange: ").Append(RefundDaysRange).Append("\n");
            sb.Append("  RefundPercentageRange: ").Append(RefundPercentageRange).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
