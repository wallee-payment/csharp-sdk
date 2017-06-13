
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
    /// DataCollectionType model.
    /// </summary>
    /// <value>DataCollectionType model.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DataCollectionType
    {
        
        /// <summary>
        /// Enum ONSITE for "ONSITE"
        /// </summary>
        [EnumMember(Value = "ONSITE")]
        ONSITE,
        
        /// <summary>
        /// Enum OFFSITE for "OFFSITE"
        /// </summary>
        [EnumMember(Value = "OFFSITE")]
        OFFSITE
    }

}
