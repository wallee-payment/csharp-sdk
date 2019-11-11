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
    /// Defines SubscriptionLedgerEntryState
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum SubscriptionLedgerEntryState
    {
        
        /// <summary>
        /// Enum OPEN for value: OPEN
        /// </summary>
        [EnumMember(Value = "OPEN")]
        OPEN,
        
        /// <summary>
        /// Enum SCHEDULED for value: SCHEDULED
        /// </summary>
        [EnumMember(Value = "SCHEDULED")]
        SCHEDULED,
        
        /// <summary>
        /// Enum PAID for value: PAID
        /// </summary>
        [EnumMember(Value = "PAID")]
        PAID
    }

}
