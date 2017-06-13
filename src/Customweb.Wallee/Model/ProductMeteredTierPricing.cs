
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// ProductMeteredTierPricing model.
    /// </summary>
    /// <value>ProductMeteredTierPricing model.</value>
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
