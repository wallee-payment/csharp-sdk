using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Wallee.Client.SwaggerDateConverter;

namespace Wallee.Model
{
    /// <summary>
    /// Defines RestAddressFormatField
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum RestAddressFormatField
    {
        
        /// <summary>
        /// Enum GIVEN_NAME for value: GIVEN_NAME
        /// </summary>
        [EnumMember(Value = "GIVEN_NAME")]
        GIVEN_NAME,
        
        /// <summary>
        /// Enum FAMILY_NAME for value: FAMILY_NAME
        /// </summary>
        [EnumMember(Value = "FAMILY_NAME")]
        FAMILY_NAME,
        
        /// <summary>
        /// Enum ORGANIZATION_NAME for value: ORGANIZATION_NAME
        /// </summary>
        [EnumMember(Value = "ORGANIZATION_NAME")]
        ORGANIZATION_NAME,
        
        /// <summary>
        /// Enum STREET for value: STREET
        /// </summary>
        [EnumMember(Value = "STREET")]
        STREET,
        
        /// <summary>
        /// Enum DEPENDENT_LOCALITY for value: DEPENDENT_LOCALITY
        /// </summary>
        [EnumMember(Value = "DEPENDENT_LOCALITY")]
        DEPENDENT_LOCALITY,
        
        /// <summary>
        /// Enum CITY for value: CITY
        /// </summary>
        [EnumMember(Value = "CITY")]
        CITY,
        
        /// <summary>
        /// Enum POSTAL_STATE for value: POSTAL_STATE
        /// </summary>
        [EnumMember(Value = "POSTAL_STATE")]
        POSTAL_STATE,
        
        /// <summary>
        /// Enum POST_CODE for value: POST_CODE
        /// </summary>
        [EnumMember(Value = "POST_CODE")]
        POST_CODE,
        
        /// <summary>
        /// Enum SORTING_CODE for value: SORTING_CODE
        /// </summary>
        [EnumMember(Value = "SORTING_CODE")]
        SORTING_CODE,
        
        /// <summary>
        /// Enum COUNTRY for value: COUNTRY
        /// </summary>
        [EnumMember(Value = "COUNTRY")]
        COUNTRY
    }

}
