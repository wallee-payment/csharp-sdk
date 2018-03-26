using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Subscription Suspension State
    /// </summary>
    /// <value>Subscription Suspension State</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionSuspensionState
    {
        
        /// <summary>
        /// Enum RUNNING for "RUNNING"
        /// </summary>
        [EnumMember(Value = "RUNNING")]
        RUNNING,
        
        /// <summary>
        /// Enum ENDED for "ENDED"
        /// </summary>
        [EnumMember(Value = "ENDED")]
        ENDED
    }

}
