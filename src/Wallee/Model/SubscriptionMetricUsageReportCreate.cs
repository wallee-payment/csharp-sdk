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
    /// The metric usage is the actual usage of a metric for a particular subscription as collected by an external application.
    /// </summary>
    [DataContract(Name = "SubscriptionMetricUsageReport.Create")]
    public partial class SubscriptionMetricUsageReportCreate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionMetricUsageReportCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionMetricUsageReportCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionMetricUsageReportCreate" /> class.
        /// </summary>
        /// <param name="consumedUnits">The number of resources consumed, will be charged in the next billing cycle. (required).</param>
        /// <param name="metric">The metric that the usage report is recorded for. (required).</param>
        /// <param name="description">A description used to identify the usage report..</param>
        /// <param name="externalId">A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result. (required).</param>
        /// <param name="subscription">The subscription that the usage report is recorded for. (required).</param>
        public SubscriptionMetricUsageReportCreate(decimal consumedUnits = default(decimal), long metric = default(long), string description = default(string), string externalId = default(string), long subscription = default(long))
        {
            this.ConsumedUnits = consumedUnits;
            this.Metric = metric;
            // to ensure "externalId" is required (not null)
            if (externalId == null)
            {
                throw new ArgumentNullException("externalId is a required property for SubscriptionMetricUsageReportCreate and cannot be null");
            }
            this.ExternalId = externalId;
            this.Subscription = subscription;
            this.Description = description;
        }

        /// <summary>
        /// The number of resources consumed, will be charged in the next billing cycle.
        /// </summary>
        /// <value>The number of resources consumed, will be charged in the next billing cycle.</value>
        [DataMember(Name = "consumedUnits", IsRequired = true, EmitDefaultValue = true)]
        public decimal ConsumedUnits { get; set; }

        /// <summary>
        /// The metric that the usage report is recorded for.
        /// </summary>
        /// <value>The metric that the usage report is recorded for.</value>
        [DataMember(Name = "metric", IsRequired = true, EmitDefaultValue = true)]
        public long Metric { get; set; }

        /// <summary>
        /// A description used to identify the usage report.
        /// </summary>
        /// <value>A description used to identify the usage report.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.
        /// </summary>
        /// <value>A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.</value>
        [DataMember(Name = "externalId", IsRequired = true, EmitDefaultValue = true)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The subscription that the usage report is recorded for.
        /// </summary>
        /// <value>The subscription that the usage report is recorded for.</value>
        [DataMember(Name = "subscription", IsRequired = true, EmitDefaultValue = true)]
        public long Subscription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscriptionMetricUsageReportCreate {\n");
            sb.Append("  ConsumedUnits: ").Append(ConsumedUnits).Append("\n");
            sb.Append("  Metric: ").Append(Metric).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
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
            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 100)
            {
                yield return new ValidationResult("Invalid value for Description, length must be less than 100.", new [] { "Description" });
            }

            yield break;
        }
    }

}
