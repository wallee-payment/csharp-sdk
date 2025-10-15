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
    /// RenderedTerminalReceipt
    /// </summary>
    [DataContract]
    public partial class RenderedTerminalReceipt :  IEquatable<RenderedTerminalReceipt>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenderedTerminalReceipt" /> class.
        /// </summary>
        public RenderedTerminalReceipt()
        {
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public byte[] Data { get; set; }

        /// <summary>
        /// The MIME type specifies the format of the receipt document and is determined by the requested format.
        /// </summary>
        /// <value>The MIME type specifies the format of the receipt document and is determined by the requested format.</value>
        [DataMember(Name="mimeType", EmitDefaultValue=false)]
        public string MimeType { get; private set; }

        /// <summary>
        /// Whether the terminal&#39;s configuration mandates printing and the device has receipt printing capabilities.
        /// </summary>
        /// <value>Whether the terminal&#39;s configuration mandates printing and the device has receipt printing capabilities.</value>
        [DataMember(Name="printed", EmitDefaultValue=false)]
        public bool? Printed { get; private set; }

        /// <summary>
        /// The receipt type specifies the intended use and the target audience of the document.
        /// </summary>
        /// <value>The receipt type specifies the intended use and the target audience of the document.</value>
        [DataMember(Name="receiptType", EmitDefaultValue=false)]
        public PaymentTerminalReceiptType ReceiptType { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RenderedTerminalReceipt {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  MimeType: ").Append(MimeType).Append("\n");
            sb.Append("  Printed: ").Append(Printed).Append("\n");
            sb.Append("  ReceiptType: ").Append(ReceiptType).Append("\n");
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
            return this.Equals(input as RenderedTerminalReceipt);
        }

        /// <summary>
        /// Returns true if RenderedTerminalReceipt instances are equal
        /// </summary>
        /// <param name="input">Instance of RenderedTerminalReceipt to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RenderedTerminalReceipt input)
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
                    this.MimeType == input.MimeType ||
                    (this.MimeType != null &&
                    this.MimeType.Equals(input.MimeType))
                ) && 
                (
                    this.Printed == input.Printed ||
                    (this.Printed != null &&
                    this.Printed.Equals(input.Printed))
                ) && 
                (
                    this.ReceiptType == input.ReceiptType ||
                    (this.ReceiptType != null &&
                    this.ReceiptType.Equals(input.ReceiptType))
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
                if (this.MimeType != null)
                    hashCode = hashCode * 59 + this.MimeType.GetHashCode();
                if (this.Printed != null)
                    hashCode = hashCode * 59 + this.Printed.GetHashCode();
                if (this.ReceiptType != null)
                    hashCode = hashCode * 59 + this.ReceiptType.GetHashCode();
                return hashCode;
            }
        }

    }

}
