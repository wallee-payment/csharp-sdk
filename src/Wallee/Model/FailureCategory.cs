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
    /// Defines FailureCategory
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum FailureCategory
    {
        
        /// <summary>
        /// Enum TEMPORARY_ISSUE for value: TEMPORARY_ISSUE
        /// </summary>
        [EnumMember(Value = "TEMPORARY_ISSUE")]
        TEMPORARY_ISSUE,
        
        /// <summary>
        /// Enum INTERNAL for value: INTERNAL
        /// </summary>
        [EnumMember(Value = "INTERNAL")]
        INTERNAL,
        
        /// <summary>
        /// Enum END_USER for value: END_USER
        /// </summary>
        [EnumMember(Value = "END_USER")]
        END_USER,
        
        /// <summary>
        /// Enum CONFIGURATION for value: CONFIGURATION
        /// </summary>
        [EnumMember(Value = "CONFIGURATION")]
        CONFIGURATION,
        
        /// <summary>
        /// Enum DEVELOPER for value: DEVELOPER
        /// </summary>
        [EnumMember(Value = "DEVELOPER")]
        DEVELOPER
    }

}
