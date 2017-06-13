
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
    /// ManualTaskState model.
    /// </summary>
    /// <value>ManualTaskState model.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ManualTaskState
    {
        
        /// <summary>
        /// Enum OPEN for "OPEN"
        /// </summary>
        [EnumMember(Value = "OPEN")]
        OPEN,
        
        /// <summary>
        /// Enum DONE for "DONE"
        /// </summary>
        [EnumMember(Value = "DONE")]
        DONE,
        
        /// <summary>
        /// Enum EXPIRED for "EXPIRED"
        /// </summary>
        [EnumMember(Value = "EXPIRED")]
        EXPIRED
    }

}
