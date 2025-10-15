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
    /// Defines DunningCaseState
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum DunningCaseState
    {
        
        /// <summary>
        /// Enum RUNNING for value: RUNNING
        /// </summary>
        [EnumMember(Value = "RUNNING")]
        RUNNING,
        
        /// <summary>
        /// Enum SUSPENDED for value: SUSPENDED
        /// </summary>
        [EnumMember(Value = "SUSPENDED")]
        SUSPENDED,
        
        /// <summary>
        /// Enum CANCELED for value: CANCELED
        /// </summary>
        [EnumMember(Value = "CANCELED")]
        CANCELED,
        
        /// <summary>
        /// Enum DERECOGNIZED for value: DERECOGNIZED
        /// </summary>
        [EnumMember(Value = "DERECOGNIZED")]
        DERECOGNIZED,
        
        /// <summary>
        /// Enum FAILED for value: FAILED
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED,
        
        /// <summary>
        /// Enum SUCCEEDED for value: SUCCEEDED
        /// </summary>
        [EnumMember(Value = "SUCCEEDED")]
        SUCCEEDED
    }

}
