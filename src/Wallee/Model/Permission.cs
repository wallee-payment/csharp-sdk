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
    /// Permission
    /// </summary>
    [DataContract(Name = "Permission")]
    public partial class Permission : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Permission" /> class.
        /// </summary>
        /// <param name="feature">feature.</param>
        public Permission(Feature feature = default(Feature))
        {
            this.Feature = feature;
        }

        /// <summary>
        /// The group that this permission belongs to.
        /// </summary>
        /// <value>The group that this permission belongs to.</value>
        [DataMember(Name = "parent", EmitDefaultValue = false)]
        public long Parent { get; private set; }

        /// <summary>
        /// Returns false as Parent should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeParent()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Feature
        /// </summary>
        [DataMember(Name = "feature", EmitDefaultValue = false)]
        public Feature Feature { get; set; }

        /// <summary>
        /// The localized name of the object.
        /// </summary>
        /// <value>The localized name of the object.</value>
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
        /// All parents of this permission up to the root of the permission tree.
        /// </summary>
        /// <value>All parents of this permission up to the root of the permission tree.</value>
        [DataMember(Name = "pathToRoot", EmitDefaultValue = false)]
        public List<long> PathToRoot { get; private set; }

        /// <summary>
        /// Returns false as PathToRoot should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePathToRoot()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets WebAppEnabled
        /// </summary>
        [DataMember(Name = "webAppEnabled", EmitDefaultValue = true)]
        public bool WebAppEnabled { get; private set; }

        /// <summary>
        /// Returns false as WebAppEnabled should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeWebAppEnabled()
        {
            return false;
        }
        /// <summary>
        /// The localized description of the object.
        /// </summary>
        /// <value>The localized description of the object.</value>
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
        /// Whether this is a leaf in the tree of permissions, and not a group.
        /// </summary>
        /// <value>Whether this is a leaf in the tree of permissions, and not a group.</value>
        [DataMember(Name = "leaf", EmitDefaultValue = true)]
        public bool Leaf { get; private set; }

        /// <summary>
        /// Returns false as Leaf should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLeaf()
        {
            return false;
        }
        /// <summary>
        /// The localized name of the object.
        /// </summary>
        /// <value>The localized name of the object.</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public Dictionary<string, string> Title { get; private set; }

        /// <summary>
        /// Returns false as Title should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTitle()
        {
            return false;
        }
        /// <summary>
        /// Whether this is a permission group.
        /// </summary>
        /// <value>Whether this is a permission group.</value>
        [DataMember(Name = "group", EmitDefaultValue = true)]
        public bool Group { get; private set; }

        /// <summary>
        /// Returns false as Group should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeGroup()
        {
            return false;
        }
        /// <summary>
        /// Whether users with this permission are required to enable two-factor authentication.
        /// </summary>
        /// <value>Whether users with this permission are required to enable two-factor authentication.</value>
        [DataMember(Name = "twoFactorRequired", EmitDefaultValue = true)]
        public bool TwoFactorRequired { get; private set; }

        /// <summary>
        /// Returns false as TwoFactorRequired should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTwoFactorRequired()
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
            sb.Append("class Permission {\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  Feature: ").Append(Feature).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PathToRoot: ").Append(PathToRoot).Append("\n");
            sb.Append("  WebAppEnabled: ").Append(WebAppEnabled).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Leaf: ").Append(Leaf).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  TwoFactorRequired: ").Append(TwoFactorRequired).Append("\n");
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
