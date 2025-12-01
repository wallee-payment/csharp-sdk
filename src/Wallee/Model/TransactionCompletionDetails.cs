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
    /// TransactionCompletionDetails
    /// </summary>
    [DataContract(Name = "TransactionCompletionDetails")]
    public partial class TransactionCompletionDetails : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionCompletionDetails" /> class.
        /// </summary>
        /// <param name="lineItems">The line items to be captured in the transaction completion..</param>
        /// <param name="lastCompletion">Whether this is the final completion for the transaction, meaning no further completions can occur, and the transaction will move to its completed state upon success..</param>
        /// <param name="statementDescriptor">The statement descriptor that appears on a customer&#39;s bank statement, providing an explanation for charges or payments, helping customers identify the transaction..</param>
        /// <param name="externalId">A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result..</param>
        /// <param name="invoiceMerchantReference">The merchant&#39;s reference used to identify the invoice..</param>
        public TransactionCompletionDetails(List<CompletionLineItemCreate> lineItems = default, bool lastCompletion = default, string statementDescriptor = default, string externalId = default, string invoiceMerchantReference = default)
        {
            this.LineItems = lineItems;
            this.LastCompletion = lastCompletion;
            this.StatementDescriptor = statementDescriptor;
            this.ExternalId = externalId;
            this.InvoiceMerchantReference = invoiceMerchantReference;
        }

        /// <summary>
        /// The line items to be captured in the transaction completion.
        /// </summary>
        /// <value>The line items to be captured in the transaction completion.</value>
        [DataMember(Name = "lineItems", EmitDefaultValue = false)]
        public List<CompletionLineItemCreate> LineItems { get; set; }

        /// <summary>
        /// Whether this is the final completion for the transaction, meaning no further completions can occur, and the transaction will move to its completed state upon success.
        /// </summary>
        /// <value>Whether this is the final completion for the transaction, meaning no further completions can occur, and the transaction will move to its completed state upon success.</value>
        [DataMember(Name = "lastCompletion", EmitDefaultValue = true)]
        public bool LastCompletion { get; set; }

        /// <summary>
        /// The statement descriptor that appears on a customer&#39;s bank statement, providing an explanation for charges or payments, helping customers identify the transaction.
        /// </summary>
        /// <value>The statement descriptor that appears on a customer&#39;s bank statement, providing an explanation for charges or payments, helping customers identify the transaction.</value>
        [DataMember(Name = "statementDescriptor", EmitDefaultValue = false)]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.
        /// </summary>
        /// <value>A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.</value>
        [DataMember(Name = "externalId", EmitDefaultValue = false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The merchant&#39;s reference used to identify the invoice.
        /// </summary>
        /// <value>The merchant&#39;s reference used to identify the invoice.</value>
        [DataMember(Name = "invoiceMerchantReference", EmitDefaultValue = false)]
        public string InvoiceMerchantReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionCompletionDetails {\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  LastCompletion: ").Append(LastCompletion).Append("\n");
            sb.Append("  StatementDescriptor: ").Append(StatementDescriptor).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  InvoiceMerchantReference: ").Append(InvoiceMerchantReference).Append("\n");
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
            // StatementDescriptor (string) maxLength
            if (this.StatementDescriptor != null && this.StatementDescriptor.Length > 80)
            {
                yield return new ValidationResult("Invalid value for StatementDescriptor, length must be less than 80.", new [] { "StatementDescriptor" });
            }

            if (this.StatementDescriptor != null) {
                // StatementDescriptor (string) pattern
                Regex regexStatementDescriptor = new Regex(@"[a-zA-Z0-9\s.,_?+/-]*", RegexOptions.CultureInvariant);
                if (!regexStatementDescriptor.Match(this.StatementDescriptor).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StatementDescriptor, must match a pattern of " + regexStatementDescriptor, new [] { "StatementDescriptor" });
                }
            }

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

            yield break;
        }
    }

}
