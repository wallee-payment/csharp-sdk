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
    /// A request to update the state of a completion. The completion must be associated with a processor created by the invoking payment web app.
    /// </summary>
    [DataContract(Name = "PaymentAppCompletionUpdate")]
    public partial class PaymentAppCompletionUpdate : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets TargetState
        /// </summary>
        [DataMember(Name = "targetState", EmitDefaultValue = false)]
        public PaymentAppCompletionTargetState? TargetState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentAppCompletionUpdate" /> class.
        /// </summary>
        /// <param name="reference">A unique identifier for the completion within the systems of the external service provider. This field is mandatory when the target state is set to &#39;SUCCESSFUL&#39;..</param>
        /// <param name="targetState">targetState.</param>
        /// <param name="failureReason">The reason for the completion&#39;s failure. This field is mandatory when the target state is set to &#39;FAILED&#39;..</param>
        public PaymentAppCompletionUpdate(string reference = default(string), PaymentAppCompletionTargetState? targetState = default(PaymentAppCompletionTargetState?), long failureReason = default(long))
        {
            this.Reference = reference;
            this.TargetState = targetState;
            this.FailureReason = failureReason;
        }

        /// <summary>
        /// A unique identifier for the completion within the systems of the external service provider. This field is mandatory when the target state is set to &#39;SUCCESSFUL&#39;.
        /// </summary>
        /// <value>A unique identifier for the completion within the systems of the external service provider. This field is mandatory when the target state is set to &#39;SUCCESSFUL&#39;.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// The reason for the completion&#39;s failure. This field is mandatory when the target state is set to &#39;FAILED&#39;.
        /// </summary>
        /// <value>The reason for the completion&#39;s failure. This field is mandatory when the target state is set to &#39;FAILED&#39;.</value>
        [DataMember(Name = "failureReason", EmitDefaultValue = false)]
        public long FailureReason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentAppCompletionUpdate {\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  TargetState: ").Append(TargetState).Append("\n");
            sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
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
            // Reference (string) maxLength
            if (this.Reference != null && this.Reference.Length > 100)
            {
                yield return new ValidationResult("Invalid value for Reference, length must be less than 100.", new [] { "Reference" });
            }

            if (this.Reference != null) {
                // Reference (string) pattern
                Regex regexReference = new Regex(@"[	\x20-\x7e]*", RegexOptions.CultureInvariant);
                if (!regexReference.Match(this.Reference).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Reference, must match a pattern of " + regexReference, new [] { "Reference" });
                }
            }

            yield break;
        }
    }

}
