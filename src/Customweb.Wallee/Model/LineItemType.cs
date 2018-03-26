using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Line Item Type
    /// </summary>
    /// <value>Line Item Type</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LineItemType
    {
        
        /// <summary>
        /// Enum SHIPPING for "SHIPPING"
        /// </summary>
        [EnumMember(Value = "SHIPPING")]
        SHIPPING,
        
        /// <summary>
        /// Enum DISCOUNT for "DISCOUNT"
        /// </summary>
        [EnumMember(Value = "DISCOUNT")]
        DISCOUNT,
        
        /// <summary>
        /// Enum FEE for "FEE"
        /// </summary>
        [EnumMember(Value = "FEE")]
        FEE,
        
        /// <summary>
        /// Enum PRODUCT for "PRODUCT"
        /// </summary>
        [EnumMember(Value = "PRODUCT")]
        PRODUCT
    }

}
