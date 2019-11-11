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
    /// Defines UserType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum UserType
    {
        
        /// <summary>
        /// Enum HUMAN_USER for value: HUMAN_USER
        /// </summary>
        [EnumMember(Value = "HUMAN_USER")]
        HUMAN_USER,
        
        /// <summary>
        /// Enum SINGLE_SIGNON_USER for value: SINGLE_SIGNON_USER
        /// </summary>
        [EnumMember(Value = "SINGLE_SIGNON_USER")]
        SINGLE_SIGNON_USER,
        
        /// <summary>
        /// Enum APPLICATION_USER for value: APPLICATION_USER
        /// </summary>
        [EnumMember(Value = "APPLICATION_USER")]
        APPLICATION_USER,
        
        /// <summary>
        /// Enum ANONYMOUS_USER for value: ANONYMOUS_USER
        /// </summary>
        [EnumMember(Value = "ANONYMOUS_USER")]
        ANONYMOUS_USER,
        
        /// <summary>
        /// Enum SERVER_USER for value: SERVER_USER
        /// </summary>
        [EnumMember(Value = "SERVER_USER")]
        SERVER_USER
    }

}
