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
    /// Defines TokenVersionState
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TokenVersionState
    {
        
        /// <summary>
        /// Enum UNINITIALIZED for value: UNINITIALIZED
        /// </summary>
        [EnumMember(Value = "UNINITIALIZED")]
        UNINITIALIZED,
        
        /// <summary>
        /// Enum ACTIVE for value: ACTIVE
        /// </summary>
        [EnumMember(Value = "ACTIVE")]
        ACTIVE,
        
        /// <summary>
        /// Enum OBSOLETE for value: OBSOLETE
        /// </summary>
        [EnumMember(Value = "OBSOLETE")]
        OBSOLETE
    }

}
