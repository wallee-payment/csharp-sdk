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
    /// Failure Category
    /// </summary>
    /// <value>Failure Category</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FailureCategory
    {
        
        /// <summary>
        /// Enum TEMPORARY_ISSUE for "TEMPORARY_ISSUE"
        /// </summary>
        [EnumMember(Value = "TEMPORARY_ISSUE")]
        TEMPORARY_ISSUE,
        
        /// <summary>
        /// Enum INTERNAL for "INTERNAL"
        /// </summary>
        [EnumMember(Value = "INTERNAL")]
        INTERNAL,
        
        /// <summary>
        /// Enum END_USER for "END_USER"
        /// </summary>
        [EnumMember(Value = "END_USER")]
        END_USER,
        
        /// <summary>
        /// Enum CONFIGURATION for "CONFIGURATION"
        /// </summary>
        [EnumMember(Value = "CONFIGURATION")]
        CONFIGURATION,
        
        /// <summary>
        /// Enum DEVELOPER for "DEVELOPER"
        /// </summary>
        [EnumMember(Value = "DEVELOPER")]
        DEVELOPER
    }

}
