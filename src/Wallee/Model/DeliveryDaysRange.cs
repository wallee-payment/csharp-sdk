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
    /// Defines DeliveryDaysRange
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DeliveryDaysRange
    {
        /// <summary>
        /// Enum ZERODAYS for value: ZERO_DAYS
        /// </summary>
        [EnumMember(Value = "ZERO_DAYS")]
        ZERODAYS = 1,

        /// <summary>
        /// Enum ONETOTHREEDAYS for value: ONE_TO_THREE_DAYS
        /// </summary>
        [EnumMember(Value = "ONE_TO_THREE_DAYS")]
        ONETOTHREEDAYS = 2,

        /// <summary>
        /// Enum THREETOFIVEDAYS for value: THREE_TO_FIVE_DAYS
        /// </summary>
        [EnumMember(Value = "THREE_TO_FIVE_DAYS")]
        THREETOFIVEDAYS = 3,

        /// <summary>
        /// Enum FIVETOTENDAYS for value: FIVE_TO_TEN_DAYS
        /// </summary>
        [EnumMember(Value = "FIVE_TO_TEN_DAYS")]
        FIVETOTENDAYS = 4,

        /// <summary>
        /// Enum TENTOFIFTEENDAYS for value: TEN_TO_FIFTEEN_DAYS
        /// </summary>
        [EnumMember(Value = "TEN_TO_FIFTEEN_DAYS")]
        TENTOFIFTEENDAYS = 5,

        /// <summary>
        /// Enum FIFTEENTOTWENTYDAYS for value: FIFTEEN_TO_TWENTY_DAYS
        /// </summary>
        [EnumMember(Value = "FIFTEEN_TO_TWENTY_DAYS")]
        FIFTEENTOTWENTYDAYS = 6,

        /// <summary>
        /// Enum TWENTYTOTHIRTYDAYS for value: TWENTY_TO_THIRTY_DAYS
        /// </summary>
        [EnumMember(Value = "TWENTY_TO_THIRTY_DAYS")]
        TWENTYTOTHIRTYDAYS = 7,

        /// <summary>
        /// Enum THIRTYTOFORTYDAYS for value: THIRTY_TO_FORTY_DAYS
        /// </summary>
        [EnumMember(Value = "THIRTY_TO_FORTY_DAYS")]
        THIRTYTOFORTYDAYS = 8,

        /// <summary>
        /// Enum FORTYTOFIFTYDAYS for value: FORTY_TO_FIFTY_DAYS
        /// </summary>
        [EnumMember(Value = "FORTY_TO_FIFTY_DAYS")]
        FORTYTOFIFTYDAYS = 9,

        /// <summary>
        /// Enum FIFTYTOSIXTYDAYS for value: FIFTY_TO_SIXTY_DAYS
        /// </summary>
        [EnumMember(Value = "FIFTY_TO_SIXTY_DAYS")]
        FIFTYTOSIXTYDAYS = 10,

        /// <summary>
        /// Enum SIXTYTONINETYDAYS for value: SIXTY_TO_NINETY_DAYS
        /// </summary>
        [EnumMember(Value = "SIXTY_TO_NINETY_DAYS")]
        SIXTYTONINETYDAYS = 11,

        /// <summary>
        /// Enum OVERNINETYDAYS for value: OVER_NINETY_DAYS
        /// </summary>
        [EnumMember(Value = "OVER_NINETY_DAYS")]
        OVERNINETYDAYS = 12
    }

}
