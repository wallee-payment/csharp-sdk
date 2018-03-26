using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Subscription Product Version State
    /// </summary>
    /// <value>Subscription Product Version State</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionProductVersionState
    {
        
        /// <summary>
        /// Enum PENDING for "PENDING"
        /// </summary>
        [EnumMember(Value = "PENDING")]
        PENDING,
        
        /// <summary>
        /// Enum ACTIVE for "ACTIVE"
        /// </summary>
        [EnumMember(Value = "ACTIVE")]
        ACTIVE,
        
        /// <summary>
        /// Enum OBSOLETE for "OBSOLETE"
        /// </summary>
        [EnumMember(Value = "OBSOLETE")]
        OBSOLETE,
        
        /// <summary>
        /// Enum RETIRING for "RETIRING"
        /// </summary>
        [EnumMember(Value = "RETIRING")]
        RETIRING,
        
        /// <summary>
        /// Enum RETIRED for "RETIRED"
        /// </summary>
        [EnumMember(Value = "RETIRED")]
        RETIRED
    }

}
