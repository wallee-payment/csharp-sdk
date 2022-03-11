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
    /// Defines InvoiceReconciliationRecordRejectionStatus
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum InvoiceReconciliationRecordRejectionStatus
    {
        
        /// <summary>
        /// Enum NONE for value: NONE
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE,
        
        /// <summary>
        /// Enum REJECTED for value: REJECTED
        /// </summary>
        [EnumMember(Value = "REJECTED")]
        REJECTED,
        
        /// <summary>
        /// Enum BULK_REJECTED for value: BULK_REJECTED
        /// </summary>
        [EnumMember(Value = "BULK_REJECTED")]
        BULK_REJECTED
    }

}
