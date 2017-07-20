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
    /// Line Item Reduction
    /// </summary>
    [DataContract]
    public partial class LineItemReduction :  IEquatable<LineItemReduction>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="LineItemReduction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public LineItemReduction()
        {
        }

        /// <summary>
        /// The unique id identifies the line item on which the reduction is applied on.
        /// </summary>
        /// <value>The unique id identifies the line item on which the reduction is applied on.</value>
        [DataMember(Name="lineItemUniqueId", EmitDefaultValue=false)]
        public string LineItemUniqueId { get; private set; }

        /// <summary>
        /// QuantityReduction
        /// </summary>
        /// <value>QuantityReduction</value>
        [DataMember(Name="quantityReduction", EmitDefaultValue=false)]
        public decimal? QuantityReduction { get; private set; }

        /// <summary>
        /// UnitPriceReduction
        /// </summary>
        /// <value>UnitPriceReduction</value>
        [DataMember(Name="unitPriceReduction", EmitDefaultValue=false)]
        public decimal? UnitPriceReduction { get; private set; }

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
            return this.Equals(obj as LineItemReduction);
        }

        /// <summary>
        /// Returns true if LineItemReduction instances are equal
        /// </summary>
        /// <param name="other">Instance of LineItemReduction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LineItemReduction other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.LineItemUniqueId == other.LineItemUniqueId ||
                    this.LineItemUniqueId != null &&
                    this.LineItemUniqueId.Equals(other.LineItemUniqueId)
                ) && 
                (
                    this.QuantityReduction == other.QuantityReduction ||
                    this.QuantityReduction != null &&
                    this.QuantityReduction.Equals(other.QuantityReduction)
                ) && 
                (
                    this.UnitPriceReduction == other.UnitPriceReduction ||
                    this.UnitPriceReduction != null &&
                    this.UnitPriceReduction.Equals(other.UnitPriceReduction)
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
                if (this.LineItemUniqueId != null)
                {
                    hash = hash * 59 + this.LineItemUniqueId.GetHashCode();
                }
                if (this.QuantityReduction != null)
                {
                    hash = hash * 59 + this.QuantityReduction.GetHashCode();
                }
                if (this.UnitPriceReduction != null)
                {
                    hash = hash * 59 + this.UnitPriceReduction.GetHashCode();
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
