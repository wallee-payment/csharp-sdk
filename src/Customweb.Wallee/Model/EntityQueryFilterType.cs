using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// The filter type defines how the filter is interpreted. Depending of the type different properties are relevant on the filter itself.
    /// </summary>
    /// <value>The filter type defines how the filter is interpreted. Depending of the type different properties are relevant on the filter itself.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EntityQueryFilterType
    {
        
        /// <summary>
        /// Enum LEAF for "LEAF"
        /// </summary>
        [EnumMember(Value = "LEAF")]
        LEAF,
        
        /// <summary>
        /// Enum OR for "OR"
        /// </summary>
        [EnumMember(Value = "OR")]
        OR,
        
        /// <summary>
        /// Enum AND for "AND"
        /// </summary>
        [EnumMember(Value = "AND")]
        AND
    }

}
