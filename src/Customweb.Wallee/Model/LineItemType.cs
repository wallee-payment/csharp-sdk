
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
    /// LineItemType model.
    /// </summary>
    /// <value>LineItemType model.</value>
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
