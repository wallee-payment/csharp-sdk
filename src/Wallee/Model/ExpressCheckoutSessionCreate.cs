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
    /// ExpressCheckoutSessionCreate
    /// </summary>
    [DataContract(Name = "ExpressCheckoutSession.Create")]
    public partial class ExpressCheckoutSessionCreate : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets AuthorizationEnvironment
        /// </summary>
        [DataMember(Name = "authorizationEnvironment", IsRequired = true, EmitDefaultValue = true)]
        public ChargeAttemptEnvironment AuthorizationEnvironment { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressCheckoutSessionCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExpressCheckoutSessionCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressCheckoutSessionCreate" /> class.
        /// </summary>
        /// <param name="lineItems">lineItems (required).</param>
        /// <param name="merchantShippingCallbackUrl">The URL to fetch the shipping options from..</param>
        /// <param name="merchantRedirectUrl">The base URL on the merchant shop used to create the order. (required).</param>
        /// <param name="authorizationEnvironment">authorizationEnvironment (required).</param>
        /// <param name="varTimeZone">Customer time zone for presentation and cutoffs (same semantics as on Transaction)..</param>
        /// <param name="currency">The currency of the session. (required).</param>
        /// <param name="language">Preferred language for customer-facing content (same semantics as on Transaction)..</param>
        public ExpressCheckoutSessionCreate(List<LineItem> lineItems = default, string merchantShippingCallbackUrl = default, string merchantRedirectUrl = default, ChargeAttemptEnvironment authorizationEnvironment = default, string varTimeZone = default, string currency = default, string language = default)
        {
            // to ensure "lineItems" is required (not null)
            if (lineItems == null)
            {
                throw new ArgumentNullException("lineItems is a required property for ExpressCheckoutSessionCreate and cannot be null");
            }
            this.LineItems = lineItems;
            // to ensure "merchantRedirectUrl" is required (not null)
            if (merchantRedirectUrl == null)
            {
                throw new ArgumentNullException("merchantRedirectUrl is a required property for ExpressCheckoutSessionCreate and cannot be null");
            }
            this.MerchantRedirectUrl = merchantRedirectUrl;
            this.AuthorizationEnvironment = authorizationEnvironment;
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new ArgumentNullException("currency is a required property for ExpressCheckoutSessionCreate and cannot be null");
            }
            this.Currency = currency;
            this.MerchantShippingCallbackUrl = merchantShippingCallbackUrl;
            this.VarTimeZone = varTimeZone;
            this.Language = language;
        }

        /// <summary>
        /// Gets or Sets LineItems
        /// </summary>
        [DataMember(Name = "lineItems", IsRequired = true, EmitDefaultValue = true)]
        public List<LineItem> LineItems { get; set; }

        /// <summary>
        /// The URL to fetch the shipping options from.
        /// </summary>
        /// <value>The URL to fetch the shipping options from.</value>
        [DataMember(Name = "merchantShippingCallbackUrl", EmitDefaultValue = false)]
        public string MerchantShippingCallbackUrl { get; set; }

        /// <summary>
        /// The base URL on the merchant shop used to create the order.
        /// </summary>
        /// <value>The base URL on the merchant shop used to create the order.</value>
        [DataMember(Name = "merchantRedirectUrl", IsRequired = true, EmitDefaultValue = true)]
        public string MerchantRedirectUrl { get; set; }

        /// <summary>
        /// Customer time zone for presentation and cutoffs (same semantics as on Transaction).
        /// </summary>
        /// <value>Customer time zone for presentation and cutoffs (same semantics as on Transaction).</value>
        [DataMember(Name = "timeZone", EmitDefaultValue = false)]
        public string VarTimeZone { get; set; }

        /// <summary>
        /// The currency of the session.
        /// </summary>
        /// <value>The currency of the session.</value>
        [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// Preferred language for customer-facing content (same semantics as on Transaction).
        /// </summary>
        /// <value>Preferred language for customer-facing content (same semantics as on Transaction).</value>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public string Language { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExpressCheckoutSessionCreate {\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  MerchantShippingCallbackUrl: ").Append(MerchantShippingCallbackUrl).Append("\n");
            sb.Append("  MerchantRedirectUrl: ").Append(MerchantRedirectUrl).Append("\n");
            sb.Append("  AuthorizationEnvironment: ").Append(AuthorizationEnvironment).Append("\n");
            sb.Append("  VarTimeZone: ").Append(VarTimeZone).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
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
