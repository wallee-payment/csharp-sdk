using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// The type of Client Errors which can be returned by a service.
    /// </summary>
    /// <value>The type of Client Errors which can be returned by a service.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ClientErrorType
    {
        
        /// <summary>
        /// Enum END_USER_ERROR for "END_USER_ERROR"
        /// </summary>
        [EnumMember(Value = "END_USER_ERROR")]
        END_USER_ERROR,
        
        /// <summary>
        /// Enum CONFIGURATION_ERROR for "CONFIGURATION_ERROR"
        /// </summary>
        [EnumMember(Value = "CONFIGURATION_ERROR")]
        CONFIGURATION_ERROR,
        
        /// <summary>
        /// Enum DEVELOPER_ERROR for "DEVELOPER_ERROR"
        /// </summary>
        [EnumMember(Value = "DEVELOPER_ERROR")]
        DEVELOPER_ERROR
    }

}
