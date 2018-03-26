using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Refund Type
    /// </summary>
    /// <value>Refund Type</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RefundType
    {
        
        /// <summary>
        /// Enum CUSTOMER_INITIATED_AUTOMATIC for "CUSTOMER_INITIATED_AUTOMATIC"
        /// </summary>
        [EnumMember(Value = "CUSTOMER_INITIATED_AUTOMATIC")]
        CUSTOMER_INITIATED_AUTOMATIC,
        
        /// <summary>
        /// Enum CUSTOMER_INITIATED_MANUAL for "CUSTOMER_INITIATED_MANUAL"
        /// </summary>
        [EnumMember(Value = "CUSTOMER_INITIATED_MANUAL")]
        CUSTOMER_INITIATED_MANUAL,
        
        /// <summary>
        /// Enum MERCHANT_INITIATED_ONLINE for "MERCHANT_INITIATED_ONLINE"
        /// </summary>
        [EnumMember(Value = "MERCHANT_INITIATED_ONLINE")]
        MERCHANT_INITIATED_ONLINE,
        
        /// <summary>
        /// Enum MERCHANT_INITIATED_OFFLINE for "MERCHANT_INITIATED_OFFLINE"
        /// </summary>
        [EnumMember(Value = "MERCHANT_INITIATED_OFFLINE")]
        MERCHANT_INITIATED_OFFLINE
    }

}
