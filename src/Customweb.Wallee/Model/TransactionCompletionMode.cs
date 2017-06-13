
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

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// TransactionCompletionMode model.
    /// </summary>
    /// <value>TransactionCompletionMode model.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransactionCompletionMode
    {
        
        /// <summary>
        /// Enum DIRECT for "DIRECT"
        /// </summary>
        [EnumMember(Value = "DIRECT")]
        DIRECT,
        
        /// <summary>
        /// Enum ONLINE for "ONLINE"
        /// </summary>
        [EnumMember(Value = "ONLINE")]
        ONLINE,
        
        /// <summary>
        /// Enum OFFLINE for "OFFLINE"
        /// </summary>
        [EnumMember(Value = "OFFLINE")]
        OFFLINE
    }

}
