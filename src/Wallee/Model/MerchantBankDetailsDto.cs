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
    /// MerchantBankDetailsDto
    /// </summary>
    [DataContract(Name = "MerchantBankDetailsDto")]
    public partial class MerchantBankDetailsDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantBankDetailsDto" /> class.
        /// </summary>
        /// <param name="directAccountOwnershipConfirmed">Whether the merchant confirms direct ownership of the payout accounts..</param>
        /// <param name="payoutAccounts">The bank accounts where merchant payouts should be sent..</param>
        public MerchantBankDetailsDto(bool directAccountOwnershipConfirmed = default, List<PayoutAccountInfo> payoutAccounts = default)
        {
            this.DirectAccountOwnershipConfirmed = directAccountOwnershipConfirmed;
            this.PayoutAccounts = payoutAccounts;
        }

        /// <summary>
        /// Whether the merchant confirms direct ownership of the payout accounts.
        /// </summary>
        /// <value>Whether the merchant confirms direct ownership of the payout accounts.</value>
        [DataMember(Name = "directAccountOwnershipConfirmed", EmitDefaultValue = true)]
        public bool DirectAccountOwnershipConfirmed { get; set; }

        /// <summary>
        /// The bank accounts where merchant payouts should be sent.
        /// </summary>
        /// <value>The bank accounts where merchant payouts should be sent.</value>
        [DataMember(Name = "payoutAccounts", EmitDefaultValue = false)]
        public List<PayoutAccountInfo> PayoutAccounts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MerchantBankDetailsDto {\n");
            sb.Append("  DirectAccountOwnershipConfirmed: ").Append(DirectAccountOwnershipConfirmed).Append("\n");
            sb.Append("  PayoutAccounts: ").Append(PayoutAccounts).Append("\n");
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
