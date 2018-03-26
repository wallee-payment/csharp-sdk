using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Data Collection Type
    /// </summary>
    /// <value>Data Collection Type</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DataCollectionType
    {
        
        /// <summary>
        /// Enum ONSITE for "ONSITE"
        /// </summary>
        [EnumMember(Value = "ONSITE")]
        ONSITE,
        
        /// <summary>
        /// Enum OFFSITE for "OFFSITE"
        /// </summary>
        [EnumMember(Value = "OFFSITE")]
        OFFSITE
    }

}
