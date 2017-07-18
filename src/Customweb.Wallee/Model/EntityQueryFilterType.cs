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
    /// The filter type defines how the filter is interpreted. Depending of the type different properties are relevant on the filter itself.
    /// </summary>
    /// <value>The filter type defines how the filter is interpreted. Depending of the type different properties are relevant on the filter itself.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EntityQueryFilterType
    {
        
        /// <summary>
        /// Enum LEAF for "LEAF"
        /// </summary>
        [EnumMember(Value = "LEAF")]
        LEAF,
        
        /// <summary>
        /// Enum OR for "OR"
        /// </summary>
        [EnumMember(Value = "OR")]
        OR,
        
        /// <summary>
        /// Enum AND for "AND"
        /// </summary>
        [EnumMember(Value = "AND")]
        AND
    }

}
