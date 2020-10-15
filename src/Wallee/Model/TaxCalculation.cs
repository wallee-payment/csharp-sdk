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
    /// Defines TaxCalculation
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TaxCalculation
    {
        
        /// <summary>
        /// Enum INCLUDED for value: TAX_INCLUDED
        /// </summary>
        [EnumMember(Value = "TAX_INCLUDED")]
        INCLUDED,
        
        /// <summary>
        /// Enum NOT_INCLUDED for value: TAX_NOT_INCLUDED
        /// </summary>
        [EnumMember(Value = "TAX_NOT_INCLUDED")]
        NOT_INCLUDED
    }

}
