using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Payment Link Protection Mode
    /// </summary>
    /// <value>Payment Link Protection Mode</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentLinkProtectionMode
    {
        
        /// <summary>
        /// Enum NO_PROTECTION for "NO_PROTECTION"
        /// </summary>
        [EnumMember(Value = "NO_PROTECTION")]
        NO_PROTECTION,
        
        /// <summary>
        /// Enum ACCESS_KEY for "ACCESS_KEY"
        /// </summary>
        [EnumMember(Value = "ACCESS_KEY")]
        ACCESS_KEY
    }

}
