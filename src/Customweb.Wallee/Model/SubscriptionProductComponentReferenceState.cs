using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Subscription Product Component Reference State
    /// </summary>
    /// <value>Subscription Product Component Reference State</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionProductComponentReferenceState
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
        /// Enum DELETING for "DELETING"
        /// </summary>
        [EnumMember(Value = "DELETING")]
        DELETING,
        
        /// <summary>
        /// Enum DELETED for "DELETED"
        /// </summary>
        [EnumMember(Value = "DELETED")]
        DELETED
    }

}
