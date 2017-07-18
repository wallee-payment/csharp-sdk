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
    public partial class WebhookListener :  IEquatable<WebhookListener>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookListener" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public WebhookListener()
        {
        }

        /// <summary>
        /// The listener listens on state changes of the entity linked with the listener.
        /// </summary>
        /// <value>The listener listens on state changes of the entity linked with the listener.</value>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public long? Entity { get; private set; }

        /// <summary>
        /// The target state identifies the state into which entities need to move into to trigger the webhook listener.
        /// </summary>
        /// <value>The target state identifies the state into which entities need to move into to trigger the webhook listener.</value>
        [DataMember(Name="entityStates", EmitDefaultValue=false)]
        public List<string> EntityStates { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The identity which will be used to sign messages sent by this listener.
        /// </summary>
        /// <value>The identity which will be used to sign messages sent by this listener.</value>
        [DataMember(Name="identity", EmitDefaultValue=false)]
        public WebhookIdentity Identity { get; private set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// The webhook listener name is used internally to identify the webhook listener in administrative interfaces.For example it is used within search fields and hence it should be distinct and descriptive.
        /// </summary>
        /// <value>The webhook listener name is used internally to identify the webhook listener in administrative interfaces.For example it is used within search fields and hence it should be distinct and descriptive.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// Defines whether the webhook listener is to be informed about every change made to the entity in contrast to state transitions only.
        /// </summary>
        /// <value>Defines whether the webhook listener is to be informed about every change made to the entity in contrast to state transitions only.</value>
        [DataMember(Name="notifyEveryChange", EmitDefaultValue=false)]
        public bool? NotifyEveryChange { get; private set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public CreationEntityState? State { get; private set; }

        /// <summary>
        /// The URL which is invoked by the listener to notify the application about the event.
        /// </summary>
        /// <value>The URL which is invoked by the listener to notify the application about the event.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public WebhookUrl Url { get; private set; }

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
            return this.Equals(obj as WebhookListener);
        }

        /// <summary>
        /// Returns true if WebhookListener instances are equal
        /// </summary>
        /// <param name="other">Instance of WebhookListener to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookListener other)
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
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Identity == other.Identity ||
                    this.Identity != null &&
                    this.Identity.Equals(other.Identity)
                ) && 
                (
                    this.LinkedSpaceId == other.LinkedSpaceId ||
                    this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(other.LinkedSpaceId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.NotifyEveryChange == other.NotifyEveryChange ||
                    this.NotifyEveryChange != null &&
                    this.NotifyEveryChange.Equals(other.NotifyEveryChange)
                ) && 
                (
                    this.PlannedPurgeDate == other.PlannedPurgeDate ||
                    this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(other.PlannedPurgeDate)
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
                if (this.Entity != null)
                {
                    hash = hash * 59 + this.Entity.GetHashCode();
                }
                if (this.EntityStates != null)
                {
                    hash = hash * 59 + this.EntityStates.GetHashCode();
                }
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.Identity != null)
                {
                    hash = hash * 59 + this.Identity.GetHashCode();
                }
                if (this.LinkedSpaceId != null)
                {
                    hash = hash * 59 + this.LinkedSpaceId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hash = hash * 59 + this.Name.GetHashCode();
                }
                if (this.NotifyEveryChange != null)
                {
                    hash = hash * 59 + this.NotifyEveryChange.GetHashCode();
                }
                if (this.PlannedPurgeDate != null)
                {
                    hash = hash * 59 + this.PlannedPurgeDate.GetHashCode();
                }
                if (this.State != null)
                {
                    hash = hash * 59 + this.State.GetHashCode();
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

    }

}
