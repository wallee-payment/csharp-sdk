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
    /// Defines PaymentInitiationAdviceFileState
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PaymentInitiationAdviceFileState
    {
        
        /// <summary>
        /// Enum CREATED for value: CREATED
        /// </summary>
        [EnumMember(Value = "CREATED")]
        CREATED,
        
        /// <summary>
        /// Enum UPLOADED for value: UPLOADED
        /// </summary>
        [EnumMember(Value = "UPLOADED")]
        UPLOADED,
        
        /// <summary>
        /// Enum DOWNLOADED for value: DOWNLOADED
        /// </summary>
        [EnumMember(Value = "DOWNLOADED")]
        DOWNLOADED,
        
        /// <summary>
        /// Enum PROCESSED for value: PROCESSED
        /// </summary>
        [EnumMember(Value = "PROCESSED")]
        PROCESSED
    }

}
