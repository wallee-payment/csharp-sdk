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
    /// Defines ShopifySubscriptionSuspensionType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ShopifySubscriptionSuspensionType
    {
        
        /// <summary>
        /// Enum REACTIVATE for value: REACTIVATE
        /// </summary>
        [EnumMember(Value = "REACTIVATE")]
        REACTIVATE,
        
        /// <summary>
        /// Enum TERMINATE for value: TERMINATE
        /// </summary>
        [EnumMember(Value = "TERMINATE")]
        TERMINATE
    }

}
