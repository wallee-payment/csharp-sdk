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
    /// PaymentAppCompletionConfigurationCreate
    /// </summary>
    [DataContract(Name = "PaymentAppCompletionConfiguration.Create")]
    public partial class PaymentAppCompletionConfigurationCreate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentAppCompletionConfigurationCreate" /> class.
        /// </summary>
        /// <param name="multipleCompletionsSupported">Whether the payment connector can process multiple completions for a single transaction..</param>
        /// <param name="maximalCompletionDelayInDays">The maximum number of days after a transaction&#39;s authorization during which a completion or void action can be triggered. Once this period has passed, neither action can be executed..</param>
        /// <param name="completionEndpoint">The URL that the payment service provider will invoke to process a completion request. This endpoint handles communication with the provider for initiating and managing completions..</param>
        /// <param name="completionTimeoutInMinutes">The maximum time (in minutes) to wait for a response from the payment service provider after a completion request is triggered. If no feedback or final status is received within this period, the completion is considered failed..</param>
        /// <param name="voidEndpoint">The URL that the payment service provider will invoke to process a void request. This endpoint handles communication with the provider for initiating and managing voids..</param>
        public PaymentAppCompletionConfigurationCreate(bool multipleCompletionsSupported = default, int maximalCompletionDelayInDays = default, string completionEndpoint = default, int completionTimeoutInMinutes = default, string voidEndpoint = default)
        {
            this.MultipleCompletionsSupported = multipleCompletionsSupported;
            this.MaximalCompletionDelayInDays = maximalCompletionDelayInDays;
            this.CompletionEndpoint = completionEndpoint;
            this.CompletionTimeoutInMinutes = completionTimeoutInMinutes;
            this.VoidEndpoint = voidEndpoint;
        }

        /// <summary>
        /// Whether the payment connector can process multiple completions for a single transaction.
        /// </summary>
        /// <value>Whether the payment connector can process multiple completions for a single transaction.</value>
        [DataMember(Name = "multipleCompletionsSupported", EmitDefaultValue = true)]
        public bool MultipleCompletionsSupported { get; set; }

        /// <summary>
        /// The maximum number of days after a transaction&#39;s authorization during which a completion or void action can be triggered. Once this period has passed, neither action can be executed.
        /// </summary>
        /// <value>The maximum number of days after a transaction&#39;s authorization during which a completion or void action can be triggered. Once this period has passed, neither action can be executed.</value>
        [DataMember(Name = "maximalCompletionDelayInDays", EmitDefaultValue = false)]
        public int MaximalCompletionDelayInDays { get; set; }

        /// <summary>
        /// The URL that the payment service provider will invoke to process a completion request. This endpoint handles communication with the provider for initiating and managing completions.
        /// </summary>
        /// <value>The URL that the payment service provider will invoke to process a completion request. This endpoint handles communication with the provider for initiating and managing completions.</value>
        [DataMember(Name = "completionEndpoint", EmitDefaultValue = false)]
        public string CompletionEndpoint { get; set; }

        /// <summary>
        /// The maximum time (in minutes) to wait for a response from the payment service provider after a completion request is triggered. If no feedback or final status is received within this period, the completion is considered failed.
        /// </summary>
        /// <value>The maximum time (in minutes) to wait for a response from the payment service provider after a completion request is triggered. If no feedback or final status is received within this period, the completion is considered failed.</value>
        [DataMember(Name = "completionTimeoutInMinutes", EmitDefaultValue = false)]
        public int CompletionTimeoutInMinutes { get; set; }

        /// <summary>
        /// The URL that the payment service provider will invoke to process a void request. This endpoint handles communication with the provider for initiating and managing voids.
        /// </summary>
        /// <value>The URL that the payment service provider will invoke to process a void request. This endpoint handles communication with the provider for initiating and managing voids.</value>
        [DataMember(Name = "voidEndpoint", EmitDefaultValue = false)]
        public string VoidEndpoint { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentAppCompletionConfigurationCreate {\n");
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
