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
    /// Defines ShopifyAdditionalLineItemData
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ShopifyAdditionalLineItemData
    {
        
        /// <summary>
        /// Enum VENDOR for value: VENDOR
        /// </summary>
        [EnumMember(Value = "VENDOR")]
        VENDOR,
        
        /// <summary>
        /// Enum WEIGHT for value: WEIGHT
        /// </summary>
        [EnumMember(Value = "WEIGHT")]
        WEIGHT
    }

}
