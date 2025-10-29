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
    /// AuthenticatedCardRequest
    /// </summary>
    [DataContract(Name = "AuthenticatedCardRequest")]
    public partial class AuthenticatedCardRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticatedCardRequest" /> class.
        /// </summary>
        /// <param name="cardData">cardData.</param>
        /// <param name="paymentMethodConfiguration">The ID of the payment method configuration to use..</param>
        public AuthenticatedCardRequest(AuthenticatedCardDataCreate cardData = default(AuthenticatedCardDataCreate), long paymentMethodConfiguration = default(long))
        {
            this.CardData = cardData;
            this.PaymentMethodConfiguration = paymentMethodConfiguration;
        }

        /// <summary>
        /// Gets or Sets CardData
        /// </summary>
        [DataMember(Name = "cardData", EmitDefaultValue = false)]
        public AuthenticatedCardDataCreate CardData { get; set; }

        /// <summary>
        /// The ID of the payment method configuration to use.
        /// </summary>
        /// <value>The ID of the payment method configuration to use.</value>
        [DataMember(Name = "paymentMethodConfiguration", EmitDefaultValue = false)]
        public long PaymentMethodConfiguration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthenticatedCardRequest {\n");
            sb.Append("  CardData: ").Append(CardData).Append("\n");
            sb.Append("  PaymentMethodConfiguration: ").Append(PaymentMethodConfiguration).Append("\n");
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
