
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
    /// The attachment resource allows the attachment of resources to emails.
    /// </summary>
    [DataContract]
    public partial class AttachmentResource :  IEquatable<AttachmentResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentResource" /> class.
        /// </summary>
        /// <param name="AttachmentName">The name of the attachment which is shown to the user within the email client.</param>
        /// <param name="ResourcePath">The path to the resource which should be attached to the email.</param>
        public AttachmentResource(Dictionary<string, string> AttachmentName = default(Dictionary<string, string>), ResourcePath ResourcePath = default(ResourcePath))
        {
            this.AttachmentName = AttachmentName;
            this.ResourcePath = ResourcePath;
        }

        /// <summary>
        /// The name of the attachment which is shown to the user within the email client.
        /// </summary>
        /// <value>The name of the attachment which is shown to the user within the email client.</value>
        [DataMember(Name="attachmentName", EmitDefaultValue=false)]
        public Dictionary<string, string> AttachmentName { get; set; }

        /// <summary>
        /// The path to the resource which should be attached to the email.
        /// </summary>
        /// <value>The path to the resource which should be attached to the email.</value>
        [DataMember(Name="resourcePath", EmitDefaultValue=false)]
        public ResourcePath ResourcePath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachmentResource {\n");
            sb.Append("  AttachmentName: ").Append(AttachmentName).Append("\n");
            sb.Append("  ResourcePath: ").Append(ResourcePath).Append("\n");
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
            return this.Equals(obj as AttachmentResource);
        }

        /// <summary>
        /// Returns true if AttachmentResource instances are equal
        /// </summary>
        /// <param name="other">Instance of AttachmentResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttachmentResource other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.AttachmentName == other.AttachmentName ||
                    this.AttachmentName != null &&
                    this.AttachmentName.SequenceEqual(other.AttachmentName)
                ) && 
                (
                    this.ResourcePath == other.ResourcePath ||
                    this.ResourcePath != null &&
                    this.ResourcePath.Equals(other.ResourcePath)
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
                if (this.AttachmentName != null)
                    hash = hash * 59 + this.AttachmentName.GetHashCode();
                if (this.ResourcePath != null)
                    hash = hash * 59 + this.ResourcePath.GetHashCode();
                return hash;
            }
        }

    }

}
