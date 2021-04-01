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
    /// Defines RecurringIndicator
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum RecurringIndicator
    {
        
        /// <summary>
        /// Enum REGULAR_TRANSACTION for value: REGULAR_TRANSACTION
        /// </summary>
        [EnumMember(Value = "REGULAR_TRANSACTION")]
        REGULAR_TRANSACTION,
        
        /// <summary>
        /// Enum INITIAL_RECURRING_TRANSACTION for value: INITIAL_RECURRING_TRANSACTION
        /// </summary>
        [EnumMember(Value = "INITIAL_RECURRING_TRANSACTION")]
        INITIAL_RECURRING_TRANSACTION,
        
        /// <summary>
        /// Enum MERCHANT_INITIATED_RECURRING_TRANSACTION for value: MERCHANT_INITIATED_RECURRING_TRANSACTION
        /// </summary>
        [EnumMember(Value = "MERCHANT_INITIATED_RECURRING_TRANSACTION")]
        MERCHANT_INITIATED_RECURRING_TRANSACTION,
        
        /// <summary>
        /// Enum CUSTOMER_INITIATED_RECURRING_TRANSACTION for value: CUSTOMER_INITIATED_RECURRING_TRANSACTION
        /// </summary>
        [EnumMember(Value = "CUSTOMER_INITIATED_RECURRING_TRANSACTION")]
        CUSTOMER_INITIATED_RECURRING_TRANSACTION
    }

}
