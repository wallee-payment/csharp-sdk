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
    /// Represents the aggregated transaction data for a specific brand and currency, including regular and DCC (Dynamic Currency Conversion) transactions.
    /// </summary>
    [DataContract(Name = "PaymentTerminalTransactionSum")]
    public partial class PaymentTerminalTransactionSum : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTerminalTransactionSum" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentTerminalTransactionSum()
        {
        }

        /// <summary>
        /// The total amount of tips from regular (non-DCC) transactions in the transaction currency.
        /// </summary>
        /// <value>The total amount of tips from regular (non-DCC) transactions in the transaction currency.</value>
        [DataMember(Name = "transactionTipAmount", EmitDefaultValue = false)]
        public decimal TransactionTipAmount { get; private set; }

        /// <summary>
        /// Returns false as TransactionTipAmount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTransactionTipAmount()
        {
            return false;
        }
        /// <summary>
        /// The product within the brand for which transactions are summarized.
        /// </summary>
        /// <value>The product within the brand for which transactions are summarized.</value>
        [DataMember(Name = "product", EmitDefaultValue = false)]
        public string Product { get; private set; }

        /// <summary>
        /// Returns false as Product should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProduct()
        {
            return false;
        }
        /// <summary>
        /// The base currency in which the transactions were processed and settled, excluding any DCC conversions.
        /// </summary>
        /// <value>The base currency in which the transactions were processed and settled, excluding any DCC conversions.</value>
        [DataMember(Name = "transactionCurrency", EmitDefaultValue = false)]
        public string TransactionCurrency { get; private set; }

        /// <summary>
        /// Returns false as TransactionCurrency should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTransactionCurrency()
        {
            return false;
        }
        /// <summary>
        /// The total monetary value of all transactions in the transaction currency, excluding DCC transactions.
        /// </summary>
        /// <value>The total monetary value of all transactions in the transaction currency, excluding DCC transactions.</value>
        [DataMember(Name = "transactionAmount", EmitDefaultValue = false)]
        public decimal TransactionAmount { get; private set; }

        /// <summary>
        /// Returns false as TransactionAmount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTransactionAmount()
        {
            return false;
        }
        /// <summary>
        /// The total amount of tips from DCC transactions, converted and presented in the transaction currency.
        /// </summary>
        /// <value>The total amount of tips from DCC transactions, converted and presented in the transaction currency.</value>
        [DataMember(Name = "dccTipAmount", EmitDefaultValue = false)]
        public decimal DccTipAmount { get; private set; }

        /// <summary>
        /// Returns false as DccTipAmount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDccTipAmount()
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
        /// The total count of regular (non-DCC) transactions processed within this summary period.
        /// </summary>
        /// <value>The total count of regular (non-DCC) transactions processed within this summary period.</value>
        [DataMember(Name = "transactionCount", EmitDefaultValue = false)]
        public int TransactionCount { get; private set; }

        /// <summary>
        /// Returns false as TransactionCount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTransactionCount()
        {
            return false;
        }
        /// <summary>
        /// The payment brand for which the transactions are summarized.
        /// </summary>
        /// <value>The payment brand for which the transactions are summarized.</value>
        [DataMember(Name = "brand", EmitDefaultValue = false)]
        public string Brand { get; private set; }

        /// <summary>
        /// Returns false as Brand should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBrand()
        {
            return false;
        }
        /// <summary>
        /// The number of transactions where Dynamic Currency Conversion (DCC) was applied, allowing customers to pay in their home currency.
        /// </summary>
        /// <value>The number of transactions where Dynamic Currency Conversion (DCC) was applied, allowing customers to pay in their home currency.</value>
        [DataMember(Name = "dccTransactionCount", EmitDefaultValue = false)]
        public int DccTransactionCount { get; private set; }

        /// <summary>
        /// Returns false as DccTransactionCount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDccTransactionCount()
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
        /// The total monetary value of DCC transactions, converted and presented in the transaction currency.
        /// </summary>
        /// <value>The total monetary value of DCC transactions, converted and presented in the transaction currency.</value>
        [DataMember(Name = "dccTransactionAmount", EmitDefaultValue = false)]
        public decimal DccTransactionAmount { get; private set; }

        /// <summary>
        /// Returns false as DccTransactionAmount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDccTransactionAmount()
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
            sb.Append("class PaymentTerminalTransactionSum {\n");
            sb.Append("  TransactionTipAmount: ").Append(TransactionTipAmount).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  TransactionCurrency: ").Append(TransactionCurrency).Append("\n");
            sb.Append("  TransactionAmount: ").Append(TransactionAmount).Append("\n");
            sb.Append("  DccTipAmount: ").Append(DccTipAmount).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TransactionCount: ").Append(TransactionCount).Append("\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  DccTransactionCount: ").Append(DccTransactionCount).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  DccTransactionAmount: ").Append(DccTransactionAmount).Append("\n");
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
