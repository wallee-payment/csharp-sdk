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
    /// Defines InvoiceReimbursementState
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum InvoiceReimbursementState
    {
        
        /// <summary>
        /// Enum PENDING for value: PENDING
        /// </summary>
        [EnumMember(Value = "PENDING")]
        PENDING,
        
        /// <summary>
        /// Enum MANUAL_REVIEW for value: MANUAL_REVIEW
        /// </summary>
        [EnumMember(Value = "MANUAL_REVIEW")]
        MANUAL_REVIEW,
        
        /// <summary>
        /// Enum PROCESSING for value: PROCESSING
        /// </summary>
        [EnumMember(Value = "PROCESSING")]
        PROCESSING,
        
        /// <summary>
        /// Enum PROCESSED for value: PROCESSED
        /// </summary>
        [EnumMember(Value = "PROCESSED")]
        PROCESSED,
        
        /// <summary>
        /// Enum DISCARDED for value: DISCARDED
        /// </summary>
        [EnumMember(Value = "DISCARDED")]
        DISCARDED
    }

}
