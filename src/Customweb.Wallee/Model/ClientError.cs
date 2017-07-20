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
    /// An error that is returned as the result of a bad user request or a misconfiguration.
    /// </summary>
    [DataContract]
    public partial class ClientError :  IEquatable<ClientError>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ClientError()
        {
        }

        /// <summary>
        /// Date when an error has occurred.
        /// </summary>
        /// <value>Date when an error has occurred.</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public string Date { get; private set; }

        /// <summary>
        /// The error message which is translated into the default language (i.e. English).
        /// </summary>
        /// <value>The error message which is translated into the default language (i.e. English).</value>
        [DataMember(Name="defaultMessage", EmitDefaultValue=false)]
        public string DefaultMessage { get; private set; }

        /// <summary>
        /// Unique identifier of an error.
        /// </summary>
        /// <value>Unique identifier of an error.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }

        /// <summary>
        /// The error message which is translated in into the language of the client.
        /// </summary>
        /// <value>The error message which is translated in into the language of the client.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; private set; }

        /// <summary>
        /// The type of the client error.
        /// </summary>
        /// <value>The type of the client error.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public ClientErrorType? Type { get; private set; }

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
            return this.Equals(obj as ClientError);
        }

        /// <summary>
        /// Returns true if ClientError instances are equal
        /// </summary>
        /// <param name="other">Instance of ClientError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientError other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
                ) && 
                (
                    this.DefaultMessage == other.DefaultMessage ||
                    this.DefaultMessage != null &&
                    this.DefaultMessage.Equals(other.DefaultMessage)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.Date != null)
                {
                    hash = hash * 59 + this.Date.GetHashCode();
                }
                if (this.DefaultMessage != null)
                {
                    hash = hash * 59 + this.DefaultMessage.GetHashCode();
                }
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.Message != null)
                {
                    hash = hash * 59 + this.Message.GetHashCode();
                }
                if (this.Type != null)
                {
                    hash = hash * 59 + this.Type.GetHashCode();
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
