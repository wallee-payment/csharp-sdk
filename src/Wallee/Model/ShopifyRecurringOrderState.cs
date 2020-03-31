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
    /// Defines ShopifyRecurringOrderState
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ShopifyRecurringOrderState
    {
        
        /// <summary>
        /// Enum PENDING for value: PENDING
        /// </summary>
        [EnumMember(Value = "PENDING")]
        PENDING,
        
        /// <summary>
        /// Enum ONHOLD for value: ONHOLD
        /// </summary>
        [EnumMember(Value = "ONHOLD")]
        ONHOLD,
        
        /// <summary>
        /// Enum PROCESSING for value: PROCESSING
        /// </summary>
        [EnumMember(Value = "PROCESSING")]
        PROCESSING,
        
        /// <summary>
        /// Enum CANCELED for value: CANCELED
        /// </summary>
        [EnumMember(Value = "CANCELED")]
        CANCELED,
        
        /// <summary>
        /// Enum BILLED for value: BILLED
        /// </summary>
        [EnumMember(Value = "BILLED")]
        BILLED,
        
        /// <summary>
        /// Enum FAILED for value: FAILED
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED
    }

}
