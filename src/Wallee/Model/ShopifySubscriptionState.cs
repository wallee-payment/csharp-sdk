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
    /// Defines ShopifySubscriptionState
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ShopifySubscriptionState
    {
        
        /// <summary>
        /// Enum INITIATING for value: INITIATING
        /// </summary>
        [EnumMember(Value = "INITIATING")]
        INITIATING,
        
        /// <summary>
        /// Enum FAILED for value: FAILED
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED,
        
        /// <summary>
        /// Enum ACTIVE for value: ACTIVE
        /// </summary>
        [EnumMember(Value = "ACTIVE")]
        ACTIVE,
        
        /// <summary>
        /// Enum SUSPENDED for value: SUSPENDED
        /// </summary>
        [EnumMember(Value = "SUSPENDED")]
        SUSPENDED,
        
        /// <summary>
        /// Enum TERMINATING for value: TERMINATING
        /// </summary>
        [EnumMember(Value = "TERMINATING")]
        TERMINATING,
        
        /// <summary>
        /// Enum TERMINATED for value: TERMINATED
        /// </summary>
        [EnumMember(Value = "TERMINATED")]
        TERMINATED
    }

}
