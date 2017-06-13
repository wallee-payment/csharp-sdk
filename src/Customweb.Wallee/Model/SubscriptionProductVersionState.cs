
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
    /// SubscriptionProductVersionState model.
    /// </summary>
    /// <value>SubscriptionProductVersionState model.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionProductVersionState
    {
        
        /// <summary>
        /// Enum PENDING for "PENDING"
        /// </summary>
        [EnumMember(Value = "PENDING")]
        PENDING,
        
        /// <summary>
        /// Enum ACTIVE for "ACTIVE"
        /// </summary>
        [EnumMember(Value = "ACTIVE")]
        ACTIVE,
        
        /// <summary>
        /// Enum OBSOLETE for "OBSOLETE"
        /// </summary>
        [EnumMember(Value = "OBSOLETE")]
        OBSOLETE,
        
        /// <summary>
        /// Enum RETIRING for "RETIRING"
        /// </summary>
        [EnumMember(Value = "RETIRING")]
        RETIRING,
        
        /// <summary>
        /// Enum RETIRED for "RETIRED"
        /// </summary>
        [EnumMember(Value = "RETIRED")]
        RETIRED
    }

}
