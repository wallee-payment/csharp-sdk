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
    /// ChargeBankTransaction
    /// </summary>
    [DataContract(Name = "ChargeBankTransaction")]
    public partial class ChargeBankTransaction : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeBankTransaction" /> class.
        /// </summary>
        /// <param name="completion">completion.</param>
        /// <param name="bankTransaction">bankTransaction.</param>
        /// <param name="transaction">transaction.</param>
        public ChargeBankTransaction(TransactionCompletion completion = default(TransactionCompletion), BankTransaction bankTransaction = default(BankTransaction), Transaction transaction = default(Transaction))
        {
            this.Completion = completion;
            this.BankTransaction = bankTransaction;
            this.Transaction = transaction;
        }

        /// <summary>
        /// The posting amount represents the monetary value of the bank transaction, recorded in the payment transaction&#39;s currency, before applying any adjustments.
        /// </summary>
        /// <value>The posting amount represents the monetary value of the bank transaction, recorded in the payment transaction&#39;s currency, before applying any adjustments.</value>
        [DataMember(Name = "transactionCurrencyAmount", EmitDefaultValue = false)]
        public decimal TransactionCurrencyAmount { get; private set; }

        /// <summary>
        /// Returns false as TransactionCurrencyAmount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTransactionCurrencyAmount()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Completion
        /// </summary>
        [DataMember(Name = "completion", EmitDefaultValue = false)]
        public TransactionCompletion Completion { get; set; }

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
        /// The language that is linked to the object.
        /// </summary>
        /// <value>The language that is linked to the object.</value>
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
        /// The ID of the space view this object is linked to.
        /// </summary>
        /// <value>The ID of the space view this object is linked to.</value>
        [DataMember(Name = "spaceViewId", EmitDefaultValue = false)]
        public long SpaceViewId { get; private set; }

        /// <summary>
        /// Returns false as SpaceViewId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSpaceViewId()
        {
            return false;
        }
        /// <summary>
        /// The payment transaction this object is linked to.
        /// </summary>
        /// <value>The payment transaction this object is linked to.</value>
        [DataMember(Name = "linkedTransaction", EmitDefaultValue = false)]
        public long LinkedTransaction { get; private set; }

        /// <summary>
        /// Returns false as LinkedTransaction should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLinkedTransaction()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets BankTransaction
        /// </summary>
        [DataMember(Name = "bankTransaction", EmitDefaultValue = false)]
        public BankTransaction BankTransaction { get; set; }

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
        /// Gets or Sets Transaction
        /// </summary>
        [DataMember(Name = "transaction", EmitDefaultValue = false)]
        public Transaction Transaction { get; set; }

        /// <summary>
        /// The value amount represents the net monetary value of the bank transaction, recorded in the payment transaction&#39;s currency, after applicable deductions.
        /// </summary>
        /// <value>The value amount represents the net monetary value of the bank transaction, recorded in the payment transaction&#39;s currency, after applicable deductions.</value>
        [DataMember(Name = "transactionCurrencyValueAmount", EmitDefaultValue = false)]
        public decimal TransactionCurrencyValueAmount { get; private set; }

        /// <summary>
        /// Returns false as TransactionCurrencyValueAmount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTransactionCurrencyValueAmount()
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
            sb.Append("class ChargeBankTransaction {\n");
            sb.Append("  TransactionCurrencyAmount: ").Append(TransactionCurrencyAmount).Append("\n");
            sb.Append("  Completion: ").Append(Completion).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SpaceViewId: ").Append(SpaceViewId).Append("\n");
            sb.Append("  LinkedTransaction: ").Append(LinkedTransaction).Append("\n");
            sb.Append("  BankTransaction: ").Append(BankTransaction).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
            sb.Append("  TransactionCurrencyValueAmount: ").Append(TransactionCurrencyValueAmount).Append("\n");
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
