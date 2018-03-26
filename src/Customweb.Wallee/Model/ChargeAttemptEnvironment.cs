using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Charge Attempt Environment
    /// </summary>
    /// <value>Charge Attempt Environment</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ChargeAttemptEnvironment
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
