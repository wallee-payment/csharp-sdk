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
    /// TransactionPending
    /// </summary>
    [DataContract(Name = "Transaction.Pending")]
    public partial class TransactionPending : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets TokenizationMode
        /// </summary>
        [DataMember(Name = "tokenizationMode", EmitDefaultValue = false)]
        public TokenizationMode? TokenizationMode { get; set; }

        /// <summary>
        /// Gets or Sets CompletionBehavior
        /// </summary>
        [DataMember(Name = "completionBehavior", EmitDefaultValue = false)]
        public TransactionCompletionBehavior? CompletionBehavior { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionPending" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionPending() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionPending" /> class.
        /// </summary>
        /// <param name="customerEmailAddress">The customer&#39;s email address..</param>
        /// <param name="shippingMethod">The name of the shipping method used to ship the products..</param>
        /// <param name="invoiceMerchantReference">The merchant&#39;s reference used to identify the invoice..</param>
        /// <param name="successUrl">The URL to redirect the customer back to after they successfully authenticated their payment..</param>
        /// <param name="varTimeZone">The customer&#39;s time zone, which affects how dates and times are formatted when communicating with the customer..</param>
        /// <param name="language">The language that is linked to the object..</param>
        /// <param name="tokenizationMode">tokenizationMode.</param>
        /// <param name="allowedPaymentMethodBrands">The payment method brands that can be used to authorize the transaction..</param>
        /// <param name="completionBehavior">completionBehavior.</param>
        /// <param name="token">The payment token that should be used to charge the customer..</param>
        /// <param name="lineItems">The line items purchased by the customer..</param>
        /// <param name="metaData">Allow to store additional information about the object..</param>
        /// <param name="customerId">The unique identifier of the customer in the external system..</param>
        /// <param name="shippingAddress">shippingAddress.</param>
        /// <param name="currency">The three-letter code (ISO 4217 format) of the transaction&#39;s currency..</param>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="merchantReference">The merchant&#39;s reference used to identify the transaction..</param>
        /// <param name="allowedPaymentMethodConfigurations">The payment method configurations that can be used to authorize the transaction..</param>
        /// <param name="failedUrl">The URL to redirect the customer back to after they canceled or failed to authenticated their payment..</param>
        /// <param name="varVersion">The version number indicates the version of the entity. The version is incremented whenever the entity is changed. (required).</param>
        public TransactionPending(string customerEmailAddress = default, string shippingMethod = default, string invoiceMerchantReference = default, string successUrl = default, string varTimeZone = default, string language = default, TokenizationMode? tokenizationMode = default, List<long> allowedPaymentMethodBrands = default, TransactionCompletionBehavior? completionBehavior = default, long token = default, List<LineItemCreate> lineItems = default, Dictionary<string, string> metaData = default, string customerId = default, AddressCreate shippingAddress = default, string currency = default, AddressCreate billingAddress = default, string merchantReference = default, List<long> allowedPaymentMethodConfigurations = default, string failedUrl = default, int varVersion = default)
        {
            this.VarVersion = varVersion;
            this.CustomerEmailAddress = customerEmailAddress;
            this.ShippingMethod = shippingMethod;
            this.InvoiceMerchantReference = invoiceMerchantReference;
            this.SuccessUrl = successUrl;
            this.VarTimeZone = varTimeZone;
            this.Language = language;
            this.TokenizationMode = tokenizationMode;
            this.AllowedPaymentMethodBrands = allowedPaymentMethodBrands;
            this.CompletionBehavior = completionBehavior;
            this.Token = token;
            this.LineItems = lineItems;
            this.MetaData = metaData;
            this.CustomerId = customerId;
            this.ShippingAddress = shippingAddress;
            this.Currency = currency;
            this.BillingAddress = billingAddress;
            this.MerchantReference = merchantReference;
            this.AllowedPaymentMethodConfigurations = allowedPaymentMethodConfigurations;
            this.FailedUrl = failedUrl;
        }

        /// <summary>
        /// The customer&#39;s email address.
        /// </summary>
        /// <value>The customer&#39;s email address.</value>
        [DataMember(Name = "customerEmailAddress", EmitDefaultValue = false)]
        public string CustomerEmailAddress { get; set; }

        /// <summary>
        /// The name of the shipping method used to ship the products.
        /// </summary>
        /// <value>The name of the shipping method used to ship the products.</value>
        [DataMember(Name = "shippingMethod", EmitDefaultValue = false)]
        public string ShippingMethod { get; set; }

        /// <summary>
        /// The merchant&#39;s reference used to identify the invoice.
        /// </summary>
        /// <value>The merchant&#39;s reference used to identify the invoice.</value>
        [DataMember(Name = "invoiceMerchantReference", EmitDefaultValue = false)]
        public string InvoiceMerchantReference { get; set; }

        /// <summary>
        /// The URL to redirect the customer back to after they successfully authenticated their payment.
        /// </summary>
        /// <value>The URL to redirect the customer back to after they successfully authenticated their payment.</value>
        [DataMember(Name = "successUrl", EmitDefaultValue = false)]
        public string SuccessUrl { get; set; }

        /// <summary>
        /// The customer&#39;s time zone, which affects how dates and times are formatted when communicating with the customer.
        /// </summary>
        /// <value>The customer&#39;s time zone, which affects how dates and times are formatted when communicating with the customer.</value>
        [DataMember(Name = "timeZone", EmitDefaultValue = false)]
        public string VarTimeZone { get; set; }

        /// <summary>
        /// The language that is linked to the object.
        /// </summary>
        /// <value>The language that is linked to the object.</value>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public string Language { get; set; }

        /// <summary>
        /// The payment method brands that can be used to authorize the transaction.
        /// </summary>
        /// <value>The payment method brands that can be used to authorize the transaction.</value>
        [DataMember(Name = "allowedPaymentMethodBrands", EmitDefaultValue = false)]
        public List<long> AllowedPaymentMethodBrands { get; set; }

        /// <summary>
        /// The payment token that should be used to charge the customer.
        /// </summary>
        /// <value>The payment token that should be used to charge the customer.</value>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        public long Token { get; set; }

        /// <summary>
        /// The line items purchased by the customer.
        /// </summary>
        /// <value>The line items purchased by the customer.</value>
        [DataMember(Name = "lineItems", EmitDefaultValue = false)]
        public List<LineItemCreate> LineItems { get; set; }

        /// <summary>
        /// Allow to store additional information about the object.
        /// </summary>
        /// <value>Allow to store additional information about the object.</value>
        [DataMember(Name = "metaData", EmitDefaultValue = false)]
        public Dictionary<string, string> MetaData { get; set; }

        /// <summary>
        /// The unique identifier of the customer in the external system.
        /// </summary>
        /// <value>The unique identifier of the customer in the external system.</value>
        [DataMember(Name = "customerId", EmitDefaultValue = false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// Gets or Sets ShippingAddress
        /// </summary>
        [DataMember(Name = "shippingAddress", EmitDefaultValue = false)]
        public AddressCreate ShippingAddress { get; set; }

        /// <summary>
        /// The three-letter code (ISO 4217 format) of the transaction&#39;s currency.
        /// </summary>
        /// <value>The three-letter code (ISO 4217 format) of the transaction&#39;s currency.</value>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name = "billingAddress", EmitDefaultValue = false)]
        public AddressCreate BillingAddress { get; set; }

        /// <summary>
        /// The merchant&#39;s reference used to identify the transaction.
        /// </summary>
        /// <value>The merchant&#39;s reference used to identify the transaction.</value>
        [DataMember(Name = "merchantReference", EmitDefaultValue = false)]
        public string MerchantReference { get; set; }

        /// <summary>
        /// The payment method configurations that can be used to authorize the transaction.
        /// </summary>
        /// <value>The payment method configurations that can be used to authorize the transaction.</value>
        [DataMember(Name = "allowedPaymentMethodConfigurations", EmitDefaultValue = false)]
        public List<long> AllowedPaymentMethodConfigurations { get; set; }

        /// <summary>
        /// The URL to redirect the customer back to after they canceled or failed to authenticated their payment.
        /// </summary>
        /// <value>The URL to redirect the customer back to after they canceled or failed to authenticated their payment.</value>
        [DataMember(Name = "failedUrl", EmitDefaultValue = false)]
        public string FailedUrl { get; set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public int VarVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionPending {\n");
            sb.Append("  CustomerEmailAddress: ").Append(CustomerEmailAddress).Append("\n");
            sb.Append("  ShippingMethod: ").Append(ShippingMethod).Append("\n");
            sb.Append("  InvoiceMerchantReference: ").Append(InvoiceMerchantReference).Append("\n");
            sb.Append("  SuccessUrl: ").Append(SuccessUrl).Append("\n");
            sb.Append("  VarTimeZone: ").Append(VarTimeZone).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  TokenizationMode: ").Append(TokenizationMode).Append("\n");
            sb.Append("  AllowedPaymentMethodBrands: ").Append(AllowedPaymentMethodBrands).Append("\n");
            sb.Append("  CompletionBehavior: ").Append(CompletionBehavior).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  MetaData: ").Append(MetaData).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
            sb.Append("  AllowedPaymentMethodConfigurations: ").Append(AllowedPaymentMethodConfigurations).Append("\n");
            sb.Append("  FailedUrl: ").Append(FailedUrl).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
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
            // CustomerEmailAddress (string) maxLength
            if (this.CustomerEmailAddress != null && this.CustomerEmailAddress.Length > 254)
            {
                yield return new ValidationResult("Invalid value for CustomerEmailAddress, length must be less than 254.", new [] { "CustomerEmailAddress" });
            }

            // ShippingMethod (string) maxLength
            if (this.ShippingMethod != null && this.ShippingMethod.Length > 200)
            {
                yield return new ValidationResult("Invalid value for ShippingMethod, length must be less than 200.", new [] { "ShippingMethod" });
            }

            // InvoiceMerchantReference (string) maxLength
            if (this.InvoiceMerchantReference != null && this.InvoiceMerchantReference.Length > 100)
            {
                yield return new ValidationResult("Invalid value for InvoiceMerchantReference, length must be less than 100.", new [] { "InvoiceMerchantReference" });
            }

            if (this.InvoiceMerchantReference != null) {
                // InvoiceMerchantReference (string) pattern
                Regex regexInvoiceMerchantReference = new Regex(@"[	\x20-\x7e]*", RegexOptions.CultureInvariant);
                if (!regexInvoiceMerchantReference.Match(this.InvoiceMerchantReference).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InvoiceMerchantReference, must match a pattern of " + regexInvoiceMerchantReference, new [] { "InvoiceMerchantReference" });
                }
            }

            // SuccessUrl (string) maxLength
            if (this.SuccessUrl != null && this.SuccessUrl.Length > 2000)
            {
                yield return new ValidationResult("Invalid value for SuccessUrl, length must be less than 2000.", new [] { "SuccessUrl" });
            }

            // SuccessUrl (string) minLength
            if (this.SuccessUrl != null && this.SuccessUrl.Length < 9)
            {
                yield return new ValidationResult("Invalid value for SuccessUrl, length must be greater than 9.", new [] { "SuccessUrl" });
            }

            // MerchantReference (string) maxLength
            if (this.MerchantReference != null && this.MerchantReference.Length > 100)
            {
                yield return new ValidationResult("Invalid value for MerchantReference, length must be less than 100.", new [] { "MerchantReference" });
            }

            if (this.MerchantReference != null) {
                // MerchantReference (string) pattern
                Regex regexMerchantReference = new Regex(@"[	\x20-\x7e]*", RegexOptions.CultureInvariant);
                if (!regexMerchantReference.Match(this.MerchantReference).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantReference, must match a pattern of " + regexMerchantReference, new [] { "MerchantReference" });
                }
            }

            // FailedUrl (string) maxLength
            if (this.FailedUrl != null && this.FailedUrl.Length > 2000)
            {
                yield return new ValidationResult("Invalid value for FailedUrl, length must be less than 2000.", new [] { "FailedUrl" });
            }

            // FailedUrl (string) minLength
            if (this.FailedUrl != null && this.FailedUrl.Length < 9)
            {
                yield return new ValidationResult("Invalid value for FailedUrl, length must be greater than 9.", new [] { "FailedUrl" });
            }

            yield break;
        }
    }

}
