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
    /// Defines ShopifySubscriptionVersionState
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ShopifySubscriptionVersionState
    {
        
        /// <summary>
        /// Enum CREATE for value: CREATE
        /// </summary>
        [EnumMember(Value = "CREATE")]
        CREATE,
        
        /// <summary>
        /// Enum ACTIVE for value: ACTIVE
        /// </summary>
        [EnumMember(Value = "ACTIVE")]
        ACTIVE,
        
        /// <summary>
        /// Enum DISCHARGED for value: DISCHARGED
        /// </summary>
        [EnumMember(Value = "DISCHARGED")]
        DISCHARGED
    }

}
