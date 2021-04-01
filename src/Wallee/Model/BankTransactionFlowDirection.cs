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
    /// Defines BankTransactionFlowDirection
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum BankTransactionFlowDirection
    {
        
        /// <summary>
        /// Enum INFLOW for value: INFLOW
        /// </summary>
        [EnumMember(Value = "INFLOW")]
        INFLOW,
        
        /// <summary>
        /// Enum OUTFLOW for value: OUTFLOW
        /// </summary>
        [EnumMember(Value = "OUTFLOW")]
        OUTFLOW
    }

}
