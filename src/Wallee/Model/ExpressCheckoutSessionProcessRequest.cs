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
    /// ExpressCheckoutSessionProcessRequest
    /// </summary>
    [DataContract(Name = "ExpressCheckoutSessionProcessRequest")]
    public partial class ExpressCheckoutSessionProcessRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressCheckoutSessionProcessRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExpressCheckoutSessionProcessRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressCheckoutSessionProcessRequest" /> class.
        /// </summary>
        /// <param name="successUrl">Mandatory URL to redirect the customer to after a successful payment for Express Checkout. (required).</param>
        /// <param name="sessionId">The Express Checkout session identifier returned by create-session. (required).</param>
        /// <param name="merchantReference">Mandatory merchant order identifier used as merchantReference on the created transaction. (required).</param>
        /// <param name="failureUrl">Mandatory URL to redirect the customer to after a failed payment for Express Checkout. (required).</param>
        public ExpressCheckoutSessionProcessRequest(string successUrl = default, long sessionId = default, string merchantReference = default, string failureUrl = default)
        {
            // to ensure "successUrl" is required (not null)
            if (successUrl == null)
            {
                throw new ArgumentNullException("successUrl is a required property for ExpressCheckoutSessionProcessRequest and cannot be null");
            }
            this.SuccessUrl = successUrl;
            this.SessionId = sessionId;
            // to ensure "merchantReference" is required (not null)
            if (merchantReference == null)
            {
                throw new ArgumentNullException("merchantReference is a required property for ExpressCheckoutSessionProcessRequest and cannot be null");
            }
            this.MerchantReference = merchantReference;
            // to ensure "failureUrl" is required (not null)
            if (failureUrl == null)
            {
                throw new ArgumentNullException("failureUrl is a required property for ExpressCheckoutSessionProcessRequest and cannot be null");
            }
            this.FailureUrl = failureUrl;
        }

        /// <summary>
        /// Mandatory URL to redirect the customer to after a successful payment for Express Checkout.
        /// </summary>
        /// <value>Mandatory URL to redirect the customer to after a successful payment for Express Checkout.</value>
        [DataMember(Name = "successUrl", IsRequired = true, EmitDefaultValue = true)]
        public string SuccessUrl { get; set; }

        /// <summary>
        /// The Express Checkout session identifier returned by create-session.
        /// </summary>
        /// <value>The Express Checkout session identifier returned by create-session.</value>
        [DataMember(Name = "sessionId", IsRequired = true, EmitDefaultValue = true)]
        public long SessionId { get; set; }

        /// <summary>
        /// Mandatory merchant order identifier used as merchantReference on the created transaction.
        /// </summary>
        /// <value>Mandatory merchant order identifier used as merchantReference on the created transaction.</value>
        [DataMember(Name = "merchantReference", IsRequired = true, EmitDefaultValue = true)]
        public string MerchantReference { get; set; }

        /// <summary>
        /// Mandatory URL to redirect the customer to after a failed payment for Express Checkout.
        /// </summary>
        /// <value>Mandatory URL to redirect the customer to after a failed payment for Express Checkout.</value>
        [DataMember(Name = "failureUrl", IsRequired = true, EmitDefaultValue = true)]
        public string FailureUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExpressCheckoutSessionProcessRequest {\n");
            sb.Append("  SuccessUrl: ").Append(SuccessUrl).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
            sb.Append("  FailureUrl: ").Append(FailureUrl).Append("\n");
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
