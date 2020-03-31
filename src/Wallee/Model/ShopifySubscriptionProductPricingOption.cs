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
using SwaggerDateConverter = Wallee.Client.SwaggerDateConverter;

namespace Wallee.Model
{
    /// <summary>
    /// Defines ShopifySubscriptionProductPricingOption
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ShopifySubscriptionProductPricingOption
    {
        
        /// <summary>
        /// Enum CURRENT_PRICE for value: CURRENT_PRICE
        /// </summary>
        [EnumMember(Value = "CURRENT_PRICE")]
        CURRENT_PRICE,
        
        /// <summary>
        /// Enum ORIGINAL_PRICE for value: ORIGINAL_PRICE
        /// </summary>
        [EnumMember(Value = "ORIGINAL_PRICE")]
        ORIGINAL_PRICE,
        
        /// <summary>
        /// Enum FIXED_PRICE for value: FIXED_PRICE
        /// </summary>
        [EnumMember(Value = "FIXED_PRICE")]
        FIXED_PRICE,
        
        /// <summary>
        /// Enum RELATIVE_ADJUSTMENT for value: RELATIVE_ADJUSTMENT
        /// </summary>
        [EnumMember(Value = "RELATIVE_ADJUSTMENT")]
        RELATIVE_ADJUSTMENT,
        
        /// <summary>
        /// Enum ABSOLUTE_ADJUSTMENT for value: ABSOLUTE_ADJUSTMENT
        /// </summary>
        [EnumMember(Value = "ABSOLUTE_ADJUSTMENT")]
        ABSOLUTE_ADJUSTMENT
    }

}
