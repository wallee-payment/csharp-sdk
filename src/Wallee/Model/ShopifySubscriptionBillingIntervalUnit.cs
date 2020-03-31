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
    /// Defines ShopifySubscriptionBillingIntervalUnit
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ShopifySubscriptionBillingIntervalUnit
    {
        
        /// <summary>
        /// Enum MINUTES for value: MINUTES
        /// </summary>
        [EnumMember(Value = "MINUTES")]
        MINUTES,
        
        /// <summary>
        /// Enum HOURS for value: HOURS
        /// </summary>
        [EnumMember(Value = "HOURS")]
        HOURS,
        
        /// <summary>
        /// Enum DAYS for value: DAYS
        /// </summary>
        [EnumMember(Value = "DAYS")]
        DAYS,
        
        /// <summary>
        /// Enum WEEKS for value: WEEKS
        /// </summary>
        [EnumMember(Value = "WEEKS")]
        WEEKS,
        
        /// <summary>
        /// Enum MONTHS for value: MONTHS
        /// </summary>
        [EnumMember(Value = "MONTHS")]
        MONTHS,
        
        /// <summary>
        /// Enum YEARS for value: YEARS
        /// </summary>
        [EnumMember(Value = "YEARS")]
        YEARS
    }

}
