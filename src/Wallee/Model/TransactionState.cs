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
    /// Defines TransactionState
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TransactionState
    {
        
        /// <summary>
        /// Enum CREATE for value: CREATE
        /// </summary>
        [EnumMember(Value = "CREATE")]
        CREATE,
        
        /// <summary>
        /// Enum PENDING for value: PENDING
        /// </summary>
        [EnumMember(Value = "PENDING")]
        PENDING,
        
        /// <summary>
        /// Enum CONFIRMED for value: CONFIRMED
        /// </summary>
        [EnumMember(Value = "CONFIRMED")]
        CONFIRMED,
        
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
        /// Enum AUTHORIZED for value: AUTHORIZED
        /// </summary>
        [EnumMember(Value = "AUTHORIZED")]
        AUTHORIZED,
        
        /// <summary>
        /// Enum VOIDED for value: VOIDED
        /// </summary>
        [EnumMember(Value = "VOIDED")]
        VOIDED,
        
        /// <summary>
        /// Enum COMPLETED for value: COMPLETED
        /// </summary>
        [EnumMember(Value = "COMPLETED")]
        COMPLETED,
        
        /// <summary>
        /// Enum FULFILL for value: FULFILL
        /// </summary>
        [EnumMember(Value = "FULFILL")]
        FULFILL,
        
        /// <summary>
        /// Enum DECLINE for value: DECLINE
        /// </summary>
        [EnumMember(Value = "DECLINE")]
        DECLINE
    }

}
