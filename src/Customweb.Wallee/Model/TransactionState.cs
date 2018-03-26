using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Transaction State
    /// </summary>
    /// <value>Transaction State</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransactionState
    {
        
        /// <summary>
        /// Enum CREATE for "CREATE"
        /// </summary>
        [EnumMember(Value = "CREATE")]
        CREATE,
        
        /// <summary>
        /// Enum PENDING for "PENDING"
        /// </summary>
        [EnumMember(Value = "PENDING")]
        PENDING,
        
        /// <summary>
        /// Enum CONFIRMED for "CONFIRMED"
        /// </summary>
        [EnumMember(Value = "CONFIRMED")]
        CONFIRMED,
        
        /// <summary>
        /// Enum PROCESSING for "PROCESSING"
        /// </summary>
        [EnumMember(Value = "PROCESSING")]
        PROCESSING,
        
        /// <summary>
        /// Enum FAILED for "FAILED"
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED,
        
        /// <summary>
        /// Enum AUTHORIZED for "AUTHORIZED"
        /// </summary>
        [EnumMember(Value = "AUTHORIZED")]
        AUTHORIZED,
        
        /// <summary>
        /// Enum VOIDED for "VOIDED"
        /// </summary>
        [EnumMember(Value = "VOIDED")]
        VOIDED,
        
        /// <summary>
        /// Enum COMPLETED for "COMPLETED"
        /// </summary>
        [EnumMember(Value = "COMPLETED")]
        COMPLETED,
        
        /// <summary>
        /// Enum FULFILL for "FULFILL"
        /// </summary>
        [EnumMember(Value = "FULFILL")]
        FULFILL,
        
        /// <summary>
        /// Enum DECLINE for "DECLINE"
        /// </summary>
        [EnumMember(Value = "DECLINE")]
        DECLINE
    }

}
