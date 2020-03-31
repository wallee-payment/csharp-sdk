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
    /// Defines ShopifySubscriptionProductState
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ShopifySubscriptionProductState
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
        /// Enum OBSOLETE for value: OBSOLETE
        /// </summary>
        [EnumMember(Value = "OBSOLETE")]
        OBSOLETE,
        
        /// <summary>
        /// Enum DELETING for value: DELETING
        /// </summary>
        [EnumMember(Value = "DELETING")]
        DELETING,
        
        /// <summary>
        /// Enum DELETED for value: DELETED
        /// </summary>
        [EnumMember(Value = "DELETED")]
        DELETED
    }

}
