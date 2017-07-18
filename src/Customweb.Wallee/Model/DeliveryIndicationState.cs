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
    /// Delivery Indication State
    /// </summary>
    /// <value>Delivery Indication State</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DeliveryIndicationState
    {
        
        /// <summary>
        /// Enum PENDING for "PENDING"
        /// </summary>
        [EnumMember(Value = "PENDING")]
        PENDING,
        
        /// <summary>
        /// Enum NOT_SUITABLE for "NOT_SUITABLE"
        /// </summary>
        [EnumMember(Value = "NOT_SUITABLE")]
        NOT_SUITABLE,
        
        /// <summary>
        /// Enum MANUAL_CHECK_REQUIRED for "MANUAL_CHECK_REQUIRED"
        /// </summary>
        [EnumMember(Value = "MANUAL_CHECK_REQUIRED")]
        MANUAL_CHECK_REQUIRED,
        
        /// <summary>
        /// Enum SUITABLE for "SUITABLE"
        /// </summary>
        [EnumMember(Value = "SUITABLE")]
        SUITABLE
    }

}
