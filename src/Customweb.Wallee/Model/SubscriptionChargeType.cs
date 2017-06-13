
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
    /// SubscriptionChargeType model.
    /// </summary>
    /// <value>SubscriptionChargeType model.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionChargeType
    {
        
        /// <summary>
        /// Enum MANUAL for "MANUAL"
        /// </summary>
        [EnumMember(Value = "MANUAL")]
        MANUAL,
        
        /// <summary>
        /// Enum AUTOMATIC for "AUTOMATIC"
        /// </summary>
        [EnumMember(Value = "AUTOMATIC")]
        AUTOMATIC
    }

}
