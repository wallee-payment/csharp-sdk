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
    /// TransactionInvoiceCommentCreate
    /// </summary>
    [DataContract]
    public partial class TransactionInvoiceCommentCreate : AbstractTransactionInvoiceCommentActive,  IEquatable<TransactionInvoiceCommentCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionInvoiceCommentCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionInvoiceCommentCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionInvoiceCommentCreate" /> class.
        /// </summary>
        /// <param name="transactionInvoice">transactionInvoice (required).</param>
        public TransactionInvoiceCommentCreate(long? transactionInvoice)
        {
            // to ensure "transactionInvoice" is required (not null)
            if (transactionInvoice == null)
            {
                throw new InvalidDataException("transactionInvoice is a required property for TransactionInvoiceCommentCreate and cannot be null");
            }
            this.TransactionInvoice = transactionInvoice;
        }


        /// <summary>
        /// Gets or Sets TransactionInvoice
        /// </summary>
        [DataMember(Name="transactionInvoice", EmitDefaultValue=false)]
        public long? TransactionInvoice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionInvoiceCommentCreate {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  TransactionInvoice: ").Append(TransactionInvoice).Append("\n");
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
            return this.Equals(input as TransactionInvoiceCommentCreate);
        }

        /// <summary>
        /// Returns true if TransactionInvoiceCommentCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionInvoiceCommentCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionInvoiceCommentCreate input)
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
                    this.TransactionInvoice == input.TransactionInvoice ||
                    (this.TransactionInvoice != null &&
                    this.TransactionInvoice.Equals(input.TransactionInvoice))
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
                if (this.TransactionInvoice != null)
                    hashCode = hashCode * 59 + this.TransactionInvoice.GetHashCode();
                return hashCode;
            }
        }

    }

}
