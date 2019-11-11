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
    /// Defines SubscriptionProductState
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum SubscriptionProductState
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
        /// Enum INACTIVE for value: INACTIVE
        /// </summary>
        [EnumMember(Value = "INACTIVE")]
        INACTIVE,
        
        /// <summary>
        /// Enum RETIRING for value: RETIRING
        /// </summary>
        [EnumMember(Value = "RETIRING")]
        RETIRING,
        
        /// <summary>
        /// Enum RETIRED for value: RETIRED
        /// </summary>
        [EnumMember(Value = "RETIRED")]
        RETIRED
    }

}
