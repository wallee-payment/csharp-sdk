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
    /// Scope
    /// </summary>
    [DataContract(Name = "Scope")]
    public partial class Scope : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public CreationEntityState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Scope" /> class.
        /// </summary>
        /// <param name="state">state.</param>
        public Scope(CreationEntityState? state = default(CreationEntityState?))
        {
            this.State = state;
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
        /// Whether the scope supports SSL.
        /// </summary>
        /// <value>Whether the scope supports SSL.</value>
        [DataMember(Name = "sslActive", EmitDefaultValue = true)]
        public bool SslActive { get; private set; }

        /// <summary>
        /// Returns false as SslActive should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSslActive()
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
        /// The name identifying the scope in e.g. URLs.
        /// </summary>
        /// <value>The name identifying the scope in e.g. URLs.</value>
        [DataMember(Name = "machineName", EmitDefaultValue = false)]
        public string MachineName { get; private set; }

        /// <summary>
        /// Returns false as MachineName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMachineName()
        {
            return false;
        }
        /// <summary>
        /// The URL where the scope can be accessed.
        /// </summary>
        /// <value>The URL where the scope can be accessed.</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; private set; }

        /// <summary>
        /// Returns false as Url should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUrl()
        {
            return false;
        }
        /// <summary>
        /// The list of features that are active in the scope.
        /// </summary>
        /// <value>The list of features that are active in the scope.</value>
        [DataMember(Name = "features", EmitDefaultValue = false)]
        public List<Feature> Features { get; private set; }

        /// <summary>
        /// Returns false as Features should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFeatures()
        {
            return false;
        }
        /// <summary>
        /// The themes that determine the look and feel of the scope&#39;s user interface. A fall-through strategy is applied when building the actual theme.
        /// </summary>
        /// <value>The themes that determine the look and feel of the scope&#39;s user interface. A fall-through strategy is applied when building the actual theme.</value>
        [DataMember(Name = "themes", EmitDefaultValue = false)]
        public List<string> Themes { get; private set; }

        /// <summary>
        /// Returns false as Themes should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeThemes()
        {
            return false;
        }
        /// <summary>
        /// The port where the scope can be accessed.
        /// </summary>
        /// <value>The port where the scope can be accessed.</value>
        [DataMember(Name = "port", EmitDefaultValue = false)]
        public int Port { get; private set; }

        /// <summary>
        /// Returns false as Port should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePort()
        {
            return false;
        }
        /// <summary>
        /// The preprod domain name that belongs to the scope.
        /// </summary>
        /// <value>The preprod domain name that belongs to the scope.</value>
        [DataMember(Name = "preprodDomainName", EmitDefaultValue = false)]
        public string PreprodDomainName { get; private set; }

        /// <summary>
        /// Returns false as PreprodDomainName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePreprodDomainName()
        {
            return false;
        }
        /// <summary>
        /// The domain name that belongs to the scope.
        /// </summary>
        /// <value>The domain name that belongs to the scope.</value>
        [DataMember(Name = "domainName", EmitDefaultValue = false)]
        public string DomainName { get; private set; }

        /// <summary>
        /// Returns false as DomainName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDomainName()
        {
            return false;
        }
        /// <summary>
        /// The name used to identify the scope.
        /// </summary>
        /// <value>The name used to identify the scope.</value>
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
        /// The sandbox domain name that belongs to the scope.
        /// </summary>
        /// <value>The sandbox domain name that belongs to the scope.</value>
        [DataMember(Name = "sandboxDomainName", EmitDefaultValue = false)]
        public string SandboxDomainName { get; private set; }

        /// <summary>
        /// Returns false as SandboxDomainName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSandboxDomainName()
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
            sb.Append("class Scope {\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  SslActive: ").Append(SslActive).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  MachineName: ").Append(MachineName).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
            sb.Append("  Themes: ").Append(Themes).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  PreprodDomainName: ").Append(PreprodDomainName).Append("\n");
            sb.Append("  DomainName: ").Append(DomainName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  SandboxDomainName: ").Append(SandboxDomainName).Append("\n");
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
            // MachineName (string) maxLength
            if (this.MachineName != null && this.MachineName.Length > 50)
            {
                yield return new ValidationResult("Invalid value for MachineName, length must be less than 50.", new [] { "MachineName" });
            }

            if (this.MachineName != null) {
                // MachineName (string) pattern
                Regex regexMachineName = new Regex(@"([A-Z][A-Za-z0-9]+)(_([A-Z][A-Za-z0-9]+))*", RegexOptions.CultureInvariant);
                if (!regexMachineName.Match(this.MachineName).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MachineName, must match a pattern of " + regexMachineName, new [] { "MachineName" });
                }
            }

            // Port (int) minimum
            if (this.Port < (int)1)
            {
                yield return new ValidationResult("Invalid value for Port, must be a value greater than or equal to 1.", new [] { "Port" });
            }

            // PreprodDomainName (string) maxLength
            if (this.PreprodDomainName != null && this.PreprodDomainName.Length > 40)
            {
                yield return new ValidationResult("Invalid value for PreprodDomainName, length must be less than 40.", new [] { "PreprodDomainName" });
            }

            // DomainName (string) maxLength
            if (this.DomainName != null && this.DomainName.Length > 40)
            {
                yield return new ValidationResult("Invalid value for DomainName, length must be less than 40.", new [] { "DomainName" });
            }

            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 50)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 50.", new [] { "Name" });
            }

            // SandboxDomainName (string) maxLength
            if (this.SandboxDomainName != null && this.SandboxDomainName.Length > 40)
            {
                yield return new ValidationResult("Invalid value for SandboxDomainName, length must be less than 40.", new [] { "SandboxDomainName" });
            }

            yield break;
        }
    }

}
