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
    /// AbstractSubscriptionProductActive
    /// </summary>
    [DataContract(Name = "Abstract.SubscriptionProduct.Active")]
    public partial class AbstractSubscriptionProductActive : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public SubscriptionProductState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractSubscriptionProductActive" /> class.
        /// </summary>
        /// <param name="sortOrder">When listing products, they can be sorted by this number..</param>
        /// <param name="name">The name used to identify the product..</param>
        /// <param name="productLocked">Whether subscriptions can be switched to or from this product, or whether they are locked in..</param>
        /// <param name="state">state.</param>
        /// <param name="failedPaymentSuspensionPeriod">The period after which a subscription that has been suspended due to a failed payment is terminated..</param>
        /// <param name="allowedPaymentMethodConfigurations">The payment methods that can be used to subscribe to this product. If none are selected, no restriction is applied..</param>
        public AbstractSubscriptionProductActive(int sortOrder = default(int), string name = default(string), bool productLocked = default(bool), SubscriptionProductState? state = default(SubscriptionProductState?), string failedPaymentSuspensionPeriod = default(string), List<long> allowedPaymentMethodConfigurations = default(List<long>))
        {
            this.SortOrder = sortOrder;
            this.Name = name;
            this.ProductLocked = productLocked;
            this.State = state;
            this.FailedPaymentSuspensionPeriod = failedPaymentSuspensionPeriod;
            this.AllowedPaymentMethodConfigurations = allowedPaymentMethodConfigurations;
        }

        /// <summary>
        /// When listing products, they can be sorted by this number.
        /// </summary>
        /// <value>When listing products, they can be sorted by this number.</value>
        [DataMember(Name = "sortOrder", EmitDefaultValue = false)]
        public int SortOrder { get; set; }

        /// <summary>
        /// The name used to identify the product.
        /// </summary>
        /// <value>The name used to identify the product.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Whether subscriptions can be switched to or from this product, or whether they are locked in.
        /// </summary>
        /// <value>Whether subscriptions can be switched to or from this product, or whether they are locked in.</value>
        [DataMember(Name = "productLocked", EmitDefaultValue = true)]
        public bool ProductLocked { get; set; }

        /// <summary>
        /// The period after which a subscription that has been suspended due to a failed payment is terminated.
        /// </summary>
        /// <value>The period after which a subscription that has been suspended due to a failed payment is terminated.</value>
        [DataMember(Name = "failedPaymentSuspensionPeriod", EmitDefaultValue = false)]
        public string FailedPaymentSuspensionPeriod { get; set; }

        /// <summary>
        /// The payment methods that can be used to subscribe to this product. If none are selected, no restriction is applied.
        /// </summary>
        /// <value>The payment methods that can be used to subscribe to this product. If none are selected, no restriction is applied.</value>
        [DataMember(Name = "allowedPaymentMethodConfigurations", EmitDefaultValue = false)]
        public List<long> AllowedPaymentMethodConfigurations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AbstractSubscriptionProductActive {\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ProductLocked: ").Append(ProductLocked).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  FailedPaymentSuspensionPeriod: ").Append(FailedPaymentSuspensionPeriod).Append("\n");
            sb.Append("  AllowedPaymentMethodConfigurations: ").Append(AllowedPaymentMethodConfigurations).Append("\n");
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 100)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 100.", new [] { "Name" });
            }

            yield break;
        }
    }

}
