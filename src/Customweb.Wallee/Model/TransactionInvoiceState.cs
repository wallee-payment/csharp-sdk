
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

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// TransactionInvoiceState model.
    /// </summary>
    /// <value>TransactionInvoiceState model.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransactionInvoiceState
    {
        
        /// <summary>
        /// Enum CREATE for "CREATE"
        /// </summary>
        [EnumMember(Value = "CREATE")]
        CREATE,
        
        /// <summary>
        /// Enum OPEN for "OPEN"
        /// </summary>
        [EnumMember(Value = "OPEN")]
        OPEN,
        
        /// <summary>
        /// Enum OVERDUE for "OVERDUE"
        /// </summary>
        [EnumMember(Value = "OVERDUE")]
        OVERDUE,
        
        /// <summary>
        /// Enum CANCELED for "CANCELED"
        /// </summary>
        [EnumMember(Value = "CANCELED")]
        CANCELED,
        
        /// <summary>
        /// Enum PAID for "PAID"
        /// </summary>
        [EnumMember(Value = "PAID")]
        PAID,
        
        /// <summary>
        /// Enum DERECOGNIZED for "DERECOGNIZED"
        /// </summary>
        [EnumMember(Value = "DERECOGNIZED")]
        DERECOGNIZED,
        
        /// <summary>
        /// Enum NOT_APPLICABLE for "NOT_APPLICABLE"
        /// </summary>
        [EnumMember(Value = "NOT_APPLICABLE")]
        NOT_APPLICABLE
    }

}
