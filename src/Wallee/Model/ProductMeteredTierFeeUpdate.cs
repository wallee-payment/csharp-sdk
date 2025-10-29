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
    /// ProductMeteredTierFeeUpdate
    /// </summary>
    [DataContract(Name = "ProductMeteredTierFee.Update")]
    public partial class ProductMeteredTierFeeUpdate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductMeteredTierFeeUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProductMeteredTierFeeUpdate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductMeteredTierFeeUpdate" /> class.
        /// </summary>
        /// <param name="startRange">Starting from and including this quantity is contained in the tier..</param>
        /// <param name="meteredFee">The metered fee that this tier belongs to..</param>
        /// <param name="fee">The amount charged to the customer for each consumed unit at the end of a billing cycle..</param>
        /// <param name="varVersion">The version number indicates the version of the entity. The version is incremented whenever the entity is changed. (required).</param>
        public ProductMeteredTierFeeUpdate(decimal startRange = default(decimal), long meteredFee = default(long), List<PersistableCurrencyAmountUpdate> fee = default(List<PersistableCurrencyAmountUpdate>), int varVersion = default(int))
        {
            this.VarVersion = varVersion;
            this.StartRange = startRange;
            this.MeteredFee = meteredFee;
            this.Fee = fee;
        }

        /// <summary>
        /// Starting from and including this quantity is contained in the tier.
        /// </summary>
        /// <value>Starting from and including this quantity is contained in the tier.</value>
        [DataMember(Name = "startRange", EmitDefaultValue = false)]
        public decimal StartRange { get; set; }

        /// <summary>
        /// The metered fee that this tier belongs to.
        /// </summary>
        /// <value>The metered fee that this tier belongs to.</value>
        [DataMember(Name = "meteredFee", EmitDefaultValue = false)]
        public long MeteredFee { get; set; }

        /// <summary>
        /// The amount charged to the customer for each consumed unit at the end of a billing cycle.
        /// </summary>
        /// <value>The amount charged to the customer for each consumed unit at the end of a billing cycle.</value>
        [DataMember(Name = "fee", EmitDefaultValue = false)]
        public List<PersistableCurrencyAmountUpdate> Fee { get; set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public int VarVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductMeteredTierFeeUpdate {\n");
            sb.Append("  StartRange: ").Append(StartRange).Append("\n");
            sb.Append("  MeteredFee: ").Append(MeteredFee).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
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
