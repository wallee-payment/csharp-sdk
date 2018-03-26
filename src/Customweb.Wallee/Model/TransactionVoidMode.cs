using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Transaction Void Mode
    /// </summary>
    /// <value>Transaction Void Mode</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransactionVoidMode
    {
        
        /// <summary>
        /// Enum ONLINE for "ONLINE"
        /// </summary>
        [EnumMember(Value = "ONLINE")]
        ONLINE,
        
        /// <summary>
        /// Enum OFFLINE for "OFFLINE"
        /// </summary>
        [EnumMember(Value = "OFFLINE")]
        OFFLINE
    }

}
