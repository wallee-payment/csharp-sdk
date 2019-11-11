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
    /// Defines SubscriptionChargeType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum SubscriptionChargeType
    {
        
        /// <summary>
        /// Enum MANUAL for value: MANUAL
        /// </summary>
        [EnumMember(Value = "MANUAL")]
        MANUAL,
        
        /// <summary>
        /// Enum AUTOMATIC for value: AUTOMATIC
        /// </summary>
        [EnumMember(Value = "AUTOMATIC")]
        AUTOMATIC
    }

}
