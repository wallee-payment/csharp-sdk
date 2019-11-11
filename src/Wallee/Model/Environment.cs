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
    /// Defines Environment
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum Environment
    {
        
        /// <summary>
        /// Enum LIVE for value: LIVE
        /// </summary>
        [EnumMember(Value = "LIVE")]
        LIVE,
        
        /// <summary>
        /// Enum PREVIEW for value: PREVIEW
        /// </summary>
        [EnumMember(Value = "PREVIEW")]
        PREVIEW
    }

}
