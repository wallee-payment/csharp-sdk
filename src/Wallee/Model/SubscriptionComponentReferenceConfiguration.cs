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
    /// The component reference configuration adjusts the product component for a particular subscription.
    /// </summary>
    [DataContract(Name = "SubscriptionComponentReferenceConfiguration")]
    public partial class SubscriptionComponentReferenceConfiguration : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionComponentReferenceConfiguration" /> class.
        /// </summary>
        /// <param name="quantity">The quantity that should be applied to the component..</param>
        /// <param name="productComponentReferenceId">The ID of the component reference that is being configured..</param>
        public SubscriptionComponentReferenceConfiguration(decimal quantity = default, long productComponentReferenceId = default)
        {
            this.Quantity = quantity;
            this.ProductComponentReferenceId = productComponentReferenceId;
        }

        /// <summary>
        /// The quantity that should be applied to the component.
        /// </summary>
        /// <value>The quantity that should be applied to the component.</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// The ID of the component reference that is being configured.
        /// </summary>
        /// <value>The ID of the component reference that is being configured.</value>
        [DataMember(Name = "productComponentReferenceId", EmitDefaultValue = false)]
        public long ProductComponentReferenceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscriptionComponentReferenceConfiguration {\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  ProductComponentReferenceId: ").Append(ProductComponentReferenceId).Append("\n");
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
