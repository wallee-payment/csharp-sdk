using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Environment
    /// </summary>
    /// <value>Environment</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Environment
    {
        
        /// <summary>
        /// Enum LIVE for "LIVE"
        /// </summary>
        [EnumMember(Value = "LIVE")]
        LIVE,
        
        /// <summary>
        /// Enum PREVIEW for "PREVIEW"
        /// </summary>
        [EnumMember(Value = "PREVIEW")]
        PREVIEW
    }

}
