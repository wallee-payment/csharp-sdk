using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Subscription Ledger Entry State
    /// </summary>
    /// <value>Subscription Ledger Entry State</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionLedgerEntryState
    {
        
        /// <summary>
        /// Enum OPEN for "OPEN"
        /// </summary>
        [EnumMember(Value = "OPEN")]
        OPEN,
        
        /// <summary>
        /// Enum SCHEDULED for "SCHEDULED"
        /// </summary>
        [EnumMember(Value = "SCHEDULED")]
        SCHEDULED,
        
        /// <summary>
        /// Enum PAID for "PAID"
        /// </summary>
        [EnumMember(Value = "PAID")]
        PAID
    }

}
