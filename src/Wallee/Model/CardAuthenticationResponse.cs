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
    /// Defines CardAuthenticationResponse
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CardAuthenticationResponse
    {
        /// <summary>
        /// Enum FULLYAUTHENTICATED for value: FULLY_AUTHENTICATED
        /// </summary>
        [EnumMember(Value = "FULLY_AUTHENTICATED")]
        FULLYAUTHENTICATED = 1,

        /// <summary>
        /// Enum AUTHENTICATIONNOTREQUIRED for value: AUTHENTICATION_NOT_REQUIRED
        /// </summary>
        [EnumMember(Value = "AUTHENTICATION_NOT_REQUIRED")]
        AUTHENTICATIONNOTREQUIRED = 2,

        /// <summary>
        /// Enum NOTENROLLED for value: NOT_ENROLLED
        /// </summary>
        [EnumMember(Value = "NOT_ENROLLED")]
        NOTENROLLED = 3,

        /// <summary>
        /// Enum ENROLLMENTERROR for value: ENROLLMENT_ERROR
        /// </summary>
        [EnumMember(Value = "ENROLLMENT_ERROR")]
        ENROLLMENTERROR = 4,

        /// <summary>
        /// Enum AUTHENTICATIONERROR for value: AUTHENTICATION_ERROR
        /// </summary>
        [EnumMember(Value = "AUTHENTICATION_ERROR")]
        AUTHENTICATIONERROR = 5
    }

}
