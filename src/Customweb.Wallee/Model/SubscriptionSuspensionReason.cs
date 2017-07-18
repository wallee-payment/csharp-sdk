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
    /// Subscription Suspension Reason
    /// </summary>
    /// <value>Subscription Suspension Reason</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionSuspensionReason
    {
        
        /// <summary>
        /// Enum FAILED_CHARGE for "FAILED_CHARGE"
        /// </summary>
        [EnumMember(Value = "FAILED_CHARGE")]
        FAILED_CHARGE,
        
        /// <summary>
        /// Enum SUBSCRIBER_INITIATED_REFUND for "SUBSCRIBER_INITIATED_REFUND"
        /// </summary>
        [EnumMember(Value = "SUBSCRIBER_INITIATED_REFUND")]
        SUBSCRIBER_INITIATED_REFUND,
        
        /// <summary>
        /// Enum MANUAL for "MANUAL"
        /// </summary>
        [EnumMember(Value = "MANUAL")]
        MANUAL
    }

}
