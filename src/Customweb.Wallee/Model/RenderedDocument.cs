
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
    /// RenderedDocument model.
    /// </summary>
    [DataContract]
    public partial class RenderedDocument :  IEquatable<RenderedDocument>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenderedDocument" /> class.
        /// </summary>
        /// <param name="Data">Data</param>
        /// <param name="DocumentTemplateType">DocumentTemplateType</param>
        /// <param name="MimeType">MimeType</param>
        /// <param name="Title">Title</param>
        public RenderedDocument(List<byte[]> Data = default(List<byte[]>), long? DocumentTemplateType = default(long?), string MimeType = default(string), string Title = default(string))
        {
            this.Data = Data;
            this.DocumentTemplateType = DocumentTemplateType;
            this.MimeType = MimeType;
            this.Title = Title;
        }

        /// <summary>
        /// Data
        /// </summary>
        /// <value>Data</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<byte[]> Data { get; set; }

        /// <summary>
        /// DocumentTemplateType
        /// </summary>
        /// <value>DocumentTemplateType</value>
        [DataMember(Name="documentTemplateType", EmitDefaultValue=false)]
        public long? DocumentTemplateType { get; set; }

        /// <summary>
        /// MimeType
        /// </summary>
        /// <value>MimeType</value>
        [DataMember(Name="mimeType", EmitDefaultValue=false)]
        public string MimeType { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        /// <value>Title</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

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
            return this.Equals(obj as RenderedDocument);
        }

        /// <summary>
        /// Returns true if RenderedDocument instances are equal
        /// </summary>
        /// <param name="other">Instance of RenderedDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RenderedDocument other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(other.Data)
                ) && 
                (
                    this.DocumentTemplateType == other.DocumentTemplateType ||
                    this.DocumentTemplateType != null &&
                    this.DocumentTemplateType.Equals(other.DocumentTemplateType)
                ) && 
                (
                    this.MimeType == other.MimeType ||
                    this.MimeType != null &&
                    this.MimeType.Equals(other.MimeType)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
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
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                if (this.DocumentTemplateType != null)
                    hash = hash * 59 + this.DocumentTemplateType.GetHashCode();
                if (this.MimeType != null)
                    hash = hash * 59 + this.MimeType.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                return hash;
            }
        }

    }

}
