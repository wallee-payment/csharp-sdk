using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Product Metered Tier Pricing
    /// </summary>
    /// <value>Product Metered Tier Pricing</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProductMeteredTierPricing
    {
        
        /// <summary>
        /// Enum CHEAPEST_TIER_PRICING for "CHEAPEST_TIER_PRICING"
        /// </summary>
        [EnumMember(Value = "CHEAPEST_TIER_PRICING")]
        CHEAPEST_TIER_PRICING,
        
        /// <summary>
        /// Enum INCREMENTAL_DISCOUNT_PRICING for "INCREMENTAL_DISCOUNT_PRICING"
        /// </summary>
        [EnumMember(Value = "INCREMENTAL_DISCOUNT_PRICING")]
        INCREMENTAL_DISCOUNT_PRICING
    }

}
