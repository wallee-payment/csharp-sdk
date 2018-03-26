using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Subscription Version State
    /// </summary>
    /// <value>Subscription Version State</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionVersionState
    {
        
        /// <summary>
        /// Enum PENDING for "PENDING"
        /// </summary>
        [EnumMember(Value = "PENDING")]
        PENDING,
        
        /// <summary>
        /// Enum INITIALIZING for "INITIALIZING"
        /// </summary>
        [EnumMember(Value = "INITIALIZING")]
        INITIALIZING,
        
        /// <summary>
        /// Enum FAILED for "FAILED"
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED,
        
        /// <summary>
        /// Enum ACTIVE for "ACTIVE"
        /// </summary>
        [EnumMember(Value = "ACTIVE")]
        ACTIVE,
        
        /// <summary>
        /// Enum TERMINATING for "TERMINATING"
        /// </summary>
        [EnumMember(Value = "TERMINATING")]
        TERMINATING,
        
        /// <summary>
        /// Enum TERMINATED for "TERMINATED"
        /// </summary>
        [EnumMember(Value = "TERMINATED")]
        TERMINATED
    }

}
