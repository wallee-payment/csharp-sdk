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
    /// Transaction Invoice State
    /// </summary>
    /// <value>Transaction Invoice State</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransactionInvoiceState
    {
        
        /// <summary>
        /// Enum CREATE for "CREATE"
        /// </summary>
        [EnumMember(Value = "CREATE")]
        CREATE,
        
        /// <summary>
        /// Enum OPEN for "OPEN"
        /// </summary>
        [EnumMember(Value = "OPEN")]
        OPEN,
        
        /// <summary>
        /// Enum OVERDUE for "OVERDUE"
        /// </summary>
        [EnumMember(Value = "OVERDUE")]
        OVERDUE,
        
        /// <summary>
        /// Enum CANCELED for "CANCELED"
        /// </summary>
        [EnumMember(Value = "CANCELED")]
        CANCELED,
        
        /// <summary>
        /// Enum PAID for "PAID"
        /// </summary>
        [EnumMember(Value = "PAID")]
        PAID,
        
        /// <summary>
        /// Enum DERECOGNIZED for "DERECOGNIZED"
        /// </summary>
        [EnumMember(Value = "DERECOGNIZED")]
        DERECOGNIZED,
        
        /// <summary>
        /// Enum NOT_APPLICABLE for "NOT_APPLICABLE"
        /// </summary>
        [EnumMember(Value = "NOT_APPLICABLE")]
        NOT_APPLICABLE
    }

}
