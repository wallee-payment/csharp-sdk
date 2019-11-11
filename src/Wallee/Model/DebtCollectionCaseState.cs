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
    /// Defines DebtCollectionCaseState
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum DebtCollectionCaseState
    {
        
        /// <summary>
        /// Enum CREATE for value: CREATE
        /// </summary>
        [EnumMember(Value = "CREATE")]
        CREATE,
        
        /// <summary>
        /// Enum PREPARING for value: PREPARING
        /// </summary>
        [EnumMember(Value = "PREPARING")]
        PREPARING,
        
        /// <summary>
        /// Enum REVIEWING for value: REVIEWING
        /// </summary>
        [EnumMember(Value = "REVIEWING")]
        REVIEWING,
        
        /// <summary>
        /// Enum PENDING for value: PENDING
        /// </summary>
        [EnumMember(Value = "PENDING")]
        PENDING,
        
        /// <summary>
        /// Enum PROCESSING for value: PROCESSING
        /// </summary>
        [EnumMember(Value = "PROCESSING")]
        PROCESSING,
        
        /// <summary>
        /// Enum CLOSED for value: CLOSED
        /// </summary>
        [EnumMember(Value = "CLOSED")]
        CLOSED,
        
        /// <summary>
        /// Enum FAILED for value: FAILED
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED
    }

}
