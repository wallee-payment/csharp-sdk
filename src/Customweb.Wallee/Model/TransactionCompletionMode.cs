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
    /// Transaction Completion Mode
    /// </summary>
    /// <value>Transaction Completion Mode</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransactionCompletionMode
    {
        
        /// <summary>
        /// Enum DIRECT for "DIRECT"
        /// </summary>
        [EnumMember(Value = "DIRECT")]
        DIRECT,
        
        /// <summary>
        /// Enum ONLINE for "ONLINE"
        /// </summary>
        [EnumMember(Value = "ONLINE")]
        ONLINE,
        
        /// <summary>
        /// Enum OFFLINE for "OFFLINE"
        /// </summary>
        [EnumMember(Value = "OFFLINE")]
        OFFLINE
    }

}
