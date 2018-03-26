using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Subscription Suspension Reason
    /// </summary>
    /// <value>Subscription Suspension Reason</value>
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
