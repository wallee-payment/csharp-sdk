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
    /// Defines TransactionUserInterfaceType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TransactionUserInterfaceType
    {
        
        /// <summary>
        /// Enum IFRAME for value: IFRAME
        /// </summary>
        [EnumMember(Value = "IFRAME")]
        IFRAME,
        
        /// <summary>
        /// Enum LIGHTBOX for value: LIGHTBOX
        /// </summary>
        [EnumMember(Value = "LIGHTBOX")]
        LIGHTBOX,
        
        /// <summary>
        /// Enum PAYMENT_PAGE for value: PAYMENT_PAGE
        /// </summary>
        [EnumMember(Value = "PAYMENT_PAGE")]
        PAYMENT_PAGE,
        
        /// <summary>
        /// Enum MOBILE_SDK for value: MOBILE_SDK
        /// </summary>
        [EnumMember(Value = "MOBILE_SDK")]
        MOBILE_SDK,
        
        /// <summary>
        /// Enum TERMINAL for value: TERMINAL
        /// </summary>
        [EnumMember(Value = "TERMINAL")]
        TERMINAL
    }

}
