
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
    /// OneClickPaymentMode model.
    /// </summary>
    /// <value>OneClickPaymentMode model.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OneClickPaymentMode
    {
        
        /// <summary>
        /// Enum DISABLED for "DISABLED"
        /// </summary>
        [EnumMember(Value = "DISABLED")]
        DISABLED,
        
        /// <summary>
        /// Enum ALLOW for "ALLOW"
        /// </summary>
        [EnumMember(Value = "ALLOW")]
        ALLOW,
        
        /// <summary>
        /// Enum FORCE for "FORCE"
        /// </summary>
        [EnumMember(Value = "FORCE")]
        FORCE
    }

}
