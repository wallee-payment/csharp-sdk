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
    /// Defines UserType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UserType
    {
        /// <summary>
        /// Enum HUMANUSER for value: HUMAN_USER
        /// </summary>
        [EnumMember(Value = "HUMAN_USER")]
        HUMANUSER = 1,

        /// <summary>
        /// Enum SINGLESIGNONUSER for value: SINGLE_SIGNON_USER
        /// </summary>
        [EnumMember(Value = "SINGLE_SIGNON_USER")]
        SINGLESIGNONUSER = 2,

        /// <summary>
        /// Enum APPLICATIONUSER for value: APPLICATION_USER
        /// </summary>
        [EnumMember(Value = "APPLICATION_USER")]
        APPLICATIONUSER = 3,

        /// <summary>
        /// Enum ANONYMOUSUSER for value: ANONYMOUS_USER
        /// </summary>
        [EnumMember(Value = "ANONYMOUS_USER")]
        ANONYMOUSUSER = 4,

        /// <summary>
        /// Enum SERVERUSER for value: SERVER_USER
        /// </summary>
        [EnumMember(Value = "SERVER_USER")]
        SERVERUSER = 5
    }

}
