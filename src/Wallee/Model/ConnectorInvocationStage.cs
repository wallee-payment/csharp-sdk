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
    /// Defines ConnectorInvocationStage
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ConnectorInvocationStage
    {
        
        /// <summary>
        /// Enum PAYMENT_METHOD_LIST for value: PAYMENT_METHOD_LIST
        /// </summary>
        [EnumMember(Value = "PAYMENT_METHOD_LIST")]
        PAYMENT_METHOD_LIST,
        
        /// <summary>
        /// Enum FORM_GENERATION for value: FORM_GENERATION
        /// </summary>
        [EnumMember(Value = "FORM_GENERATION")]
        FORM_GENERATION,
        
        /// <summary>
        /// Enum VALIDATION for value: VALIDATION
        /// </summary>
        [EnumMember(Value = "VALIDATION")]
        VALIDATION,
        
        /// <summary>
        /// Enum AUTHORIZATION for value: AUTHORIZATION
        /// </summary>
        [EnumMember(Value = "AUTHORIZATION")]
        AUTHORIZATION
    }

}
