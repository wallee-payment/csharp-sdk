
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
    /// SubscriptionPeriodBillState model.
    /// </summary>
    /// <value>SubscriptionPeriodBillState model.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionPeriodBillState
    {
        
        /// <summary>
        /// Enum PENDING for "PENDING"
        /// </summary>
        [EnumMember(Value = "PENDING")]
        PENDING,
        
        /// <summary>
        /// Enum BILLED for "BILLED"
        /// </summary>
        [EnumMember(Value = "BILLED")]
        BILLED
    }

}
