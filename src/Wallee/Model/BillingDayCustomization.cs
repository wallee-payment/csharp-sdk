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
    /// Defines BillingDayCustomization
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum BillingDayCustomization
    {
        
        /// <summary>
        /// Enum DEFAULT for value: DEFAULT
        /// </summary>
        [EnumMember(Value = "DEFAULT")]
        DEFAULT,
        
        /// <summary>
        /// Enum SPECIFIC for value: SPECIFIC
        /// </summary>
        [EnumMember(Value = "SPECIFIC")]
        SPECIFIC
    }

}
