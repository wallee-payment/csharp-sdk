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
    /// Defines Gender
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum Gender
    {
        
        /// <summary>
        /// Enum MALE for value: MALE
        /// </summary>
        [EnumMember(Value = "MALE")]
        MALE,
        
        /// <summary>
        /// Enum FEMALE for value: FEMALE
        /// </summary>
        [EnumMember(Value = "FEMALE")]
        FEMALE
    }

}
