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
    /// Defines SubscriptionProductVersionState
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum SubscriptionProductVersionState
    {
        
        /// <summary>
        /// Enum PENDING for value: PENDING
        /// </summary>
        [EnumMember(Value = "PENDING")]
        PENDING,
        
        /// <summary>
        /// Enum ACTIVE for value: ACTIVE
        /// </summary>
        [EnumMember(Value = "ACTIVE")]
        ACTIVE,
        
        /// <summary>
        /// Enum OBSOLETE for value: OBSOLETE
        /// </summary>
        [EnumMember(Value = "OBSOLETE")]
        OBSOLETE,
        
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
