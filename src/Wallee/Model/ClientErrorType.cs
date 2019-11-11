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
    /// The type of Client Errors which can be returned by a service.
    /// </summary>
    /// <value>The type of Client Errors which can be returned by a service.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ClientErrorType
    {
        
        /// <summary>
        /// Enum END_USER_ERROR for value: END_USER_ERROR
        /// </summary>
        [EnumMember(Value = "END_USER_ERROR")]
        END_USER_ERROR,
        
        /// <summary>
        /// Enum CONFIGURATION_ERROR for value: CONFIGURATION_ERROR
        /// </summary>
        [EnumMember(Value = "CONFIGURATION_ERROR")]
        CONFIGURATION_ERROR,
        
        /// <summary>
        /// Enum DEVELOPER_ERROR for value: DEVELOPER_ERROR
        /// </summary>
        [EnumMember(Value = "DEVELOPER_ERROR")]
        DEVELOPER_ERROR
    }

}
