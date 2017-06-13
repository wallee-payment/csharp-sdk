
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
    /// WebhookListenerEntity model.
    /// </summary>
    [DataContract]
    public partial class WebhookListenerEntity :  IEquatable<WebhookListenerEntity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookListenerEntity" /> class.
        /// </summary>
        /// <param name="Id">The ID is the primary key of the entity. The ID identifies the entity uniquely.</param>
        /// <param name="Name">Name</param>
        /// <param name="TechnicalName">TechnicalName</param>
        public WebhookListenerEntity(long? Id = default(long?), Dictionary<string, string> Name = default(Dictionary<string, string>), string TechnicalName = default(string))
        {
            this.Id = Id;
            this.Name = Name;
            this.TechnicalName = TechnicalName;
        }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public Dictionary<string, string> Name { get; set; }

        /// <summary>
        /// TechnicalName
        /// </summary>
        /// <value>TechnicalName</value>
        [DataMember(Name="technicalName", EmitDefaultValue=false)]
        public string TechnicalName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookListenerEntity {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TechnicalName: ").Append(TechnicalName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
            return this.Equals(obj as WebhookListenerEntity);
        }

        /// <summary>
        /// Returns true if WebhookListenerEntity instances are equal
        /// </summary>
        /// <param name="other">Instance of WebhookListenerEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookListenerEntity other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.SequenceEqual(other.Name)
                ) && 
                (
                    this.TechnicalName == other.TechnicalName ||
                    this.TechnicalName != null &&
                    this.TechnicalName.Equals(other.TechnicalName)
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
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.TechnicalName != null)
                    hash = hash * 59 + this.TechnicalName.GetHashCode();
                return hash;
            }
        }

    }

}
