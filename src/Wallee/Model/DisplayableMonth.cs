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
    /// Defines DisplayableMonth
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DisplayableMonth
    {
        /// <summary>
        /// Enum JANUARY for value: JANUARY
        /// </summary>
        [EnumMember(Value = "JANUARY")]
        JANUARY = 1,

        /// <summary>
        /// Enum FEBRUARY for value: FEBRUARY
        /// </summary>
        [EnumMember(Value = "FEBRUARY")]
        FEBRUARY = 2,

        /// <summary>
        /// Enum MARCH for value: MARCH
        /// </summary>
        [EnumMember(Value = "MARCH")]
        MARCH = 3,

        /// <summary>
        /// Enum APRIL for value: APRIL
        /// </summary>
        [EnumMember(Value = "APRIL")]
        APRIL = 4,

        /// <summary>
        /// Enum MAY for value: MAY
        /// </summary>
        [EnumMember(Value = "MAY")]
        MAY = 5,

        /// <summary>
        /// Enum JUNE for value: JUNE
        /// </summary>
        [EnumMember(Value = "JUNE")]
        JUNE = 6,

        /// <summary>
        /// Enum JULY for value: JULY
        /// </summary>
        [EnumMember(Value = "JULY")]
        JULY = 7,

        /// <summary>
        /// Enum AUGUST for value: AUGUST
        /// </summary>
        [EnumMember(Value = "AUGUST")]
        AUGUST = 8,

        /// <summary>
        /// Enum SEPTEMBER for value: SEPTEMBER
        /// </summary>
        [EnumMember(Value = "SEPTEMBER")]
        SEPTEMBER = 9,

        /// <summary>
        /// Enum OCTOBER for value: OCTOBER
        /// </summary>
        [EnumMember(Value = "OCTOBER")]
        OCTOBER = 10,

        /// <summary>
        /// Enum NOVEMBER for value: NOVEMBER
        /// </summary>
        [EnumMember(Value = "NOVEMBER")]
        NOVEMBER = 11,

        /// <summary>
        /// Enum DECEMBER for value: DECEMBER
        /// </summary>
        [EnumMember(Value = "DECEMBER")]
        DECEMBER = 12
    }

}
