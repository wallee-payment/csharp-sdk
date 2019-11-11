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
    /// Defines TransactionInvoiceState
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TransactionInvoiceState
    {
        
        /// <summary>
        /// Enum CREATE for value: CREATE
        /// </summary>
        [EnumMember(Value = "CREATE")]
        CREATE,
        
        /// <summary>
        /// Enum OPEN for value: OPEN
        /// </summary>
        [EnumMember(Value = "OPEN")]
        OPEN,
        
        /// <summary>
        /// Enum OVERDUE for value: OVERDUE
        /// </summary>
        [EnumMember(Value = "OVERDUE")]
        OVERDUE,
        
        /// <summary>
        /// Enum CANCELED for value: CANCELED
        /// </summary>
        [EnumMember(Value = "CANCELED")]
        CANCELED,
        
        /// <summary>
        /// Enum PAID for value: PAID
        /// </summary>
        [EnumMember(Value = "PAID")]
        PAID,
        
        /// <summary>
        /// Enum DERECOGNIZED for value: DERECOGNIZED
        /// </summary>
        [EnumMember(Value = "DERECOGNIZED")]
        DERECOGNIZED,
        
        /// <summary>
        /// Enum NOT_APPLICABLE for value: NOT_APPLICABLE
        /// </summary>
        [EnumMember(Value = "NOT_APPLICABLE")]
        NOT_APPLICABLE
    }

}
