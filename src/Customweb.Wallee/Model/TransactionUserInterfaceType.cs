using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Transaction User Interface Type
    /// </summary>
    /// <value>Transaction User Interface Type</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransactionUserInterfaceType
    {
        
        /// <summary>
        /// Enum IFRAME for "IFRAME"
        /// </summary>
        [EnumMember(Value = "IFRAME")]
        IFRAME,
        
        /// <summary>
        /// Enum PAYMENT_PAGE for "PAYMENT_PAGE"
        /// </summary>
        [EnumMember(Value = "PAYMENT_PAGE")]
        PAYMENT_PAGE,
        
        /// <summary>
        /// Enum MOBILE_SDK for "MOBILE_SDK"
        /// </summary>
        [EnumMember(Value = "MOBILE_SDK")]
        MOBILE_SDK
    }

}
