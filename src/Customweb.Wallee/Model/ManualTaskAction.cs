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
    /// Manual Task Action
    /// </summary>
    [DataContract]
    public partial class ManualTaskAction :  IEquatable<ManualTaskAction>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ManualTaskAction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ManualTaskAction()
        {
        }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// Label
        /// </summary>
        /// <value>Label</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public Dictionary<string, string> Label { get; private set; }

        /// <summary>
        /// Style
        /// </summary>
        /// <value>Style</value>
        [DataMember(Name="style", EmitDefaultValue=false)]
        public ManualTaskActionStyle? Style { get; private set; }

        /// <summary>
        /// TaskType
        /// </summary>
        /// <value>TaskType</value>
        [DataMember(Name="taskType", EmitDefaultValue=false)]
        public long? TaskType { get; private set; }

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
            return this.Equals(obj as ManualTaskAction);
        }

        /// <summary>
        /// Returns true if ManualTaskAction instances are equal
        /// </summary>
        /// <param name="other">Instance of ManualTaskAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManualTaskAction other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Label == other.Label ||
                    this.Label != null &&
                    this.Label.SequenceEqual(other.Label)
                ) && 
                (
                    this.Style == other.Style ||
                    this.Style != null &&
                    this.Style.Equals(other.Style)
                ) && 
                (
                    this.TaskType == other.TaskType ||
                    this.TaskType != null &&
                    this.TaskType.Equals(other.TaskType)
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
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.Label != null)
                {
                    hash = hash * 59 + this.Label.GetHashCode();
                }
                if (this.Style != null)
                {
                    hash = hash * 59 + this.Style.GetHashCode();
                }
                if (this.TaskType != null)
                {
                    hash = hash * 59 + this.TaskType.GetHashCode();
                }
                return hash;
            }
        }

    }

}
