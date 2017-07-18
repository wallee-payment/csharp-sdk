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
    /// Line Item Reduction . Create
    /// </summary>
    [DataContract]
    public partial class LineItemReductionCreate :  IEquatable<LineItemReductionCreate>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="LineItemReductionCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LineItemReductionCreate() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="LineItemReductionCreate" /> class.
        /// </summary>
        /// <param name="LineItemUniqueId">The unique id identifies the line item on which the reduction is applied on. (required)</param>
        /// <param name="QuantityReduction">QuantityReduction (required)</param>
        /// <param name="UnitPriceReduction">UnitPriceReduction (required)</param>
        public LineItemReductionCreate(decimal? UnitPriceReduction = default(decimal?), decimal? QuantityReduction = default(decimal?), string LineItemUniqueId = default(string))
        {
            // to ensure "LineItemUniqueId" is required (not null)
            if (LineItemUniqueId == null)
            {
                throw new ArgumentNullException("LineItemUniqueId is a required property for LineItemReductionCreate and cannot be null");
            }
            else
            {
                this.LineItemUniqueId = LineItemUniqueId;
            }
            // to ensure "QuantityReduction" is required (not null)
            if (QuantityReduction == null)
            {
                throw new ArgumentNullException("QuantityReduction is a required property for LineItemReductionCreate and cannot be null");
            }
            else
            {
                this.QuantityReduction = QuantityReduction;
            }
            // to ensure "UnitPriceReduction" is required (not null)
            if (UnitPriceReduction == null)
            {
                throw new ArgumentNullException("UnitPriceReduction is a required property for LineItemReductionCreate and cannot be null");
            }
            else
            {
                this.UnitPriceReduction = UnitPriceReduction;
            }
        }

        /// <summary>
        /// The unique id identifies the line item on which the reduction is applied on.
        /// </summary>
        /// <value>The unique id identifies the line item on which the reduction is applied on.</value>
        [DataMember(Name="lineItemUniqueId", EmitDefaultValue=false)]
        public string LineItemUniqueId { get; set; }

        /// <summary>
        /// QuantityReduction
        /// </summary>
        /// <value>QuantityReduction</value>
        [DataMember(Name="quantityReduction", EmitDefaultValue=false)]
        public decimal? QuantityReduction { get; set; }

        /// <summary>
        /// UnitPriceReduction
        /// </summary>
        /// <value>UnitPriceReduction</value>
        [DataMember(Name="unitPriceReduction", EmitDefaultValue=false)]
        public decimal? UnitPriceReduction { get; set; }

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
            return this.Equals(obj as LineItemReductionCreate);
        }

        /// <summary>
        /// Returns true if LineItemReductionCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of LineItemReductionCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LineItemReductionCreate other)
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

    }

}
