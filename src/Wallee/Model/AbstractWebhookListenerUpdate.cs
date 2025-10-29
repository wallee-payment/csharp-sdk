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
    /// AbstractWebhookListenerUpdate
    /// </summary>
    [DataContract(Name = "Abstract.WebhookListener.Update")]
    public partial class AbstractWebhookListenerUpdate : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public CreationEntityState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractWebhookListenerUpdate" /> class.
        /// </summary>
        /// <param name="entityStates">The entity&#39;s target states that are to be monitored..</param>
        /// <param name="name">The name used to identify the webhook listener..</param>
        /// <param name="state">state.</param>
        /// <param name="notifyEveryChange">Whether every update of the entity or only state changes are to be monitored..</param>
        public AbstractWebhookListenerUpdate(List<string> entityStates = default(List<string>), string name = default(string), CreationEntityState? state = default(CreationEntityState?), bool notifyEveryChange = default(bool))
        {
            this.EntityStates = entityStates;
            this.Name = name;
            this.State = state;
            this.NotifyEveryChange = notifyEveryChange;
        }

        /// <summary>
        /// The entity&#39;s target states that are to be monitored.
        /// </summary>
        /// <value>The entity&#39;s target states that are to be monitored.</value>
        [DataMember(Name = "entityStates", EmitDefaultValue = false)]
        public List<string> EntityStates { get; set; }

        /// <summary>
        /// The name used to identify the webhook listener.
        /// </summary>
        /// <value>The name used to identify the webhook listener.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Whether every update of the entity or only state changes are to be monitored.
        /// </summary>
        /// <value>Whether every update of the entity or only state changes are to be monitored.</value>
        [DataMember(Name = "notifyEveryChange", EmitDefaultValue = true)]
        public bool NotifyEveryChange { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AbstractWebhookListenerUpdate {\n");
            sb.Append("  EntityStates: ").Append(EntityStates).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  NotifyEveryChange: ").Append(NotifyEveryChange).Append("\n");
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
            if (this.Name != null && this.Name.Length > 50)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 50.", new [] { "Name" });
            }

            yield break;
        }
    }

}
