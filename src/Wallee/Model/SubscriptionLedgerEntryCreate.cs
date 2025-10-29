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
    /// The subscription ledger entry represents a single change on the subscription balance.
    /// </summary>
    [DataContract(Name = "SubscriptionLedgerEntry.Create")]
    public partial class SubscriptionLedgerEntryCreate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionLedgerEntryCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionLedgerEntryCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionLedgerEntryCreate" /> class.
        /// </summary>
        /// <param name="quantity">The number of items that were consumed. (required).</param>
        /// <param name="subscriptionVersion">The subscription version that the ledger entry belongs to. (required).</param>
        /// <param name="externalId">A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result. (required).</param>
        /// <param name="taxes">A set of tax lines, each of which specifies a tax applied to the ledger entry..</param>
        /// <param name="amountIncludingTax">The leger entry&#39;s amount with discounts applied, including taxes. (required).</param>
        /// <param name="title">The title that indicates what the ledger entry is about. (required).</param>
        /// <param name="componentReferenceName">componentReferenceName.</param>
        /// <param name="subscriptionMetricId">subscriptionMetricId.</param>
        public SubscriptionLedgerEntryCreate(decimal quantity = default(decimal), long subscriptionVersion = default(long), string externalId = default(string), List<TaxCreate> taxes = default(List<TaxCreate>), decimal amountIncludingTax = default(decimal), string title = default(string), string componentReferenceName = default(string), long subscriptionMetricId = default(long))
        {
            this.Quantity = quantity;
            this.SubscriptionVersion = subscriptionVersion;
            // to ensure "externalId" is required (not null)
            if (externalId == null)
            {
                throw new ArgumentNullException("externalId is a required property for SubscriptionLedgerEntryCreate and cannot be null");
            }
            this.ExternalId = externalId;
            this.AmountIncludingTax = amountIncludingTax;
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for SubscriptionLedgerEntryCreate and cannot be null");
            }
            this.Title = title;
            this.Taxes = taxes;
            this.ComponentReferenceName = componentReferenceName;
            this.SubscriptionMetricId = subscriptionMetricId;
        }

        /// <summary>
        /// The number of items that were consumed.
        /// </summary>
        /// <value>The number of items that were consumed.</value>
        [DataMember(Name = "quantity", IsRequired = true, EmitDefaultValue = true)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// The subscription version that the ledger entry belongs to.
        /// </summary>
        /// <value>The subscription version that the ledger entry belongs to.</value>
        [DataMember(Name = "subscriptionVersion", IsRequired = true, EmitDefaultValue = true)]
        public long SubscriptionVersion { get; set; }

        /// <summary>
        /// A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.
        /// </summary>
        /// <value>A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.</value>
        [DataMember(Name = "externalId", IsRequired = true, EmitDefaultValue = true)]
        public string ExternalId { get; set; }

        /// <summary>
        /// A set of tax lines, each of which specifies a tax applied to the ledger entry.
        /// </summary>
        /// <value>A set of tax lines, each of which specifies a tax applied to the ledger entry.</value>
        [DataMember(Name = "taxes", EmitDefaultValue = false)]
        public List<TaxCreate> Taxes { get; set; }

        /// <summary>
        /// The leger entry&#39;s amount with discounts applied, including taxes.
        /// </summary>
        /// <value>The leger entry&#39;s amount with discounts applied, including taxes.</value>
        [DataMember(Name = "amountIncludingTax", IsRequired = true, EmitDefaultValue = true)]
        public decimal AmountIncludingTax { get; set; }

        /// <summary>
        /// The title that indicates what the ledger entry is about.
        /// </summary>
        /// <value>The title that indicates what the ledger entry is about.</value>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets ComponentReferenceName
        /// </summary>
        [DataMember(Name = "componentReferenceName", EmitDefaultValue = false)]
        public string ComponentReferenceName { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionMetricId
        /// </summary>
        [DataMember(Name = "subscriptionMetricId", EmitDefaultValue = false)]
        public long SubscriptionMetricId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscriptionLedgerEntryCreate {\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  SubscriptionVersion: ").Append(SubscriptionVersion).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Taxes: ").Append(Taxes).Append("\n");
            sb.Append("  AmountIncludingTax: ").Append(AmountIncludingTax).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  ComponentReferenceName: ").Append(ComponentReferenceName).Append("\n");
            sb.Append("  SubscriptionMetricId: ").Append(SubscriptionMetricId).Append("\n");
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
            // Title (string) maxLength
            if (this.Title != null && this.Title.Length > 150)
            {
                yield return new ValidationResult("Invalid value for Title, length must be less than 150.", new [] { "Title" });
            }

            // Title (string) minLength
            if (this.Title != null && this.Title.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Title, length must be greater than 1.", new [] { "Title" });
            }

            yield break;
        }
    }

}
