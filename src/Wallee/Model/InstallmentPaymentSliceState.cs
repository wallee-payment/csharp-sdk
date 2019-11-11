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
    /// Defines InstallmentPaymentSliceState
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum InstallmentPaymentSliceState
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
        /// Enum CANCELED for value: CANCELED
        /// </summary>
        [EnumMember(Value = "CANCELED")]
        CANCELED,
        
        /// <summary>
        /// Enum PREPARE_PROCESSING for value: PREPARE_PROCESSING
        /// </summary>
        [EnumMember(Value = "PREPARE_PROCESSING")]
        PREPARE_PROCESSING,
        
        /// <summary>
        /// Enum PROCESSING for value: PROCESSING
        /// </summary>
        [EnumMember(Value = "PROCESSING")]
        PROCESSING,
        
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
