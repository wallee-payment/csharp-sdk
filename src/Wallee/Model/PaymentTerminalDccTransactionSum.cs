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
    /// Represents the aggregated summary of Dynamic Currency Conversion (DCC) transactions grouped by brand and currency combinations in a transaction summary receipt.
    /// </summary>
    [DataContract(Name = "PaymentTerminalDccTransactionSum")]
    public partial class PaymentTerminalDccTransactionSum : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTerminalDccTransactionSum" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentTerminalDccTransactionSum()
        {
        }

        /// <summary>
        /// The original currency of the transactions before DCC conversion (typically the merchant&#39;s local currency).
        /// </summary>
        /// <value>The original currency of the transactions before DCC conversion (typically the merchant&#39;s local currency).</value>
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
        /// The total sum of all transactions in the original transaction currency (the amount in merchant&#39;s local currency before DCC conversion).
        /// </summary>
        /// <value>The total sum of all transactions in the original transaction currency (the amount in merchant&#39;s local currency before DCC conversion).</value>
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
        /// The total sum of all transactions in the converted DCC currency (the amount paid by customers in their chosen currency).
        /// </summary>
        /// <value>The total sum of all transactions in the converted DCC currency (the amount paid by customers in their chosen currency).</value>
        [DataMember(Name = "dccAmount", EmitDefaultValue = false)]
        public decimal DccAmount { get; private set; }

        /// <summary>
        /// Returns false as DccAmount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDccAmount()
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
        /// The total count of DCC transactions processed for this specific brand and currency combination.
        /// </summary>
        /// <value>The total count of DCC transactions processed for this specific brand and currency combination.</value>
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
        /// The converted currency used in DCC transactions (the currency chosen by the customer for payment).
        /// </summary>
        /// <value>The converted currency used in DCC transactions (the currency chosen by the customer for payment).</value>
        [DataMember(Name = "dccCurrency", EmitDefaultValue = false)]
        public string DccCurrency { get; private set; }

        /// <summary>
        /// Returns false as DccCurrency should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDccCurrency()
        {
            return false;
        }
        /// <summary>
        /// The payment brand for which these DCC transactions are summarized.
        /// </summary>
        /// <value>The payment brand for which these DCC transactions are summarized.</value>
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentTerminalDccTransactionSum {\n");
            sb.Append("  TransactionCurrency: ").Append(TransactionCurrency).Append("\n");
            sb.Append("  TransactionAmount: ").Append(TransactionAmount).Append("\n");
            sb.Append("  DccAmount: ").Append(DccAmount).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TransactionCount: ").Append(TransactionCount).Append("\n");
            sb.Append("  DccCurrency: ").Append(DccCurrency).Append("\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
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
            yield break;
        }
    }

}
