/**
 * Wallee AG C# SDK
 *
 * This library allows to interact with the Wallee AG payment service.
 *
 * Copyright owner: Wallee AG
 * Website: https://en.wallee.com
 * Developer email: ecosystem-team@wallee.com
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Wallee.Client.OpenAPIDateConverter;

namespace Wallee.Model
{
    /// <summary>
    /// The primary risk taker will have the main loss when one party of the contract does not fulfill the contractual duties.
    /// </summary>
    /// <value>The primary risk taker will have the main loss when one party of the contract does not fulfill the contractual duties.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentPrimaryRiskTaker
    {
        /// <summary>
        /// Enum CUSTOMER for value: CUSTOMER
        /// </summary>
        [EnumMember(Value = "CUSTOMER")]
        CUSTOMER = 1,

        /// <summary>
        /// Enum MERCHANT for value: MERCHANT
        /// </summary>
        [EnumMember(Value = "MERCHANT")]
        MERCHANT = 2,

        /// <summary>
        /// Enum THIRDPARTY for value: THIRD_PARTY
        /// </summary>
        [EnumMember(Value = "THIRD_PARTY")]
        THIRDPARTY = 3
    }

}
