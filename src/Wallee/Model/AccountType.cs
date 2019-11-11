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
    /// Defines AccountType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum AccountType
    {
        
        /// <summary>
        /// Enum MASTER for value: MASTER
        /// </summary>
        [EnumMember(Value = "MASTER")]
        MASTER,
        
        /// <summary>
        /// Enum REGULAR for value: REGULAR
        /// </summary>
        [EnumMember(Value = "REGULAR")]
        REGULAR,
        
        /// <summary>
        /// Enum SUBACCOUNT for value: SUBACCOUNT
        /// </summary>
        [EnumMember(Value = "SUBACCOUNT")]
        SUBACCOUNT
    }

}
