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
    /// Defines PanType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PanType
    {
        /// <summary>
        /// Enum PLAIN for value: PLAIN
        /// </summary>
        [EnumMember(Value = "PLAIN")]
        PLAIN = 1,

        /// <summary>
        /// Enum PLAINGOOGLEPAY for value: PLAIN_GOOGLE_PAY
        /// </summary>
        [EnumMember(Value = "PLAIN_GOOGLE_PAY")]
        PLAINGOOGLEPAY = 2,

        /// <summary>
        /// Enum SCHEMETOKEN for value: SCHEME_TOKEN
        /// </summary>
        [EnumMember(Value = "SCHEME_TOKEN")]
        SCHEMETOKEN = 3,

        /// <summary>
        /// Enum SCHEMETOKENCLICKTOPAY for value: SCHEME_TOKEN_CLICK_TO_PAY
        /// </summary>
        [EnumMember(Value = "SCHEME_TOKEN_CLICK_TO_PAY")]
        SCHEMETOKENCLICKTOPAY = 4,

        /// <summary>
        /// Enum DEVICETOKENAPPLEPAY for value: DEVICE_TOKEN_APPLE_PAY
        /// </summary>
        [EnumMember(Value = "DEVICE_TOKEN_APPLE_PAY")]
        DEVICETOKENAPPLEPAY = 5,

        /// <summary>
        /// Enum DEVICETOKENGOOGLEPAY for value: DEVICE_TOKEN_GOOGLE_PAY
        /// </summary>
        [EnumMember(Value = "DEVICE_TOKEN_GOOGLE_PAY")]
        DEVICETOKENGOOGLEPAY = 6,

        /// <summary>
        /// Enum DEVICETOKENSAMSUNGPAY for value: DEVICE_TOKEN_SAMSUNG_PAY
        /// </summary>
        [EnumMember(Value = "DEVICE_TOKEN_SAMSUNG_PAY")]
        DEVICETOKENSAMSUNGPAY = 7,

        /// <summary>
        /// Enum DEVICETOKENANDROIDPAY for value: DEVICE_TOKEN_ANDROID_PAY
        /// </summary>
        [EnumMember(Value = "DEVICE_TOKEN_ANDROID_PAY")]
        DEVICETOKENANDROIDPAY = 8
    }

}
