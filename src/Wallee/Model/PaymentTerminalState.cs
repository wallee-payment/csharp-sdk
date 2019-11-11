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
using SwaggerDateConverter = Wallee.Client.SwaggerDateConverter;

namespace Wallee.Model
{
    /// <summary>
    /// Defines PaymentTerminalState
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PaymentTerminalState
    {
        
        /// <summary>
        /// Enum PREPARING for value: PREPARING
        /// </summary>
        [EnumMember(Value = "PREPARING")]
        PREPARING,
        
        /// <summary>
        /// Enum ACTIVE for value: ACTIVE
        /// </summary>
        [EnumMember(Value = "ACTIVE")]
        ACTIVE,
        
        /// <summary>
        /// Enum INACTIVE for value: INACTIVE
        /// </summary>
        [EnumMember(Value = "INACTIVE")]
        INACTIVE,
        
        /// <summary>
        /// Enum DECOMMISSIONING for value: DECOMMISSIONING
        /// </summary>
        [EnumMember(Value = "DECOMMISSIONING")]
        DECOMMISSIONING,
        
        /// <summary>
        /// Enum DECOMMISSIONED for value: DECOMMISSIONED
        /// </summary>
        [EnumMember(Value = "DECOMMISSIONED")]
        DECOMMISSIONED
    }

}
