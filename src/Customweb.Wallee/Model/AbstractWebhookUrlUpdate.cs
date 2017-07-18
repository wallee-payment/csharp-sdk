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
    /// Abstract Webhook URL
    /// </summary>
    [DataContract]
    public partial class AbstractWebhookUrlUpdate :  IEquatable<AbstractWebhookUrlUpdate>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractWebhookUrlUpdate" /> class.
        /// </summary>
        /// <param name="Name">The URL name is used internally to identify the URL in administrative interfaces. For example it is used within search fields and hence it should be distinct and descriptive.</param>
        /// <param name="State">State</param>
        /// <param name="Url">The URL to which the HTTP requests are sent to. An example URL could look like https://www.example.com/some/path?some-query-parameter&#x3D;value.</param>
        public AbstractWebhookUrlUpdate(CreationEntityState? State = default(CreationEntityState?), string Name = default(string), string Url = default(string))
        {
            this.Name = Name;
            this.State = State;
            this.Url = Url;
        }

        /// <summary>
        /// The URL name is used internally to identify the URL in administrative interfaces. For example it is used within search fields and hence it should be distinct and descriptive.
        /// </summary>
        /// <value>The URL name is used internally to identify the URL in administrative interfaces. For example it is used within search fields and hence it should be distinct and descriptive.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public CreationEntityState? State { get; set; }

        /// <summary>
        /// The URL to which the HTTP requests are sent to. An example URL could look like https://www.example.com/some/path?some-query-parameter&#x3D;value.
        /// </summary>
        /// <value>The URL to which the HTTP requests are sent to. An example URL could look like https://www.example.com/some/path?some-query-parameter&#x3D;value.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

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
            return this.Equals(obj as AbstractWebhookUrlUpdate);
        }

        /// <summary>
        /// Returns true if AbstractWebhookUrlUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of AbstractWebhookUrlUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbstractWebhookUrlUpdate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
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
                if (this.Name != null)
                {
                    hash = hash * 59 + this.Name.GetHashCode();
                }
                if (this.State != null)
                {
                    hash = hash * 59 + this.State.GetHashCode();
                }
                if (this.Url != null)
                {
                    hash = hash * 59 + this.Url.GetHashCode();
                }
                return hash;
            }
        }

    }

}
