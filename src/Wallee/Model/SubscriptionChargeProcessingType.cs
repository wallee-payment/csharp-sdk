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
    /// Defines SubscriptionChargeProcessingType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum SubscriptionChargeProcessingType
    {
        
        /// <summary>
        /// Enum SYNCHRONOUS for value: SYNCHRONOUS
        /// </summary>
        [EnumMember(Value = "SYNCHRONOUS")]
        SYNCHRONOUS,
        
        /// <summary>
        /// Enum CHARGE_FLOW for value: CHARGE_FLOW
        /// </summary>
        [EnumMember(Value = "CHARGE_FLOW")]
        CHARGE_FLOW
    }

}
