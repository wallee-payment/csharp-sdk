using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Subscription Charge State
    /// </summary>
    /// <value>Subscription Charge State</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionChargeState
    {
        
        /// <summary>
        /// Enum SCHEDULED for "SCHEDULED"
        /// </summary>
        [EnumMember(Value = "SCHEDULED")]
        SCHEDULED,
        
        /// <summary>
        /// Enum DISCARDED for "DISCARDED"
        /// </summary>
        [EnumMember(Value = "DISCARDED")]
        DISCARDED,
        
        /// <summary>
        /// Enum PROCESSING for "PROCESSING"
        /// </summary>
        [EnumMember(Value = "PROCESSING")]
        PROCESSING,
        
        /// <summary>
        /// Enum SUCCESSFUL for "SUCCESSFUL"
        /// </summary>
        [EnumMember(Value = "SUCCESSFUL")]
        SUCCESSFUL,
        
        /// <summary>
        /// Enum FAILED for "FAILED"
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED
    }

}
