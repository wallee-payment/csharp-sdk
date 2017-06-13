
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
    /// SubscriptionSuspensionAction model.
    /// </summary>
    /// <value>SubscriptionSuspensionAction model.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionSuspensionAction
    {
        
        /// <summary>
        /// Enum TERMINATE for "TERMINATE"
        /// </summary>
        [EnumMember(Value = "TERMINATE")]
        TERMINATE,
        
        /// <summary>
        /// Enum REACTIVATE for "REACTIVATE"
        /// </summary>
        [EnumMember(Value = "REACTIVATE")]
        REACTIVATE
    }

}
