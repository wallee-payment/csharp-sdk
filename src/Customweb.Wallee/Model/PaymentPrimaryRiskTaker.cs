
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
    /// The primary risk taker will have the main loss when one party of the contract does not fulfill the contractual duties.
    /// </summary>
    /// <value>The primary risk taker will have the main loss when one party of the contract does not fulfill the contractual duties.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentPrimaryRiskTaker
    {
        
        /// <summary>
        /// Enum CUSTOMER for "CUSTOMER"
        /// </summary>
        [EnumMember(Value = "CUSTOMER")]
        CUSTOMER,
        
        /// <summary>
        /// Enum MERCHANT for "MERCHANT"
        /// </summary>
        [EnumMember(Value = "MERCHANT")]
        MERCHANT,
        
        /// <summary>
        /// Enum THIRD_PARTY for "THIRD_PARTY"
        /// </summary>
        [EnumMember(Value = "THIRD_PARTY")]
        THIRD_PARTY
    }

}
