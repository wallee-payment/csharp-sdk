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
    /// Defines DunningCaseLevelState
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum DunningCaseLevelState
    {
        
        /// <summary>
        /// Enum INITIALIZING for value: INITIALIZING
        /// </summary>
        [EnumMember(Value = "INITIALIZING")]
        INITIALIZING,
        
        /// <summary>
        /// Enum PENDING for value: PENDING
        /// </summary>
        [EnumMember(Value = "PENDING")]
        PENDING,
        
        /// <summary>
        /// Enum FAILED for value: FAILED
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED,
        
        /// <summary>
        /// Enum CANCELED for value: CANCELED
        /// </summary>
        [EnumMember(Value = "CANCELED")]
        CANCELED,
        
        /// <summary>
        /// Enum SUCCEEDED for value: SUCCEEDED
        /// </summary>
        [EnumMember(Value = "SUCCEEDED")]
        SUCCEEDED
    }

}
