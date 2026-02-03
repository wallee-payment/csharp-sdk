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
    /// A refund is a credit issued to the customer, which can be initiated either by the merchant or by the customer as a reversal.
    /// </summary>
    [DataContract(Name = "Refund.Create")]
    public partial class RefundCreate : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public RefundType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RefundCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundCreate" /> class.
        /// </summary>
        /// <param name="completion">The transaction completion that the refund belongs to..</param>
        /// <param name="metaData">Allow to store additional information about the object..</param>
        /// <param name="amount">The total monetary amount of the refund, representing the exact credit issued to the customer..</param>
        /// <param name="reductions">The reductions applied on the original transaction items, detailing specific adjustments associated with the refund..</param>
        /// <param name="externalId">A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result. (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="merchantReference">The merchant&#39;s reference used to identify the refund..</param>
        /// <param name="transaction">The transaction that the refund belongs to..</param>
        public RefundCreate(long completion = default, Dictionary<string, string> metaData = default, decimal amount = default, List<LineItemReductionCreate> reductions = default, string externalId = default, RefundType type = default, string merchantReference = default, long transaction = default)
        {
            // to ensure "externalId" is required (not null)
            if (externalId == null)
            {
                throw new ArgumentNullException("externalId is a required property for RefundCreate and cannot be null");
            }
            this.ExternalId = externalId;
            this.Type = type;
            this.Completion = completion;
            this.MetaData = metaData;
            this.Amount = amount;
            this.Reductions = reductions;
            this.MerchantReference = merchantReference;
            this.Transaction = transaction;
        }

        /// <summary>
        /// The transaction completion that the refund belongs to.
        /// </summary>
        /// <value>The transaction completion that the refund belongs to.</value>
        [DataMember(Name = "completion", EmitDefaultValue = false)]
        public long Completion { get; set; }

        /// <summary>
        /// Allow to store additional information about the object.
        /// </summary>
        /// <value>Allow to store additional information about the object.</value>
        [DataMember(Name = "metaData", EmitDefaultValue = false)]
        public Dictionary<string, string> MetaData { get; set; }

        /// <summary>
        /// The total monetary amount of the refund, representing the exact credit issued to the customer.
        /// </summary>
        /// <value>The total monetary amount of the refund, representing the exact credit issued to the customer.</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public decimal Amount { get; set; }

        /// <summary>
        /// The reductions applied on the original transaction items, detailing specific adjustments associated with the refund.
        /// </summary>
        /// <value>The reductions applied on the original transaction items, detailing specific adjustments associated with the refund.</value>
        [DataMember(Name = "reductions", EmitDefaultValue = false)]
        public List<LineItemReductionCreate> Reductions { get; set; }

        /// <summary>
        /// A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.
        /// </summary>
        /// <value>A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.</value>
        [DataMember(Name = "externalId", IsRequired = true, EmitDefaultValue = true)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The merchant&#39;s reference used to identify the refund.
        /// </summary>
        /// <value>The merchant&#39;s reference used to identify the refund.</value>
        [DataMember(Name = "merchantReference", EmitDefaultValue = false)]
        public string MerchantReference { get; set; }

        /// <summary>
        /// The transaction that the refund belongs to.
        /// </summary>
        /// <value>The transaction that the refund belongs to.</value>
        [DataMember(Name = "transaction", EmitDefaultValue = false)]
        public long Transaction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RefundCreate {\n");
            sb.Append("  Completion: ").Append(Completion).Append("\n");
            sb.Append("  MetaData: ").Append(MetaData).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Reductions: ").Append(Reductions).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
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
