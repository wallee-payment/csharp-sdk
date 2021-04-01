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
    /// This model defines the card authentication versions.
    /// </summary>
    /// <value>This model defines the card authentication versions.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum CardAuthenticationVersion
    {
        
        /// <summary>
        /// Enum V1 for value: V1
        /// </summary>
        [EnumMember(Value = "V1")]
        V1,
        
        /// <summary>
        /// Enum V2 for value: V2
        /// </summary>
        [EnumMember(Value = "V2")]
        V2
    }

}
