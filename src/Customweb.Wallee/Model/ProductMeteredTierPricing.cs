/**
 * Wallee SDK Client
 *
 * This client allows to interact with the Wallee API.
 *
 * Wallee API: 1.0.0
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
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
