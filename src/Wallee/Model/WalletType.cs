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
    /// Defines WalletType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum WalletType
    {
        
        /// <summary>
        /// Enum APPLE_PAY for value: APPLE_PAY
        /// </summary>
        [EnumMember(Value = "APPLE_PAY")]
        APPLE_PAY,
        
        /// <summary>
        /// Enum CLICK_TO_PAY for value: CLICK_TO_PAY
        /// </summary>
        [EnumMember(Value = "CLICK_TO_PAY")]
        CLICK_TO_PAY,
        
        /// <summary>
        /// Enum NONE for value: NONE
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE
    }

}
