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
    public partial class PaymentTerminalTransactionSummaryFetchRequest :  IEquatable<PaymentTerminalTransactionSummaryFetchRequest>
    {
        /// <summary>
        /// The format determines in what format the receipt will be returned in.
        /// </summary>
        /// <value>The format determines in what format the receipt will be returned in.</value>
        [DataMember(Name="format", EmitDefaultValue=true)]
        public TerminalReceiptFormat Format { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTerminalTransactionSummaryFetchRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentTerminalTransactionSummaryFetchRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTerminalTransactionSummaryFetchRequest" /> class.
        /// </summary>
        /// <param name="format">The format determines in what format the receipt will be returned in. (required).</param>
        /// <param name="summaryId">The id of the transaction summary receipt whose content should be returned. (required).</param>
        public PaymentTerminalTransactionSummaryFetchRequest(TerminalReceiptFormat format, long? summaryId)
        {
            // to ensure "format" is required (not null)
            if (format == null)
            {
                throw new InvalidDataException("format is a required property for PaymentTerminalTransactionSummaryFetchRequest and cannot be null");
            }
            this.Format = format;
            // to ensure "summaryId" is required (not null)
            if (summaryId == null)
            {
                throw new InvalidDataException("summaryId is a required property for PaymentTerminalTransactionSummaryFetchRequest and cannot be null");
            }
            this.SummaryId = summaryId;
        }


        /// <summary>
        /// The id of the transaction summary receipt whose content should be returned.
        /// </summary>
        /// <value>The id of the transaction summary receipt whose content should be returned.</value>
        [DataMember(Name="summaryId", EmitDefaultValue=false)]
        public long? SummaryId { get; set; }

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
            sb.Append("class PaymentTerminalTransactionSummaryFetchRequest {\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  SummaryId: ").Append(SummaryId).Append("\n");
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
            return this.Equals(input as PaymentTerminalTransactionSummaryFetchRequest);
        }

        /// <summary>
        /// Returns true if PaymentTerminalTransactionSummaryFetchRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentTerminalTransactionSummaryFetchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentTerminalTransactionSummaryFetchRequest input)
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
                    this.SummaryId == input.SummaryId ||
                    (this.SummaryId != null &&
                    this.SummaryId.Equals(input.SummaryId))
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
                if (this.SummaryId != null)
                    hashCode = hashCode * 59 + this.SummaryId.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
                return hashCode;
            }
        }

    }

}
