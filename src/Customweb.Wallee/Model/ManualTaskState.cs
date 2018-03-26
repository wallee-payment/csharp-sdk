using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Manual Task State
    /// </summary>
    /// <value>Manual Task State</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ManualTaskState
    {
        
        /// <summary>
        /// Enum OPEN for "OPEN"
        /// </summary>
        [EnumMember(Value = "OPEN")]
        OPEN,
        
        /// <summary>
        /// Enum DONE for "DONE"
        /// </summary>
        [EnumMember(Value = "DONE")]
        DONE,
        
        /// <summary>
        /// Enum EXPIRED for "EXPIRED"
        /// </summary>
        [EnumMember(Value = "EXPIRED")]
        EXPIRED
    }

}
