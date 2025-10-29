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
    /// The metric usage provides details about the consumption of a particular metric.
    /// </summary>
    [DataContract(Name = "MetricUsage")]
    public partial class MetricUsage : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetricUsage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public MetricUsage()
        {
        }

        /// <summary>
        /// The number of consumed units.
        /// </summary>
        /// <value>The number of consumed units.</value>
        [DataMember(Name = "consumedUnits", EmitDefaultValue = false)]
        public decimal ConsumedUnits { get; private set; }

        /// <summary>
        /// Returns false as ConsumedUnits should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeConsumedUnits()
        {
            return false;
        }
        /// <summary>
        /// The description of the consumed unit&#39;s metric.
        /// </summary>
        /// <value>The description of the consumed unit&#39;s metric.</value>
        [DataMember(Name = "metricDescription", EmitDefaultValue = false)]
        public Dictionary<string, string> MetricDescription { get; private set; }

        /// <summary>
        /// Returns false as MetricDescription should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMetricDescription()
        {
            return false;
        }
        /// <summary>
        /// The name of the consumed units&#39; metric.
        /// </summary>
        /// <value>The name of the consumed units&#39; metric.</value>
        [DataMember(Name = "metricName", EmitDefaultValue = false)]
        public Dictionary<string, string> MetricName { get; private set; }

        /// <summary>
        /// Returns false as MetricName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMetricName()
        {
            return false;
        }
        /// <summary>
        /// The ID of the consumed units&#39; metric.
        /// </summary>
        /// <value>The ID of the consumed units&#39; metric.</value>
        [DataMember(Name = "metricId", EmitDefaultValue = false)]
        public long MetricId { get; private set; }

        /// <summary>
        /// Returns false as MetricId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMetricId()
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
            sb.Append("class MetricUsage {\n");
            sb.Append("  ConsumedUnits: ").Append(ConsumedUnits).Append("\n");
            sb.Append("  MetricDescription: ").Append(MetricDescription).Append("\n");
            sb.Append("  MetricName: ").Append(MetricName).Append("\n");
            sb.Append("  MetricId: ").Append(MetricId).Append("\n");
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
