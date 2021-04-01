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
    /// Defines BankTransactionState
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum BankTransactionState
    {
        
        /// <summary>
        /// Enum UPCOMING for value: UPCOMING
        /// </summary>
        [EnumMember(Value = "UPCOMING")]
        UPCOMING,
        
        /// <summary>
        /// Enum SETTLED for value: SETTLED
        /// </summary>
        [EnumMember(Value = "SETTLED")]
        SETTLED
    }

}
