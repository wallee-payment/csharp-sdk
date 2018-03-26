using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Transaction Completion Mode
    /// </summary>
    /// <value>Transaction Completion Mode</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransactionCompletionMode
    {
        
        /// <summary>
        /// Enum DIRECT for "DIRECT"
        /// </summary>
        [EnumMember(Value = "DIRECT")]
        DIRECT,
        
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
