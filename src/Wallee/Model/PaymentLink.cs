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
    /// PaymentLink
    /// </summary>
    [DataContract(Name = "PaymentLink")]
    public partial class PaymentLink : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ShippingAddressHandlingMode
        /// </summary>
        [DataMember(Name = "shippingAddressHandlingMode", EmitDefaultValue = false)]
        public PaymentLinkAddressHandlingMode? ShippingAddressHandlingMode { get; set; }

        /// <summary>
        /// Gets or Sets ProtectionMode
        /// </summary>
        [DataMember(Name = "protectionMode", EmitDefaultValue = false)]
        public PaymentLinkProtectionMode? ProtectionMode { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public CreationEntityState? State { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddressHandlingMode
        /// </summary>
        [DataMember(Name = "billingAddressHandlingMode", EmitDefaultValue = false)]
        public PaymentLinkAddressHandlingMode? BillingAddressHandlingMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentLink" /> class.
        /// </summary>
        /// <param name="shippingAddressHandlingMode">shippingAddressHandlingMode.</param>
        /// <param name="protectionMode">protectionMode.</param>
        /// <param name="state">state.</param>
        /// <param name="billingAddressHandlingMode">billingAddressHandlingMode.</param>
        public PaymentLink(PaymentLinkAddressHandlingMode? shippingAddressHandlingMode = default, PaymentLinkProtectionMode? protectionMode = default, CreationEntityState? state = default, PaymentLinkAddressHandlingMode? billingAddressHandlingMode = default)
        {
            this.ShippingAddressHandlingMode = shippingAddressHandlingMode;
            this.ProtectionMode = protectionMode;
            this.State = state;
            this.BillingAddressHandlingMode = billingAddressHandlingMode;
        }

        /// <summary>
        /// The domains to which the user is allowed to be redirected after the payment is completed. The following options can be configured: Exact domain: enter a full domain, e.g. (https://example.com). Wildcard domain: use to allow subdomains, e.g. (https://_*.example.com). All domains: use (ALL) to allow redirection to any domain (not recommended for security reasons). No domains : use (NONE) to disallow any redirection. Only one option per line is allowed. Invalid entries will be rejected. 
        /// </summary>
        /// <value>The domains to which the user is allowed to be redirected after the payment is completed. The following options can be configured: Exact domain: enter a full domain, e.g. (https://example.com). Wildcard domain: use to allow subdomains, e.g. (https://_*.example.com). All domains: use (ALL) to allow redirection to any domain (not recommended for security reasons). No domains : use (NONE) to disallow any redirection. Only one option per line is allowed. Invalid entries will be rejected. </value>
        [DataMember(Name = "allowedRedirectionDomains", EmitDefaultValue = false)]
        public List<string> AllowedRedirectionDomains { get; private set; }

        /// <summary>
        /// Returns false as AllowedRedirectionDomains should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAllowedRedirectionDomains()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.
        /// </summary>
        /// <value>The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.</value>
        [DataMember(Name = "plannedPurgeDate", EmitDefaultValue = false)]
        public DateTime PlannedPurgeDate { get; private set; }

        /// <summary>
        /// Returns false as PlannedPurgeDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePlannedPurgeDate()
        {
            return false;
        }
        /// <summary>
        /// A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.
        /// </summary>
        /// <value>A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.</value>
        [DataMember(Name = "externalId", EmitDefaultValue = false)]
        public string ExternalId { get; private set; }

        /// <summary>
        /// Returns false as ExternalId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeExternalId()
        {
            return false;
        }
        /// <summary>
        /// The language for displaying the payment page. If not specified, it can be supplied via the &#39;language&#39; request parameter.
        /// </summary>
        /// <value>The language for displaying the payment page. If not specified, it can be supplied via the &#39;language&#39; request parameter.</value>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public string Language { get; private set; }

        /// <summary>
        /// Returns false as Language should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLanguage()
        {
            return false;
        }
        /// <summary>
        /// The earliest date the payment link can be used to initiate a transaction. If no date is provided, the link will be available immediately.
        /// </summary>
        /// <value>The earliest date the payment link can be used to initiate a transaction. If no date is provided, the link will be available immediately.</value>
        [DataMember(Name = "availableFrom", EmitDefaultValue = false)]
        public DateTime AvailableFrom { get; private set; }

        /// <summary>
        /// Returns false as AvailableFrom should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAvailableFrom()
        {
            return false;
        }
        /// <summary>
        /// The version is used for optimistic locking and incremented whenever the object is updated.
        /// </summary>
        /// <value>The version is used for optimistic locking and incremented whenever the object is updated.</value>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int VarVersion { get; private set; }

        /// <summary>
        /// Returns false as VarVersion should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVarVersion()
        {
            return false;
        }
        /// <summary>
        /// The public URL to share with customers for making payments.
        /// </summary>
        /// <value>The public URL to share with customers for making payments.</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; private set; }

        /// <summary>
        /// Returns false as Url should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUrl()
        {
            return false;
        }
        /// <summary>
        /// The line items representing what is being sold. If not specified, they can be supplied via request parameters.
        /// </summary>
        /// <value>The line items representing what is being sold. If not specified, they can be supplied via request parameters.</value>
        [DataMember(Name = "lineItems", EmitDefaultValue = false)]
        public List<LineItem> LineItems { get; private set; }

        /// <summary>
        /// Returns false as LineItems should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLineItems()
        {
            return false;
        }
        /// <summary>
        /// The latest date the payment link can be used to initiate a transaction. If no date is provided, the link will remain available indefinitely.
        /// </summary>
        /// <value>The latest date the payment link can be used to initiate a transaction. If no date is provided, the link will remain available indefinitely.</value>
        [DataMember(Name = "availableUntil", EmitDefaultValue = false)]
        public DateTime AvailableUntil { get; private set; }

        /// <summary>
        /// Returns false as AvailableUntil should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAvailableUntil()
        {
            return false;
        }
        /// <summary>
        /// The ID of the space this object belongs to.
        /// </summary>
        /// <value>The ID of the space this object belongs to.</value>
        [DataMember(Name = "linkedSpaceId", EmitDefaultValue = false)]
        public long LinkedSpaceId { get; private set; }

        /// <summary>
        /// Returns false as LinkedSpaceId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLinkedSpaceId()
        {
            return false;
        }
        /// <summary>
        /// The name used to identify the payment link.
        /// </summary>
        /// <value>The name used to identify the payment link.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; private set; }

        /// <summary>
        /// Returns false as Name should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeName()
        {
            return false;
        }
        /// <summary>
        /// The three-letter currency code (ISO 4217). If not specified, it must be provided in the &#39;currency&#39; request parameter.
        /// </summary>
        /// <value>The three-letter currency code (ISO 4217). If not specified, it must be provided in the &#39;currency&#39; request parameter.</value>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; private set; }

        /// <summary>
        /// Returns false as Currency should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCurrency()
        {
            return false;
        }
        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// The maximum number of transactions that can be initiated using the payment link.
        /// </summary>
        /// <value>The maximum number of transactions that can be initiated using the payment link.</value>
        [DataMember(Name = "maximalNumberOfTransactions", EmitDefaultValue = false)]
        public int MaximalNumberOfTransactions { get; private set; }

        /// <summary>
        /// Returns false as MaximalNumberOfTransactions should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMaximalNumberOfTransactions()
        {
            return false;
        }
        /// <summary>
        /// The payment method configurations that customers can use for making payments.
        /// </summary>
        /// <value>The payment method configurations that customers can use for making payments.</value>
        [DataMember(Name = "allowedPaymentMethodConfigurations", EmitDefaultValue = false)]
        public List<PaymentMethodConfiguration> AllowedPaymentMethodConfigurations { get; private set; }

        /// <summary>
        /// Returns false as AllowedPaymentMethodConfigurations should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAllowedPaymentMethodConfigurations()
        {
            return false;
        }
        /// <summary>
        /// The payment link can be used within a specific space view, which may apply a customized design to the payment page.
        /// </summary>
        /// <value>The payment link can be used within a specific space view, which may apply a customized design to the payment page.</value>
        [DataMember(Name = "appliedSpaceView", EmitDefaultValue = false)]
        public long AppliedSpaceView { get; private set; }

        /// <summary>
        /// Returns false as AppliedSpaceView should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAppliedSpaceView()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentLink {\n");
            sb.Append("  ShippingAddressHandlingMode: ").Append(ShippingAddressHandlingMode).Append("\n");
            sb.Append("  AllowedRedirectionDomains: ").Append(AllowedRedirectionDomains).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  AvailableFrom: ").Append(AvailableFrom).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  ProtectionMode: ").Append(ProtectionMode).Append("\n");
            sb.Append("  AvailableUntil: ").Append(AvailableUntil).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  MaximalNumberOfTransactions: ").Append(MaximalNumberOfTransactions).Append("\n");
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
