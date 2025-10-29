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
    /// SubscriptionInitializeSubscriberPresentRequest
    /// </summary>
    [DataContract(Name = "SubscriptionInitializeSubscriberPresentRequest")]
    public partial class SubscriptionInitializeSubscriberPresentRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionInitializeSubscriberPresentRequest" /> class.
        /// </summary>
        /// <param name="successUrl">The URL that the user is redirected to if the transaction succeeds..</param>
        /// <param name="failureUrl">The URL that the user is redirected to if the transaction fails..</param>
        public SubscriptionInitializeSubscriberPresentRequest(string successUrl = default(string), string failureUrl = default(string))
        {
            this.SuccessUrl = successUrl;
            this.FailureUrl = failureUrl;
        }

        /// <summary>
        /// The URL that the user is redirected to if the transaction succeeds.
        /// </summary>
        /// <value>The URL that the user is redirected to if the transaction succeeds.</value>
        [DataMember(Name = "successUrl", EmitDefaultValue = false)]
        public string SuccessUrl { get; set; }

        /// <summary>
        /// The URL that the user is redirected to if the transaction fails.
        /// </summary>
        /// <value>The URL that the user is redirected to if the transaction fails.</value>
        [DataMember(Name = "failureUrl", EmitDefaultValue = false)]
        public string FailureUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscriptionInitializeSubscriberPresentRequest {\n");
            sb.Append("  SuccessUrl: ").Append(SuccessUrl).Append("\n");
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
