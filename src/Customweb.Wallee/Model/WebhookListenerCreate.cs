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
    /// Webhook Listener
    /// </summary>
    [DataContract]
    public partial class WebhookListenerCreate : AbstractWebhookListenerUpdate,  IEquatable<WebhookListenerCreate>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookListenerCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookListenerCreate() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookListenerCreate" /> class.
        /// </summary>
        /// <param name="Entity">The listener listens on state changes of the entity linked with the listener. (required)</param>
        /// <param name="EntityStates">The target state identifies the state into which entities need to move into to trigger the webhook listener. (required)</param>
        /// <param name="Identity">The identity which will be used to sign messages sent by this listener.</param>
        /// <param name="NotifyEveryChange">Defines whether the webhook listener is to be informed about every change made to the entity in contrast to state transitions only.</param>
        /// <param name="Url">The URL which is invoked by the listener to notify the application about the event. (required)</param>
        public WebhookListenerCreate(bool? NotifyEveryChange = default(bool?), long? Identity = default(long?), CreationEntityState? State = default(CreationEntityState?), long? Entity = default(long?), long? Url = default(long?), List<string> EntityStates = default(List<string>), string Name = default(string))
        {
            // to ensure "Entity" is required (not null)
            if (Entity == null)
            {
                throw new ArgumentNullException("Entity is a required property for WebhookListenerCreate and cannot be null");
            }
            else
            {
                this.Entity = Entity;
            }
            // to ensure "EntityStates" is required (not null)
            if (EntityStates == null)
            {
                throw new ArgumentNullException("EntityStates is a required property for WebhookListenerCreate and cannot be null");
            }
            else
            {
                this.EntityStates = EntityStates;
            }
            // to ensure "Url" is required (not null)
            if (Url == null)
            {
                throw new ArgumentNullException("Url is a required property for WebhookListenerCreate and cannot be null");
            }
            else
            {
                this.Url = Url;
            }
            this.Identity = Identity;
            this.NotifyEveryChange = NotifyEveryChange;
            this.Name = Name;
            this.State = State;
        }

        /// <summary>
        /// The listener listens on state changes of the entity linked with the listener.
        /// </summary>
        /// <value>The listener listens on state changes of the entity linked with the listener.</value>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public long? Entity { get; set; }

        /// <summary>
        /// The target state identifies the state into which entities need to move into to trigger the webhook listener.
        /// </summary>
        /// <value>The target state identifies the state into which entities need to move into to trigger the webhook listener.</value>
        [DataMember(Name="entityStates", EmitDefaultValue=false)]
        public List<string> EntityStates { get; set; }

        /// <summary>
        /// The identity which will be used to sign messages sent by this listener.
        /// </summary>
        /// <value>The identity which will be used to sign messages sent by this listener.</value>
        [DataMember(Name="identity", EmitDefaultValue=false)]
        public long? Identity { get; set; }

        /// <summary>
        /// Defines whether the webhook listener is to be informed about every change made to the entity in contrast to state transitions only.
        /// </summary>
        /// <value>Defines whether the webhook listener is to be informed about every change made to the entity in contrast to state transitions only.</value>
        [DataMember(Name="notifyEveryChange", EmitDefaultValue=false)]
        public bool? NotifyEveryChange { get; set; }

        /// <summary>
        /// The URL which is invoked by the listener to notify the application about the event.
        /// </summary>
        /// <value>The URL which is invoked by the listener to notify the application about the event.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public long? Url { get; set; }

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
        public new string ToJson()
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
            return this.Equals(obj as WebhookListenerCreate);
        }

        /// <summary>
        /// Returns true if WebhookListenerCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of WebhookListenerCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookListenerCreate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Entity == other.Entity ||
                    this.Entity != null &&
                    this.Entity.Equals(other.Entity)
                ) && 
                (
                    this.EntityStates == other.EntityStates ||
                    this.EntityStates != null &&
                    this.EntityStates.SequenceEqual(other.EntityStates)
                ) && 
                (
                    this.Identity == other.Identity ||
                    this.Identity != null &&
                    this.Identity.Equals(other.Identity)
                ) && 
                (
                    this.NotifyEveryChange == other.NotifyEveryChange ||
                    this.NotifyEveryChange != null &&
                    this.NotifyEveryChange.Equals(other.NotifyEveryChange)
                ) && 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
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
                if (this.Entity != null)
                {
                    hash = hash * 59 + this.Entity.GetHashCode();
                }
                if (this.EntityStates != null)
                {
                    hash = hash * 59 + this.EntityStates.GetHashCode();
                }
                if (this.Identity != null)
                {
                    hash = hash * 59 + this.Identity.GetHashCode();
                }
                if (this.NotifyEveryChange != null)
                {
                    hash = hash * 59 + this.NotifyEveryChange.GetHashCode();
                }
                if (this.Url != null)
                {
                    hash = hash * 59 + this.Url.GetHashCode();
                }
                if (this.Name != null)
                {
                    hash = hash * 59 + this.Name.GetHashCode();
                }
                if (this.State != null)
                {
                    hash = hash * 59 + this.State.GetHashCode();
                }
                return hash;
            }
        }

    }

}
