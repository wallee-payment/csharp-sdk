using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Subscription Product State
    /// </summary>
    /// <value>Subscription Product State</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionProductState
    {
        
        /// <summary>
        /// Enum CREATE for "CREATE"
        /// </summary>
        [EnumMember(Value = "CREATE")]
        CREATE,
        
        /// <summary>
        /// Enum ACTIVE for "ACTIVE"
        /// </summary>
        [EnumMember(Value = "ACTIVE")]
        ACTIVE,
        
        /// <summary>
        /// Enum INACTIVE for "INACTIVE"
        /// </summary>
        [EnumMember(Value = "INACTIVE")]
        INACTIVE,
        
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
