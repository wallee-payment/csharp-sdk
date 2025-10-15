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
    /// Defines DisplayableMonth
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum DisplayableMonth
    {
        
        /// <summary>
        /// Enum JANUARY for value: JANUARY
        /// </summary>
        [EnumMember(Value = "JANUARY")]
        JANUARY,
        
        /// <summary>
        /// Enum FEBRUARY for value: FEBRUARY
        /// </summary>
        [EnumMember(Value = "FEBRUARY")]
        FEBRUARY,
        
        /// <summary>
        /// Enum MARCH for value: MARCH
        /// </summary>
        [EnumMember(Value = "MARCH")]
        MARCH,
        
        /// <summary>
        /// Enum APRIL for value: APRIL
        /// </summary>
        [EnumMember(Value = "APRIL")]
        APRIL,
        
        /// <summary>
        /// Enum MAY for value: MAY
        /// </summary>
        [EnumMember(Value = "MAY")]
        MAY,
        
        /// <summary>
        /// Enum JUNE for value: JUNE
        /// </summary>
        [EnumMember(Value = "JUNE")]
        JUNE,
        
        /// <summary>
        /// Enum JULY for value: JULY
        /// </summary>
        [EnumMember(Value = "JULY")]
        JULY,
        
        /// <summary>
        /// Enum AUGUST for value: AUGUST
        /// </summary>
        [EnumMember(Value = "AUGUST")]
        AUGUST,
        
        /// <summary>
        /// Enum SEPTEMBER for value: SEPTEMBER
        /// </summary>
        [EnumMember(Value = "SEPTEMBER")]
        SEPTEMBER,
        
        /// <summary>
        /// Enum OCTOBER for value: OCTOBER
        /// </summary>
        [EnumMember(Value = "OCTOBER")]
        OCTOBER,
        
        /// <summary>
        /// Enum NOVEMBER for value: NOVEMBER
        /// </summary>
        [EnumMember(Value = "NOVEMBER")]
        NOVEMBER,
        
        /// <summary>
        /// Enum DECEMBER for value: DECEMBER
        /// </summary>
        [EnumMember(Value = "DECEMBER")]
        DECEMBER
    }

}
