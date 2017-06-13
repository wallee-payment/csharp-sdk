
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
    /// Gender model.
    /// </summary>
    /// <value>Gender model.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Gender
    {
        
        /// <summary>
        /// Enum MALE for "MALE"
        /// </summary>
        [EnumMember(Value = "MALE")]
        MALE,
        
        /// <summary>
        /// Enum FEMALE for "FEMALE"
        /// </summary>
        [EnumMember(Value = "FEMALE")]
        FEMALE
    }

}
