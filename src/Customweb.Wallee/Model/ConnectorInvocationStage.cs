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
    /// Connector Invocation Stage
    /// </summary>
    /// <value>Connector Invocation Stage</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ConnectorInvocationStage
    {
        
        /// <summary>
        /// Enum PAYMENT_METHOD_LIST for "PAYMENT_METHOD_LIST"
        /// </summary>
        [EnumMember(Value = "PAYMENT_METHOD_LIST")]
        PAYMENT_METHOD_LIST,
        
        /// <summary>
        /// Enum FORM_GENERATION for "FORM_GENERATION"
        /// </summary>
        [EnumMember(Value = "FORM_GENERATION")]
        FORM_GENERATION,
        
        /// <summary>
        /// Enum VALIDATION for "VALIDATION"
        /// </summary>
        [EnumMember(Value = "VALIDATION")]
        VALIDATION,
        
        /// <summary>
        /// Enum AUTHORIZATION for "AUTHORIZATION"
        /// </summary>
        [EnumMember(Value = "AUTHORIZATION")]
        AUTHORIZATION
    }

}
