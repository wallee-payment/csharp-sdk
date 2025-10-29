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
    /// Defines RestAddressFormatField
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RestAddressFormatField
    {
        /// <summary>
        /// Enum GIVENNAME for value: GIVEN_NAME
        /// </summary>
        [EnumMember(Value = "GIVEN_NAME")]
        GIVENNAME = 1,

        /// <summary>
        /// Enum FAMILYNAME for value: FAMILY_NAME
        /// </summary>
        [EnumMember(Value = "FAMILY_NAME")]
        FAMILYNAME = 2,

        /// <summary>
        /// Enum ORGANIZATIONNAME for value: ORGANIZATION_NAME
        /// </summary>
        [EnumMember(Value = "ORGANIZATION_NAME")]
        ORGANIZATIONNAME = 3,

        /// <summary>
        /// Enum STREET for value: STREET
        /// </summary>
        [EnumMember(Value = "STREET")]
        STREET = 4,

        /// <summary>
        /// Enum DEPENDENTLOCALITY for value: DEPENDENT_LOCALITY
        /// </summary>
        [EnumMember(Value = "DEPENDENT_LOCALITY")]
        DEPENDENTLOCALITY = 5,

        /// <summary>
        /// Enum CITY for value: CITY
        /// </summary>
        [EnumMember(Value = "CITY")]
        CITY = 6,

        /// <summary>
        /// Enum POSTALSTATE for value: POSTAL_STATE
        /// </summary>
        [EnumMember(Value = "POSTAL_STATE")]
        POSTALSTATE = 7,

        /// <summary>
        /// Enum POSTCODE for value: POST_CODE
        /// </summary>
        [EnumMember(Value = "POST_CODE")]
        POSTCODE = 8,

        /// <summary>
        /// Enum SORTINGCODE for value: SORTING_CODE
        /// </summary>
        [EnumMember(Value = "SORTING_CODE")]
        SORTINGCODE = 9,

        /// <summary>
        /// Enum COUNTRY for value: COUNTRY
        /// </summary>
        [EnumMember(Value = "COUNTRY")]
        COUNTRY = 10
    }

}
