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
    /// Defines LegalForm
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LegalForm
    {
        /// <summary>
        /// Enum SOLEPROPRIETORSHIP for value: SOLE_PROPRIETORSHIP
        /// </summary>
        [EnumMember(Value = "SOLE_PROPRIETORSHIP")]
        SOLEPROPRIETORSHIP = 1,

        /// <summary>
        /// Enum COOPERATIVE for value: COOPERATIVE
        /// </summary>
        [EnumMember(Value = "COOPERATIVE")]
        COOPERATIVE = 2,

        /// <summary>
        /// Enum PARTNERSHIPLIMITEDBYSHARES for value: PARTNERSHIP_LIMITED_BY_SHARES
        /// </summary>
        [EnumMember(Value = "PARTNERSHIP_LIMITED_BY_SHARES")]
        PARTNERSHIPLIMITEDBYSHARES = 3,

        /// <summary>
        /// Enum COMPANYLIMITEDBYSHARES for value: COMPANY_LIMITED_BY_SHARES
        /// </summary>
        [EnumMember(Value = "COMPANY_LIMITED_BY_SHARES")]
        COMPANYLIMITEDBYSHARES = 4,

        /// <summary>
        /// Enum LIMITEDLIABILITYCOMPANY for value: LIMITED_LIABILITY_COMPANY
        /// </summary>
        [EnumMember(Value = "LIMITED_LIABILITY_COMPANY")]
        LIMITEDLIABILITYCOMPANY = 5,

        /// <summary>
        /// Enum ASSOCIATION for value: ASSOCIATION
        /// </summary>
        [EnumMember(Value = "ASSOCIATION")]
        ASSOCIATION = 6,

        /// <summary>
        /// Enum FOUNDATION for value: FOUNDATION
        /// </summary>
        [EnumMember(Value = "FOUNDATION")]
        FOUNDATION = 7,

        /// <summary>
        /// Enum PUBLICINSTITUTION for value: PUBLIC_INSTITUTION
        /// </summary>
        [EnumMember(Value = "PUBLIC_INSTITUTION")]
        PUBLICINSTITUTION = 8,

        /// <summary>
        /// Enum GENERALPARTNERSHIP for value: GENERAL_PARTNERSHIP
        /// </summary>
        [EnumMember(Value = "GENERAL_PARTNERSHIP")]
        GENERALPARTNERSHIP = 9,

        /// <summary>
        /// Enum NONDEFINEDLEGALFORM for value: NON_DEFINED_LEGAL_FORM
        /// </summary>
        [EnumMember(Value = "NON_DEFINED_LEGAL_FORM")]
        NONDEFINEDLEGALFORM = 10,

        /// <summary>
        /// Enum PUBLICAGCORPORATION for value: PUBLIC_AG_CORPORATION
        /// </summary>
        [EnumMember(Value = "PUBLIC_AG_CORPORATION")]
        PUBLICAGCORPORATION = 11,

        /// <summary>
        /// Enum PUBLICLIMITEDLIABILITYCOMPANY for value: PUBLIC_LIMITED_LIABILITY_COMPANY
        /// </summary>
        [EnumMember(Value = "PUBLIC_LIMITED_LIABILITY_COMPANY")]
        PUBLICLIMITEDLIABILITYCOMPANY = 12,

        /// <summary>
        /// Enum BODYCORPORATE for value: BODY_CORPORATE
        /// </summary>
        [EnumMember(Value = "BODY_CORPORATE")]
        BODYCORPORATE = 13,

        /// <summary>
        /// Enum PUBLICCOOPERATIVE for value: PUBLIC_COOPERATIVE
        /// </summary>
        [EnumMember(Value = "PUBLIC_COOPERATIVE")]
        PUBLICCOOPERATIVE = 14,

        /// <summary>
        /// Enum PUBLICASSOCIATION for value: PUBLIC_ASSOCIATION
        /// </summary>
        [EnumMember(Value = "PUBLIC_ASSOCIATION")]
        PUBLICASSOCIATION = 15,

        /// <summary>
        /// Enum SPECIALLEGALFORM for value: SPECIAL_LEGAL_FORM
        /// </summary>
        [EnumMember(Value = "SPECIAL_LEGAL_FORM")]
        SPECIALLEGALFORM = 16,

        /// <summary>
        /// Enum LIMITEDPARTNERSHIPCOLLECTIVEINVESTMENT for value: LIMITED_PARTNERSHIP_COLLECTIVE_INVESTMENT
        /// </summary>
        [EnumMember(Value = "LIMITED_PARTNERSHIP_COLLECTIVE_INVESTMENT")]
        LIMITEDPARTNERSHIPCOLLECTIVEINVESTMENT = 17,

        /// <summary>
        /// Enum SIMPLEPARTNERSHIP for value: SIMPLE_PARTNERSHIP
        /// </summary>
        [EnumMember(Value = "SIMPLE_PARTNERSHIP")]
        SIMPLEPARTNERSHIP = 18,

        /// <summary>
        /// Enum INTERNATIONALORGANIZATION for value: INTERNATIONAL_ORGANIZATION
        /// </summary>
        [EnumMember(Value = "INTERNATIONAL_ORGANIZATION")]
        INTERNATIONALORGANIZATION = 19,

        /// <summary>
        /// Enum TRUST for value: TRUST
        /// </summary>
        [EnumMember(Value = "TRUST")]
        TRUST = 20,

        /// <summary>
        /// Enum FUND for value: FUND
        /// </summary>
        [EnumMember(Value = "FUND")]
        FUND = 21,

        /// <summary>
        /// Enum EUROPEANCOMPANY for value: EUROPEAN_COMPANY
        /// </summary>
        [EnumMember(Value = "EUROPEAN_COMPANY")]
        EUROPEANCOMPANY = 22,

        /// <summary>
        /// Enum LIMITEDPARTNERSHIP for value: LIMITED_PARTNERSHIP
        /// </summary>
        [EnumMember(Value = "LIMITED_PARTNERSHIP")]
        LIMITEDPARTNERSHIP = 23,

        /// <summary>
        /// Enum SIMPLIFIEDLIMITEDLIABILITYCOMPANY for value: SIMPLIFIED_LIMITED_LIABILITY_COMPANY
        /// </summary>
        [EnumMember(Value = "SIMPLIFIED_LIMITED_LIABILITY_COMPANY")]
        SIMPLIFIEDLIMITEDLIABILITYCOMPANY = 24,

        /// <summary>
        /// Enum CIVILCOMPANY for value: CIVIL_COMPANY
        /// </summary>
        [EnumMember(Value = "CIVIL_COMPANY")]
        CIVILCOMPANY = 25,

        /// <summary>
        /// Enum AGRICULTURALASSOCIATION for value: AGRICULTURAL_ASSOCIATION
        /// </summary>
        [EnumMember(Value = "AGRICULTURAL_ASSOCIATION")]
        AGRICULTURALASSOCIATION = 26,

        /// <summary>
        /// Enum ECONOMICINTERESTGROUP for value: ECONOMIC_INTEREST_GROUP
        /// </summary>
        [EnumMember(Value = "ECONOMIC_INTEREST_GROUP")]
        ECONOMICINTERESTGROUP = 27,

        /// <summary>
        /// Enum EUROPEANCOOPERATIVESOCIETY for value: EUROPEAN_COOPERATIVE_SOCIETY
        /// </summary>
        [EnumMember(Value = "EUROPEAN_COOPERATIVE_SOCIETY")]
        EUROPEANCOOPERATIVESOCIETY = 28,

        /// <summary>
        /// Enum EUROPEANECONOMICINTERESTGROUP for value: EUROPEAN_ECONOMIC_INTEREST_GROUP
        /// </summary>
        [EnumMember(Value = "EUROPEAN_ECONOMIC_INTEREST_GROUP")]
        EUROPEANECONOMICINTERESTGROUP = 29,

        /// <summary>
        /// Enum FRANCHISING for value: FRANCHISING
        /// </summary>
        [EnumMember(Value = "FRANCHISING")]
        FRANCHISING = 30,

        /// <summary>
        /// Enum SIMPLIFIEDSHAREHOLDERCOMPANY for value: SIMPLIFIED_SHAREHOLDER_COMPANY
        /// </summary>
        [EnumMember(Value = "SIMPLIFIED_SHAREHOLDER_COMPANY")]
        SIMPLIFIEDSHAREHOLDERCOMPANY = 31,

        /// <summary>
        /// Enum SINGLEMEMBERLIMITEDLIABILITYCOMPANY for value: SINGLE_MEMBER_LIMITED_LIABILITY_COMPANY
        /// </summary>
        [EnumMember(Value = "SINGLE_MEMBER_LIMITED_LIABILITY_COMPANY")]
        SINGLEMEMBERLIMITEDLIABILITYCOMPANY = 32,

        /// <summary>
        /// Enum SOCIETALIMPACTCOMPANY for value: SOCIETAL_IMPACT_COMPANY
        /// </summary>
        [EnumMember(Value = "SOCIETAL_IMPACT_COMPANY")]
        SOCIETALIMPACTCOMPANY = 33,

        /// <summary>
        /// Enum SPECIALLIMITEDPARTNERSHIP for value: SPECIAL_LIMITED_PARTNERSHIP
        /// </summary>
        [EnumMember(Value = "SPECIAL_LIMITED_PARTNERSHIP")]
        SPECIALLIMITEDPARTNERSHIP = 34,

        /// <summary>
        /// Enum TEMPORARYPARTNERSHIP for value: TEMPORARY_PARTNERSHIP
        /// </summary>
        [EnumMember(Value = "TEMPORARY_PARTNERSHIP")]
        TEMPORARYPARTNERSHIP = 35
    }

}
