using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Label Descriptor Category
    /// </summary>
    /// <value>Label Descriptor Category</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LabelDescriptorCategory
    {
        
        /// <summary>
        /// Enum HUMAN for "HUMAN"
        /// </summary>
        [EnumMember(Value = "HUMAN")]
        HUMAN,
        
        /// <summary>
        /// Enum APPLICATION for "APPLICATION"
        /// </summary>
        [EnumMember(Value = "APPLICATION")]
        APPLICATION
    }

}
