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
    /// Defines ChargeType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ChargeType
    {
        
        /// <summary>
        /// Enum ASYNCHRONOUS for value: ASYNCHRONOUS
        /// </summary>
        [EnumMember(Value = "ASYNCHRONOUS")]
        ASYNCHRONOUS,
        
        /// <summary>
        /// Enum SYNCHRONOUS for value: SYNCHRONOUS
        /// </summary>
        [EnumMember(Value = "SYNCHRONOUS")]
        SYNCHRONOUS,
        
        /// <summary>
        /// Enum TOKEN for value: TOKEN
        /// </summary>
        [EnumMember(Value = "TOKEN")]
        TOKEN,
        
        /// <summary>
        /// Enum TERMINAL for value: TERMINAL
        /// </summary>
        [EnumMember(Value = "TERMINAL")]
        TERMINAL
    }

}
