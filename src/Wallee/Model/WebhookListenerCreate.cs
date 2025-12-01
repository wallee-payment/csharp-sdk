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
    /// WebhookListenerCreate
    /// </summary>
    [DataContract(Name = "WebhookListener.Create")]
    public partial class WebhookListenerCreate : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public CreationEntityState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookListenerCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookListenerCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookListenerCreate" /> class.
        /// </summary>
        /// <param name="entityStates">The entity&#39;s target states that are to be monitored..</param>
        /// <param name="name">The name used to identify the webhook listener..</param>
        /// <param name="state">state.</param>
        /// <param name="notifyEveryChange">Whether every update of the entity or only state changes are to be monitored..</param>
        /// <param name="identity">The identity used to sign messages..</param>
        /// <param name="entity">The entity that is to be monitored. (required).</param>
        /// <param name="url">The URL where notifications about entity changes are sent to. (required).</param>
        public WebhookListenerCreate(List<string> entityStates = default, string name = default, CreationEntityState? state = default, bool notifyEveryChange = default, long identity = default, long entity = default, long url = default)
        {
            this.Entity = entity;
            this.Url = url;
            this.EntityStates = entityStates;
            this.Name = name;
            this.State = state;
            this.NotifyEveryChange = notifyEveryChange;
            this.Identity = identity;
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
        /// The identity used to sign messages.
        /// </summary>
        /// <value>The identity used to sign messages.</value>
        [DataMember(Name = "identity", EmitDefaultValue = false)]
        public long Identity { get; set; }

        /// <summary>
        /// The entity that is to be monitored.
        /// </summary>
        /// <value>The entity that is to be monitored.</value>
        [DataMember(Name = "entity", IsRequired = true, EmitDefaultValue = true)]
        public long Entity { get; set; }

        /// <summary>
        /// The URL where notifications about entity changes are sent to.
        /// </summary>
        /// <value>The URL where notifications about entity changes are sent to.</value>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = true)]
        public long Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebhookListenerCreate {\n");
            sb.Append("  EntityStates: ").Append(EntityStates).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  NotifyEveryChange: ").Append(NotifyEveryChange).Append("\n");
            sb.Append("  Identity: ").Append(Identity).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
