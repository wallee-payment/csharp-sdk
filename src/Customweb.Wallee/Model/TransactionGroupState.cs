using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Transaction Group State
    /// </summary>
    /// <value>Transaction Group State</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransactionGroupState
    {
        
        /// <summary>
        /// Enum PENDING for "PENDING"
        /// </summary>
        [EnumMember(Value = "PENDING")]
        PENDING,
        
        /// <summary>
        /// Enum FAILED for "FAILED"
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED,
        
        /// <summary>
        /// Enum SUCCESSFUL for "SUCCESSFUL"
        /// </summary>
        [EnumMember(Value = "SUCCESSFUL")]
        SUCCESSFUL
    }

}
