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
    /// RefundCommentCreate
    /// </summary>
    [DataContract]
    public partial class RefundCommentCreate : AbstractRefundCommentActive,  IEquatable<RefundCommentCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundCommentCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RefundCommentCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundCommentCreate" /> class.
        /// </summary>
        /// <param name="refund">The refund that the comment belongs to. (required).</param>
        public RefundCommentCreate(long? refund)
        {
            // to ensure "refund" is required (not null)
            if (refund == null)
            {
                throw new InvalidDataException("refund is a required property for RefundCommentCreate and cannot be null");
            }
            this.Refund = refund;
        }


        /// <summary>
        /// The refund that the comment belongs to.
        /// </summary>
        /// <value>The refund that the comment belongs to.</value>
        [DataMember(Name="refund", EmitDefaultValue=false)]
        public long? Refund { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RefundCommentCreate {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Refund: ").Append(Refund).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as RefundCommentCreate);
        }

        /// <summary>
        /// Returns true if RefundCommentCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of RefundCommentCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RefundCommentCreate input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && base.Equals(input) && 
                (
                    this.Refund == input.Refund ||
                    (this.Refund != null &&
                    this.Refund.Equals(input.Refund))
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
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Refund != null)
                    hashCode = hashCode * 59 + this.Refund.GetHashCode();
                return hashCode;
            }
        }

    }

}
