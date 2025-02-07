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
    /// Defines PanType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PanType
    {
        
        /// <summary>
        /// Enum PLAIN for value: PLAIN
        /// </summary>
        [EnumMember(Value = "PLAIN")]
        PLAIN,
        
        /// <summary>
        /// Enum SCHEME_TOKEN for value: SCHEME_TOKEN
        /// </summary>
        [EnumMember(Value = "SCHEME_TOKEN")]
        SCHEME_TOKEN,
        
        /// <summary>
        /// Enum SCHEME_TOKEN_CLICK_TO_PAY for value: SCHEME_TOKEN_CLICK_TO_PAY
        /// </summary>
        [EnumMember(Value = "SCHEME_TOKEN_CLICK_TO_PAY")]
        SCHEME_TOKEN_CLICK_TO_PAY,
        
        /// <summary>
        /// Enum DEVICE_TOKEN_APPLE_PAY for value: DEVICE_TOKEN_APPLE_PAY
        /// </summary>
        [EnumMember(Value = "DEVICE_TOKEN_APPLE_PAY")]
        DEVICE_TOKEN_APPLE_PAY,
        
        /// <summary>
        /// Enum DEVICE_TOKEN_GOOGLE_PAY for value: DEVICE_TOKEN_GOOGLE_PAY
        /// </summary>
        [EnumMember(Value = "DEVICE_TOKEN_GOOGLE_PAY")]
        DEVICE_TOKEN_GOOGLE_PAY,
        
        /// <summary>
        /// Enum DEVICE_TOKEN_SAMSUNG_PAY for value: DEVICE_TOKEN_SAMSUNG_PAY
        /// </summary>
        [EnumMember(Value = "DEVICE_TOKEN_SAMSUNG_PAY")]
        DEVICE_TOKEN_SAMSUNG_PAY,
        
        /// <summary>
        /// Enum DEVICE_TOKEN_ANDROID_PAY for value: DEVICE_TOKEN_ANDROID_PAY
        /// </summary>
        [EnumMember(Value = "DEVICE_TOKEN_ANDROID_PAY")]
        DEVICE_TOKEN_ANDROID_PAY
    }

}
