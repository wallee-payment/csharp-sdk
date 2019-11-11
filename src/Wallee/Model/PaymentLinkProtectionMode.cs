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
    /// Defines PaymentLinkProtectionMode
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PaymentLinkProtectionMode
    {
        
        /// <summary>
        /// Enum NO_PROTECTION for value: NO_PROTECTION
        /// </summary>
        [EnumMember(Value = "NO_PROTECTION")]
        NO_PROTECTION,
        
        /// <summary>
        /// Enum ACCESS_KEY for value: ACCESS_KEY
        /// </summary>
        [EnumMember(Value = "ACCESS_KEY")]
        ACCESS_KEY
    }

}
