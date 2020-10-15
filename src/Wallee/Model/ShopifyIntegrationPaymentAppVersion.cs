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
    /// Defines ShopifyIntegrationPaymentAppVersion
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ShopifyIntegrationPaymentAppVersion
    {
        
        /// <summary>
        /// Enum API_2019_07 for value: API_2019_07
        /// </summary>
        [EnumMember(Value = "API_2019_07")]
        API_2019_07
    }

}
