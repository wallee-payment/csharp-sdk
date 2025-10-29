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
    /// The tokenization mode controls how the tokenization of payment information is applied on the transaction.
    /// </summary>
    /// <value>The tokenization mode controls how the tokenization of payment information is applied on the transaction.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TokenizationMode
    {
        /// <summary>
        /// Enum FORCEUPDATE for value: FORCE_UPDATE
        /// </summary>
        [EnumMember(Value = "FORCE_UPDATE")]
        FORCEUPDATE = 1,

        /// <summary>
        /// Enum FORCECREATION for value: FORCE_CREATION
        /// </summary>
        [EnumMember(Value = "FORCE_CREATION")]
        FORCECREATION = 2,

        /// <summary>
        /// Enum FORCECREATIONWITHONECLICKPAYMENT for value: FORCE_CREATION_WITH_ONE_CLICK_PAYMENT
        /// </summary>
        [EnumMember(Value = "FORCE_CREATION_WITH_ONE_CLICK_PAYMENT")]
        FORCECREATIONWITHONECLICKPAYMENT = 3,

        /// <summary>
        /// Enum ALLOWONECLICKPAYMENT for value: ALLOW_ONE_CLICK_PAYMENT
        /// </summary>
        [EnumMember(Value = "ALLOW_ONE_CLICK_PAYMENT")]
        ALLOWONECLICKPAYMENT = 4
    }

}
