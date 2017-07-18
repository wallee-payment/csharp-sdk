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
    /// Document Template Type
    /// </summary>
    [DataContract]
    public partial class DocumentTemplateType :  IEquatable<DocumentTemplateType>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentTemplateType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public DocumentTemplateType()
        {
        }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public Dictionary<string, string> Description { get; private set; }

        /// <summary>
        /// Feature
        /// </summary>
        /// <value>Feature</value>
        [DataMember(Name="feature", EmitDefaultValue=false)]
        public long? Feature { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// TemplateResource
        /// </summary>
        /// <value>TemplateResource</value>
        [DataMember(Name="templateResource", EmitDefaultValue=false)]
        public string TemplateResource { get; private set; }

        /// <summary>
        /// Title
        /// </summary>
        /// <value>Title</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public Dictionary<string, string> Title { get; private set; }

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
            return this.Equals(obj as DocumentTemplateType);
        }

        /// <summary>
        /// Returns true if DocumentTemplateType instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentTemplateType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentTemplateType other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.SequenceEqual(other.Description)
                ) && 
                (
                    this.Feature == other.Feature ||
                    this.Feature != null &&
                    this.Feature.Equals(other.Feature)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.TemplateResource == other.TemplateResource ||
                    this.TemplateResource != null &&
                    this.TemplateResource.Equals(other.TemplateResource)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.SequenceEqual(other.Title)
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
                if (this.Description != null)
                {
                    hash = hash * 59 + this.Description.GetHashCode();
                }
                if (this.Feature != null)
                {
                    hash = hash * 59 + this.Feature.GetHashCode();
                }
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.TemplateResource != null)
                {
                    hash = hash * 59 + this.TemplateResource.GetHashCode();
                }
                if (this.Title != null)
                {
                    hash = hash * 59 + this.Title.GetHashCode();
                }
                return hash;
            }
        }

    }

}
