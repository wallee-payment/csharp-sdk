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
    /// SubscriptionProductComponentGroupUpdate
    /// </summary>
    [DataContract(Name = "SubscriptionProductComponentGroup.Update")]
    public partial class SubscriptionProductComponentGroupUpdate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductComponentGroupUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionProductComponentGroupUpdate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductComponentGroupUpdate" /> class.
        /// </summary>
        /// <param name="productVersion">The product version that the component group belongs to..</param>
        /// <param name="sortOrder">When listing component groups, they can be sorted by this number..</param>
        /// <param name="name">The localized name of the component group that is displayed to the customer..</param>
        /// <param name="optional">Whether the component group is optional, i.e. the customer does not have to select any component..</param>
        /// <param name="varVersion">The version number indicates the version of the entity. The version is incremented whenever the entity is changed. (required).</param>
        public SubscriptionProductComponentGroupUpdate(long productVersion = default(long), int sortOrder = default(int), Dictionary<string, string> name = default(Dictionary<string, string>), bool optional = default(bool), int varVersion = default(int))
        {
            this.VarVersion = varVersion;
            this.ProductVersion = productVersion;
            this.SortOrder = sortOrder;
            this.Name = name;
            this.Optional = optional;
        }

        /// <summary>
        /// The product version that the component group belongs to.
        /// </summary>
        /// <value>The product version that the component group belongs to.</value>
        [DataMember(Name = "productVersion", EmitDefaultValue = false)]
        public long ProductVersion { get; set; }

        /// <summary>
        /// When listing component groups, they can be sorted by this number.
        /// </summary>
        /// <value>When listing component groups, they can be sorted by this number.</value>
        [DataMember(Name = "sortOrder", EmitDefaultValue = false)]
        public int SortOrder { get; set; }

        /// <summary>
        /// The localized name of the component group that is displayed to the customer.
        /// </summary>
        /// <value>The localized name of the component group that is displayed to the customer.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public Dictionary<string, string> Name { get; set; }

        /// <summary>
        /// Whether the component group is optional, i.e. the customer does not have to select any component.
        /// </summary>
        /// <value>Whether the component group is optional, i.e. the customer does not have to select any component.</value>
        [DataMember(Name = "optional", EmitDefaultValue = true)]
        public bool Optional { get; set; }

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
            sb.Append("class SubscriptionProductComponentGroupUpdate {\n");
            sb.Append("  ProductVersion: ").Append(ProductVersion).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Optional: ").Append(Optional).Append("\n");
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
            yield break;
        }
    }

}
