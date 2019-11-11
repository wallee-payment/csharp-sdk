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
    /// Defines OneClickPaymentMode
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum OneClickPaymentMode
    {
        
        /// <summary>
        /// Enum DISABLED for value: DISABLED
        /// </summary>
        [EnumMember(Value = "DISABLED")]
        DISABLED,
        
        /// <summary>
        /// Enum ALLOW for value: ALLOW
        /// </summary>
        [EnumMember(Value = "ALLOW")]
        ALLOW,
        
        /// <summary>
        /// Enum FORCE for value: FORCE
        /// </summary>
        [EnumMember(Value = "FORCE")]
        FORCE
    }

}
