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
    /// AbstractWebhookListenerUpdate
    /// </summary>
    [DataContract]
    public partial class AbstractWebhookListenerUpdate :  IEquatable<AbstractWebhookListenerUpdate>
    {
        /// <summary>
        /// The object&#39;s current state.
        /// </summary>
        /// <value>The object&#39;s current state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public CreationEntityState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractWebhookListenerUpdate" /> class.
        /// </summary>
        public AbstractWebhookListenerUpdate()
        {
        }

        /// <summary>
        /// The target state identifies the state into which entities need to move into to trigger the webhook listener.
        /// </summary>
        /// <value>The target state identifies the state into which entities need to move into to trigger the webhook listener.</value>
        [DataMember(Name="entityStates", EmitDefaultValue=false)]
        public List<string> EntityStates { get; set; }

        /// <summary>
        /// The webhook listener name is used internally to identify the webhook listener in administrative interfaces.For example it is used within search fields and hence it should be distinct and descriptive.
        /// </summary>
        /// <value>The webhook listener name is used internally to identify the webhook listener in administrative interfaces.For example it is used within search fields and hence it should be distinct and descriptive.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Defines whether the webhook listener is to be informed about every change made to the entity in contrast to state transitions only.
        /// </summary>
        /// <value>Defines whether the webhook listener is to be informed about every change made to the entity in contrast to state transitions only.</value>
        [DataMember(Name="notifyEveryChange", EmitDefaultValue=false)]
        public bool? NotifyEveryChange { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AbstractWebhookListenerUpdate {\n");
            sb.Append("  EntityStates: ").Append(EntityStates).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NotifyEveryChange: ").Append(NotifyEveryChange).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AbstractWebhookListenerUpdate);
        }

        /// <summary>
        /// Returns true if AbstractWebhookListenerUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of AbstractWebhookListenerUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbstractWebhookListenerUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EntityStates == input.EntityStates ||
                    this.EntityStates != null &&
                    input.EntityStates != null &&
                    this.EntityStates.SequenceEqual(input.EntityStates)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NotifyEveryChange == input.NotifyEveryChange ||
                    (this.NotifyEveryChange != null &&
                    this.NotifyEveryChange.Equals(input.NotifyEveryChange))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                int hashCode = 41;
                if (this.EntityStates != null)
                    hashCode = hashCode * 59 + this.EntityStates.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NotifyEveryChange != null)
                    hashCode = hashCode * 59 + this.NotifyEveryChange.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                return hashCode;
            }
        }

    }

}
