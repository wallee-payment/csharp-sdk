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
    /// Defines LineItemType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum LineItemType
    {
        
        /// <summary>
        /// Enum SHIPPING for value: SHIPPING
        /// </summary>
        [EnumMember(Value = "SHIPPING")]
        SHIPPING,
        
        /// <summary>
        /// Enum DISCOUNT for value: DISCOUNT
        /// </summary>
        [EnumMember(Value = "DISCOUNT")]
        DISCOUNT,
        
        /// <summary>
        /// Enum FEE for value: FEE
        /// </summary>
        [EnumMember(Value = "FEE")]
        FEE,
        
        /// <summary>
        /// Enum PRODUCT for value: PRODUCT
        /// </summary>
        [EnumMember(Value = "PRODUCT")]
        PRODUCT
    }

}
