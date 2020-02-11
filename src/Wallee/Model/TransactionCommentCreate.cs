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
    /// TransactionCommentCreate
    /// </summary>
    [DataContract]
    public partial class TransactionCommentCreate : AbstractTransactionCommentActive,  IEquatable<TransactionCommentCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionCommentCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionCommentCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionCommentCreate" /> class.
        /// </summary>
        /// <param name="transaction">transaction (required).</param>
        public TransactionCommentCreate(long? transaction)
        {
            // to ensure "transaction" is required (not null)
            if (transaction == null)
            {
                throw new InvalidDataException("transaction is a required property for TransactionCommentCreate and cannot be null");
            }
            this.Transaction = transaction;
        }


        /// <summary>
        /// Gets or Sets Transaction
        /// </summary>
        [DataMember(Name="transaction", EmitDefaultValue=true)]
        public long? Transaction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionCommentCreate {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
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
            return this.Equals(input as TransactionCommentCreate);
        }

        /// <summary>
        /// Returns true if TransactionCommentCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionCommentCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionCommentCreate input)
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
                    this.Transaction == input.Transaction ||
                    (this.Transaction != null &&
                    this.Transaction.Equals(input.Transaction))
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
                if (this.Transaction != null)
                    hashCode = hashCode * 59 + this.Transaction.GetHashCode();
                return hashCode;
            }
        }

    }

}
