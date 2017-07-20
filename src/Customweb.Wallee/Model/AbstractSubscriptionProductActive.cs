/**
 * Wallee SDK Client
 *
 * This client allows to interact with the Wallee API.
 *
 * Wallee API: 1.0.0
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Abstract Product
    /// </summary>
    [DataContract]
    public partial class AbstractSubscriptionProductActive :  IEquatable<AbstractSubscriptionProductActive>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractSubscriptionProductActive" /> class.
        /// </summary>
        /// <param name="AllowedPaymentMethodConfigurations">The allowed payment method configurations control which payment methods can be used with this product. When none is selected all methods will be allowed.</param>
        /// <param name="FailedPaymentSuspensionPeriod">When a payment fails, the subscription to which the payment belongs to will be suspended. When the suspension is not removed within the specified period the subscription will be terminated. A payment is considered as failed when the subscriber issues a refund or when a subscription charge fails.</param>
        /// <param name="Name">The product name is used internally to identify the configuration in administrative interfaces. For example it is used within search fields and hence it should be distinct and descriptive.</param>
        /// <param name="SortOrder">The sort order controls in which order the product is listed. The sort order is used to order the products in ascending order.</param>
        /// <param name="State">State</param>
        public AbstractSubscriptionProductActive(string FailedPaymentSuspensionPeriod = default(string), int? SortOrder = default(int?), SubscriptionProductState? State = default(SubscriptionProductState?), List<long?> AllowedPaymentMethodConfigurations = default(List<long?>), string Name = default(string))
        {
            this.AllowedPaymentMethodConfigurations = AllowedPaymentMethodConfigurations;
            this.FailedPaymentSuspensionPeriod = FailedPaymentSuspensionPeriod;
            this.Name = Name;
            this.SortOrder = SortOrder;
            this.State = State;
        }

        /// <summary>
        /// The allowed payment method configurations control which payment methods can be used with this product. When none is selected all methods will be allowed.
        /// </summary>
        /// <value>The allowed payment method configurations control which payment methods can be used with this product. When none is selected all methods will be allowed.</value>
        [DataMember(Name="allowedPaymentMethodConfigurations", EmitDefaultValue=false)]
        public List<long?> AllowedPaymentMethodConfigurations { get; set; }

        /// <summary>
        /// When a payment fails, the subscription to which the payment belongs to will be suspended. When the suspension is not removed within the specified period the subscription will be terminated. A payment is considered as failed when the subscriber issues a refund or when a subscription charge fails.
        /// </summary>
        /// <value>When a payment fails, the subscription to which the payment belongs to will be suspended. When the suspension is not removed within the specified period the subscription will be terminated. A payment is considered as failed when the subscriber issues a refund or when a subscription charge fails.</value>
        [DataMember(Name="failedPaymentSuspensionPeriod", EmitDefaultValue=false)]
        public string FailedPaymentSuspensionPeriod { get; set; }

        /// <summary>
        /// The product name is used internally to identify the configuration in administrative interfaces. For example it is used within search fields and hence it should be distinct and descriptive.
        /// </summary>
        /// <value>The product name is used internally to identify the configuration in administrative interfaces. For example it is used within search fields and hence it should be distinct and descriptive.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The sort order controls in which order the product is listed. The sort order is used to order the products in ascending order.
        /// </summary>
        /// <value>The sort order controls in which order the product is listed. The sort order is used to order the products in ascending order.</value>
        [DataMember(Name="sortOrder", EmitDefaultValue=false)]
        public int? SortOrder { get; set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public SubscriptionProductState? State { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return this.ToJson();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            return this.Equals(obj as AbstractSubscriptionProductActive);
        }

        /// <summary>
        /// Returns true if AbstractSubscriptionProductActive instances are equal
        /// </summary>
        /// <param name="other">Instance of AbstractSubscriptionProductActive to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbstractSubscriptionProductActive other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.AllowedPaymentMethodConfigurations == other.AllowedPaymentMethodConfigurations ||
                    this.AllowedPaymentMethodConfigurations != null &&
                    this.AllowedPaymentMethodConfigurations.SequenceEqual(other.AllowedPaymentMethodConfigurations)
                ) && 
                (
                    this.FailedPaymentSuspensionPeriod == other.FailedPaymentSuspensionPeriod ||
                    this.FailedPaymentSuspensionPeriod != null &&
                    this.FailedPaymentSuspensionPeriod.Equals(other.FailedPaymentSuspensionPeriod)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.SortOrder == other.SortOrder ||
                    this.SortOrder != null &&
                    this.SortOrder.Equals(other.SortOrder)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                if (this.AllowedPaymentMethodConfigurations != null)
                {
                    hash = hash * 59 + this.AllowedPaymentMethodConfigurations.GetHashCode();
                }
                if (this.FailedPaymentSuspensionPeriod != null)
                {
                    hash = hash * 59 + this.FailedPaymentSuspensionPeriod.GetHashCode();
                }
                if (this.Name != null)
                {
                    hash = hash * 59 + this.Name.GetHashCode();
                }
                if (this.SortOrder != null)
                {
                    hash = hash * 59 + this.SortOrder.GetHashCode();
                }
                if (this.State != null)
                {
                    hash = hash * 59 + this.State.GetHashCode();
                }
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
