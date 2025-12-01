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
    /// BankTransaction
    /// </summary>
    [DataContract(Name = "BankTransaction")]
    public partial class BankTransaction : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets FlowDirection
        /// </summary>
        [DataMember(Name = "flowDirection", EmitDefaultValue = false)]
        public BankTransactionFlowDirection? FlowDirection { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public BankTransactionState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BankTransaction" /> class.
        /// </summary>
        /// <param name="currencyBankAccount">currencyBankAccount.</param>
        /// <param name="flowDirection">flowDirection.</param>
        /// <param name="state">state.</param>
        public BankTransaction(CurrencyBankAccount currencyBankAccount = default, BankTransactionFlowDirection? flowDirection = default, BankTransactionState? state = default)
        {
            this.CurrencyBankAccount = currencyBankAccount;
            this.FlowDirection = flowDirection;
            this.State = state;
        }

        /// <summary>
        /// Adjustments are changes made to the initial transaction amount, such as fees or corrections.
        /// </summary>
        /// <value>Adjustments are changes made to the initial transaction amount, such as fees or corrections.</value>
        [DataMember(Name = "adjustments", EmitDefaultValue = false)]
        public List<PaymentAdjustment> Adjustments { get; private set; }

        /// <summary>
        /// Returns false as Adjustments should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAdjustments()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CurrencyBankAccount
        /// </summary>
        [DataMember(Name = "currencyBankAccount", EmitDefaultValue = false)]
        public CurrencyBankAccount CurrencyBankAccount { get; set; }

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
        /// A client generated nonce which identifies the entity to be created. Subsequent creation requests with the same external ID will not create new entities but return the initially created entity instead.
        /// </summary>
        /// <value>A client generated nonce which identifies the entity to be created. Subsequent creation requests with the same external ID will not create new entities but return the initially created entity instead.</value>
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
        /// The posting amount refers to the monetary value recorded for the bank transaction prior to any adjustments.
        /// </summary>
        /// <value>The posting amount refers to the monetary value recorded for the bank transaction prior to any adjustments.</value>
        [DataMember(Name = "postingAmount", EmitDefaultValue = false)]
        public decimal PostingAmount { get; private set; }

        /// <summary>
        /// Returns false as PostingAmount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePostingAmount()
        {
            return false;
        }
        /// <summary>
        /// The source indicates how the bank transaction was created.
        /// </summary>
        /// <value>The source indicates how the bank transaction was created.</value>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public long Source { get; private set; }

        /// <summary>
        /// Returns false as Source should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSource()
        {
            return false;
        }
        /// <summary>
        /// The value date indicates the date on which the transaction amount becomes effective.
        /// </summary>
        /// <value>The value date indicates the date on which the transaction amount becomes effective.</value>
        [DataMember(Name = "valueDate", EmitDefaultValue = false)]
        public DateTime ValueDate { get; private set; }

        /// <summary>
        /// Returns false as ValueDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeValueDate()
        {
            return false;
        }
        /// <summary>
        /// The bank transaction&#39;s type.
        /// </summary>
        /// <value>The bank transaction&#39;s type.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public long Type { get; private set; }

        /// <summary>
        /// Returns false as Type should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeType()
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
        /// A unique reference to identify the bank transaction.
        /// </summary>
        /// <value>A unique reference to identify the bank transaction.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; private set; }

        /// <summary>
        /// Returns false as Reference should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeReference()
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
        /// The value amount represents the net monetary value of the transaction after applicable deductions.
        /// </summary>
        /// <value>The value amount represents the net monetary value of the transaction after applicable deductions.</value>
        [DataMember(Name = "valueAmount", EmitDefaultValue = false)]
        public decimal ValueAmount { get; private set; }

        /// <summary>
        /// Returns false as ValueAmount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeValueAmount()
        {
            return false;
        }
        /// <summary>
        /// The ID of the user the bank transaction was created by.
        /// </summary>
        /// <value>The ID of the user the bank transaction was created by.</value>
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
        /// The payment date specifies the date on which the payment was processed.
        /// </summary>
        /// <value>The payment date specifies the date on which the payment was processed.</value>
        [DataMember(Name = "paymentDate", EmitDefaultValue = false)]
        public DateTime PaymentDate { get; private set; }

        /// <summary>
        /// Returns false as PaymentDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePaymentDate()
        {
            return false;
        }
        /// <summary>
        /// Represents the total value of all adjustments to the bank transaction, including tax.
        /// </summary>
        /// <value>Represents the total value of all adjustments to the bank transaction, including tax.</value>
        [DataMember(Name = "totalAdjustmentAmountIncludingTax", EmitDefaultValue = false)]
        public decimal TotalAdjustmentAmountIncludingTax { get; private set; }

        /// <summary>
        /// Returns false as TotalAdjustmentAmountIncludingTax should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTotalAdjustmentAmountIncludingTax()
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
            sb.Append("class BankTransaction {\n");
            sb.Append("  Adjustments: ").Append(Adjustments).Append("\n");
            sb.Append("  CurrencyBankAccount: ").Append(CurrencyBankAccount).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  PostingAmount: ").Append(PostingAmount).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  ValueDate: ").Append(ValueDate).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  ValueAmount: ").Append(ValueAmount).Append("\n");
            sb.Append("  FlowDirection: ").Append(FlowDirection).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  PaymentDate: ").Append(PaymentDate).Append("\n");
            sb.Append("  TotalAdjustmentAmountIncludingTax: ").Append(TotalAdjustmentAmountIncludingTax).Append("\n");
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

            yield break;
        }
    }

}
