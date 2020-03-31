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
    /// Defines ShopifySubscriptionVersionItemPriceStrategy
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ShopifySubscriptionVersionItemPriceStrategy
    {
        
        /// <summary>
        /// Enum INITIALLY_CALCULATED for value: INITIALLY_CALCULATED
        /// </summary>
        [EnumMember(Value = "INITIALLY_CALCULATED")]
        INITIALLY_CALCULATED,
        
        /// <summary>
        /// Enum RECALCULATE for value: RECALCULATE
        /// </summary>
        [EnumMember(Value = "RECALCULATE")]
        RECALCULATE
    }

}
