
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
    /// LabelDescriptorCategory model.
    /// </summary>
    /// <value>LabelDescriptorCategory model.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LabelDescriptorCategory
    {
        
        /// <summary>
        /// Enum HUMAN for "HUMAN"
        /// </summary>
        [EnumMember(Value = "HUMAN")]
        HUMAN,
        
        /// <summary>
        /// Enum APPLICATION for "APPLICATION"
        /// </summary>
        [EnumMember(Value = "APPLICATION")]
        APPLICATION
    }

}
