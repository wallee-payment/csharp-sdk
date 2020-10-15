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
    /// Defines TransactionCompletionBehavior
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TransactionCompletionBehavior
    {
        
        /// <summary>
        /// Enum COMPLETE_IMMEDIATELY for value: COMPLETE_IMMEDIATELY
        /// </summary>
        [EnumMember(Value = "COMPLETE_IMMEDIATELY")]
        COMPLETE_IMMEDIATELY,
        
        /// <summary>
        /// Enum COMPLETE_DEFERRED for value: COMPLETE_DEFERRED
        /// </summary>
        [EnumMember(Value = "COMPLETE_DEFERRED")]
        COMPLETE_DEFERRED,
        
        /// <summary>
        /// Enum USE_CONFIGURATION for value: USE_CONFIGURATION
        /// </summary>
        [EnumMember(Value = "USE_CONFIGURATION")]
        USE_CONFIGURATION
    }

}
