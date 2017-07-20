/**
 * Wallee SDK Client
 *
 * This client allows to interact with the Wallee API.
 *
 * Wallee API: 1.0.0
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Scope
    /// </summary>
    [DataContract]
    public partial class Scope :  IEquatable<Scope>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Scope" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Scope()
        {
        }

        /// <summary>
        /// The domain name to which this scope is mapped to.
        /// </summary>
        /// <value>The domain name to which this scope is mapped to.</value>
        [DataMember(Name="domainName", EmitDefaultValue=false)]
        public string DomainName { get; private set; }

        /// <summary>
        /// Features
        /// </summary>
        /// <value>Features</value>
        [DataMember(Name="features", EmitDefaultValue=false)]
        public List<Feature> Features { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The name of the scope is shown to the user where the user should select a scope.
        /// </summary>
        /// <value>The name of the scope is shown to the user where the user should select a scope.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// The port number to which this scope is mapped to.
        /// </summary>
        /// <value>The port number to which this scope is mapped to.</value>
        [DataMember(Name="port", EmitDefaultValue=false)]
        public int? Port { get; private set; }

        /// <summary>
        /// Define whether the scope supports SSL.
        /// </summary>
        /// <value>Define whether the scope supports SSL.</value>
        [DataMember(Name="sslActive", EmitDefaultValue=false)]
        public bool? SslActive { get; private set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public CreationEntityState? State { get; private set; }

        /// <summary>
        /// The themes determines how the application layout, look and feel is. By providing multiple themes you can fallback to other themes.
        /// </summary>
        /// <value>The themes determines how the application layout, look and feel is. By providing multiple themes you can fallback to other themes.</value>
        [DataMember(Name="themes", EmitDefaultValue=false)]
        public List<string> Themes { get; private set; }

        /// <summary>
        /// Url
        /// </summary>
        /// <value>Url</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; private set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return this.ToJson();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            return this.Equals(obj as Scope);
        }

        /// <summary>
        /// Returns true if Scope instances are equal
        /// </summary>
        /// <param name="other">Instance of Scope to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Scope other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.DomainName == other.DomainName ||
                    this.DomainName != null &&
                    this.DomainName.Equals(other.DomainName)
                ) && 
                (
                    this.Features == other.Features ||
                    this.Features != null &&
                    this.Features.SequenceEqual(other.Features)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.PlannedPurgeDate == other.PlannedPurgeDate ||
                    this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(other.PlannedPurgeDate)
                ) && 
                (
                    this.Port == other.Port ||
                    this.Port != null &&
                    this.Port.Equals(other.Port)
                ) && 
                (
                    this.SslActive == other.SslActive ||
                    this.SslActive != null &&
                    this.SslActive.Equals(other.SslActive)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Themes == other.Themes ||
                    this.Themes != null &&
                    this.Themes.SequenceEqual(other.Themes)
                ) && 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                if (this.DomainName != null)
                {
                    hash = hash * 59 + this.DomainName.GetHashCode();
                }
                if (this.Features != null)
                {
                    hash = hash * 59 + this.Features.GetHashCode();
                }
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hash = hash * 59 + this.Name.GetHashCode();
                }
                if (this.PlannedPurgeDate != null)
                {
                    hash = hash * 59 + this.PlannedPurgeDate.GetHashCode();
                }
                if (this.Port != null)
                {
                    hash = hash * 59 + this.Port.GetHashCode();
                }
                if (this.SslActive != null)
                {
                    hash = hash * 59 + this.SslActive.GetHashCode();
                }
                if (this.State != null)
                {
                    hash = hash * 59 + this.State.GetHashCode();
                }
                if (this.Themes != null)
                {
                    hash = hash * 59 + this.Themes.GetHashCode();
                }
                if (this.Url != null)
                {
                    hash = hash * 59 + this.Url.GetHashCode();
                }
                if (this.Version != null)
                {
                    hash = hash * 59 + this.Version.GetHashCode();
                }
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
