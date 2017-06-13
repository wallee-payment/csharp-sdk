
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

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// ConnectorInvocationStage model.
    /// </summary>
    /// <value>ConnectorInvocationStage model.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ConnectorInvocationStage
    {
        
        /// <summary>
        /// Enum PAYMENT_METHOD_LIST for "PAYMENT_METHOD_LIST"
        /// </summary>
        [EnumMember(Value = "PAYMENT_METHOD_LIST")]
        PAYMENT_METHOD_LIST,
        
        /// <summary>
        /// Enum FORM_GENERATION for "FORM_GENERATION"
        /// </summary>
        [EnumMember(Value = "FORM_GENERATION")]
        FORM_GENERATION,
        
        /// <summary>
        /// Enum VALIDATION for "VALIDATION"
        /// </summary>
        [EnumMember(Value = "VALIDATION")]
        VALIDATION,
        
        /// <summary>
        /// Enum AUTHORIZATION for "AUTHORIZATION"
        /// </summary>
        [EnumMember(Value = "AUTHORIZATION")]
        AUTHORIZATION
    }

}
