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
    /// Defines CardAuthenticationResponse
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum CardAuthenticationResponse
    {
        
        /// <summary>
        /// Enum FULLY_AUTHENTICATED for value: FULLY_AUTHENTICATED
        /// </summary>
        [EnumMember(Value = "FULLY_AUTHENTICATED")]
        FULLY_AUTHENTICATED,
        
        /// <summary>
        /// Enum AUTHENTICATION_NOT_REQUIRED for value: AUTHENTICATION_NOT_REQUIRED
        /// </summary>
        [EnumMember(Value = "AUTHENTICATION_NOT_REQUIRED")]
        AUTHENTICATION_NOT_REQUIRED,
        
        /// <summary>
        /// Enum NOT_ENROLLED for value: NOT_ENROLLED
        /// </summary>
        [EnumMember(Value = "NOT_ENROLLED")]
        NOT_ENROLLED,
        
        /// <summary>
        /// Enum ENROLLMENT_ERROR for value: ENROLLMENT_ERROR
        /// </summary>
        [EnumMember(Value = "ENROLLMENT_ERROR")]
        ENROLLMENT_ERROR,
        
        /// <summary>
        /// Enum AUTHENTICATION_ERROR for value: AUTHENTICATION_ERROR
        /// </summary>
        [EnumMember(Value = "AUTHENTICATION_ERROR")]
        AUTHENTICATION_ERROR
    }

}
