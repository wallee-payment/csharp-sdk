using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Address Format Field
    /// </summary>
    /// <value>Address Format Field</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RestAddressFormatField
    {
        
        /// <summary>
        /// Enum GIVEN_NAME for "GIVEN_NAME"
        /// </summary>
        [EnumMember(Value = "GIVEN_NAME")]
        GIVEN_NAME,
        
        /// <summary>
        /// Enum FAMILY_NAME for "FAMILY_NAME"
        /// </summary>
        [EnumMember(Value = "FAMILY_NAME")]
        FAMILY_NAME,
        
        /// <summary>
        /// Enum ORGANIZATION_NAME for "ORGANIZATION_NAME"
        /// </summary>
        [EnumMember(Value = "ORGANIZATION_NAME")]
        ORGANIZATION_NAME,
        
        /// <summary>
        /// Enum STREET for "STREET"
        /// </summary>
        [EnumMember(Value = "STREET")]
        STREET,
        
        /// <summary>
        /// Enum DEPENDENT_LOCALITY for "DEPENDENT_LOCALITY"
        /// </summary>
        [EnumMember(Value = "DEPENDENT_LOCALITY")]
        DEPENDENT_LOCALITY,
        
        /// <summary>
        /// Enum CITY for "CITY"
        /// </summary>
        [EnumMember(Value = "CITY")]
        CITY,
        
        /// <summary>
        /// Enum POSTAL_STATE for "POSTAL_STATE"
        /// </summary>
        [EnumMember(Value = "POSTAL_STATE")]
        POSTAL_STATE,
        
        /// <summary>
        /// Enum POST_CODE for "POST_CODE"
        /// </summary>
        [EnumMember(Value = "POST_CODE")]
        POST_CODE,
        
        /// <summary>
        /// Enum SORTING_CODE for "SORTING_CODE"
        /// </summary>
        [EnumMember(Value = "SORTING_CODE")]
        SORTING_CODE,
        
        /// <summary>
        /// Enum COUNTRY for "COUNTRY"
        /// </summary>
        [EnumMember(Value = "COUNTRY")]
        COUNTRY
    }

}
