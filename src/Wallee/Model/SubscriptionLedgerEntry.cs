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
    [DataContract(Name = "SubscriptionLedgerEntry")]
    public partial class SubscriptionLedgerEntry : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets FeeType
        /// </summary>
        [DataMember(Name = "feeType", EmitDefaultValue = false)]
        public ProductFeeType? FeeType { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public SubscriptionLedgerEntryState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionLedgerEntry" /> class.
        /// </summary>
        /// <param name="feeType">feeType.</param>
        /// <param name="state">state.</param>
        public SubscriptionLedgerEntry(ProductFeeType? feeType = default(ProductFeeType?), SubscriptionLedgerEntryState? state = default(SubscriptionLedgerEntryState?))
        {
            this.FeeType = feeType;
            this.State = state;
        }

        /// <summary>
        /// The number of items that were consumed.
        /// </summary>
        /// <value>The number of items that were consumed.</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public decimal Quantity { get; private set; }

        /// <summary>
        /// Returns false as Quantity should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeQuantity()
        {
            return false;
        }
        /// <summary>
        /// The leger entry&#39;s amount with discounts applied, excluding taxes.
        /// </summary>
        /// <value>The leger entry&#39;s amount with discounts applied, excluding taxes.</value>
        [DataMember(Name = "amountExcludingTax", EmitDefaultValue = false)]
        public decimal AmountExcludingTax { get; private set; }

        /// <summary>
        /// Returns false as AmountExcludingTax should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAmountExcludingTax()
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
        /// The subscription version that the ledger entry belongs to.
        /// </summary>
        /// <value>The subscription version that the ledger entry belongs to.</value>
        [DataMember(Name = "subscriptionVersion", EmitDefaultValue = false)]
        public long SubscriptionVersion { get; private set; }

        /// <summary>
        /// Returns false as SubscriptionVersion should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSubscriptionVersion()
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
        /// A set of tax lines, each of which specifies a tax applied to the ledger entry.
        /// </summary>
        /// <value>A set of tax lines, each of which specifies a tax applied to the ledger entry.</value>
        [DataMember(Name = "taxes", EmitDefaultValue = false)]
        public List<Tax> Taxes { get; private set; }

        /// <summary>
        /// Returns false as Taxes should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTaxes()
        {
            return false;
        }
        /// <summary>
        /// The title that indicates what the ledger entry is about.
        /// </summary>
        /// <value>The title that indicates what the ledger entry is about.</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; private set; }

        /// <summary>
        /// Returns false as Title should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTitle()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the object was created.
        /// </summary>
        /// <value>The date and time when the object was created.</value>
        [DataMember(Name = "createdOn", EmitDefaultValue = false)]
        public DateTime CreatedOn { get; private set; }

        /// <summary>
        /// Returns false as CreatedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedOn()
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
        /// Gets or Sets ComponentReferenceName
        /// </summary>
        [DataMember(Name = "componentReferenceName", EmitDefaultValue = false)]
        public string ComponentReferenceName { get; private set; }

        /// <summary>
        /// Returns false as ComponentReferenceName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeComponentReferenceName()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets SubscriptionMetricId
        /// </summary>
        [DataMember(Name = "subscriptionMetricId", EmitDefaultValue = false)]
        public long SubscriptionMetricId { get; private set; }

        /// <summary>
        /// Returns false as SubscriptionMetricId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSubscriptionMetricId()
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
        /// Gets or Sets ProRataCalculated
        /// </summary>
        [DataMember(Name = "proRataCalculated", EmitDefaultValue = true)]
        public bool ProRataCalculated { get; private set; }

        /// <summary>
        /// Returns false as ProRataCalculated should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProRataCalculated()
        {
            return false;
        }
        /// <summary>
        /// The ID of the user the ledger entry was created by.
        /// </summary>
        /// <value>The ID of the user the ledger entry was created by.</value>
        [DataMember(Name = "createdBy", EmitDefaultValue = false)]
        public long CreatedBy { get; private set; }

        /// <summary>
        /// Returns false as CreatedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedBy()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ComponentReferenceSku
        /// </summary>
        [DataMember(Name = "componentReferenceSku", EmitDefaultValue = false)]
        public string ComponentReferenceSku { get; private set; }

        /// <summary>
        /// Returns false as ComponentReferenceSku should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeComponentReferenceSku()
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
        /// The leger entry&#39;s amount with discounts applied, including taxes.
        /// </summary>
        /// <value>The leger entry&#39;s amount with discounts applied, including taxes.</value>
        [DataMember(Name = "amountIncludingTax", EmitDefaultValue = false)]
        public decimal AmountIncludingTax { get; private set; }

        /// <summary>
        /// Returns false as AmountIncludingTax should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAmountIncludingTax()
        {
            return false;
        }
        /// <summary>
        /// The discount allocated to the ledger entry, including taxes.
        /// </summary>
        /// <value>The discount allocated to the ledger entry, including taxes.</value>
        [DataMember(Name = "discountIncludingTax", EmitDefaultValue = false)]
        public decimal DiscountIncludingTax { get; private set; }

        /// <summary>
        /// Returns false as DiscountIncludingTax should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDiscountIncludingTax()
        {
            return false;
        }
        /// <summary>
        /// The sum of all taxes applied to the ledger entry.
        /// </summary>
        /// <value>The sum of all taxes applied to the ledger entry.</value>
        [DataMember(Name = "taxAmount", EmitDefaultValue = false)]
        public decimal TaxAmount { get; private set; }

        /// <summary>
        /// Returns false as TaxAmount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTaxAmount()
        {
            return false;
        }
        /// <summary>
        /// The total tax rate applied to the ledger entry, calculated from the rates of all tax lines.
        /// </summary>
        /// <value>The total tax rate applied to the ledger entry, calculated from the rates of all tax lines.</value>
        [DataMember(Name = "aggregatedTaxRate", EmitDefaultValue = false)]
        public decimal AggregatedTaxRate { get; private set; }

        /// <summary>
        /// Returns false as AggregatedTaxRate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAggregatedTaxRate()
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
            sb.Append("class SubscriptionLedgerEntry {\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  AmountExcludingTax: ").Append(AmountExcludingTax).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  SubscriptionVersion: ").Append(SubscriptionVersion).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Taxes: ").Append(Taxes).Append("\n");
            sb.Append("  FeeType: ").Append(FeeType).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  ComponentReferenceName: ").Append(ComponentReferenceName).Append("\n");
            sb.Append("  SubscriptionMetricId: ").Append(SubscriptionMetricId).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  ProRataCalculated: ").Append(ProRataCalculated).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  ComponentReferenceSku: ").Append(ComponentReferenceSku).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  AmountIncludingTax: ").Append(AmountIncludingTax).Append("\n");
            sb.Append("  DiscountIncludingTax: ").Append(DiscountIncludingTax).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  AggregatedTaxRate: ").Append(AggregatedTaxRate).Append("\n");
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

            // ComponentReferenceSku (string) maxLength
            if (this.ComponentReferenceSku != null && this.ComponentReferenceSku.Length > 100)
            {
                yield return new ValidationResult("Invalid value for ComponentReferenceSku, length must be less than 100.", new [] { "ComponentReferenceSku" });
            }

            if (this.ComponentReferenceSku != null) {
                // ComponentReferenceSku (string) pattern
                Regex regexComponentReferenceSku = new Regex(@"([0-9a-zA-Z\-_]+)", RegexOptions.CultureInvariant);
                if (!regexComponentReferenceSku.Match(this.ComponentReferenceSku).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ComponentReferenceSku, must match a pattern of " + regexComponentReferenceSku, new [] { "ComponentReferenceSku" });
                }
            }

            yield break;
        }
    }

}
