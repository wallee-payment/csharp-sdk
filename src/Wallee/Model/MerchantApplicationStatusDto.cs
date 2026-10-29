/**
 * Wallee AG C# SDK
 *
 * This library allows to interact with the Wallee AG payment service.
 *
 * Copyright owner: Wallee AG
 * Website: https://en.wallee.com
 * Developer email: ecosystem-team@wallee.com
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Wallee.Client.OpenAPIDateConverter;

namespace Wallee.Model
{
    /// <summary>
    /// MerchantApplicationStatusDto
    /// </summary>
    [DataContract(Name = "MerchantApplicationStatusDto")]
    public partial class MerchantApplicationStatusDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ApplicationState
        /// </summary>
        [DataMember(Name = "applicationState", EmitDefaultValue = false)]
        public MerchantApplicationState? ApplicationState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantApplicationStatusDto" /> class.
        /// </summary>
        /// <param name="applicationState">applicationState.</param>
        public MerchantApplicationStatusDto(MerchantApplicationState? applicationState = default)
        {
            this.ApplicationState = applicationState;
        }

        /// <summary>
        /// Validation violations that currently prevent the merchant application from being completed.
        /// </summary>
        /// <value>Validation violations that currently prevent the merchant application from being completed.</value>
        [DataMember(Name = "violations", EmitDefaultValue = false)]
        public List<Dictionary<string, Object>> Violations { get; private set; }

        /// <summary>
        /// Returns false as Violations should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeViolations()
        {
            return false;
        }
        /// <summary>
        /// The ID of the merchant application.
        /// </summary>
        /// <value>The ID of the merchant application.</value>
        [DataMember(Name = "merchantApplicationId", EmitDefaultValue = false)]
        public long MerchantApplicationId { get; private set; }

        /// <summary>
        /// Returns false as MerchantApplicationId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMerchantApplicationId()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MerchantApplicationStatusDto {\n");
            sb.Append("  ApplicationState: ").Append(ApplicationState).Append("\n");
            sb.Append("  Violations: ").Append(Violations).Append("\n");
            sb.Append("  MerchantApplicationId: ").Append(MerchantApplicationId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
