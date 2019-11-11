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
    /// Defines ManualTaskState
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ManualTaskState
    {
        
        /// <summary>
        /// Enum OPEN for value: OPEN
        /// </summary>
        [EnumMember(Value = "OPEN")]
        OPEN,
        
        /// <summary>
        /// Enum DONE for value: DONE
        /// </summary>
        [EnumMember(Value = "DONE")]
        DONE,
        
        /// <summary>
        /// Enum EXPIRED for value: EXPIRED
        /// </summary>
        [EnumMember(Value = "EXPIRED")]
        EXPIRED
    }

}
