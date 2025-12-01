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
    /// The debt collector configuration defines the behavior of the collection process for a particular collector.
    /// </summary>
    [DataContract(Name = "DebtCollectorConfiguration.Update")]
    public partial class DebtCollectorConfigurationUpdate : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public CreationEntityState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DebtCollectorConfigurationUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DebtCollectorConfigurationUpdate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DebtCollectorConfigurationUpdate" /> class.
        /// </summary>
        /// <param name="skipReviewEnabled">Whether the review of debt collection cases is skipped..</param>
        /// <param name="name">The name used to identify the debt collector configuration..</param>
        /// <param name="enabledSpaceViews">The space views for which the debt collector configuration is enabled. If empty, it is enabled for all space views..</param>
        /// <param name="state">state.</param>
        /// <param name="conditions">Conditions allow to define criteria that a debt collection case must fulfill in order for the debt collector configuration to be considered for processing the case..</param>
        /// <param name="priority">The priority that determines the order in which debt collector configurations are taken into account when processing a case. Low values are considered first..</param>
        /// <param name="varVersion">The version number indicates the version of the entity. The version is incremented whenever the entity is changed. (required).</param>
        public DebtCollectorConfigurationUpdate(bool skipReviewEnabled = default, string name = default, List<long> enabledSpaceViews = default, CreationEntityState? state = default, List<DebtCollectorCondition> conditions = default, int priority = default, int varVersion = default)
        {
            this.VarVersion = varVersion;
            this.SkipReviewEnabled = skipReviewEnabled;
            this.Name = name;
            this.EnabledSpaceViews = enabledSpaceViews;
            this.State = state;
            this.Conditions = conditions;
            this.Priority = priority;
        }

        /// <summary>
        /// Whether the review of debt collection cases is skipped.
        /// </summary>
        /// <value>Whether the review of debt collection cases is skipped.</value>
        [DataMember(Name = "skipReviewEnabled", EmitDefaultValue = true)]
        public bool SkipReviewEnabled { get; set; }

        /// <summary>
        /// The name used to identify the debt collector configuration.
        /// </summary>
        /// <value>The name used to identify the debt collector configuration.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The space views for which the debt collector configuration is enabled. If empty, it is enabled for all space views.
        /// </summary>
        /// <value>The space views for which the debt collector configuration is enabled. If empty, it is enabled for all space views.</value>
        [DataMember(Name = "enabledSpaceViews", EmitDefaultValue = false)]
        public List<long> EnabledSpaceViews { get; set; }

        /// <summary>
        /// Conditions allow to define criteria that a debt collection case must fulfill in order for the debt collector configuration to be considered for processing the case.
        /// </summary>
        /// <value>Conditions allow to define criteria that a debt collection case must fulfill in order for the debt collector configuration to be considered for processing the case.</value>
        [DataMember(Name = "conditions", EmitDefaultValue = false)]
        public List<DebtCollectorCondition> Conditions { get; set; }

        /// <summary>
        /// The priority that determines the order in which debt collector configurations are taken into account when processing a case. Low values are considered first.
        /// </summary>
        /// <value>The priority that determines the order in which debt collector configurations are taken into account when processing a case. Low values are considered first.</value>
        [DataMember(Name = "priority", EmitDefaultValue = false)]
        public int Priority { get; set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public int VarVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DebtCollectorConfigurationUpdate {\n");
            sb.Append("  SkipReviewEnabled: ").Append(SkipReviewEnabled).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  EnabledSpaceViews: ").Append(EnabledSpaceViews).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 100)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 100.", new [] { "Name" });
            }

            yield break;
        }
    }

}
