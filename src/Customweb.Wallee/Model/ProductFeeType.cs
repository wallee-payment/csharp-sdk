
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
    /// ProductFeeType model.
    /// </summary>
    /// <value>ProductFeeType model.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProductFeeType
    {
        
        /// <summary>
        /// Enum METERED_FEE for "METERED_FEE"
        /// </summary>
        [EnumMember(Value = "METERED_FEE")]
        METERED_FEE,
        
        /// <summary>
        /// Enum SETUP_FEE for "SETUP_FEE"
        /// </summary>
        [EnumMember(Value = "SETUP_FEE")]
        SETUP_FEE,
        
        /// <summary>
        /// Enum PERIOD_FEE for "PERIOD_FEE"
        /// </summary>
        [EnumMember(Value = "PERIOD_FEE")]
        PERIOD_FEE
    }

}
