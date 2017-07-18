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
    /// Transaction State
    /// </summary>
    /// <value>Transaction State</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransactionState
    {
        
        /// <summary>
        /// Enum CREATE for "CREATE"
        /// </summary>
        [EnumMember(Value = "CREATE")]
        CREATE,
        
        /// <summary>
        /// Enum PENDING for "PENDING"
        /// </summary>
        [EnumMember(Value = "PENDING")]
        PENDING,
        
        /// <summary>
        /// Enum CONFIRMED for "CONFIRMED"
        /// </summary>
        [EnumMember(Value = "CONFIRMED")]
        CONFIRMED,
        
        /// <summary>
        /// Enum PROCESSING for "PROCESSING"
        /// </summary>
        [EnumMember(Value = "PROCESSING")]
        PROCESSING,
        
        /// <summary>
        /// Enum FAILED for "FAILED"
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED,
        
        /// <summary>
        /// Enum AUTHORIZED for "AUTHORIZED"
        /// </summary>
        [EnumMember(Value = "AUTHORIZED")]
        AUTHORIZED,
        
        /// <summary>
        /// Enum VOIDED for "VOIDED"
        /// </summary>
        [EnumMember(Value = "VOIDED")]
        VOIDED,
        
        /// <summary>
        /// Enum COMPLETED for "COMPLETED"
        /// </summary>
        [EnumMember(Value = "COMPLETED")]
        COMPLETED,
        
        /// <summary>
        /// Enum FULFILL for "FULFILL"
        /// </summary>
        [EnumMember(Value = "FULFILL")]
        FULFILL,
        
        /// <summary>
        /// Enum DECLINE for "DECLINE"
        /// </summary>
        [EnumMember(Value = "DECLINE")]
        DECLINE
    }

}
