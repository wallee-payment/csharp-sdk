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
    /// A document template contains the customizations for a particular document template type.
    /// </summary>
    [DataContract(Name = "DocumentTemplate")]
    public partial class DocumentTemplate : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public CreationEntityState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentTemplate" /> class.
        /// </summary>
        /// <param name="state">state.</param>
        /// <param name="type">type.</param>
        public DocumentTemplate(CreationEntityState? state = default(CreationEntityState?), DocumentTemplateType type = default(DocumentTemplateType))
        {
            this.State = state;
            this.Type = type;
        }

        /// <summary>
        /// Whether documents of this template should be delivered.
        /// </summary>
        /// <value>Whether documents of this template should be delivered.</value>
        [DataMember(Name = "deliveryEnabled", EmitDefaultValue = true)]
        public bool DeliveryEnabled { get; private set; }

        /// <summary>
        /// Returns false as DeliveryEnabled should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDeliveryEnabled()
        {
            return false;
        }
        /// <summary>
        /// The ID of the space this object belongs to.
        /// </summary>
        /// <value>The ID of the space this object belongs to.</value>
        [DataMember(Name = "linkedSpaceId", EmitDefaultValue = false)]
        public long LinkedSpaceId { get; private set; }

        /// <summary>
        /// Returns false as LinkedSpaceId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLinkedSpaceId()
        {
            return false;
        }
        /// <summary>
        /// The ID of the space this object belongs to.
        /// </summary>
        /// <value>The ID of the space this object belongs to.</value>
        [DataMember(Name = "spaceId", EmitDefaultValue = false)]
        public long SpaceId { get; private set; }

        /// <summary>
        /// Returns false as SpaceId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSpaceId()
        {
            return false;
        }
        /// <summary>
        /// Whether this is the default document template which is used whenever no specific template is specified for the same template type.
        /// </summary>
        /// <value>Whether this is the default document template which is used whenever no specific template is specified for the same template type.</value>
        [DataMember(Name = "defaultTemplate", EmitDefaultValue = true)]
        public bool DefaultTemplate { get; private set; }

        /// <summary>
        /// Returns false as DefaultTemplate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDefaultTemplate()
        {
            return false;
        }
        /// <summary>
        /// The name used to identify the document template.
        /// </summary>
        /// <value>The name used to identify the document template.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; private set; }

        /// <summary>
        /// Returns false as Name should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeName()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.
        /// </summary>
        /// <value>The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.</value>
        [DataMember(Name = "plannedPurgeDate", EmitDefaultValue = false)]
        public DateTime PlannedPurgeDate { get; private set; }

        /// <summary>
        /// Returns false as PlannedPurgeDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePlannedPurgeDate()
        {
            return false;
        }
        /// <summary>
        /// The resource path to a custom template to be used to generate PDF documents.
        /// </summary>
        /// <value>The resource path to a custom template to be used to generate PDF documents.</value>
        [DataMember(Name = "templateResource", EmitDefaultValue = false)]
        public string TemplateResource { get; private set; }

        /// <summary>
        /// Returns false as TemplateResource should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTemplateResource()
        {
            return false;
        }
        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public DocumentTemplateType Type { get; set; }

        /// <summary>
        /// The version is used for optimistic locking and incremented whenever the object is updated.
        /// </summary>
        /// <value>The version is used for optimistic locking and incremented whenever the object is updated.</value>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int VarVersion { get; private set; }

        /// <summary>
        /// Returns false as VarVersion should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVarVersion()
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
            sb.Append("class DocumentTemplate {\n");
            sb.Append("  DeliveryEnabled: ").Append(DeliveryEnabled).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  SpaceId: ").Append(SpaceId).Append("\n");
            sb.Append("  DefaultTemplate: ").Append(DefaultTemplate).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  TemplateResource: ").Append(TemplateResource).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
