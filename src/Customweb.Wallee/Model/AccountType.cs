
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
    /// AccountType model.
    /// </summary>
    /// <value>AccountType model.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccountType
    {
        
        /// <summary>
        /// Enum MASTER for "MASTER"
        /// </summary>
        [EnumMember(Value = "MASTER")]
        MASTER,
        
        /// <summary>
        /// Enum REGULAR for "REGULAR"
        /// </summary>
        [EnumMember(Value = "REGULAR")]
        REGULAR,
        
        /// <summary>
        /// Enum SUBACCOUNT for "SUBACCOUNT"
        /// </summary>
        [EnumMember(Value = "SUBACCOUNT")]
        SUBACCOUNT
    }

}
