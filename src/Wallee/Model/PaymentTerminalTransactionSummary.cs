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
    /// PaymentTerminalTransactionSummary
    /// </summary>
    [DataContract(Name = "PaymentTerminalTransactionSummary")]
    public partial class PaymentTerminalTransactionSummary : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTerminalTransactionSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentTerminalTransactionSummary()
        {
        }

        /// <summary>
        /// The unique reference assigned to this transaction summary.
        /// </summary>
        /// <value>The unique reference assigned to this transaction summary.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public long Reference { get; private set; }

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
        /// The total monetary amounts of all transactions, organized and grouped by brand and currency.
        /// </summary>
        /// <value>The total monetary amounts of all transactions, organized and grouped by brand and currency.</value>
        [DataMember(Name = "transactionSums", EmitDefaultValue = false)]
        public List<PaymentTerminalTransactionSum> TransactionSums { get; private set; }

        /// <summary>
        /// Returns false as TransactionSums should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTransactionSums()
        {
            return false;
        }
        /// <summary>
        /// Detailed breakdown of Dynamic Currency Conversion (DCC) transactions, showing transaction amounts in both original and converted currencies, grouped by payment brand.
        /// </summary>
        /// <value>Detailed breakdown of Dynamic Currency Conversion (DCC) transactions, showing transaction amounts in both original and converted currencies, grouped by payment brand.</value>
        [DataMember(Name = "dccTransactionSums", EmitDefaultValue = false)]
        public List<PaymentTerminalDccTransactionSum> DccTransactionSums { get; private set; }

        /// <summary>
        /// Returns false as DccTransactionSums should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDccTransactionSums()
        {
            return false;
        }
        /// <summary>
        /// The end of the time period covered by this summary report.
        /// </summary>
        /// <value>The end of the time period covered by this summary report.</value>
        [DataMember(Name = "endedOn", EmitDefaultValue = false)]
        public DateTime EndedOn { get; private set; }

        /// <summary>
        /// Returns false as EndedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEndedOn()
        {
            return false;
        }
        /// <summary>
        /// The overall transaction volume in each processed currency.
        /// </summary>
        /// <value>The overall transaction volume in each processed currency.</value>
        [DataMember(Name = "balanceAmountPerCurrency", EmitDefaultValue = false)]
        public Dictionary<string, decimal> BalanceAmountPerCurrency { get; private set; }

        /// <summary>
        /// Returns false as BalanceAmountPerCurrency should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBalanceAmountPerCurrency()
        {
            return false;
        }
        /// <summary>
        /// The payment terminal that processed the transactions included in this summary report.
        /// </summary>
        /// <value>The payment terminal that processed the transactions included in this summary report.</value>
        [DataMember(Name = "paymentTerminal", EmitDefaultValue = false)]
        public long PaymentTerminal { get; private set; }

        /// <summary>
        /// Returns false as PaymentTerminal should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePaymentTerminal()
        {
            return false;
        }
        /// <summary>
        /// The HTML content of the transaction summary receipt.
        /// </summary>
        /// <value>The HTML content of the transaction summary receipt.</value>
        [DataMember(Name = "receipt", EmitDefaultValue = false)]
        public string Receipt { get; private set; }

        /// <summary>
        /// Returns false as Receipt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeReceipt()
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
        /// The total count of all transactions processed by the terminal during the summary period.
        /// </summary>
        /// <value>The total count of all transactions processed by the terminal during the summary period.</value>
        [DataMember(Name = "numberOfTransactions", EmitDefaultValue = false)]
        public int NumberOfTransactions { get; private set; }

        /// <summary>
        /// Returns false as NumberOfTransactions should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNumberOfTransactions()
        {
            return false;
        }
        /// <summary>
        /// The beginning of the time period covered by this summary report.
        /// </summary>
        /// <value>The beginning of the time period covered by this summary report.</value>
        [DataMember(Name = "startedOn", EmitDefaultValue = false)]
        public DateTime StartedOn { get; private set; }

        /// <summary>
        /// Returns false as StartedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStartedOn()
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
            sb.Append("class PaymentTerminalTransactionSummary {\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  TransactionSums: ").Append(TransactionSums).Append("\n");
            sb.Append("  DccTransactionSums: ").Append(DccTransactionSums).Append("\n");
            sb.Append("  EndedOn: ").Append(EndedOn).Append("\n");
            sb.Append("  BalanceAmountPerCurrency: ").Append(BalanceAmountPerCurrency).Append("\n");
            sb.Append("  PaymentTerminal: ").Append(PaymentTerminal).Append("\n");
            sb.Append("  Receipt: ").Append(Receipt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  NumberOfTransactions: ").Append(NumberOfTransactions).Append("\n");
            sb.Append("  StartedOn: ").Append(StartedOn).Append("\n");
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
