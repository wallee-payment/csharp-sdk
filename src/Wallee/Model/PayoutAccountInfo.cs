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
    /// PayoutAccountInfo
    /// </summary>
    [DataContract(Name = "PayoutAccountInfo")]
    public partial class PayoutAccountInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutAccountInfo" /> class.
        /// </summary>
        /// <param name="iban">iban.</param>
        /// <param name="bankName">bankName.</param>
        /// <param name="currency">currency.</param>
        /// <param name="bic">bic.</param>
        public PayoutAccountInfo(string iban = default, string bankName = default, string currency = default, string bic = default)
        {
            this.Iban = iban;
            this.BankName = bankName;
            this.Currency = currency;
            this.Bic = bic;
        }

        /// <summary>
        /// Gets or Sets Iban
        /// </summary>
        [DataMember(Name = "iban", EmitDefaultValue = false)]
        public string Iban { get; set; }

        /// <summary>
        /// Gets or Sets BankName
        /// </summary>
        [DataMember(Name = "bankName", EmitDefaultValue = false)]
        public string BankName { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets Bic
        /// </summary>
        [DataMember(Name = "bic", EmitDefaultValue = false)]
        public string Bic { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PayoutAccountInfo {\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Bic: ").Append(Bic).Append("\n");
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
