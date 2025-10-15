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
    /// TransactionInvoiceComment
    /// </summary>
    [DataContract]
    public partial class TransactionInvoiceComment :  IEquatable<TransactionInvoiceComment>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionInvoiceComment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public TransactionInvoiceComment()
        {
        }

        /// <summary>
        /// The comment&#39;s actual content.
        /// </summary>
        /// <value>The comment&#39;s actual content.</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; private set; }

        /// <summary>
        /// The ID of the user the comment was created by.
        /// </summary>
        /// <value>The ID of the user the comment was created by.</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public long? CreatedBy { get; private set; }

        /// <summary>
        /// The date and time when the object was created.
        /// </summary>
        /// <value>The date and time when the object was created.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// The ID of the user the comment was last updated by.
        /// </summary>
        /// <value>The ID of the user the comment was last updated by.</value>
        [DataMember(Name="editedBy", EmitDefaultValue=false)]
        public long? EditedBy { get; private set; }

        /// <summary>
        /// The date and time when the comment was last updated.
        /// </summary>
        /// <value>The date and time when the comment was last updated.</value>
        [DataMember(Name="editedOn", EmitDefaultValue=false)]
        public DateTime? EditedOn { get; private set; }

        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The ID of the space this object belongs to.
        /// </summary>
        /// <value>The ID of the space this object belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// Whether the comment is pinned to the top.
        /// </summary>
        /// <value>Whether the comment is pinned to the top.</value>
        [DataMember(Name="pinned", EmitDefaultValue=false)]
        public bool? Pinned { get; private set; }

        /// <summary>
        /// The transaction invoice that the comment belongs to.
        /// </summary>
        /// <value>The transaction invoice that the comment belongs to.</value>
        [DataMember(Name="transactionInvoice", EmitDefaultValue=false)]
        public long? TransactionInvoice { get; private set; }

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
            sb.Append("class TransactionInvoiceComment {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  EditedBy: ").Append(EditedBy).Append("\n");
            sb.Append("  EditedOn: ").Append(EditedOn).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  Pinned: ").Append(Pinned).Append("\n");
            sb.Append("  TransactionInvoice: ").Append(TransactionInvoice).Append("\n");
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
            return this.Equals(input as TransactionInvoiceComment);
        }

        /// <summary>
        /// Returns true if TransactionInvoiceComment instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionInvoiceComment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionInvoiceComment input)
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
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && 
                (
                    this.EditedBy == input.EditedBy ||
                    (this.EditedBy != null &&
                    this.EditedBy.Equals(input.EditedBy))
                ) && 
                (
                    this.EditedOn == input.EditedOn ||
                    (this.EditedOn != null &&
                    this.EditedOn.Equals(input.EditedOn))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LinkedSpaceId == input.LinkedSpaceId ||
                    (this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(input.LinkedSpaceId))
                ) && 
                (
                    this.Pinned == input.Pinned ||
                    (this.Pinned != null &&
                    this.Pinned.Equals(input.Pinned))
                ) && 
                (
                    this.TransactionInvoice == input.TransactionInvoice ||
                    (this.TransactionInvoice != null &&
                    this.TransactionInvoice.Equals(input.TransactionInvoice))
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
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.EditedBy != null)
                    hashCode = hashCode * 59 + this.EditedBy.GetHashCode();
                if (this.EditedOn != null)
                    hashCode = hashCode * 59 + this.EditedOn.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.Pinned != null)
                    hashCode = hashCode * 59 + this.Pinned.GetHashCode();
                if (this.TransactionInvoice != null)
                    hashCode = hashCode * 59 + this.TransactionInvoice.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
