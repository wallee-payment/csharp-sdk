using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Account Type
    /// </summary>
    /// <value>Account Type</value>
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
