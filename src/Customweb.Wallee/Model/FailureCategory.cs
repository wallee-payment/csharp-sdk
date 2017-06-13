
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
    /// FailureCategory model.
    /// </summary>
    /// <value>FailureCategory model.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FailureCategory
    {
        
        /// <summary>
        /// Enum TEMPORARY_ISSUE for "TEMPORARY_ISSUE"
        /// </summary>
        [EnumMember(Value = "TEMPORARY_ISSUE")]
        TEMPORARY_ISSUE,
        
        /// <summary>
        /// Enum INTERNAL for "INTERNAL"
        /// </summary>
        [EnumMember(Value = "INTERNAL")]
        INTERNAL,
        
        /// <summary>
        /// Enum END_USER for "END_USER"
        /// </summary>
        [EnumMember(Value = "END_USER")]
        END_USER,
        
        /// <summary>
        /// Enum CONFIGURATION for "CONFIGURATION"
        /// </summary>
        [EnumMember(Value = "CONFIGURATION")]
        CONFIGURATION,
        
        /// <summary>
        /// Enum DEVELOPER for "DEVELOPER"
        /// </summary>
        [EnumMember(Value = "DEVELOPER")]
        DEVELOPER
    }

}
