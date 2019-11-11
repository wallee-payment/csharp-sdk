using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Wallee.Client.SwaggerDateConverter;

namespace Wallee.Model
{
    /// <summary>
    /// Defines TransactionEnvironmentSelectionStrategy
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TransactionEnvironmentSelectionStrategy
    {
        
        /// <summary>
        /// Enum FORCE_TEST_ENVIRONMENT for value: FORCE_TEST_ENVIRONMENT
        /// </summary>
        [EnumMember(Value = "FORCE_TEST_ENVIRONMENT")]
        FORCE_TEST_ENVIRONMENT,
        
        /// <summary>
        /// Enum FORCE_PRODUCTION_ENVIRONMENT for value: FORCE_PRODUCTION_ENVIRONMENT
        /// </summary>
        [EnumMember(Value = "FORCE_PRODUCTION_ENVIRONMENT")]
        FORCE_PRODUCTION_ENVIRONMENT,
        
        /// <summary>
        /// Enum USE_CONFIGURATION for value: USE_CONFIGURATION
        /// </summary>
        [EnumMember(Value = "USE_CONFIGURATION")]
        USE_CONFIGURATION
    }

}
