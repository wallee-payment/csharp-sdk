using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Token Version State
    /// </summary>
    /// <value>Token Version State</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TokenVersionState
    {
        
        /// <summary>
        /// Enum UNINITIALIZED for "UNINITIALIZED"
        /// </summary>
        [EnumMember(Value = "UNINITIALIZED")]
        UNINITIALIZED,
        
        /// <summary>
        /// Enum ACTIVE for "ACTIVE"
        /// </summary>
        [EnumMember(Value = "ACTIVE")]
        ACTIVE,
        
        /// <summary>
        /// Enum OBSOLETE for "OBSOLETE"
        /// </summary>
        [EnumMember(Value = "OBSOLETE")]
        OBSOLETE
    }

}
