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
    /// SubscriptionProductComponent
    /// </summary>
    [DataContract(Name = "SubscriptionProductComponent")]
    public partial class SubscriptionProductComponent : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductComponent" /> class.
        /// </summary>
        /// <param name="taxClass">taxClass.</param>
        /// <param name="reference">reference.</param>
        /// <param name="componentGroup">componentGroup.</param>
        public SubscriptionProductComponent(TaxClass taxClass = default, SubscriptionProductComponentReference reference = default, SubscriptionProductComponentGroup componentGroup = default)
        {
            this.TaxClass = taxClass;
            this.Reference = reference;
            this.ComponentGroup = componentGroup;
        }

        /// <summary>
        /// Gets or Sets TaxClass
        /// </summary>
        [DataMember(Name = "taxClass", EmitDefaultValue = false)]
        public TaxClass TaxClass { get; set; }

        /// <summary>
        /// The localized description of the component that is displayed to the customer.
        /// </summary>
        /// <value>The localized description of the component that is displayed to the customer.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public Dictionary<string, string> Description { get; private set; }

        /// <summary>
        /// Returns false as Description should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDescription()
        {
            return false;
        }
        /// <summary>
        /// If switching from a component with a lower tier to a component with a higher one, this is considered an upgrade and a fee may be applied.
        /// </summary>
        /// <value>If switching from a component with a lower tier to a component with a higher one, this is considered an upgrade and a fee may be applied.</value>
        [DataMember(Name = "componentChangeWeight", EmitDefaultValue = false)]
        public int ComponentChangeWeight { get; private set; }

        /// <summary>
        /// Returns false as ComponentChangeWeight should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeComponentChangeWeight()
        {
            return false;
        }
        /// <summary>
        /// A maximum of the defined quantity can be selected for this component.
        /// </summary>
        /// <value>A maximum of the defined quantity can be selected for this component.</value>
        [DataMember(Name = "maximalQuantity", EmitDefaultValue = false)]
        public decimal MaximalQuantity { get; private set; }

        /// <summary>
        /// Returns false as MaximalQuantity should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMaximalQuantity()
        {
            return false;
        }
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
        /// A minimum of the defined quantity must be selected for this component.
        /// </summary>
        /// <value>A minimum of the defined quantity must be selected for this component.</value>
        [DataMember(Name = "minimalQuantity", EmitDefaultValue = false)]
        public decimal MinimalQuantity { get; private set; }

        /// <summary>
        /// Returns false as MinimalQuantity should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMinimalQuantity()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public SubscriptionProductComponentReference Reference { get; set; }

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
        /// The quantity step determines the interval in which the quantity can be increased.
        /// </summary>
        /// <value>The quantity step determines the interval in which the quantity can be increased.</value>
        [DataMember(Name = "quantityStep", EmitDefaultValue = false)]
        public decimal QuantityStep { get; private set; }

        /// <summary>
        /// Returns false as QuantityStep should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeQuantityStep()
        {
            return false;
        }
        /// <summary>
        /// When listing components, they can be sorted by this number.
        /// </summary>
        /// <value>When listing components, they can be sorted by this number.</value>
        [DataMember(Name = "sortOrder", EmitDefaultValue = false)]
        public int SortOrder { get; private set; }

        /// <summary>
        /// Returns false as SortOrder should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSortOrder()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ComponentGroup
        /// </summary>
        [DataMember(Name = "componentGroup", EmitDefaultValue = false)]
        public SubscriptionProductComponentGroup ComponentGroup { get; set; }

        /// <summary>
        /// The localized name of the component that is displayed to the customer.
        /// </summary>
        /// <value>The localized name of the component that is displayed to the customer.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public Dictionary<string, string> Name { get; private set; }

        /// <summary>
        /// Returns false as Name should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeName()
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
        /// Whether this is the default component in its group and preselected.
        /// </summary>
        /// <value>Whether this is the default component in its group and preselected.</value>
        [DataMember(Name = "defaultComponent", EmitDefaultValue = true)]
        public bool DefaultComponent { get; private set; }

        /// <summary>
        /// Returns false as DefaultComponent should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDefaultComponent()
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
            sb.Append("class SubscriptionProductComponent {\n");
            sb.Append("  TaxClass: ").Append(TaxClass).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ComponentChangeWeight: ").Append(ComponentChangeWeight).Append("\n");
            sb.Append("  MaximalQuantity: ").Append(MaximalQuantity).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  MinimalQuantity: ").Append(MinimalQuantity).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  QuantityStep: ").Append(QuantityStep).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  ComponentGroup: ").Append(ComponentGroup).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DefaultComponent: ").Append(DefaultComponent).Append("\n");
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
