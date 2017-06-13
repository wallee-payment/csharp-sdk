
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
    /// TokenVersionState model.
    /// </summary>
    /// <value>TokenVersionState model.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TokenVersionState
    {
        
        /// <summary>
        /// Enum UNINITIALIZED for "UNINITIALIZED"
        /// </summary>
        [EnumMember(Value = "UNINITIALIZED")]
        UNINITIALIZED,
        
        /// <summary>
        /// Enum ACTIVE for "ACTIVE"
        /// </summary>
        [EnumMember(Value = "ACTIVE")]
        ACTIVE,
        
        /// <summary>
        /// Enum OBSOLETE for "OBSOLETE"
        /// </summary>
        [EnumMember(Value = "OBSOLETE")]
        OBSOLETE
    }

}
