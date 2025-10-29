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
    /// ResultPortionModel
    /// </summary>
    [DataContract(Name = "ResultPortionModel")]
    public partial class ResultPortionModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResultPortionModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ResultPortionModel()
        {
        }

        /// <summary>
        /// 0-based offset of items.
        /// </summary>
        /// <value>0-based offset of items.</value>
        [DataMember(Name = "offset", EmitDefaultValue = false)]
        public int Offset { get; private set; }

        /// <summary>
        /// Returns false as Offset should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOffset()
        {
            return false;
        }
        /// <summary>
        /// Amount of items in portion.
        /// </summary>
        /// <value>Amount of items in portion.</value>
        [DataMember(Name = "limit", EmitDefaultValue = false)]
        public int Limit { get; private set; }

        /// <summary>
        /// Returns false as Limit should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLimit()
        {
            return false;
        }
        /// <summary>
        /// Total count of items.
        /// </summary>
        /// <value>Total count of items.</value>
        [DataMember(Name = "totalCount", EmitDefaultValue = false)]
        public long TotalCount { get; private set; }

        /// <summary>
        /// Returns false as TotalCount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTotalCount()
        {
            return false;
        }
        /// <summary>
        /// Items of the result portion.
        /// </summary>
        /// <value>Items of the result portion.</value>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public List<Object> Items { get; private set; }

        /// <summary>
        /// Returns false as Items should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeItems()
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
            sb.Append("class ResultPortionModel {\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
