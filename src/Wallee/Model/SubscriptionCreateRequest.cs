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
    /// SubscriptionCreateRequest
    /// </summary>
    [DataContract(Name = "SubscriptionCreateRequest")]
    public partial class SubscriptionCreateRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionCreateRequest" /> class.
        /// </summary>
        /// <param name="componentConfigurations">The configurations of the subscription&#39;s components..</param>
        /// <param name="product">The product to subscribe to..</param>
        /// <param name="currency">The three-letter code (ISO 4217 format) of the currency used to invoice the customer. Must be one of the currencies supported by the product..</param>
        /// <param name="subscription">subscription.</param>
        public SubscriptionCreateRequest(List<SubscriptionComponentReferenceConfiguration> componentConfigurations = default, long product = default, string currency = default, SubscriptionPending subscription = default)
        {
            this.ComponentConfigurations = componentConfigurations;
            this.Product = product;
            this.Currency = currency;
            this.Subscription = subscription;
        }

        /// <summary>
        /// The configurations of the subscription&#39;s components.
        /// </summary>
        /// <value>The configurations of the subscription&#39;s components.</value>
        [DataMember(Name = "componentConfigurations", EmitDefaultValue = false)]
        public List<SubscriptionComponentReferenceConfiguration> ComponentConfigurations { get; set; }

        /// <summary>
        /// The product to subscribe to.
        /// </summary>
        /// <value>The product to subscribe to.</value>
        [DataMember(Name = "product", EmitDefaultValue = false)]
        public long Product { get; set; }

        /// <summary>
        /// The three-letter code (ISO 4217 format) of the currency used to invoice the customer. Must be one of the currencies supported by the product.
        /// </summary>
        /// <value>The three-letter code (ISO 4217 format) of the currency used to invoice the customer. Must be one of the currencies supported by the product.</value>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets Subscription
        /// </summary>
        [DataMember(Name = "subscription", EmitDefaultValue = false)]
        public SubscriptionPending Subscription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscriptionCreateRequest {\n");
            sb.Append("  ComponentConfigurations: ").Append(ComponentConfigurations).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
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
            yield break;
        }
    }

}
