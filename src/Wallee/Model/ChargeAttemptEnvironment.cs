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
    /// Defines ChargeAttemptEnvironment
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ChargeAttemptEnvironment
    {
        
        /// <summary>
        /// Enum PRODUCTION for value: PRODUCTION
        /// </summary>
        [EnumMember(Value = "PRODUCTION")]
        PRODUCTION,
        
        /// <summary>
        /// Enum TEST for value: TEST
        /// </summary>
        [EnumMember(Value = "TEST")]
        TEST
    }

}
