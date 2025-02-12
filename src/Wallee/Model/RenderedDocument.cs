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
    /// RenderedDocument
    /// </summary>
    [DataContract]
    public partial class RenderedDocument :  IEquatable<RenderedDocument>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenderedDocument" /> class.
        /// </summary>
        public RenderedDocument()
        {
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public byte[] Data { get; set; }

        /// <summary>
        /// The document&#39;s template type
        /// </summary>
        /// <value>The document&#39;s template type</value>
        [DataMember(Name="documentTemplateType", EmitDefaultValue=false)]
        public long? DocumentTemplateType { get; private set; }

        /// <summary>
        /// The document&#39;s content type
        /// </summary>
        /// <value>The document&#39;s content type</value>
        [DataMember(Name="mimeType", EmitDefaultValue=false)]
        public string MimeType { get; private set; }

        /// <summary>
        /// The title of the rendered document
        /// </summary>
        /// <value>The title of the rendered document</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RenderedDocument {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  DocumentTemplateType: ").Append(DocumentTemplateType).Append("\n");
            sb.Append("  MimeType: ").Append(MimeType).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as RenderedDocument);
        }

        /// <summary>
        /// Returns true if RenderedDocument instances are equal
        /// </summary>
        /// <param name="input">Instance of RenderedDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RenderedDocument input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.DocumentTemplateType == input.DocumentTemplateType ||
                    (this.DocumentTemplateType != null &&
                    this.DocumentTemplateType.Equals(input.DocumentTemplateType))
                ) && 
                (
                    this.MimeType == input.MimeType ||
                    (this.MimeType != null &&
                    this.MimeType.Equals(input.MimeType))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.DocumentTemplateType != null)
                    hashCode = hashCode * 59 + this.DocumentTemplateType.GetHashCode();
                if (this.MimeType != null)
                    hashCode = hashCode * 59 + this.MimeType.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                return hashCode;
            }
        }

    }

}
