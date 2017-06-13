
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
    /// The 'order by' type specifies how the result is sorted.
    /// </summary>
    /// <value>The 'order by' type specifies how the result is sorted.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EntityQueryOrderByType
    {
        
        /// <summary>
        /// Enum DESC for "DESC"
        /// </summary>
        [EnumMember(Value = "DESC")]
        DESC,
        
        /// <summary>
        /// Enum ASC for "ASC"
        /// </summary>
        [EnumMember(Value = "ASC")]
        ASC
    }

}
