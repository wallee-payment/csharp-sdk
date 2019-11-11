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
    /// The &#39;order by&#39; type specifies how the result is sorted.
    /// </summary>
    /// <value>The &#39;order by&#39; type specifies how the result is sorted.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum EntityQueryOrderByType
    {
        
        /// <summary>
        /// Enum DESC for value: DESC
        /// </summary>
        [EnumMember(Value = "DESC")]
        DESC,
        
        /// <summary>
        /// Enum ASC for value: ASC
        /// </summary>
        [EnumMember(Value = "ASC")]
        ASC
    }

}
