
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
    /// SubscriptionChargeProcessingType model.
    /// </summary>
    /// <value>SubscriptionChargeProcessingType model.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionChargeProcessingType
    {
        
        /// <summary>
        /// Enum SYNCHRONOUS for "SYNCHRONOUS"
        /// </summary>
        [EnumMember(Value = "SYNCHRONOUS")]
        SYNCHRONOUS,
        
        /// <summary>
        /// Enum CHARGE_FLOW for "CHARGE_FLOW"
        /// </summary>
        [EnumMember(Value = "CHARGE_FLOW")]
        CHARGE_FLOW
    }

}
