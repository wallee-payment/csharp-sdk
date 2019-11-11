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
    /// Defines LabelDescriptorCategory
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum LabelDescriptorCategory
    {
        
        /// <summary>
        /// Enum HUMAN for value: HUMAN
        /// </summary>
        [EnumMember(Value = "HUMAN")]
        HUMAN,
        
        /// <summary>
        /// Enum APPLICATION for value: APPLICATION
        /// </summary>
        [EnumMember(Value = "APPLICATION")]
        APPLICATION
    }

}
