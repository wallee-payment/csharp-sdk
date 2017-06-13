
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
    /// ChargeType model.
    /// </summary>
    /// <value>ChargeType model.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ChargeType
    {
        
        /// <summary>
        /// Enum ASYNCHRONOUS for "ASYNCHRONOUS"
        /// </summary>
        [EnumMember(Value = "ASYNCHRONOUS")]
        ASYNCHRONOUS,
        
        /// <summary>
        /// Enum SYNCHRONOUS for "SYNCHRONOUS"
        /// </summary>
        [EnumMember(Value = "SYNCHRONOUS")]
        SYNCHRONOUS,
        
        /// <summary>
        /// Enum TOKEN for "TOKEN"
        /// </summary>
        [EnumMember(Value = "TOKEN")]
        TOKEN
    }

}
