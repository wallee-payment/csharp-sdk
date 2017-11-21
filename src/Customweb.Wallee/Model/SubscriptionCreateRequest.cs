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
    /// The subscription create request holds all the data required to create a new subscription.
    /// </summary>
    [DataContract]
    public partial class SubscriptionCreateRequest :  IEquatable<SubscriptionCreateRequest>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionCreateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionCreateRequest() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionCreateRequest" /> class.
        /// </summary>
        /// <param name="Currency">Currency (required)</param>
        /// <param name="Product">The subscription has to be linked with a product. (required)</param>
        /// <param name="SelectedComponents">SelectedComponents</param>
        /// <param name="Subscription">Subscription (required)</param>
        public SubscriptionCreateRequest(long? Product = default(long?), string Currency = default(string), long? Subscription = default(long?), List<SubscriptionProductComponentReference> SelectedComponents = default(List<SubscriptionProductComponentReference>))
        {
            // to ensure "Currency" is required (not null)
            if (Currency == null)
            {
                throw new ArgumentNullException("Currency is a required property for SubscriptionCreateRequest and cannot be null");
            }
            else
            {
                this.Currency = Currency;
            }
            // to ensure "Product" is required (not null)
            if (Product == null)
            {
                throw new ArgumentNullException("Product is a required property for SubscriptionCreateRequest and cannot be null");
            }
            else
            {
                this.Product = Product;
            }
            // to ensure "Subscription" is required (not null)
            if (Subscription == null)
            {
                throw new ArgumentNullException("Subscription is a required property for SubscriptionCreateRequest and cannot be null");
            }
            else
            {
                this.Subscription = Subscription;
            }
            this.SelectedComponents = SelectedComponents;
        }

        /// <summary>
        /// Currency
        /// </summary>
        /// <value>Currency</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// The subscription has to be linked with a product.
        /// </summary>
        /// <value>The subscription has to be linked with a product.</value>
        [DataMember(Name="product", EmitDefaultValue=false)]
        public long? Product { get; set; }

        /// <summary>
        /// SelectedComponents
        /// </summary>
        /// <value>SelectedComponents</value>
        [DataMember(Name="selectedComponents", EmitDefaultValue=false)]
        public List<SubscriptionProductComponentReference> SelectedComponents { get; set; }

        /// <summary>
        /// Subscription
        /// </summary>
        /// <value>Subscription</value>
        [DataMember(Name="subscription", EmitDefaultValue=false)]
        public long? Subscription { get; set; }

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
            return this.Equals(obj as SubscriptionCreateRequest);
        }

        /// <summary>
        /// Returns true if SubscriptionCreateRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SubscriptionCreateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionCreateRequest other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
                (
                    this.Product == other.Product ||
                    this.Product != null &&
                    this.Product.Equals(other.Product)
                ) && 
                (
                    this.SelectedComponents == other.SelectedComponents ||
                    this.SelectedComponents != null &&
                    this.SelectedComponents.SequenceEqual(other.SelectedComponents)
                ) && 
                (
                    this.Subscription == other.Subscription ||
                    this.Subscription != null &&
                    this.Subscription.Equals(other.Subscription)
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
                if (this.Currency != null)
                {
                    hash = hash * 59 + this.Currency.GetHashCode();
                }
                if (this.Product != null)
                {
                    hash = hash * 59 + this.Product.GetHashCode();
                }
                if (this.SelectedComponents != null)
                {
                    hash = hash * 59 + this.SelectedComponents.GetHashCode();
                }
                if (this.Subscription != null)
                {
                    hash = hash * 59 + this.Subscription.GetHashCode();
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
