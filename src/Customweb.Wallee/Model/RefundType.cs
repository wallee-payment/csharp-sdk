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
    /// Refund Type
    /// </summary>
    /// <value>Refund Type</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RefundType
    {
        
        /// <summary>
        /// Enum CUSTOMER_INITIATED_AUTOMATIC for "CUSTOMER_INITIATED_AUTOMATIC"
        /// </summary>
        [EnumMember(Value = "CUSTOMER_INITIATED_AUTOMATIC")]
        CUSTOMER_INITIATED_AUTOMATIC,
        
        /// <summary>
        /// Enum CUSTOMER_INITIATED_MANUAL for "CUSTOMER_INITIATED_MANUAL"
        /// </summary>
        [EnumMember(Value = "CUSTOMER_INITIATED_MANUAL")]
        CUSTOMER_INITIATED_MANUAL,
        
        /// <summary>
        /// Enum MERCHANT_INITIATED_ONLINE for "MERCHANT_INITIATED_ONLINE"
        /// </summary>
        [EnumMember(Value = "MERCHANT_INITIATED_ONLINE")]
        MERCHANT_INITIATED_ONLINE,
        
        /// <summary>
        /// Enum MERCHANT_INITIATED_OFFLINE for "MERCHANT_INITIATED_OFFLINE"
        /// </summary>
        [EnumMember(Value = "MERCHANT_INITIATED_OFFLINE")]
        MERCHANT_INITIATED_OFFLINE
    }

}
