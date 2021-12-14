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
    /// The receipt fetch request allows to retrieve the receipt documents for a terminal transaction.
    /// </summary>
    [DataContract]
    public partial class TerminalReceiptFetchRequest :  IEquatable<TerminalReceiptFetchRequest>
    {
        /// <summary>
        /// The format determines in what format the receipts will be returned in.
        /// </summary>
        /// <value>The format determines in what format the receipts will be returned in.</value>
        [DataMember(Name="format", EmitDefaultValue=true)]
        public TerminalReceiptFormat Format { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TerminalReceiptFetchRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TerminalReceiptFetchRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TerminalReceiptFetchRequest" /> class.
        /// </summary>
        /// <param name="format">The format determines in what format the receipts will be returned in. (required).</param>
        /// <param name="transaction">Provide here the ID of the transaction for which the receipts should be fetched. (required).</param>
        public TerminalReceiptFetchRequest(TerminalReceiptFormat format, long? transaction)
        {
            // to ensure "format" is required (not null)
            if (format == null)
            {
                throw new InvalidDataException("format is a required property for TerminalReceiptFetchRequest and cannot be null");
            }
            this.Format = format;
            // to ensure "transaction" is required (not null)
            if (transaction == null)
            {
                throw new InvalidDataException("transaction is a required property for TerminalReceiptFetchRequest and cannot be null");
            }
            this.Transaction = transaction;
        }


        /// <summary>
        /// Provide here the ID of the transaction for which the receipts should be fetched.
        /// </summary>
        /// <value>Provide here the ID of the transaction for which the receipts should be fetched.</value>
        [DataMember(Name="transaction", EmitDefaultValue=false)]
        public long? Transaction { get; set; }

        /// <summary>
        /// The width controls how width the document will be rendered. In case of the PDF format the width is in mm. In case of the text format the width is in the number of chars per line.
        /// </summary>
        /// <value>The width controls how width the document will be rendered. In case of the PDF format the width is in mm. In case of the text format the width is in the number of chars per line.</value>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public int? Width { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TerminalReceiptFetchRequest {\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
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
            return this.Equals(input as TerminalReceiptFetchRequest);
        }

        /// <summary>
        /// Returns true if TerminalReceiptFetchRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TerminalReceiptFetchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TerminalReceiptFetchRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
                ) && 
                (
                    this.Transaction == input.Transaction ||
                    (this.Transaction != null &&
                    this.Transaction.Equals(input.Transaction))
                ) && 
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
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
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.Transaction != null)
                    hashCode = hashCode * 59 + this.Transaction.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
                return hashCode;
            }
        }

    }

}
