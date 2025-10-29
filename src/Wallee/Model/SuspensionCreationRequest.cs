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
    /// SuspensionCreationRequest
    /// </summary>
    [DataContract(Name = "SuspensionCreationRequest")]
    public partial class SuspensionCreationRequest : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets EndAction
        /// </summary>
        [DataMember(Name = "endAction", EmitDefaultValue = false)]
        public SubscriptionSuspensionAction? EndAction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SuspensionCreationRequest" /> class.
        /// </summary>
        /// <param name="note">A note that contains details about the suspension. It is not disclosed to the subscriber..</param>
        /// <param name="endAction">endAction.</param>
        /// <param name="plannedEndDate">The date and time when the suspension is planned to end..</param>
        public SuspensionCreationRequest(string note = default(string), SubscriptionSuspensionAction? endAction = default(SubscriptionSuspensionAction?), DateTime plannedEndDate = default(DateTime))
        {
            this.Note = note;
            this.EndAction = endAction;
            this.PlannedEndDate = plannedEndDate;
        }

        /// <summary>
        /// A note that contains details about the suspension. It is not disclosed to the subscriber.
        /// </summary>
        /// <value>A note that contains details about the suspension. It is not disclosed to the subscriber.</value>
        [DataMember(Name = "note", EmitDefaultValue = false)]
        public string Note { get; set; }

        /// <summary>
        /// The date and time when the suspension is planned to end.
        /// </summary>
        /// <value>The date and time when the suspension is planned to end.</value>
        [DataMember(Name = "plannedEndDate", EmitDefaultValue = false)]
        public DateTime PlannedEndDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SuspensionCreationRequest {\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  EndAction: ").Append(EndAction).Append("\n");
            sb.Append("  PlannedEndDate: ").Append(PlannedEndDate).Append("\n");
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
            // Note (string) maxLength
            if (this.Note != null && this.Note.Length > 300)
            {
                yield return new ValidationResult("Invalid value for Note, length must be less than 300.", new [] { "Note" });
            }

            yield break;
        }
    }

}
