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
    /// Defines ShopifyTransactionState
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ShopifyTransactionState
    {
        
        /// <summary>
        /// Enum PENDING for value: PENDING
        /// </summary>
        [EnumMember(Value = "PENDING")]
        PENDING,
        
        /// <summary>
        /// Enum AUTHORIZED for value: AUTHORIZED
        /// </summary>
        [EnumMember(Value = "AUTHORIZED")]
        AUTHORIZED,
        
        /// <summary>
        /// Enum COMPLETED for value: COMPLETED
        /// </summary>
        [EnumMember(Value = "COMPLETED")]
        COMPLETED,
        
        /// <summary>
        /// Enum FAILED for value: FAILED
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED,
        
        /// <summary>
        /// Enum CONFLICTING for value: CONFLICTING
        /// </summary>
        [EnumMember(Value = "CONFLICTING")]
        CONFLICTING
    }

}
