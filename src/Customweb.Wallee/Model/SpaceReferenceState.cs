
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
    /// SpaceReferenceState model.
    /// </summary>
    /// <value>SpaceReferenceState model.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SpaceReferenceState
    {
        
        /// <summary>
        /// Enum RESTRICTED_ACTIVE for "RESTRICTED_ACTIVE"
        /// </summary>
        [EnumMember(Value = "RESTRICTED_ACTIVE")]
        RESTRICTED_ACTIVE,
        
        /// <summary>
        /// Enum ACTIVE for "ACTIVE"
        /// </summary>
        [EnumMember(Value = "ACTIVE")]
        ACTIVE,
        
        /// <summary>
        /// Enum INACTIVE for "INACTIVE"
        /// </summary>
        [EnumMember(Value = "INACTIVE")]
        INACTIVE,
        
        /// <summary>
        /// Enum DELETING for "DELETING"
        /// </summary>
        [EnumMember(Value = "DELETING")]
        DELETING,
        
        /// <summary>
        /// Enum DELETED for "DELETED"
        /// </summary>
        [EnumMember(Value = "DELETED")]
        DELETED
    }

}
