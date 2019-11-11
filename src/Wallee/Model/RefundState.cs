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
    /// Defines RefundState
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum RefundState
    {
        
        /// <summary>
        /// Enum CREATE for value: CREATE
        /// </summary>
        [EnumMember(Value = "CREATE")]
        CREATE,
        
        /// <summary>
        /// Enum SCHEDULED for value: SCHEDULED
        /// </summary>
        [EnumMember(Value = "SCHEDULED")]
        SCHEDULED,
        
        /// <summary>
        /// Enum PENDING for value: PENDING
        /// </summary>
        [EnumMember(Value = "PENDING")]
        PENDING,
        
        /// <summary>
        /// Enum MANUAL_CHECK for value: MANUAL_CHECK
        /// </summary>
        [EnumMember(Value = "MANUAL_CHECK")]
        MANUAL_CHECK,
        
        /// <summary>
        /// Enum FAILED for value: FAILED
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED,
        
        /// <summary>
        /// Enum SUCCESSFUL for value: SUCCESSFUL
        /// </summary>
        [EnumMember(Value = "SUCCESSFUL")]
        SUCCESSFUL
    }

}
