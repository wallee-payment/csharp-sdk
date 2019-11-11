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
    /// Defines CustomersPresence
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum CustomersPresence
    {
        
        /// <summary>
        /// Enum NOT_PRESENT for value: NOT_PRESENT
        /// </summary>
        [EnumMember(Value = "NOT_PRESENT")]
        NOT_PRESENT,
        
        /// <summary>
        /// Enum VIRTUAL_PRESENT for value: VIRTUAL_PRESENT
        /// </summary>
        [EnumMember(Value = "VIRTUAL_PRESENT")]
        VIRTUAL_PRESENT,
        
        /// <summary>
        /// Enum PHYSICAL_PRESENT for value: PHYSICAL_PRESENT
        /// </summary>
        [EnumMember(Value = "PHYSICAL_PRESENT")]
        PHYSICAL_PRESENT
    }

}
