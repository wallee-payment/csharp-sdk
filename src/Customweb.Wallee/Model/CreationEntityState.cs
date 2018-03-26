using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Creation Entity State
    /// </summary>
    /// <value>Creation Entity State</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CreationEntityState
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
