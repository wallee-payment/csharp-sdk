using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Subscription Charge Processing Type
    /// </summary>
    /// <value>Subscription Charge Processing Type</value>
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
