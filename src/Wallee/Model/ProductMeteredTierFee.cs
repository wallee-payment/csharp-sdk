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
    /// ProductMeteredTierFee
    /// </summary>
    [DataContract(Name = "ProductMeteredTierFee")]
    public partial class ProductMeteredTierFee : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductMeteredTierFee" /> class.
        /// </summary>
        /// <param name="meteredFee">meteredFee.</param>
        public ProductMeteredTierFee(ProductMeteredFee meteredFee = default)
        {
            this.MeteredFee = meteredFee;
        }

        /// <summary>
        /// Starting from and including this quantity is contained in the tier.
        /// </summary>
        /// <value>Starting from and including this quantity is contained in the tier.</value>
        [DataMember(Name = "startRange", EmitDefaultValue = false)]
        public decimal StartRange { get; private set; }

        /// <summary>
        /// Returns false as StartRange should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStartRange()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets MeteredFee
        /// </summary>
        [DataMember(Name = "meteredFee", EmitDefaultValue = false)]
        public ProductMeteredFee MeteredFee { get; set; }

        /// <summary>
        /// The amount charged to the customer for each consumed unit at the end of a billing cycle.
        /// </summary>
        /// <value>The amount charged to the customer for each consumed unit at the end of a billing cycle.</value>
        [DataMember(Name = "fee", EmitDefaultValue = false)]
        public List<PersistableCurrencyAmount> Fee { get; private set; }

        /// <summary>
        /// Returns false as Fee should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFee()
        {
            return false;
        }
        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// The version is used for optimistic locking and incremented whenever the object is updated.
        /// </summary>
        /// <value>The version is used for optimistic locking and incremented whenever the object is updated.</value>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int VarVersion { get; private set; }

        /// <summary>
        /// Returns false as VarVersion should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVarVersion()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductMeteredTierFee {\n");
            sb.Append("  StartRange: ").Append(StartRange).Append("\n");
            sb.Append("  MeteredFee: ").Append(MeteredFee).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
