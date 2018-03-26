using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Subscription Charge Type
    /// </summary>
    /// <value>Subscription Charge Type</value>
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
