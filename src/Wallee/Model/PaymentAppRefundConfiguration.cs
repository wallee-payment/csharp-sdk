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
    /// PaymentAppRefundConfiguration
    /// </summary>
    [DataContract(Name = "PaymentAppRefundConfiguration")]
    public partial class PaymentAppRefundConfiguration : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentAppRefundConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentAppRefundConfiguration()
        {
        }

        /// <summary>
        /// The maximum time (in minutes) to wait for a response from the payment service provider after a refund request is triggered. If no feedback or final status is received within this period, the refund is considered failed.
        /// </summary>
        /// <value>The maximum time (in minutes) to wait for a response from the payment service provider after a refund request is triggered. If no feedback or final status is received within this period, the refund is considered failed.</value>
        [DataMember(Name = "refundTimeoutInMinutes", EmitDefaultValue = false)]
        public int RefundTimeoutInMinutes { get; private set; }

        /// <summary>
        /// Returns false as RefundTimeoutInMinutes should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRefundTimeoutInMinutes()
        {
            return false;
        }
        /// <summary>
        /// Whether the payment connector can process multiple refunds for a single transaction.
        /// </summary>
        /// <value>Whether the payment connector can process multiple refunds for a single transaction.</value>
        [DataMember(Name = "multipleRefundsSupported", EmitDefaultValue = true)]
        public bool MultipleRefundsSupported { get; private set; }

        /// <summary>
        /// Returns false as MultipleRefundsSupported should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMultipleRefundsSupported()
        {
            return false;
        }
        /// <summary>
        /// The URL that the payment service provider will invoke to process a refund request. This endpoint handles communication with the provider for initiating and managing refunds.
        /// </summary>
        /// <value>The URL that the payment service provider will invoke to process a refund request. This endpoint handles communication with the provider for initiating and managing refunds.</value>
        [DataMember(Name = "refundEndpoint", EmitDefaultValue = false)]
        public string RefundEndpoint { get; private set; }

        /// <summary>
        /// Returns false as RefundEndpoint should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRefundEndpoint()
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
            sb.Append("class PaymentAppRefundConfiguration {\n");
            sb.Append("  RefundTimeoutInMinutes: ").Append(RefundTimeoutInMinutes).Append("\n");
            sb.Append("  MultipleRefundsSupported: ").Append(MultipleRefundsSupported).Append("\n");
            sb.Append("  RefundEndpoint: ").Append(RefundEndpoint).Append("\n");
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
