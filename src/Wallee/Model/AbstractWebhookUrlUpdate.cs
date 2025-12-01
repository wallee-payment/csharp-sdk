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
    /// AbstractWebhookUrlUpdate
    /// </summary>
    [DataContract(Name = "Abstract.WebhookUrl.Update")]
    public partial class AbstractWebhookUrlUpdate : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public CreationEntityState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractWebhookUrlUpdate" /> class.
        /// </summary>
        /// <param name="name">The name used to identify the webhook URL..</param>
        /// <param name="state">state.</param>
        /// <param name="url">The actual URL where notifications about entity changes are sent to..</param>
        public AbstractWebhookUrlUpdate(string name = default, CreationEntityState? state = default, string url = default)
        {
            this.Name = name;
            this.State = state;
            this.Url = url;
        }

        /// <summary>
        /// The name used to identify the webhook URL.
        /// </summary>
        /// <value>The name used to identify the webhook URL.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The actual URL where notifications about entity changes are sent to.
        /// </summary>
        /// <value>The actual URL where notifications about entity changes are sent to.</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AbstractWebhookUrlUpdate {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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

            // Url (string) maxLength
            if (this.Url != null && this.Url.Length > 500)
            {
                yield return new ValidationResult("Invalid value for Url, length must be less than 500.", new [] { "Url" });
            }

            // Url (string) minLength
            if (this.Url != null && this.Url.Length < 9)
            {
                yield return new ValidationResult("Invalid value for Url, length must be greater than 9.", new [] { "Url" });
            }

            yield break;
        }
    }

}
