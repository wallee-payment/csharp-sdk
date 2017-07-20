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
    /// A subscription product represents a product to which a subscriber can subscribe to. A product defines how much the subscription costs and in what cycles the subscribe is charged.
    /// </summary>
    [DataContract]
    public partial class SubscriptionProductCreate : AbstractSubscriptionProductActive,  IEquatable<SubscriptionProductCreate>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionProductCreate() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductCreate" /> class.
        /// </summary>
        /// <param name="Reference">The product reference identifies the product for external systems. This field may contain the product&#39;s SKU. (required)</param>
        public SubscriptionProductCreate(string FailedPaymentSuspensionPeriod = default(string), int? SortOrder = default(int?), string Reference = default(string), List<long?> AllowedPaymentMethodConfigurations = default(List<long?>), SubscriptionProductState? State = default(SubscriptionProductState?), string Name = default(string))
        {
            // to ensure "Reference" is required (not null)
            if (Reference == null)
            {
                throw new ArgumentNullException("Reference is a required property for SubscriptionProductCreate and cannot be null");
            }
            else
            {
                this.Reference = Reference;
            }
            this.AllowedPaymentMethodConfigurations = AllowedPaymentMethodConfigurations;
            this.FailedPaymentSuspensionPeriod = FailedPaymentSuspensionPeriod;
            this.Name = Name;
            this.SortOrder = SortOrder;
            this.State = State;
        }

        /// <summary>
        /// The product reference identifies the product for external systems. This field may contain the product&#39;s SKU.
        /// </summary>
        /// <value>The product reference identifies the product for external systems. This field may contain the product&#39;s SKU.</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

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
        public new string ToJson()
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
            return this.Equals(obj as SubscriptionProductCreate);
        }

        /// <summary>
        /// Returns true if SubscriptionProductCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of SubscriptionProductCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionProductCreate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Reference == other.Reference ||
                    this.Reference != null &&
                    this.Reference.Equals(other.Reference)
                ) && 
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
                if (this.Reference != null)
                {
                    hash = hash * 59 + this.Reference.GetHashCode();
                }
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
