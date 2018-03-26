using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Charge Type
    /// </summary>
    /// <value>Charge Type</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ChargeType
    {
        
        /// <summary>
        /// Enum ASYNCHRONOUS for "ASYNCHRONOUS"
        /// </summary>
        [EnumMember(Value = "ASYNCHRONOUS")]
        ASYNCHRONOUS,
        
        /// <summary>
        /// Enum SYNCHRONOUS for "SYNCHRONOUS"
        /// </summary>
        [EnumMember(Value = "SYNCHRONOUS")]
        SYNCHRONOUS,
        
        /// <summary>
        /// Enum TOKEN for "TOKEN"
        /// </summary>
        [EnumMember(Value = "TOKEN")]
        TOKEN
    }

}
