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
    /// Defines TransactionCompletionMode
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TransactionCompletionMode
    {
        
        /// <summary>
        /// Enum DIRECT for value: DIRECT
        /// </summary>
        [EnumMember(Value = "DIRECT")]
        DIRECT,
        
        /// <summary>
        /// Enum ONLINE for value: ONLINE
        /// </summary>
        [EnumMember(Value = "ONLINE")]
        ONLINE,
        
        /// <summary>
        /// Enum OFFLINE for value: OFFLINE
        /// </summary>
        [EnumMember(Value = "OFFLINE")]
        OFFLINE
    }

}
