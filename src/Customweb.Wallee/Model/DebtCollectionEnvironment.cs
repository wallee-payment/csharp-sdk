using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Debt Collection Environment
    /// </summary>
    /// <value>Debt Collection Environment</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DebtCollectionEnvironment
    {
        
        /// <summary>
        /// Enum PRODUCTION for "PRODUCTION"
        /// </summary>
        [EnumMember(Value = "PRODUCTION")]
        PRODUCTION,
        
        /// <summary>
        /// Enum TEST for "TEST"
        /// </summary>
        [EnumMember(Value = "TEST")]
        TEST
    }

}
