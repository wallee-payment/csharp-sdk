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
    /// Defines PaymentTerminalDeviceState
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PaymentTerminalDeviceState
    {
        
        /// <summary>
        /// Enum CREATE for value: CREATE
        /// </summary>
        [EnumMember(Value = "CREATE")]
        CREATE,
        
        /// <summary>
        /// Enum PREPARING for value: PREPARING
        /// </summary>
        [EnumMember(Value = "PREPARING")]
        PREPARING,
        
        /// <summary>
        /// Enum REGISTERED for value: REGISTERED
        /// </summary>
        [EnumMember(Value = "REGISTERED")]
        REGISTERED,
        
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
