using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Gender
    /// </summary>
    /// <value>Gender</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Gender
    {
        
        /// <summary>
        /// Enum MALE for "MALE"
        /// </summary>
        [EnumMember(Value = "MALE")]
        MALE,
        
        /// <summary>
        /// Enum FEMALE for "FEMALE"
        /// </summary>
        [EnumMember(Value = "FEMALE")]
        FEMALE
    }

}
