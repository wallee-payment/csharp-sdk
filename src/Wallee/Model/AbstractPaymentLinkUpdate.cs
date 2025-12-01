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
    /// AbstractPaymentLinkUpdate
    /// </summary>
    [DataContract(Name = "Abstract.PaymentLink.Update")]
    public partial class AbstractPaymentLinkUpdate : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ShippingAddressHandlingMode
        /// </summary>
        [DataMember(Name = "shippingAddressHandlingMode", EmitDefaultValue = false)]
        public PaymentLinkAddressHandlingMode? ShippingAddressHandlingMode { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddressHandlingMode
        /// </summary>
        [DataMember(Name = "billingAddressHandlingMode", EmitDefaultValue = false)]
        public PaymentLinkAddressHandlingMode? BillingAddressHandlingMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractPaymentLinkUpdate" /> class.
        /// </summary>
        /// <param name="lineItems">The line items representing what is being sold. If not specified, they can be supplied via request parameters..</param>
        /// <param name="availableUntil">The latest date the payment link can be used to initiate a transaction. If no date is provided, the link will remain available indefinitely..</param>
        /// <param name="shippingAddressHandlingMode">shippingAddressHandlingMode.</param>
        /// <param name="allowedRedirectionDomains">The domains to which the user is allowed to be redirected after the payment is completed. The following options can be configured: Exact domain: enter a full domain, e.g. (https://example.com). Wildcard domain: use to allow subdomains, e.g. (https://_*.example.com). All domains: use (ALL) to allow redirection to any domain (not recommended for security reasons). No domains : use (NONE) to disallow any redirection. Only one option per line is allowed. Invalid entries will be rejected. .</param>
        /// <param name="name">The name used to identify the payment link..</param>
        /// <param name="currency">The three-letter currency code (ISO 4217). If not specified, it must be provided in the &#39;currency&#39; request parameter..</param>
        /// <param name="language">The language for displaying the payment page. If not specified, it can be supplied via the &#39;language&#39; request parameter..</param>
        /// <param name="maximalNumberOfTransactions">The maximum number of transactions that can be initiated using the payment link..</param>
        /// <param name="availableFrom">The earliest date the payment link can be used to initiate a transaction. If no date is provided, the link will be available immediately..</param>
        /// <param name="allowedPaymentMethodConfigurations">The payment method configurations that customers can use for making payments..</param>
        /// <param name="appliedSpaceView">The payment link can be used within a specific space view, which may apply a customized design to the payment page..</param>
        /// <param name="billingAddressHandlingMode">billingAddressHandlingMode.</param>
        public AbstractPaymentLinkUpdate(List<LineItemCreate> lineItems = default, DateTime availableUntil = default, PaymentLinkAddressHandlingMode? shippingAddressHandlingMode = default, List<string> allowedRedirectionDomains = default, string name = default, string currency = default, string language = default, int maximalNumberOfTransactions = default, DateTime availableFrom = default, List<PaymentMethodConfiguration> allowedPaymentMethodConfigurations = default, long appliedSpaceView = default, PaymentLinkAddressHandlingMode? billingAddressHandlingMode = default)
        {
            this.LineItems = lineItems;
            this.AvailableUntil = availableUntil;
            this.ShippingAddressHandlingMode = shippingAddressHandlingMode;
            this.AllowedRedirectionDomains = allowedRedirectionDomains;
            this.Name = name;
            this.Currency = currency;
            this.Language = language;
            this.MaximalNumberOfTransactions = maximalNumberOfTransactions;
            this.AvailableFrom = availableFrom;
            this.AllowedPaymentMethodConfigurations = allowedPaymentMethodConfigurations;
            this.AppliedSpaceView = appliedSpaceView;
            this.BillingAddressHandlingMode = billingAddressHandlingMode;
        }

        /// <summary>
        /// The line items representing what is being sold. If not specified, they can be supplied via request parameters.
        /// </summary>
        /// <value>The line items representing what is being sold. If not specified, they can be supplied via request parameters.</value>
        [DataMember(Name = "lineItems", EmitDefaultValue = false)]
        public List<LineItemCreate> LineItems { get; set; }

        /// <summary>
        /// The latest date the payment link can be used to initiate a transaction. If no date is provided, the link will remain available indefinitely.
        /// </summary>
        /// <value>The latest date the payment link can be used to initiate a transaction. If no date is provided, the link will remain available indefinitely.</value>
        [DataMember(Name = "availableUntil", EmitDefaultValue = false)]
        public DateTime AvailableUntil { get; set; }

        /// <summary>
        /// The domains to which the user is allowed to be redirected after the payment is completed. The following options can be configured: Exact domain: enter a full domain, e.g. (https://example.com). Wildcard domain: use to allow subdomains, e.g. (https://_*.example.com). All domains: use (ALL) to allow redirection to any domain (not recommended for security reasons). No domains : use (NONE) to disallow any redirection. Only one option per line is allowed. Invalid entries will be rejected. 
        /// </summary>
        /// <value>The domains to which the user is allowed to be redirected after the payment is completed. The following options can be configured: Exact domain: enter a full domain, e.g. (https://example.com). Wildcard domain: use to allow subdomains, e.g. (https://_*.example.com). All domains: use (ALL) to allow redirection to any domain (not recommended for security reasons). No domains : use (NONE) to disallow any redirection. Only one option per line is allowed. Invalid entries will be rejected. </value>
        [DataMember(Name = "allowedRedirectionDomains", EmitDefaultValue = false)]
        public List<string> AllowedRedirectionDomains { get; set; }

        /// <summary>
        /// The name used to identify the payment link.
        /// </summary>
        /// <value>The name used to identify the payment link.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The three-letter currency code (ISO 4217). If not specified, it must be provided in the &#39;currency&#39; request parameter.
        /// </summary>
        /// <value>The three-letter currency code (ISO 4217). If not specified, it must be provided in the &#39;currency&#39; request parameter.</value>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// The language for displaying the payment page. If not specified, it can be supplied via the &#39;language&#39; request parameter.
        /// </summary>
        /// <value>The language for displaying the payment page. If not specified, it can be supplied via the &#39;language&#39; request parameter.</value>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public string Language { get; set; }

        /// <summary>
        /// The maximum number of transactions that can be initiated using the payment link.
        /// </summary>
        /// <value>The maximum number of transactions that can be initiated using the payment link.</value>
        [DataMember(Name = "maximalNumberOfTransactions", EmitDefaultValue = false)]
        public int MaximalNumberOfTransactions { get; set; }

        /// <summary>
        /// The earliest date the payment link can be used to initiate a transaction. If no date is provided, the link will be available immediately.
        /// </summary>
        /// <value>The earliest date the payment link can be used to initiate a transaction. If no date is provided, the link will be available immediately.</value>
        [DataMember(Name = "availableFrom", EmitDefaultValue = false)]
        public DateTime AvailableFrom { get; set; }

        /// <summary>
        /// The payment method configurations that customers can use for making payments.
        /// </summary>
        /// <value>The payment method configurations that customers can use for making payments.</value>
        [DataMember(Name = "allowedPaymentMethodConfigurations", EmitDefaultValue = false)]
        public List<PaymentMethodConfiguration> AllowedPaymentMethodConfigurations { get; set; }

        /// <summary>
        /// The payment link can be used within a specific space view, which may apply a customized design to the payment page.
        /// </summary>
        /// <value>The payment link can be used within a specific space view, which may apply a customized design to the payment page.</value>
        [DataMember(Name = "appliedSpaceView", EmitDefaultValue = false)]
        public long AppliedSpaceView { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AbstractPaymentLinkUpdate {\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  AvailableUntil: ").Append(AvailableUntil).Append("\n");
            sb.Append("  ShippingAddressHandlingMode: ").Append(ShippingAddressHandlingMode).Append("\n");
            sb.Append("  AllowedRedirectionDomains: ").Append(AllowedRedirectionDomains).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  MaximalNumberOfTransactions: ").Append(MaximalNumberOfTransactions).Append("\n");
            sb.Append("  AvailableFrom: ").Append(AvailableFrom).Append("\n");
            sb.Append("  AllowedPaymentMethodConfigurations: ").Append(AllowedPaymentMethodConfigurations).Append("\n");
            sb.Append("  AppliedSpaceView: ").Append(AppliedSpaceView).Append("\n");
            sb.Append("  BillingAddressHandlingMode: ").Append(BillingAddressHandlingMode).Append("\n");
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 100)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 100.", new [] { "Name" });
            }

            yield break;
        }
    }

}
