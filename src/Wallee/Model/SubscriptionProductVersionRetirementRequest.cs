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
    /// SubscriptionProductVersionRetirementRequest
    /// </summary>
    [DataContract(Name = "SubscriptionProductVersionRetirementRequest")]
    public partial class SubscriptionProductVersionRetirementRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductVersionRetirementRequest" /> class.
        /// </summary>
        /// <param name="respectTerminationPeriods">Whether the subscriptions&#39; termination periods should be respected..</param>
        /// <param name="targetProduct">The product to which the subscriptions with the retiring product version are to be migrated. If none is defined, the subscriptions are terminated..</param>
        public SubscriptionProductVersionRetirementRequest(bool respectTerminationPeriods = default(bool), long targetProduct = default(long))
        {
            this.RespectTerminationPeriods = respectTerminationPeriods;
            this.TargetProduct = targetProduct;
        }

        /// <summary>
        /// Whether the subscriptions&#39; termination periods should be respected.
        /// </summary>
        /// <value>Whether the subscriptions&#39; termination periods should be respected.</value>
        [DataMember(Name = "respectTerminationPeriods", EmitDefaultValue = true)]
        public bool RespectTerminationPeriods { get; set; }

        /// <summary>
        /// The product to which the subscriptions with the retiring product version are to be migrated. If none is defined, the subscriptions are terminated.
        /// </summary>
        /// <value>The product to which the subscriptions with the retiring product version are to be migrated. If none is defined, the subscriptions are terminated.</value>
        [DataMember(Name = "targetProduct", EmitDefaultValue = false)]
        public long TargetProduct { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscriptionProductVersionRetirementRequest {\n");
            sb.Append("  RespectTerminationPeriods: ").Append(RespectTerminationPeriods).Append("\n");
            sb.Append("  TargetProduct: ").Append(TargetProduct).Append("\n");
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
