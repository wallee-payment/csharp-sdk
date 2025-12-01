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
    /// AbstractTokenUpdate
    /// </summary>
    [DataContract(Name = "Abstract.Token.Update")]
    public partial class AbstractTokenUpdate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractTokenUpdate" /> class.
        /// </summary>
        /// <param name="enabledForOneClickPayment">Whether the token is enabled for one-click payments, which simplify the payment process for the customer. One-click tokens are linked to customers via the customer ID..</param>
        /// <param name="customerEmailAddress">The customer&#39;s email address..</param>
        /// <param name="tokenReference">The reference used to identify the payment token (e.g. the customer&#39;s ID or email address)..</param>
        /// <param name="customerId">The unique identifier of the customer in the external system..</param>
        /// <param name="varTimeZone">The customer&#39;s time zone, which affects how dates and times are formatted when communicating with the customer..</param>
        /// <param name="language">The language that is linked to the object..</param>
        public AbstractTokenUpdate(bool enabledForOneClickPayment = default, string customerEmailAddress = default, string tokenReference = default, string customerId = default, string varTimeZone = default, string language = default)
        {
            this.EnabledForOneClickPayment = enabledForOneClickPayment;
            this.CustomerEmailAddress = customerEmailAddress;
            this.TokenReference = tokenReference;
            this.CustomerId = customerId;
            this.VarTimeZone = varTimeZone;
            this.Language = language;
        }

        /// <summary>
        /// Whether the token is enabled for one-click payments, which simplify the payment process for the customer. One-click tokens are linked to customers via the customer ID.
        /// </summary>
        /// <value>Whether the token is enabled for one-click payments, which simplify the payment process for the customer. One-click tokens are linked to customers via the customer ID.</value>
        [DataMember(Name = "enabledForOneClickPayment", EmitDefaultValue = true)]
        public bool EnabledForOneClickPayment { get; set; }

        /// <summary>
        /// The customer&#39;s email address.
        /// </summary>
        /// <value>The customer&#39;s email address.</value>
        [DataMember(Name = "customerEmailAddress", EmitDefaultValue = false)]
        public string CustomerEmailAddress { get; set; }

        /// <summary>
        /// The reference used to identify the payment token (e.g. the customer&#39;s ID or email address).
        /// </summary>
        /// <value>The reference used to identify the payment token (e.g. the customer&#39;s ID or email address).</value>
        [DataMember(Name = "tokenReference", EmitDefaultValue = false)]
        public string TokenReference { get; set; }

        /// <summary>
        /// The unique identifier of the customer in the external system.
        /// </summary>
        /// <value>The unique identifier of the customer in the external system.</value>
        [DataMember(Name = "customerId", EmitDefaultValue = false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// The customer&#39;s time zone, which affects how dates and times are formatted when communicating with the customer.
        /// </summary>
        /// <value>The customer&#39;s time zone, which affects how dates and times are formatted when communicating with the customer.</value>
        [DataMember(Name = "timeZone", EmitDefaultValue = false)]
        public string VarTimeZone { get; set; }

        /// <summary>
        /// The language that is linked to the object.
        /// </summary>
        /// <value>The language that is linked to the object.</value>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public string Language { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AbstractTokenUpdate {\n");
            sb.Append("  EnabledForOneClickPayment: ").Append(EnabledForOneClickPayment).Append("\n");
            sb.Append("  CustomerEmailAddress: ").Append(CustomerEmailAddress).Append("\n");
            sb.Append("  TokenReference: ").Append(TokenReference).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  VarTimeZone: ").Append(VarTimeZone).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
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
            // CustomerEmailAddress (string) maxLength
            if (this.CustomerEmailAddress != null && this.CustomerEmailAddress.Length > 150)
            {
                yield return new ValidationResult("Invalid value for CustomerEmailAddress, length must be less than 150.", new [] { "CustomerEmailAddress" });
            }

            // TokenReference (string) maxLength
            if (this.TokenReference != null && this.TokenReference.Length > 100)
            {
                yield return new ValidationResult("Invalid value for TokenReference, length must be less than 100.", new [] { "TokenReference" });
            }

            if (this.TokenReference != null) {
                // TokenReference (string) pattern
                Regex regexTokenReference = new Regex(@"[	\x20-\x7e]*", RegexOptions.CultureInvariant);
                if (!regexTokenReference.Match(this.TokenReference).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TokenReference, must match a pattern of " + regexTokenReference, new [] { "TokenReference" });
                }
            }

            yield break;
        }
    }

}
