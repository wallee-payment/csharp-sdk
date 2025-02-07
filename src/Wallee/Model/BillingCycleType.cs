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
    /// Defines BillingCycleType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum BillingCycleType
    {
        
        /// <summary>
        /// Enum DAILY for value: DAILY
        /// </summary>
        [EnumMember(Value = "DAILY")]
        DAILY,
        
        /// <summary>
        /// Enum WEEKLY for value: WEEKLY
        /// </summary>
        [EnumMember(Value = "WEEKLY")]
        WEEKLY,
        
        /// <summary>
        /// Enum MONTHLY for value: MONTHLY
        /// </summary>
        [EnumMember(Value = "MONTHLY")]
        MONTHLY,
        
        /// <summary>
        /// Enum YEARLY for value: YEARLY
        /// </summary>
        [EnumMember(Value = "YEARLY")]
        YEARLY
    }

}
