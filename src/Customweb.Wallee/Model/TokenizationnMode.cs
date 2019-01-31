using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// The tokenization mode controls how the tokenization of payment information is applied on the transaction.
    /// </summary>
    /// <value>The tokenization mode controls how the tokenization of payment information is applied on the transaction.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TokenizationnMode
    {
        
        /// <summary>
        /// Enum FORCE_UPDATE for "FORCE_UPDATE"
        /// </summary>
        [EnumMember(Value = "FORCE_UPDATE")]
        FORCE_UPDATE,
        
        /// <summary>
        /// Enum FORCE_CREATION for "FORCE_CREATION"
        /// </summary>
        [EnumMember(Value = "FORCE_CREATION")]
        FORCE_CREATION,
        
        /// <summary>
        /// Enum FORCE_CREATION_WITH_ONE_CLICK_PAYMENT for "FORCE_CREATION_WITH_ONE_CLICK_PAYMENT"
        /// </summary>
        [EnumMember(Value = "FORCE_CREATION_WITH_ONE_CLICK_PAYMENT")]
        FORCE_CREATION_WITH_ONE_CLICK_PAYMENT,
        
        /// <summary>
        /// Enum ALLOW_ONE_CLICK_PAYMENT for "ALLOW_ONE_CLICK_PAYMENT"
        /// </summary>
        [EnumMember(Value = "ALLOW_ONE_CLICK_PAYMENT")]
        ALLOW_ONE_CLICK_PAYMENT
    }

}
