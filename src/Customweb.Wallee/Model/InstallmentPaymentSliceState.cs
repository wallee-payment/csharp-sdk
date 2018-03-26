using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Installment Payment Slice State
    /// </summary>
    /// <value>Installment Payment Slice State</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InstallmentPaymentSliceState
    {
        
        /// <summary>
        /// Enum CREATE for "CREATE"
        /// </summary>
        [EnumMember(Value = "CREATE")]
        CREATE,
        
        /// <summary>
        /// Enum SCHEDULED for "SCHEDULED"
        /// </summary>
        [EnumMember(Value = "SCHEDULED")]
        SCHEDULED,
        
        /// <summary>
        /// Enum CANCELED for "CANCELED"
        /// </summary>
        [EnumMember(Value = "CANCELED")]
        CANCELED,
        
        /// <summary>
        /// Enum PREPARE_PROCESSING for "PREPARE_PROCESSING"
        /// </summary>
        [EnumMember(Value = "PREPARE_PROCESSING")]
        PREPARE_PROCESSING,
        
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
        /// Enum SUCCESSFUL for "SUCCESSFUL"
        /// </summary>
        [EnumMember(Value = "SUCCESSFUL")]
        SUCCESSFUL
    }

}
