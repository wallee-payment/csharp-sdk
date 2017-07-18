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
    /// User Type
    /// </summary>
    /// <value>User Type</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UserType
    {
        
        /// <summary>
        /// Enum HUMAN_USER for "HUMAN_USER"
        /// </summary>
        [EnumMember(Value = "HUMAN_USER")]
        HUMAN_USER,
        
        /// <summary>
        /// Enum APPLICATION_USER for "APPLICATION_USER"
        /// </summary>
        [EnumMember(Value = "APPLICATION_USER")]
        APPLICATION_USER,
        
        /// <summary>
        /// Enum ANONYMOUS_USER for "ANONYMOUS_USER"
        /// </summary>
        [EnumMember(Value = "ANONYMOUS_USER")]
        ANONYMOUS_USER,
        
        /// <summary>
        /// Enum SERVER_USER for "SERVER_USER"
        /// </summary>
        [EnumMember(Value = "SERVER_USER")]
        SERVER_USER
    }

}
