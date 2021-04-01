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
    /// The address handling mode controls if the address is required and how it is enforced to be provided.
    /// </summary>
    /// <value>The address handling mode controls if the address is required and how it is enforced to be provided.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PaymentLinkAddressHandlingMode
    {
        
        /// <summary>
        /// Enum NOT_REQUIRED for value: NOT_REQUIRED
        /// </summary>
        [EnumMember(Value = "NOT_REQUIRED")]
        NOT_REQUIRED,
        
        /// <summary>
        /// Enum REQUIRED_IN_URL for value: REQUIRED_IN_URL
        /// </summary>
        [EnumMember(Value = "REQUIRED_IN_URL")]
        REQUIRED_IN_URL,
        
        /// <summary>
        /// Enum REQUIRED_ON_PAYMENT_PAGE for value: REQUIRED_ON_PAYMENT_PAGE
        /// </summary>
        [EnumMember(Value = "REQUIRED_ON_PAYMENT_PAGE")]
        REQUIRED_ON_PAYMENT_PAGE
    }

}
