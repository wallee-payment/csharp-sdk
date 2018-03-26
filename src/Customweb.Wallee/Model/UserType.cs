using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// User Type
    /// </summary>
    /// <value>User Type</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UserType
    {
        
        /// <summary>
        /// Enum HUMAN_USER for "HUMAN_USER"
        /// </summary>
        [EnumMember(Value = "HUMAN_USER")]
        HUMAN_USER,
        
        /// <summary>
        /// Enum SINGLE_SIGNON_USER for "SINGLE_SIGNON_USER"
        /// </summary>
        [EnumMember(Value = "SINGLE_SIGNON_USER")]
        SINGLE_SIGNON_USER,
        
        /// <summary>
        /// Enum APPLICATION_USER for "APPLICATION_USER"
        /// </summary>
        [EnumMember(Value = "APPLICATION_USER")]
        APPLICATION_USER,
        
        /// <summary>
        /// Enum ANONYMOUS_USER for "ANONYMOUS_USER"
        /// </summary>
        [EnumMember(Value = "ANONYMOUS_USER")]
        ANONYMOUS_USER,
        
        /// <summary>
        /// Enum SERVER_USER for "SERVER_USER"
        /// </summary>
        [EnumMember(Value = "SERVER_USER")]
        SERVER_USER
    }

}
