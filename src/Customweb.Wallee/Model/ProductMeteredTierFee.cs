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
    /// Product Metered Tier Fee
    /// </summary>
    [DataContract]
    public partial class ProductMeteredTierFee :  IEquatable<ProductMeteredTierFee>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductMeteredTierFee" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ProductMeteredTierFee()
        {
        }

        /// <summary>
        /// The fee determines the amount which is charged. The consumed metric is multiplied by the defined fee. The resulting amount is charged at the end of the period.
        /// </summary>
        /// <value>The fee determines the amount which is charged. The consumed metric is multiplied by the defined fee. The resulting amount is charged at the end of the period.</value>
        [DataMember(Name="fee", EmitDefaultValue=false)]
        public List<PersistableCurrencyAmount> Fee { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// MeteredFee
        /// </summary>
        /// <value>MeteredFee</value>
        [DataMember(Name="meteredFee", EmitDefaultValue=false)]
        public ProductMeteredFee MeteredFee { get; private set; }

        /// <summary>
        /// The start range defines the metered consumption of the metric from which on the defined fee gets applied. This means when a subscription consumes a value of 10 or more and the start range is set to 10 the fee defined on the tier will be applied.
        /// </summary>
        /// <value>The start range defines the metered consumption of the metric from which on the defined fee gets applied. This means when a subscription consumes a value of 10 or more and the start range is set to 10 the fee defined on the tier will be applied.</value>
        [DataMember(Name="startRange", EmitDefaultValue=false)]
        public decimal? StartRange { get; private set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; private set; }

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
            return this.Equals(obj as ProductMeteredTierFee);
        }

        /// <summary>
        /// Returns true if ProductMeteredTierFee instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductMeteredTierFee to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductMeteredTierFee other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Fee == other.Fee ||
                    this.Fee != null &&
                    this.Fee.SequenceEqual(other.Fee)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.MeteredFee == other.MeteredFee ||
                    this.MeteredFee != null &&
                    this.MeteredFee.Equals(other.MeteredFee)
                ) && 
                (
                    this.StartRange == other.StartRange ||
                    this.StartRange != null &&
                    this.StartRange.Equals(other.StartRange)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                if (this.Fee != null)
                {
                    hash = hash * 59 + this.Fee.GetHashCode();
                }
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.MeteredFee != null)
                {
                    hash = hash * 59 + this.MeteredFee.GetHashCode();
                }
                if (this.StartRange != null)
                {
                    hash = hash * 59 + this.StartRange.GetHashCode();
                }
                if (this.Version != null)
                {
                    hash = hash * 59 + this.Version.GetHashCode();
                }
                return hash;
            }
        }

    }

}
