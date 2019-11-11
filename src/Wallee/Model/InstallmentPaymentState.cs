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
    /// Defines InstallmentPaymentState
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum InstallmentPaymentState
    {
        
        /// <summary>
        /// Enum CREATE for value: CREATE
        /// </summary>
        [EnumMember(Value = "CREATE")]
        CREATE,
        
        /// <summary>
        /// Enum CONFIRMED for value: CONFIRMED
        /// </summary>
        [EnumMember(Value = "CONFIRMED")]
        CONFIRMED,
        
        /// <summary>
        /// Enum AUTHORIZED for value: AUTHORIZED
        /// </summary>
        [EnumMember(Value = "AUTHORIZED")]
        AUTHORIZED,
        
        /// <summary>
        /// Enum REJECTED for value: REJECTED
        /// </summary>
        [EnumMember(Value = "REJECTED")]
        REJECTED,
        
        /// <summary>
        /// Enum COMPLETED for value: COMPLETED
        /// </summary>
        [EnumMember(Value = "COMPLETED")]
        COMPLETED,
        
        /// <summary>
        /// Enum RUNNING for value: RUNNING
        /// </summary>
        [EnumMember(Value = "RUNNING")]
        RUNNING,
        
        /// <summary>
        /// Enum DONE for value: DONE
        /// </summary>
        [EnumMember(Value = "DONE")]
        DONE,
        
        /// <summary>
        /// Enum DEFAULTED for value: DEFAULTED
        /// </summary>
        [EnumMember(Value = "DEFAULTED")]
        DEFAULTED
    }

}
