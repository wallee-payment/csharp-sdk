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
    /// Defines DisplayableDayOfWeek
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum DisplayableDayOfWeek
    {
        
        /// <summary>
        /// Enum MONDAY for value: MONDAY
        /// </summary>
        [EnumMember(Value = "MONDAY")]
        MONDAY,
        
        /// <summary>
        /// Enum TUESDAY for value: TUESDAY
        /// </summary>
        [EnumMember(Value = "TUESDAY")]
        TUESDAY,
        
        /// <summary>
        /// Enum WEDNESDAY for value: WEDNESDAY
        /// </summary>
        [EnumMember(Value = "WEDNESDAY")]
        WEDNESDAY,
        
        /// <summary>
        /// Enum THURSDAY for value: THURSDAY
        /// </summary>
        [EnumMember(Value = "THURSDAY")]
        THURSDAY,
        
        /// <summary>
        /// Enum FRIDAY for value: FRIDAY
        /// </summary>
        [EnumMember(Value = "FRIDAY")]
        FRIDAY,
        
        /// <summary>
        /// Enum SATURDAY for value: SATURDAY
        /// </summary>
        [EnumMember(Value = "SATURDAY")]
        SATURDAY,
        
        /// <summary>
        /// Enum SUNDAY for value: SUNDAY
        /// </summary>
        [EnumMember(Value = "SUNDAY")]
        SUNDAY
    }

}
