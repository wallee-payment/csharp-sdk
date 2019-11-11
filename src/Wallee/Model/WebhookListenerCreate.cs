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
using SwaggerDateConverter = Wallee.Client.SwaggerDateConverter;

namespace Wallee.Model
{
    /// <summary>
    /// WebhookListenerCreate
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
        /// <param name="entity">The listener listens on state changes of the entity linked with the listener. (required).</param>
        /// <param name="url">The URL which is invoked by the listener to notify the application about the event. (required).</param>
        public WebhookListenerCreate(long? entity, long? url)
        {
            // to ensure "entity" is required (not null)
            if (entity == null)
            {
                throw new InvalidDataException("entity is a required property for WebhookListenerCreate and cannot be null");
            }
            this.Entity = entity;
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new InvalidDataException("url is a required property for WebhookListenerCreate and cannot be null");
            }
            this.Url = url;
        }





        /// <summary>
        /// The listener listens on state changes of the entity linked with the listener.
        /// </summary>
        /// <value>The listener listens on state changes of the entity linked with the listener.</value>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public long? Entity { get; set; }

        /// <summary>
        /// The identity which will be used to sign messages sent by this listener.
        /// </summary>
        /// <value>The identity which will be used to sign messages sent by this listener.</value>
        [DataMember(Name="identity", EmitDefaultValue=false)]
        public long? Identity { get; set; }

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
            var sb = new StringBuilder();
            sb.Append("class WebhookListenerCreate {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  EntityStates: ").Append(EntityStates).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NotifyEveryChange: ").Append(NotifyEveryChange).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  Identity: ").Append(Identity).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as WebhookListenerCreate);
        }

        /// <summary>
        /// Returns true if WebhookListenerCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookListenerCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookListenerCreate input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.EntityStates == input.EntityStates ||
                    this.EntityStates != null &&
                    this.EntityStates.SequenceEqual(input.EntityStates)
                ) && base.Equals(input) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && base.Equals(input) && 
                (
                    this.NotifyEveryChange == input.NotifyEveryChange ||
                    (this.NotifyEveryChange != null &&
                    this.NotifyEveryChange.Equals(input.NotifyEveryChange))
                ) && base.Equals(input) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && base.Equals(input) && 
                (
                    this.Entity == input.Entity ||
                    (this.Entity != null &&
                    this.Entity.Equals(input.Entity))
                ) && base.Equals(input) && 
                (
                    this.Identity == input.Identity ||
                    (this.Identity != null &&
                    this.Identity.Equals(input.Identity))
                ) && base.Equals(input) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                int hashCode = base.GetHashCode();
                if (this.EntityStates != null)
                    hashCode = hashCode * 59 + this.EntityStates.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NotifyEveryChange != null)
                    hashCode = hashCode * 59 + this.NotifyEveryChange.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Entity != null)
                    hashCode = hashCode * 59 + this.Entity.GetHashCode();
                if (this.Identity != null)
                    hashCode = hashCode * 59 + this.Identity.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                return hashCode;
            }
        }

    }

}
