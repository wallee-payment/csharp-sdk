using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Delivery Indication State
    /// </summary>
    /// <value>Delivery Indication State</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DeliveryIndicationState
    {
        
        /// <summary>
        /// Enum PENDING for "PENDING"
        /// </summary>
        [EnumMember(Value = "PENDING")]
        PENDING,
        
        /// <summary>
        /// Enum NOT_SUITABLE for "NOT_SUITABLE"
        /// </summary>
        [EnumMember(Value = "NOT_SUITABLE")]
        NOT_SUITABLE,
        
        /// <summary>
        /// Enum MANUAL_CHECK_REQUIRED for "MANUAL_CHECK_REQUIRED"
        /// </summary>
        [EnumMember(Value = "MANUAL_CHECK_REQUIRED")]
        MANUAL_CHECK_REQUIRED,
        
        /// <summary>
        /// Enum SUITABLE for "SUITABLE"
        /// </summary>
        [EnumMember(Value = "SUITABLE")]
        SUITABLE
    }

}
