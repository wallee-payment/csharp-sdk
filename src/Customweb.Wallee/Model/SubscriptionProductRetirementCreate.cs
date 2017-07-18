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
    /// Product Retirement
    /// </summary>
    [DataContract]
    public partial class SubscriptionProductRetirementCreate :  IEquatable<SubscriptionProductRetirementCreate>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductRetirementCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionProductRetirementCreate() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductRetirementCreate" /> class.
        /// </summary>
        /// <param name="Product">Product (required)</param>
        /// <param name="RespectTerminiationPeriodsEnabled">RespectTerminiationPeriodsEnabled</param>
        /// <param name="TargetProduct">TargetProduct</param>
        public SubscriptionProductRetirementCreate(bool? RespectTerminiationPeriodsEnabled = default(bool?), long? TargetProduct = default(long?), long? Product = default(long?))
        {
            // to ensure "Product" is required (not null)
            if (Product == null)
            {
                throw new ArgumentNullException("Product is a required property for SubscriptionProductRetirementCreate and cannot be null");
            }
            else
            {
                this.Product = Product;
            }
            this.RespectTerminiationPeriodsEnabled = RespectTerminiationPeriodsEnabled;
            this.TargetProduct = TargetProduct;
        }

        /// <summary>
        /// Product
        /// </summary>
        /// <value>Product</value>
        [DataMember(Name="product", EmitDefaultValue=false)]
        public long? Product { get; set; }

        /// <summary>
        /// RespectTerminiationPeriodsEnabled
        /// </summary>
        /// <value>RespectTerminiationPeriodsEnabled</value>
        [DataMember(Name="respectTerminiationPeriodsEnabled", EmitDefaultValue=false)]
        public bool? RespectTerminiationPeriodsEnabled { get; set; }

        /// <summary>
        /// TargetProduct
        /// </summary>
        /// <value>TargetProduct</value>
        [DataMember(Name="targetProduct", EmitDefaultValue=false)]
        public long? TargetProduct { get; set; }

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
            return this.Equals(obj as SubscriptionProductRetirementCreate);
        }

        /// <summary>
        /// Returns true if SubscriptionProductRetirementCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of SubscriptionProductRetirementCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionProductRetirementCreate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Product == other.Product ||
                    this.Product != null &&
                    this.Product.Equals(other.Product)
                ) && 
                (
                    this.RespectTerminiationPeriodsEnabled == other.RespectTerminiationPeriodsEnabled ||
                    this.RespectTerminiationPeriodsEnabled != null &&
                    this.RespectTerminiationPeriodsEnabled.Equals(other.RespectTerminiationPeriodsEnabled)
                ) && 
                (
                    this.TargetProduct == other.TargetProduct ||
                    this.TargetProduct != null &&
                    this.TargetProduct.Equals(other.TargetProduct)
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
                if (this.Product != null)
                {
                    hash = hash * 59 + this.Product.GetHashCode();
                }
                if (this.RespectTerminiationPeriodsEnabled != null)
                {
                    hash = hash * 59 + this.RespectTerminiationPeriodsEnabled.GetHashCode();
                }
                if (this.TargetProduct != null)
                {
                    hash = hash * 59 + this.TargetProduct.GetHashCode();
                }
                return hash;
            }
        }

    }

}
