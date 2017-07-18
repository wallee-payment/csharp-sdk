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
    /// Subscription Charge State
    /// </summary>
    /// <value>Subscription Charge State</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionChargeState
    {
        
        /// <summary>
        /// Enum SCHEDULED for "SCHEDULED"
        /// </summary>
        [EnumMember(Value = "SCHEDULED")]
        SCHEDULED,
        
        /// <summary>
        /// Enum DISCARDED for "DISCARDED"
        /// </summary>
        [EnumMember(Value = "DISCARDED")]
        DISCARDED,
        
        /// <summary>
        /// Enum PROCESSING for "PROCESSING"
        /// </summary>
        [EnumMember(Value = "PROCESSING")]
        PROCESSING,
        
        /// <summary>
        /// Enum SUCCESSFUL for "SUCCESSFUL"
        /// </summary>
        [EnumMember(Value = "SUCCESSFUL")]
        SUCCESSFUL,
        
        /// <summary>
        /// Enum FAILED for "FAILED"
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED
    }

}
