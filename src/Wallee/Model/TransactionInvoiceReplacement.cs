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
    /// TransactionInvoiceReplacement
    /// </summary>
    [DataContract(Name = "TransactionInvoiceReplacement")]
    public partial class TransactionInvoiceReplacement : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionInvoiceReplacement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionInvoiceReplacement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionInvoiceReplacement" /> class.
        /// </summary>
        /// <param name="lineItems">The invoiced line items that will appear on the invoice document. (required).</param>
        /// <param name="dueOn">The due date for payment of the invoice..</param>
        /// <param name="externalId">A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result. (required).</param>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="sentToCustomer">Whether the invoice will be sent to the customer via email..</param>
        /// <param name="merchantReference">The merchant&#39;s reference used to identify the invoice..</param>
        public TransactionInvoiceReplacement(List<LineItemCreate> lineItems = default, DateTime dueOn = default, string externalId = default, AddressCreate billingAddress = default, bool sentToCustomer = default, string merchantReference = default)
        {
            // to ensure "lineItems" is required (not null)
            if (lineItems == null)
            {
                throw new ArgumentNullException("lineItems is a required property for TransactionInvoiceReplacement and cannot be null");
            }
            this.LineItems = lineItems;
            // to ensure "externalId" is required (not null)
            if (externalId == null)
            {
                throw new ArgumentNullException("externalId is a required property for TransactionInvoiceReplacement and cannot be null");
            }
            this.ExternalId = externalId;
            this.DueOn = dueOn;
            this.BillingAddress = billingAddress;
            this.SentToCustomer = sentToCustomer;
            this.MerchantReference = merchantReference;
        }

        /// <summary>
        /// The invoiced line items that will appear on the invoice document.
        /// </summary>
        /// <value>The invoiced line items that will appear on the invoice document.</value>
        [DataMember(Name = "lineItems", IsRequired = true, EmitDefaultValue = true)]
        public List<LineItemCreate> LineItems { get; set; }

        /// <summary>
        /// The due date for payment of the invoice.
        /// </summary>
        /// <value>The due date for payment of the invoice.</value>
        [DataMember(Name = "dueOn", EmitDefaultValue = false)]
        public DateTime DueOn { get; set; }

        /// <summary>
        /// A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.
        /// </summary>
        /// <value>A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.</value>
        [DataMember(Name = "externalId", IsRequired = true, EmitDefaultValue = true)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name = "billingAddress", EmitDefaultValue = false)]
        public AddressCreate BillingAddress { get; set; }

        /// <summary>
        /// Whether the invoice will be sent to the customer via email.
        /// </summary>
        /// <value>Whether the invoice will be sent to the customer via email.</value>
        [DataMember(Name = "sentToCustomer", EmitDefaultValue = true)]
        public bool SentToCustomer { get; set; }

        /// <summary>
        /// The merchant&#39;s reference used to identify the invoice.
        /// </summary>
        /// <value>The merchant&#39;s reference used to identify the invoice.</value>
        [DataMember(Name = "merchantReference", EmitDefaultValue = false)]
        public string MerchantReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionInvoiceReplacement {\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  DueOn: ").Append(DueOn).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  SentToCustomer: ").Append(SentToCustomer).Append("\n");
            sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
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
            // ExternalId (string) maxLength
            if (this.ExternalId != null && this.ExternalId.Length > 100)
            {
                yield return new ValidationResult("Invalid value for ExternalId, length must be less than 100.", new [] { "ExternalId" });
            }

            // ExternalId (string) minLength
            if (this.ExternalId != null && this.ExternalId.Length < 1)
            {
                yield return new ValidationResult("Invalid value for ExternalId, length must be greater than 1.", new [] { "ExternalId" });
            }

            if (this.ExternalId != null) {
                // ExternalId (string) pattern
                Regex regexExternalId = new Regex(@"[	\x20-\x7e]*", RegexOptions.CultureInvariant);
                if (!regexExternalId.Match(this.ExternalId).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExternalId, must match a pattern of " + regexExternalId, new [] { "ExternalId" });
                }
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

            yield break;
        }
    }

}
