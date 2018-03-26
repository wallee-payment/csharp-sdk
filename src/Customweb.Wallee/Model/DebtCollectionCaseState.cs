using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Debt Collection Case State
    /// </summary>
    /// <value>Debt Collection Case State</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DebtCollectionCaseState
    {
        
        /// <summary>
        /// Enum CREATE for "CREATE"
        /// </summary>
        [EnumMember(Value = "CREATE")]
        CREATE,
        
        /// <summary>
        /// Enum PREPARING for "PREPARING"
        /// </summary>
        [EnumMember(Value = "PREPARING")]
        PREPARING,
        
        /// <summary>
        /// Enum REVIEWING for "REVIEWING"
        /// </summary>
        [EnumMember(Value = "REVIEWING")]
        REVIEWING,
        
        /// <summary>
        /// Enum PENDING for "PENDING"
        /// </summary>
        [EnumMember(Value = "PENDING")]
        PENDING,
        
        /// <summary>
        /// Enum PROCESSING for "PROCESSING"
        /// </summary>
        [EnumMember(Value = "PROCESSING")]
        PROCESSING,
        
        /// <summary>
        /// Enum CLOSED for "CLOSED"
        /// </summary>
        [EnumMember(Value = "CLOSED")]
        CLOSED,
        
        /// <summary>
        /// Enum FAILED for "FAILED"
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED
    }

}
