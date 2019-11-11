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
    /// The tokenization mode controls how the tokenization of payment information is applied on the transaction.
    /// </summary>
    /// <value>The tokenization mode controls how the tokenization of payment information is applied on the transaction.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TokenizationMode
    {
        
        /// <summary>
        /// Enum FORCE_UPDATE for value: FORCE_UPDATE
        /// </summary>
        [EnumMember(Value = "FORCE_UPDATE")]
        FORCE_UPDATE,
        
        /// <summary>
        /// Enum FORCE_CREATION for value: FORCE_CREATION
        /// </summary>
        [EnumMember(Value = "FORCE_CREATION")]
        FORCE_CREATION,
        
        /// <summary>
        /// Enum FORCE_CREATION_WITH_ONE_CLICK_PAYMENT for value: FORCE_CREATION_WITH_ONE_CLICK_PAYMENT
        /// </summary>
        [EnumMember(Value = "FORCE_CREATION_WITH_ONE_CLICK_PAYMENT")]
        FORCE_CREATION_WITH_ONE_CLICK_PAYMENT,
        
        /// <summary>
        /// Enum ALLOW_ONE_CLICK_PAYMENT for value: ALLOW_ONE_CLICK_PAYMENT
        /// </summary>
        [EnumMember(Value = "ALLOW_ONE_CLICK_PAYMENT")]
        ALLOW_ONE_CLICK_PAYMENT
    }

}
