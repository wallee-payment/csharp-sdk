using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Subscription Suspension Action
    /// </summary>
    /// <value>Subscription Suspension Action</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionSuspensionAction
    {
        
        /// <summary>
        /// Enum TERMINATE for "TERMINATE"
        /// </summary>
        [EnumMember(Value = "TERMINATE")]
        TERMINATE,
        
        /// <summary>
        /// Enum REACTIVATE for "REACTIVATE"
        /// </summary>
        [EnumMember(Value = "REACTIVATE")]
        REACTIVATE
    }

}
