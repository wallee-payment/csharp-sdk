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
    /// SingleSignOnUserSearchResponse
    /// </summary>
    [DataContract(Name = "Single_Sign_On_User_Search_Response")]
    public partial class SingleSignOnUserSearchResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SingleSignOnUserSearchResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public SingleSignOnUserSearchResponse()
        {
        }

        /// <summary>
        /// An array containing the actual response objects.
        /// </summary>
        /// <value>An array containing the actual response objects.</value>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public List<SingleSignOnUser> Data { get; private set; }

        /// <summary>
        /// Returns false as Data should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeData()
        {
            return false;
        }
        /// <summary>
        /// The number of skipped objects.
        /// </summary>
        /// <value>The number of skipped objects.</value>
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
        /// Whether there are more objects available after this set. If false, there are no more objects to retrieve.
        /// </summary>
        /// <value>Whether there are more objects available after this set. If false, there are no more objects to retrieve.</value>
        [DataMember(Name = "hasMore", EmitDefaultValue = true)]
        public bool HasMore { get; private set; }

        /// <summary>
        /// Returns false as HasMore should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeHasMore()
        {
            return false;
        }
        /// <summary>
        /// The applied limit on the number of objects returned.
        /// </summary>
        /// <value>The applied limit on the number of objects returned.</value>
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SingleSignOnUserSearchResponse {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  HasMore: ").Append(HasMore).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
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
