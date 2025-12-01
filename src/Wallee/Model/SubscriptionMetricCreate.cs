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
    /// A metric represents the usage of a resource that can be measured.
    /// </summary>
    [DataContract(Name = "SubscriptionMetric.Create")]
    public partial class SubscriptionMetricCreate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionMetricCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionMetricCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionMetricCreate" /> class.
        /// </summary>
        /// <param name="name">The localized name of the metric that is displayed to the customer. (required).</param>
        /// <param name="description">The localized description of the metric that is displayed to the customer..</param>
        /// <param name="type">The type of the metric. (required).</param>
        public SubscriptionMetricCreate(Dictionary<string, string> name = default, Dictionary<string, string> description = default, long type = default)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for SubscriptionMetricCreate and cannot be null");
            }
            this.Name = name;
            this.Type = type;
            this.Description = description;
        }

        /// <summary>
        /// The localized name of the metric that is displayed to the customer.
        /// </summary>
        /// <value>The localized name of the metric that is displayed to the customer.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, string> Name { get; set; }

        /// <summary>
        /// The localized description of the metric that is displayed to the customer.
        /// </summary>
        /// <value>The localized description of the metric that is displayed to the customer.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public Dictionary<string, string> Description { get; set; }

        /// <summary>
        /// The type of the metric.
        /// </summary>
        /// <value>The type of the metric.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public long Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscriptionMetricCreate {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
