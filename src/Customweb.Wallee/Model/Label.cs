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
    /// Label
    /// </summary>
    [DataContract]
    public partial class Label :  IEquatable<Label>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Label" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Label()
        {
        }

        /// <summary>
        /// Content
        /// </summary>
        /// <value>Content</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public Object Content { get; private set; }

        /// <summary>
        /// ContentAsString
        /// </summary>
        /// <value>ContentAsString</value>
        [DataMember(Name="contentAsString", EmitDefaultValue=false)]
        public string ContentAsString { get; private set; }

        /// <summary>
        /// Descriptor
        /// </summary>
        /// <value>Descriptor</value>
        [DataMember(Name="descriptor", EmitDefaultValue=false)]
        public LabelDescriptor Descriptor { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

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
            return this.Equals(obj as Label);
        }

        /// <summary>
        /// Returns true if Label instances are equal
        /// </summary>
        /// <param name="other">Instance of Label to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Label other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.Equals(other.Content)
                ) && 
                (
                    this.ContentAsString == other.ContentAsString ||
                    this.ContentAsString != null &&
                    this.ContentAsString.Equals(other.ContentAsString)
                ) && 
                (
                    this.Descriptor == other.Descriptor ||
                    this.Descriptor != null &&
                    this.Descriptor.Equals(other.Descriptor)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                if (this.Content != null)
                {
                    hash = hash * 59 + this.Content.GetHashCode();
                }
                if (this.ContentAsString != null)
                {
                    hash = hash * 59 + this.ContentAsString.GetHashCode();
                }
                if (this.Descriptor != null)
                {
                    hash = hash * 59 + this.Descriptor.GetHashCode();
                }
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.Version != null)
                {
                    hash = hash * 59 + this.Version.GetHashCode();
                }
                return hash;
            }
        }

    }

}
