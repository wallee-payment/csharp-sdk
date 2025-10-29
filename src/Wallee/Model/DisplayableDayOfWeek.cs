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
    /// Defines DisplayableDayOfWeek
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DisplayableDayOfWeek
    {
        /// <summary>
        /// Enum MONDAY for value: MONDAY
        /// </summary>
        [EnumMember(Value = "MONDAY")]
        MONDAY = 1,

        /// <summary>
        /// Enum TUESDAY for value: TUESDAY
        /// </summary>
        [EnumMember(Value = "TUESDAY")]
        TUESDAY = 2,

        /// <summary>
        /// Enum WEDNESDAY for value: WEDNESDAY
        /// </summary>
        [EnumMember(Value = "WEDNESDAY")]
        WEDNESDAY = 3,

        /// <summary>
        /// Enum THURSDAY for value: THURSDAY
        /// </summary>
        [EnumMember(Value = "THURSDAY")]
        THURSDAY = 4,

        /// <summary>
        /// Enum FRIDAY for value: FRIDAY
        /// </summary>
        [EnumMember(Value = "FRIDAY")]
        FRIDAY = 5,

        /// <summary>
        /// Enum SATURDAY for value: SATURDAY
        /// </summary>
        [EnumMember(Value = "SATURDAY")]
        SATURDAY = 6,

        /// <summary>
        /// Enum SUNDAY for value: SUNDAY
        /// </summary>
        [EnumMember(Value = "SUNDAY")]
        SUNDAY = 7
    }

}
