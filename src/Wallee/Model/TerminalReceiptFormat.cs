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
    /// Defines TerminalReceiptFormat
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TerminalReceiptFormat
    {
        
        /// <summary>
        /// Enum PDF for value: PDF
        /// </summary>
        [EnumMember(Value = "PDF")]
        PDF,
        
        /// <summary>
        /// Enum TXT for value: TXT
        /// </summary>
        [EnumMember(Value = "TXT")]
        TXT
    }

}
