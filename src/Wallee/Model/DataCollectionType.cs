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
    /// Defines DataCollectionType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum DataCollectionType
    {
        
        /// <summary>
        /// Enum ONSITE for value: ONSITE
        /// </summary>
        [EnumMember(Value = "ONSITE")]
        ONSITE,
        
        /// <summary>
        /// Enum OFFSITE for value: OFFSITE
        /// </summary>
        [EnumMember(Value = "OFFSITE")]
        OFFSITE
    }

}
