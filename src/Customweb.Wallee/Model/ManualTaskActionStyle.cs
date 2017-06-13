
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
    /// ManualTaskActionStyle model.
    /// </summary>
    /// <value>ManualTaskActionStyle model.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ManualTaskActionStyle
    {
        
        /// <summary>
        /// Enum DEFAULT for "DEFAULT"
        /// </summary>
        [EnumMember(Value = "DEFAULT")]
        DEFAULT,
        
        /// <summary>
        /// Enum PRIMARY for "PRIMARY"
        /// </summary>
        [EnumMember(Value = "PRIMARY")]
        PRIMARY,
        
        /// <summary>
        /// Enum DANGER for "DANGER"
        /// </summary>
        [EnumMember(Value = "DANGER")]
        DANGER
    }

}
