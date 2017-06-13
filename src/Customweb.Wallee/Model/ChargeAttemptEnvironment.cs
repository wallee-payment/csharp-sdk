
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
    /// ChargeAttemptEnvironment model.
    /// </summary>
    /// <value>ChargeAttemptEnvironment model.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ChargeAttemptEnvironment
    {
        
        /// <summary>
        /// Enum PRODUCTION for "PRODUCTION"
        /// </summary>
        [EnumMember(Value = "PRODUCTION")]
        PRODUCTION,
        
        /// <summary>
        /// Enum TEST for "TEST"
        /// </summary>
        [EnumMember(Value = "TEST")]
        TEST
    }

}
