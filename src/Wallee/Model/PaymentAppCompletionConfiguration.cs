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
    /// PaymentAppCompletionConfiguration
    /// </summary>
    [DataContract(Name = "PaymentAppCompletionConfiguration")]
    public partial class PaymentAppCompletionConfiguration : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentAppCompletionConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentAppCompletionConfiguration()
        {
        }

        /// <summary>
        /// Whether the payment connector can process multiple completions for a single transaction.
        /// </summary>
        /// <value>Whether the payment connector can process multiple completions for a single transaction.</value>
        [DataMember(Name = "multipleCompletionsSupported", EmitDefaultValue = true)]
        public bool MultipleCompletionsSupported { get; private set; }

        /// <summary>
        /// Returns false as MultipleCompletionsSupported should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMultipleCompletionsSupported()
        {
            return false;
        }
        /// <summary>
        /// The maximum number of days after a transaction&#39;s authorization during which a completion or void action can be triggered. Once this period has passed, neither action can be executed.
        /// </summary>
        /// <value>The maximum number of days after a transaction&#39;s authorization during which a completion or void action can be triggered. Once this period has passed, neither action can be executed.</value>
        [DataMember(Name = "maximalCompletionDelayInDays", EmitDefaultValue = false)]
        public int MaximalCompletionDelayInDays { get; private set; }

        /// <summary>
        /// Returns false as MaximalCompletionDelayInDays should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMaximalCompletionDelayInDays()
        {
            return false;
        }
        /// <summary>
        /// The URL that the payment service provider will invoke to process a completion request. This endpoint handles communication with the provider for initiating and managing completions.
        /// </summary>
        /// <value>The URL that the payment service provider will invoke to process a completion request. This endpoint handles communication with the provider for initiating and managing completions.</value>
        [DataMember(Name = "completionEndpoint", EmitDefaultValue = false)]
        public string CompletionEndpoint { get; private set; }

        /// <summary>
        /// Returns false as CompletionEndpoint should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCompletionEndpoint()
        {
            return false;
        }
        /// <summary>
        /// The maximum time (in minutes) to wait for a response from the payment service provider after a completion request is triggered. If no feedback or final status is received within this period, the completion is considered failed.
        /// </summary>
        /// <value>The maximum time (in minutes) to wait for a response from the payment service provider after a completion request is triggered. If no feedback or final status is received within this period, the completion is considered failed.</value>
        [DataMember(Name = "completionTimeoutInMinutes", EmitDefaultValue = false)]
        public int CompletionTimeoutInMinutes { get; private set; }

        /// <summary>
        /// Returns false as CompletionTimeoutInMinutes should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCompletionTimeoutInMinutes()
        {
            return false;
        }
        /// <summary>
        /// The URL that the payment service provider will invoke to process a void request. This endpoint handles communication with the provider for initiating and managing voids.
        /// </summary>
        /// <value>The URL that the payment service provider will invoke to process a void request. This endpoint handles communication with the provider for initiating and managing voids.</value>
        [DataMember(Name = "voidEndpoint", EmitDefaultValue = false)]
        public string VoidEndpoint { get; private set; }

        /// <summary>
        /// Returns false as VoidEndpoint should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVoidEndpoint()
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
            sb.Append("class PaymentAppCompletionConfiguration {\n");
            sb.Append("  MultipleCompletionsSupported: ").Append(MultipleCompletionsSupported).Append("\n");
            sb.Append("  MaximalCompletionDelayInDays: ").Append(MaximalCompletionDelayInDays).Append("\n");
            sb.Append("  CompletionEndpoint: ").Append(CompletionEndpoint).Append("\n");
            sb.Append("  CompletionTimeoutInMinutes: ").Append(CompletionTimeoutInMinutes).Append("\n");
            sb.Append("  VoidEndpoint: ").Append(VoidEndpoint).Append("\n");
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
