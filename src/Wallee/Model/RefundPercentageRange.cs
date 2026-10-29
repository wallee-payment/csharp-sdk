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
    /// Defines RefundPercentageRange
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RefundPercentageRange
    {
        /// <summary>
        /// Enum ONETOFIVE for value: ONE_TO_FIVE
        /// </summary>
        [EnumMember(Value = "ONE_TO_FIVE")]
        ONETOFIVE = 1,

        /// <summary>
        /// Enum FIVETOTEN for value: FIVE_TO_TEN
        /// </summary>
        [EnumMember(Value = "FIVE_TO_TEN")]
        FIVETOTEN = 2,

        /// <summary>
        /// Enum TENTOFIFTEEN for value: TEN_TO_FIFTEEN
        /// </summary>
        [EnumMember(Value = "TEN_TO_FIFTEEN")]
        TENTOFIFTEEN = 3,

        /// <summary>
        /// Enum FIFTEENTOTWENTY for value: FIFTEEN_TO_TWENTY
        /// </summary>
        [EnumMember(Value = "FIFTEEN_TO_TWENTY")]
        FIFTEENTOTWENTY = 4,

        /// <summary>
        /// Enum TWENTYTOTHIRTY for value: TWENTY_TO_THIRTY
        /// </summary>
        [EnumMember(Value = "TWENTY_TO_THIRTY")]
        TWENTYTOTHIRTY = 5,

        /// <summary>
        /// Enum THIRTYTOFORTY for value: THIRTY_TO_FORTY
        /// </summary>
        [EnumMember(Value = "THIRTY_TO_FORTY")]
        THIRTYTOFORTY = 6,

        /// <summary>
        /// Enum FORTYTOFIFTY for value: FORTY_TO_FIFTY
        /// </summary>
        [EnumMember(Value = "FORTY_TO_FIFTY")]
        FORTYTOFIFTY = 7,

        /// <summary>
        /// Enum OVERFIFTY for value: OVER_FIFTY
        /// </summary>
        [EnumMember(Value = "OVER_FIFTY")]
        OVERFIFTY = 8
    }

}
