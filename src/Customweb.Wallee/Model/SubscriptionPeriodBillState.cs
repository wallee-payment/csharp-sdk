using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Subscription Period Bill State
    /// </summary>
    /// <value>Subscription Period Bill State</value>
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
