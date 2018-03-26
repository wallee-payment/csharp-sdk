using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// One Click Payment Mode
    /// </summary>
    /// <value>One Click Payment Mode</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OneClickPaymentMode
    {
        
        /// <summary>
        /// Enum DISABLED for "DISABLED"
        /// </summary>
        [EnumMember(Value = "DISABLED")]
        DISABLED,
        
        /// <summary>
        /// Enum ALLOW for "ALLOW"
        /// </summary>
        [EnumMember(Value = "ALLOW")]
        ALLOW,
        
        /// <summary>
        /// Enum FORCE for "FORCE"
        /// </summary>
        [EnumMember(Value = "FORCE")]
        FORCE
    }

}
