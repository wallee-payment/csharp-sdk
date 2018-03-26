using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Customers Presence
    /// </summary>
    /// <value>Customers Presence</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CustomersPresence
    {
        
        /// <summary>
        /// Enum NOT_PRESENT for "NOT_PRESENT"
        /// </summary>
        [EnumMember(Value = "NOT_PRESENT")]
        NOT_PRESENT,
        
        /// <summary>
        /// Enum VIRTUAL_PRESENT for "VIRTUAL_PRESENT"
        /// </summary>
        [EnumMember(Value = "VIRTUAL_PRESENT")]
        VIRTUAL_PRESENT,
        
        /// <summary>
        /// Enum PHYSICAL_PRESENT for "PHYSICAL_PRESENT"
        /// </summary>
        [EnumMember(Value = "PHYSICAL_PRESENT")]
        PHYSICAL_PRESENT
    }

}
