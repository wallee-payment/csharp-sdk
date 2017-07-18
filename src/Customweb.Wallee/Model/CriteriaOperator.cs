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
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Criteria Operator
    /// </summary>
    /// <value>Criteria Operator</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CriteriaOperator
    {
        
        /// <summary>
        /// Enum EQUALS for "EQUALS"
        /// </summary>
        [EnumMember(Value = "EQUALS")]
        EQUALS,
        
        /// <summary>
        /// Enum GREATER_THAN for "GREATER_THAN"
        /// </summary>
        [EnumMember(Value = "GREATER_THAN")]
        GREATER_THAN,
        
        /// <summary>
        /// Enum GREATER_THAN_OR_EQUAL for "GREATER_THAN_OR_EQUAL"
        /// </summary>
        [EnumMember(Value = "GREATER_THAN_OR_EQUAL")]
        GREATER_THAN_OR_EQUAL,
        
        /// <summary>
        /// Enum LESS_THAN for "LESS_THAN"
        /// </summary>
        [EnumMember(Value = "LESS_THAN")]
        LESS_THAN,
        
        /// <summary>
        /// Enum LESS_THAN_OR_EQUAL for "LESS_THAN_OR_EQUAL"
        /// </summary>
        [EnumMember(Value = "LESS_THAN_OR_EQUAL")]
        LESS_THAN_OR_EQUAL,
        
        /// <summary>
        /// Enum CONTAINS for "CONTAINS"
        /// </summary>
        [EnumMember(Value = "CONTAINS")]
        CONTAINS,
        
        /// <summary>
        /// Enum NOT_EQUALS for "NOT_EQUALS"
        /// </summary>
        [EnumMember(Value = "NOT_EQUALS")]
        NOT_EQUALS,
        
        /// <summary>
        /// Enum NOT_CONTAINS for "NOT_CONTAINS"
        /// </summary>
        [EnumMember(Value = "NOT_CONTAINS")]
        NOT_CONTAINS,
        
        /// <summary>
        /// Enum IS_NULL for "IS_NULL"
        /// </summary>
        [EnumMember(Value = "IS_NULL")]
        IS_NULL
    }

}
