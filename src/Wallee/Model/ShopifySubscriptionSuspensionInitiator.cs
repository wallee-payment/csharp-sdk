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
    /// Defines ShopifySubscriptionSuspensionInitiator
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ShopifySubscriptionSuspensionInitiator
    {
        
        /// <summary>
        /// Enum MERCHANT for value: MERCHANT
        /// </summary>
        [EnumMember(Value = "MERCHANT")]
        MERCHANT,
        
        /// <summary>
        /// Enum CUSTOMER for value: CUSTOMER
        /// </summary>
        [EnumMember(Value = "CUSTOMER")]
        CUSTOMER
    }

}
