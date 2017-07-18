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
    /// Manual Task Action Style
    /// </summary>
    /// <value>Manual Task Action Style</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ManualTaskActionStyle
    {
        
        /// <summary>
        /// Enum DEFAULT for "DEFAULT"
        /// </summary>
        [EnumMember(Value = "DEFAULT")]
        DEFAULT,
        
        /// <summary>
        /// Enum PRIMARY for "PRIMARY"
        /// </summary>
        [EnumMember(Value = "PRIMARY")]
        PRIMARY,
        
        /// <summary>
        /// Enum DANGER for "DANGER"
        /// </summary>
        [EnumMember(Value = "DANGER")]
        DANGER
    }

}
