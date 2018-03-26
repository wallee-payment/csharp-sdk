using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Product Fee Type
    /// </summary>
    /// <value>Product Fee Type</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProductFeeType
    {
        
        /// <summary>
        /// Enum METERED_FEE for "METERED_FEE"
        /// </summary>
        [EnumMember(Value = "METERED_FEE")]
        METERED_FEE,
        
        /// <summary>
        /// Enum SETUP_FEE for "SETUP_FEE"
        /// </summary>
        [EnumMember(Value = "SETUP_FEE")]
        SETUP_FEE,
        
        /// <summary>
        /// Enum PERIOD_FEE for "PERIOD_FEE"
        /// </summary>
        [EnumMember(Value = "PERIOD_FEE")]
        PERIOD_FEE
    }

}
