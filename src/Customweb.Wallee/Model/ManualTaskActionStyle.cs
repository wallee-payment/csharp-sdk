using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Manual Task Action Style
    /// </summary>
    /// <value>Manual Task Action Style</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ManualTaskActionStyle
    {
        
        /// <summary>
        /// Enum DEFAULT for "DEFAULT"
        /// </summary>
        [EnumMember(Value = "DEFAULT")]
        DEFAULT,
        
        /// <summary>
        /// Enum PRIMARY for "PRIMARY"
        /// </summary>
        [EnumMember(Value = "PRIMARY")]
        PRIMARY,
        
        /// <summary>
        /// Enum DANGER for "DANGER"
        /// </summary>
        [EnumMember(Value = "DANGER")]
        DANGER
    }

}
