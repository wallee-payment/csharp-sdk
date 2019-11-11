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
    /// Defines CriteriaOperator
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum CriteriaOperator
    {
        
        /// <summary>
        /// Enum CONTAINS for value: CONTAINS
        /// </summary>
        [EnumMember(Value = "CONTAINS")]
        CONTAINS,
        
        /// <summary>
        /// Enum EQUALS for value: EQUALS
        /// </summary>
        [EnumMember(Value = "EQUALS")]
        EQUALS,
        
        /// <summary>
        /// Enum EQUALS_IGNORE_CASE for value: EQUALS_IGNORE_CASE
        /// </summary>
        [EnumMember(Value = "EQUALS_IGNORE_CASE")]
        EQUALS_IGNORE_CASE,
        
        /// <summary>
        /// Enum GREATER_THAN for value: GREATER_THAN
        /// </summary>
        [EnumMember(Value = "GREATER_THAN")]
        GREATER_THAN,
        
        /// <summary>
        /// Enum GREATER_THAN_OR_EQUAL for value: GREATER_THAN_OR_EQUAL
        /// </summary>
        [EnumMember(Value = "GREATER_THAN_OR_EQUAL")]
        GREATER_THAN_OR_EQUAL,
        
        /// <summary>
        /// Enum LESS_THAN for value: LESS_THAN
        /// </summary>
        [EnumMember(Value = "LESS_THAN")]
        LESS_THAN,
        
        /// <summary>
        /// Enum LESS_THAN_OR_EQUAL for value: LESS_THAN_OR_EQUAL
        /// </summary>
        [EnumMember(Value = "LESS_THAN_OR_EQUAL")]
        LESS_THAN_OR_EQUAL,
        
        /// <summary>
        /// Enum NOT_EQUALS for value: NOT_EQUALS
        /// </summary>
        [EnumMember(Value = "NOT_EQUALS")]
        NOT_EQUALS,
        
        /// <summary>
        /// Enum NOT_EQUALS_IGNORE_CASE for value: NOT_EQUALS_IGNORE_CASE
        /// </summary>
        [EnumMember(Value = "NOT_EQUALS_IGNORE_CASE")]
        NOT_EQUALS_IGNORE_CASE,
        
        /// <summary>
        /// Enum NOT_CONTAINS for value: NOT_CONTAINS
        /// </summary>
        [EnumMember(Value = "NOT_CONTAINS")]
        NOT_CONTAINS,
        
        /// <summary>
        /// Enum IS_NULL for value: IS_NULL
        /// </summary>
        [EnumMember(Value = "IS_NULL")]
        IS_NULL,
        
        /// <summary>
        /// Enum IS_NOT_NULL for value: IS_NOT_NULL
        /// </summary>
        [EnumMember(Value = "IS_NOT_NULL")]
        IS_NOT_NULL
    }

}
