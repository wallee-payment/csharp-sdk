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
    /// Defines InvoiceReconciliationRecordState
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum InvoiceReconciliationRecordState
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
        /// Enum UNRESOLVED for value: UNRESOLVED
        /// </summary>
        [EnumMember(Value = "UNRESOLVED")]
        UNRESOLVED,
        
        /// <summary>
        /// Enum RESOLVED for value: RESOLVED
        /// </summary>
        [EnumMember(Value = "RESOLVED")]
        RESOLVED,
        
        /// <summary>
        /// Enum DISCARDED for value: DISCARDED
        /// </summary>
        [EnumMember(Value = "DISCARDED")]
        DISCARDED
    }

}
