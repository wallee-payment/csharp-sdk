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
    /// AuthenticatedCardData
    /// </summary>
    [DataContract(Name = "AuthenticatedCardData")]
    public partial class AuthenticatedCardData : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets RecurringIndicator
        /// </summary>
        [DataMember(Name = "recurringIndicator", EmitDefaultValue = false)]
        public RecurringIndicator? RecurringIndicator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticatedCardData" /> class.
        /// </summary>
        /// <param name="recurringIndicator">recurringIndicator.</param>
        /// <param name="cryptogram">cryptogram.</param>
        /// <param name="cardholderAuthentication">cardholderAuthentication.</param>
        public AuthenticatedCardData(RecurringIndicator? recurringIndicator = default, CardCryptogram cryptogram = default, CardholderAuthentication cardholderAuthentication = default)
        {
            this.RecurringIndicator = recurringIndicator;
            this.Cryptogram = cryptogram;
            this.CardholderAuthentication = cardholderAuthentication;
        }

        /// <summary>
        /// Whether the transaction is an initial recurring transaction, based on the recurring indicator. This is used to identify the first transaction in a recurring payment setup.
        /// </summary>
        /// <value>Whether the transaction is an initial recurring transaction, based on the recurring indicator. This is used to identify the first transaction in a recurring payment setup.</value>
        [DataMember(Name = "initialRecurringTransaction", EmitDefaultValue = true)]
        public bool InitialRecurringTransaction { get; private set; }

        /// <summary>
        /// Returns false as InitialRecurringTransaction should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeInitialRecurringTransaction()
        {
            return false;
        }
        /// <summary>
        /// The token requestor identifier (TRID) identifies the entity requesting tokenization for a card transaction.
        /// </summary>
        /// <value>The token requestor identifier (TRID) identifies the entity requesting tokenization for a card transaction.</value>
        [DataMember(Name = "tokenRequestorId", EmitDefaultValue = false)]
        public string TokenRequestorId { get; private set; }

        /// <summary>
        /// Returns false as TokenRequestorId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTokenRequestorId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Cryptogram
        /// </summary>
        [DataMember(Name = "cryptogram", EmitDefaultValue = false)]
        public CardCryptogram Cryptogram { get; set; }

        /// <summary>
        /// Gets or Sets CardholderAuthentication
        /// </summary>
        [DataMember(Name = "cardholderAuthentication", EmitDefaultValue = false)]
        public CardholderAuthentication CardholderAuthentication { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthenticatedCardData {\n");
            sb.Append("  InitialRecurringTransaction: ").Append(InitialRecurringTransaction).Append("\n");
            sb.Append("  RecurringIndicator: ").Append(RecurringIndicator).Append("\n");
            sb.Append("  TokenRequestorId: ").Append(TokenRequestorId).Append("\n");
            sb.Append("  Cryptogram: ").Append(Cryptogram).Append("\n");
            sb.Append("  CardholderAuthentication: ").Append(CardholderAuthentication).Append("\n");
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
