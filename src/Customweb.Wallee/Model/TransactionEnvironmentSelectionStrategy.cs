using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Transaction Environment Selection Strategy
    /// </summary>
    /// <value>Transaction Environment Selection Strategy</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransactionEnvironmentSelectionStrategy
    {
        
        /// <summary>
        /// Enum FORCE_TEST_ENVIRONMENT for "FORCE_TEST_ENVIRONMENT"
        /// </summary>
        [EnumMember(Value = "FORCE_TEST_ENVIRONMENT")]
        FORCE_TEST_ENVIRONMENT,
        
        /// <summary>
        /// Enum USE_CONFIGURATION for "USE_CONFIGURATION"
        /// </summary>
        [EnumMember(Value = "USE_CONFIGURATION")]
        USE_CONFIGURATION
    }

}
