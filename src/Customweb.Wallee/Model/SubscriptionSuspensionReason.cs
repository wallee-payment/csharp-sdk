
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
    /// SubscriptionSuspensionReason model.
    /// </summary>
    /// <value>SubscriptionSuspensionReason model.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionSuspensionReason
    {
        
        /// <summary>
        /// Enum FAILED_CHARGE for "FAILED_CHARGE"
        /// </summary>
        [EnumMember(Value = "FAILED_CHARGE")]
        FAILED_CHARGE,
        
        /// <summary>
        /// Enum SUBSCRIBER_INITIATED_REFUND for "SUBSCRIBER_INITIATED_REFUND"
        /// </summary>
        [EnumMember(Value = "SUBSCRIBER_INITIATED_REFUND")]
        SUBSCRIBER_INITIATED_REFUND,
        
        /// <summary>
        /// Enum MANUAL for "MANUAL"
        /// </summary>
        [EnumMember(Value = "MANUAL")]
        MANUAL
    }

}
