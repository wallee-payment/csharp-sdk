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
    /// This model defines the card cryptogram types.
    /// </summary>
    /// <value>This model defines the card cryptogram types.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum CardCryptogramType
    {
        
        /// <summary>
        /// Enum SCHEME_TOKEN for value: SCHEME_TOKEN
        /// </summary>
        [EnumMember(Value = "SCHEME_TOKEN")]
        SCHEME_TOKEN
    }

}
