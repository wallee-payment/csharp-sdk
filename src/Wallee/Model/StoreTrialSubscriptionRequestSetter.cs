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
    /// Model used to store a Trial Subscription, assigning it to an Account
    /// </summary>
    [DataContract(Name = "StoreTrialSubscriptionRequest.Setter")]
    public partial class StoreTrialSubscriptionRequestSetter : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreTrialSubscriptionRequestSetter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StoreTrialSubscriptionRequestSetter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreTrialSubscriptionRequestSetter" /> class.
        /// </summary>
        /// <param name="couponCodes">couponCodes.</param>
        /// <param name="componentConfigurations">componentConfigurations.</param>
        /// <param name="productId">ID of the product that will be used for the Trial Subscription assigned to the Account. (required).</param>
        /// <param name="currency">currency (required).</param>
        /// <param name="affiliateId">ID of the affiliate to be added in the subscription assignment..</param>
        public StoreTrialSubscriptionRequestSetter(List<string> couponCodes = default, List<SubscriptionComponentGroupConfigurationRequestSetter> componentConfigurations = default, long productId = default, string currency = default, long affiliateId = default)
        {
            this.ProductId = productId;
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new ArgumentNullException("currency is a required property for StoreTrialSubscriptionRequestSetter and cannot be null");
            }
            this.Currency = currency;
            this.CouponCodes = couponCodes;
            this.ComponentConfigurations = componentConfigurations;
            this.AffiliateId = affiliateId;
        }

        /// <summary>
        /// Gets or Sets CouponCodes
        /// </summary>
        [DataMember(Name = "couponCodes", EmitDefaultValue = false)]
        public List<string> CouponCodes { get; set; }

        /// <summary>
        /// Gets or Sets ComponentConfigurations
        /// </summary>
        [DataMember(Name = "componentConfigurations", EmitDefaultValue = false)]
        public List<SubscriptionComponentGroupConfigurationRequestSetter> ComponentConfigurations { get; set; }

        /// <summary>
        /// ID of the product that will be used for the Trial Subscription assigned to the Account.
        /// </summary>
        /// <value>ID of the product that will be used for the Trial Subscription assigned to the Account.</value>
        [DataMember(Name = "productId", IsRequired = true, EmitDefaultValue = true)]
        public long ProductId { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// ID of the affiliate to be added in the subscription assignment.
        /// </summary>
        /// <value>ID of the affiliate to be added in the subscription assignment.</value>
        [DataMember(Name = "affiliateId", EmitDefaultValue = false)]
        public long AffiliateId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StoreTrialSubscriptionRequestSetter {\n");
            sb.Append("  CouponCodes: ").Append(CouponCodes).Append("\n");
            sb.Append("  ComponentConfigurations: ").Append(ComponentConfigurations).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  AffiliateId: ").Append(AffiliateId).Append("\n");
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
