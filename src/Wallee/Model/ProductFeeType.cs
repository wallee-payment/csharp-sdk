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
    /// Defines ProductFeeType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ProductFeeType
    {
        
        /// <summary>
        /// Enum METERED_FEE for value: METERED_FEE
        /// </summary>
        [EnumMember(Value = "METERED_FEE")]
        METERED_FEE,
        
        /// <summary>
        /// Enum SETUP_FEE for value: SETUP_FEE
        /// </summary>
        [EnumMember(Value = "SETUP_FEE")]
        SETUP_FEE,
        
        /// <summary>
        /// Enum PERIOD_FEE for value: PERIOD_FEE
        /// </summary>
        [EnumMember(Value = "PERIOD_FEE")]
        PERIOD_FEE
    }

}
