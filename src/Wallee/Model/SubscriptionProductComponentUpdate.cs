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
    /// SubscriptionProductComponentUpdate
    /// </summary>
    [DataContract(Name = "SubscriptionProductComponent.Update")]
    public partial class SubscriptionProductComponentUpdate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductComponentUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionProductComponentUpdate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductComponentUpdate" /> class.
        /// </summary>
        /// <param name="reference">The reference is used to link components across different product versions..</param>
        /// <param name="taxClass">The tax class to be applied to fees..</param>
        /// <param name="quantityStep">The quantity step determines the interval in which the quantity can be increased..</param>
        /// <param name="sortOrder">When listing components, they can be sorted by this number..</param>
        /// <param name="componentGroup">The group that the component belongs to..</param>
        /// <param name="name">The localized name of the component that is displayed to the customer..</param>
        /// <param name="description">The localized description of the component that is displayed to the customer..</param>
        /// <param name="componentChangeWeight">If switching from a component with a lower tier to a component with a higher one, this is considered an upgrade and a fee may be applied..</param>
        /// <param name="varVersion">The version number indicates the version of the entity. The version is incremented whenever the entity is changed. (required).</param>
        /// <param name="maximalQuantity">A maximum of the defined quantity can be selected for this component..</param>
        /// <param name="defaultComponent">Whether this is the default component in its group and preselected..</param>
        /// <param name="minimalQuantity">A minimum of the defined quantity must be selected for this component..</param>
        public SubscriptionProductComponentUpdate(long reference = default, long taxClass = default, decimal quantityStep = default, int sortOrder = default, long componentGroup = default, Dictionary<string, string> name = default, Dictionary<string, string> description = default, int componentChangeWeight = default, int varVersion = default, decimal maximalQuantity = default, bool defaultComponent = default, decimal minimalQuantity = default)
        {
            this.VarVersion = varVersion;
            this.Reference = reference;
            this.TaxClass = taxClass;
            this.QuantityStep = quantityStep;
            this.SortOrder = sortOrder;
            this.ComponentGroup = componentGroup;
            this.Name = name;
            this.Description = description;
            this.ComponentChangeWeight = componentChangeWeight;
            this.MaximalQuantity = maximalQuantity;
            this.DefaultComponent = defaultComponent;
            this.MinimalQuantity = minimalQuantity;
        }

        /// <summary>
        /// The reference is used to link components across different product versions.
        /// </summary>
        /// <value>The reference is used to link components across different product versions.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public long Reference { get; set; }

        /// <summary>
        /// The tax class to be applied to fees.
        /// </summary>
        /// <value>The tax class to be applied to fees.</value>
        [DataMember(Name = "taxClass", EmitDefaultValue = false)]
        public long TaxClass { get; set; }

        /// <summary>
        /// The quantity step determines the interval in which the quantity can be increased.
        /// </summary>
        /// <value>The quantity step determines the interval in which the quantity can be increased.</value>
        [DataMember(Name = "quantityStep", EmitDefaultValue = false)]
        public decimal QuantityStep { get; set; }

        /// <summary>
        /// When listing components, they can be sorted by this number.
        /// </summary>
        /// <value>When listing components, they can be sorted by this number.</value>
        [DataMember(Name = "sortOrder", EmitDefaultValue = false)]
        public int SortOrder { get; set; }

        /// <summary>
        /// The group that the component belongs to.
        /// </summary>
        /// <value>The group that the component belongs to.</value>
        [DataMember(Name = "componentGroup", EmitDefaultValue = false)]
        public long ComponentGroup { get; set; }

        /// <summary>
        /// The localized name of the component that is displayed to the customer.
        /// </summary>
        /// <value>The localized name of the component that is displayed to the customer.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public Dictionary<string, string> Name { get; set; }

        /// <summary>
        /// The localized description of the component that is displayed to the customer.
        /// </summary>
        /// <value>The localized description of the component that is displayed to the customer.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public Dictionary<string, string> Description { get; set; }

        /// <summary>
        /// If switching from a component with a lower tier to a component with a higher one, this is considered an upgrade and a fee may be applied.
        /// </summary>
        /// <value>If switching from a component with a lower tier to a component with a higher one, this is considered an upgrade and a fee may be applied.</value>
        [DataMember(Name = "componentChangeWeight", EmitDefaultValue = false)]
        public int ComponentChangeWeight { get; set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public int VarVersion { get; set; }

        /// <summary>
        /// A maximum of the defined quantity can be selected for this component.
        /// </summary>
        /// <value>A maximum of the defined quantity can be selected for this component.</value>
        [DataMember(Name = "maximalQuantity", EmitDefaultValue = false)]
        public decimal MaximalQuantity { get; set; }

        /// <summary>
        /// Whether this is the default component in its group and preselected.
        /// </summary>
        /// <value>Whether this is the default component in its group and preselected.</value>
        [DataMember(Name = "defaultComponent", EmitDefaultValue = true)]
        public bool DefaultComponent { get; set; }

        /// <summary>
        /// A minimum of the defined quantity must be selected for this component.
        /// </summary>
        /// <value>A minimum of the defined quantity must be selected for this component.</value>
        [DataMember(Name = "minimalQuantity", EmitDefaultValue = false)]
        public decimal MinimalQuantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscriptionProductComponentUpdate {\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  TaxClass: ").Append(TaxClass).Append("\n");
            sb.Append("  QuantityStep: ").Append(QuantityStep).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  ComponentGroup: ").Append(ComponentGroup).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ComponentChangeWeight: ").Append(ComponentChangeWeight).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  MaximalQuantity: ").Append(MaximalQuantity).Append("\n");
            sb.Append("  DefaultComponent: ").Append(DefaultComponent).Append("\n");
            sb.Append("  MinimalQuantity: ").Append(MinimalQuantity).Append("\n");
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
