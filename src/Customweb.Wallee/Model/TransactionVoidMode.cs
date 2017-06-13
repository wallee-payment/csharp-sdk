
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
    /// TransactionVoidMode model.
    /// </summary>
    /// <value>TransactionVoidMode model.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransactionVoidMode
    {
        
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
