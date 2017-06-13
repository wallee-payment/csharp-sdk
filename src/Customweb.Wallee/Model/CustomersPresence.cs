
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
    /// CustomersPresence model.
    /// </summary>
    /// <value>CustomersPresence model.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CustomersPresence
    {
        
        /// <summary>
        /// Enum NOT_PRESENT for "NOT_PRESENT"
        /// </summary>
        [EnumMember(Value = "NOT_PRESENT")]
        NOT_PRESENT,
        
        /// <summary>
        /// Enum VIRTUAL_PRESENT for "VIRTUAL_PRESENT"
        /// </summary>
        [EnumMember(Value = "VIRTUAL_PRESENT")]
        VIRTUAL_PRESENT,
        
        /// <summary>
        /// Enum PHYSICAL_PRESENT for "PHYSICAL_PRESENT"
        /// </summary>
        [EnumMember(Value = "PHYSICAL_PRESENT")]
        PHYSICAL_PRESENT
    }

}
