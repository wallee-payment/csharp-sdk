using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Installment Payment State
    /// </summary>
    /// <value>Installment Payment State</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InstallmentPaymentState
    {
        
        /// <summary>
        /// Enum CREATE for "CREATE"
        /// </summary>
        [EnumMember(Value = "CREATE")]
        CREATE,
        
        /// <summary>
        /// Enum CONFIRMED for "CONFIRMED"
        /// </summary>
        [EnumMember(Value = "CONFIRMED")]
        CONFIRMED,
        
        /// <summary>
        /// Enum AUTHORIZED for "AUTHORIZED"
        /// </summary>
        [EnumMember(Value = "AUTHORIZED")]
        AUTHORIZED,
        
        /// <summary>
        /// Enum REJECTED for "REJECTED"
        /// </summary>
        [EnumMember(Value = "REJECTED")]
        REJECTED,
        
        /// <summary>
        /// Enum COMPLETED for "COMPLETED"
        /// </summary>
        [EnumMember(Value = "COMPLETED")]
        COMPLETED,
        
        /// <summary>
        /// Enum RUNNING for "RUNNING"
        /// </summary>
        [EnumMember(Value = "RUNNING")]
        RUNNING,
        
        /// <summary>
        /// Enum DONE for "DONE"
        /// </summary>
        [EnumMember(Value = "DONE")]
        DONE,
        
        /// <summary>
        /// Enum DEFAULTED for "DEFAULTED"
        /// </summary>
        [EnumMember(Value = "DEFAULTED")]
        DEFAULTED
    }

}
