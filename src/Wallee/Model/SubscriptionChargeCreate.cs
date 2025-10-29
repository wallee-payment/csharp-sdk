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
    /// The subscription charge represents a single charge carried out for a particular subscription.
    /// </summary>
    [DataContract(Name = "SubscriptionCharge.Create")]
    public partial class SubscriptionChargeCreate : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ProcessingType
        /// </summary>
        [DataMember(Name = "processingType", IsRequired = true, EmitDefaultValue = true)]
        public SubscriptionChargeProcessingType ProcessingType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionChargeCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionChargeCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionChargeCreate" /> class.
        /// </summary>
        /// <param name="reference">The merchant&#39;s reference used to identify the charge..</param>
        /// <param name="plannedExecutionDate">The date and time when the execution of the charge is planned..</param>
        /// <param name="processingType">processingType (required).</param>
        /// <param name="externalId">A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result. (required).</param>
        /// <param name="successUrl">The URL to redirect the customer back to after they successfully authenticated their payment..</param>
        /// <param name="subscription">The subscription that the charge belongs to. (required).</param>
        /// <param name="failedUrl">The URL to redirect the customer back to after they canceled or failed to authenticated their payment..</param>
        public SubscriptionChargeCreate(string reference = default(string), DateTime plannedExecutionDate = default(DateTime), SubscriptionChargeProcessingType processingType = default(SubscriptionChargeProcessingType), string externalId = default(string), string successUrl = default(string), long subscription = default(long), string failedUrl = default(string))
        {
            this.ProcessingType = processingType;
            // to ensure "externalId" is required (not null)
            if (externalId == null)
            {
                throw new ArgumentNullException("externalId is a required property for SubscriptionChargeCreate and cannot be null");
            }
            this.ExternalId = externalId;
            this.Subscription = subscription;
            this.Reference = reference;
            this.PlannedExecutionDate = plannedExecutionDate;
            this.SuccessUrl = successUrl;
            this.FailedUrl = failedUrl;
        }

        /// <summary>
        /// The merchant&#39;s reference used to identify the charge.
        /// </summary>
        /// <value>The merchant&#39;s reference used to identify the charge.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// The date and time when the execution of the charge is planned.
        /// </summary>
        /// <value>The date and time when the execution of the charge is planned.</value>
        [DataMember(Name = "plannedExecutionDate", EmitDefaultValue = false)]
        public DateTime PlannedExecutionDate { get; set; }

        /// <summary>
        /// A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.
        /// </summary>
        /// <value>A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.</value>
        [DataMember(Name = "externalId", IsRequired = true, EmitDefaultValue = true)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The URL to redirect the customer back to after they successfully authenticated their payment.
        /// </summary>
        /// <value>The URL to redirect the customer back to after they successfully authenticated their payment.</value>
        [DataMember(Name = "successUrl", EmitDefaultValue = false)]
        public string SuccessUrl { get; set; }

        /// <summary>
        /// The subscription that the charge belongs to.
        /// </summary>
        /// <value>The subscription that the charge belongs to.</value>
        [DataMember(Name = "subscription", IsRequired = true, EmitDefaultValue = true)]
        public long Subscription { get; set; }

        /// <summary>
        /// The URL to redirect the customer back to after they canceled or failed to authenticated their payment.
        /// </summary>
        /// <value>The URL to redirect the customer back to after they canceled or failed to authenticated their payment.</value>
        [DataMember(Name = "failedUrl", EmitDefaultValue = false)]
        public string FailedUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscriptionChargeCreate {\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  PlannedExecutionDate: ").Append(PlannedExecutionDate).Append("\n");
            sb.Append("  ProcessingType: ").Append(ProcessingType).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  SuccessUrl: ").Append(SuccessUrl).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
            sb.Append("  FailedUrl: ").Append(FailedUrl).Append("\n");
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

            // SuccessUrl (string) maxLength
            if (this.SuccessUrl != null && this.SuccessUrl.Length > 500)
            {
                yield return new ValidationResult("Invalid value for SuccessUrl, length must be less than 500.", new [] { "SuccessUrl" });
            }

            // SuccessUrl (string) minLength
            if (this.SuccessUrl != null && this.SuccessUrl.Length < 9)
            {
                yield return new ValidationResult("Invalid value for SuccessUrl, length must be greater than 9.", new [] { "SuccessUrl" });
            }

            // FailedUrl (string) maxLength
            if (this.FailedUrl != null && this.FailedUrl.Length > 500)
            {
                yield return new ValidationResult("Invalid value for FailedUrl, length must be less than 500.", new [] { "FailedUrl" });
            }

            // FailedUrl (string) minLength
            if (this.FailedUrl != null && this.FailedUrl.Length < 9)
            {
                yield return new ValidationResult("Invalid value for FailedUrl, length must be greater than 9.", new [] { "FailedUrl" });
            }

            yield break;
        }
    }

}
