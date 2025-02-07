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
        /// The label&#39;s actual content.
        /// </summary>
        /// <value>The label&#39;s actual content.</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public Object Content { get; private set; }

        /// <summary>
        /// The label&#39;s content formatted as string.
        /// </summary>
        /// <value>The label&#39;s content formatted as string.</value>
        [DataMember(Name="contentAsString", EmitDefaultValue=false)]
        public string ContentAsString { get; private set; }

        /// <summary>
        /// The descriptor that describes what information the label provides.
        /// </summary>
        /// <value>The descriptor that describes what information the label provides.</value>
        [DataMember(Name="descriptor", EmitDefaultValue=false)]
        public LabelDescriptor Descriptor { get; private set; }

        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The version is used for optimistic locking and incremented whenever the object is updated.
        /// </summary>
        /// <value>The version is used for optimistic locking and incremented whenever the object is updated.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Label {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  ContentAsString: ").Append(ContentAsString).Append("\n");
            sb.Append("  Descriptor: ").Append(Descriptor).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as Label);
        }

        /// <summary>
        /// Returns true if Label instances are equal
        /// </summary>
        /// <param name="input">Instance of Label to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Label input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.ContentAsString == input.ContentAsString ||
                    (this.ContentAsString != null &&
                    this.ContentAsString.Equals(input.ContentAsString))
                ) && 
                (
                    this.Descriptor == input.Descriptor ||
                    (this.Descriptor != null &&
                    this.Descriptor.Equals(input.Descriptor))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.ContentAsString != null)
                    hashCode = hashCode * 59 + this.ContentAsString.GetHashCode();
                if (this.Descriptor != null)
                    hashCode = hashCode * 59 + this.Descriptor.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
